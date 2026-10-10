
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Function definition for tool calling<br/>
    /// Example: {"description":"Get the current weather for a location","name":"get_weather","parameters":{"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}}
    /// </summary>
    public sealed partial class ChatFunctionToolVariant1Function
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Function description for the model<br/>
        /// Example: Get the current weather for a location
        /// </summary>
        /// <example>Get the current weather for a location</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)<br/>
        /// Example: get_weather
        /// </summary>
        /// <example>get_weather</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Function parameters as JSON Schema object<br/>
        /// Example: {"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}
        /// </summary>
        /// <example>{"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Enable strict schema adherence<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionToolVariant1Function" /> class.
        /// </summary>
        /// <param name="name">
        /// Function name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)<br/>
        /// Example: get_weather
        /// </param>
        /// <param name="deferLoading"></param>
        /// <param name="description">
        /// Function description for the model<br/>
        /// Example: Get the current weather for a location
        /// </param>
        /// <param name="parameters">
        /// Function parameters as JSON Schema object<br/>
        /// Example: {"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}
        /// </param>
        /// <param name="strict">
        /// Enable strict schema adherence<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatFunctionToolVariant1Function(
            string name,
            bool? deferLoading,
            string? description,
            object? parameters,
            bool? strict)
        {
            this.DeferLoading = deferLoading;
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionToolVariant1Function" /> class.
        /// </summary>
        public ChatFunctionToolVariant1Function()
        {
        }

    }
}