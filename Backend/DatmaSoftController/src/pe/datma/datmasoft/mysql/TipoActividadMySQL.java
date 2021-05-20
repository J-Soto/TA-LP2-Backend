/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.mysql;

import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.TipoActividadDAO;
import pe.datma.datmasoft.logistica.TipoActividad;

import java.sql.*;

/**
 *
 * @author JLHP
 */
public class TipoActividadMySQL implements TipoActividadDAO {
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<TipoActividad> listar() {
        ArrayList<TipoActividad> tipoActividades = new ArrayList<TipoActividad>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_TIPOACTIVIDAD()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoActividad tipoactividad = new TipoActividad();
                tipoactividad.setIdTipoActividad(rs.getInt("idtipoactividad"));
                tipoactividad.setDescripcion(rs.getString("descripcion"));
                tipoactividad.setSincrono(rs.getInt("sincrono"));
                tipoActividades.add(tipoactividad);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return tipoActividades;
    }

    @Override
    public int insertar(TipoActividad tipoActividad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_TIPOACTIVIDAD(?,?,?)}");
            cs.registerOutParameter("_id_tipoactividad", java.sql.Types.INTEGER);
            cs.setString("_descripcion", tipoActividad.getDescripcion());
            cs.setInt("_sincrono", tipoActividad.getSincrono());
            cs.executeUpdate();
            tipoActividad.setIdTipoActividad(cs.getInt("_id_tipoactividad"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(TipoActividad tipoActividad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_TIPOACTIVIDAD(?,?,?)}");
            cs.setInt("_id_tipoactividad", tipoActividad.getIdTipoActividad());
            cs.setString("_descripcion", tipoActividad.getDescripcion());
            cs.setInt("_sincrono", tipoActividad.getSincrono());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int eliminar(int idTipoActividad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_TIPOACTIVIDAD(?)}");
            cs.setInt("_id_tipoactividad", idTipoActividad);
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    
}
