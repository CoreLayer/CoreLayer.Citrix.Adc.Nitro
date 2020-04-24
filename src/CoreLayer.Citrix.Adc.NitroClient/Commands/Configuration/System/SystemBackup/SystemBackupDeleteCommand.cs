using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteCommand : NitroCommand<NitroResponse>
    {
        public SystemBackupDeleteCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) :
            base(serviceClient, requestConfiguration) { }
    }
}