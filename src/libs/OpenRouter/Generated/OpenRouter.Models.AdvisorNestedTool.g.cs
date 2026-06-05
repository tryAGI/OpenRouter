
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A tool made available to the advisor sub-agent. Accepts function tools and OpenRouter server tools (e.g. openrouter:web_search). The advisor tool may not list itself.
    /// </summary>
    public sealed partial class AdvisorNestedTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public object? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorNestedTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="function"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvisorNestedTool(
            string type,
            object? function,
            object? parameters)
        {
            this.Function = function;
            this.Parameters = parameters;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorNestedTool" /> class.
        /// </summary>
        public AdvisorNestedTool()
        {
        }

    }
}