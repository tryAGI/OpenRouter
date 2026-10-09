
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The tools a client-executed tool search loaded<br/>
    /// Example: {"call_id":"call_search_1","execution":"client","status":"completed","tools":[{"name":"get_weather","parameters":{"properties":{"location":{"type":"string"}},"type":"object"},"type":"function"}],"type":"tool_search_output"}
    /// </summary>
    public sealed partial class ToolSearchOutputItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchOutputItemExecutionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolSearchOutputItemExecution Execution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchOutputItemStatusJsonConverter))]
        public global::OpenRouter.ToolSearchOutputItemStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ToolSearchOutputItemTool>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool, global::OpenRouter.ToolSearchOutputItemTool2>> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchOutputItemTypeJsonConverter))]
        public global::OpenRouter.ToolSearchOutputItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="execution"></param>
        /// <param name="tools"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchOutputItem(
            string callId,
            global::OpenRouter.ToolSearchOutputItemExecution execution,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ToolSearchOutputItemTool>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool, global::OpenRouter.ToolSearchOutputItemTool2>> tools,
            string? id,
            global::OpenRouter.ToolSearchOutputItemStatus? status,
            global::OpenRouter.ToolSearchOutputItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Execution = execution;
            this.Id = id;
            this.Status = status;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchOutputItem" /> class.
        /// </summary>
        public ToolSearchOutputItem()
        {
        }

    }
}