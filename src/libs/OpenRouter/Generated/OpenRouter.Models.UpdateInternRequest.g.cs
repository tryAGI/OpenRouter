
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Lifecycle settings to change. Omitted fields stay unchanged and null clears a field.<br/>
    /// Example: {"description":"Researches customer questions","model":"openai/gpt-5.4"}
    /// </summary>
    public sealed partial class UpdateInternRequest
    {
        /// <summary>
        /// New free-form description. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New standing instructions. Null clears them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// New OpenRouter model slug in `author/slug` form (an optional `:variant` suffix is accepted). Other shapes are refused with 400. Null restores the workspace default. Takes effect on the next provision: until then `GET` shows this configured model while chat chunks show the model the running intern reports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// New intern name, unique per creator within the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInternRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// New free-form description. Null clears it.
        /// </param>
        /// <param name="instructions">
        /// New standing instructions. Null clears them.
        /// </param>
        /// <param name="model">
        /// New OpenRouter model slug in `author/slug` form (an optional `:variant` suffix is accepted). Other shapes are refused with 400. Null restores the workspace default. Takes effect on the next provision: until then `GET` shows this configured model while chat chunks show the model the running intern reports.
        /// </param>
        /// <param name="name">
        /// New intern name, unique per creator within the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInternRequest(
            string? description,
            string? instructions,
            string? model,
            string? name)
        {
            this.Description = description;
            this.Instructions = instructions;
            this.Model = model;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInternRequest" /> class.
        /// </summary>
        public UpdateInternRequest()
        {
        }

    }
}