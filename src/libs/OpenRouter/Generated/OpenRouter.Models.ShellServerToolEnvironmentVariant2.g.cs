
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference to a previously created container to reuse.
    /// </summary>
    public sealed partial class ShellServerToolEnvironmentVariant2
    {
        /// <summary>
        /// Discriminator value: container_reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellServerToolEnvironmentVariant2TypeJsonConverter))]
        public global::OpenRouter.ShellServerToolEnvironmentVariant2Type Type { get; set; }

        /// <summary>
        /// Identifier of an existing container to reuse (max 20 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolEnvironmentVariant2" /> class.
        /// </summary>
        /// <param name="containerId">
        /// Identifier of an existing container to reuse (max 20 characters).
        /// </param>
        /// <param name="type">
        /// Discriminator value: container_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellServerToolEnvironmentVariant2(
            string containerId,
            global::OpenRouter.ShellServerToolEnvironmentVariant2Type type)
        {
            this.Type = type;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolEnvironmentVariant2" /> class.
        /// </summary>
        public ShellServerToolEnvironmentVariant2()
        {
        }

    }
}