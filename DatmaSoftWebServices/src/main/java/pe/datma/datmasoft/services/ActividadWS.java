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
import pe.datma.datmasoft.modulos.Asistencia;
import pe.datma.datmasoft.modulos.Documento;
import pe.datma.datmasoft.modulos.Video;
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
    
    @WebMethod(operationName = "listarActividadesIdSemana")
    public ArrayList<Actividad> listarActividadesIdSemana(@WebParam(name = "idSemana") int idSemana) {
        ArrayList<Actividad> actividades = null;
        try {
            actividades=daoActividad.listarActividadesIdSemana(idSemana); 
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
    
    @WebMethod(operationName = "listarAsistenciasPorIdActividadYGrupo")
    public ArrayList<Asistencia> listarAsistenciasPorIdActividadYGrupo(@WebParam(name = "idActividad") int idActividad,@WebParam(name = "idGrupo") int idGrupo){
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        
        try {
            asistencias = daoActividad.listarAsistenciasPorIdActividadYGrupo(idActividad, idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return asistencias;
    }
    
    @WebMethod(operationName = "listarDocumentosPorIdActividad")
    public ArrayList<Documento> listarDocumentosPorIdActividad(@WebParam(name = "idActividad") int idActividad){
        ArrayList<Documento> documentos = new ArrayList<>();
        try {
            documentos = daoActividad.listarDocumentosPorIdActividad(idActividad);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return documentos;
    }
    
    @WebMethod(operationName = "listarVideosPorIdActividad")
    public ArrayList<Video> listarVideosPorIdActividad(@WebParam(name = "idActividad") int idActividad){
        ArrayList<Video> videos = new ArrayList<>();
        
        try {
            videos = daoActividad.listarVideosPorIdActividad(idActividad);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return videos;
    }
    
}
