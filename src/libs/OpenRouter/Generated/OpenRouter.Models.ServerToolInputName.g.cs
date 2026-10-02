
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerToolInputName
    {
        /// <summary>
        /// API formats that accept this spelling in `tools[].type`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputNameApiFormat> ApiFormats { get; set; }

        /// <summary>
        /// What the call surfaces as on each accepting API format when requested under this spelling; a format is absent when the call is not visible to the caller
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolOutputName> OutputNames { get; set; }

        /// <summary>
        /// Example: web_search_20250305
        /// </summary>
        /// <example>web_search_20250305</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolInputName" /> class.
        /// </summary>
        /// <param name="apiFormats">
        /// API formats that accept this spelling in `tools[].type`
        /// </param>
        /// <param name="outputNames">
        /// What the call surfaces as on each accepting API format when requested under this spelling; a format is absent when the call is not visible to the caller
        /// </param>
        /// <param name="type">
        /// Example: web_search_20250305
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolInputName(
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputNameApiFormat> apiFormats,
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolOutputName> outputNames,
            string type)
        {
            this.ApiFormats = apiFormats ?? throw new global::System.ArgumentNullException(nameof(apiFormats));
            this.OutputNames = outputNames ?? throw new global::System.ArgumentNullException(nameof(outputNames));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolInputName" /> class.
        /// </summary>
        public ServerToolInputName()
        {
        }

    }
}