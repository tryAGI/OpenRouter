
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// No outbound internet access.
    /// </summary>
    public enum ContainerNetworkPolicyVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerNetworkPolicyVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerNetworkPolicyVariant1Type value)
        {
            return value switch
            {
                ContainerNetworkPolicyVariant1Type.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerNetworkPolicyVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ContainerNetworkPolicyVariant1Type.Disabled,
                _ => null,
            };
        }
    }
}