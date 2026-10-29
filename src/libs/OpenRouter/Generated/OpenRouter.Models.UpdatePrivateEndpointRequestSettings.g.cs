
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Only the fields present change; an omitted field keeps its stored value and `null` clears a limit or reverts a flag to the provider default.
    /// </summary>
    public sealed partial class UpdatePrivateEndpointRequestSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}