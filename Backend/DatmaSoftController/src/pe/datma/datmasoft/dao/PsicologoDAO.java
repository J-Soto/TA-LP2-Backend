package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Psicologo;

import java.util.ArrayList;

public interface PsicologoDAO {
     ArrayList<Psicologo> listarPsicologos();
     int insertarPsicologo(Psicologo psicologo);
     int modificarPsicologo(Psicologo psicologo);
     int eliminarPsicologo(int idPsicologo, int idUsuario);
}

