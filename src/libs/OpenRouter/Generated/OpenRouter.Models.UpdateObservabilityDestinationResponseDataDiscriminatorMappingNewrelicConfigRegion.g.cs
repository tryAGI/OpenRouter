
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default Value: us
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion
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
    public static class UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion.Eu => "eu",
                UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion.Eu,
                "us" => UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion.Us,
                _ => null,
            };
        }
    }
}