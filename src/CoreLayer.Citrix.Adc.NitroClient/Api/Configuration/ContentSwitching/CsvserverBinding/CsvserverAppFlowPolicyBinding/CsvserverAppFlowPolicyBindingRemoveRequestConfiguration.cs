﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAppFlowPolicyBinding
{
    public class CsvserverAppFlowPolicyBindingRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/csvserver_appflowpolicy_binding";
        public override INitroRequestDataRoot DataRoot => new CsvserverAppFlowPolicyBindingRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new CsvserverAppFlowPolicyBindingRemoveRequestOptions();
    }
}