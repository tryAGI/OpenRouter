
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PresetWithDesignatedVersionVariant2
    {
        /// <summary>
        /// A specific version of a preset, containing config and optional system prompt.<br/>
        /// Example: {"config":{"model":"openai/gpt-4o","temperature":0.7},"created_at":"2026-04-20T10:00:00Z","creator_id":"user_2dHFtVWx2n56w6HkM0000000000","id":"550e8400-e29b-41d4-a716-446655440000","preset_id":"650e8400-e29b-41d4-a716-446655440001","system_prompt":"You are a helpful assistant.","updated_at":"2026-04-20T10:00:00Z","version":1}
        /// </summary>
        /// <example>{"config":{"model":"openai/gpt-4o","temperature":0.7},"created_at":"2026-04-20T10:00:00Z","creator_id":"user_2dHFtVWx2n56w6HkM0000000000","id":"550e8400-e29b-41d4-a716-446655440000","preset_id":"650e8400-e29b-41d4-a716-446655440001","system_prompt":"You are a helpful assistant.","updated_at":"2026-04-20T10:00:00Z","version":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("designated_version")]
        public global::OpenRouter.PresetDesignatedVersion? DesignatedVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetWithDesignatedVersionVariant2" /> class.
        /// </summary>
        /// <param name="designatedVersion">
        /// A specific version of a preset, containing config and optional system prompt.<br/>
        /// Example: {"config":{"model":"openai/gpt-4o","temperature":0.7},"created_at":"2026-04-20T10:00:00Z","creator_id":"user_2dHFtVWx2n56w6HkM0000000000","id":"550e8400-e29b-41d4-a716-446655440000","preset_id":"650e8400-e29b-41d4-a716-446655440001","system_prompt":"You are a helpful assistant.","updated_at":"2026-04-20T10:00:00Z","version":1}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresetWithDesignatedVersionVariant2(
            global::OpenRouter.PresetDesignatedVersion? designatedVersion)
        {
            this.DesignatedVersion = designatedVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetWithDesignatedVersionVariant2" /> class.
        /// </summary>
        public PresetWithDesignatedVersionVariant2()
        {
        }

    }
}