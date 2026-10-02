
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A parameter that accepts any value within an inclusive numeric range.<br/>
    /// Example: {"max":100,"min":0,"type":"range"}
    /// </summary>
    public sealed partial class RangeCapability
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RangeCapabilityTypeJsonConverter))]
        public global::OpenRouter.RangeCapabilityType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeCapability" /> class.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RangeCapability(
            double max,
            double min,
            global::OpenRouter.RangeCapabilityType type)
        {
            this.Max = max;
            this.Min = min;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeCapability" /> class.
        /// </summary>
        public RangeCapability()
        {
        }

    }
}