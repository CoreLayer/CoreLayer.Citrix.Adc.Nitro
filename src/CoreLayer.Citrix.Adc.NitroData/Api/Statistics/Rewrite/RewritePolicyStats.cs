﻿using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Rewrite
{
    public class RewritePolicyStats
    {
        public string Name { get; set; }
        [JsonPropertyName("pipolicyundefhits")]public string PolicyUndefinedHits { get; set; }
        [JsonPropertyName("pipolicyundefhitsrate")]public double? PolicyUndefinedHitsRate { get; set; }
        [JsonPropertyName("pipolicyhits")]public string PolicyHits { get; set; }
        [JsonPropertyName("pipolicyhitsrate")]public double? PolicyHitsRate { get; set; }
    }
}