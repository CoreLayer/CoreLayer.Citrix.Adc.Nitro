using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/service";
        public override INitroRequestDataRoot DataRoot => new ServiceGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new ServiceGetRequestOptions();
    }
}