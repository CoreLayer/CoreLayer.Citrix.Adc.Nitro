using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupAddCommand : NitroCommand
    {
        public SystemBackupAddCommand(INitroHttpClient httpClient, INitroRequestConfiguration requestConfiguration) :
            base(httpClient, requestConfiguration)
        {
            
        }
    }
}