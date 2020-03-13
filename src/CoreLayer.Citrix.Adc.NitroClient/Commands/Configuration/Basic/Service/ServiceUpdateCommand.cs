using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Service
{
    public class ServiceUpdateCommand : NitroCommand<NitroResponse>
    {
        public ServiceUpdateCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}