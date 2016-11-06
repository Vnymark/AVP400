﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAdmin.ServiceReference {
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
        private WindowsFormsAdmin.ServiceReference.Author AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AuthorIdField;
        
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
        public WindowsFormsAdmin.ServiceReference.Author Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> AuthorId {
            get {
                return this.AuthorIdField;
            }
            set {
                if ((this.AuthorIdField.Equals(value) != true)) {
                    this.AuthorIdField = value;
                    this.RaisePropertyChanged("AuthorId");
                }
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Author", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Author : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsAdmin.ServiceReference.Book[] BookField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public WindowsFormsAdmin.ServiceReference.Book[] Book {
            get {
                return this.BookField;
            }
            set {
                if ((object.ReferenceEquals(this.BookField, value) != true)) {
                    this.BookField = value;
                    this.RaisePropertyChanged("Book");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookAuthor", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class BookAuthor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string URLField;
        
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
        public string AuthorName {
            get {
                return this.AuthorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorNameField, value) != true)) {
                    this.AuthorNameField = value;
                    this.RaisePropertyChanged("AuthorName");
                }
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        WindowsFormsAdmin.ServiceReference.Book[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBooks", ReplyAction="http://tempuri.org/IService1/GetBooksResponse")]
        System.Threading.Tasks.Task<WindowsFormsAdmin.ServiceReference.Book[]> GetBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        string AddBook(string name, string description, string url, short visability, int author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBook", ReplyAction="http://tempuri.org/IService1/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(string name, string description, string url, short visability, int author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditBook", ReplyAction="http://tempuri.org/IService1/EditBookResponse")]
        string EditBook(int id, string name, string description, string url, short visability, int author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditBook", ReplyAction="http://tempuri.org/IService1/EditBookResponse")]
        System.Threading.Tasks.Task<string> EditBookAsync(int id, string name, string description, string url, short visability, int author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        string DeleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBook", ReplyAction="http://tempuri.org/IService1/DeleteBookResponse")]
        System.Threading.Tasks.Task<string> DeleteBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuthor", ReplyAction="http://tempuri.org/IService1/GetAuthorResponse")]
        WindowsFormsAdmin.ServiceReference.Author[] GetAuthor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuthor", ReplyAction="http://tempuri.org/IService1/GetAuthorResponse")]
        System.Threading.Tasks.Task<WindowsFormsAdmin.ServiceReference.Author[]> GetAuthorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAuthor", ReplyAction="http://tempuri.org/IService1/AddAuthorResponse")]
        string AddAuthor(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAuthor", ReplyAction="http://tempuri.org/IService1/AddAuthorResponse")]
        System.Threading.Tasks.Task<string> AddAuthorAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditAuthor", ReplyAction="http://tempuri.org/IService1/EditAuthorResponse")]
        string EditAuthor(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditAuthor", ReplyAction="http://tempuri.org/IService1/EditAuthorResponse")]
        System.Threading.Tasks.Task<string> EditAuthorAsync(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAuthor", ReplyAction="http://tempuri.org/IService1/DeleteAuthorResponse")]
        string DeleteAuthor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAuthor", ReplyAction="http://tempuri.org/IService1/DeleteAuthorResponse")]
        System.Threading.Tasks.Task<string> DeleteAuthorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookAuthor", ReplyAction="http://tempuri.org/IService1/GetBookAuthorResponse")]
        WindowsFormsAdmin.ServiceReference.BookAuthor[] GetBookAuthor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookAuthor", ReplyAction="http://tempuri.org/IService1/GetBookAuthorResponse")]
        System.Threading.Tasks.Task<WindowsFormsAdmin.ServiceReference.BookAuthor[]> GetBookAuthorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuthorName", ReplyAction="http://tempuri.org/IService1/GetAuthorNameResponse")]
        string GetAuthorName(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuthorName", ReplyAction="http://tempuri.org/IService1/GetAuthorNameResponse")]
        System.Threading.Tasks.Task<string> GetAuthorNameAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ImportFile", ReplyAction="http://tempuri.org/IService1/ImportFileResponse")]
        void ImportFile();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ImportFile", ReplyAction="http://tempuri.org/IService1/ImportFileResponse")]
        System.Threading.Tasks.Task ImportFileAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsAdmin.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsAdmin.ServiceReference.IService1>, WindowsFormsAdmin.ServiceReference.IService1 {
        
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
        
        public WindowsFormsAdmin.ServiceReference.Book[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsAdmin.ServiceReference.Book[]> GetBooksAsync() {
            return base.Channel.GetBooksAsync();
        }
        
        public string AddBook(string name, string description, string url, short visability, int author) {
            return base.Channel.AddBook(name, description, url, visability, author);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(string name, string description, string url, short visability, int author) {
            return base.Channel.AddBookAsync(name, description, url, visability, author);
        }
        
        public string EditBook(int id, string name, string description, string url, short visability, int author) {
            return base.Channel.EditBook(id, name, description, url, visability, author);
        }
        
        public System.Threading.Tasks.Task<string> EditBookAsync(int id, string name, string description, string url, short visability, int author) {
            return base.Channel.EditBookAsync(id, name, description, url, visability, author);
        }
        
        public string DeleteBook(int id) {
            return base.Channel.DeleteBook(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBookAsync(int id) {
            return base.Channel.DeleteBookAsync(id);
        }
        
        public WindowsFormsAdmin.ServiceReference.Author[] GetAuthor() {
            return base.Channel.GetAuthor();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsAdmin.ServiceReference.Author[]> GetAuthorAsync() {
            return base.Channel.GetAuthorAsync();
        }
        
        public string AddAuthor(string name) {
            return base.Channel.AddAuthor(name);
        }
        
        public System.Threading.Tasks.Task<string> AddAuthorAsync(string name) {
            return base.Channel.AddAuthorAsync(name);
        }
        
        public string EditAuthor(int id, string name) {
            return base.Channel.EditAuthor(id, name);
        }
        
        public System.Threading.Tasks.Task<string> EditAuthorAsync(int id, string name) {
            return base.Channel.EditAuthorAsync(id, name);
        }
        
        public string DeleteAuthor(int id) {
            return base.Channel.DeleteAuthor(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAuthorAsync(int id) {
            return base.Channel.DeleteAuthorAsync(id);
        }
        
        public WindowsFormsAdmin.ServiceReference.BookAuthor[] GetBookAuthor() {
            return base.Channel.GetBookAuthor();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsAdmin.ServiceReference.BookAuthor[]> GetBookAuthorAsync() {
            return base.Channel.GetBookAuthorAsync();
        }
        
        public string GetAuthorName(System.Nullable<int> id) {
            return base.Channel.GetAuthorName(id);
        }
        
        public System.Threading.Tasks.Task<string> GetAuthorNameAsync(System.Nullable<int> id) {
            return base.Channel.GetAuthorNameAsync(id);
        }
        
        public void ImportFile() {
            base.Channel.ImportFile();
        }
        
        public System.Threading.Tasks.Task ImportFileAsync() {
            return base.Channel.ImportFileAsync();
        }
    }
}
