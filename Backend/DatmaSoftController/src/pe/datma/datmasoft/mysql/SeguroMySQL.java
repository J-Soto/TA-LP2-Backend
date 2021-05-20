/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.mysql;

import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.SeguroDAO;
import pe.datma.datmasoft.rrhh.Seguro;

import java.sql.*;

/**
 *
 * @author JLHP
 */
public class SeguroMySQL implements SeguroDAO {
    Connection con;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Seguro> listar() {
        ArrayList<Seguro> seguros = new ArrayList<Seguro>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_SEGURO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Seguro seguro = new Seguro();
                seguro.setIdSeguro(rs.getInt("idseguro"));
                seguro.setProveedor(rs.getString("proveedor"));
                seguros.add(seguro);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return seguros;
    }

    @Override
    public int insertar(Seguro seguro) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_SEGURO(?,?)}");
            cs.registerOutParameter("_id_seguro", java.sql.Types.INTEGER);
            cs.setString("_proveedor", seguro.getProveedor());
            cs.executeUpdate();
            seguro.setIdSeguro(cs.getInt("_id_seguro"));
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
    public int modificar(Seguro seguro) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_SEGURO(?,?)}");
            cs.setInt("_id_seguro", seguro.getIdSeguro());
            cs.setString("_proveedor", seguro.getProveedor());
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
    public int eliminar(int idSeguro) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_SEGURO(?)}");
            cs.setInt("_id_seguro", idSeguro);
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
