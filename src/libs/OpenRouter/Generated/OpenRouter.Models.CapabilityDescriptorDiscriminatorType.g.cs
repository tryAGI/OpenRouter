
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CapabilityDescriptorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Enum,
        /// <summary>
        /// 
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CapabilityDescriptorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilityDescriptorDiscriminatorType value)
        {
            return value switch
            {
                CapabilityDescriptorDiscriminatorType.Boolean => "boolean",
                CapabilityDescriptorDiscriminatorType.Enum => "enum",
                CapabilityDescriptorDiscriminatorType.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilityDescriptorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => CapabilityDescriptorDiscriminatorType.Boolean,
                "enum" => CapabilityDescriptorDiscriminatorType.Enum,
                "range" => CapabilityDescriptorDiscriminatorType.Range,
                _ => null,
            };
        }
    }
}