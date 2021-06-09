package pe.datma.datmasoft.dao;



import java.util.ArrayList;
import java.util.Date;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.modulos.Curso;
import pe.datma.datmasoft.modulos.Requerimiento;
import pe.datma.datmasoft.modulos.Semana;
import pe.datma.datmasoft.modulos.Tema;

public interface CursoDAO {
    int insertarCurso(Curso curso);
    int modificarCurso(Curso curso);
    int eliminarCurso(int idCurso);
    ArrayList<Curso> listarCursos();
    ArrayList<Curso> listarCursosPorNombre(String nombreCurso);
    ArrayList<Grupo> listarGruposPorIdCurso(int idCurso);
    ArrayList<Tema> listarTemasPorIdCurso(int idCurso);
    ArrayList<Semana> listarSemanasPorIdCurso(int idCurso);
    ArrayList<Requerimiento> listarRequerimientoPorIdCurso(int idCurso);
    
    //curso_tema:
    int insertarCursoTema(int idCurso, int idTema, Date fechaInicio, Date fechaFin);
    int modificarCursoTema(int idCurso, int idTema, Date fechaInicio, Date fechaFin);
    int eliminarCursoTema(int idCurso, int idTema);
    
    //Requerimiento del Curso: 
    int insertarRequerimiento(int idCursoDep,int idCursoReq,String descripcion);
    int eliminarRequerimiento(int idCursoDep, int idRequerimiento);
    int modificarRequerimiento(int idCursoDep, int idRequerimiento,String descripcion); 
}
