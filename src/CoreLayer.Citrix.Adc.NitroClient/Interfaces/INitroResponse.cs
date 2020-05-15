using System.Net;

namespace CoreLayer.Citrix.Adc.NitroClient.Interfaces
{
    public interface INitroResponse
    {
        int ErrorCode { get; set; }
        string Message { get; set; }
        string Severity { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}