using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceUpdateUdpRequestData : ServiceUpdateRequestData
    {
        public ServiceUpdateUdpRequestData(string serviceName) : base(serviceName)
        {
        }
        
        public string Cacheable { get; set; }
        public string Sc { get; set; }//SureConnect { get; set; } 
        public string Sp { get; set; }//SurgeProtection { get; set; }
    }
}