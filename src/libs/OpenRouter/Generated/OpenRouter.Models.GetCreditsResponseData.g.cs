
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"total_credits":100.5,"total_usage":25.75}
    /// </summary>
    public sealed partial class GetCreditsResponseData
    {
        /// <summary>
        /// Total credits purchased<br/>
        /// Example: 100.5F
        /// </summary>
        /// <example>100.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCredits { get; set; }

        /// <summary>
        /// Total credits used<br/>
        /// Example: 25.75F
        /// </summary>
        /// <example>25.75F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponseData" /> class.
        /// </summary>
        /// <param name="totalCredits">
        /// Total credits purchased<br/>
        /// Example: 100.5F
        /// </param>
        /// <param name="totalUsage">
        /// Total credits used<br/>
        /// Example: 25.75F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCreditsResponseData(
            double totalCredits,
            double totalUsage)
        {
            this.TotalCredits = totalCredits;
            this.TotalUsage = totalUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreditsResponseData" /> class.
        /// </summary>
        public GetCreditsResponseData()
        {
        }

    }
}