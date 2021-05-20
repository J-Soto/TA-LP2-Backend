/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.mysql;

import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.TipoAsistenciaDAO;
import pe.datma.datmasoft.logistica.TipoAsistencia;

import java.sql.*;

/**
 *
 * @author JLHP
 */
public class TipoAsistenciaMySQL implements TipoAsistenciaDAO {
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<TipoAsistencia> listar() {
        ArrayList<TipoAsistencia> tipoAsistencias = new ArrayList<TipoAsistencia>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_TIPOASISTENCIA()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoAsistencia tipoasistencia=new TipoAsistencia();
                tipoasistencia.setIdTipoAsistencia(rs.getInt("idtipoasistencia"));
                tipoasistencia.setDescripcion(rs.getString("descripcion"));
                tipoAsistencias.add(tipoasistencia);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return tipoAsistencias;
    }

    @Override
    public int insertar(TipoAsistencia tipoAsistencia) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_TIPOASISTENCIA(?,?)}");
            cs.registerOutParameter("_id_tipoasistencia", java.sql.Types.INTEGER);
            cs.setString("_descripcion", tipoAsistencia.getDescripcion());
            cs.executeUpdate();
            tipoAsistencia.setIdTipoAsistencia(cs.getInt("_id_tipoasistencia"));
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
    public int modificar(TipoAsistencia tipoAsistencia) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_TIPOASISTENCIA(?,?)}");
            cs.setInt("_id_tipoasistencia", tipoAsistencia.getIdTipoAsistencia());
            cs.setString("_descripcion", tipoAsistencia.getDescripcion());
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
    public int eliminar(int idTipoAsistencia) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_TIPOASISTENCIA(?)}");
            cs.setInt("_id_tipoasistencia", idTipoAsistencia);
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
