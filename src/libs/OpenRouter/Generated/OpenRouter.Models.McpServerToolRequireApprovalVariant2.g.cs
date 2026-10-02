
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpServerToolRequireApprovalVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Always,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolRequireApprovalVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolRequireApprovalVariant2 value)
        {
            return value switch
            {
                McpServerToolRequireApprovalVariant2.Always => "always",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolRequireApprovalVariant2? ToEnum(string value)
        {
            return value switch
            {
                "always" => McpServerToolRequireApprovalVariant2.Always,
                _ => null,
            };
        }
    }
}