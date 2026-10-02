
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Outbound access restricted to the listed domains.
    /// </summary>
    public enum ContainerNetworkPolicyVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Allowlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerNetworkPolicyVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerNetworkPolicyVariant2Type value)
        {
            return value switch
            {
                ContainerNetworkPolicyVariant2Type.Allowlist => "allowlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerNetworkPolicyVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "allowlist" => ContainerNetworkPolicyVariant2Type.Allowlist,
                _ => null,
            };
        }
    }
}