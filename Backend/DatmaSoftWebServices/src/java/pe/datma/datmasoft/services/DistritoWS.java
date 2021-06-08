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

    public DistritoWS(DistritoDAO daoDistrito) {
        this.daoDistrito = new DistritoMySQL();
    }

    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarDistritos")
    public ArrayList<Distrito> listarDistritos() {
        return daoDistrito.listarDistritos();
    }
    
    @WebMethod(operationName = "insertarDistrito")
    public int insertarDistrito(@WebParam(name = "name") Distrito distrito) {
        return daoDistrito.insertarDistrito(distrito);
    }
    
    @WebMethod(operationName = "modificarDistrito")
    public int modificarDistrito(@WebParam(name = "name") Distrito distrito) {
        return daoDistrito.modificarDistrito(distrito);
    }
}
