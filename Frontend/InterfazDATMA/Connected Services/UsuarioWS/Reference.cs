﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfazDATMA.UsuarioWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.datmasoft.datma.pe/", ConfigurationName="UsuarioWS.UsuarioWS")]
    public interface UsuarioWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/UsuarioWS/listarUsuariosRequest", ReplyAction="http://services.datmasoft.datma.pe/UsuarioWS/listarUsuariosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InterfazDATMA.UsuarioWS.listarUsuariosResponse listarUsuarios(InterfazDATMA.UsuarioWS.listarUsuariosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/UsuarioWS/listarUsuariosRequest", ReplyAction="http://services.datmasoft.datma.pe/UsuarioWS/listarUsuariosResponse")]
        System.Threading.Tasks.Task<InterfazDATMA.UsuarioWS.listarUsuariosResponse> listarUsuariosAsync(InterfazDATMA.UsuarioWS.listarUsuariosRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/UsuarioWS/insertarUsuarioRequest", ReplyAction="http://services.datmasoft.datma.pe/UsuarioWS/insertarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InterfazDATMA.UsuarioWS.insertarUsuarioResponse insertarUsuario(InterfazDATMA.UsuarioWS.insertarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/UsuarioWS/insertarUsuarioRequest", ReplyAction="http://services.datmasoft.datma.pe/UsuarioWS/insertarUsuarioResponse")]
        System.Threading.Tasks.Task<InterfazDATMA.UsuarioWS.insertarUsuarioResponse> insertarUsuarioAsync(InterfazDATMA.UsuarioWS.insertarUsuarioRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.datmasoft.datma.pe/")]
    public partial class usuario : persona {
        
        private int activoField;
        
        private byte[] fotoPerfilField;
        
        private int idUsuarioField;
        
        private string passwordField;
        
        private int tipoField;
        
        private string userField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=1)]
        public byte[] fotoPerfil {
            get {
                return this.fotoPerfilField;
            }
            set {
                this.fotoPerfilField = value;
                this.RaisePropertyChanged("fotoPerfil");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("idUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
                this.RaisePropertyChanged("tipo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
                this.RaisePropertyChanged("user");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(usuario))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.datmasoft.datma.pe/")]
    public partial class persona : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoMaternoField;
        
        private string apellidoPaternoField;
        
        private string celularField;
        
        private string correoField;
        
        private string dNIField;
        
        private distrito distritoField;
        
        private int edadField;
        
        private System.DateTime fechaNacimientoField;
        
        private bool fechaNacimientoFieldSpecified;
        
        private ushort generoField;
        
        private int idPersonaField;
        
        private string nombreField;
        
        private string telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellidoMaterno {
            get {
                return this.apellidoMaternoField;
            }
            set {
                this.apellidoMaternoField = value;
                this.RaisePropertyChanged("apellidoMaterno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string apellidoPaterno {
            get {
                return this.apellidoPaternoField;
            }
            set {
                this.apellidoPaternoField = value;
                this.RaisePropertyChanged("apellidoPaterno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string celular {
            get {
                return this.celularField;
            }
            set {
                this.celularField = value;
                this.RaisePropertyChanged("celular");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string DNI {
            get {
                return this.dNIField;
            }
            set {
                this.dNIField = value;
                this.RaisePropertyChanged("DNI");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public distrito distrito {
            get {
                return this.distritoField;
            }
            set {
                this.distritoField = value;
                this.RaisePropertyChanged("distrito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int edad {
            get {
                return this.edadField;
            }
            set {
                this.edadField = value;
                this.RaisePropertyChanged("edad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public System.DateTime fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
                this.RaisePropertyChanged("fechaNacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaNacimientoSpecified {
            get {
                return this.fechaNacimientoFieldSpecified;
            }
            set {
                this.fechaNacimientoFieldSpecified = value;
                this.RaisePropertyChanged("fechaNacimientoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public ushort genero {
            get {
                return this.generoField;
            }
            set {
                this.generoField = value;
                this.RaisePropertyChanged("genero");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int idPersona {
            get {
                return this.idPersonaField;
            }
            set {
                this.idPersonaField = value;
                this.RaisePropertyChanged("idPersona");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.datmasoft.datma.pe/")]
    public partial class distrito : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idDistritoField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int idDistrito {
            get {
                return this.idDistritoField;
            }
            set {
                this.idDistritoField = value;
                this.RaisePropertyChanged("idDistrito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarUsuarios", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class listarUsuariosRequest {
        
        public listarUsuariosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarUsuariosResponse", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class listarUsuariosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InterfazDATMA.UsuarioWS.usuario[] @return;
        
        public listarUsuariosResponse() {
        }
        
        public listarUsuariosResponse(InterfazDATMA.UsuarioWS.usuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuario", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class insertarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InterfazDATMA.UsuarioWS.usuario usuario;
        
        public insertarUsuarioRequest() {
        }
        
        public insertarUsuarioRequest(InterfazDATMA.UsuarioWS.usuario usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuarioResponse", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class insertarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarUsuarioResponse() {
        }
        
        public insertarUsuarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UsuarioWSChannel : InterfazDATMA.UsuarioWS.UsuarioWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioWSClient : System.ServiceModel.ClientBase<InterfazDATMA.UsuarioWS.UsuarioWS>, InterfazDATMA.UsuarioWS.UsuarioWS {
        
        public UsuarioWSClient() {
        }
        
        public UsuarioWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfazDATMA.UsuarioWS.listarUsuariosResponse InterfazDATMA.UsuarioWS.UsuarioWS.listarUsuarios(InterfazDATMA.UsuarioWS.listarUsuariosRequest request) {
            return base.Channel.listarUsuarios(request);
        }
        
        public InterfazDATMA.UsuarioWS.usuario[] listarUsuarios() {
            InterfazDATMA.UsuarioWS.listarUsuariosRequest inValue = new InterfazDATMA.UsuarioWS.listarUsuariosRequest();
            InterfazDATMA.UsuarioWS.listarUsuariosResponse retVal = ((InterfazDATMA.UsuarioWS.UsuarioWS)(this)).listarUsuarios(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfazDATMA.UsuarioWS.listarUsuariosResponse> InterfazDATMA.UsuarioWS.UsuarioWS.listarUsuariosAsync(InterfazDATMA.UsuarioWS.listarUsuariosRequest request) {
            return base.Channel.listarUsuariosAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfazDATMA.UsuarioWS.listarUsuariosResponse> listarUsuariosAsync() {
            InterfazDATMA.UsuarioWS.listarUsuariosRequest inValue = new InterfazDATMA.UsuarioWS.listarUsuariosRequest();
            return ((InterfazDATMA.UsuarioWS.UsuarioWS)(this)).listarUsuariosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfazDATMA.UsuarioWS.insertarUsuarioResponse InterfazDATMA.UsuarioWS.UsuarioWS.insertarUsuario(InterfazDATMA.UsuarioWS.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuario(request);
        }
        
        public int insertarUsuario(InterfazDATMA.UsuarioWS.usuario usuario) {
            InterfazDATMA.UsuarioWS.insertarUsuarioRequest inValue = new InterfazDATMA.UsuarioWS.insertarUsuarioRequest();
            inValue.usuario = usuario;
            InterfazDATMA.UsuarioWS.insertarUsuarioResponse retVal = ((InterfazDATMA.UsuarioWS.UsuarioWS)(this)).insertarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfazDATMA.UsuarioWS.insertarUsuarioResponse> InterfazDATMA.UsuarioWS.UsuarioWS.insertarUsuarioAsync(InterfazDATMA.UsuarioWS.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfazDATMA.UsuarioWS.insertarUsuarioResponse> insertarUsuarioAsync(InterfazDATMA.UsuarioWS.usuario usuario) {
            InterfazDATMA.UsuarioWS.insertarUsuarioRequest inValue = new InterfazDATMA.UsuarioWS.insertarUsuarioRequest();
            inValue.usuario = usuario;
            return ((InterfazDATMA.UsuarioWS.UsuarioWS)(this)).insertarUsuarioAsync(inValue);
        }
    }
}
