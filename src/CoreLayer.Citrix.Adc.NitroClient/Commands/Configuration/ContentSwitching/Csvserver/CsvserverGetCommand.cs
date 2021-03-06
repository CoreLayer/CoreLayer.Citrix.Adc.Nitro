﻿using CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Commands.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverGetCommand : NitroCommand<CsvserverGetResponse>
    {
        public CsvserverGetCommand(INitroServiceClient serviceClient, INitroRequestConfiguration requestConfiguration)
            :base(serviceClient, requestConfiguration){}
    }
}