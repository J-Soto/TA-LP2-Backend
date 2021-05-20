package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.cursos.Modulo;
import pe.datma.datmasoft.dao.ModuloDAO;

import java.sql.*;
import java.util.ArrayList;

public class ModuloMySQL implements ModuloDAO {
    Connection con;
    CallableStatement cs;
    ResultSet rs;

    @Override
    public int insertar(Modulo modulo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call insertar_modulo(?,?,?)}";
            cs = con.prepareCall(query);
            cs.registerOutParameter("_id_modulo", java.sql.Types.INTEGER);
            cs.setDate("_fechainicial", new java.sql.Date(modulo.getFechaInicial().getTime()));
            cs.setDate("_fechafinal", new java.sql.Date(modulo.getFechaFinal().getTime()));
            cs.executeUpdate();
            res = 1;
            modulo.setId(cs.getInt("_id_modulo"));
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(cs);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public int modificar(Modulo modulo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call modificar_modulo(?,?,?)}";
            cs = con.prepareCall(query);
            cs.setInt("_id_modulo", modulo.getId());
            cs.setDate("_fechainicial", new java.sql.Date(modulo.getFechaInicial().getTime()));
            cs.setDate("_fechafinal", new java.sql.Date(modulo.getFechaFinal().getTime()));
            cs.executeUpdate();
            res = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(cs);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public int eliminar(int idModulo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call eliminar_modulo(?)}";
            cs = con.prepareCall(query);
            cs.setInt("_id_modulo", idModulo);
            cs.executeUpdate();
            res = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(cs);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public ArrayList<Modulo> listar(int idModulo) {
        ArrayList<Modulo> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call listar_modulo()}";
            cs = con.prepareCall(query);
            rs = cs.executeQuery();
            while (rs.next()) {
                Modulo modulo = new Modulo();
                modulo.setId(rs.getInt("idmodulo"));
                modulo.setFechaInicial(rs.getDate("fechainicial"));
                modulo.setFechaFinal(rs.getDate("fechafinal"));
                arr.add(modulo);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(rs);
            DbUtils.closeQuietly(cs);
            DbUtils.closeQuietly(con);
        }
        return arr;
    }
}
