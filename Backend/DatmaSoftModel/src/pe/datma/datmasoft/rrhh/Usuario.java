package pe.datma.datmasoft.rrhh;

public abstract class Usuario extends Persona {
    private int idUsuario;
    private String user;
    private String password;

    private int tipo; //0->Cuidador, 1->Psicologo
    private boolean activo;

    public int getTipo() {
        return tipo;
    }

    public void setTipo(int tipo) {
        this.tipo = tipo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public String getUser() {
        return user;
    }

    public void setUser(String user) {
        this.user = user;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    /**
     * Verificar datos del usuario con la RENIEC
     * @return true si es correcto, false si no lo es
     */
    public boolean verificarRENIEC() {return true;}

    /**
     * Guardar datos del formulario
     */
    public void guardarFormulario() { }
}
