using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AzureNamer.Shared.Extensions;

public static class ObjectExtensions
{
    public static T? JsonClone<T>(this T instance, JsonTypeInfo<T> jsonTypeInfo)
    {
        if (instance == null)
            return instance;

        if (jsonTypeInfo is null)
            throw new ArgumentNullException(nameof(jsonTypeInfo));

        var buffer = JsonSerializer.SerializeToUtf8Bytes(instance, jsonTypeInfo);
        return JsonSerializer.Deserialize<T>(buffer, jsonTypeInfo);
    }

    public static T? JsonClone<T>(this T instance, JsonSerializerOptions? serializerOptions = null)
    {
        if (instance == null)
            return instance;

        serializerOptions ??= new JsonSerializerOptions(JsonSerializerDefaults.Web);

        var buffer = JsonSerializer.SerializeToUtf8Bytes(instance, serializerOptions);
        return JsonSerializer.Deserialize<T>(buffer, serializerOptions);
    }
}
