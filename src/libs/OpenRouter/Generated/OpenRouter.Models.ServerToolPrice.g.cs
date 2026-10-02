
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerToolPrice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_units_per_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxUnitsPerCall { get; set; }

        /// <summary>
        /// The `parameters.mode` this price applies to; null for prices that do not depend on the mode. A request bills exactly one `request` row<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// USD per unit, as a decimal string<br/>
        /// Example: 0.007
        /// </summary>
        /// <example>0.007</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Price { get; set; }

        /// <summary>
        /// Example: request
        /// </summary>
        /// <example>request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolPrice" /> class.
        /// </summary>
        /// <param name="maxUnitsPerCall"></param>
        /// <param name="price">
        /// USD per unit, as a decimal string<br/>
        /// Example: 0.007
        /// </param>
        /// <param name="unit">
        /// Example: request
        /// </param>
        /// <param name="mode">
        /// The `parameters.mode` this price applies to; null for prices that do not depend on the mode. A request bills exactly one `request` row<br/>
        /// Example: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolPrice(
            int maxUnitsPerCall,
            string price,
            string unit,
            string? mode)
        {
            this.MaxUnitsPerCall = maxUnitsPerCall;
            this.Mode = mode;
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolPrice" /> class.
        /// </summary>
        public ServerToolPrice()
        {
        }

    }
}