using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.CsvserverBinding;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingAddLbvserverCommand : NitroCommand<CsvserverBindingAddResponse>
    {
        public CsvserverBindingAddLbvserverCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration) { }
    }
}