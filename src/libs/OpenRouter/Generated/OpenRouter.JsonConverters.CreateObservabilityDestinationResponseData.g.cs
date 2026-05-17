#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class CreateObservabilityDestinationResponseDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CreateObservabilityDestinationResponseData>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CreateObservabilityDestinationResponseData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? arize = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Arize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1)}");
                arize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? braintrust = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Braintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2)}");
                braintrust = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? clickhouse = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Clickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3)}");
                clickhouse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? datadog = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Datadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4)}");
                datadog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? grafana = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Grafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5)}");
                grafana = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? langfuse = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? langsmith = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Langsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7)}");
                langsmith = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? newrelic = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Newrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8)}");
                newrelic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? opik = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Opik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9)}");
                opik = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? otelCollector = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.OtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10)}");
                otelCollector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? posthog = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Posthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11)}");
                posthog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? ramp = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Ramp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12)}");
                ramp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? s3 = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? sentry = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Sentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14)}");
                sentry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? snowflake = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Snowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15)}");
                snowflake = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? weave = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Weave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16)}");
                weave = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? webhook = default;
            if (discriminator?.Type == global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.CreateObservabilityDestinationResponseData(
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
            global::OpenRouter.CreateObservabilityDestinationResponseData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arize!, typeInfo);
            }
            else if (value.IsBraintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Braintrust!, typeInfo);
            }
            else if (value.IsClickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Clickhouse!, typeInfo);
            }
            else if (value.IsDatadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Datadog!, typeInfo);
            }
            else if (value.IsGrafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Grafana!, typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse!, typeInfo);
            }
            else if (value.IsLangsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langsmith!, typeInfo);
            }
            else if (value.IsNewrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Newrelic!, typeInfo);
            }
            else if (value.IsOpik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Opik!, typeInfo);
            }
            else if (value.IsOtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OtelCollector!, typeInfo);
            }
            else if (value.IsPosthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Posthog!, typeInfo);
            }
            else if (value.IsRamp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ramp!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsSentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentry!, typeInfo);
            }
            else if (value.IsSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Snowflake!, typeInfo);
            }
            else if (value.IsWeave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Weave!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
        }
    }
}