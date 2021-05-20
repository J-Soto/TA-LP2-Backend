/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.logistica.TipoAsistencia;

import java.util.ArrayList;

/**
 *
 * @author JLHP
 */
public interface TipoAsistenciaDAO {
    public ArrayList<TipoAsistencia> listar();
    public int insertar(TipoAsistencia tipoAsistencia);
    public int modificar(TipoAsistencia tipoAsistencia);
    public int eliminar(int idTipoAsistencia);
}
