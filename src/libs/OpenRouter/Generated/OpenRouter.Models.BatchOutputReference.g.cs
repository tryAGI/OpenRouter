
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output location of a batch submitted with `input`, whose `results` are `null`. Returned only by `GET /batches/{id}`, once the batch has ended and the provider reported an output folder or table. Batch lists and responses for a batch with an unpaid charge leave it out.
    /// </summary>
    public sealed partial class BatchOutputReference
    {
        /// <summary>
        /// URI of the batch output in your own storage. For a Cloud Storage input file it is the output folder, in the form `gs://bucket/folder`, and the files are in the provider batch output format. For a BigQuery input table it is the output table, in the form `bq://project.dataset.table`.<br/>
        /// Example: gs://my-bucket/openrouter-batch/output/org_abc/batch_123/batch_123/prediction-model-2026-01-01T00:00:00.000000Z
        /// </summary>
        /// <example>gs://my-bucket/openrouter-batch/output/org_abc/batch_123/batch_123/prediction-model-2026-01-01T00:00:00.000000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOutputReference" /> class.
        /// </summary>
        /// <param name="uri">
        /// URI of the batch output in your own storage. For a Cloud Storage input file it is the output folder, in the form `gs://bucket/folder`, and the files are in the provider batch output format. For a BigQuery input table it is the output table, in the form `bq://project.dataset.table`.<br/>
        /// Example: gs://my-bucket/openrouter-batch/output/org_abc/batch_123/batch_123/prediction-model-2026-01-01T00:00:00.000000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchOutputReference(
            string uri)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchOutputReference" /> class.
        /// </summary>
        public BatchOutputReference()
        {
        }

    }
}