
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ObservabilityFilterRuleGroupRuleField : global::System.IEquatable<ObservabilityFilterRuleGroupRuleField>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityFilterRuleGroupRuleField(string value)
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
        public static ObservabilityFilterRuleGroupRuleField ApiKeyName { get; } = new("api_key_name");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField CompletionTokens { get; } = new("completion_tokens");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField FinishReason { get; } = new("finish_reason");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField Input { get; } = new("input");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField Model { get; } = new("model");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField Output { get; } = new("output");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField PromptTokens { get; } = new("prompt_tokens");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField Provider { get; } = new("provider");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField SessionId { get; } = new("session_id");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField TotalCost { get; } = new("total_cost");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField TotalTokens { get; } = new("total_tokens");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField UserId { get; } = new("user_id");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "api_key_name" => ApiKeyName,
                "completion_tokens" => CompletionTokens,
                "finish_reason" => FinishReason,
                "input" => Input,
                "model" => Model,
                "output" => Output,
                "prompt_tokens" => PromptTokens,
                "provider" => Provider,
                "session_id" => SessionId,
                "total_cost" => TotalCost,
                "total_tokens" => TotalTokens,
                "user_id" => UserId,
                _ => new ObservabilityFilterRuleGroupRuleField(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "api_key_name" => true,
            "completion_tokens" => true,
            "finish_reason" => true,
            "input" => true,
            "model" => true,
            "output" => true,
            "prompt_tokens" => true,
            "provider" => true,
            "session_id" => true,
            "total_cost" => true,
            "total_tokens" => true,
            "user_id" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityFilterRuleGroupRuleField other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityFilterRuleGroupRuleField other && Equals(other);
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
        public static bool operator ==(ObservabilityFilterRuleGroupRuleField left, ObservabilityFilterRuleGroupRuleField right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityFilterRuleGroupRuleField left, ObservabilityFilterRuleGroupRuleField right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityFilterRuleGroupRuleFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRuleGroupRuleField value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleField? ToEnum(string value)
        {
            return ObservabilityFilterRuleGroupRuleField.FromValue(value);
        }
    }
}