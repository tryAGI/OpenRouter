
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1
    {
        /// <summary>
        /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
        /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
        /// </summary>
        /// <example>{"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::OpenRouter.Alignment? Alignment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice> Choices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Debug? Debug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant1ObjectJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Object Object { get; set; }

        /// <summary>
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </summary>
        /// <example>{"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public global::OpenRouter.OpenRouterMetadata? OpenrouterMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1" /> class.
        /// </summary>
        /// <param name="choices"></param>
        /// <param name="created"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="alignment">
        /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
        /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
        /// </param>
        /// <param name="debug"></param>
        /// <param name="object"></param>
        /// <param name="openrouterMetadata">
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </param>
        /// <param name="provider"></param>
        /// <param name="serviceTier"></param>
        /// <param name="systemFingerprint"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1(
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice> choices,
            int created,
            string id,
            string model,
            global::OpenRouter.Alignment? alignment,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1Debug? debug,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1Object @object,
            global::OpenRouter.OpenRouterMetadata? openrouterMetadata,
            string? provider,
            string? serviceTier,
            string? systemFingerprint,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1Usage? usage)
        {
            this.Alignment = alignment;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Debug = debug;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.OpenrouterMetadata = openrouterMetadata;
            this.Provider = provider;
            this.ServiceTier = serviceTier;
            this.SystemFingerprint = systemFingerprint;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1()
        {
        }

    }
}