
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Images keyed by reference string, as in TypeSafe's API. Write a reference wherever the image belongs in `state`, `instructions`, or `criteria`; every asset must be referenced at least once. Jev reads a reference as a whole string value or inside longer text. Other Decisions models read a whole-string reference wherever they read an `image_url` part and reject a reference inside longer text.
    /// </summary>
    public sealed partial class DecisionsRequestAssets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}