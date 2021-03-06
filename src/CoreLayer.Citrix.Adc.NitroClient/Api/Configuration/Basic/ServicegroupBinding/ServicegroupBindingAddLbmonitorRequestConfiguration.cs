using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServicegroupBinding
{
    public class ServicegroupBindingAddLbmonitorRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/servicegroup_lbmonitor_binding";
        public override INitroRequestOptions Options => new ServicegroupBindingAddLbmonitorRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public ServicegroupBindingAddLbmonitorRequestConfiguration(ServicegroupBindingAddLbmonitorRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}