package pe.datma.datmasoft.modulos;

import java.util.ArrayList;
import java.util.Date;


public class Semana {
    private int idSemana;
    private String descripcion;
    private Date fechaInicio;
    private Date fechaFin;
    private int numeroSemana;
    private ArrayList<Actividad> actividad;
    private String nombreEje;


    public ArrayList<Actividad> getActividad() {
        return actividad;
    }

    public void setActividad(ArrayList<Actividad> actividad) {
        this.actividad = actividad;
    }

    public String getNombreEje() {
        return nombreEje;
    }

    public void setNombreEje(String nombreEje) {
        this.nombreEje = nombreEje;
    }
    
    public int getIdSemana() {
        return idSemana;
    }

    public void setIdSemana(int idSemana) {
        this.idSemana = idSemana;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
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

    public int getNumeroSemana() {
        return numeroSemana;
    }

    public void setNumeroSemana(int numeroSemana) {
        this.numeroSemana = numeroSemana;
    }
    
}
