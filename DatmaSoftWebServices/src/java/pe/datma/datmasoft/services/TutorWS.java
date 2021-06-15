/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.services;

//import com.google.gson.Gson;
//import com.google.gson.JsonObject;
import com.google.gson.Gson;
import com.google.gson.JsonObject;
import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.datma.datmasoft.dao.TutorDAO;
import pe.datma.datmasoft.mysql.TutorMySQL;
import pe.datma.datmasoft.rrhh.Tutor;

/**
 *
 * @author maldo
 */
@WebService(serviceName = "TutorWS")
public class TutorWS {

    private TutorDAO daoTutor;
    
    public TutorWS(){
        daoTutor = new TutorMySQL();
    }
    
    @WebMethod(operationName = "verificarDNI")
    public int verificarDNI(@WebParam(name = "dni") String dni,
            @WebParam(name = "nom") String nom,
            @WebParam(name = "apPat") String app,
            @WebParam(name = "apMat") String apm){
        int resultado=0;
        String enlace="https://dni.optimizeperu.com/api/persons/"+dni+"?format=json";
        //String enlace="https://dni.optimizeperu.com/api/prod/persons/"+dni;
        try {
            URL url = new URL(enlace);
            HttpURLConnection con=(HttpURLConnection)url.openConnection();
            //con.setRequestProperty("authorization","token k4d2956bd531ab61d44f4fa07304b20e13913815");
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
            
            //System.out.println(DNI.length());
            DNI=DNI.substring(1,DNI.length()-1);
            NOM=NOM.substring(1,NOM.length()-1);
            APP=APP.substring(1,APP.length()-1);
            APM=APM.substring(1,APM.length()-1);
            nom=nom.toUpperCase();
            app=app.toUpperCase();
            apm=apm.toUpperCase();
            if(NOM.equals(nom) && APP.equals(app) && APM.equals(apm) && 
                    DNI.equals(dni))
                resultado=1;
        
            con.disconnect();
//      
        } catch (FileNotFoundException e) {
            System.out.println(e);
            resultado=-1;
        } catch(Exception ex){
            System.out.println(ex.getMessage());
        } 
        
        return resultado;
    }
    
    @WebMethod(operationName = "insertarTutor")
    public int insertarTutor(@WebParam(name = "tutor") Tutor tutor){
        int resultado = 0;
        try {
            resultado = daoTutor.insertarTutor(tutor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarTutor")
    public int modificarTutor(@WebParam(name = "tutor") Tutor tutor){
        int resultado = 0;
        try {
            resultado = daoTutor.modificarTutor(tutor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarTutor")
    public int eliminarTutor(@WebParam(name = "idTutor") int idTutor,@WebParam(name = "idUsuario") int idUsuario){
        int resultado = 0;
        try {
            resultado = daoTutor.eliminarTutor(idTutor, idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTutoresPorNombre")
    public ArrayList<Tutor> listarTutoresPorNombre(@WebParam(name = "nombreTutor") String nombreTutor){
        ArrayList<Tutor> tutores = new ArrayList<Tutor>();
        try {
            tutores = daoTutor.listarTutores(nombreTutor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return tutores;
    }
    
    @WebMethod(operationName = "listarTodosTutores")
    public ArrayList<Tutor> listarTodosTutores(){
        ArrayList<Tutor> tutores = new ArrayList<Tutor>();
        try {
            tutores = daoTutor.listarTodosTutores();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return tutores;
    }
    
}