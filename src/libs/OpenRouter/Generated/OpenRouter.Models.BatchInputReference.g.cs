
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A batch input file or table in your own storage, named in place of `requests`. Available to allowlisted callers on Google Vertex BYOK endpoints only.
    /// </summary>
    public sealed partial class BatchInputReference
    {
        /// <summary>
        /// URI of the batch input: a Cloud Storage file in the form `gs://bucket/object`, or a BigQuery table in the form `bq://project.dataset.table`. The input stays in your project and must already be in the provider batch input format.<br/>
        /// Example: gs://my-bucket/batches/input.jsonl
        /// </summary>
        /// <example>gs://my-bucket/batches/input.jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputReference" /> class.
        /// </summary>
        /// <param name="uri">
        /// URI of the batch input: a Cloud Storage file in the form `gs://bucket/object`, or a BigQuery table in the form `bq://project.dataset.table`. The input stays in your project and must already be in the provider batch input format.<br/>
        /// Example: gs://my-bucket/batches/input.jsonl
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchInputReference(
            string uri)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchInputReference" /> class.
        /// </summary>
        public BatchInputReference()
        {
        }

    }
}