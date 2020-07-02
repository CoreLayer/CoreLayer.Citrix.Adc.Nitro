using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddSslTcpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddSslTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "SSL_TCP";
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
    }
}