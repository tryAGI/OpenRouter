
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: boolean
    /// </summary>
    public enum CapabilityDescriptorVariant1Type
    {
        /// <summary>
        /// boolean
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CapabilityDescriptorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilityDescriptorVariant1Type value)
        {
            return value switch
            {
                CapabilityDescriptorVariant1Type.Boolean => "boolean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilityDescriptorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CapabilityDescriptorVariant1Type.Boolean,
                _ => null,
            };
        }
    }
}