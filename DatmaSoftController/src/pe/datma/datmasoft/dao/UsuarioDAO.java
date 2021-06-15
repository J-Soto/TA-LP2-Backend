/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.rrhh.Usuario;

/**
 *
 * @author JLHP
 */
public interface UsuarioDAO {
    int insertarUsuario(Usuario user);
    ArrayList<Usuario> listarUsuarios();
    int verificarUsuario(String user,String password);
}
