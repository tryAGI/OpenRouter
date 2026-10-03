
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Descriptor for one request parameter: `type` plus the optional `min`, `max`, `default`, `values`, `unit`, `max_items`, `properties` and `items` constraints. Recursive through `properties` and `items`; the full JSON Schema is in the Models API V2 schema asset.
    /// </summary>
    public sealed partial class ParameterDescriptorV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        public global::OpenRouter.OneOf<string, double?, bool?>? Default { get; set; }

        /// <summary>
        /// Descriptor for one request parameter: `type` plus the optional `min`, `max`, `default`, `values`, `unit`, `max_items`, `properties` and `items` constraints. Recursive through `properties` and `items`; the full JSON Schema is in the Models API V2 schema asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::OpenRouter.ParameterDescriptorV2? Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_items")]
        public int? MaxItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? Properties { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ParameterDescriptorV2TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ParameterDescriptorV2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DescriptorUnitV2JsonConverter))]
        public global::OpenRouter.DescriptorUnitV2? Unit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<string, double?>>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDescriptorV2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="default"></param>
        /// <param name="items">
        /// Descriptor for one request parameter: `type` plus the optional `min`, `max`, `default`, `values`, `unit`, `max_items`, `properties` and `items` constraints. Recursive through `properties` and `items`; the full JSON Schema is in the Models API V2 schema asset.
        /// </param>
        /// <param name="max"></param>
        /// <param name="maxItems"></param>
        /// <param name="min"></param>
        /// <param name="properties"></param>
        /// <param name="unit"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParameterDescriptorV2(
            global::OpenRouter.ParameterDescriptorV2Type type,
            global::OpenRouter.OneOf<string, double?, bool?>? @default,
            global::OpenRouter.ParameterDescriptorV2? items,
            double? max,
            int? maxItems,
            double? min,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? properties,
            global::OpenRouter.DescriptorUnitV2? unit,
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<string, double?>>? values)
        {
            this.Default = @default;
            this.Items = items;
            this.Max = max;
            this.MaxItems = maxItems;
            this.Min = min;
            this.Properties = properties;
            this.Type = type;
            this.Unit = unit;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDescriptorV2" /> class.
        /// </summary>
        public ParameterDescriptorV2()
        {
        }

    }
}