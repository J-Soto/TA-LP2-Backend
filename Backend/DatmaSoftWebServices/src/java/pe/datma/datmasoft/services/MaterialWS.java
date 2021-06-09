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
import pe.datma.datmasoft.dao.MaterialDAO;
import pe.datma.datmasoft.modulos.Documento;
import pe.datma.datmasoft.modulos.Video;
import pe.datma.datmasoft.mysql.MaterialMySQL;

/**
 *
 * @author JLHP
 */
@WebService(serviceName = "MaterialWS")
public class MaterialWS {
    private MaterialDAO daoMaterial;

    public MaterialWS(MaterialDAO daoMaterial) {
        this.daoMaterial = new MaterialMySQL();
    }
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarMaterialVideo")
    public int insertarMaterialVideo(@WebParam(name = "video") Video video) {
        return daoMaterial.insertarMaterialVideo(video);
    }
    
    @WebMethod(operationName = "insertarMaterialDocumento")
    public int insertarMaterialDocumento(@WebParam(name = "doc") Documento documento) {
        return daoMaterial.insertarMaterialDocumento(documento);
    }
    
    @WebMethod(operationName = "modificarMaterialDocumento")
    public int modificarMaterialDocumento(@WebParam(name = "doc") Documento documento) {
        return daoMaterial.modificarMaterialDocumento(documento);
    }
    
    @WebMethod(operationName = "modificarMaterialVideo")
    public int modificarMaterialVideo(@WebParam(name = "video") Video video) {
        return daoMaterial.modificarMaterialVideo(video);
    }
    
    @WebMethod(operationName = "listarVideos")
    public ArrayList<Video> listarVideos() {
        return daoMaterial.listarVideos();
    }
    
    @WebMethod(operationName = "listarDocumentos")
    public ArrayList<Documento> listarDocumentos() {
        return daoMaterial.listarDocumentos();
    }
    
    @WebMethod(operationName = "eliminarMaterial")
    public int eliminarMaterial(@WebParam(name = "idMat") int idMaterial) {
        return daoMaterial.eliminarMaterial(idMaterial);
    }
}
