
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Free-model (`:free` variant) daily request quota for the account that owns the key. Reports the same counter and tier limit that free-model enforcement reads for accounts subject to the free-model limits; the counter resets at UTC midnight. Accounts and endpoints exempt from free-model limits, and BYOK requests, are not gated by it, so `remaining` is the tier policy rather than an enforced ceiling for them.<br/>
    /// Example: {"limit":50,"remaining":38,"used":12}
    /// </summary>
    public sealed partial class FreeModelDailyRequests
    {
        /// <summary>
        /// Free-model requests the account may make per UTC day; the ceiling depends on total credits purchased and is independent of `is_free_tier`<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Free-model requests left in the current UTC day<br/>
        /// Example: 38
        /// </summary>
        /// <example>38</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Remaining { get; set; }

        /// <summary>
        /// Free-model requests recorded for the account so far in the current UTC day<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Used { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FreeModelDailyRequests" /> class.
        /// </summary>
        /// <param name="limit">
        /// Free-model requests the account may make per UTC day; the ceiling depends on total credits purchased and is independent of `is_free_tier`<br/>
        /// Example: 50
        /// </param>
        /// <param name="remaining">
        /// Free-model requests left in the current UTC day<br/>
        /// Example: 38
        /// </param>
        /// <param name="used">
        /// Free-model requests recorded for the account so far in the current UTC day<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FreeModelDailyRequests(
            int limit,
            int remaining,
            int used)
        {
            this.Limit = limit;
            this.Remaining = remaining;
            this.Used = used;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FreeModelDailyRequests" /> class.
        /// </summary>
        public FreeModelDailyRequests()
        {
        }

    }
}