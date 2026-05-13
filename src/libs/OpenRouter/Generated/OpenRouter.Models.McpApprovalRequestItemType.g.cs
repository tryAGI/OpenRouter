
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpApprovalRequestItemType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalRequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalRequestItemType value)
        {
            return value switch
            {
                McpApprovalRequestItemType.McpApprovalRequest => "mcp_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalRequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_request" => McpApprovalRequestItemType.McpApprovalRequest,
                _ => null,
            };
        }
    }
}