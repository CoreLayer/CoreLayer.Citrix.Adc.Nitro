﻿using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.VServer
{
    public class VServerDisableCommand : NitroCommand<VServerDisableResponse>
    {
        public VServerDisableCommand(INitroServiceClient serviceClient,
            INitroRequestConfiguration requestConfiguration) : base(serviceClient, requestConfiguration)
        {
            
        }
    }
}