/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.services;

import com.google.gson.Gson;
import com.google.gson.JsonObject;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
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
    
    @WebMethod(operationName = "verificarDNI")
    public int verificarDNI(@WebParam(name = "dni") String dni,
            @WebParam(name = "nom") String nom,
            @WebParam(name = "apPat") String apPat,
            @WebParam(name = "apMat") String apMat){
        int resultado = 0;
        String enlace="https://dni.optimizeperu.com/api/persons/"+dni+"?format=json";
        try {
            //String param = "?Authorization=" + "k4d2956bd531ab61d44f4fa07304b20e13913815";
            URL url = new URL(enlace);
            HttpURLConnection con=(HttpURLConnection)url.openConnection();
            //con.setRequestProperty("token", "k4d2956bd531ab61d44f4fa07304b20e13913815");
            con.setRequestMethod("GET");
            
            BufferedReader input = new BufferedReader(new InputStreamReader(con.getInputStream()));
            
            String line = input.readLine(); 

//            System.out.println(line);
            Gson gson=new Gson();
            JsonObject json=gson.fromJson(line, JsonObject.class);
            String DNI=json.get("dni").toString();
            String NOM=json.get("name").toString();
            String APP=json.get("first_name").toString();
            String APM=json.get("last_name").toString();
            String CUI=json.get("cui").toString();

            con.disconnect();
            if(NOM==nom.toUpperCase() && APP==apPat.toUpperCase() && 
                    APM==apMat.toUpperCase() && 
                    DNI==dni)resultado=1;
           
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
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