/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.rrhh;

import java.util.ArrayList;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.modulos.Curso;

/**
 *
 * @author maldo
 */
public class Psicologo extends Usuario{
    private int activoPsicologo;
    private ArrayList<Grupo> grupos;
    private ArrayList<Curso> cursos; //Cursos que esta dictando el psicologo en total

    
    public int getActivoPsicologo() {
        return activoPsicologo;
    }

    public void setActivoPsicologo(int activoPsicologo) {
        this.activoPsicologo = activoPsicologo;
    }

    public ArrayList<Grupo> getGrupos() {
        return grupos;
    }

    public void setGrupos(ArrayList<Grupo> grupos) {
        this.grupos = grupos;
    }
    
    public ArrayList<Curso> getCursos() {
        return cursos;
    }

    public void setCursos(ArrayList<Curso> cursos) {
        this.cursos = cursos;
    }
    
}
