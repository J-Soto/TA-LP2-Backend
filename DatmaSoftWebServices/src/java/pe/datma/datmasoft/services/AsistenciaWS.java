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
import pe.datma.datmasoft.dao.AsistenciaDAO;
import pe.datma.datmasoft.modulos.Asistencia;
import pe.datma.datmasoft.mysql.AsistenciaMySQL;

/**
 *
 * @author Gian Pierre
 */

@WebService(serviceName = "AsistenciaWS")
public class AsistenciaWS {
    private AsistenciaDAO daoAsistencia;

    public AsistenciaWS() {
        this.daoAsistencia = new AsistenciaMySQL();
    }
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarAsistencia")
    public ArrayList<Asistencia> listarAsistencia() {
        ArrayList<Asistencia> asistencias=new ArrayList<Asistencia>();
        try {
            asistencias=daoAsistencia.listarAsistencia();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return asistencias;
    }
    
    @WebMethod(operationName = "eliminarActividad")
    public int eliminarAsistencia(@WebParam(name = "idAsistencia") int idAsistencia) {
        int resultado=0;
        try {
            resultado=daoAsistencia.eliminarAsistencia(idAsistencia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarAsistencia")
    public int insertarAsistencia(@WebParam(name = "asistencia") Asistencia asistencia) {
        int resultado=0;
        try {
            resultado=daoAsistencia.insertarAsistencia(asistencia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarAsistencia")
    public int modificarAsistencia(@WebParam(name = "asistencia") Asistencia asistencia) {
        int resultado=0;
        try {
            resultado=daoAsistencia.modificarAsistencia(asistencia);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
