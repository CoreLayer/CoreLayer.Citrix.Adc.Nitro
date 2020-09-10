﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Reporting
{
    public class ReportingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/reporting";
        public override INitroRequestDataRoot DataRoot => new ReportingGetRequestDataRoot(); 
        public override INitroRequestOptions Options { get; set; } = new ReportingGetRequestOptions();
                
        public ReportingGetRequestConfiguration()
        {
            
        }
    }
}