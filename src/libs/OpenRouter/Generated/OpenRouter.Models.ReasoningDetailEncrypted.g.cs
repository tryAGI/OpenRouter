
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning detail encrypted schema
    /// </summary>
    public sealed partial class ReasoningDetailEncrypted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningDetailEncryptedTypeJsonConverter))]
        public global::OpenRouter.ReasoningDetailEncryptedType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ReasoningDetailEncryptedFormat?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ReasoningDetailEncryptedFormat?, object>? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailEncrypted" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningDetailEncrypted(
            string data,
            global::OpenRouter.ReasoningDetailEncryptedType type,
            string? id,
            global::OpenRouter.OneOf<global::OpenRouter.ReasoningDetailEncryptedFormat?, object>? format,
            double? index)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
            this.Id = id;
            this.Format = format;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailEncrypted" /> class.
        /// </summary>
        public ReasoningDetailEncrypted()
        {
        }
    }
}