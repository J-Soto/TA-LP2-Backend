/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.UsuarioDAO;
import pe.datma.datmasoft.rrhh.Usuario;

/**
 *
 * @author JLHP
 */
public class UsuarioMySQL implements UsuarioDAO{
    
    Connection con;
    CallableStatement cs;
    ResultSet rs;

    @Override
    public int insertarUsuario(Usuario user) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Usuario> listarUsuarios() {
        ArrayList<Usuario> usuarios = new ArrayList<Usuario>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_USUARIOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Usuario usuario = new Usuario();
                usuario.setIdUsuario(rs.getInt("idusuario"));
                usuario.setUser(rs.getString("user"));
                usuario.setPassword(rs.getString("password"));
                usuario.setTipo(rs.getInt("tipo"));
                usuario.setFotoPerfil(rs.getBytes("foto"));
                usuario.setActivo(rs.getInt("activo"));
                usuarios.add(usuario);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return usuarios;
    }
    
}
