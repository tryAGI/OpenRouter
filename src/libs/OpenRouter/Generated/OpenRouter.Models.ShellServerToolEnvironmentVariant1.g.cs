
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An OpenRouter-managed, auto-provisioned ephemeral container.
    /// </summary>
    public sealed partial class ShellServerToolEnvironmentVariant1
    {
        /// <summary>
        /// Discriminator value: container_auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellServerToolEnvironmentVariant1TypeJsonConverter))]
        public global::OpenRouter.ShellServerToolEnvironmentVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolEnvironmentVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: container_auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellServerToolEnvironmentVariant1(
            global::OpenRouter.ShellServerToolEnvironmentVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolEnvironmentVariant1" /> class.
        /// </summary>
        public ShellServerToolEnvironmentVariant1()
        {
        }

    }
}