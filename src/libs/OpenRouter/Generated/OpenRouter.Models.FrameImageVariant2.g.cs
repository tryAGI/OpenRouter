
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FrameImageVariant2
    {
        /// <summary>
        /// Whether this image represents the first or last frame of the video<br/>
        /// Example: first_frame
        /// </summary>
        /// <example>first_frame</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FrameImageVariant2FrameTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FrameImageVariant2FrameType FrameType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameImageVariant2" /> class.
        /// </summary>
        /// <param name="frameType">
        /// Whether this image represents the first or last frame of the video<br/>
        /// Example: first_frame
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FrameImageVariant2(
            global::OpenRouter.FrameImageVariant2FrameType frameType)
        {
            this.FrameType = frameType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameImageVariant2" /> class.
        /// </summary>
        public FrameImageVariant2()
        {
        }

    }
}