
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How a blocked call reaches the caller. `text` (the default): the call is withheld and an `&lt;openrouter_armor_blocked&gt;` marker stands in assistant text. `custom_item` (Responses API only): the call is withheld and an `openrouter:armor_blocked` output item carries its id, name, arguments and the rule that fired. `claude_code_compatibility` (Messages API only; the default when the request carries a `dangerous_tool_use` safeguard, i.e. the client speaks Claude Code's protocol): the `tool_use` stays in `content[]` and the verdict is `flagged` in `safeguard_results`, so the client withholds execution and writes the error tool result as under the native classifier. Under `text` and `custom_item` the model received a failure result in the loop and continued in the same request; under `claude_code_compatibility` the turn ends on the flagged call and the model continues on the next request, after the client's denial.
    /// </summary>
    public readonly partial struct ArmorPluginOutputMode : global::System.IEquatable<ArmorPluginOutputMode>
    {
        /// <summary>
        ///
        /// </summary>
        public ArmorPluginOutputMode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// the call is withheld and an `&lt;openrouter_armor_blocked&gt;` marker stands in assistant text. `custom_item` (Responses API only): the call is withheld and an `openrouter:armor_blocked` output item carries its id, name, arguments and the rule that fired. `claude_code_compatibility` (Messages API only; the default when the request carries a `dangerous_tool_use` safeguard, i.e. the client speaks Claude Code's protocol): the `tool_use` stays in `content[]` and the verdict is `flagged` in `safeguard_results`, so the client withholds execution and writes the error tool result as under the native classifier. Under `text` and `custom_item` the model received a failure result in the loop and continued in the same request; under `claude_code_compatibility` the turn ends on the flagged call and the model continues on the next request, after the client's denial.
        /// </summary>
        public static ArmorPluginOutputMode ClaudeCodeCompatibility { get; } = new("claude_code_compatibility");

        /// <summary>
        /// the call is withheld and an `&lt;openrouter_armor_blocked&gt;` marker stands in assistant text. `custom_item` (Responses API only): the call is withheld and an `openrouter:armor_blocked` output item carries its id, name, arguments and the rule that fired. `claude_code_compatibility` (Messages API only; the default when the request carries a `dangerous_tool_use` safeguard, i.e. the client speaks Claude Code's protocol): the `tool_use` stays in `content[]` and the verdict is `flagged` in `safeguard_results`, so the client withholds execution and writes the error tool result as under the native classifier. Under `text` and `custom_item` the model received a failure result in the loop and continued in the same request; under `claude_code_compatibility` the turn ends on the flagged call and the model continues on the next request, after the client's denial.
        /// </summary>
        public static ArmorPluginOutputMode CustomItem { get; } = new("custom_item");

        /// <summary>
        /// the call is withheld and an `&lt;openrouter_armor_blocked&gt;` marker stands in assistant text. `custom_item` (Responses API only): the call is withheld and an `openrouter:armor_blocked` output item carries its id, name, arguments and the rule that fired. `claude_code_compatibility` (Messages API only; the default when the request carries a `dangerous_tool_use` safeguard, i.e. the client speaks Claude Code's protocol): the `tool_use` stays in `content[]` and the verdict is `flagged` in `safeguard_results`, so the client withholds execution and writes the error tool result as under the native classifier. Under `text` and `custom_item` the model received a failure result in the loop and continued in the same request; under `claude_code_compatibility` the turn ends on the flagged call and the model continues on the next request, after the client's denial.
        /// </summary>
        public static ArmorPluginOutputMode Text { get; } = new("text");
        /// <summary>
        ///
        /// </summary>
        public static ArmorPluginOutputMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "claude_code_compatibility" => ClaudeCodeCompatibility,
                "custom_item" => CustomItem,
                "text" => Text,
                _ => new ArmorPluginOutputMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "claude_code_compatibility" => true,
            "custom_item" => true,
            "text" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ArmorPluginOutputMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArmorPluginOutputMode other && Equals(other);
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
        public static bool operator ==(ArmorPluginOutputMode left, ArmorPluginOutputMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ArmorPluginOutputMode left, ArmorPluginOutputMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorPluginOutputModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorPluginOutputMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorPluginOutputMode? ToEnum(string value)
        {
            return ArmorPluginOutputMode.FromValue(value);
        }
    }
}