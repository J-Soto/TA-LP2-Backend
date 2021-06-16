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
import pe.datma.datmasoft.dao.ActividadDAO;
import pe.datma.datmasoft.modulos.Actividad;
import pe.datma.datmasoft.mysql.ActividadMySQL;

/**
 *
 * @author JLHP
 */
@WebService(serviceName = "ActividadWS")
public class ActividadWS {
    private ActividadDAO daoActividad;

    public ActividadWS() {
        this.daoActividad = new ActividadMySQL();
    }
    
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarActividad")
    public ArrayList<Actividad> listarActividad() {
        ArrayList<Actividad> actividades=new ArrayList<Actividad>();
        try {
            actividades=daoActividad.listarActividad(); 
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return actividades;
    }
    
    @WebMethod(operationName = "eliminarActividad")
    public int eliminarActividad(@WebParam(name = "idActividad") int idActividad) {
        int resultado=0;
        try {
            resultado=daoActividad.eliminarActividad(idActividad);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarActividad")
    public int insertarActividad(@WebParam(name = "actividad") Actividad actividad,
            @WebParam(name = "idSemana") int idsemana) {
        int resultado=0;
        try {
            resultado=daoActividad.insertarActividad(actividad, idsemana);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarActividad")
    public int modificarActividad(@WebParam(name = "actividad") Actividad actividad) {
        int resultado=0;
        try {
            resultado=daoActividad.modificarActividad(actividad);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
