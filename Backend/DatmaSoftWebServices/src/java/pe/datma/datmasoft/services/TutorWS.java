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
import pe.datma.datmasoft.dao.TutorDAO;
import pe.datma.datmasoft.modulos.Actividad;
import pe.datma.datmasoft.mysql.TutorMySQL;
import pe.datma.datmasoft.rrhh.Tutor;

/**
 *
 * @author JLHP
 */
@WebService(serviceName = "TutorWS")
public class TutorWS {
    private TutorDAO daoTutor;
    
    public TutorWS() {
        this.daoTutor = new TutorMySQL();
    }
    
    @WebMethod(operationName = "listarTutor")
    public ArrayList<Tutor> listarTutor() {
        ArrayList<Tutor> tutores =new ArrayList<Tutor>();
        try {
            tutores=daoTutor.listarTutores();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return tutores;
    }
    
    @WebMethod(operationName = "eliminarTutor")
    public int eliminarTutor(@WebParam(name = "idTutor") int idTutor, @WebParam(name = "idUsuario") int idUsuario) {
        int resultado=0;
        try {
            resultado=daoTutor.eliminarTutor(idTutor,  idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarTutor")
    public int insertarTutor(@WebParam(name = "tutor") Tutor tutor) {
        int resultado=0;
        try {
            resultado=daoTutor.insertarTutor(tutor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarTutor")
    public int modificarTutor(@WebParam(name = "tutor") Tutor tutor) {
        int resultado=0;
        try {
            resultado=daoTutor.modificarTutor(tutor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
