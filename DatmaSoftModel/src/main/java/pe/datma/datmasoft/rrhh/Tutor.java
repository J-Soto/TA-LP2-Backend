package pe.datma.datmasoft.rrhh;

import java.util.ArrayList;
import pe.datma.datmasoft.familias.Grupo;


public class Tutor extends Usuario{
    private int bajoRecursos; //0->No, 1->Sí
    private int activoTutor; //0->No, 1->Sí
    private ArrayList<Grupo> grupos;
    private int tiposConexion;
    private int redesSociales;
    private int dispositivos;
    private int turno;
    private int dia;
    private int gestante; //0->No, 1->Sí

    public ArrayList<Grupo> getGrupos() {
        return grupos;
    }

    public void setGrupos(ArrayList<Grupo> grupos) {
        this.grupos = grupos;
    }
    
    public int getGestante() {
        return gestante;
    }

    public void setGestante(int gestante) {
        this.gestante = gestante;
    }

    public int getBajoRecursos() {
        return bajoRecursos;
    }

    public void setBajoRecursos(int bajoRecursos) {
        this.bajoRecursos = bajoRecursos;
    }
   
    public int getActivoTutor() {
        return activoTutor;
    }

    public void setActivoTutor(int activoTutor) {
        this.activoTutor = activoTutor;
    }

    public int getTiposConexion() {
        return tiposConexion;
    }

    public void setTiposConexion(int tiposConexion) {
        this.tiposConexion = tiposConexion;
    }

    public int getRedesSociales() {
        return redesSociales;
    }

    public void setRedesSociales(int redesSociales) {
        this.redesSociales = redesSociales;
    }

    public int getDispositivos() {
        return dispositivos;
    }

    public void setDispositivos(int dispositivos) {
        this.dispositivos = dispositivos;
    }

    public int getTurno() {
        return turno;
    }

    public void setTurno(int turno) {
        this.turno = turno;
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }


   
    
}
