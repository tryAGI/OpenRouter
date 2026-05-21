
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The destination type. Only stable destination types are accepted.
    /// </summary>
    public enum CreateObservabilityDestinationRequestType
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
    public static class CreateObservabilityDestinationRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationRequestType value)
        {
            return value switch
            {
                CreateObservabilityDestinationRequestType.Arize => "arize",
                CreateObservabilityDestinationRequestType.Braintrust => "braintrust",
                CreateObservabilityDestinationRequestType.Clickhouse => "clickhouse",
                CreateObservabilityDestinationRequestType.Datadog => "datadog",
                CreateObservabilityDestinationRequestType.Grafana => "grafana",
                CreateObservabilityDestinationRequestType.Langfuse => "langfuse",
                CreateObservabilityDestinationRequestType.Langsmith => "langsmith",
                CreateObservabilityDestinationRequestType.Newrelic => "newrelic",
                CreateObservabilityDestinationRequestType.Opik => "opik",
                CreateObservabilityDestinationRequestType.OtelCollector => "otel-collector",
                CreateObservabilityDestinationRequestType.Posthog => "posthog",
                CreateObservabilityDestinationRequestType.Ramp => "ramp",
                CreateObservabilityDestinationRequestType.S3 => "s3",
                CreateObservabilityDestinationRequestType.Sentry => "sentry",
                CreateObservabilityDestinationRequestType.Snowflake => "snowflake",
                CreateObservabilityDestinationRequestType.Weave => "weave",
                CreateObservabilityDestinationRequestType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationRequestType? ToEnum(string value)
        {
            return value switch
            {
                "arize" => CreateObservabilityDestinationRequestType.Arize,
                "braintrust" => CreateObservabilityDestinationRequestType.Braintrust,
                "clickhouse" => CreateObservabilityDestinationRequestType.Clickhouse,
                "datadog" => CreateObservabilityDestinationRequestType.Datadog,
                "grafana" => CreateObservabilityDestinationRequestType.Grafana,
                "langfuse" => CreateObservabilityDestinationRequestType.Langfuse,
                "langsmith" => CreateObservabilityDestinationRequestType.Langsmith,
                "newrelic" => CreateObservabilityDestinationRequestType.Newrelic,
                "opik" => CreateObservabilityDestinationRequestType.Opik,
                "otel-collector" => CreateObservabilityDestinationRequestType.OtelCollector,
                "posthog" => CreateObservabilityDestinationRequestType.Posthog,
                "ramp" => CreateObservabilityDestinationRequestType.Ramp,
                "s3" => CreateObservabilityDestinationRequestType.S3,
                "sentry" => CreateObservabilityDestinationRequestType.Sentry,
                "snowflake" => CreateObservabilityDestinationRequestType.Snowflake,
                "weave" => CreateObservabilityDestinationRequestType.Weave,
                "webhook" => CreateObservabilityDestinationRequestType.Webhook,
                _ => null,
            };
        }
    }
}