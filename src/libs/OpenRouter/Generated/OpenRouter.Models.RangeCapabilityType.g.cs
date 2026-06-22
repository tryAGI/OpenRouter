
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum RangeCapabilityType
    {
        /// <summary>
        /// 
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RangeCapabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RangeCapabilityType value)
        {
            return value switch
            {
                RangeCapabilityType.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RangeCapabilityType? ToEnum(string value)
        {
            return value switch
            {
                "range" => RangeCapabilityType.Range,
                _ => null,
            };
        }
    }
}