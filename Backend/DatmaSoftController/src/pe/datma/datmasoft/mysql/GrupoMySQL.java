package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.GrupoDAO;
import pe.datma.datmasoft.familias.Grupo;

import java.sql.*;
import java.util.ArrayList;

public class GrupoMySQL implements GrupoDAO {
    Connection con;
    CallableStatement cs;
    ResultSet rs;

    @Override
    public int insertar(Grupo grupo, int idModulo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call insertar_grupo(?,?,?)}";
            cs = con.prepareCall(query);
            cs.registerOutParameter("_id_grupo", java.sql.Types.INTEGER);
            cs.setInt("_id_modulo", idModulo);
            cs.setString("_nombre", grupo.getNombrePromocion());
            cs.executeUpdate();
            res = 1;
            grupo.setId(cs.getInt("_id_grupo"));
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(cs);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public int modificar(Grupo grupo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call modificar_grupo(?,?)}";
            cs = con.prepareCall(query);
            cs.setInt("_id_grupo", grupo.getId());
            cs.setString("_nombre", grupo.getNombrePromocion());
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
    public int eliminar(int idGrupo) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call eliminar_grupo(?)}";
            cs = con.prepareCall(query);
            cs.setInt("_id_grupo", idGrupo);
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
    public ArrayList<Grupo> listar(int idGrupo) {
        ArrayList<Grupo> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call listar_grupo()}";
            cs = con.prepareCall(query);
            rs = cs.executeQuery();
            while (rs.next()) {
                Grupo grupo = new Grupo();
                grupo.setId(rs.getInt("idgrupo"));
                grupo.setNombrePromocion(rs.getString("nombre"));
                grupo.setFidmodulo(rs.getInt("fidmodulo"));
                arr.add(grupo);
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
