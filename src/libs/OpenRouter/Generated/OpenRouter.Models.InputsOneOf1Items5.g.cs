
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output message item
    /// </summary>
    public sealed partial class InputsOneOf1Items5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsOneOf5ContentJsonConverter))]
        public global::OpenRouter.InputsOneOf1ItemsOneOf5Content? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items5" /> class.
        /// </summary>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputsOneOf1Items5(
            global::OpenRouter.InputsOneOf1ItemsOneOf5Content? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items5" /> class.
        /// </summary>
        public InputsOneOf1Items5()
        {
        }
    }
}