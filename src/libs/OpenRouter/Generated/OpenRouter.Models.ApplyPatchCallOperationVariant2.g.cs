
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `delete_file` variant of an `apply_patch_call.operation`. Identifies the file to remove; no diff is required.
    /// </summary>
    public sealed partial class ApplyPatchCallOperationVariant2
    {
        /// <summary>
        /// Discriminator value: delete_file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationVariant2TypeJsonConverter))]
        public global::OpenRouter.ApplyPatchCallOperationVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationVariant2" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="type">
        /// Discriminator value: delete_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallOperationVariant2(
            string path,
            global::OpenRouter.ApplyPatchCallOperationVariant2Type type)
        {
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationVariant2" /> class.
        /// </summary>
        public ApplyPatchCallOperationVariant2()
        {
        }

    }
}