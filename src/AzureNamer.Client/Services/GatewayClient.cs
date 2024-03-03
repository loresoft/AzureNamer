
using FluentRest;

namespace AzureNamer.Client.Services;

public class GatewayClient : FluentClient
{
    public GatewayClient(HttpClient httpClient, IContentSerializer contentSerializer)
        : base(httpClient, contentSerializer)
    {
    }
}
