using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddCsPolicyRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_cspolicy_binding";
        public override INitroRequestOptions Options => new CsvserverBindingAddCsPolicyRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverBindingAddCsPolicyRequestConfiguration(CsvserverBindingAddCsPolicyRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}