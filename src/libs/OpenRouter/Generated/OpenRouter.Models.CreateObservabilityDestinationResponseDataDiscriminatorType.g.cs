
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Arize,
        /// <summary>
        /// 
        /// </summary>
        Braintrust,
        /// <summary>
        /// 
        /// </summary>
        Clickhouse,
        /// <summary>
        /// 
        /// </summary>
        Datadog,
        /// <summary>
        /// 
        /// </summary>
        Grafana,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        Langsmith,
        /// <summary>
        /// 
        /// </summary>
        Newrelic,
        /// <summary>
        /// 
        /// </summary>
        Opik,
        /// <summary>
        /// 
        /// </summary>
        OtelCollector,
        /// <summary>
        /// 
        /// </summary>
        Posthog,
        /// <summary>
        /// 
        /// </summary>
        Ramp,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        Sentry,
        /// <summary>
        /// 
        /// </summary>
        Snowflake,
        /// <summary>
        /// 
        /// </summary>
        Weave,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataDiscriminatorType value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataDiscriminatorType.Arize => "arize",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Braintrust => "braintrust",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Clickhouse => "clickhouse",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Datadog => "datadog",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Grafana => "grafana",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Langfuse => "langfuse",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Langsmith => "langsmith",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Newrelic => "newrelic",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Opik => "opik",
                CreateObservabilityDestinationResponseDataDiscriminatorType.OtelCollector => "otel-collector",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Posthog => "posthog",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Ramp => "ramp",
                CreateObservabilityDestinationResponseDataDiscriminatorType.S3 => "s3",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Sentry => "sentry",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Snowflake => "snowflake",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Weave => "weave",
                CreateObservabilityDestinationResponseDataDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "arize" => CreateObservabilityDestinationResponseDataDiscriminatorType.Arize,
                "braintrust" => CreateObservabilityDestinationResponseDataDiscriminatorType.Braintrust,
                "clickhouse" => CreateObservabilityDestinationResponseDataDiscriminatorType.Clickhouse,
                "datadog" => CreateObservabilityDestinationResponseDataDiscriminatorType.Datadog,
                "grafana" => CreateObservabilityDestinationResponseDataDiscriminatorType.Grafana,
                "langfuse" => CreateObservabilityDestinationResponseDataDiscriminatorType.Langfuse,
                "langsmith" => CreateObservabilityDestinationResponseDataDiscriminatorType.Langsmith,
                "newrelic" => CreateObservabilityDestinationResponseDataDiscriminatorType.Newrelic,
                "opik" => CreateObservabilityDestinationResponseDataDiscriminatorType.Opik,
                "otel-collector" => CreateObservabilityDestinationResponseDataDiscriminatorType.OtelCollector,
                "posthog" => CreateObservabilityDestinationResponseDataDiscriminatorType.Posthog,
                "ramp" => CreateObservabilityDestinationResponseDataDiscriminatorType.Ramp,
                "s3" => CreateObservabilityDestinationResponseDataDiscriminatorType.S3,
                "sentry" => CreateObservabilityDestinationResponseDataDiscriminatorType.Sentry,
                "snowflake" => CreateObservabilityDestinationResponseDataDiscriminatorType.Snowflake,
                "weave" => CreateObservabilityDestinationResponseDataDiscriminatorType.Weave,
                "webhook" => CreateObservabilityDestinationResponseDataDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}