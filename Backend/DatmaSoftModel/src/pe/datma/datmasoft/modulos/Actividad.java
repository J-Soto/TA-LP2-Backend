package pe.datma.datmasoft.modulos;

import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;


public class Actividad {
    private int idActividad;
    private String nombre;
    private String linkZoom; //se trabaja con zoom
    private String descripcion;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private Date fecha; //fecha de dictado de la actividad
    private ArrayList<Material> materiales;

    
    public int getIdActividad() {
        return idActividad;
    }

    public void setIdActividad(int idActividad) {
        this.idActividad = idActividad;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getLinkZoom() {
        return linkZoom;
    }

    public void setLinkZoom(String linkZoom) {
        this.linkZoom = linkZoom;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public LocalTime getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(LocalTime horaInicio) {
        this.horaInicio = horaInicio;
    }

    public LocalTime getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(LocalTime horaFin) {
        this.horaFin = horaFin;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public ArrayList<Material> getMateriales() {
        return materiales;
    }

    public void setMateriales(ArrayList<Material> materiales) {
        this.materiales = materiales;
    }

}
