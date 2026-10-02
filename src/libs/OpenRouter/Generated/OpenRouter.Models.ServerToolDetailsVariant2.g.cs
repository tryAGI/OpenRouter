
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerToolDetailsVariant2
    {
        /// <summary>
        /// Endpoints whose provider runs this tool itself during inference. Zero for tools no provider runs natively.<br/>
        /// Example: {"endpoint_count":18,"model_count":12}
        /// </summary>
        /// <example>{"endpoint_count":18,"model_count":12}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_support")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ServerToolNativeSupport, global::OpenRouter.ServerToolDetailsVariant2NativeSupport>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ServerToolNativeSupport, global::OpenRouter.ServerToolDetailsVariant2NativeSupport>? NativeSupport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolDetailsVariant2" /> class.
        /// </summary>
        /// <param name="nativeSupport">
        /// Endpoints whose provider runs this tool itself during inference. Zero for tools no provider runs natively.<br/>
        /// Example: {"endpoint_count":18,"model_count":12}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolDetailsVariant2(
            global::OpenRouter.AllOf<global::OpenRouter.ServerToolNativeSupport, global::OpenRouter.ServerToolDetailsVariant2NativeSupport>? nativeSupport)
        {
            this.NativeSupport = nativeSupport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolDetailsVariant2" /> class.
        /// </summary>
        public ServerToolDetailsVariant2()
        {
        }

    }
}