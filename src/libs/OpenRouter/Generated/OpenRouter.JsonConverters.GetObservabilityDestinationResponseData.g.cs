#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class GetObservabilityDestinationResponseDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.GetObservabilityDestinationResponseData>
    {
        /// <inheritdoc />
        public override global::OpenRouter.GetObservabilityDestinationResponseData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? arize = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Arize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1)}");
                arize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? braintrust = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Braintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2)}");
                braintrust = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? clickhouse = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Clickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3)}");
                clickhouse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? datadog = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Datadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4)}");
                datadog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? grafana = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Grafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5)}");
                grafana = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? langfuse = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? langsmith = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Langsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7)}");
                langsmith = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? newrelic = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Newrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8)}");
                newrelic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? opik = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Opik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9)}");
                opik = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? otelCollector = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.OtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10)}");
                otelCollector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? posthog = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Posthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11)}");
                posthog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? ramp = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Ramp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12)}");
                ramp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? s3 = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? sentry = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Sentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14)}");
                sentry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? snowflake = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Snowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15)}");
                snowflake = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? weave = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Weave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16)}");
                weave = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? webhook = default;
            if (discriminator?.Type == global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.GetObservabilityDestinationResponseData(
                discriminator?.Type,
                arize,

                braintrust,

                clickhouse,

                datadog,

                grafana,

                langfuse,

                langsmith,

                newrelic,

                opik,

                otelCollector,

                posthog,

                ramp,

                s3,

                sentry,

                snowflake,

                weave,

                webhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.GetObservabilityDestinationResponseData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arize!, typeInfo);
            }
            else if (value.IsBraintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Braintrust!, typeInfo);
            }
            else if (value.IsClickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Clickhouse!, typeInfo);
            }
            else if (value.IsDatadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Datadog!, typeInfo);
            }
            else if (value.IsGrafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Grafana!, typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse!, typeInfo);
            }
            else if (value.IsLangsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langsmith!, typeInfo);
            }
            else if (value.IsNewrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Newrelic!, typeInfo);
            }
            else if (value.IsOpik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Opik!, typeInfo);
            }
            else if (value.IsOtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OtelCollector!, typeInfo);
            }
            else if (value.IsPosthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Posthog!, typeInfo);
            }
            else if (value.IsRamp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ramp!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsSentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentry!, typeInfo);
            }
            else if (value.IsSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Snowflake!, typeInfo);
            }
            else if (value.IsWeave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Weave!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.GetObservabilityDestinationResponseDataVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
        }
    }
}