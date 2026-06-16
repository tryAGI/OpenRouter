
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An OpenRouter-managed, auto-provisioned ephemeral container.
    /// </summary>
    public sealed partial class BashServerToolEnvironmentVariant1
    {
        /// <summary>
        /// Discriminator value: container_auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BashServerToolEnvironmentVariant1TypeJsonConverter))]
        public global::OpenRouter.BashServerToolEnvironmentVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerToolEnvironmentVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: container_auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashServerToolEnvironmentVariant1(
            global::OpenRouter.BashServerToolEnvironmentVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerToolEnvironmentVariant1" /> class.
        /// </summary>
        public BashServerToolEnvironmentVariant1()
        {
        }

    }
}