package pe.datma.datmasoft.modulos;


public class Requerimiento {
    private int idRequerimiento;
    private int idCursoReq;
    private String descripcion;

    public int getIdRequerimiento() {
        return idRequerimiento;
    }

    public void setIdRequerimiento(int idRequerimiento) {
        this.idRequerimiento = idRequerimiento;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public int getIdCursoReq() {
        return idCursoReq;
    }

    public void setIdCursoReq(int idCursoReq) {
        this.idCursoReq = idCursoReq;
    }
}
