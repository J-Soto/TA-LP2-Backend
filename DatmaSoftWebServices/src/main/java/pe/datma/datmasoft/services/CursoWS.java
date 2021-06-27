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
import pe.datma.datmasoft.dao.CursoDAO;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.modulos.Curso;
import pe.datma.datmasoft.modulos.Requerimiento;
import pe.datma.datmasoft.modulos.Semana;
import pe.datma.datmasoft.modulos.Tema;
import pe.datma.datmasoft.mysql.CursoMySQL;

/**
 *
 * @author maldo
 */
@WebService(serviceName = "CursoWS")
public class CursoWS {

    private CursoDAO daoCurso;
    
    public CursoWS(){
        daoCurso = new CursoMySQL();        
    }
    
    
    @WebMethod(operationName = "insertarCurso")
    public int insertarCurso(@WebParam(name="curso") Curso curso){
        int resultado = 0;
        try {
            resultado = daoCurso.insertarCurso(curso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPsicologoCurso")
    public int eliminarPsicologoCurso(@WebParam(name="idPsi") int idPsi,
            @WebParam(name="idCurso") int idCurso){
        int resultado = 0;
        try {
            resultado = daoCurso.eliminarPsicologoCurso(idPsi, idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarCurso")
    public int modificarCurso(@WebParam(name="curso") Curso curso){
        int resultado = 0;
        try {
            resultado = daoCurso.modificarCurso(curso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCurso")
    public int eliminarCurso(@WebParam(name="idCurso") int idCurso){
        int resultado = 0;
        try {
            resultado = daoCurso.eliminarCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarCursos")
    public ArrayList<Curso> listarCursos() {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoCurso.listarCursos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "listarCursosDisponibles")
    public ArrayList<Curso> listarCursosDisponibles() {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoCurso.listarCursosDisponibles();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "listarCursosPorNombre")
    public ArrayList<Curso> listarCursosPorNombre(@WebParam(name="nombreCurso") String nombreCurso){
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoCurso.listarCursosPorNombre(nombreCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "listarCursosPsicologo")
    public ArrayList<Curso> listarCursosPsicologo(@WebParam(name="idPsicologo") int idPsicologo) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoCurso.listarCursosPsicologo(idPsicologo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
  
    
    @WebMethod(operationName = "listarGruposPorIdCurso")
    public ArrayList<Grupo> listarGruposPorIdCurso(@WebParam(name="idCurso") int idCurso){
        ArrayList<Grupo> grupos = new ArrayList<>();
        try {
            grupos = daoCurso.listarGruposPorIdCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return grupos;
    }
    
    //
    @WebMethod(operationName = "listarTemasPorIdCurso")
    public ArrayList<Tema> listarTemasPorIdCurso(@WebParam(name="idCurso") int idCurso){
        ArrayList<Tema> temas = new ArrayList<>();
        try {
            temas = daoCurso.listarTemasPorIdCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return temas;
    }
    
    @WebMethod(operationName = "listarSemanasPorIdCurso")
    public ArrayList<Semana> listarSemanasPorIdCurso(@WebParam(name="idCurso") int idCurso){
        ArrayList<Semana> semanas = new ArrayList<>();
        try {
            semanas = daoCurso.listarSemanasPorIdCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return semanas;
    }
    
    @WebMethod(operationName = "listarRequerimientoPorIdCurso")
    public ArrayList<Requerimiento> listarRequerimientoPorIdCurso(@WebParam(name="idCurso") int idCurso){
        ArrayList<Requerimiento> requerimientos = new ArrayList<>();
        try {
            requerimientos = daoCurso.listarRequerimientoPorIdCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return requerimientos;
    }
    
    //curso-tema: 
    @WebMethod(operationName = "insertarCursoTema")
    public int insertarCursoTema(@WebParam(name="idCurso") int idCurso,@WebParam(name="idTema") int idTema,@WebParam(name="fechaInicio") java.util.Date fechaInicio,@WebParam(name="fechaFin") java.util.Date fechaFin){
        int resultado = 0;
        try {
            resultado = daoCurso.insertarCursoTema(idCurso, idTema, fechaInicio, fechaFin);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "modificarCursoTema")
    public int modificarCursoTema(@WebParam(name="idCurso") int idCurso,@WebParam(name="idTema") int idTema,@WebParam(name="fechaInicio") java.util.Date fechaInicio,@WebParam(name="fechaFin") java.util.Date fechaFin){
        int resultado = 0;
        try {
            resultado = daoCurso.modificarCursoTema(idCurso, idTema, fechaInicio, fechaFin);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //
    @WebMethod(operationName = "eliminarCursoTema")
    public int eliminarCursoTema(@WebParam(name="idCurso_tema") int idCurso_tema){
        int resultado = 0;
        try {
            resultado = daoCurso.eliminarCursoTema(idCurso_tema);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    //requerimiento
    @WebMethod(operationName = "insertarRequerimiento")
    public int insertarRequerimiento(@WebParam(name="idCursoDep") int idCursoDep,@WebParam(name="idCursoReq") int idCursoReq,@WebParam(name="descripcion") String descripcion){
        int resultado = 0;
        try {
            resultado = daoCurso.insertarRequerimiento(idCursoDep, idCursoReq, descripcion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "eliminarRequerimiento")
    public int eliminarRequerimiento(@WebParam(name="idCursoDep") int idCursoDep,@WebParam(name="idRequerimiento") int idRequerimiento){
        int resultado = 0;
        try {
            resultado = daoCurso.eliminarRequerimiento(idCursoDep, idRequerimiento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarRequerimiento")
    public int modificarRequerimiento(@WebParam(name="idCursoDep") int idCursoDep,@WebParam(name="idRequerimiento") int idRequerimiento,@WebParam(name="descripcion") String descripcion){
        int resultado = 0;
        try {
            resultado = daoCurso.modificarRequerimiento(idCursoDep, idRequerimiento, descripcion);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //psicologo_curso:
    @WebMethod(operationName = "insertarPsicologoCurso")
    public int insertarPsicologoCurso(@WebParam(name="idPsicologo") int idPsicologo,@WebParam(name="idCurso") int idCurso){
        int resultado = 0;
        try {
            resultado = daoCurso.insertarPsicologoCurso(idPsicologo, idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "listarCursosGrupoPsicologo")
    public ArrayList<Grupo> listarCursosGrupoPsicologo(@WebParam(name="idPsicologo") int idPsicologo,@WebParam(name="idCurso") int idCurso){
        ArrayList<Grupo> grupos = new ArrayList<>();
        try {
            grupos = daoCurso.listarCursosGrupoPsicologo(idPsicologo, idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return grupos;
    }
}
