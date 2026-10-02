
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum McpServerToolRequireApprovalVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolRequireApprovalVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolRequireApprovalVariant3 value)
        {
            return value switch
            {
                McpServerToolRequireApprovalVariant3.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolRequireApprovalVariant3? ToEnum(string value)
        {
            return value switch
            {
                "never" => McpServerToolRequireApprovalVariant3.Never,
                _ => null,
            };
        }
    }
}