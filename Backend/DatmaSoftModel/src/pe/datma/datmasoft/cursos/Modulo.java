package pe.datma.datmasoft.cursos;

import java.util.Date;

public class Modulo {
    private int id;
    private Date fechaInicial;
    private Date fechaFinal;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getFechaInicial() {
        return fechaInicial;
    }

    public void setFechaInicial(Date fechaInicial) {
        this.fechaInicial = fechaInicial;
    }

    public Date getFechaFinal() {
        return fechaFinal;
    }

    public void setFechaFinal(Date fechaFinal) {
        this.fechaFinal = fechaFinal;
    }

    //Metodos:
    public void eliminarPsicologo(int idPsicologo){}
    public void eliminarCuidador(int idCuidador){}
    public void listarPsicologos(){}
    public void listarRequerimientos(){}
}
