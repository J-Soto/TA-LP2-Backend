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

    public ActividadWS(ActividadDAO daoActividad) {
        this.daoActividad = new ActividadMySQL();
    }
    
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarActividad")
    public ArrayList<Actividad> listarActividad() {
        return daoActividad.listarActividad();
    }
    
    @WebMethod(operationName = "eliminarActividad")
    public int eliminarActividad(@WebParam(name = "idActividad") int idActividad) {
        return daoActividad.eliminarActividad(idActividad);
    }
    
    @WebMethod(operationName = "insertarActividad")
    public int insertarActividad(@WebParam(name = "actividad") Actividad actividad,
            @WebParam(name = "idSemana") int idsemana) {
        
        return daoActividad.insertarActividad(actividad, idsemana);
    }
    
    @WebMethod(operationName = "modificarActividad")
    public int modificarActividad(@WebParam(name = "actividad") Actividad actividad) {
        return daoActividad.modificarActividad(actividad);
    }
}
