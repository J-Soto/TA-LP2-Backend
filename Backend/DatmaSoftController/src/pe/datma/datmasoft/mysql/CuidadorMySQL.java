package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.CuidadorDAO;
import pe.datma.datmasoft.rrhh.Cuidador;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

public class CuidadorMySQL implements CuidadorDAO {
    Connection con;
    PreparedStatement st;
    ResultSet rs;

    @Override
    public ArrayList<Cuidador> listar() {
        return listar(-1);
    }

    @Override
    public ArrayList<Cuidador> listar(int idCuidador) {
        ArrayList<Cuidador> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query;
            if (idCuidador == -1) {
                query = "select * from cuidador where activo = 1";
                st = con.prepareStatement(query);
            } else {
                query = "select * from cuidador where activo = 1 and fidpersona = ?";
                st = con.prepareStatement(query);
                st.setInt(1,idCuidador);
            }
            rs = st.executeQuery();
            while (rs.next()) {
                Cuidador cui = new Cuidador();
                cui.setGestante(rs.getBoolean("gestante"));
                cui.setBajosRecursos(rs.getBoolean("bajosrecursos"));
                arr.add(cui);
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
