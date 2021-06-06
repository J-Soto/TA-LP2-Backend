package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.cursos.actividades.sincrona.Actividad;
import pe.datma.datmasoft.dao.ActividadDAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

public class ActividadMySQL implements ActividadDAO {
    Connection con;
    PreparedStatement st;
    ResultSet rs;

    @Override
    public ArrayList<Actividad> listar() {
        return listar(-1);
    }

    @Override
    public ArrayList<Actividad> listar(int idActividad) {
        ArrayList<Actividad> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query;
            if (idActividad == -1) {
                query = "select * from actividad where activo = 1";
                st = con.prepareStatement(query);
            } else {
                query = "select * from actividad where activo = 1 and idactividad = ?";
                st = con.prepareStatement(query);
                st.setInt(1,idActividad);
            }
            rs = st.executeQuery();
            while (rs.next()) {
                Actividad act = new Actividad();
                act.setNombre(rs.getString("nombre"));
                act.setFecha(rs.getDate("fechaInicial"));
                act.setHoraFin(rs.getTime("horafin").toLocalTime());
                act.setHoraInicio(rs.getTime("horainicio").toLocalTime());
                arr.add(act);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(rs);
            DbUtils.closeQuietly(st);
            DbUtils.closeQuietly(con);
        }
        return arr;
    }
}
