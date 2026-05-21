#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ReasoningItemStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ReasoningItemStatus>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ReasoningItemStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus0), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.ReasoningItemStatus0? reasoningItemStatus0 = default;
            global::OpenRouter.ReasoningItemStatus1? reasoningItemStatus1 = default;
            global::OpenRouter.ReasoningItemStatus2? reasoningItemStatus2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus0).Name}");
                        reasoningItemStatus0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus1).Name}");
                        reasoningItemStatus1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus2).Name}");
                        reasoningItemStatus2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reasoningItemStatus0 == null && reasoningItemStatus1 == null && reasoningItemStatus2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus0).Name}");
                    reasoningItemStatus0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItemStatus0 == null && reasoningItemStatus1 == null && reasoningItemStatus2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus1).Name}");
                    reasoningItemStatus1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItemStatus0 == null && reasoningItemStatus1 == null && reasoningItemStatus2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus2).Name}");
                    reasoningItemStatus2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ReasoningItemStatus(
                reasoningItemStatus0,

                reasoningItemStatus1,

                reasoningItemStatus2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ReasoningItemStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoningItemStatus0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningItemStatus0!.Value, typeInfo);
            }
            else if (value.IsReasoningItemStatus1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningItemStatus1!.Value, typeInfo);
            }
            else if (value.IsReasoningItemStatus2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItemStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItemStatus2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItemStatus2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningItemStatus2!.Value, typeInfo);
            }
        }
    }
}