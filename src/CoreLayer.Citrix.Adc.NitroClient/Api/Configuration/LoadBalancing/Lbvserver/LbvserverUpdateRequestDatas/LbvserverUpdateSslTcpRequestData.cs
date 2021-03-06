namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverUpdateRequestDatas
{
    public class LbvserverUpdateSslTcpRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateSslTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        public string IpV46 { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
    }
}