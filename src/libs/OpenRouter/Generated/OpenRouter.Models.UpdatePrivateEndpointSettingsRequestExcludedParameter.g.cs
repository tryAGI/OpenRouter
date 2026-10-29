
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UpdatePrivateEndpointSettingsRequestExcludedParameter : global::System.IEquatable<UpdatePrivateEndpointSettingsRequestExcludedParameter>
    {
        /// <summary>
        ///
        /// </summary>
        public UpdatePrivateEndpointSettingsRequestExcludedParameter(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter FrequencyPenalty { get; } = new("frequency_penalty");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter IncludeReasoning { get; } = new("include_reasoning");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter LogitBias { get; } = new("logit_bias");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Logprobs { get; } = new("logprobs");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter MaxCompletionTokens { get; } = new("max_completion_tokens");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter MaxTokens { get; } = new("max_tokens");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter MinP { get; } = new("min_p");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter ParallelToolCalls { get; } = new("parallel_tool_calls");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Prediction { get; } = new("prediction");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter PresencePenalty { get; } = new("presence_penalty");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Reasoning { get; } = new("reasoning");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter ReasoningEffort { get; } = new("reasoning_effort");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter RepetitionPenalty { get; } = new("repetition_penalty");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter ResponseFormat { get; } = new("response_format");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Seed { get; } = new("seed");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Stop { get; } = new("stop");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter StructuredOutputs { get; } = new("structured_outputs");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Temperature { get; } = new("temperature");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter ToolChoice { get; } = new("tool_choice");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Tools { get; } = new("tools");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter TopA { get; } = new("top_a");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter TopK { get; } = new("top_k");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter TopLogprobs { get; } = new("top_logprobs");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter TopP { get; } = new("top_p");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter Verbosity { get; } = new("verbosity");

        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter WebSearchOptions { get; } = new("web_search_options");
        /// <summary>
        ///
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "frequency_penalty" => FrequencyPenalty,
                "include_reasoning" => IncludeReasoning,
                "logit_bias" => LogitBias,
                "logprobs" => Logprobs,
                "max_completion_tokens" => MaxCompletionTokens,
                "max_tokens" => MaxTokens,
                "min_p" => MinP,
                "parallel_tool_calls" => ParallelToolCalls,
                "prediction" => Prediction,
                "presence_penalty" => PresencePenalty,
                "reasoning" => Reasoning,
                "reasoning_effort" => ReasoningEffort,
                "repetition_penalty" => RepetitionPenalty,
                "response_format" => ResponseFormat,
                "seed" => Seed,
                "stop" => Stop,
                "structured_outputs" => StructuredOutputs,
                "temperature" => Temperature,
                "tool_choice" => ToolChoice,
                "tools" => Tools,
                "top_a" => TopA,
                "top_k" => TopK,
                "top_logprobs" => TopLogprobs,
                "top_p" => TopP,
                "verbosity" => Verbosity,
                "web_search_options" => WebSearchOptions,
                _ => new UpdatePrivateEndpointSettingsRequestExcludedParameter(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "frequency_penalty" => true,
            "include_reasoning" => true,
            "logit_bias" => true,
            "logprobs" => true,
            "max_completion_tokens" => true,
            "max_tokens" => true,
            "min_p" => true,
            "parallel_tool_calls" => true,
            "prediction" => true,
            "presence_penalty" => true,
            "reasoning" => true,
            "reasoning_effort" => true,
            "repetition_penalty" => true,
            "response_format" => true,
            "seed" => true,
            "stop" => true,
            "structured_outputs" => true,
            "temperature" => true,
            "tool_choice" => true,
            "tools" => true,
            "top_a" => true,
            "top_k" => true,
            "top_logprobs" => true,
            "top_p" => true,
            "verbosity" => true,
            "web_search_options" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UpdatePrivateEndpointSettingsRequestExcludedParameter other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdatePrivateEndpointSettingsRequestExcludedParameter other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdatePrivateEndpointSettingsRequestExcludedParameter left, UpdatePrivateEndpointSettingsRequestExcludedParameter right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdatePrivateEndpointSettingsRequestExcludedParameter left, UpdatePrivateEndpointSettingsRequestExcludedParameter right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePrivateEndpointSettingsRequestExcludedParameterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePrivateEndpointSettingsRequestExcludedParameter value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePrivateEndpointSettingsRequestExcludedParameter? ToEnum(string value)
        {
            return UpdatePrivateEndpointSettingsRequestExcludedParameter.FromValue(value);
        }
    }
}