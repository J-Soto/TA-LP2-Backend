package pe.datma.datmasoft.modulos;
import java.util.Date;
import java.util.ArrayList;
import pe.datma.datmasoft.familias.Grupo;


public class Curso {
    private int idCurso;
    private String descripcion;
    private int estado; //0->En proceso, 1->Finalizado
    private Date fechaInicio;
    private Date fechaFin;
    private Date fechaInscripcion;
    private int cantSemanas;
    private ArrayList<Grupo> grupos;
    private ArrayList<Requerimiento> requerimientos;
    private ArrayList<Semana> semanas;
    private ArrayList<Tema> temas; //Tema principal del Curso (Eje)

    public ArrayList<Tema> getTemas() {
        return temas;
    }

    public void setTemas(ArrayList<Tema> temas) {
        this.temas = temas;
    }
    
    public ArrayList<Semana> getSemanas() {
        return semanas;
    }

    public void setSemanas(ArrayList<Semana> semanas) {
        this.semanas = semanas;
    }

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

    public ArrayList<Grupo> getGrupos() {
        return grupos;
    }

    public void setGrupos(ArrayList<Grupo> grupos) {
        this.grupos = grupos;
    }


    public ArrayList<Requerimiento> getRequerimientos() {
        return requerimientos;
    }

    public void setRequerimientos(ArrayList<Requerimiento> requerimientos) {
        this.requerimientos = requerimientos;
    }

    public Date getFechaInscripcion() {
        return fechaInscripcion;
    }

    public void setFechaInscripcion(Date fechaInscripcion) {
        this.fechaInscripcion = fechaInscripcion;
    }
    
}
