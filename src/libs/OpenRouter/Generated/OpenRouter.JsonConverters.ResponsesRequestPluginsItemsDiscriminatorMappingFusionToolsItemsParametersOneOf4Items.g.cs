#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(double), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(bool), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(object), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(object), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 = default;
            double? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 = default;
            bool? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 = default;
            object? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 = default;
            object? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                        responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                        responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                    responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                    responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4 == null && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items(
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1,

                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2,

                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3,

                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4,

                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant1!, typeInfo);
            }
            else if (value.IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant2!.Value, typeInfo);
            }
            else if (value.IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant3!.Value, typeInfo);
            }
            else if (value.IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant4!, typeInfo);
            }
            else if (value.IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4ItemsVariant5!, typeInfo);
            }
        }
    }
}