using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Cspolicy
{
    public class CspolicyRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/cspolicy";
        public override INitroRequestDataRoot DataRoot => new CspolicyRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CspolicyRemoveRequestOptions();
    }
}