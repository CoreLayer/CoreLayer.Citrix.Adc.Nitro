namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server.ServerAddRequestDatas
{
    public class ServerAddByDomainRequestData : IServerAddRequestData
    {
        public string Name { get; }
        public string Domain { get; }
        public string TranslationIp { get; set; }
        public string TranslationMask { get; set; }
        public int DomainResolveRetry { get; }
        public string State { get; set; }
        public string Ipv6Address { get; set; }
        public string Comment { get; set; }
        public double Td { get; set; }
        public string QueryType { get; }

        public ServerAddByDomainRequestData(string serverName, string domainName, int domainResolveRetry = 5,
            string queryType = "A")
        {
            Name = serverName;
            Domain = domainName;
            DomainResolveRetry = domainResolveRetry;
            QueryType = queryType;
        }

        public override string ToString()
        {
            return "Name:" + Name;
        }
    }
}