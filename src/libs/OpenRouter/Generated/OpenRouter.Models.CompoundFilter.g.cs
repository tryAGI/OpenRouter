
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A compound filter that combines multiple comparison or compound filters
    /// </summary>
    public sealed partial class CompoundFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CompoundFilterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CompoundFilterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompoundFilter" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompoundFilter(
            global::System.Collections.Generic.IList<object> filters,
            global::OpenRouter.CompoundFilterType type)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompoundFilter" /> class.
        /// </summary>
        public CompoundFilter()
        {
        }
    }
}