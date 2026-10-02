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

            global::OpenRouter.ObservabilityArizeDestination? arize = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Arize)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityArizeDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityArizeDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityArizeDestination)}");
                arize = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityBraintrustDestination? braintrust = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Braintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityBraintrustDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityBraintrustDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityBraintrustDestination)}");
                braintrust = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityClickhouseDestination? clickhouse = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Clickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityClickhouseDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityClickhouseDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityClickhouseDestination)}");
                clickhouse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityDatadogDestination? datadog = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Datadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDatadogDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDatadogDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityDatadogDestination)}");
                datadog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityGrafanaDestination? grafana = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Grafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityGrafanaDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityGrafanaDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityGrafanaDestination)}");
                grafana = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityLangfuseDestination? langfuse = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityLangfuseDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityLangfuseDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityLangfuseDestination)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityLangsmithDestination? langsmith = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Langsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityLangsmithDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityLangsmithDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityLangsmithDestination)}");
                langsmith = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityNewrelicDestination? newrelic = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Newrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityNewrelicDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityNewrelicDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityNewrelicDestination)}");
                newrelic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityOpikDestination? opik = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Opik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityOpikDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityOpikDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityOpikDestination)}");
                opik = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityOtelCollectorDestination? otelCollector = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.OtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityOtelCollectorDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityOtelCollectorDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityOtelCollectorDestination)}");
                otelCollector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityPosthogDestination? posthog = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Posthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityPosthogDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityPosthogDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityPosthogDestination)}");
                posthog = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityRampDestination? ramp = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Ramp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityRampDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityRampDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityRampDestination)}");
                ramp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityS3Destination? s3 = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityS3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityS3Destination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityS3Destination)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilitySentryDestination? sentry = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Sentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilitySentryDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilitySentryDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilitySentryDestination)}");
                sentry = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilitySnowflakeDestination? snowflake = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Snowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilitySnowflakeDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilitySnowflakeDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilitySnowflakeDestination)}");
                snowflake = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityWeaveDestination? weave = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Weave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityWeaveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityWeaveDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityWeaveDestination)}");
                weave = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ObservabilityWebhookDestination? webhook = default;
            if (discriminator?.Type == global::OpenRouter.ObservabilityDestinationDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityWebhookDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityWebhookDestination> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ObservabilityWebhookDestination)}");
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityArizeDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityArizeDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityArizeDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArize(), typeInfo);
            }
            else if (value.IsBraintrust)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityBraintrustDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityBraintrustDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityBraintrustDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBraintrust(), typeInfo);
            }
            else if (value.IsClickhouse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityClickhouseDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityClickhouseDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityClickhouseDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClickhouse(), typeInfo);
            }
            else if (value.IsDatadog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityDatadogDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityDatadogDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityDatadogDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDatadog(), typeInfo);
            }
            else if (value.IsGrafana)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityGrafanaDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityGrafanaDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityGrafanaDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrafana(), typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityLangfuseDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityLangfuseDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityLangfuseDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLangfuse(), typeInfo);
            }
            else if (value.IsLangsmith)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityLangsmithDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityLangsmithDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityLangsmithDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLangsmith(), typeInfo);
            }
            else if (value.IsNewrelic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityNewrelicDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityNewrelicDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityNewrelicDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNewrelic(), typeInfo);
            }
            else if (value.IsOpik)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityOpikDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityOpikDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityOpikDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpik(), typeInfo);
            }
            else if (value.IsOtelCollector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityOtelCollectorDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityOtelCollectorDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityOtelCollectorDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOtelCollector(), typeInfo);
            }
            else if (value.IsPosthog)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityPosthogDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityPosthogDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityPosthogDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPosthog(), typeInfo);
            }
            else if (value.IsRamp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityRampDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityRampDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityRampDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRamp(), typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityS3Destination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityS3Destination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityS3Destination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickS3(), typeInfo);
            }
            else if (value.IsSentry)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilitySentryDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilitySentryDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilitySentryDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSentry(), typeInfo);
            }
            else if (value.IsSnowflake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilitySnowflakeDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilitySnowflakeDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilitySnowflakeDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSnowflake(), typeInfo);
            }
            else if (value.IsWeave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityWeaveDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityWeaveDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityWeaveDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWeave(), typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ObservabilityWebhookDestination), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ObservabilityWebhookDestination?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ObservabilityWebhookDestination).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebhook(), typeInfo);
            }
        }
    }
}