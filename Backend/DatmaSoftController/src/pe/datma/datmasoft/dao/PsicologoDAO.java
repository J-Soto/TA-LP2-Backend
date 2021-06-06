package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Psicologo;

import java.util.ArrayList;

public interface PsicologoDAO {
     ArrayList<Psicologo> listar();
     int insertar(Psicologo psicologo);
     int modificar(Psicologo psicologo);
     int eliminar(int idPsicologo, int idUsuario);
}

