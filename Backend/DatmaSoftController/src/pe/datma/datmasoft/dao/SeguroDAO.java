/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Seguro;

import java.util.ArrayList;

/**
 *
 * @author JLHP
 */
public interface SeguroDAO {
    public ArrayList<Seguro> listar();
    public int insertar(Seguro seguro);
    public int modificar(Seguro seguro);
    public int eliminar(int idSeguro);
}
