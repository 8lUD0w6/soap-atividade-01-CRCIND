﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPDemo
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="SOAPDemo.SOAPDemoSoap")]
    public interface SOAPDemoSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.AddInteger", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<long> AddIntegerAsync(long Arg1, long Arg2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.DivideInteger", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<long> DivideIntegerAsync(long Arg1, long Arg2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.FindPerson", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SOAPDemo.Person> FindPersonAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.GetByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SOAPDemo.ArrayOfXElement> GetByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.GetDataSetByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Xml.XmlElement> GetDataSetByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.GetListByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SOAPDemo.PersonIdentification[]> GetListByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.LookupCity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SOAPDemo.Address> LookupCityAsync(string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.Mission", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> MissionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SOAP.Demo.QueryByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<System.Xml.XmlElement> QueryByNameAsync(string name);
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Employee))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class Person
    {
        
        private string nameField;
        
        private string sSNField;
        
        private System.DateTime dOBField;
        
        private bool dOBFieldSpecified;
        
        private Address homeField;
        
        private Address officeField;
        
        private Person spouseField;
        
        private string[] favoriteColorsField;
        
        private long ageField;
        
        private bool ageFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SSN
        {
            get
            {
                return this.sSNField;
            }
            set
            {
                this.sSNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime DOB
        {
            get
            {
                return this.dOBField;
            }
            set
            {
                this.dOBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DOBSpecified
        {
            get
            {
                return this.dOBFieldSpecified;
            }
            set
            {
                this.dOBFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Address Home
        {
            get
            {
                return this.homeField;
            }
            set
            {
                this.homeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Address Office
        {
            get
            {
                return this.officeField;
            }
            set
            {
                this.officeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public Person Spouse
        {
            get
            {
                return this.spouseField;
            }
            set
            {
                this.spouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FavoriteColorsItem")]
        public string[] FavoriteColors
        {
            get
            {
                return this.favoriteColorsField;
            }
            set
            {
                this.favoriteColorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public long Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified
        {
            get
            {
                return this.ageFieldSpecified;
            }
            set
            {
                this.ageFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class Address
    {
        
        private string streetField;
        
        private string cityField;
        
        private string stateField;
        
        private string zipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class PersonIdentification
    {
        
        private string idField;
        
        private string nameField;
        
        private string sSNField;
        
        private System.DateTime dOBField;
        
        private bool dOBFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SSN
        {
            get
            {
                return this.sSNField;
            }
            set
            {
                this.sSNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime DOB
        {
            get
            {
                return this.dOBField;
            }
            set
            {
                this.dOBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DOBSpecified
        {
            get
            {
                return this.dOBFieldSpecified;
            }
            set
            {
                this.dOBFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class Employee : Person
    {
        
        private string titleField;
        
        private long salaryField;
        
        private bool salaryFieldSpecified;
        
        private string notesField;
        
        private byte[] pictureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long Salary
        {
            get
            {
                return this.salaryField;
            }
            set
            {
                this.salaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalarySpecified
        {
            get
            {
                return this.salaryFieldSpecified;
            }
            set
            {
                this.salaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=3)]
        public byte[] Picture
        {
            get
            {
                return this.pictureField;
            }
            set
            {
                this.pictureField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface SOAPDemoSoapChannel : SOAPDemo.SOAPDemoSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class SOAPDemoSoapClient : System.ServiceModel.ClientBase<SOAPDemo.SOAPDemoSoap>, SOAPDemo.SOAPDemoSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SOAPDemoSoapClient() : 
                base(SOAPDemoSoapClient.GetDefaultBinding(), SOAPDemoSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SOAPDemoSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SOAPDemoSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SOAPDemoSoapClient.GetBindingForEndpoint(endpointConfiguration), SOAPDemoSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SOAPDemoSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SOAPDemoSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SOAPDemoSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SOAPDemoSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SOAPDemoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<long> AddIntegerAsync(long Arg1, long Arg2)
        {
            return base.Channel.AddIntegerAsync(Arg1, Arg2);
        }
        
        public System.Threading.Tasks.Task<long> DivideIntegerAsync(long Arg1, long Arg2)
        {
            return base.Channel.DivideIntegerAsync(Arg1, Arg2);
        }
        
        public System.Threading.Tasks.Task<SOAPDemo.Person> FindPersonAsync(string id)
        {
            return base.Channel.FindPersonAsync(id);
        }
        
        public System.Threading.Tasks.Task<SOAPDemo.ArrayOfXElement> GetByNameAsync(string name)
        {
            return base.Channel.GetByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlElement> GetDataSetByNameAsync(string name)
        {
            return base.Channel.GetDataSetByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<SOAPDemo.PersonIdentification[]> GetListByNameAsync(string name)
        {
            return base.Channel.GetListByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<SOAPDemo.Address> LookupCityAsync(string zip)
        {
            return base.Channel.LookupCityAsync(zip);
        }
        
        public System.Threading.Tasks.Task<string> MissionAsync()
        {
            return base.Channel.MissionAsync();
        }
        
        public System.Threading.Tasks.Task<System.Xml.XmlElement> QueryByNameAsync(string name)
        {
            return base.Channel.QueryByNameAsync(name);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SOAPDemoSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SOAPDemoSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://www.crcind.com/csp/samples/SOAP.Demo.cls");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SOAPDemoSoapClient.GetBindingForEndpoint(EndpointConfiguration.SOAPDemoSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SOAPDemoSoapClient.GetEndpointAddress(EndpointConfiguration.SOAPDemoSoap);
        }
        
        public enum EndpointConfiguration
        {
            
            SOAPDemoSoap,
        }
    }
    
    [System.Xml.Serialization.XmlSchemaProviderAttribute(null, IsAny=true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil-lib", "2.0.3.0")]
    public partial class ArrayOfXElement : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Collections.Generic.List<System.Xml.Linq.XElement> nodesList = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
        
        public ArrayOfXElement()
        {
        }
        
        public virtual System.Collections.Generic.List<System.Xml.Linq.XElement> Nodes
        {
            get
            {
                return this.nodesList;
            }
        }
        
        public virtual System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }
        
        public virtual void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> e = nodesList.GetEnumerator();
            for (
            ; e.MoveNext(); 
            )
            {
                ((System.Xml.Serialization.IXmlSerializable)(e.Current)).WriteXml(writer);
            }
        }
        
        public virtual void ReadXml(System.Xml.XmlReader reader)
        {
            for (
            ; (reader.NodeType != System.Xml.XmlNodeType.EndElement); 
            )
            {
                if ((reader.NodeType == System.Xml.XmlNodeType.Element))
                {
                    System.Xml.Linq.XElement elem = new System.Xml.Linq.XElement("default");
                    ((System.Xml.Serialization.IXmlSerializable)(elem)).ReadXml(reader);
                    Nodes.Add(elem);
                }
                else
                {
                    reader.Skip();
                }
            }
        }
    }
}