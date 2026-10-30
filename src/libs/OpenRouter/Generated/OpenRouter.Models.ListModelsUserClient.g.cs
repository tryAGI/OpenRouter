
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Return only the models and presets the named harness offers: those that support tool calling, and, when one of your guardrails sets `enforce_first_party_harness_models`, only the harness vendor's own models (OpenAI for codex, Anthropic for claude_code and claude_desktop). One of: claude_code, claude_desktop, codex. Omit it to get every model you can use.<br/>
    /// Example: codex
    /// </summary>
    public readonly partial struct ListModelsUserClient : global::System.IEquatable<ListModelsUserClient>
    {
        /// <summary>
        ///
        /// </summary>
        public ListModelsUserClient(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// those that support tool calling, and, when one of your guardrails sets `enforce_first_party_harness_models`, only the harness vendor's own models (OpenAI for codex, Anthropic for claude_code and claude_desktop). One of: claude_code, claude_desktop, codex. Omit it to get every model you can use.
        /// </summary>
        public static ListModelsUserClient ClaudeCode { get; } = new("claude_code");

        /// <summary>
        /// those that support tool calling, and, when one of your guardrails sets `enforce_first_party_harness_models`, only the harness vendor's own models (OpenAI for codex, Anthropic for claude_code and claude_desktop). One of: claude_code, claude_desktop, codex. Omit it to get every model you can use.
        /// </summary>
        public static ListModelsUserClient ClaudeDesktop { get; } = new("claude_desktop");

        /// <summary>
        /// those that support tool calling, and, when one of your guardrails sets `enforce_first_party_harness_models`, only the harness vendor's own models (OpenAI for codex, Anthropic for claude_code and claude_desktop). One of: claude_code, claude_desktop, codex. Omit it to get every model you can use.
        /// </summary>
        public static ListModelsUserClient Codex { get; } = new("codex");
        /// <summary>
        ///
        /// </summary>
        public static ListModelsUserClient FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "claude_code" => ClaudeCode,
                "claude_desktop" => ClaudeDesktop,
                "codex" => Codex,
                _ => new ListModelsUserClient(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "claude_code" => true,
            "claude_desktop" => true,
            "codex" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ListModelsUserClient other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListModelsUserClient other && Equals(other);
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
        public static bool operator ==(ListModelsUserClient left, ListModelsUserClient right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListModelsUserClient left, ListModelsUserClient right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListModelsUserClientExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListModelsUserClient value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListModelsUserClient? ToEnum(string value)
        {
            return ListModelsUserClient.FromValue(value);
        }
    }
}