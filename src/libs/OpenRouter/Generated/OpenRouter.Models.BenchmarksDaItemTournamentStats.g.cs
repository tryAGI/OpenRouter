
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Placement distribution from tournament matches.
    /// </summary>
    public sealed partial class BenchmarksDaItemTournamentStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_place")]
        public int? FirstPlace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fourth_place")]
        public int? FourthPlace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("second_place")]
        public int? SecondPlace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("third_place")]
        public int? ThirdPlace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksDaItemTournamentStats" /> class.
        /// </summary>
        /// <param name="firstPlace"></param>
        /// <param name="fourthPlace"></param>
        /// <param name="secondPlace"></param>
        /// <param name="thirdPlace"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BenchmarksDaItemTournamentStats(
            int? firstPlace,
            int? fourthPlace,
            int? secondPlace,
            int? thirdPlace,
            int? total)
        {
            this.FirstPlace = firstPlace;
            this.FourthPlace = fourthPlace;
            this.SecondPlace = secondPlace;
            this.ThirdPlace = thirdPlace;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksDaItemTournamentStats" /> class.
        /// </summary>
        public BenchmarksDaItemTournamentStats()
        {
        }

    }
}