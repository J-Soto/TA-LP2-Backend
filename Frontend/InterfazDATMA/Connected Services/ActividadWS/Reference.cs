﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterfazDATMA.ActividadWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.datmasoft.datma.pe/", ConfigurationName="ActividadWS.ActividadWS")]
    public interface ActividadWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/eliminarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/eliminarActividadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InterfazDATMA.ActividadWS.eliminarActividadResponse eliminarActividad(InterfazDATMA.ActividadWS.eliminarActividadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/eliminarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/eliminarActividadResponse")]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.eliminarActividadResponse> eliminarActividadAsync(InterfazDATMA.ActividadWS.eliminarActividadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/insertarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/insertarActividadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InterfazDATMA.ActividadWS.insertarActividadResponse insertarActividad(InterfazDATMA.ActividadWS.insertarActividadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/insertarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/insertarActividadResponse")]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.insertarActividadResponse> insertarActividadAsync(InterfazDATMA.ActividadWS.insertarActividadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/modificarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/modificarActividadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InterfazDATMA.ActividadWS.modificarActividadResponse modificarActividad(InterfazDATMA.ActividadWS.modificarActividadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/modificarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/modificarActividadResponse")]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.modificarActividadResponse> modificarActividadAsync(InterfazDATMA.ActividadWS.modificarActividadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/listarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/listarActividadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InterfazDATMA.ActividadWS.listarActividadResponse listarActividad(InterfazDATMA.ActividadWS.listarActividadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.datmasoft.datma.pe/ActividadWS/listarActividadRequest", ReplyAction="http://services.datmasoft.datma.pe/ActividadWS/listarActividadResponse")]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.listarActividadResponse> listarActividadAsync(InterfazDATMA.ActividadWS.listarActividadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarActividad", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class eliminarActividadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idActividad;
        
        public eliminarActividadRequest() {
        }
        
        public eliminarActividadRequest(int idActividad) {
            this.idActividad = idActividad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarActividadResponse", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class eliminarActividadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarActividadResponse() {
        }
        
        public eliminarActividadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.datmasoft.datma.pe/")]
    public partial class actividad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private System.DateTime fechaField;
        
        private bool fechaFieldSpecified;
        
        private localTime horaFinField;
        
        private localTime horaInicioField;
        
        private int idActividadField;
        
        private string linkZoomField;
        
        private material[] materialesField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("fecha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaSpecified {
            get {
                return this.fechaFieldSpecified;
            }
            set {
                this.fechaFieldSpecified = value;
                this.RaisePropertyChanged("fechaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public localTime horaFin {
            get {
                return this.horaFinField;
            }
            set {
                this.horaFinField = value;
                this.RaisePropertyChanged("horaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public localTime horaInicio {
            get {
                return this.horaInicioField;
            }
            set {
                this.horaInicioField = value;
                this.RaisePropertyChanged("horaInicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idActividad {
            get {
                return this.idActividadField;
            }
            set {
                this.idActividadField = value;
                this.RaisePropertyChanged("idActividad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string linkZoom {
            get {
                return this.linkZoomField;
            }
            set {
                this.linkZoomField = value;
                this.RaisePropertyChanged("linkZoom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("materiales", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=6)]
        public material[] materiales {
            get {
                return this.materialesField;
            }
            set {
                this.materialesField = value;
                this.RaisePropertyChanged("materiales");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.datmasoft.datma.pe/")]
    public partial class localTime : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    public partial class material : object, System.ComponentModel.INotifyPropertyChanged {
        
        private actividad actividadField;
        
        private string descripcionField;
        
        private int estadoField;
        
        private int idMaterialField;
        
        private string nombreField;
        
        private int tipoMaterialField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public actividad actividad {
            get {
                return this.actividadField;
            }
            set {
                this.actividadField = value;
                this.RaisePropertyChanged("actividad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idMaterial {
            get {
                return this.idMaterialField;
            }
            set {
                this.idMaterialField = value;
                this.RaisePropertyChanged("idMaterial");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int tipoMaterial {
            get {
                return this.tipoMaterialField;
            }
            set {
                this.tipoMaterialField = value;
                this.RaisePropertyChanged("tipoMaterial");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarActividad", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class insertarActividadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InterfazDATMA.ActividadWS.actividad actividad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idSemana;
        
        public insertarActividadRequest() {
        }
        
        public insertarActividadRequest(InterfazDATMA.ActividadWS.actividad actividad, int idSemana) {
            this.actividad = actividad;
            this.idSemana = idSemana;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarActividadResponse", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class insertarActividadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarActividadResponse() {
        }
        
        public insertarActividadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarActividad", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class modificarActividadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InterfazDATMA.ActividadWS.actividad actividad;
        
        public modificarActividadRequest() {
        }
        
        public modificarActividadRequest(InterfazDATMA.ActividadWS.actividad actividad) {
            this.actividad = actividad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarActividadResponse", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class modificarActividadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarActividadResponse() {
        }
        
        public modificarActividadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarActividad", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class listarActividadRequest {
        
        public listarActividadRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarActividadResponse", WrapperNamespace="http://services.datmasoft.datma.pe/", IsWrapped=true)]
    public partial class listarActividadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.datmasoft.datma.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InterfazDATMA.ActividadWS.actividad[] @return;
        
        public listarActividadResponse() {
        }
        
        public listarActividadResponse(InterfazDATMA.ActividadWS.actividad[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ActividadWSChannel : InterfazDATMA.ActividadWS.ActividadWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ActividadWSClient : System.ServiceModel.ClientBase<InterfazDATMA.ActividadWS.ActividadWS>, InterfazDATMA.ActividadWS.ActividadWS {
        
        public ActividadWSClient() {
        }
        
        public ActividadWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ActividadWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActividadWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActividadWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfazDATMA.ActividadWS.eliminarActividadResponse InterfazDATMA.ActividadWS.ActividadWS.eliminarActividad(InterfazDATMA.ActividadWS.eliminarActividadRequest request) {
            return base.Channel.eliminarActividad(request);
        }
        
        public int eliminarActividad(int idActividad) {
            InterfazDATMA.ActividadWS.eliminarActividadRequest inValue = new InterfazDATMA.ActividadWS.eliminarActividadRequest();
            inValue.idActividad = idActividad;
            InterfazDATMA.ActividadWS.eliminarActividadResponse retVal = ((InterfazDATMA.ActividadWS.ActividadWS)(this)).eliminarActividad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.eliminarActividadResponse> InterfazDATMA.ActividadWS.ActividadWS.eliminarActividadAsync(InterfazDATMA.ActividadWS.eliminarActividadRequest request) {
            return base.Channel.eliminarActividadAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.eliminarActividadResponse> eliminarActividadAsync(int idActividad) {
            InterfazDATMA.ActividadWS.eliminarActividadRequest inValue = new InterfazDATMA.ActividadWS.eliminarActividadRequest();
            inValue.idActividad = idActividad;
            return ((InterfazDATMA.ActividadWS.ActividadWS)(this)).eliminarActividadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfazDATMA.ActividadWS.insertarActividadResponse InterfazDATMA.ActividadWS.ActividadWS.insertarActividad(InterfazDATMA.ActividadWS.insertarActividadRequest request) {
            return base.Channel.insertarActividad(request);
        }
        
        public int insertarActividad(InterfazDATMA.ActividadWS.actividad actividad, int idSemana) {
            InterfazDATMA.ActividadWS.insertarActividadRequest inValue = new InterfazDATMA.ActividadWS.insertarActividadRequest();
            inValue.actividad = actividad;
            inValue.idSemana = idSemana;
            InterfazDATMA.ActividadWS.insertarActividadResponse retVal = ((InterfazDATMA.ActividadWS.ActividadWS)(this)).insertarActividad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.insertarActividadResponse> InterfazDATMA.ActividadWS.ActividadWS.insertarActividadAsync(InterfazDATMA.ActividadWS.insertarActividadRequest request) {
            return base.Channel.insertarActividadAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.insertarActividadResponse> insertarActividadAsync(InterfazDATMA.ActividadWS.actividad actividad, int idSemana) {
            InterfazDATMA.ActividadWS.insertarActividadRequest inValue = new InterfazDATMA.ActividadWS.insertarActividadRequest();
            inValue.actividad = actividad;
            inValue.idSemana = idSemana;
            return ((InterfazDATMA.ActividadWS.ActividadWS)(this)).insertarActividadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfazDATMA.ActividadWS.modificarActividadResponse InterfazDATMA.ActividadWS.ActividadWS.modificarActividad(InterfazDATMA.ActividadWS.modificarActividadRequest request) {
            return base.Channel.modificarActividad(request);
        }
        
        public int modificarActividad(InterfazDATMA.ActividadWS.actividad actividad) {
            InterfazDATMA.ActividadWS.modificarActividadRequest inValue = new InterfazDATMA.ActividadWS.modificarActividadRequest();
            inValue.actividad = actividad;
            InterfazDATMA.ActividadWS.modificarActividadResponse retVal = ((InterfazDATMA.ActividadWS.ActividadWS)(this)).modificarActividad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.modificarActividadResponse> InterfazDATMA.ActividadWS.ActividadWS.modificarActividadAsync(InterfazDATMA.ActividadWS.modificarActividadRequest request) {
            return base.Channel.modificarActividadAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.modificarActividadResponse> modificarActividadAsync(InterfazDATMA.ActividadWS.actividad actividad) {
            InterfazDATMA.ActividadWS.modificarActividadRequest inValue = new InterfazDATMA.ActividadWS.modificarActividadRequest();
            inValue.actividad = actividad;
            return ((InterfazDATMA.ActividadWS.ActividadWS)(this)).modificarActividadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InterfazDATMA.ActividadWS.listarActividadResponse InterfazDATMA.ActividadWS.ActividadWS.listarActividad(InterfazDATMA.ActividadWS.listarActividadRequest request) {
            return base.Channel.listarActividad(request);
        }
        
        public InterfazDATMA.ActividadWS.actividad[] listarActividad() {
            InterfazDATMA.ActividadWS.listarActividadRequest inValue = new InterfazDATMA.ActividadWS.listarActividadRequest();
            InterfazDATMA.ActividadWS.listarActividadResponse retVal = ((InterfazDATMA.ActividadWS.ActividadWS)(this)).listarActividad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.listarActividadResponse> InterfazDATMA.ActividadWS.ActividadWS.listarActividadAsync(InterfazDATMA.ActividadWS.listarActividadRequest request) {
            return base.Channel.listarActividadAsync(request);
        }
        
        public System.Threading.Tasks.Task<InterfazDATMA.ActividadWS.listarActividadResponse> listarActividadAsync() {
            InterfazDATMA.ActividadWS.listarActividadRequest inValue = new InterfazDATMA.ActividadWS.listarActividadRequest();
            return ((InterfazDATMA.ActividadWS.ActividadWS)(this)).listarActividadAsync(inValue);
        }
    }
}
