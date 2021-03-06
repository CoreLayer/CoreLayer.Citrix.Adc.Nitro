using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient
{
    public static class NitroRequestConfigurationSerializer
    {
        private static async Task SerializeRequestData(Stream dataStream, INitroRequestDataRoot requestDataRoot)
        {
            await JsonSerializer.SerializeAsync(
                dataStream, 
                requestDataRoot, 
                requestDataRoot.GetType(), 
                NitroServiceSerializerOptions.JsonSerializerOptions, 
                CancellationToken.None).ConfigureAwait(false);
            
            dataStream.Seek(0, SeekOrigin.Begin);
        }

        private static StreamContent StreamContent(Stream dataStream) => 
            new StreamContent(new StreamReader(dataStream).BaseStream);

        public static async Task<HttpRequestMessage> GenerateHttpRequestMessageAsync(INitroRequestConfiguration requestConfiguration)
        {
            var dataStream = new MemoryStream();
            await SerializeRequestData(dataStream, requestConfiguration.DataRoot).ConfigureAwait(false);
            
            var request = new HttpRequestMessage(
                requestConfiguration.Method, 
                requestConfiguration.ResourcePath + requestConfiguration.Options.ToString())
            {
                Content = StreamContent(dataStream)
            };
            request.Content.Headers.ContentType = requestConfiguration.ContentType;

            return request;
        }
    }
}