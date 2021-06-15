/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.modulos;

import java.util.Date;

/**
 *
 * @author maldo
 */
public class Tema {
    private int id;
    private String nombre;
    private String descripcion;
    private int id_curso_tema;
    private Date fechaInicio;
    private Date fechaFin;
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
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

    public int getId_curso_tema() {
        return id_curso_tema;
    }

    public void setId_curso_tema(int id_curso_tema) {
        this.id_curso_tema = id_curso_tema;
    }
    
    
}
