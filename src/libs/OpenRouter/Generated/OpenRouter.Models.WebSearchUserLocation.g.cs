
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// User location information for web search
    /// </summary>
    public sealed partial class WebSearchUserLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationTypeJsonConverter))]
        public global::OpenRouter.WebSearchUserLocationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchUserLocation" /> class.
        /// </summary>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="timezone"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchUserLocation(
            string? city,
            string? country,
            string? region,
            string? timezone,
            global::OpenRouter.WebSearchUserLocationType? type)
        {
            this.City = city;
            this.Country = country;
            this.Region = region;
            this.Timezone = timezone;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchUserLocation" /> class.
        /// </summary>
        public WebSearchUserLocation()
        {
        }
    }
}