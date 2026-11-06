
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpServerToolParametersRequireApprovalVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Always,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolParametersRequireApprovalVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolParametersRequireApprovalVariant2 value)
        {
            return value switch
            {
                McpServerToolParametersRequireApprovalVariant2.Always => "always",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolParametersRequireApprovalVariant2? ToEnum(string value)
        {
            return value switch
            {
                "always" => McpServerToolParametersRequireApprovalVariant2.Always,
                _ => null,
            };
        }
    }
}