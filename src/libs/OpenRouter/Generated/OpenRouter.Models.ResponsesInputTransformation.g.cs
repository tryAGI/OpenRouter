
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One input item the upstream provider changed before inference, e.g. a replayed reasoning item removed because the conversation before it was edited.<br/>
    /// Example: {"action":"removed","id":"rs_0ca73592c5f68037016afcc009779887","reason":"prefix_mismatch","type":"reasoning"}
    /// </summary>
    public sealed partial class ResponsesInputTransformation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponsesInputTransformation" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="id"></param>
        /// <param name="reason"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesInputTransformation(
            string action,
            string id,
            string reason,
            string type)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesInputTransformation" /> class.
        /// </summary>
        public ResponsesInputTransformation()
        {
        }

    }
}