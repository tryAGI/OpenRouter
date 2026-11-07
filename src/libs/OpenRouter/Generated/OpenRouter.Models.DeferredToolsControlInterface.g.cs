
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How the universal profile exposes the hidden catalog to the provider. Absent or `wrappers`: the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
    /// </summary>
    public readonly partial struct DeferredToolsControlInterface : global::System.IEquatable<DeferredToolsControlInterface>
    {
        /// <summary>
        ///
        /// </summary>
        public DeferredToolsControlInterface(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
        /// </summary>
        public static DeferredToolsControlInterface CodeMode { get; } = new("code_mode");

        /// <summary>
        /// the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
        /// </summary>
        public static DeferredToolsControlInterface Wrappers { get; } = new("wrappers");
        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsControlInterface FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "code_mode" => CodeMode,
                "wrappers" => Wrappers,
                _ => new DeferredToolsControlInterface(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "code_mode" => true,
            "wrappers" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DeferredToolsControlInterface other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeferredToolsControlInterface other && Equals(other);
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
        public static bool operator ==(DeferredToolsControlInterface left, DeferredToolsControlInterface right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeferredToolsControlInterface left, DeferredToolsControlInterface right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlInterfaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlInterface value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlInterface? ToEnum(string value)
        {
            return DeferredToolsControlInterface.FromValue(value);
        }
    }
}