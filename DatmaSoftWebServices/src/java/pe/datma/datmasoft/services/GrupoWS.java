package pe.datma.datmasoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.datma.datmasoft.dao.GrupoDAO;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.mysql.GrupoMySQL;
import pe.datma.datmasoft.rrhh.Psicologo;
import pe.datma.datmasoft.rrhh.Tutor;

@WebService(serviceName = "GrupoWS")
public class GrupoWS {
    private GrupoDAO daoGrupo;
    
    public GrupoWS() {
        this.daoGrupo = new GrupoMySQL();
    }
    
    @WebMethod(operationName = "insertarGrupo")
    public int insertarGrupo(@WebParam(name = "idCurso") int idCurso,@WebParam(name = "grupo")  Grupo grupo){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.insertarGrupo(idCurso, grupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    
    @WebMethod(operationName = "modificarGrupo")
    public int modificarGrupo(@WebParam(name = "grupo") Grupo grupo){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.modificarGrupo(grupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    
    @WebMethod(operationName = "eliminarGrupo")
    public int eliminarGrupo(@WebParam(name = "idGrupo") int idGrupo){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.eliminarGrupo(idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "listarGrupoPorIdCurso")
    public ArrayList<Grupo> listarGrupoPorIdCurso(@WebParam(name = "idGrupo") int idCurso){
        ArrayList<Grupo> grupos = new ArrayList<>();
        
        try {
            grupos = daoGrupo.listarGrupoPorIdCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return grupos;
    }
    
    //grupo-tutor
    @WebMethod(operationName = "insertarGrupoTutor")
    public int insertarGrupoTutor(@WebParam(name = "idTutor") int idTutor,@WebParam(name = "idGrupo") int idGrupo,@WebParam(name = "numInfantes") int numInfantes){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.insertarGrupoTutor(idTutor, idGrupo, numInfantes);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    
    @WebMethod(operationName = "modificarGrupoTutor")
    public int modificarGrupoTutor(@WebParam(name = "idTutor") int idTutor,@WebParam(name = "idGrupo") int idGrupo,@WebParam(name = "numInfantes") int numInfantes){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.modificarGrupoTutor(idTutor, idGrupo, numInfantes);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarGrupoTutor")
    public int eliminarGrupoTutor(@WebParam(name = "idTutor") int idTutor,@WebParam(name = "idGrupo") int idGrupo){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.eliminarGrupoTutor(idTutor, idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "listarTutoresPorIdGrupo")
    public ArrayList<Tutor> listarTutoresPorIdGrupo(@WebParam(name = "idGrupo") int idGrupo){
        ArrayList<Tutor> tutores = new ArrayList<>();
        
        try {
            tutores = daoGrupo.listarTutoresPorIdGrupo(idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return tutores;
    }
    
    
    //grupo-psicologo
    @WebMethod(operationName = "insertarGrupoPsicologo")
    public int insertarGrupoPsicologo(@WebParam(name = "idPsicologo") int idPsicologo,@WebParam(name = "idGrupo") int idGrupo) {
        int resultado = 0;
     
        try {
            resultado = daoGrupo.insertarGrupoPsicologo(idPsicologo, idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarGrupoPsicologo")
    public int eliminarGrupoPsicologo(@WebParam(name = "idPsicologo") int idPsicologo,@WebParam(name = "idGrupo") int idGrupo){
        int resultado = 0;
     
        try {
            resultado = daoGrupo.eliminarGrupoPsicologo(idPsicologo, idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "listarPsicologosPorIdGrupo")
    public ArrayList<Psicologo> listarPsicologosPorIdGrupo(@WebParam(name = "idGrupo") int idGrupo){
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        try {
            psicologos = daoGrupo.listarPsicologosPorIdGrupo(idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        
        return psicologos;
    }
    
}
