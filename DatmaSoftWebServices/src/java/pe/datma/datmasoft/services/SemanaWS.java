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
import pe.datma.datmasoft.dao.SemanaDAO;
import pe.datma.datmasoft.modulos.Semana;
import pe.datma.datmasoft.mysql.SemanaMySQL;

/**
 *
 * @author maldo
 */
@WebService(serviceName = "SemanaWS")
public class SemanaWS {

    private SemanaDAO daoSemana;
    
    public SemanaWS(){
        daoSemana = new SemanaMySQL();
    }
    
    
    @WebMethod(operationName = "insertarSemana")
    public int insertarSemana(@WebParam(name = "semana") Semana semana,@WebParam(name = "fidCursoTema") int fidCursoTema){
        int resultado = 0;
        
        try {
            resultado = daoSemana.insertar(semana, fidCursoTema);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "modificarSemana")
    public int modificarSemana(@WebParam(name = "semana") Semana semana){
        int resultado = 0;
        
        try {
            resultado = daoSemana.modificar(semana);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
        
    
    @WebMethod(operationName = "listarSemanas")
    public ArrayList<Semana> listarSemanas(){
        ArrayList<Semana> semanas = new ArrayList<>();
        try {
            semanas = daoSemana.listar();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return semanas;
    }
    
    
    
}
