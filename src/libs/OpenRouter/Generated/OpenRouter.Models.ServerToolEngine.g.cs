
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerToolEngine
    {
        /// <summary>
        /// Whether the engine needs the caller's own key, saved in plugin settings: `required` (OpenRouter holds none), `optional` (OpenRouter's key is used unless the caller saved one), or `none`<br/>
        /// Example: none
        /// </summary>
        /// <example>none</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ServerToolEngineByokJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ServerToolEngineByok Byok { get; set; }

        /// <summary>
        /// The data regions whose requests this engine serves without leaving the region. A request pinned to a region can only use engines that list it; `global` is always listed.<br/>
        /// Example: [global, us]
        /// </summary>
        /// <example>[global, us]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngineDataRegion> DataRegions { get; set; }

        /// <summary>
        /// The `parameters.mode` a request without one runs and bills as; null for engines without modes. The `pricing[]` row with this `mode` is what an unmoded request bills<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_mode")]
        public string? DefaultMode { get; set; }

        /// <summary>
        /// Who runs the tool call: the model provider during inference (`provider`), OpenRouter (`openrouter`), or the caller's application after the call is returned (`client`).<br/>
        /// Example: openrouter
        /// </summary>
        /// <example>openrouter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("executed_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ServerToolExecutedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ServerToolExecutedBy ExecutedBy { get; set; }

        /// <summary>
        /// The `parameters.engine` value that selects this engine; null for the single engine of a tool without an engine parameter<br/>
        /// Example: exa
        /// </summary>
        /// <example>exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: Exa
        /// </summary>
        /// <example>Exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The rows OpenRouter bills; non-empty exactly when `pricing_source` is `openrouter`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolPrice> Pricing { get; set; }

        /// <summary>
        /// Where the rates are documented when `pricing_source` is `provider` or `byok`; null otherwise<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_doc_url")]
        public string? PricingDocUrl { get; set; }

        /// <summary>
        /// Who bills the engine's calls beyond the model's tokens: `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)<br/>
        /// Example: openrouter
        /// </summary>
        /// <example>openrouter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ServerToolEnginePricingSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ServerToolEnginePricingSource PricingSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolEngine" /> class.
        /// </summary>
        /// <param name="byok">
        /// Whether the engine needs the caller's own key, saved in plugin settings: `required` (OpenRouter holds none), `optional` (OpenRouter's key is used unless the caller saved one), or `none`<br/>
        /// Example: none
        /// </param>
        /// <param name="dataRegions">
        /// The data regions whose requests this engine serves without leaving the region. A request pinned to a region can only use engines that list it; `global` is always listed.<br/>
        /// Example: [global, us]
        /// </param>
        /// <param name="executedBy">
        /// Who runs the tool call: the model provider during inference (`provider`), OpenRouter (`openrouter`), or the caller's application after the call is returned (`client`).<br/>
        /// Example: openrouter
        /// </param>
        /// <param name="name">
        /// Example: Exa
        /// </param>
        /// <param name="pricing">
        /// The rows OpenRouter bills; non-empty exactly when `pricing_source` is `openrouter`
        /// </param>
        /// <param name="pricingSource">
        /// Who bills the engine's calls beyond the model's tokens: `openrouter` (the `pricing` rows, from the caller's credits), `provider` (a per-call tool fee from the model's provider on the inference call, at its own rates), `byok` (the engine's vendor, against the caller's own key), or `none` (no charge)<br/>
        /// Example: openrouter
        /// </param>
        /// <param name="defaultMode">
        /// The `parameters.mode` a request without one runs and bills as; null for engines without modes. The `pricing[]` row with this `mode` is what an unmoded request bills<br/>
        /// Example: auto
        /// </param>
        /// <param name="id">
        /// The `parameters.engine` value that selects this engine; null for the single engine of a tool without an engine parameter<br/>
        /// Example: exa
        /// </param>
        /// <param name="pricingDocUrl">
        /// Where the rates are documented when `pricing_source` is `provider` or `byok`; null otherwise<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolEngine(
            global::OpenRouter.ServerToolEngineByok byok,
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngineDataRegion> dataRegions,
            global::OpenRouter.ServerToolExecutedBy executedBy,
            string name,
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolPrice> pricing,
            global::OpenRouter.ServerToolEnginePricingSource pricingSource,
            string? defaultMode,
            string? id,
            string? pricingDocUrl)
        {
            this.Byok = byok;
            this.DataRegions = dataRegions ?? throw new global::System.ArgumentNullException(nameof(dataRegions));
            this.DefaultMode = defaultMode;
            this.ExecutedBy = executedBy;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.PricingDocUrl = pricingDocUrl;
            this.PricingSource = pricingSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolEngine" /> class.
        /// </summary>
        public ServerToolEngine()
        {
        }

    }
}