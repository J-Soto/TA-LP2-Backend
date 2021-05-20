package pe.datma.datmasoft.rrhh;

import pe.datma.datmasoft.cursos.registro.Asistencia;

import java.util.ArrayList;

public class Psicologo extends Usuario {
    private int idPsicologo;
    private ArrayList<Asistencia> asistencias;
    private ArrayList<String> consultas;

    public int getIdPsicologo() {
        return idPsicologo;
    }

    public void setIdPsicologo(int idPsicologo) {
        this.idPsicologo = idPsicologo;
    }

    public ArrayList<Asistencia> getAsistencias() {
        return asistencias;
    }

    public void setAsistencias(ArrayList<Asistencia> asistencias) {
        this.asistencias = asistencias;
    }

    public void registrarPsicologo() {}

    public void modificarRegistroPsicologo() {}

    public void registrarAsistencia() {}

    public void registrarConsulta() {}
}
