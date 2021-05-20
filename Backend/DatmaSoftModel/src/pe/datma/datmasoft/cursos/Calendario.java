package pe.datma.datmasoft.cursos;

import pe.datma.datmasoft.cursos.actividades.sincrona.Actividad;

import java.util.ArrayList;
import java.util.Date;

public class Calendario {
    private Date fechaInicio;
    private Date fechaFin;
    private String descripcion;
    private ArrayList<Actividad> actividadesSinc;

    public ArrayList<Actividad> getActividadesSinc() {
        return actividadesSinc;
    }

    public void setActividadesSinc(ArrayList<Actividad> actividadesSinc) {
        this.actividadesSinc = actividadesSinc;
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

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

}
