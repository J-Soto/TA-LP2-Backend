package pe.datma.datmasoft.mysql;

import org.apache.commons.dbutils.DbUtils;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.cursos.actividades.asincrona.Material;
import pe.datma.datmasoft.dao.MaterialDAO;

import java.sql.*;
import java.util.ArrayList;

public class MaterialMySQL implements MaterialDAO {
    Connection con;
    CallableStatement cs;
    ResultSet rs;

    @Override
    public int insertar(Material material) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call insertar_material(?,?,?,?)}";
            cs = con.prepareCall(query);
            cs.registerOutParameter("_id_material", java.sql.Types.INTEGER);
            cs.setString("_tipoarchivo", material.getTipo());
            cs.setString("_link", material.getLink());
            cs.setString("_descripcion", material.getDescripcion());
            cs.executeUpdate();
            res = 1;
            material.setId(cs.getInt("_id_material"));
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            DbUtils.closeQuietly(cs);
            DbUtils.closeQuietly(con);
        }
        return res;
    }

    @Override
    public int modificar(Material material) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call modificar_material(?,?,?,?)}";
            cs = con.prepareCall(query);
            cs.setInt("_id_material", material.getId());
            cs.setString("_tipoarchivo", material.getTipo());
            cs.setString("_link", material.getLink());
            cs.setString("_descripcion", material.getDescripcion());
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
    public int eliminar(int idMaterial) {
        int res = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call eliminar_material(?)}";
            cs = con.prepareCall(query);
            cs.setInt("_id_material", idMaterial);
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
    public ArrayList<Material> listar() {
        ArrayList<Material> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            String query = "{call listar_material()}";
            cs = con.prepareCall(query);
            rs = cs.executeQuery();
            while (rs.next()) {
                Material material = new Material();
                material.setId(rs.getInt("idmaterial"));
                material.setLink(rs.getString("link"));
                material.setTipo(rs.getString("tipoarchivo"));
                material.setDescripcion(rs.getString("descripcion"));
                arr.add(material);
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
