﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TChannel", Namespace="http://schemas.datacontract.org/2004/07/NewService")]
    public partial class TChannel : object
    {
        
        private int ChannelIDField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChannelID
        {
            get
            {
                return this.ChannelIDField;
            }
            set
            {
                this.ChannelIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TMessage", Namespace="http://schemas.datacontract.org/2004/07/NewService")]
    public partial class TMessage : object
    {
        
        private int ChannelIDField;
        
        private NewsService.TMessageData[] MessageDataField;
        
        private int MessageIDField;
        
        private int MessageTypeIDField;
        
        private System.DateTime ValidFromField;
        
        private System.DateTime ValidTillField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ChannelID
        {
            get
            {
                return this.ChannelIDField;
            }
            set
            {
                this.ChannelIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NewsService.TMessageData[] MessageData
        {
            get
            {
                return this.MessageDataField;
            }
            set
            {
                this.MessageDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MessageID
        {
            get
            {
                return this.MessageIDField;
            }
            set
            {
                this.MessageIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MessageTypeID
        {
            get
            {
                return this.MessageTypeIDField;
            }
            set
            {
                this.MessageTypeIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ValidFrom
        {
            get
            {
                return this.ValidFromField;
            }
            set
            {
                this.ValidFromField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ValidTill
        {
            get
            {
                return this.ValidTillField;
            }
            set
            {
                this.ValidTillField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TMessageData", Namespace="http://schemas.datacontract.org/2004/07/NewService")]
    public partial class TMessageData : object
    {
        
        private int LanguageField;
        
        private string NameField;
        
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Language
        {
            get
            {
                return this.LanguageField;
            }
            set
            {
                this.LanguageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TMessageType", Namespace="http://schemas.datacontract.org/2004/07/NewsService")]
    public partial class TMessageType : object
    {
        
        private string DescriptionField;
        
        private int MessageTypeIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MessageTypeID
        {
            get
            {
                return this.MessageTypeIDField;
            }
            set
            {
                this.MessageTypeIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TTemplate", Namespace="http://schemas.datacontract.org/2004/07/NewService")]
    public partial class TTemplate : object
    {
        
        private string DescriptionField;
        
        private int MessageTypeIDField;
        
        private string TemplateContentField;
        
        private string TemplateFileNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MessageTypeID
        {
            get
            {
                return this.MessageTypeIDField;
            }
            set
            {
                this.MessageTypeIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TemplateContent
        {
            get
            {
                return this.TemplateContentField;
            }
            set
            {
                this.TemplateContentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TemplateFileName
        {
            get
            {
                return this.TemplateFileNameField;
            }
            set
            {
                this.TemplateFileNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TLanguage", Namespace="http://schemas.datacontract.org/2004/07/NewService")]
    public partial class TLanguage : object
    {
        
        private string AbbrevField;
        
        private int LanguageIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Abbrev
        {
            get
            {
                return this.AbbrevField;
            }
            set
            {
                this.AbbrevField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LanguageID
        {
            get
            {
                return this.LanguageIDField;
            }
            set
            {
                this.LanguageIDField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewsService.INewsService")]
    public interface INewsService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetACMessages", ReplyAction="http://tempuri.org/INewsService/GetACMessagesResponse")]
        System.Threading.Tasks.Task<string> GetACMessagesAsync(int ChannelID, bool NewestFirst, string Language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsService/GetACMessagesByType", ReplyAction="http://tempuri.org/INewsService/GetACMessagesByTypeResponse")]
        System.Threading.Tasks.Task<string> GetACMessagesByTypeAsync(int ChannelID, bool NewestFirst, string Language, int MessageTypeID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public interface INewsServiceChannel : NewsService.INewsService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public partial class NewsServiceClient : System.ServiceModel.ClientBase<NewsService.INewsService>, NewsService.INewsService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NewsServiceClient() : 
                base(NewsServiceClient.GetDefaultBinding(), NewsServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INewsService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(NewsServiceClient.GetBindingForEndpoint(endpointConfiguration), NewsServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NewsServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NewsServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> GetACMessagesAsync(int ChannelID, bool NewestFirst, string Language)
        {
            return base.Channel.GetACMessagesAsync(ChannelID, NewestFirst, Language);
        }
        
        public System.Threading.Tasks.Task<string> GetACMessagesByTypeAsync(int ChannelID, bool NewestFirst, string Language, int MessageTypeID)
        {
            return base.Channel.GetACMessagesByTypeAsync(ChannelID, NewestFirst, Language, MessageTypeID);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        #if !NET6_0_OR_GREATER
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        #endif
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INewsService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INewsService))
            {
                return new System.ServiceModel.EndpointAddress("http://mczmsint05/NewsService/NewsService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return NewsServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INewsService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return NewsServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INewsService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INewsService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewsService.INewsRoomService")]
    public interface INewsRoomService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/AddChannel", ReplyAction="http://tempuri.org/INewsRoomService/AddChannelResponse")]
        System.Threading.Tasks.Task<bool> AddChannelAsync(NewsService.TChannel Channel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/AddMessage", ReplyAction="http://tempuri.org/INewsRoomService/AddMessageResponse")]
        System.Threading.Tasks.Task<bool> AddMessageAsync(NewsService.TMessage Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/DeleteChannel", ReplyAction="http://tempuri.org/INewsRoomService/DeleteChannelResponse")]
        System.Threading.Tasks.Task<bool> DeleteChannelAsync(int ChannelID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/DeleteMessage", ReplyAction="http://tempuri.org/INewsRoomService/DeleteMessageResponse")]
        System.Threading.Tasks.Task<bool> DeleteMessageAsync(int MessageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/EditChannel", ReplyAction="http://tempuri.org/INewsRoomService/EditChannelResponse")]
        System.Threading.Tasks.Task<bool> EditChannelAsync(NewsService.TChannel Channel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/EditMessage", ReplyAction="http://tempuri.org/INewsRoomService/EditMessageResponse")]
        System.Threading.Tasks.Task<bool> EditMessageAsync(NewsService.TMessage Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/GetMessagesList", ReplyAction="http://tempuri.org/INewsRoomService/GetMessagesListResponse")]
        System.Threading.Tasks.Task<NewsService.TMessage[]> GetMessagesListAsync(int ChannelID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/GetChannelsList", ReplyAction="http://tempuri.org/INewsRoomService/GetChannelsListResponse")]
        System.Threading.Tasks.Task<NewsService.TChannel[]> GetChannelsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/GetMessageTypes", ReplyAction="http://tempuri.org/INewsRoomService/GetMessageTypesResponse")]
        System.Threading.Tasks.Task<NewsService.TMessageType[]> GetMessageTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/GetTemplatesList", ReplyAction="http://tempuri.org/INewsRoomService/GetTemplatesListResponse")]
        System.Threading.Tasks.Task<NewsService.TTemplate[]> GetTemplatesListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/GetLanguageList", ReplyAction="http://tempuri.org/INewsRoomService/GetLanguageListResponse")]
        System.Threading.Tasks.Task<NewsService.TLanguage[]> GetLanguageListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsRoomService/UploadTemplate", ReplyAction="http://tempuri.org/INewsRoomService/UploadTemplateResponse")]
        System.Threading.Tasks.Task<bool> UploadTemplateAsync(NewsService.TTemplate Template);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public interface INewsRoomServiceChannel : NewsService.INewsRoomService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "8.0.0")]
    public partial class NewsRoomServiceClient : System.ServiceModel.ClientBase<NewsService.INewsRoomService>, NewsService.INewsRoomService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NewsRoomServiceClient() : 
                base(NewsRoomServiceClient.GetDefaultBinding(), NewsRoomServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_INewsRoomService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsRoomServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(NewsRoomServiceClient.GetBindingForEndpoint(endpointConfiguration), NewsRoomServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsRoomServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NewsRoomServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsRoomServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NewsRoomServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NewsRoomServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> AddChannelAsync(NewsService.TChannel Channel)
        {
            return base.Channel.AddChannelAsync(Channel);
        }
        
        public System.Threading.Tasks.Task<bool> AddMessageAsync(NewsService.TMessage Message)
        {
            return base.Channel.AddMessageAsync(Message);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteChannelAsync(int ChannelID)
        {
            return base.Channel.DeleteChannelAsync(ChannelID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMessageAsync(int MessageID)
        {
            return base.Channel.DeleteMessageAsync(MessageID);
        }
        
        public System.Threading.Tasks.Task<bool> EditChannelAsync(NewsService.TChannel Channel)
        {
            return base.Channel.EditChannelAsync(Channel);
        }
        
        public System.Threading.Tasks.Task<bool> EditMessageAsync(NewsService.TMessage Message)
        {
            return base.Channel.EditMessageAsync(Message);
        }
        
        public System.Threading.Tasks.Task<NewsService.TMessage[]> GetMessagesListAsync(int ChannelID)
        {
            return base.Channel.GetMessagesListAsync(ChannelID);
        }
        
        public System.Threading.Tasks.Task<NewsService.TChannel[]> GetChannelsListAsync()
        {
            return base.Channel.GetChannelsListAsync();
        }
        
        public System.Threading.Tasks.Task<NewsService.TMessageType[]> GetMessageTypesAsync()
        {
            return base.Channel.GetMessageTypesAsync();
        }
        
        public System.Threading.Tasks.Task<NewsService.TTemplate[]> GetTemplatesListAsync()
        {
            return base.Channel.GetTemplatesListAsync();
        }
        
        public System.Threading.Tasks.Task<NewsService.TLanguage[]> GetLanguageListAsync()
        {
            return base.Channel.GetLanguageListAsync();
        }
        
        public System.Threading.Tasks.Task<bool> UploadTemplateAsync(NewsService.TTemplate Template)
        {
            return base.Channel.UploadTemplateAsync(Template);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        #if !NET6_0_OR_GREATER
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        #endif
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INewsRoomService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_INewsRoomService))
            {
                return new System.ServiceModel.EndpointAddress("http://mczmsint05/NewsService/NewsService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return NewsRoomServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_INewsRoomService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return NewsRoomServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_INewsRoomService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_INewsRoomService,
        }
    }
}
