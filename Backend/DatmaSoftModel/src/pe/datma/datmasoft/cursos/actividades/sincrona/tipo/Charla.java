package pe.datma.datmasoft.cursos.actividades.sincrona.tipo;

import pe.datma.datmasoft.cursos.actividades.sincrona.Actividad;

public class Charla extends Actividad {
    private String tema;
    private String titulo;

    public String getTema() {
        return tema;
    }

    public void setTema(String tema) {
        this.tema = tema;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }
}
