﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlatformAdminSite.InfrastructureTestsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InfrastructureTestsService.IInfrastructureTestsService")]
    public interface IInfrastructureTestsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfrastructureTestsService/PerformanceTest_InternalCaching_Ge" +
            "tAccounts", ReplyAction="http://tempuri.org/IInfrastructureTestsService/PerformanceTest_InternalCaching_Ge" +
            "tAccountsResponse")]
        string PerformanceTest_InternalCaching_GetAccounts(bool useCache, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfrastructureTestsService/PerformanceTest_InternalCaching_Ge" +
            "tAccounts", ReplyAction="http://tempuri.org/IInfrastructureTestsService/PerformanceTest_InternalCaching_Ge" +
            "tAccountsResponse")]
        System.Threading.Tasks.Task<string> PerformanceTest_InternalCaching_GetAccountsAsync(bool useCache, string sharedClientKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfrastructureTestsService/GetCurrentNodeName", ReplyAction="http://tempuri.org/IInfrastructureTestsService/GetCurrentNodeNameResponse")]
        string GetCurrentNodeName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfrastructureTestsService/GetCurrentNodeName", ReplyAction="http://tempuri.org/IInfrastructureTestsService/GetCurrentNodeNameResponse")]
        System.Threading.Tasks.Task<string> GetCurrentNodeNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfrastructureTestsService/SendTestEmail", ReplyAction="http://tempuri.org/IInfrastructureTestsService/SendTestEmailResponse")]
        bool SendTestEmail(string email, string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInfrastructureTestsService/SendTestEmail", ReplyAction="http://tempuri.org/IInfrastructureTestsService/SendTestEmailResponse")]
        System.Threading.Tasks.Task<bool> SendTestEmailAsync(string email, string subject, string body);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInfrastructureTestsServiceChannel : PlatformAdminSite.InfrastructureTestsService.IInfrastructureTestsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InfrastructureTestsServiceClient : System.ServiceModel.ClientBase<PlatformAdminSite.InfrastructureTestsService.IInfrastructureTestsService>, PlatformAdminSite.InfrastructureTestsService.IInfrastructureTestsService {
        
        public InfrastructureTestsServiceClient() {
        }
        
        public InfrastructureTestsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InfrastructureTestsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfrastructureTestsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InfrastructureTestsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PerformanceTest_InternalCaching_GetAccounts(bool useCache, string sharedClientKey) {
            return base.Channel.PerformanceTest_InternalCaching_GetAccounts(useCache, sharedClientKey);
        }
        
        public System.Threading.Tasks.Task<string> PerformanceTest_InternalCaching_GetAccountsAsync(bool useCache, string sharedClientKey) {
            return base.Channel.PerformanceTest_InternalCaching_GetAccountsAsync(useCache, sharedClientKey);
        }
        
        public string GetCurrentNodeName() {
            return base.Channel.GetCurrentNodeName();
        }
        
        public System.Threading.Tasks.Task<string> GetCurrentNodeNameAsync() {
            return base.Channel.GetCurrentNodeNameAsync();
        }
        
        public bool SendTestEmail(string email, string subject, string body) {
            return base.Channel.SendTestEmail(email, subject, body);
        }
        
        public System.Threading.Tasks.Task<bool> SendTestEmailAsync(string email, string subject, string body) {
            return base.Channel.SendTestEmailAsync(email, subject, body);
        }
    }
}
