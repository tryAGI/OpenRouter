
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How a universal `tool_search` query reaches the client's own tool search. Absent or `keywords`: a `select:` query becomes the words of the selected names and the limit is always filled. `native`: a `select:` query passes through verbatim when the client search documents `select:`, and the limit field is sent only when the model gave one, unless the client search requires it, in which case its documented default is sent. Experimental.
    /// </summary>
    public readonly partial struct DeferredToolsControlCascadeMode : global::System.IEquatable<DeferredToolsControlCascadeMode>
    {
        /// <summary>
        ///
        /// </summary>
        public DeferredToolsControlCascadeMode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// a `select:` query becomes the words of the selected names and the limit is always filled. `native`: a `select:` query passes through verbatim when the client search documents `select:`, and the limit field is sent only when the model gave one, unless the client search requires it, in which case its documented default is sent. Experimental.
        /// </summary>
        public static DeferredToolsControlCascadeMode Keywords { get; } = new("keywords");

        /// <summary>
        /// a `select:` query becomes the words of the selected names and the limit is always filled. `native`: a `select:` query passes through verbatim when the client search documents `select:`, and the limit field is sent only when the model gave one, unless the client search requires it, in which case its documented default is sent. Experimental.
        /// </summary>
        public static DeferredToolsControlCascadeMode Native { get; } = new("native");
        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsControlCascadeMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "keywords" => Keywords,
                "native" => Native,
                _ => new DeferredToolsControlCascadeMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "keywords" => true,
            "native" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DeferredToolsControlCascadeMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeferredToolsControlCascadeMode other && Equals(other);
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
        public static bool operator ==(DeferredToolsControlCascadeMode left, DeferredToolsControlCascadeMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeferredToolsControlCascadeMode left, DeferredToolsControlCascadeMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlCascadeModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlCascadeMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlCascadeMode? ToEnum(string value)
        {
            return DeferredToolsControlCascadeMode.FromValue(value);
        }
    }
}