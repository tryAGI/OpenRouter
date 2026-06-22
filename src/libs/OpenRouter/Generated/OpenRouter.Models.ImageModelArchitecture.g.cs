
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageModelArchitecture
    {
        /// <summary>
        /// Supported input modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.InputModality> InputModalities { get; set; }

        /// <summary>
        /// Supported output modalities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality> OutputModalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelArchitecture" /> class.
        /// </summary>
        /// <param name="inputModalities">
        /// Supported input modalities
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageModelArchitecture(
            global::System.Collections.Generic.IList<global::OpenRouter.InputModality> inputModalities,
            global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality> outputModalities)
        {
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageModelArchitecture" /> class.
        /// </summary>
        public ImageModelArchitecture()
        {
        }

    }
}