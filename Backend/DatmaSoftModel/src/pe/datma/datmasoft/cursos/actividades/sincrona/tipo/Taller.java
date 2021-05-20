package pe.datma.datmasoft.cursos.actividades.sincrona.tipo;
import pe.datma.datmasoft.cursos.actividades.sincrona.Actividad;

public class Taller extends Actividad {
    private String material;
    private String objetivo;

    public String getMaterial() {
        return material;
    }

    public void setMaterial(String material) {
        this.material = material;
    }

    public String getObjetivo() {
        return objetivo;
    }

    public void setObjetivo(String objetivo) {
        this.objetivo = objetivo;
    }
}
