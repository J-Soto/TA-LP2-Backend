package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.AsistenciaDAO;
import pe.datma.datmasoft.modulos.Asistencia;

/*
Table: asistencia
Columns:
idasistencia int AI PK 
fidusuario int 
fidactividad int 
descripcion varchar(250) 
activo int 
tipoasistencia int
*/

public class AsistenciaMySQL implements AsistenciaDAO {
    Connection con;
    CallableStatement cst;
    ResultSet rs;

    @Override
    public int insertarAsistencia(Asistencia asistencia) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call INSERTAR_ASISTENCIA(?,?,?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.registerOutParameter("_idasistencia", java.sql.Types.INTEGER);
            cst.setInt("_fidusuario", asistencia.getUsuario().getIdUsuario());
            cst.setInt("_fidactividad", asistencia.getActividad().getIdActividad());
            cst.setString("_descripcion", asistencia.getDescripcion());
            cst.setInt("_tipoasistencia", asistencia.getTipo());
            
            cst.executeUpdate();
            asistencia.setId(cst.getInt("_idasistencia"));
            resultado = 1;
        } catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        } finally{
            try{ cst.close(); }catch(SQLException ex){}
            try{ con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }

    @Override
    public int modificarAsistencia(Asistencia asistencia) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call MODIFICAR_ASISTENCIA(?,?,?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.setInt("_idasistencia", asistencia.getId());
            cst.setInt("_fidusuario", asistencia.getUsuario().getIdUsuario());
            cst.setInt("_fidactividad", asistencia.getActividad().getIdActividad());
            cst.setString("_descripcion", asistencia.getDescripcion());
            cst.setInt("_tipoasistencia", asistencia.getTipo());
            
            cst.executeUpdate();
            resultado = 1;
        } catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        } finally{
            try{ cst.close(); }catch(SQLException ex){}
            try{ con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }

    @Override
    public ArrayList<Asistencia> listarAsistencia() {
        ArrayList<Asistencia> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call LISTAR_ASISTENCIA()}";
            cst = con.prepareCall(query);
            rs = cst.executeQuery();
            while (rs.next()) {
                Asistencia asistencia = new Asistencia();
                asistencia.setId(rs.getInt("idasistencia"));
                asistencia.setDescripcion(rs.getString("descripcion"));
                asistencia.setTipo(rs.getInt("tipoasistencia"));
                // TODO: falta setear usuario y actividad
                arr.add(asistencia);
            }
        } catch(ClassNotFoundException | SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            try { rs.close(); } catch (SQLException ex) {}
            try { cst.close(); } catch (SQLException ex) {}
            try { con.close(); } catch (SQLException ex) {}
        }
        return arr;
    }
    
}
