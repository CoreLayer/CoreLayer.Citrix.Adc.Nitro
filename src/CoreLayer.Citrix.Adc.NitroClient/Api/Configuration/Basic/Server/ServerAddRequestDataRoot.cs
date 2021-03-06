using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerAddRequestDataRoot : INitroRequestDataRoot
    {
        public ServerAddRequestDataRoot(dynamic data)
        {
            Server = new dynamic[] {data};
        }
        public ServerAddRequestDataRoot(dynamic[] data)
        {
            Server = data;
        }
        public dynamic[] Server { get; set; }
    }
}