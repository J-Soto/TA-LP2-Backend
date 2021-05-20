/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.mysql;

import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.RedSocialDAO;
import pe.datma.datmasoft.util.RedSocial;

import java.sql.*;

/**
 *
 * @author JLHP
 */
public class RedSocialMySQL implements RedSocialDAO {
    Connection con;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<RedSocial> listar() {
        ArrayList<RedSocial> redesSociales = new ArrayList<RedSocial>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_EMPLEADOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                RedSocial redSocial = new RedSocial();
                redSocial.setIdRedSocial(rs.getInt("idredsocial"));
                redSocial.setNombre(rs.getString("nombre"));
                redesSociales.add(redSocial);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return redesSociales;
    }

    @Override
    public int insertar(RedSocial redSocial) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_REDSOCIAL(?,?)}");
            cs.registerOutParameter("_id_redsocial", java.sql.Types.INTEGER);
            cs.setString("_nombre", redSocial.getNombre());
            cs.executeUpdate();
            redSocial.setIdRedSocial(cs.getInt("_id_redsocial"));
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
    public int modificar(RedSocial redSocial) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_REDSOCIAL(?,?)}");
            cs.setInt("_id_redsocial", redSocial.getIdRedSocial());
            cs.setString("_nombre", redSocial.getNombre());
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
    public int eliminar(int idRedSocial) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_REDSOCIAL(?)}");
            cs.setInt("_id_redsocial", idRedSocial);
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
