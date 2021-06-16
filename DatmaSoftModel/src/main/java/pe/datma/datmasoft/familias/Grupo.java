/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.familias;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Curso;
import pe.datma.datmasoft.rrhh.Tutor;
import pe.datma.datmasoft.rrhh.Psicologo;

/**
 *
 * @author maldo
 */
public class Grupo {
    private int idGrupo;
    private String nombrePromocion;
    private int maxCantCuidadores;
    private ArrayList<Tutor> cuidadores;
    private ArrayList<Psicologo> psicologos;
    private Curso curso;
    private int cantInfantes;

    public int getCantInfantes() {
        return cantInfantes;
    }

    public void setCantInfantes(int cantInfantes) {
        this.cantInfantes = cantInfantes;
    }
    
    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }    
    
    public int getMaxCantCuidadores() {
        return maxCantCuidadores;
    }

    public void setMaxCantCuidadores(int maxCantCuidadores) {
        this.maxCantCuidadores = maxCantCuidadores;
    }

    public int getIdGrupo() {
        return idGrupo;
    }

    public void setIdGrupo(int idGrupo) {
        this.idGrupo = idGrupo;
    }

    public String getNombrePromocion() {
        return nombrePromocion;
    }

    public void setNombrePromocion(String nombrePromocion) {
        this.nombrePromocion = nombrePromocion;
    }

    public ArrayList<Tutor> getCuidadores() {
        return cuidadores;
    }

    public void setCuidadores(ArrayList<Tutor> cuidadores) {
        this.cuidadores = cuidadores;
    }

    public ArrayList<Psicologo> getPsicologos() {
        return psicologos;
    }

    public void setPsicologos(ArrayList<Psicologo> psicologos) {
        this.psicologos = psicologos;
    }
    
}
