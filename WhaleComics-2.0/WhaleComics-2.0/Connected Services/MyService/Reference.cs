﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.28307.1000
// 
namespace WhaleComics_2._0.MyService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="UserList", Namespace="http://schemas.datacontract.org/2004/07/WhaleComicsDataBase", ItemName="User")]
    public class UserList : System.Collections.ObjectModel.ObservableCollection<WhaleComics_2._0.MyService.User> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WhaleComicsDataBase")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string UserAddressField;
        
        private string UserEmailField;
        
        private string UserNameField;
        
        private string UserPasswordField;
        
        private string UserPhoneNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserAddress {
            get {
                return this.UserAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.UserAddressField, value) != true)) {
                    this.UserAddressField = value;
                    this.RaisePropertyChanged("UserAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserEmail {
            get {
                return this.UserEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.UserEmailField, value) != true)) {
                    this.UserEmailField = value;
                    this.RaisePropertyChanged("UserEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPassword {
            get {
                return this.UserPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPasswordField, value) != true)) {
                    this.UserPasswordField = value;
                    this.RaisePropertyChanged("UserPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPhoneNumber {
            get {
                return this.UserPhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPhoneNumberField, value) != true)) {
                    this.UserPhoneNumberField = value;
                    this.RaisePropertyChanged("UserPhoneNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WhaleComicsDataBase")]
    public partial class Product : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ProductImageField;
        
        private string ProductNameField;
        
        private int ProductNumberField;
        
        private int ProductPriceField;
        
        private int ProductQuanityField;
        
        private string ProductTypeField;
        
        private string PruductGenreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImage {
            get {
                return this.ProductImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductImageField, value) != true)) {
                    this.ProductImageField = value;
                    this.RaisePropertyChanged("ProductImage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductNumber {
            get {
                return this.ProductNumberField;
            }
            set {
                if ((this.ProductNumberField.Equals(value) != true)) {
                    this.ProductNumberField = value;
                    this.RaisePropertyChanged("ProductNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductPrice {
            get {
                return this.ProductPriceField;
            }
            set {
                if ((this.ProductPriceField.Equals(value) != true)) {
                    this.ProductPriceField = value;
                    this.RaisePropertyChanged("ProductPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductQuanity {
            get {
                return this.ProductQuanityField;
            }
            set {
                if ((this.ProductQuanityField.Equals(value) != true)) {
                    this.ProductQuanityField = value;
                    this.RaisePropertyChanged("ProductQuanity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductType {
            get {
                return this.ProductTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductTypeField, value) != true)) {
                    this.ProductTypeField = value;
                    this.RaisePropertyChanged("ProductType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PruductGenre {
            get {
                return this.PruductGenreField;
            }
            set {
                if ((object.ReferenceEquals(this.PruductGenreField, value) != true)) {
                    this.PruductGenreField = value;
                    this.RaisePropertyChanged("PruductGenre");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ProductList", Namespace="http://schemas.datacontract.org/2004/07/WhaleComicsDataBase", ItemName="Product")]
    public class ProductList : System.Collections.ObjectModel.ObservableCollection<WhaleComics_2._0.MyService.Product> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IMethods")]
    public interface IMethods {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SelectAllUsers", ReplyAction="http://tempuri.org/IMethods/SelectAllUsersResponse")]
        System.Threading.Tasks.Task<WhaleComics_2._0.MyService.UserList> SelectAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SelectUserByName", ReplyAction="http://tempuri.org/IMethods/SelectUserByNameResponse")]
        System.Threading.Tasks.Task<WhaleComics_2._0.MyService.User> SelectUserByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/InsertNewUser", ReplyAction="http://tempuri.org/IMethods/InsertNewUserResponse")]
        System.Threading.Tasks.Task InsertNewUserAsync(WhaleComics_2._0.MyService.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SelectUserByNameAndPassword", ReplyAction="http://tempuri.org/IMethods/SelectUserByNameAndPasswordResponse")]
        System.Threading.Tasks.Task<WhaleComics_2._0.MyService.User> SelectUserByNameAndPasswordAsync(string name, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SelectProductByName", ReplyAction="http://tempuri.org/IMethods/SelectProductByNameResponse")]
        System.Threading.Tasks.Task<WhaleComics_2._0.MyService.Product> SelectProductByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SelectAllProduct", ReplyAction="http://tempuri.org/IMethods/SelectAllProductResponse")]
        System.Threading.Tasks.Task<WhaleComics_2._0.MyService.ProductList> SelectAllProductAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMethods/SelectProductByNumber", ReplyAction="http://tempuri.org/IMethods/SelectProductByNumberResponse")]
        System.Threading.Tasks.Task<WhaleComics_2._0.MyService.Product> SelectProductByNumberAsync(int prodNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMethodsChannel : WhaleComics_2._0.MyService.IMethods, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MethodsClient : System.ServiceModel.ClientBase<WhaleComics_2._0.MyService.IMethods>, WhaleComics_2._0.MyService.IMethods {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MethodsClient() : 
                base(MethodsClient.GetDefaultBinding(), MethodsClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMethods.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MethodsClient(EndpointConfiguration endpointConfiguration) : 
                base(MethodsClient.GetBindingForEndpoint(endpointConfiguration), MethodsClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MethodsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MethodsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MethodsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MethodsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MethodsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<WhaleComics_2._0.MyService.UserList> SelectAllUsersAsync() {
            return base.Channel.SelectAllUsersAsync();
        }
        
        public System.Threading.Tasks.Task<WhaleComics_2._0.MyService.User> SelectUserByNameAsync(string name) {
            return base.Channel.SelectUserByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task InsertNewUserAsync(WhaleComics_2._0.MyService.User u) {
            return base.Channel.InsertNewUserAsync(u);
        }
        
        public System.Threading.Tasks.Task<WhaleComics_2._0.MyService.User> SelectUserByNameAndPasswordAsync(string name, string pass) {
            return base.Channel.SelectUserByNameAndPasswordAsync(name, pass);
        }
        
        public System.Threading.Tasks.Task<WhaleComics_2._0.MyService.Product> SelectProductByNameAsync(string name) {
            return base.Channel.SelectProductByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<WhaleComics_2._0.MyService.ProductList> SelectAllProductAsync() {
            return base.Channel.SelectAllProductAsync();
        }
        
        public System.Threading.Tasks.Task<WhaleComics_2._0.MyService.Product> SelectProductByNumberAsync(int prodNumber) {
            return base.Channel.SelectProductByNumberAsync(prodNumber);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMethods)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMethods)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WhaleComics/Methods/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return MethodsClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMethods);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return MethodsClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMethods);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IMethods,
        }
    }
}
