
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetObservabilityDestinationResponseDataDiscriminatorType
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
    public static class GetObservabilityDestinationResponseDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataDiscriminatorType value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataDiscriminatorType.Arize => "arize",
                GetObservabilityDestinationResponseDataDiscriminatorType.Braintrust => "braintrust",
                GetObservabilityDestinationResponseDataDiscriminatorType.Clickhouse => "clickhouse",
                GetObservabilityDestinationResponseDataDiscriminatorType.Datadog => "datadog",
                GetObservabilityDestinationResponseDataDiscriminatorType.Grafana => "grafana",
                GetObservabilityDestinationResponseDataDiscriminatorType.Langfuse => "langfuse",
                GetObservabilityDestinationResponseDataDiscriminatorType.Langsmith => "langsmith",
                GetObservabilityDestinationResponseDataDiscriminatorType.Newrelic => "newrelic",
                GetObservabilityDestinationResponseDataDiscriminatorType.Opik => "opik",
                GetObservabilityDestinationResponseDataDiscriminatorType.OtelCollector => "otel-collector",
                GetObservabilityDestinationResponseDataDiscriminatorType.Posthog => "posthog",
                GetObservabilityDestinationResponseDataDiscriminatorType.Ramp => "ramp",
                GetObservabilityDestinationResponseDataDiscriminatorType.S3 => "s3",
                GetObservabilityDestinationResponseDataDiscriminatorType.Sentry => "sentry",
                GetObservabilityDestinationResponseDataDiscriminatorType.Snowflake => "snowflake",
                GetObservabilityDestinationResponseDataDiscriminatorType.Weave => "weave",
                GetObservabilityDestinationResponseDataDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "arize" => GetObservabilityDestinationResponseDataDiscriminatorType.Arize,
                "braintrust" => GetObservabilityDestinationResponseDataDiscriminatorType.Braintrust,
                "clickhouse" => GetObservabilityDestinationResponseDataDiscriminatorType.Clickhouse,
                "datadog" => GetObservabilityDestinationResponseDataDiscriminatorType.Datadog,
                "grafana" => GetObservabilityDestinationResponseDataDiscriminatorType.Grafana,
                "langfuse" => GetObservabilityDestinationResponseDataDiscriminatorType.Langfuse,
                "langsmith" => GetObservabilityDestinationResponseDataDiscriminatorType.Langsmith,
                "newrelic" => GetObservabilityDestinationResponseDataDiscriminatorType.Newrelic,
                "opik" => GetObservabilityDestinationResponseDataDiscriminatorType.Opik,
                "otel-collector" => GetObservabilityDestinationResponseDataDiscriminatorType.OtelCollector,
                "posthog" => GetObservabilityDestinationResponseDataDiscriminatorType.Posthog,
                "ramp" => GetObservabilityDestinationResponseDataDiscriminatorType.Ramp,
                "s3" => GetObservabilityDestinationResponseDataDiscriminatorType.S3,
                "sentry" => GetObservabilityDestinationResponseDataDiscriminatorType.Sentry,
                "snowflake" => GetObservabilityDestinationResponseDataDiscriminatorType.Snowflake,
                "weave" => GetObservabilityDestinationResponseDataDiscriminatorType.Weave,
                "webhook" => GetObservabilityDestinationResponseDataDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}