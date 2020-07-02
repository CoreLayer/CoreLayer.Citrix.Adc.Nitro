using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorUpdateHttpRequestData : LbmonitorUpdateRequestData
    {
        public LbmonitorUpdateHttpRequestData(string monitorName) : base(monitorName)
        {
        }

        public string Type => "HTTP";
        [JsonPropertyName("respcode")]public string[] ResponseCodes { get; set; }
        public string HttpRequest { get; set; }
        public string CustomHeaders { get; set; }
        [JsonPropertyName("lrtm")]public string LeqastResponseTime { get; set; }
        public double? Deviation { get; set; }
        [JsonPropertyName("units1")]public string DeviationUnits { get; set; } 
        [JsonPropertyName("destip")]public string DestinationIp { get; set; }
        [JsonPropertyName("destport")]public int? DestinationPort { get; set; }
        public string Transparent { get; set; } 
        public string IpTunnel { get; set; } 
        public string Tos { get; set; } 
        public double? TosId { get; set; } 
        public double? TrofsCode { get; set; }
        public string TrofsString { get; set; }
    }
}