
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The destination type. Only stable destination types are accepted.<br/>
    /// Example: langfuse
    /// </summary>
    public readonly partial struct CreateObservabilityDestinationRequestType : global::System.IEquatable<CreateObservabilityDestinationRequestType>
    {
        /// <summary>
        ///
        /// </summary>
        public CreateObservabilityDestinationRequestType(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Arize { get; } = new("arize");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Braintrust { get; } = new("braintrust");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Clickhouse { get; } = new("clickhouse");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Datadog { get; } = new("datadog");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Grafana { get; } = new("grafana");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Langfuse { get; } = new("langfuse");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Langsmith { get; } = new("langsmith");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Newrelic { get; } = new("newrelic");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Opik { get; } = new("opik");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType OtelCollector { get; } = new("otel-collector");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Posthog { get; } = new("posthog");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Ramp { get; } = new("ramp");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType S3 { get; } = new("s3");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Sentry { get; } = new("sentry");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Snowflake { get; } = new("snowflake");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Weave { get; } = new("weave");

        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType Webhook { get; } = new("webhook");
        /// <summary>
        ///
        /// </summary>
        public static CreateObservabilityDestinationRequestType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "arize" => Arize,
                "braintrust" => Braintrust,
                "clickhouse" => Clickhouse,
                "datadog" => Datadog,
                "grafana" => Grafana,
                "langfuse" => Langfuse,
                "langsmith" => Langsmith,
                "newrelic" => Newrelic,
                "opik" => Opik,
                "otel-collector" => OtelCollector,
                "posthog" => Posthog,
                "ramp" => Ramp,
                "s3" => S3,
                "sentry" => Sentry,
                "snowflake" => Snowflake,
                "weave" => Weave,
                "webhook" => Webhook,
                _ => new CreateObservabilityDestinationRequestType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "arize" => true,
            "braintrust" => true,
            "clickhouse" => true,
            "datadog" => true,
            "grafana" => true,
            "langfuse" => true,
            "langsmith" => true,
            "newrelic" => true,
            "opik" => true,
            "otel-collector" => true,
            "posthog" => true,
            "ramp" => true,
            "s3" => true,
            "sentry" => true,
            "snowflake" => true,
            "weave" => true,
            "webhook" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CreateObservabilityDestinationRequestType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateObservabilityDestinationRequestType other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateObservabilityDestinationRequestType left, CreateObservabilityDestinationRequestType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateObservabilityDestinationRequestType left, CreateObservabilityDestinationRequestType right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationRequestType? ToEnum(string value)
        {
            return CreateObservabilityDestinationRequestType.FromValue(value);
        }
    }
}