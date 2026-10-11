
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which budget layer this is, in the order enforcement checks them: the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).<br/>
    /// Example: member
    /// </summary>
    public readonly partial struct KeyBudgetScope : global::System.IEquatable<KeyBudgetScope>
    {
        /// <summary>
        ///
        /// </summary>
        public KeyBudgetScope(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).
        /// </summary>
        public static KeyBudgetScope ApiKey { get; } = new("api_key");

        /// <summary>
        /// the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).
        /// </summary>
        public static KeyBudgetScope KeyLimit { get; } = new("key_limit");

        /// <summary>
        /// the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).
        /// </summary>
        public static KeyBudgetScope Member { get; } = new("member");

        /// <summary>
        /// the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).
        /// </summary>
        public static KeyBudgetScope Workspace { get; } = new("workspace");

        /// <summary>
        /// the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).
        /// </summary>
        public static KeyBudgetScope WorkspaceDefaultKey { get; } = new("workspace_default_key");

        /// <summary>
        /// the workspace default guardrail against the member aggregate (`workspace_default_member`) and against this key (`workspace_default_key`), the member guardrail (`member`), the API key guardrail (`api_key`), a workspace budget (`workspace`), or the key's own limit (`key_limit`).
        /// </summary>
        public static KeyBudgetScope WorkspaceDefaultMember { get; } = new("workspace_default_member");
        /// <summary>
        ///
        /// </summary>
        public static KeyBudgetScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "api_key" => ApiKey,
                "key_limit" => KeyLimit,
                "member" => Member,
                "workspace" => Workspace,
                "workspace_default_key" => WorkspaceDefaultKey,
                "workspace_default_member" => WorkspaceDefaultMember,
                _ => new KeyBudgetScope(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "api_key" => true,
            "key_limit" => true,
            "member" => true,
            "workspace" => true,
            "workspace_default_key" => true,
            "workspace_default_member" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(KeyBudgetScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KeyBudgetScope other && Equals(other);
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
        public static bool operator ==(KeyBudgetScope left, KeyBudgetScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(KeyBudgetScope left, KeyBudgetScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyBudgetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyBudgetScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyBudgetScope? ToEnum(string value)
        {
            return KeyBudgetScope.FromValue(value);
        }
    }
}