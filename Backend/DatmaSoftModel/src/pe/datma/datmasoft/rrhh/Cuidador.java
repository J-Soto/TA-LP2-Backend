package pe.datma.datmasoft.rrhh;

public class Cuidador extends Usuario {
    private boolean gestante;
    private boolean bajosRecursos;

    public boolean isGestante() {
        return gestante;
    }

    public void setGestante(boolean gestante) {
        this.gestante = gestante;
    }

    public boolean isBajosRecursos() {
        return bajosRecursos;
    }

    public void setBajosRecursos(boolean bajosRecursos) {
        this.bajosRecursos = bajosRecursos;
    }

    /**
     * Registrar la asistencia del cuidador
     */
    public void registrarAsistencia() {}

    public void registrarAviso() {}
}
