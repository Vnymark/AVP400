﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAdmin.GridServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string URLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> VisabilityField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL {
            get {
                return this.URLField;
            }
            set {
                if ((object.ReferenceEquals(this.URLField, value) != true)) {
                    this.URLField = value;
                    this.RaisePropertyChanged("URL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Visability {
            get {
                return this.VisabilityField;
            }
            set {
                if ((this.VisabilityField.Equals(value) != true)) {
                    this.VisabilityField = value;
                    this.RaisePropertyChanged("Visability");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GridServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        WindowsFormsAdmin.GridServiceReference.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        System.Threading.Tasks.Task<WindowsFormsAdmin.GridServiceReference.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        string AddBook(string name, string description, string url, short visability);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(string name, string description, string url, short visability);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditBook", ReplyAction="http://tempuri.org/IService1/EditBookResponse")]
        string EditBook(int id, string name, string description, string url, short visability);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditBook", ReplyAction="http://tempuri.org/IService1/EditBookResponse")]
        System.Threading.Tasks.Task<string> EditBookAsync(int id, string name, string description, string url, short visability);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        string DeleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        System.Threading.Tasks.Task<string> DeleteBookAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsAdmin.GridServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsAdmin.GridServiceReference.IService1>, WindowsFormsAdmin.GridServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsAdmin.GridServiceReference.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsAdmin.GridServiceReference.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public string AddBook(string name, string description, string url, short visability) {
            return base.Channel.AddBook(name, description, url, visability);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(string name, string description, string url, short visability) {
            return base.Channel.AddBookAsync(name, description, url, visability);
        }
        
        public string EditBook(int id, string name, string description, string url, short visability) {
            return base.Channel.EditBook(id, name, description, url, visability);
        }
        
        public System.Threading.Tasks.Task<string> EditBookAsync(int id, string name, string description, string url, short visability) {
            return base.Channel.EditBookAsync(id, name, description, url, visability);
        }
        
        public string DeleteBook(int id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBookAsync(int id) {
            return base.Channel.DeleteBookAsync(id);
        }
    }
}