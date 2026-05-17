#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class UpdateObservabilityDestinationResponseDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UpdateObservabilityDestinationResponseData>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UpdateObservabilityDestinationResponseData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1? arize = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Arize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1)}");
                arize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2? braintrust = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Braintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2)}");
                braintrust = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3? clickhouse = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Clickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3)}");
                clickhouse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4? datadog = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Datadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4)}");
                datadog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5? grafana = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Grafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5)}");
                grafana = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6? langfuse = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7? langsmith = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Langsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7)}");
                langsmith = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8? newrelic = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Newrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8)}");
                newrelic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9? opik = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Opik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9)}");
                opik = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10? otelCollector = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.OtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10)}");
                otelCollector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11? posthog = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Posthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11)}");
                posthog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12? ramp = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Ramp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12)}");
                ramp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13? s3 = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14? sentry = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Sentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14)}");
                sentry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15? snowflake = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Snowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15)}");
                snowflake = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16? weave = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Weave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16)}");
                weave = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17? webhook = default;
            if (discriminator?.Type == global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.UpdateObservabilityDestinationResponseData(
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
            global::OpenRouter.UpdateObservabilityDestinationResponseData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arize!, typeInfo);
            }
            else if (value.IsBraintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Braintrust!, typeInfo);
            }
            else if (value.IsClickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Clickhouse!, typeInfo);
            }
            else if (value.IsDatadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Datadog!, typeInfo);
            }
            else if (value.IsGrafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Grafana!, typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse!, typeInfo);
            }
            else if (value.IsLangsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langsmith!, typeInfo);
            }
            else if (value.IsNewrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Newrelic!, typeInfo);
            }
            else if (value.IsOpik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Opik!, typeInfo);
            }
            else if (value.IsOtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OtelCollector!, typeInfo);
            }
            else if (value.IsPosthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Posthog!, typeInfo);
            }
            else if (value.IsRamp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ramp!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsSentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentry!, typeInfo);
            }
            else if (value.IsSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Snowflake!, typeInfo);
            }
            else if (value.IsWeave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Weave!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
        }
    }
}