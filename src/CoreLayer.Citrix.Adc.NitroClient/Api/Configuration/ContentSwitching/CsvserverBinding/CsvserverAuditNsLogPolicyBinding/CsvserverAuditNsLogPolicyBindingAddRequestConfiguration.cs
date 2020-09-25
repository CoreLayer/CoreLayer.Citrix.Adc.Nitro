﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding.CsvserverAuditNsLogPolicyBinding
{
    public class CsvserverAuditNsLogPolicyBindingAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/csvserver_auditnslogpolicy_binding";
        public override INitroRequestOptions Options => new CsvserverAuditNsLogPolicyBindingAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public CsvserverAuditNsLogPolicyBindingAddRequestConfiguration(CsvserverAuditNsLogPolicyBindingAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }

    }
}