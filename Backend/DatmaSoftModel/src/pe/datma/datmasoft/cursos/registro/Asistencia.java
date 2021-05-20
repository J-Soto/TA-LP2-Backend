package pe.datma.datmasoft.cursos.registro;

import pe.datma.datmasoft.rrhh.Cuidador;

import java.util.Date;

public class Asistencia {
    private Date fecha;
    private boolean asistio;
    private String comentario;

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public boolean isAsistio() {
        return asistio;
    }

    public void setAsistio(boolean asistio) {
        this.asistio = asistio;
    }

    public String getComentario() {
        return comentario;
    }

    public void setComentario(String comentario) {
        this.comentario = comentario;
    }
}
