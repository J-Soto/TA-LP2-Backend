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
import pe.datma.datmasoft.dao.PsicologoDAO;
import pe.datma.datmasoft.mysql.PsicologoMySQL;
import pe.datma.datmasoft.rrhh.Psicologo;


/**
 *
 * @author maldo
 */
@WebService(serviceName = "PsicologoWS")
public class PsicologoWS {

    private PsicologoDAO daoPsicologo;
    
    public PsicologoWS(){
        daoPsicologo = new PsicologoMySQL();
    }
    
    
    @WebMethod(operationName = "insertarPsicologo")
    public int insertarPsicologo(@WebParam(name = "psicologo") Psicologo psicologo){
        int resultado = 0;
        try {
            resultado = daoPsicologo.insertarPsicologo(psicologo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarPsicologo")
    public int modificarPsicologo(@WebParam(name = "psicologo") Psicologo psicologo){
        int resultado = 0;
        try {
            resultado = daoPsicologo.modificarPsicologo(psicologo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
     
    @WebMethod(operationName = "eliminarPsicologo")
    public int eliminarPsicologo(@WebParam(name = "idPsicologo") int idPsicologo,@WebParam(name = "idUsuario") int idUsuario) {
        int resultado = 0;
        try {
            resultado = daoPsicologo.eliminarPsicologo(idPsicologo, idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
     
    
    @WebMethod(operationName = "listarPsicologosPorNombre")
    public ArrayList<Psicologo> listarPsicologosPorNombre(@WebParam(name = "nombrePsico") String nombrePsico){
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        try {
            psicologos = daoPsicologo.listarPsicologos(nombrePsico);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return psicologos;   
    }
    
    @WebMethod(operationName = "listarTodosPsicologos")
    public ArrayList<Psicologo> listarTodosPsicologos(){
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        try {
            psicologos = daoPsicologo.listarTodosPsicologos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return psicologos;   
    }
    
}