using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Service
{
    public class ServiceRemoveCommand : NitroCommand<NitroResponse>
    {
        public ServiceRemoveCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) : base(
            httpClient, requestConfiguration)
        {
            
        }
    }
}