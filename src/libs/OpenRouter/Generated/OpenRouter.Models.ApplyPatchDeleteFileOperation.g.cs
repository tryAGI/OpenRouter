
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `delete_file` variant of an `apply_patch_call.operation`. Identifies the file to remove; no diff is required.<br/>
    /// Example: {"path":"/src/main.ts","type":"delete_file"}
    /// </summary>
    public sealed partial class ApplyPatchDeleteFileOperation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchDeleteFileOperationTypeJsonConverter))]
        public global::OpenRouter.ApplyPatchDeleteFileOperationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchDeleteFileOperation" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchDeleteFileOperation(
            string path,
            global::OpenRouter.ApplyPatchDeleteFileOperationType type)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchDeleteFileOperation" /> class.
        /// </summary>
        public ApplyPatchDeleteFileOperation()
        {
        }

    }
}