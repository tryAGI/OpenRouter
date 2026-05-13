
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpApprovalResponseItemType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalResponseItemType value)
        {
            return value switch
            {
                McpApprovalResponseItemType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => McpApprovalResponseItemType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}