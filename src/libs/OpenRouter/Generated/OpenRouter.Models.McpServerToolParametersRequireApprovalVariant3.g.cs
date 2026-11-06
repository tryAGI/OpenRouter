
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpServerToolParametersRequireApprovalVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolParametersRequireApprovalVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolParametersRequireApprovalVariant3 value)
        {
            return value switch
            {
                McpServerToolParametersRequireApprovalVariant3.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolParametersRequireApprovalVariant3? ToEnum(string value)
        {
            return value switch
            {
                "never" => McpServerToolParametersRequireApprovalVariant3.Never,
                _ => null,
            };
        }
    }
}