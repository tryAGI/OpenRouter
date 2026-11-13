
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContentFilterReadEntryVariant2
    {
        /// <summary>
        /// Whether inference applies this pattern. False for a pattern saved before pattern validation that is too complex to run safely; it is kept but skipped until replaced.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enforced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterReadEntryVariant2" /> class.
        /// </summary>
        /// <param name="isEnforced">
        /// Whether inference applies this pattern. False for a pattern saved before pattern validation that is too complex to run safely; it is kept but skipped until replaced.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterReadEntryVariant2(
            bool isEnforced)
        {
            this.IsEnforced = isEnforced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterReadEntryVariant2" /> class.
        /// </summary>
        public ContentFilterReadEntryVariant2()
        {
        }

    }
}