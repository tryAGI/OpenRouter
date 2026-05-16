
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilitySentryDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Sentry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilitySentryDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilitySentryDestinationType value)
        {
            return value switch
            {
                ObservabilitySentryDestinationType.Sentry => "sentry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilitySentryDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "sentry" => ObservabilitySentryDestinationType.Sentry,
                _ => null,
            };
        }
    }
}