package pe.datma.datmasoft.rrhh;

public class Infante extends Persona {
    private int IdInfante;
    private int idSeguroPrincipal;
    private String proveedorSeguro;
    private int activo;


    public int getIdInfante() {
        return IdInfante;
    }

    public void setIdInfante(int idInfante) {
        IdInfante = idInfante;
    }

    public int getIdSeguroPrincipal() {
        return idSeguroPrincipal;
    }

    public void setIdSeguroPrincipal(int idSeguroPrincipal) {
        this.idSeguroPrincipal = idSeguroPrincipal;
    }

    public String getProveedorSeguro() {
        return proveedorSeguro;
    }

    public void setProveedorSeguro(String proveedorSeguro) {
        this.proveedorSeguro = proveedorSeguro;
    }

    public int getActivo() {
        return activo;
    }

    public void setActivo(int activo) {
        this.activo = activo;
    }
}
