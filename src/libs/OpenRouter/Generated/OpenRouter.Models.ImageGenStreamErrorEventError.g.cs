
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider error details
    /// </summary>
    public sealed partial class ImageGenStreamErrorEventError
    {
        /// <summary>
        /// Provider error code, when supplied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Provider error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Request parameter associated with the error, when supplied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Provider error type, when supplied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenStreamErrorEventError" /> class.
        /// </summary>
        /// <param name="message">
        /// Provider error message
        /// </param>
        /// <param name="code">
        /// Provider error code, when supplied
        /// </param>
        /// <param name="param">
        /// Request parameter associated with the error, when supplied
        /// </param>
        /// <param name="type">
        /// Provider error type, when supplied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenStreamErrorEventError(
            string message,
            string? code,
            string? param,
            string? type)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenStreamErrorEventError" /> class.
        /// </summary>
        public ImageGenStreamErrorEventError()
        {
        }

    }
}