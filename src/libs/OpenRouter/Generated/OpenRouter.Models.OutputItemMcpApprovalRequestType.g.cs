
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemMcpApprovalRequestType
    {
        /// <summary>
        ///
        /// </summary>
        McpApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpApprovalRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpApprovalRequestType value)
        {
            return value switch
            {
                OutputItemMcpApprovalRequestType.McpApprovalRequest => "mcp_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpApprovalRequestType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_request" => OutputItemMcpApprovalRequestType.McpApprovalRequest,
                _ => null,
            };
        }
    }
}