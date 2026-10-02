
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The single tool this endpoint calls, asking the caller for input.<br/>
    /// Example: {"arguments":"{\u0022fields\u0022:[{\u0022name\u0022:\u0022answer\u0022,\u0022options\u0022:[\u0022red\u0022,\u0022blue\u0022,\u0022Other\u0022],\u0022required\u0022:true,\u0022type\u0022:\u0022string\u0022}],\u0022kind\u0022:\u0022elicitation\u0022,\u0022message\u0022:\u0022Which colour do you prefer?\u0022}","name":"openrouter.provide_input"}
    /// </summary>
    public sealed partial class InternChatToolCallFunction
    {
        /// <summary>
        /// A JSON object string describing the interaction. A permission request is `{"kind":"permission","operation":&lt;tool name or null&gt;,"options":[&lt;permission option kinds&gt;]}`. A question is `{"kind":"elicitation","message":&lt;question&gt;,"fields":[&lt;field descriptors&gt;]}`.<br/>
        /// Example: {"fields":[{"name":"answer","options":["red","blue","Other"],"required":true,"type":"string"}],"kind":"elicitation","message":"Which colour do you prefer?"}
        /// </summary>
        /// <example>{"fields":[{"name":"answer","options":["red","blue","Other"],"required":true,"type":"string"}],"kind":"elicitation","message":"Which colour do you prefer?"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatToolCallFunctionNameJsonConverter))]
        public global::OpenRouter.InternChatToolCallFunctionName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatToolCallFunction" /> class.
        /// </summary>
        /// <param name="arguments">
        /// A JSON object string describing the interaction. A permission request is `{"kind":"permission","operation":&lt;tool name or null&gt;,"options":[&lt;permission option kinds&gt;]}`. A question is `{"kind":"elicitation","message":&lt;question&gt;,"fields":[&lt;field descriptors&gt;]}`.<br/>
        /// Example: {"fields":[{"name":"answer","options":["red","blue","Other"],"required":true,"type":"string"}],"kind":"elicitation","message":"Which colour do you prefer?"}
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatToolCallFunction(
            string arguments,
            global::OpenRouter.InternChatToolCallFunctionName name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatToolCallFunction" /> class.
        /// </summary>
        public InternChatToolCallFunction()
        {
        }

    }
}