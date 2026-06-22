
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single image model in the discovery listing.
    /// </summary>
    public sealed partial class ImageModelListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ImageModelArchitecture Architecture { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) of when the model was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Relative URL to the full per-endpoint records for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoints { get; set; }

        /// <summary>
        /// Model slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Union of supported parameters across every endpoint of this model. Coarse discovery aid; the definitive per-endpoint set is behind the endpoints URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SupportedParameters SupportedParameters { get; set; }

        /// <summary>
        /// Whether any endpoint of this model supports native SSE streaming on the dedicated Image API (i.e. `stream: true` in the request). OR across endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_streaming")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsStreaming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelListItem" /> class.
        /// </summary>
        /// <param name="architecture"></param>
        /// <param name="created">
        /// Unix timestamp (seconds) of when the model was created
        /// </param>
        /// <param name="description"></param>
        /// <param name="endpoints">
        /// Relative URL to the full per-endpoint records for this model
        /// </param>
        /// <param name="id">
        /// Model slug
        /// </param>
        /// <param name="name">
        /// Display name
        /// </param>
        /// <param name="supportedParameters">
        /// Union of supported parameters across every endpoint of this model. Coarse discovery aid; the definitive per-endpoint set is behind the endpoints URL.
        /// </param>
        /// <param name="supportsStreaming">
        /// Whether any endpoint of this model supports native SSE streaming on the dedicated Image API (i.e. `stream: true` in the request). OR across endpoints.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageModelListItem(
            global::OpenRouter.ImageModelArchitecture architecture,
            global::System.DateTimeOffset created,
            string description,
            string endpoints,
            string id,
            string name,
            global::OpenRouter.SupportedParameters supportedParameters,
            bool supportsStreaming)
        {
            this.Architecture = architecture ?? throw new global::System.ArgumentNullException(nameof(architecture));
            this.Created = created;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.SupportsStreaming = supportsStreaming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelListItem" /> class.
        /// </summary>
        public ImageModelListItem()
        {
        }

    }
}