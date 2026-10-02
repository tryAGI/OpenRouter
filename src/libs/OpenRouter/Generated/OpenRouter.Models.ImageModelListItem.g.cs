
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single image model in the discovery listing.<br/>
    /// Example: {"architecture":{"input_modalities":["text","image"],"output_modalities":["image"]},"created":1692901234,"description":"A text-to-image model.","endpoints":"/api/v1/images/models/bytedance-seed/seedream-4.5/endpoints","id":"bytedance-seed/seedream-4.5","name":"Seedream 4.5","supported_parameters":{"resolution":{"type":"enum","values":["1K","2K","4K"]},"seed":{"type":"boolean"}},"supports_streaming":false}
    /// </summary>
    public sealed partial class ImageModelListItem
    {
        /// <summary>
        /// Example: {"input_modalities":["text","image"],"output_modalities":["image"]}
        /// </summary>
        /// <example>{"input_modalities":["text","image"],"output_modalities":["image"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ImageModelArchitecture Architecture { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) of when the model was created<br/>
        /// Example: 1692901234
        /// </summary>
        /// <example>1692901234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Example: A text-to-image model.
        /// </summary>
        /// <example>A text-to-image model.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Relative URL to the full per-endpoint records for this model<br/>
        /// Example: /api/v1/images/models/bytedance-seed/seedream-4.5/endpoints
        /// </summary>
        /// <example>/api/v1/images/models/bytedance-seed/seedream-4.5/endpoints</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoints { get; set; }

        /// <summary>
        /// Model slug<br/>
        /// Example: bytedance-seed/seedream-4.5
        /// </summary>
        /// <example>bytedance-seed/seedream-4.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name<br/>
        /// Example: Seedream 4.5
        /// </summary>
        /// <example>Seedream 4.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Union of supported parameters across every endpoint of this model. Coarse discovery aid; the definitive per-endpoint set is behind the endpoints URL.<br/>
        /// Example: {"output_compression":{"max":100,"min":0,"type":"range"},"resolution":{"type":"enum","values":["1K","2K","4K"]},"seed":{"type":"boolean"}}
        /// </summary>
        /// <example>{"output_compression":{"max":100,"min":0,"type":"range"},"resolution":{"type":"enum","values":["1K","2K","4K"]},"seed":{"type":"boolean"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor> SupportedParameters { get; set; }

        /// <summary>
        /// Whether any endpoint of this model supports native SSE streaming on the dedicated Image API (i.e. `stream: true` in the request). OR across endpoints.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
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
        /// <param name="architecture">
        /// Example: {"input_modalities":["text","image"],"output_modalities":["image"]}
        /// </param>
        /// <param name="created">
        /// Unix timestamp (seconds) of when the model was created<br/>
        /// Example: 1692901234
        /// </param>
        /// <param name="description">
        /// Example: A text-to-image model.
        /// </param>
        /// <param name="endpoints">
        /// Relative URL to the full per-endpoint records for this model<br/>
        /// Example: /api/v1/images/models/bytedance-seed/seedream-4.5/endpoints
        /// </param>
        /// <param name="id">
        /// Model slug<br/>
        /// Example: bytedance-seed/seedream-4.5
        /// </param>
        /// <param name="name">
        /// Display name<br/>
        /// Example: Seedream 4.5
        /// </param>
        /// <param name="supportedParameters">
        /// Union of supported parameters across every endpoint of this model. Coarse discovery aid; the definitive per-endpoint set is behind the endpoints URL.<br/>
        /// Example: {"output_compression":{"max":100,"min":0,"type":"range"},"resolution":{"type":"enum","values":["1K","2K","4K"]},"seed":{"type":"boolean"}}
        /// </param>
        /// <param name="supportsStreaming">
        /// Whether any endpoint of this model supports native SSE streaming on the dedicated Image API (i.e. `stream: true` in the request). OR across endpoints.<br/>
        /// Example: false
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
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor> supportedParameters,
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