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
import pe.datma.datmasoft.dao.DistritoDAO;
import pe.datma.datmasoft.mysql.DistritoMySQL;
import pe.datma.datmasoft.rrhh.Distrito;

/**
 *
 * @author JLHP
 */
@WebService(serviceName = "DistritoWS")
public class DistritoWS {
    private DistritoDAO daoDistrito;

    public DistritoWS() {
        this.daoDistrito = new DistritoMySQL();
    }

    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarDistritos")
    public ArrayList<Distrito> listarDistritos(@WebParam(name = "name") String nombre) {
        ArrayList<Distrito> distritos=new ArrayList<Distrito>();
        try {
            distritos=daoDistrito.listarDistritos(nombre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return distritos;
    }
    
    @WebMethod(operationName = "insertarDistrito")
    public int insertarDistrito(@WebParam(name = "name") Distrito distrito) {
        int resultado=0;
        try {
            resultado=daoDistrito.insertarDistrito(distrito);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarDistrito")
    public int modificarDistrito(@WebParam(name = "name") Distrito distrito) {
        int resultado=0;
        try {
            resultado=daoDistrito.modificarDistrito(distrito);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "lisrarTodosDistritos")
    public ArrayList<Distrito> lisrarTodosDistritos(){
        ArrayList<Distrito> distritos = new ArrayList<>();
        
        try {
            distritos = daoDistrito.lisrarTodosDistritos();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return distritos;
    }
    
}
