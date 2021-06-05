/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.modulos;

/**
 *
 * @author maldo
 */
public class Asistencia {
    private int idAsistencia;
    private int tipoAsistencia; //1->Asistio, 2->Tardanza, 3->No asistio
    private String descripcion;
    private Actividad actividad;

    public int getIdAsistencia() {
        return idAsistencia;
    }

    public void setIdAsistencia(int idAsistencia) {
        this.idAsistencia = idAsistencia;
    }

    public int getTipoAsistencia() {
        return tipoAsistencia;
    }

    public void setTipoAsistencia(int tipoAsistencia) {
        this.tipoAsistencia = tipoAsistencia;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }    

    public Actividad getActividad() {
        return actividad;
    }

    public void setActividad(Actividad actividad) {
        this.actividad = actividad;
    }
    
    
}
