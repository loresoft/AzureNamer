using System.Text.Json;

using AzureNamer.Client.Services;
using AzureNamer.Shared;
using AzureNamer.Shared.Models;

using FluentRest;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class LoggingRepository
{
    protected GatewayClient Gateway { get; }

    public LoggingRepository(GatewayClient gateway)
    {
        Gateway = gateway;
    }

    public async Task<List<string>> List()
    {

        var result = await Gateway.GetAsync<string[]>(b => b
            .AppendPath("/api/administrative/logging")
        );

        return result.ToList();
    }

    public async Task<List<LogEventModel>> Read(string file)
    {

        var result = await Gateway.GetAsync(b => b
            .AppendPath("/api/administrative/logging")
            .AppendPath(file)
        );

        var logs = new List<LogEventModel>();

        await using var stream = await result.Content.ReadAsStreamAsync();
        using var reader = new StreamReader(stream);

        while (!reader.EndOfStream)
        {
            var json = await reader.ReadLineAsync();
            if (string.IsNullOrWhiteSpace(json))
                continue;

            var logEvent = JsonSerializer.Deserialize(json, DomainJsonContext.Default.LogEventModel);
            if (logEvent != null)
                logs.Add(logEvent);
        }

        return logs;
    }
}
