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
import pe.datma.datmasoft.modulos.Actividad;
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

    public MaterialWS() {
        this.daoMaterial = new MaterialMySQL();
    }
    
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarMaterialVideo")
    public int insertarMaterialVideo(@WebParam(name = "video") Video video) {
        int resultado=0;
        try {
            resultado=daoMaterial.insertarMaterialVideo(video);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarMaterialDocumento")
    public int insertarMaterialDocumento(@WebParam(name = "doc") Documento documento) {
        int resultado=0;
        try {
            resultado=daoMaterial.insertarMaterialDocumento(documento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarMaterialDocumento")
    public int modificarMaterialDocumento(@WebParam(name = "doc") Documento documento) {
        int resultado=0;
        try {
            resultado=daoMaterial.modificarMaterialDocumento(documento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarMaterialVideo")
    public int modificarMaterialVideo(@WebParam(name = "video") Video video) {
        int resultado=0;
        try {
            resultado=daoMaterial.modificarMaterialVideo(video);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarVideos")
    public ArrayList<Video> listarVideos() {
        ArrayList<Video> videos=new ArrayList<Video>();
        try {
            videos=daoMaterial.listarVideos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return videos;
    }
    
    @WebMethod(operationName = "listarDocumentos")
    public ArrayList<Documento> listarDocumentos() {
        ArrayList<Documento> documentos=new ArrayList<Documento>();
        try {
            documentos=daoMaterial.listarDocumentos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return documentos;
    }
    
    @WebMethod(operationName = "eliminarMaterial")
    public int eliminarMaterial(@WebParam(name = "idMat") int idMaterial) {
        int resultado=0;
        try {
            resultado=daoMaterial.eliminarMaterial(idMaterial);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
