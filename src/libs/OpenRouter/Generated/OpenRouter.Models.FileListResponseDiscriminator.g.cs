
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FileListResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FileListResponseDiscriminatorShapeJsonConverter))]
        public global::OpenRouter.FileListResponseDiscriminatorShape? Shape { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileListResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="shape"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileListResponseDiscriminator(
            global::OpenRouter.FileListResponseDiscriminatorShape? shape)
        {
            this.Shape = shape;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileListResponseDiscriminator" /> class.
        /// </summary>
        public FileListResponseDiscriminator()
        {
        }

    }
}