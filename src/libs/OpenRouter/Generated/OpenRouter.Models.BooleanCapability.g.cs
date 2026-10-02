
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A supported-or-not flag. Present means the parameter is accepted.<br/>
    /// Example: {"type":"boolean"}
    /// </summary>
    public sealed partial class BooleanCapability
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BooleanCapabilityTypeJsonConverter))]
        public global::OpenRouter.BooleanCapabilityType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanCapability" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BooleanCapability(
            global::OpenRouter.BooleanCapabilityType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanCapability" /> class.
        /// </summary>
        public BooleanCapability()
        {
        }

    }
}