using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.LbvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.LoadBalancing.LbvserverBinding
{
    public class LbvserverBindingRemoveServiceCommand : NitroCommand<LbvserverBindingRemoveResponse>
    {
        public LbvserverBindingRemoveServiceCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            : base(serviceClient, requestConfiguration) { }
    }
}