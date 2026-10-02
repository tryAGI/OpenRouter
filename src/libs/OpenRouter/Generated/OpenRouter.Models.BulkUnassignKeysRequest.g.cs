
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"key_hashes":["c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93"]}
    /// </summary>
    public sealed partial class BulkUnassignKeysRequest
    {
        /// <summary>
        /// Array of API key hashes to unassign from the guardrail<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </summary>
        /// <example>[c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KeyHashes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysRequest" /> class.
        /// </summary>
        /// <param name="keyHashes">
        /// Array of API key hashes to unassign from the guardrail<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUnassignKeysRequest(
            global::System.Collections.Generic.IList<string> keyHashes)
        {
            this.KeyHashes = keyHashes ?? throw new global::System.ArgumentNullException(nameof(keyHashes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysRequest" /> class.
        /// </summary>
        public BulkUnassignKeysRequest()
        {
        }

    }
}