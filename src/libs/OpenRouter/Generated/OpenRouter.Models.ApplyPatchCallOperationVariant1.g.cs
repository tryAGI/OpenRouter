
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `create_file` variant of an `apply_patch_call.operation`. Carries a V4A diff describing the new file contents.
    /// </summary>
    public sealed partial class ApplyPatchCallOperationVariant1
    {
        /// <summary>
        /// Discriminator value: create_file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationVariant1TypeJsonConverter))]
        public global::OpenRouter.ApplyPatchCallOperationVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationVariant1" /> class.
        /// </summary>
        /// <param name="diff"></param>
        /// <param name="path"></param>
        /// <param name="type">
        /// Discriminator value: create_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallOperationVariant1(
            string diff,
            string path,
            global::OpenRouter.ApplyPatchCallOperationVariant1Type type)
        {
            this.Type = type;
            this.Diff = diff ?? throw new global::System.ArgumentNullException(nameof(diff));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationVariant1" /> class.
        /// </summary>
        public ApplyPatchCallOperationVariant1()
        {
        }

    }
}