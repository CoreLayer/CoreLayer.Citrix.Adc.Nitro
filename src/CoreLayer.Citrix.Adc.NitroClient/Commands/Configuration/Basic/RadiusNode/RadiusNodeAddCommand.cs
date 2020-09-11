﻿using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.RadiusNode;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.Basic.RadiusNode
{
    public class RadiusNodeAddCommand : NitroCommand<RadiusNodeAddResponse>
    {
        public RadiusNodeAddCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration) 
            :base(serviceClient, requestConfiguration){}
    }
}