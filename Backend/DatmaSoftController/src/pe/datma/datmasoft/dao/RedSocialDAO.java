/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.dao;

/**
 *
 * @author JLHP
 */

import pe.datma.datmasoft.util.RedSocial;

import java.util.ArrayList;

public interface RedSocialDAO {
    public ArrayList<RedSocial> listar();
    public int insertar(RedSocial redSocial);
    public int modificar(RedSocial redSocial);
    public int eliminar(int idRedSocial);
}