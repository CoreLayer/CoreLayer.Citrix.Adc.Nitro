using System.Net;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Interfaces
{
    public interface INitroResponse
    {
        int ErrorCode { get; set; }
        string Message { get; set; }
        string Severity { get; set; }
        
        string StatusCode { get; set; }
    }
}