package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.InfanteCuidadorDAO;
import pe.datma.datmasoft.rrhh.Cuidador;
import pe.datma.datmasoft.rrhh.Infante;

import java.sql.*;
import java.util.ArrayList;

public class InfanteCuidadorMySQL implements InfanteCuidadorDAO {
    Connection con;
    PreparedStatement st;
    ResultSet rs;

    @Override
    public int insertar(int idInfante, int idCuidador) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "insert into niño_cuidador(fidniño, fidcuidador) values (?,?)";
            st = con.prepareStatement(query);
            st.setInt(1, idInfante);
            st.setInt(2, idCuidador);
            res = st.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(st);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public int eliminarInfante(int idInfante) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "update niño_cuidador set activo = 0 where fidniño = ?";
            st = con.prepareStatement(query);
            st.setInt(1, idInfante);
            res = st.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(st);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public int eliminarCuidador(int idCuidador) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "update niño_cuidador set activo = 0 where fidcuidador = ?";
            st = con.prepareStatement(query);
            st.setInt(1, idCuidador);
            res = st.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(st);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public ArrayList<Cuidador> listarCuidadores(int idInfante) {
        ArrayList<Cuidador> arr = new ArrayList<>();
        CuidadorMySQL cuisql = new CuidadorMySQL();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "select * from niño_cuidador where activo = 1 and fidniño = ?";
            st = con.prepareStatement(query);
            st.setInt(1, idInfante);
            rs = st.executeQuery();
            while (rs.next()) {
                arr.add(cuisql.listar(rs.getInt("fidcuidador")).get(0));
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

    @Override
    public ArrayList<Infante> listarInfantes(int idCuidador) {
        ArrayList<Infante> arr = new ArrayList<>();
        InfanteMySQL infsql = new InfanteMySQL();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "select * from niño_cuidador where activo = 1 and fidcuidador = ?";
            st = con.prepareStatement(query);
            st.setInt(1, idCuidador);
            rs = st.executeQuery();
            while (rs.next()) {
                arr.add(infsql.listar(rs.getInt("fidniño")).get(0));
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
