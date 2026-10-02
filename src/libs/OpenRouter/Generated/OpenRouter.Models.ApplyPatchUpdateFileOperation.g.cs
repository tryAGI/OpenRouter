
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `update_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing edits to an existing file.<br/>
    /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
    /// </summary>
    public sealed partial class ApplyPatchUpdateFileOperation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Diff { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchUpdateFileOperationTypeJsonConverter))]
        public global::OpenRouter.ApplyPatchUpdateFileOperationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchUpdateFileOperation" /> class.
        /// </summary>
        /// <param name="diff"></param>
        /// <param name="path"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchUpdateFileOperation(
            string diff,
            string path,
            global::OpenRouter.ApplyPatchUpdateFileOperationType type)
        {
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchUpdateFileOperation" /> class.
        /// </summary>
        public ApplyPatchUpdateFileOperation()
        {
        }

    }
}