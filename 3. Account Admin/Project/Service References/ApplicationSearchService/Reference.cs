﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountAdminSite.ApplicationSearchService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataAccessResponseType", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Common.ResponseTypes")]
    [System.SerializableAttribute()]
    public partial class DataAccessResponseType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ErrorMessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ResultsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleInstanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuccessCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuccessMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SuccessMessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isSuccessField;
        
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
        public string ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorCodeField, value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] ErrorMessages {
            get {
                return this.ErrorMessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessagesField, value) != true)) {
                    this.ErrorMessagesField = value;
                    this.RaisePropertyChanged("ErrorMessages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Results {
            get {
                return this.ResultsField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultsField, value) != true)) {
                    this.ResultsField = value;
                    this.RaisePropertyChanged("Results");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoleInstance {
            get {
                return this.RoleInstanceField;
            }
            set {
                if ((this.RoleInstanceField.Equals(value) != true)) {
                    this.RoleInstanceField = value;
                    this.RaisePropertyChanged("RoleInstance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoleName {
            get {
                return this.RoleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleNameField, value) != true)) {
                    this.RoleNameField = value;
                    this.RaisePropertyChanged("RoleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SuccessCode {
            get {
                return this.SuccessCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SuccessCodeField, value) != true)) {
                    this.SuccessCodeField = value;
                    this.RaisePropertyChanged("SuccessCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SuccessMessage {
            get {
                return this.SuccessMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.SuccessMessageField, value) != true)) {
                    this.SuccessMessageField = value;
                    this.RaisePropertyChanged("SuccessMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] SuccessMessages {
            get {
                return this.SuccessMessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.SuccessMessagesField, value) != true)) {
                    this.SuccessMessagesField = value;
                    this.RaisePropertyChanged("SuccessMessages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isSuccess {
            get {
                return this.isSuccessField;
            }
            set {
                if ((this.isSuccessField.Equals(value) != true)) {
                    this.isSuccessField = value;
                    this.RaisePropertyChanged("isSuccess");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductSearchFacet", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Application.Search.Models.Pro" +
        "duct")]
    [System.SerializableAttribute()]
    public partial class ProductSearchFacet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BooleanOperatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SearchFieldNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ShowAdvancedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AccountAdminSite.ApplicationSearchService.FacetValue[] ValuesField;
        
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
        public string BooleanOperator {
            get {
                return this.BooleanOperatorField;
            }
            set {
                if ((object.ReferenceEquals(this.BooleanOperatorField, value) != true)) {
                    this.BooleanOperatorField = value;
                    this.RaisePropertyChanged("BooleanOperator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName {
            get {
                return this.PropertyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyNameField, value) != true)) {
                    this.PropertyNameField = value;
                    this.RaisePropertyChanged("PropertyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyType {
            get {
                return this.PropertyTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyTypeField, value) != true)) {
                    this.PropertyTypeField = value;
                    this.RaisePropertyChanged("PropertyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SearchFieldName {
            get {
                return this.SearchFieldNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SearchFieldNameField, value) != true)) {
                    this.SearchFieldNameField = value;
                    this.RaisePropertyChanged("SearchFieldName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ShowAdvanced {
            get {
                return this.ShowAdvancedField;
            }
            set {
                if ((this.ShowAdvancedField.Equals(value) != true)) {
                    this.ShowAdvancedField = value;
                    this.RaisePropertyChanged("ShowAdvanced");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AccountAdminSite.ApplicationSearchService.FacetValue[] Values {
            get {
                return this.ValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.ValuesField, value) != true)) {
                    this.ValuesField = value;
                    this.RaisePropertyChanged("Values");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FacetValue", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Application.Search.Models.Pro" +
        "duct")]
    [System.SerializableAttribute()]
    public partial class FacetValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SelectedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public string Count {
            get {
                return this.CountField;
            }
            set {
                if ((object.ReferenceEquals(this.CountField, value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Filter {
            get {
                return this.FilterField;
            }
            set {
                if ((object.ReferenceEquals(this.FilterField, value) != true)) {
                    this.FilterField = value;
                    this.RaisePropertyChanged("Filter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
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
        public bool Selected {
            get {
                return this.SelectedField;
            }
            set {
                if ((this.SelectedField.Equals(value) != true)) {
                    this.SelectedField = value;
                    this.RaisePropertyChanged("Selected");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductSearchSortable", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Application.Search.Models.Pro" +
        "duct")]
    [System.SerializableAttribute()]
    public partial class ProductSearchSortable : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrderByStringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SortLabelField;
        
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
        public string OrderByString {
            get {
                return this.OrderByStringField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderByStringField, value) != true)) {
                    this.OrderByStringField = value;
                    this.RaisePropertyChanged("OrderByString");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SortLabel {
            get {
                return this.SortLabelField;
            }
            set {
                if ((object.ReferenceEquals(this.SortLabelField, value) != true)) {
                    this.SortLabelField = value;
                    this.RaisePropertyChanged("SortLabel");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApplicationSearchService.IApplicationSearchService")]
    public interface IApplicationSearchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationSearchService/ReindexProducts", ReplyAction="http://tempuri.org/IApplicationSearchService/ReindexProductsResponse")]
        AccountAdminSite.ApplicationSearchService.DataAccessResponseType ReindexProducts(string accountNameKey, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationSearchService/ReindexProducts", ReplyAction="http://tempuri.org/IApplicationSearchService/ReindexProductsResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationSearchService.DataAccessResponseType> ReindexProductsAsync(string accountNameKey, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationSearchService/GetProductFacets", ReplyAction="http://tempuri.org/IApplicationSearchService/GetProductFacetsResponse")]
        AccountAdminSite.ApplicationSearchService.ProductSearchFacet[] GetProductFacets(string accountNameKey, bool includeHidden, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationSearchService/GetProductFacets", ReplyAction="http://tempuri.org/IApplicationSearchService/GetProductFacetsResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationSearchService.ProductSearchFacet[]> GetProductFacetsAsync(string accountNameKey, bool includeHidden, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationSearchService/GetProductSortables", ReplyAction="http://tempuri.org/IApplicationSearchService/GetProductSortablesResponse")]
        AccountAdminSite.ApplicationSearchService.ProductSearchSortable[] GetProductSortables(string accountNameKey, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationSearchService/GetProductSortables", ReplyAction="http://tempuri.org/IApplicationSearchService/GetProductSortablesResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationSearchService.ProductSearchSortable[]> GetProductSortablesAsync(string accountNameKey, string sharedClientKey);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationSearchServiceChannel : AccountAdminSite.ApplicationSearchService.IApplicationSearchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationSearchServiceClient : System.ServiceModel.ClientBase<AccountAdminSite.ApplicationSearchService.IApplicationSearchService>, AccountAdminSite.ApplicationSearchService.IApplicationSearchService {
        
        public ApplicationSearchServiceClient() {
        }
        
        public ApplicationSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AccountAdminSite.ApplicationSearchService.DataAccessResponseType ReindexProducts(string accountNameKey, string sharedClientKey) {
            return base.Channel.ReindexProducts(accountNameKey, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationSearchService.DataAccessResponseType> ReindexProductsAsync(string accountNameKey, string sharedClientKey) {
            return base.Channel.ReindexProductsAsync(accountNameKey, sharedClientKey);
        }
        
        public AccountAdminSite.ApplicationSearchService.ProductSearchFacet[] GetProductFacets(string accountNameKey, bool includeHidden, string sharedClientKey) {
            return base.Channel.GetProductFacets(accountNameKey, includeHidden, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationSearchService.ProductSearchFacet[]> GetProductFacetsAsync(string accountNameKey, bool includeHidden, string sharedClientKey) {
            return base.Channel.GetProductFacetsAsync(accountNameKey, includeHidden, sharedClientKey);
        }
        
        public AccountAdminSite.ApplicationSearchService.ProductSearchSortable[] GetProductSortables(string accountNameKey, string sharedClientKey) {
            return base.Channel.GetProductSortables(accountNameKey, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationSearchService.ProductSearchSortable[]> GetProductSortablesAsync(string accountNameKey, string sharedClientKey) {
            return base.Channel.GetProductSortablesAsync(accountNameKey, sharedClientKey);
        }
    }
}
