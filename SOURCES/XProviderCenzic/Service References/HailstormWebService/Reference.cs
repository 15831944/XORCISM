﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XProviderCenzic.HailstormWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.cenzic.com/", ConfigurationName="HailstormWebService.IScanService")]
    public interface IScanService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/QueueAssessmentRun", ReplyAction="http://www.cenzic.com/IScanService/QueueAssessmentRunResponse")]
        void QueueAssessmentRun(string clientId, string requestId, string url, string assessmentType, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetStatus", ReplyAction="http://www.cenzic.com/IScanService/GetStatusResponse")]
        string GetStatus(string clientId, string requestId, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetTitanStatus", ReplyAction="http://www.cenzic.com/IScanService/GetTitanStatusResponse")]
        string GetTitanStatus(string clientId, string requestId, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetUpdatedStatuses", ReplyAction="http://www.cenzic.com/IScanService/GetUpdatedStatusesResponse")]
        string GetUpdatedStatuses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/UpdateGetStatusesReferenceTime", ReplyAction="http://www.cenzic.com/IScanService/UpdateGetStatusesReferenceTimeResponse")]
        void UpdateGetStatusesReferenceTime(string lastStatusTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetResults", ReplyAction="http://www.cenzic.com/IScanService/GetResultsResponse")]
        string GetResults(string clientId, string requestId, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetReport", ReplyAction="http://www.cenzic.com/IScanService/GetReportResponse")]
        byte[] GetReport(string clientId, string requestId, string parameters, string reportName, bool compressReport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetCompressedResults", ReplyAction="http://www.cenzic.com/IScanService/GetCompressedResultsResponse")]
        byte[] GetCompressedResults(string clientId, string requestId, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/TerminateAssessmentRun", ReplyAction="http://www.cenzic.com/IScanService/TerminateAssessmentRunResponse")]
        void TerminateAssessmentRun(string clientId, string requestId, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/DeleteAssessmentRunData", ReplyAction="http://www.cenzic.com/IScanService/DeleteAssessmentRunDataResponse")]
        void DeleteAssessmentRunData(string clientId, string requestId, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/DeleteApplicationData", ReplyAction="http://www.cenzic.com/IScanService/DeleteApplicationDataResponse")]
        void DeleteApplicationData(string clientId, string url, string parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.cenzic.com/IScanService/GetDbTime", ReplyAction="http://www.cenzic.com/IScanService/GetDbTimeResponse")]
        string GetDbTime();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScanServiceChannel : XProviderCenzic.HailstormWebService.IScanService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScanServiceClient : System.ServiceModel.ClientBase<XProviderCenzic.HailstormWebService.IScanService>, XProviderCenzic.HailstormWebService.IScanService {
        
        public ScanServiceClient() {
        }
        
        public ScanServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScanServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScanServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScanServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void QueueAssessmentRun(string clientId, string requestId, string url, string assessmentType, string parameters) {
            base.Channel.QueueAssessmentRun(clientId, requestId, url, assessmentType, parameters);
        }
        
        public string GetStatus(string clientId, string requestId, string parameters) {
            return base.Channel.GetStatus(clientId, requestId, parameters);
        }
        
        public string GetTitanStatus(string clientId, string requestId, string parameters) {
            return base.Channel.GetTitanStatus(clientId, requestId, parameters);
        }
        
        public string GetUpdatedStatuses() {
            return base.Channel.GetUpdatedStatuses();
        }
        
        public void UpdateGetStatusesReferenceTime(string lastStatusTime) {
            base.Channel.UpdateGetStatusesReferenceTime(lastStatusTime);
        }
        
        public string GetResults(string clientId, string requestId, string parameters) {
            return base.Channel.GetResults(clientId, requestId, parameters);
        }
        
        public byte[] GetReport(string clientId, string requestId, string parameters, string reportName, bool compressReport) {
            return base.Channel.GetReport(clientId, requestId, parameters, reportName, compressReport);
        }
        
        public byte[] GetCompressedResults(string clientId, string requestId, string parameters) {
            return base.Channel.GetCompressedResults(clientId, requestId, parameters);
        }
        
        public void TerminateAssessmentRun(string clientId, string requestId, string parameters) {
            base.Channel.TerminateAssessmentRun(clientId, requestId, parameters);
        }
        
        public void DeleteAssessmentRunData(string clientId, string requestId, string parameters) {
            base.Channel.DeleteAssessmentRunData(clientId, requestId, parameters);
        }
        
        public void DeleteApplicationData(string clientId, string url, string parameters) {
            base.Channel.DeleteApplicationData(clientId, url, parameters);
        }
        
        public string GetDbTime() {
            return base.Channel.GetDbTime();
        }
    }
}
