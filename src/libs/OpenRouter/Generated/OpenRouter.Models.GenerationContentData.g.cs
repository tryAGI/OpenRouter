
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stored prompt and completion content, plus the failure error when one was stored<br/>
    /// Example: {"error":null,"input":{"messages":[{"content":"What is the meaning of life?","role":"user"}]},"output":{"completion":"The meaning of life is a philosophical question...","reasoning":null}}
    /// </summary>
    public sealed partial class GenerationContentData
    {
        /// <summary>
        /// The stored failure for this generation, or null when it succeeded<br/>
        /// Example: {"message":"Timed out waiting for the provider","previous_errors":[{"code":429,"message":"Provider returned error","provider_name":"Google","raw":"{\u0022error\u0022:{\u0022code\u0022:429,\u0022message\u0022:\u0022Resource exhausted\u0022}}"}],"provider_name":"Vertex","raw":"{\u0022error\u0022:{\u0022code\u0022:504,\u0022message\u0022:\u0022Deadline exceeded\u0022}}","status":504}
        /// </summary>
        /// <example>{"message":"Timed out waiting for the provider","previous_errors":[{"code":429,"message":"Provider returned error","provider_name":"Google","raw":"{\u0022error\u0022:{\u0022code\u0022:429,\u0022message\u0022:\u0022Resource exhausted\u0022}}"}],"provider_name":"Vertex","raw":"{\u0022error\u0022:{\u0022code\u0022:504,\u0022message\u0022:\u0022Deadline exceeded\u0022}}","status":504}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::OpenRouter.GenerationContentError? Error { get; set; }

        /// <summary>
        /// The input to the generation — either a prompt string or an array of messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.GenerationContentDataInputVariant1, global::OpenRouter.GenerationContentDataInputVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.GenerationContentDataInputVariant1, global::OpenRouter.GenerationContentDataInputVariant2> Input { get; set; }

        /// <summary>
        /// The output from the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GenerationContentDataOutput Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentData" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to the generation — either a prompt string or an array of messages
        /// </param>
        /// <param name="output">
        /// The output from the generation
        /// </param>
        /// <param name="error">
        /// The stored failure for this generation, or null when it succeeded<br/>
        /// Example: {"message":"Timed out waiting for the provider","previous_errors":[{"code":429,"message":"Provider returned error","provider_name":"Google","raw":"{\u0022error\u0022:{\u0022code\u0022:429,\u0022message\u0022:\u0022Resource exhausted\u0022}}"}],"provider_name":"Vertex","raw":"{\u0022error\u0022:{\u0022code\u0022:504,\u0022message\u0022:\u0022Deadline exceeded\u0022}}","status":504}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentData(
            global::OpenRouter.AnyOf<global::OpenRouter.GenerationContentDataInputVariant1, global::OpenRouter.GenerationContentDataInputVariant2> input,
            global::OpenRouter.GenerationContentDataOutput output,
            global::OpenRouter.GenerationContentError? error)
        {
            this.Error = error;
            this.Input = input;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentData" /> class.
        /// </summary>
        public GenerationContentData()
        {
        }

    }
}