
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: us
    /// </summary>
    public enum ObservabilityNewrelicDestinationConfigRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityNewrelicDestinationConfigRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityNewrelicDestinationConfigRegion value)
        {
            return value switch
            {
                ObservabilityNewrelicDestinationConfigRegion.Eu => "eu",
                ObservabilityNewrelicDestinationConfigRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityNewrelicDestinationConfigRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => ObservabilityNewrelicDestinationConfigRegion.Eu,
                "us" => ObservabilityNewrelicDestinationConfigRegion.Us,
                _ => null,
            };
        }
    }
}