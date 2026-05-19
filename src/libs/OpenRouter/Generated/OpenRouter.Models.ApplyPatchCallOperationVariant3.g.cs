
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `update_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing edits to an existing file.
    /// </summary>
    public sealed partial class ApplyPatchCallOperationVariant3
    {
        /// <summary>
        /// Discriminator value: update_file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationVariant3TypeJsonConverter))]
        public global::OpenRouter.ApplyPatchCallOperationVariant3Type Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationVariant3" /> class.
        /// </summary>
        /// <param name="diff"></param>
        /// <param name="path"></param>
        /// <param name="type">
        /// Discriminator value: update_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallOperationVariant3(
            string diff,
            string path,
            global::OpenRouter.ApplyPatchCallOperationVariant3Type type)
        {
            this.Type = type;
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationVariant3" /> class.
        /// </summary>
        public ApplyPatchCallOperationVariant3()
        {
        }

    }
}