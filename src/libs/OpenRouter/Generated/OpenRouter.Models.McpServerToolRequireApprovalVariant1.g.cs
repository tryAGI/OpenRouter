
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpServerToolRequireApprovalVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always")]
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Always? Always { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never")]
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Never? Never { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApprovalVariant1" /> class.
        /// </summary>
        /// <param name="always"></param>
        /// <param name="never"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerToolRequireApprovalVariant1(
            global::OpenRouter.McpServerToolRequireApprovalVariant1Always? always,
            global::OpenRouter.McpServerToolRequireApprovalVariant1Never? never)
        {
            this.Always = always;
            this.Never = never;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApprovalVariant1" /> class.
        /// </summary>
        public McpServerToolRequireApprovalVariant1()
        {
        }

    }
}