/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.logistica.TipoActividad;

import java.util.ArrayList;

/**
 *
 * @author JLHP
 */
public interface TipoActividadDAO {
    public ArrayList<TipoActividad> listar();
    public int insertar(TipoActividad tipoActividad);
    public int modificar(TipoActividad tipoActividad);
    public int eliminar(int idTipoActividad);
}
