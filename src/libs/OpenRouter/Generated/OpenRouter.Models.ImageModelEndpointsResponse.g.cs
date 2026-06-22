
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The full per-endpoint records for an image model.
    /// </summary>
    public sealed partial class ImageModelEndpointsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Model slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelEndpointsResponse" /> class.
        /// </summary>
        /// <param name="endpoints"></param>
        /// <param name="id">
        /// Model slug
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageModelEndpointsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint> endpoints,
            string id)
        {
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelEndpointsResponse" /> class.
        /// </summary>
        public ImageModelEndpointsResponse()
        {
        }

    }
}