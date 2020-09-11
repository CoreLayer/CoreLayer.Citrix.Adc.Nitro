﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ServerBinding
{
    public class ServerBindingGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/server_binding";
        public override INitroRequestOptions Options { get; set; } = new ServerBindingGetRequestOptions();
        public override INitroRequestDataRoot DataRoot => new ServerBindingGetRequestDataRoot();
    }
}