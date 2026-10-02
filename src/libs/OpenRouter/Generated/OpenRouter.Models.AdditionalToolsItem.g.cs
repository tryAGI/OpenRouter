
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Additional tools made available to the model at this point in the input<br/>
    /// Example: {"role":"developer","tools":[{"name":"get_weather","parameters":{"properties":{"location":{"type":"string"}},"type":"object"},"type":"function"}],"type":"additional_tools"}
    /// </summary>
    public sealed partial class AdditionalToolsItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AdditionalToolsItemRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AdditionalToolsItemRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.AdditionalToolsItemTool>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool, global::OpenRouter.AdditionalToolsItemTool2>> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AdditionalToolsItemTypeJsonConverter))]
        public global::OpenRouter.AdditionalToolsItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalToolsItem" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="tools"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdditionalToolsItem(
            global::OpenRouter.AdditionalToolsItemRole role,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.AdditionalToolsItemTool>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool, global::OpenRouter.AdditionalToolsItemTool2>> tools,
            string? id,
            global::OpenRouter.AdditionalToolsItemType type)
        {
            this.Id = id;
            this.Role = role;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalToolsItem" /> class.
        /// </summary>
        public AdditionalToolsItem()
        {
        }

    }
}