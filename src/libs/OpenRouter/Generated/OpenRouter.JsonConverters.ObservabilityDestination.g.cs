#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ObservabilityDestinationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ObservabilityDestination>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ObservabilityDestination Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ObservabilityDestinationVariant1? arize = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Arize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant1)}");
                arize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant2? braintrust = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Braintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant2)}");
                braintrust = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant3? clickhouse = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Clickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant3)}");
                clickhouse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant4? datadog = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Datadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant4)}");
                datadog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant5? grafana = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Grafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant5)}");
                grafana = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant6? langfuse = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant6)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant7? langsmith = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Langsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant7)}");
                langsmith = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant8? newrelic = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Newrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant8)}");
                newrelic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant9? opik = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Opik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant9)}");
                opik = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant10? otelCollector = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.OtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant10)}");
                otelCollector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant11? posthog = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Posthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant11)}");
                posthog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant12? ramp = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Ramp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant12)}");
                ramp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant13? s3 = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant13)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant14? sentry = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Sentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant14)}");
                sentry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant15? snowflake = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Snowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant15)}");
                snowflake = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant16? weave = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Weave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant16)}");
                weave = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDestinationVariant17? webhook = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDestinationVariant17)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ObservabilityDestination(
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
            global::OpenRouter.ObservabilityDestination value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arize!, typeInfo);
            }
            else if (value.IsBraintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Braintrust!, typeInfo);
            }
            else if (value.IsClickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Clickhouse!, typeInfo);
            }
            else if (value.IsDatadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Datadog!, typeInfo);
            }
            else if (value.IsGrafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Grafana!, typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse!, typeInfo);
            }
            else if (value.IsLangsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langsmith!, typeInfo);
            }
            else if (value.IsNewrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Newrelic!, typeInfo);
            }
            else if (value.IsOpik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Opik!, typeInfo);
            }
            else if (value.IsOtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OtelCollector!, typeInfo);
            }
            else if (value.IsPosthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Posthog!, typeInfo);
            }
            else if (value.IsRamp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ramp!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsSentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentry!, typeInfo);
            }
            else if (value.IsSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Snowflake!, typeInfo);
            }
            else if (value.IsWeave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Weave!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDestinationVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDestinationVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDestinationVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
        }
    }
}