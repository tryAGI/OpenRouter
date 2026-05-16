
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityGrafanaDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Grafana,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityGrafanaDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityGrafanaDestinationType value)
        {
            return value switch
            {
                ObservabilityGrafanaDestinationType.Grafana => "grafana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityGrafanaDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "grafana" => ObservabilityGrafanaDestinationType.Grafana,
                _ => null,
            };
        }
    }
}