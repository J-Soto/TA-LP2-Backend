package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.familias.Grupo;

import java.util.ArrayList;
import pe.datma.datmasoft.rrhh.Psicologo;
import pe.datma.datmasoft.rrhh.Tutor;

public interface GrupoDAO {
    int insertarGrupo(int idCurso, Grupo grupo);
    int modificarGrupo(Grupo grupo);
    int eliminarGrupo(int idGrupo);
    ArrayList<Grupo> listarGrupoPorIdCurso(int idCurso);
    
    //grupo-tutor:
    int insertarGrupoTutor(int idTutor, int idGrupo, int numInfantes);
    int modificarGrupoTutor(int idTutor, int idGrupo, int numInfantes);
    int eliminarGrupoTutor(int idTutor,int idGrupo);
    ArrayList<Tutor> listarTutoresPorIdGrupo(int idGrupo);
    
    //grupo-psicologo:
    int insertarGrupoPsicologo(int idPsicologo, int idGrupo);
    int eliminarGrupoPsicologo(int idPsicologo, int idGrupo);
    ArrayList<Psicologo> listarPsicologosPorIdGrupo(int idGrupo);
    
}
