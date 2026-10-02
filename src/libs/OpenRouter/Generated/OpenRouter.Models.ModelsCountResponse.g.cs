
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Model count data<br/>
    /// Example: {"data":{"count":150}}
    /// </summary>
    public sealed partial class ModelsCountResponse
    {
        /// <summary>
        /// Model count data<br/>
        /// Example: {"count":150}
        /// </summary>
        /// <example>{"count":150}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelsCountResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Model count data<br/>
        /// Example: {"count":150}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsCountResponse(
            global::OpenRouter.ModelsCountResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponse" /> class.
        /// </summary>
        public ModelsCountResponse()
        {
        }

    }
}