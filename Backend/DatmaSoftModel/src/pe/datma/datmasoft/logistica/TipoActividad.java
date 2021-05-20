/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.logistica;

/**
 *
 * @author JLHP
 */
public class TipoActividad {
    int idTipoActividad;
    String descripcion;
    int sincrono;

    public int getIdTipoActividad() {
        return idTipoActividad;
    }

    public void setIdTipoActividad(int idTipoActividad) {
        this.idTipoActividad = idTipoActividad;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getSincrono() {
        return sincrono;
    }

    public void setSincrono(int sincrono) {
        this.sincrono = sincrono;
    }
}
