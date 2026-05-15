
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// computer_call variant
    /// </summary>
    public sealed partial class OutputItemsVariant3
    {
        /// <summary>
        /// Discriminator value: computer_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsVariant3TypeJsonConverter))]
        public global::OpenRouter.OutputItemsVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public object? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_safety_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems> PendingSafetyChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsDiscriminatorMappingComputerCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant3" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="pendingSafetyChecks"></param>
        /// <param name="status"></param>
        /// <param name="type">
        /// Discriminator value: computer_call
        /// </param>
        /// <param name="action"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant3(
            string callId,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems> pendingSafetyChecks,
            global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallStatus status,
            global::OpenRouter.OutputItemsVariant3Type type,
            object? action,
            string? id)
        {
            this.Type = type;
            this.Action = action;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.PendingSafetyChecks = pendingSafetyChecks ?? throw new global::System.ArgumentNullException(nameof(pendingSafetyChecks));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant3" /> class.
        /// </summary>
        public OutputItemsVariant3()
        {
        }

    }
}