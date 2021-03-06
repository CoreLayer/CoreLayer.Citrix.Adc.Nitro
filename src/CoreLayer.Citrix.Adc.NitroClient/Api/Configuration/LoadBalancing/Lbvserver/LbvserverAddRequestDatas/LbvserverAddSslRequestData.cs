namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverAddRequestDatas
{
    public class LbvserverAddSslRequestData : LbvserverAddRequestData
    {
        public LbvserverAddSslRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "SSL";
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public string RedirUrl { get; set; }
        public string Cacheable { get; set; }
        public string InsertVserverIpPort { get; set; }
        public string VipHeader { get; set; }
        public string AuthenticationHost { get; set; }
        public string Authentication { get; set; } 
        public string Authn401 { get; set; }
        public string AuthnVsName { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string AuthnProfile { get; set; }
        public int? RedirectFromPort { get; set; }
        public string HttpsRedirectUrl { get; set; }
    }
}