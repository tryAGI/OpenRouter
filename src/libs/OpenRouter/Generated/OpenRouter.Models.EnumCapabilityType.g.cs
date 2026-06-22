
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumCapabilityType
    {
        /// <summary>
        /// 
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnumCapabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnumCapabilityType value)
        {
            return value switch
            {
                EnumCapabilityType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnumCapabilityType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => EnumCapabilityType.Enum,
                _ => null,
            };
        }
    }
}