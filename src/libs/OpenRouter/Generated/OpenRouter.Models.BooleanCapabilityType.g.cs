
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BooleanCapabilityType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BooleanCapabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BooleanCapabilityType value)
        {
            return value switch
            {
                BooleanCapabilityType.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BooleanCapabilityType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => BooleanCapabilityType.Boolean,
                _ => null,
            };
        }
    }
}