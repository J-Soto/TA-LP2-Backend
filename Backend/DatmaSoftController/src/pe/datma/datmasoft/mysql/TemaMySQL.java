package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.cursos.Eje;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.dao.TemaDAO;

public class TemaMySQL implements TemaDAO {
    Connection con;
    PreparedStatement st;
    ResultSet rs;

    @Override
    public ArrayList<Eje> listar() {
        return listar(-1);
    }

    @Override
    public ArrayList<Eje> listar(int idEje) {
        ArrayList<Eje> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query;
            if (idEje == -1) {
                query = "select * from eje where activo = 1";
                st = con.prepareStatement(query);
            } else {
                query = "select * from eje where activo = 1 and ideje = ?";
                st = con.prepareStatement(query);
                st.setInt(1,idEje);
            }
            rs = st.executeQuery();
            while (rs.next()) {
                Eje eje = new Eje();
                eje.setId(rs.getInt("ideje"));
                eje.setNombre(rs.getString("nombre"));
                arr.add(eje);
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
