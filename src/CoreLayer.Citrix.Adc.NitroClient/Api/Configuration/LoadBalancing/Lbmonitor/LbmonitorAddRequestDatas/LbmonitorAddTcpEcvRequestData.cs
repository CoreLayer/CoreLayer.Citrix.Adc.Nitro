namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor.LbmonitorAddRequestDatas
{
    public class LbmonitorAddTcpEcvRequestData : LbmonitorAddRequestData
    {
        public string MonitorName { get; }
        public string Type => "TCP-ECV";
        
        public LbmonitorAddTcpEcvRequestData(string monitorName)
        {
            MonitorName = monitorName;
        }     
        
        public string Send { get; set; }
        public string Recv { get; set; }
        public string Lrtm { get; set; }
        public double? Deviation { get; set; }
        public string Units1 { get; set; } 
        public string DestIp { get; set; }
        public int? DestPort { get; set; }
        public string Transparent { get; set; } 
        public string IpTunnel { get; set; } 
        public string Tos { get; set; } 
        public double? TosId { get; set; }
    }
}