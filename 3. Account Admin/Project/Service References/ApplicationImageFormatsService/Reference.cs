﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountAdminSite.ApplicationImageFormatsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageFormatGroupTypeModel", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Application.Images.Formats.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class ImageFormatGroupTypeModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ImageFormatGroupTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupTypeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupTypeNameKeyField;
        
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
        public System.Guid ImageFormatGroupTypeID {
            get {
                return this.ImageFormatGroupTypeIDField;
            }
            set {
                if ((this.ImageFormatGroupTypeIDField.Equals(value) != true)) {
                    this.ImageFormatGroupTypeIDField = value;
                    this.RaisePropertyChanged("ImageFormatGroupTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupTypeName {
            get {
                return this.ImageFormatGroupTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupTypeNameField, value) != true)) {
                    this.ImageFormatGroupTypeNameField = value;
                    this.RaisePropertyChanged("ImageFormatGroupTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupTypeNameKey {
            get {
                return this.ImageFormatGroupTypeNameKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupTypeNameKeyField, value) != true)) {
                    this.ImageFormatGroupTypeNameKeyField = value;
                    this.RaisePropertyChanged("ImageFormatGroupTypeNameKey");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageFormatGroupModel", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Application.Images.Formats.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class ImageFormatGroupModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AllowDeletionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ImageFormatGroupIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupNameKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupTypeNameKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AccountAdminSite.ApplicationImageFormatsService.ImageFormatModel[] ImageFormatsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VisibleField;
        
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
        public bool AllowDeletion {
            get {
                return this.AllowDeletionField;
            }
            set {
                if ((this.AllowDeletionField.Equals(value) != true)) {
                    this.AllowDeletionField = value;
                    this.RaisePropertyChanged("AllowDeletion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ImageFormatGroupID {
            get {
                return this.ImageFormatGroupIDField;
            }
            set {
                if ((this.ImageFormatGroupIDField.Equals(value) != true)) {
                    this.ImageFormatGroupIDField = value;
                    this.RaisePropertyChanged("ImageFormatGroupID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupName {
            get {
                return this.ImageFormatGroupNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupNameField, value) != true)) {
                    this.ImageFormatGroupNameField = value;
                    this.RaisePropertyChanged("ImageFormatGroupName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupNameKey {
            get {
                return this.ImageFormatGroupNameKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupNameKeyField, value) != true)) {
                    this.ImageFormatGroupNameKeyField = value;
                    this.RaisePropertyChanged("ImageFormatGroupNameKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupTypeNameKey {
            get {
                return this.ImageFormatGroupTypeNameKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupTypeNameKeyField, value) != true)) {
                    this.ImageFormatGroupTypeNameKeyField = value;
                    this.RaisePropertyChanged("ImageFormatGroupTypeNameKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AccountAdminSite.ApplicationImageFormatsService.ImageFormatModel[] ImageFormats {
            get {
                return this.ImageFormatsField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatsField, value) != true)) {
                    this.ImageFormatsField = value;
                    this.RaisePropertyChanged("ImageFormats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Visible {
            get {
                return this.VisibleField;
            }
            set {
                if ((this.VisibleField.Equals(value) != true)) {
                    this.VisibleField = value;
                    this.RaisePropertyChanged("Visible");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ImageFormatModel", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Application.Images.Formats.Mo" +
        "dels")]
    [System.SerializableAttribute()]
    public partial class ImageFormatModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AllowDeletionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool GalleryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupNameKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatGroupTypeNameKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ImageFormatIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageFormatNameKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ListingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VisibleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WidthField;
        
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
        public bool AllowDeletion {
            get {
                return this.AllowDeletionField;
            }
            set {
                if ((this.AllowDeletionField.Equals(value) != true)) {
                    this.AllowDeletionField = value;
                    this.RaisePropertyChanged("AllowDeletion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Gallery {
            get {
                return this.GalleryField;
            }
            set {
                if ((this.GalleryField.Equals(value) != true)) {
                    this.GalleryField = value;
                    this.RaisePropertyChanged("Gallery");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupNameKey {
            get {
                return this.ImageFormatGroupNameKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupNameKeyField, value) != true)) {
                    this.ImageFormatGroupNameKeyField = value;
                    this.RaisePropertyChanged("ImageFormatGroupNameKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatGroupTypeNameKey {
            get {
                return this.ImageFormatGroupTypeNameKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatGroupTypeNameKeyField, value) != true)) {
                    this.ImageFormatGroupTypeNameKeyField = value;
                    this.RaisePropertyChanged("ImageFormatGroupTypeNameKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ImageFormatID {
            get {
                return this.ImageFormatIDField;
            }
            set {
                if ((this.ImageFormatIDField.Equals(value) != true)) {
                    this.ImageFormatIDField = value;
                    this.RaisePropertyChanged("ImageFormatID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatName {
            get {
                return this.ImageFormatNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatNameField, value) != true)) {
                    this.ImageFormatNameField = value;
                    this.RaisePropertyChanged("ImageFormatName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageFormatNameKey {
            get {
                return this.ImageFormatNameKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageFormatNameKeyField, value) != true)) {
                    this.ImageFormatNameKeyField = value;
                    this.RaisePropertyChanged("ImageFormatNameKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Listing {
            get {
                return this.ListingField;
            }
            set {
                if ((this.ListingField.Equals(value) != true)) {
                    this.ListingField = value;
                    this.RaisePropertyChanged("Listing");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Visible {
            get {
                return this.VisibleField;
            }
            set {
                if ((this.VisibleField.Equals(value) != true)) {
                    this.VisibleField = value;
                    this.RaisePropertyChanged("Visible");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Width {
            get {
                return this.WidthField;
            }
            set {
                if ((this.WidthField.Equals(value) != true)) {
                    this.WidthField = value;
                    this.RaisePropertyChanged("Width");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequesterType", Namespace="http://schemas.datacontract.org/2004/07/Sahara.Core.Platform.Requests.Models")]
    public enum RequesterType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PlatformUser = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AccountUser = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Exempt = 2,
    }
    
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ApplicationImageFormatsService.IApplicationImageFormatsService")]
    public interface IApplicationImageFormatsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/GetImageFormatGroupTypes", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/GetImageFormatGroupTypesRespon" +
            "se")]
        AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupTypeModel[] GetImageFormatGroupTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/GetImageFormatGroupTypes", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/GetImageFormatGroupTypesRespon" +
            "se")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupTypeModel[]> GetImageFormatGroupTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/GetImageFormats", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/GetImageFormatsResponse")]
        AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupModel[] GetImageFormats(string accountNameKey, string imageFormatGroupTypeNameKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/GetImageFormats", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/GetImageFormatsResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupModel[]> GetImageFormatsAsync(string accountNameKey, string imageFormatGroupTypeNameKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/CreateImageGroup", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/CreateImageGroupResponse")]
        AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType CreateImageGroup(string accountNameKey, string imageGroupTypeNameKey, string imageGroupName, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/CreateImageGroup", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/CreateImageGroupResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> CreateImageGroupAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupName, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/CreateImageFormat", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/CreateImageFormatResponse")]
        AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType CreateImageFormat(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatName, int width, int height, bool listing, bool gallery, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/CreateImageFormat", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/CreateImageFormatResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> CreateImageFormatAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatName, int width, int height, bool listing, bool gallery, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/DeleteImageGroup", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/DeleteImageGroupResponse")]
        AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType DeleteImageGroup(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/DeleteImageGroup", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/DeleteImageGroupResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> DeleteImageGroupAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/DeleteImageFormat", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/DeleteImageFormatResponse")]
        AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType DeleteImageFormat(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationImageFormatsService/DeleteImageFormat", ReplyAction="http://tempuri.org/IApplicationImageFormatsService/DeleteImageFormatResponse")]
        System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> DeleteImageFormatAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationImageFormatsServiceChannel : AccountAdminSite.ApplicationImageFormatsService.IApplicationImageFormatsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationImageFormatsServiceClient : System.ServiceModel.ClientBase<AccountAdminSite.ApplicationImageFormatsService.IApplicationImageFormatsService>, AccountAdminSite.ApplicationImageFormatsService.IApplicationImageFormatsService {
        
        public ApplicationImageFormatsServiceClient() {
        }
        
        public ApplicationImageFormatsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationImageFormatsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationImageFormatsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationImageFormatsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupTypeModel[] GetImageFormatGroupTypes() {
            return base.Channel.GetImageFormatGroupTypes();
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupTypeModel[]> GetImageFormatGroupTypesAsync() {
            return base.Channel.GetImageFormatGroupTypesAsync();
        }
        
        public AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupModel[] GetImageFormats(string accountNameKey, string imageFormatGroupTypeNameKey) {
            return base.Channel.GetImageFormats(accountNameKey, imageFormatGroupTypeNameKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.ImageFormatGroupModel[]> GetImageFormatsAsync(string accountNameKey, string imageFormatGroupTypeNameKey) {
            return base.Channel.GetImageFormatsAsync(accountNameKey, imageFormatGroupTypeNameKey);
        }
        
        public AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType CreateImageGroup(string accountNameKey, string imageGroupTypeNameKey, string imageGroupName, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.CreateImageGroup(accountNameKey, imageGroupTypeNameKey, imageGroupName, requesterId, requesterType, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> CreateImageGroupAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupName, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.CreateImageGroupAsync(accountNameKey, imageGroupTypeNameKey, imageGroupName, requesterId, requesterType, sharedClientKey);
        }
        
        public AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType CreateImageFormat(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatName, int width, int height, bool listing, bool gallery, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.CreateImageFormat(accountNameKey, imageGroupTypeNameKey, imageGroupNameKey, imageFormatName, width, height, listing, gallery, requesterId, requesterType, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> CreateImageFormatAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatName, int width, int height, bool listing, bool gallery, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.CreateImageFormatAsync(accountNameKey, imageGroupTypeNameKey, imageGroupNameKey, imageFormatName, width, height, listing, gallery, requesterId, requesterType, sharedClientKey);
        }
        
        public AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType DeleteImageGroup(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.DeleteImageGroup(accountNameKey, imageGroupTypeNameKey, imageGroupNameKey, requesterId, requesterType, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> DeleteImageGroupAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.DeleteImageGroupAsync(accountNameKey, imageGroupTypeNameKey, imageGroupNameKey, requesterId, requesterType, sharedClientKey);
        }
        
        public AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType DeleteImageFormat(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.DeleteImageFormat(accountNameKey, imageGroupTypeNameKey, imageGroupNameKey, imageFormatNameKey, requesterId, requesterType, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<AccountAdminSite.ApplicationImageFormatsService.DataAccessResponseType> DeleteImageFormatAsync(string accountNameKey, string imageGroupTypeNameKey, string imageGroupNameKey, string imageFormatNameKey, string requesterId, AccountAdminSite.ApplicationImageFormatsService.RequesterType requesterType, string sharedClientKey) {
            return base.Channel.DeleteImageFormatAsync(accountNameKey, imageGroupTypeNameKey, imageGroupNameKey, imageFormatNameKey, requesterId, requesterType, sharedClientKey);
        }
    }
}
