
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Images keyed by reference string, as in TypeSafe's API. Write a reference wherever the image belongs in `state`, `instructions`, or `criteria`; every asset must be referenced at least once, or the request fails with `400` naming the unused key. TypeSafe Jev endpoints receive `assets` as written and read a reference as a whole string value or inside longer text. Every other provider has each whole-string reference resolved to an `image_url` part before the request is sent, so it is accepted only where that provider reads `image_url` parts (top-level `state` items), and a reference inside longer text fails with `400`. `image_url` parts and `assets` can be mixed in one request.
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