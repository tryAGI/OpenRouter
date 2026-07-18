
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A conditional override of the base pricing. An entry applies only when all of its condition fields (e.g. min_prompt_tokens, or the utc_start/utc_end time window) match the request; among applicable entries, later entries win per price key; price keys absent from an entry inherit the base price.
    /// </summary>
    public sealed partial class PricingOverride
    {
        /// <summary>
        /// Overridden price in USD per audio input token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Overridden price in USD per token for completion (output) generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public string? Completion { get; set; }

        /// <summary>
        /// Overridden price in USD per cached audio input token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cache")]
        public string? InputAudioCache { get; set; }

        /// <summary>
        /// Overridden price in USD per cached input token (read)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public string? InputCacheRead { get; set; }

        /// <summary>
        /// Overridden price in USD per cache-write token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public string? InputCacheWrite { get; set; }

        /// <summary>
        /// Overridden price in USD per 1-hour cache-write token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write_1h")]
        public string? InputCacheWrite1h { get; set; }

        /// <summary>
        /// Condition: the entry applies when the total prompt tokens of a request are strictly greater than this threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_prompt_tokens")]
        public double? MinPromptTokens { get; set; }

        /// <summary>
        /// Overridden price in USD per token for prompt (input) processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Condition: exclusive end of a daily UTC time window as an HHMM clock number (e.g. 400 = 04:00)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utc_end")]
        public double? UtcEnd { get; set; }

        /// <summary>
        /// Condition: inclusive start of a daily UTC time window as an HHMM clock number (e.g. 100 = 01:00, 1030 = 10:30). The entry applies while the current UTC time is inside the half-open window [utc_start, utc_end), which may wrap past midnight (utc_start &gt; utc_end).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utc_start")]
        public double? UtcStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOverride" /> class.
        /// </summary>
        /// <param name="audio">
        /// Overridden price in USD per audio input token
        /// </param>
        /// <param name="completion">
        /// Overridden price in USD per token for completion (output) generation
        /// </param>
        /// <param name="inputAudioCache">
        /// Overridden price in USD per cached audio input token
        /// </param>
        /// <param name="inputCacheRead">
        /// Overridden price in USD per cached input token (read)
        /// </param>
        /// <param name="inputCacheWrite">
        /// Overridden price in USD per cache-write token
        /// </param>
        /// <param name="inputCacheWrite1h">
        /// Overridden price in USD per 1-hour cache-write token
        /// </param>
        /// <param name="minPromptTokens">
        /// Condition: the entry applies when the total prompt tokens of a request are strictly greater than this threshold
        /// </param>
        /// <param name="prompt">
        /// Overridden price in USD per token for prompt (input) processing
        /// </param>
        /// <param name="utcEnd">
        /// Condition: exclusive end of a daily UTC time window as an HHMM clock number (e.g. 400 = 04:00)
        /// </param>
        /// <param name="utcStart">
        /// Condition: inclusive start of a daily UTC time window as an HHMM clock number (e.g. 100 = 01:00, 1030 = 10:30). The entry applies while the current UTC time is inside the half-open window [utc_start, utc_end), which may wrap past midnight (utc_start &gt; utc_end).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingOverride(
            string? audio,
            string? completion,
            string? inputAudioCache,
            string? inputCacheRead,
            string? inputCacheWrite,
            string? inputCacheWrite1h,
            double? minPromptTokens,
            string? prompt,
            double? utcEnd,
            double? utcStart)
        {
            this.Audio = audio;
            this.Completion = completion;
            this.InputAudioCache = inputAudioCache;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.InputCacheWrite1h = inputCacheWrite1h;
            this.MinPromptTokens = minPromptTokens;
            this.Prompt = prompt;
            this.UtcEnd = utcEnd;
            this.UtcStart = utcStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingOverride" /> class.
        /// </summary>
        public PricingOverride()
        {
        }

    }
}