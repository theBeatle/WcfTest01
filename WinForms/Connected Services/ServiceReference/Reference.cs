﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForms.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Author {
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
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HelloResponse", ReplyAction="http://tempuri.org/IService1/HelloResponseResponse")]
        string HelloResponse(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HelloResponse", ReplyAction="http://tempuri.org/IService1/HelloResponseResponse")]
        System.Threading.Tasks.Task<string> HelloResponseAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SimpleCalculator", ReplyAction="http://tempuri.org/IService1/SimpleCalculatorResponse")]
        decimal SimpleCalculator(decimal a, decimal b, char @operator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SimpleCalculator", ReplyAction="http://tempuri.org/IService1/SimpleCalculatorResponse")]
        System.Threading.Tasks.Task<decimal> SimpleCalculatorAsync(decimal a, decimal b, char @operator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookById", ReplyAction="http://tempuri.org/IService1/GetBookByIdResponse")]
        WinForms.ServiceReference.Book GetBookById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBookById", ReplyAction="http://tempuri.org/IService1/GetBookByIdResponse")]
        System.Threading.Tasks.Task<WinForms.ServiceReference.Book> GetBookByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewBook", ReplyAction="http://tempuri.org/IService1/AddNewBookResponse")]
        bool AddNewBook(WinForms.ServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNewBook", ReplyAction="http://tempuri.org/IService1/AddNewBookResponse")]
        System.Threading.Tasks.Task<bool> AddNewBookAsync(WinForms.ServiceReference.Book book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WinForms.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WinForms.ServiceReference.IService1>, WinForms.ServiceReference.IService1 {
        
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
        
        public string HelloResponse(string name) {
            return base.Channel.HelloResponse(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloResponseAsync(string name) {
            return base.Channel.HelloResponseAsync(name);
        }
        
        public decimal SimpleCalculator(decimal a, decimal b, char @operator) {
            return base.Channel.SimpleCalculator(a, b, @operator);
        }
        
        public System.Threading.Tasks.Task<decimal> SimpleCalculatorAsync(decimal a, decimal b, char @operator) {
            return base.Channel.SimpleCalculatorAsync(a, b, @operator);
        }
        
        public WinForms.ServiceReference.Book GetBookById(int id) {
            return base.Channel.GetBookById(id);
        }
        
        public System.Threading.Tasks.Task<WinForms.ServiceReference.Book> GetBookByIdAsync(int id) {
            return base.Channel.GetBookByIdAsync(id);
        }
        
        public bool AddNewBook(WinForms.ServiceReference.Book book) {
            return base.Channel.AddNewBook(book);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewBookAsync(WinForms.ServiceReference.Book book) {
            return base.Channel.AddNewBookAsync(book);
        }
    }
}
