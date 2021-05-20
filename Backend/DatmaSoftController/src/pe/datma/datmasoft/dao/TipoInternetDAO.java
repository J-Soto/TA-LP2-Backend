/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.logistica.TipoInternet;

import java.util.ArrayList;

/**
 *
 * @author JLHP
 */
public interface TipoInternetDAO {
    public ArrayList<TipoInternet> listar();
    public int insertar(TipoInternet tipoInternet);
    public int modificar(TipoInternet tipoInternet);
    public int eliminar(int idTipoInternet);
}
