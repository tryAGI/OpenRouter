
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointsMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo> Available { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsMetadata" /> class.
        /// </summary>
        /// <param name="available"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointsMetadata(
            global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo> available,
            int total)
        {
            this.Available = available ?? throw new global::System.ArgumentNullException(nameof(available));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsMetadata" /> class.
        /// </summary>
        public EndpointsMetadata()
        {
        }

    }
}