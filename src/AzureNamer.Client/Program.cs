using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

using AzureNamer.Client.Services;
using AzureNamer.Shared;

using Blazone.Authentication;
using Blazone.Authentication.Http;

using Blazored.LocalStorage;
using Blazored.Modal;

using FluentRest;

using LoreSoft.Blazor.Controls;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Net.Http.Headers;

using Sotsera.Blazor.Toaster.Core.Models;

namespace AzureNamer.Client;

internal static class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        var services = builder.Services;

        services.AddBlazoneClient();
        services.AddCascadingAuthenticationState();

        services.TryAddSingleton(sp =>
        {
            var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            options.TypeInfoResolverChain.Add(DomainJsonContext.Default);
            options.TypeInfoResolverChain.Add(AuthenticationJsonContext.Default);
            options.TypeInfoResolverChain.Add(ProblemDetailsJsonContext.Default);
            return options;
        });

        services.TryAddSingleton<IContentSerializer, JsonContentSerializer>();

        services
            .AddHttpClient<GatewayClient>(client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add(HeaderNames.XRequestedWith, "XMLHttpRequest");
            })
            .AddHttpMessageHandler<AuthenticationRequiredHandler>()
            .AddHttpMessageHandler<ProgressBarHandler>();

        services
            .AddHttpClient("default", client =>
            {
                client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add(HeaderNames.XRequestedWith, "XMLHttpRequest");
            })
            .AddHttpMessageHandler<ProgressBarHandler>();

        services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("default"));

        services.AddAutoMapper(typeof(Program).Assembly, typeof(DomainJsonContext).Assembly);

        services.AddProgressBar();
        services.AddBlazoredLocalStorage();
        services.AddBlazoredModal();

        services
            .AddToaster(config =>
            {
                config.PositionClass = Defaults.Classes.Position.TopCenter;
                config.PreventDuplicates = true;
                config.NewestOnTop = false;
                config.MaxDisplayedToasts = 2;
            });

        services.AddAzureNamerShared();
        services.AddAzureNamerClient();

        await builder.Build().RunAsync();
    }
}
