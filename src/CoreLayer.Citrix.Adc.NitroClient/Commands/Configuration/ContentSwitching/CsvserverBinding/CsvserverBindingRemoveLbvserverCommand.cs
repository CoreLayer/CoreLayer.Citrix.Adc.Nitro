using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.CsvserverBinding
{
    public class CsvserverBindingRemoveLbvserverCommand : NitroCommand<NitroResponse>
    {
        public CsvserverBindingRemoveLbvserverCommand(INitroHttpClient httpClient,
            INitroRequestConfiguration requestConfiguration) : base(httpClient, requestConfiguration)
        {
            
        }
    }
}