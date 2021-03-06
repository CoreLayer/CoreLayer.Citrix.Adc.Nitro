﻿namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public interface IServerConfiguration 
    {
        string Name { get; set; }
        string SvcType { get; set; }
        string Dup_SvcType { get; set; }
        int? Port { get; set; }
        int? Dup_Port { get; set; }
        string SvrState { get; set; }
        bool? Internal { get; set; }
        string IpAddress { get; set; }
        string State { get; set; }
        string Domain { get; set; }
        bool? DomainResolveNow { get; set; }
        int? DomainResolveRetry { get; set; }
        string TranslationIp { get; set; }
        string TranslationMask { get; set; }
        string Comment { get; set; }
        double? Delay { get; set; }
        string Graceful { get; set; }
        string StateChangeTimeSec { get; set; }
        string TicksSinceLastStateChange { get; set; }
        string IpV6Address { get; set; }
        string Td { get; set; }
        string AutoScale { get; set; }
        string Usip { get; set; }
        string Cka { get; set; }
        string TcpB { get; set; }
        string Cmp { get; set; }
        string Cacheable { get; set; }
        string Sc { get; set; }
        string Sp { get; set; }
        string SvrCfgFlags { get; set; }
        string MaxReq { get; set; }
        string MaxBandWidth { get; set; }
        string Svcitmactsvcs { get; set; }
        string Svcitmboundsvcs { get; set; }
        string Weight { get; set; }
        double? Count { get; set; }
    }
}