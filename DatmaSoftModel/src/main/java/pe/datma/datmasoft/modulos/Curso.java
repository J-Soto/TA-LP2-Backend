package pe.datma.datmasoft.modulos;
import java.util.Date;


public class Curso {
    private int idCurso;
    private String descripcion;
    private int estado; //0->En proceso, 1->Finalizado
    private Date fechaInicio;
    private Date fechaFin;
    private Date fechaInscripcion;
    private int cantSemanas;

    public int getIdCurso() {
        return idCurso;
    }

    public void setIdCurso(int idCurso) {
        this.idCurso = idCurso;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public int getCantSemanas() {
        return cantSemanas;
    }

    public void setCantSemanas(int cantSemanas) {
        this.cantSemanas = cantSemanas;
    }

    public Date getFechaInscripcion() {
        return fechaInscripcion;
    }

    public void setFechaInscripcion(Date fechaInscripcion) {
        this.fechaInscripcion = fechaInscripcion;
    }
    
}
