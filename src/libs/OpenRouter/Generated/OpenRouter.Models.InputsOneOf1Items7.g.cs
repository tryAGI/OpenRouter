
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output message item
    /// </summary>
    public sealed partial class InputsOneOf1Items7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.InputsOneOf1ItemsOneOf7Content?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.InputsOneOf1ItemsOneOf7Content?, object>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items7" /> class.
        /// </summary>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputsOneOf1Items7(
            global::OpenRouter.OneOf<global::OpenRouter.InputsOneOf1ItemsOneOf7Content?, object>? content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items7" /> class.
        /// </summary>
        public InputsOneOf1Items7()
        {
        }

    }
}