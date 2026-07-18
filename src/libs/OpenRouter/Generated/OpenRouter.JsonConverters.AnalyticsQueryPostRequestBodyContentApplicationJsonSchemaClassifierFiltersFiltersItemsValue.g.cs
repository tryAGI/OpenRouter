#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>), options);
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

            string? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = default;
            double? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = default;
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>).Name}");
                        analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 == null && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 == null && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 == null && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 == null && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                    analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 == null && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 == null && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>).Name}");
                    analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1,

                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2,

                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1!, typeInfo);
            }
            else if (value.IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2!.Value, typeInfo);
            }
            else if (value.IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2!, typeInfo);
            }
        }
    }
}