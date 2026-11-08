
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which tools the universal profile defers. Absent or `all`: every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. `client`: only the tools the client itself marked `defer_loading`, so a harness with its own tool search keeps its other direct tools direct; an adopted client tool search is still replaced by the router wrappers, and a client-deferred tool the router cannot wrap stays direct. Experimental.
    /// </summary>
    public readonly partial struct DeferredToolsControlScope : global::System.IEquatable<DeferredToolsControlScope>
    {
        /// <summary>
        ///
        /// </summary>
        public DeferredToolsControlScope(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. `client`: only the tools the client itself marked `defer_loading`, so a harness with its own tool search keeps its other direct tools direct; an adopted client tool search is still replaced by the router wrappers, and a client-deferred tool the router cannot wrap stays direct. Experimental.
        /// </summary>
        public static DeferredToolsControlScope All { get; } = new("all");

        /// <summary>
        /// every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. `client`: only the tools the client itself marked `defer_loading`, so a harness with its own tool search keeps its other direct tools direct; an adopted client tool search is still replaced by the router wrappers, and a client-deferred tool the router cannot wrap stays direct. Experimental.
        /// </summary>
        public static DeferredToolsControlScope Client { get; } = new("client");

        /// <summary>
        /// every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. `client`: only the tools the client itself marked `defer_loading`, so a harness with its own tool search keeps its other direct tools direct; an adopted client tool search is still replaced by the router wrappers, and a client-deferred tool the router cannot wrap stays direct. Experimental.
        /// </summary>
        public static DeferredToolsControlScope Mcp { get; } = new("mcp");
        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsControlScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "all" => All,
                "client" => Client,
                "mcp" => Mcp,
                _ => new DeferredToolsControlScope(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "all" => true,
            "client" => true,
            "mcp" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DeferredToolsControlScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeferredToolsControlScope other && Equals(other);
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
        public static bool operator ==(DeferredToolsControlScope left, DeferredToolsControlScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeferredToolsControlScope left, DeferredToolsControlScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlScope? ToEnum(string value)
        {
            return DeferredToolsControlScope.FromValue(value);
        }
    }
}