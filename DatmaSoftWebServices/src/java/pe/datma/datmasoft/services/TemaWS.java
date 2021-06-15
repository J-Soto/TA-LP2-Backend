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
import pe.datma.datmasoft.dao.TemaDAO;
import pe.datma.datmasoft.modulos.Tema;
import pe.datma.datmasoft.mysql.TemaMySQL;

/**
 *
 * @author maldo
 */
@WebService(serviceName = "TemaWS")
public class TemaWS {

    private TemaDAO daoTema;
    
    public TemaWS(){
        daoTema = new TemaMySQL();
    }
    
    
    @WebMethod(operationName = "listarTemas")
    public ArrayList<Tema> listarTemas(){
        ArrayList<Tema> temas = new ArrayList<>();
        
        try {
            temas = daoTema.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return temas;
    }
    
    @WebMethod(operationName = "insertarTema")
    public int insertarTema(@WebParam(name = "tema") Tema tema){
        int resultado = 0;
        
        try {
            resultado = daoTema.insertar(tema);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "modificarTema")
    public int modificarTema(@WebParam(name = "tema") Tema tema){
        int resultado = 0;
        
        try {
            resultado = daoTema.modificar(tema);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    
}
