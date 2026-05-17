
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataDiscriminatorType
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
    public static class UpdateObservabilityDestinationResponseDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataDiscriminatorType value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Arize => "arize",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Braintrust => "braintrust",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Clickhouse => "clickhouse",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Datadog => "datadog",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Grafana => "grafana",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Langfuse => "langfuse",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Langsmith => "langsmith",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Newrelic => "newrelic",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Opik => "opik",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.OtelCollector => "otel-collector",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Posthog => "posthog",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Ramp => "ramp",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.S3 => "s3",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Sentry => "sentry",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Snowflake => "snowflake",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Weave => "weave",
                UpdateObservabilityDestinationResponseDataDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "arize" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Arize,
                "braintrust" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Braintrust,
                "clickhouse" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Clickhouse,
                "datadog" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Datadog,
                "grafana" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Grafana,
                "langfuse" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Langfuse,
                "langsmith" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Langsmith,
                "newrelic" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Newrelic,
                "opik" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Opik,
                "otel-collector" => UpdateObservabilityDestinationResponseDataDiscriminatorType.OtelCollector,
                "posthog" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Posthog,
                "ramp" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Ramp,
                "s3" => UpdateObservabilityDestinationResponseDataDiscriminatorType.S3,
                "sentry" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Sentry,
                "snowflake" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Snowflake,
                "weave" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Weave,
                "webhook" => UpdateObservabilityDestinationResponseDataDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}