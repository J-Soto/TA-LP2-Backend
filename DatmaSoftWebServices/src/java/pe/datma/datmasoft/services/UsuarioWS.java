/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.datma.datmasoft.dao.UsuarioDAO;
import pe.datma.datmasoft.mysql.UsuarioMySQL;
import pe.datma.datmasoft.rrhh.Usuario;

/**
 *
 * @author JLHP
 */
@WebService(serviceName = "UsuarioWS")
public class UsuarioWS {

    /**
     * This is a sample web service operation
     */
    private UsuarioDAO daoUsuario;

    public UsuarioWS() {
        this.daoUsuario = new UsuarioMySQL();
    }
    
    @WebMethod(operationName = "listarUsuarios")
    public ArrayList<Usuario> listarUsuarios() {
        ArrayList<Usuario> usuarios=new ArrayList<Usuario>();
        try {
            usuarios=daoUsuario.listarUsuarios();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return usuarios;
    }
    
    @WebMethod(operationName = "insertarUsuario")
    public int insertarUsuario(@WebParam(name = "usuario") Usuario user) {
        int resultado=0;
        try {
            resultado=daoUsuario.insertarUsuario(user);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "verificarUsuario")
    public Usuario verificarUsuario(@WebParam(name = "user") String user,
            @WebParam(name = "pass") String password) {
        Usuario usuario = null;
        try {
            usuario = daoUsuario.verificarUsuario(user, password);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return usuario;
    }
}
