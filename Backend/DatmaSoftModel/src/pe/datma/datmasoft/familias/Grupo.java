package pe.datma.datmasoft.familias;

public class Grupo {
    private int id;
    private int fidmodulo;
    private String nombrePromocion;

    public String getNombrePromocion() {
        return nombrePromocion;
    }

    public void setNombrePromocion(String nombrePromocion) {
        this.nombrePromocion = nombrePromocion;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getFidmodulo() {
        return fidmodulo;
    }

    public void setFidmodulo(int fidmodulo) {
        this.fidmodulo = fidmodulo;
    }
}
