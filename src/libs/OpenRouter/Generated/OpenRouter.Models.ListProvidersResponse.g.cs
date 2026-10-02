
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"datacenters":["US","IE"],"headquarters":"US","name":"OpenAI","privacy_policy_url":"https://openai.com/privacy","slug":"openai","status_page_url":"https://status.openai.com","terms_of_service_url":"https://openai.com/terms"}]}
    /// </summary>
    public sealed partial class ListProvidersResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProvidersResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProvidersResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProvidersResponse" /> class.
        /// </summary>
        public ListProvidersResponse()
        {
        }

    }
}