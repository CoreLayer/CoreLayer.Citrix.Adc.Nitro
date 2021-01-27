using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertKey
{
    public class SslCertKeyAddRequestData : INitroRequestData
    {
        [JsonPropertyName("certkey")]
        public string CertKey { get; set; }
        
        [JsonPropertyName("cert")]
        public string PublicKey { get; set; }
        
        [JsonPropertyName("key")]
        public string PrivateKey { get; set; }
        
        [JsonPropertyName("password")]
        public bool Password { get; set; }
        
        [JsonPropertyName("fipskey")]
        public string FipsKey { get; set; }
        
        [JsonPropertyName("hsmkey")]
        public string HsmKey { get; set; }
        
        [JsonPropertyName("inform")]
        public string Inform { get; set; }
        
        [JsonPropertyName("passplain")]
        public string PassPlain { get; set; }
        
        [JsonPropertyName("expirymonitor")]
        public string ExpiryMonitor { get; set; }
        
        [JsonPropertyName("notificationperiod")]
        public double NotificationPeriod { get; set; }
        
        [JsonPropertyName("bundle")]
        public string Bundle { get; set; }
    }
}