﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftBO.turnoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/", ConfigurationName="turnoWS.TurnoWS")]
    public interface TurnoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://softcitws.soft.pucp.edu.pe/TurnoWS/obtenerPorIdTurnoRequest", ReplyAction="http://softcitws.soft.pucp.edu.pe/TurnoWS/obtenerPorIdTurnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SoftBO.turnoWS.obtenerPorIdTurnoResponse obtenerPorIdTurno(SoftBO.turnoWS.obtenerPorIdTurnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://softcitws.soft.pucp.edu.pe/TurnoWS/obtenerPorIdTurnoRequest", ReplyAction="http://softcitws.soft.pucp.edu.pe/TurnoWS/obtenerPorIdTurnoResponse")]
        System.Threading.Tasks.Task<SoftBO.turnoWS.obtenerPorIdTurnoResponse> obtenerPorIdTurnoAsync(SoftBO.turnoWS.obtenerPorIdTurnoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://softcitws.soft.pucp.edu.pe/TurnoWS/listarTodosTurnoRequest", ReplyAction="http://softcitws.soft.pucp.edu.pe/TurnoWS/listarTodosTurnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SoftBO.turnoWS.listarTodosTurnoResponse listarTodosTurno(SoftBO.turnoWS.listarTodosTurnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://softcitws.soft.pucp.edu.pe/TurnoWS/listarTodosTurnoRequest", ReplyAction="http://softcitws.soft.pucp.edu.pe/TurnoWS/listarTodosTurnoResponse")]
        System.Threading.Tasks.Task<SoftBO.turnoWS.listarTodosTurnoResponse> listarTodosTurnoAsync(SoftBO.turnoWS.listarTodosTurnoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://softcitws.soft.pucp.edu.pe/TurnoWS/modificarTurnoRequest", ReplyAction="http://softcitws.soft.pucp.edu.pe/TurnoWS/modificarTurnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SoftBO.turnoWS.modificarTurnoResponse modificarTurno(SoftBO.turnoWS.modificarTurnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://softcitws.soft.pucp.edu.pe/TurnoWS/modificarTurnoRequest", ReplyAction="http://softcitws.soft.pucp.edu.pe/TurnoWS/modificarTurnoResponse")]
        System.Threading.Tasks.Task<SoftBO.turnoWS.modificarTurnoResponse> modificarTurnoAsync(SoftBO.turnoWS.modificarTurnoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/")]
    public partial class turnoDTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private estadoGeneral estadoGeneralField;
        
        private bool estadoGeneralFieldSpecified;
        
        private System.DateTime horaFinField;
        
        private bool horaFinFieldSpecified;
        
        private System.DateTime horaInicioField;
        
        private bool horaInicioFieldSpecified;
        
        private int idTurnoField;
        
        private bool idTurnoFieldSpecified;
        
        private string nombreTurnoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public estadoGeneral estadoGeneral {
            get {
                return this.estadoGeneralField;
            }
            set {
                this.estadoGeneralField = value;
                this.RaisePropertyChanged("estadoGeneral");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estadoGeneralSpecified {
            get {
                return this.estadoGeneralFieldSpecified;
            }
            set {
                this.estadoGeneralFieldSpecified = value;
                this.RaisePropertyChanged("estadoGeneralSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public System.DateTime horaFin {
            get {
                return this.horaFinField;
            }
            set {
                this.horaFinField = value;
                this.RaisePropertyChanged("horaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horaFinSpecified {
            get {
                return this.horaFinFieldSpecified;
            }
            set {
                this.horaFinFieldSpecified = value;
                this.RaisePropertyChanged("horaFinSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime horaInicio {
            get {
                return this.horaInicioField;
            }
            set {
                this.horaInicioField = value;
                this.RaisePropertyChanged("horaInicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horaInicioSpecified {
            get {
                return this.horaInicioFieldSpecified;
            }
            set {
                this.horaInicioFieldSpecified = value;
                this.RaisePropertyChanged("horaInicioSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idTurno {
            get {
                return this.idTurnoField;
            }
            set {
                this.idTurnoField = value;
                this.RaisePropertyChanged("idTurno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idTurnoSpecified {
            get {
                return this.idTurnoFieldSpecified;
            }
            set {
                this.idTurnoFieldSpecified = value;
                this.RaisePropertyChanged("idTurnoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombreTurno {
            get {
                return this.nombreTurnoField;
            }
            set {
                this.nombreTurnoField = value;
                this.RaisePropertyChanged("nombreTurno");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/")]
    public enum estadoGeneral {
        
        /// <remarks/>
        INACTIVO,
        
        /// <remarks/>
        ACTIVO,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPorIdTurno", WrapperNamespace="http://softcitws.soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class obtenerPorIdTurnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idTurno;
        
        public obtenerPorIdTurnoRequest() {
        }
        
        public obtenerPorIdTurnoRequest(int idTurno) {
            this.idTurno = idTurno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPorIdTurnoResponse", WrapperNamespace="http://softcitws.soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class obtenerPorIdTurnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoftBO.turnoWS.turnoDTO @return;
        
        public obtenerPorIdTurnoResponse() {
        }
        
        public obtenerPorIdTurnoResponse(SoftBO.turnoWS.turnoDTO @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarTodosTurno", WrapperNamespace="http://softcitws.soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarTodosTurnoRequest {
        
        public listarTodosTurnoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarTodosTurnoResponse", WrapperNamespace="http://softcitws.soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarTodosTurnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoftBO.turnoWS.turnoDTO[] @return;
        
        public listarTodosTurnoResponse() {
        }
        
        public listarTodosTurnoResponse(SoftBO.turnoWS.turnoDTO[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarTurno", WrapperNamespace="http://softcitws.soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarTurnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoftBO.turnoWS.turnoDTO turno;
        
        public modificarTurnoRequest() {
        }
        
        public modificarTurnoRequest(SoftBO.turnoWS.turnoDTO turno) {
            this.turno = turno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarTurnoResponse", WrapperNamespace="http://softcitws.soft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarTurnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://softcitws.soft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarTurnoResponse() {
        }
        
        public modificarTurnoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TurnoWSChannel : SoftBO.turnoWS.TurnoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TurnoWSClient : System.ServiceModel.ClientBase<SoftBO.turnoWS.TurnoWS>, SoftBO.turnoWS.TurnoWS {
        
        public TurnoWSClient() {
        }
        
        public TurnoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TurnoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TurnoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TurnoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoftBO.turnoWS.obtenerPorIdTurnoResponse SoftBO.turnoWS.TurnoWS.obtenerPorIdTurno(SoftBO.turnoWS.obtenerPorIdTurnoRequest request) {
            return base.Channel.obtenerPorIdTurno(request);
        }
        
        public SoftBO.turnoWS.turnoDTO obtenerPorIdTurno(int idTurno) {
            SoftBO.turnoWS.obtenerPorIdTurnoRequest inValue = new SoftBO.turnoWS.obtenerPorIdTurnoRequest();
            inValue.idTurno = idTurno;
            SoftBO.turnoWS.obtenerPorIdTurnoResponse retVal = ((SoftBO.turnoWS.TurnoWS)(this)).obtenerPorIdTurno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoftBO.turnoWS.obtenerPorIdTurnoResponse> SoftBO.turnoWS.TurnoWS.obtenerPorIdTurnoAsync(SoftBO.turnoWS.obtenerPorIdTurnoRequest request) {
            return base.Channel.obtenerPorIdTurnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoftBO.turnoWS.obtenerPorIdTurnoResponse> obtenerPorIdTurnoAsync(int idTurno) {
            SoftBO.turnoWS.obtenerPorIdTurnoRequest inValue = new SoftBO.turnoWS.obtenerPorIdTurnoRequest();
            inValue.idTurno = idTurno;
            return ((SoftBO.turnoWS.TurnoWS)(this)).obtenerPorIdTurnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoftBO.turnoWS.listarTodosTurnoResponse SoftBO.turnoWS.TurnoWS.listarTodosTurno(SoftBO.turnoWS.listarTodosTurnoRequest request) {
            return base.Channel.listarTodosTurno(request);
        }
        
        public SoftBO.turnoWS.turnoDTO[] listarTodosTurno() {
            SoftBO.turnoWS.listarTodosTurnoRequest inValue = new SoftBO.turnoWS.listarTodosTurnoRequest();
            SoftBO.turnoWS.listarTodosTurnoResponse retVal = ((SoftBO.turnoWS.TurnoWS)(this)).listarTodosTurno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoftBO.turnoWS.listarTodosTurnoResponse> SoftBO.turnoWS.TurnoWS.listarTodosTurnoAsync(SoftBO.turnoWS.listarTodosTurnoRequest request) {
            return base.Channel.listarTodosTurnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoftBO.turnoWS.listarTodosTurnoResponse> listarTodosTurnoAsync() {
            SoftBO.turnoWS.listarTodosTurnoRequest inValue = new SoftBO.turnoWS.listarTodosTurnoRequest();
            return ((SoftBO.turnoWS.TurnoWS)(this)).listarTodosTurnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoftBO.turnoWS.modificarTurnoResponse SoftBO.turnoWS.TurnoWS.modificarTurno(SoftBO.turnoWS.modificarTurnoRequest request) {
            return base.Channel.modificarTurno(request);
        }
        
        public int modificarTurno(SoftBO.turnoWS.turnoDTO turno) {
            SoftBO.turnoWS.modificarTurnoRequest inValue = new SoftBO.turnoWS.modificarTurnoRequest();
            inValue.turno = turno;
            SoftBO.turnoWS.modificarTurnoResponse retVal = ((SoftBO.turnoWS.TurnoWS)(this)).modificarTurno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoftBO.turnoWS.modificarTurnoResponse> SoftBO.turnoWS.TurnoWS.modificarTurnoAsync(SoftBO.turnoWS.modificarTurnoRequest request) {
            return base.Channel.modificarTurnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoftBO.turnoWS.modificarTurnoResponse> modificarTurnoAsync(SoftBO.turnoWS.turnoDTO turno) {
            SoftBO.turnoWS.modificarTurnoRequest inValue = new SoftBO.turnoWS.modificarTurnoRequest();
            inValue.turno = turno;
            return ((SoftBO.turnoWS.TurnoWS)(this)).modificarTurnoAsync(inValue);
        }
    }
}
