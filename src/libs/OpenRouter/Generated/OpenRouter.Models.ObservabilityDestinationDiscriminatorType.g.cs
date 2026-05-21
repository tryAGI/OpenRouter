
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityDestinationDiscriminatorType
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
    public static class ObservabilityDestinationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationDiscriminatorType value)
        {
            return value switch
            {
                ObservabilityDestinationDiscriminatorType.Arize => "arize",
                ObservabilityDestinationDiscriminatorType.Braintrust => "braintrust",
                ObservabilityDestinationDiscriminatorType.Clickhouse => "clickhouse",
                ObservabilityDestinationDiscriminatorType.Datadog => "datadog",
                ObservabilityDestinationDiscriminatorType.Grafana => "grafana",
                ObservabilityDestinationDiscriminatorType.Langfuse => "langfuse",
                ObservabilityDestinationDiscriminatorType.Langsmith => "langsmith",
                ObservabilityDestinationDiscriminatorType.Newrelic => "newrelic",
                ObservabilityDestinationDiscriminatorType.Opik => "opik",
                ObservabilityDestinationDiscriminatorType.OtelCollector => "otel-collector",
                ObservabilityDestinationDiscriminatorType.Posthog => "posthog",
                ObservabilityDestinationDiscriminatorType.Ramp => "ramp",
                ObservabilityDestinationDiscriminatorType.S3 => "s3",
                ObservabilityDestinationDiscriminatorType.Sentry => "sentry",
                ObservabilityDestinationDiscriminatorType.Snowflake => "snowflake",
                ObservabilityDestinationDiscriminatorType.Weave => "weave",
                ObservabilityDestinationDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "arize" => ObservabilityDestinationDiscriminatorType.Arize,
                "braintrust" => ObservabilityDestinationDiscriminatorType.Braintrust,
                "clickhouse" => ObservabilityDestinationDiscriminatorType.Clickhouse,
                "datadog" => ObservabilityDestinationDiscriminatorType.Datadog,
                "grafana" => ObservabilityDestinationDiscriminatorType.Grafana,
                "langfuse" => ObservabilityDestinationDiscriminatorType.Langfuse,
                "langsmith" => ObservabilityDestinationDiscriminatorType.Langsmith,
                "newrelic" => ObservabilityDestinationDiscriminatorType.Newrelic,
                "opik" => ObservabilityDestinationDiscriminatorType.Opik,
                "otel-collector" => ObservabilityDestinationDiscriminatorType.OtelCollector,
                "posthog" => ObservabilityDestinationDiscriminatorType.Posthog,
                "ramp" => ObservabilityDestinationDiscriminatorType.Ramp,
                "s3" => ObservabilityDestinationDiscriminatorType.S3,
                "sentry" => ObservabilityDestinationDiscriminatorType.Sentry,
                "snowflake" => ObservabilityDestinationDiscriminatorType.Snowflake,
                "weave" => ObservabilityDestinationDiscriminatorType.Weave,
                "webhook" => ObservabilityDestinationDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}