
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A detected entity, returned when the provider runs entity detection<br/>
    /// Example: {"end_char":25,"start_char":15,"text":"John Smith","type":"name"}
    /// </summary>
    public sealed partial class STTEntity
    {
        /// <summary>
        /// Zero-based exclusive character offset of the entity end within the response-level text (not seconds)<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_char")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndChar { get; set; }

        /// <summary>
        /// Zero-based character offset of the entity start within the response-level text (not seconds)<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_char")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartChar { get; set; }

        /// <summary>
        /// Entity text as it appears in the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Provider entity type label<br/>
        /// Example: name
        /// </summary>
        /// <example>name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTEntity" /> class.
        /// </summary>
        /// <param name="endChar">
        /// Zero-based exclusive character offset of the entity end within the response-level text (not seconds)<br/>
        /// Example: 25
        /// </param>
        /// <param name="startChar">
        /// Zero-based character offset of the entity start within the response-level text (not seconds)<br/>
        /// Example: 15
        /// </param>
        /// <param name="text">
        /// Entity text as it appears in the transcript
        /// </param>
        /// <param name="type">
        /// Provider entity type label<br/>
        /// Example: name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTEntity(
            int endChar,
            int startChar,
            string text,
            string type)
        {
            this.EndChar = endChar;
            this.StartChar = startChar;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTEntity" /> class.
        /// </summary>
        public STTEntity()
        {
        }

    }
}