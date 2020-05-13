using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.Servicegroup
{
    public class ServicegroupUpdateCommand : NitroCommand<ServicegroupUpdateResponse>
    {
        public ServicegroupUpdateCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration)
        {
            
        }
    }
}