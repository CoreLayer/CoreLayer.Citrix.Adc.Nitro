﻿using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Network.MapBmr
{
    public class MapBmrStatRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/stat/mapbmr";
        public override INitroRequestOptions Options { get; set; } = new MapBmrStatRequestOptions();
        public override INitroRequestDataRoot DataRoot => new MapBmrStatRequestDataRoot();
        
        public MapBmrStatRequestConfiguration() {}
    }
}