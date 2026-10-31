
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Assets keyed by reference string. Write a reference wherever the asset belongs in `state` or a field `instructions`; every asset must be referenced at least once. A `state` that is exactly the sole asset's key carries no text of its own and is read as file-only. A model that reads either text or a document per request, not both (ScaleDown Extract with a PDF), needs that form: any other text around the key is state text and is rejected with 400.
    /// </summary>
    public sealed partial class ExtractionsRequestAssets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}