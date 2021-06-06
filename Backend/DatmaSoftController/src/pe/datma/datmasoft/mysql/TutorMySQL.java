package pe.datma.datmasoft.mysql;

import pe.datma.datmasoft.config.DBManager;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.dao.TutorDAO;
import pe.datma.datmasoft.rrhh.Tutor;

public class TutorMySQL implements TutorDAO {
    Connection con;
    PreparedStatement st;
    ResultSet rs;

    @Override
    public ArrayList<Tutor> listar() {
        return listar(-1);
    }

    @Override
    public ArrayList<Tutor> listar(int idCuidador) {
        ArrayList<Tutor> arr = new ArrayList<>();
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
                Tutor cui = new Tutor();
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
