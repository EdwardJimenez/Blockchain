﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WABlockchain.SWADBlockchainService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EBUser", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class EBUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdRolUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNetvalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime lastUpdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime registerDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string statusField;
        private string usuarioNetvalle;
        private string rolUser;
        private string title;

        public EBUser(string email, string password, string usuarioNetvalle, string rolUser, string title)
        {
            Email = email;
            Password = password;
            this.usuarioNetvalle = usuarioNetvalle;
            this.rolUser = rolUser;
            this.title = title;
        }

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdRolUser {
            get {
                return this.IdRolUserField;
            }
            set {
                if ((object.ReferenceEquals(this.IdRolUserField, value) != true)) {
                    this.IdRolUserField = value;
                    this.RaisePropertyChanged("IdRolUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdTitle {
            get {
                return this.IdTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.IdTitleField, value) != true)) {
                    this.IdTitleField = value;
                    this.RaisePropertyChanged("IdTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdUser {
            get {
                return this.IdUserField;
            }
            set {
                if ((object.ReferenceEquals(this.IdUserField, value) != true)) {
                    this.IdUserField = value;
                    this.RaisePropertyChanged("IdUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserNetvalle {
            get {
                return this.UserNetvalleField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNetvalleField, value) != true)) {
                    this.UserNetvalleField = value;
                    this.RaisePropertyChanged("UserNetvalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime lastUpdate {
            get {
                return this.lastUpdateField;
            }
            set {
                if ((this.lastUpdateField.Equals(value) != true)) {
                    this.lastUpdateField = value;
                    this.RaisePropertyChanged("lastUpdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime registerDate {
            get {
                return this.registerDateField;
            }
            set {
                if ((this.registerDateField.Equals(value) != true)) {
                    this.registerDateField = value;
                    this.RaisePropertyChanged("registerDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status {
            get {
                return this.statusField;
            }
            set {
                if ((object.ReferenceEquals(this.statusField, value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SWADBlockchainService.ISWADNETBlockchain")]
    public interface ISWADNETBlockchain {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Obtener_User_O", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Obtener_User_OResponse")]
        WABlockchain.SWADBlockchainService.EBUser[] Obtener_User_O();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Obtener_User_O", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Obtener_User_OResponse")]
        System.Threading.Tasks.Task<WABlockchain.SWADBlockchainService.EBUser[]> Obtener_User_OAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Obtener_BUser_O_iduser", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Obtener_BUser_O_iduserResponse")]
        WABlockchain.SWADBlockchainService.EBUser Obtener_BUser_O_iduser(string Id_User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Obtener_BUser_O_iduser", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Obtener_BUser_O_iduserResponse")]
        System.Threading.Tasks.Task<WABlockchain.SWADBlockchainService.EBUser> Obtener_BUser_O_iduserAsync(string Id_User);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Insertar_BUser_I_idUser_email", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Insertar_BUser_I_idUser_emailResponse")]
        void Insertar_BUser_I_idUser_email(WABlockchain.SWADBlockchainService.EBUser eBUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Insertar_BUser_I_idUser_email", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Insertar_BUser_I_idUser_emailResponse")]
        System.Threading.Tasks.Task Insertar_BUser_I_idUser_emailAsync(WABlockchain.SWADBlockchainService.EBUser eBUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Actualizar_BUser_I_idUser_email", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Actualizar_BUser_I_idUser_emailResponse")]
        void Actualizar_BUser_I_idUser_email(WABlockchain.SWADBlockchainService.EBUser eBUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISWADNETBlockchain/Actualizar_BUser_I_idUser_email", ReplyAction="http://tempuri.org/ISWADNETBlockchain/Actualizar_BUser_I_idUser_emailResponse")]
        System.Threading.Tasks.Task Actualizar_BUser_I_idUser_emailAsync(WABlockchain.SWADBlockchainService.EBUser eBUser);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISWADNETBlockchainChannel : WABlockchain.SWADBlockchainService.ISWADNETBlockchain, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SWADNETBlockchainClient : System.ServiceModel.ClientBase<WABlockchain.SWADBlockchainService.ISWADNETBlockchain>, WABlockchain.SWADBlockchainService.ISWADNETBlockchain {
        
        public SWADNETBlockchainClient() {
        }
        
        public SWADNETBlockchainClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SWADNETBlockchainClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SWADNETBlockchainClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SWADNETBlockchainClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WABlockchain.SWADBlockchainService.EBUser[] Obtener_User_O() {
            return base.Channel.Obtener_User_O();
        }
        
        public System.Threading.Tasks.Task<WABlockchain.SWADBlockchainService.EBUser[]> Obtener_User_OAsync() {
            return base.Channel.Obtener_User_OAsync();
        }
        
        public WABlockchain.SWADBlockchainService.EBUser Obtener_BUser_O_iduser(string Id_User) {
            return base.Channel.Obtener_BUser_O_iduser(Id_User);
        }
        
        public System.Threading.Tasks.Task<WABlockchain.SWADBlockchainService.EBUser> Obtener_BUser_O_iduserAsync(string Id_User) {
            return base.Channel.Obtener_BUser_O_iduserAsync(Id_User);
        }
        
        public void Insertar_BUser_I_idUser_email(WABlockchain.SWADBlockchainService.EBUser eBUser) {
            base.Channel.Insertar_BUser_I_idUser_email(eBUser);
        }
        
        public System.Threading.Tasks.Task Insertar_BUser_I_idUser_emailAsync(WABlockchain.SWADBlockchainService.EBUser eBUser) {
            return base.Channel.Insertar_BUser_I_idUser_emailAsync(eBUser);
        }
        
        public void Actualizar_BUser_I_idUser_email(WABlockchain.SWADBlockchainService.EBUser eBUser) {
            base.Channel.Actualizar_BUser_I_idUser_email(eBUser);
        }
        
        public System.Threading.Tasks.Task Actualizar_BUser_I_idUser_emailAsync(WABlockchain.SWADBlockchainService.EBUser eBUser) {
            return base.Channel.Actualizar_BUser_I_idUser_emailAsync(eBUser);
        }
    }
}
