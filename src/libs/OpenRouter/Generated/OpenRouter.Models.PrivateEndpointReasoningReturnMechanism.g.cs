
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Where the upstream puts reasoning tokens in its response: `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.<br/>
    /// Example: reasoning
    /// </summary>
    public readonly partial struct PrivateEndpointReasoningReturnMechanism : global::System.IEquatable<PrivateEndpointReasoningReturnMechanism>
    {
        /// <summary>
        ///
        /// </summary>
        public PrivateEndpointReasoningReturnMechanism(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.
        /// </summary>
        public static PrivateEndpointReasoningReturnMechanism ContentString { get; } = new("content-string");

        /// <summary>
        /// `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.
        /// </summary>
        public static PrivateEndpointReasoningReturnMechanism None { get; } = new("none");

        /// <summary>
        /// `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.
        /// </summary>
        public static PrivateEndpointReasoningReturnMechanism Reasoning { get; } = new("reasoning");

        /// <summary>
        /// `reasoning` and `reasoning-content` are response fields, `content-string` is inline in the message, `none` returns no reasoning. `null` uses the provider default.
        /// </summary>
        public static PrivateEndpointReasoningReturnMechanism ReasoningContent { get; } = new("reasoning-content");
        /// <summary>
        ///
        /// </summary>
        public static PrivateEndpointReasoningReturnMechanism FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "content-string" => ContentString,
                "none" => None,
                "reasoning" => Reasoning,
                "reasoning-content" => ReasoningContent,
                _ => new PrivateEndpointReasoningReturnMechanism(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "content-string" => true,
            "none" => true,
            "reasoning" => true,
            "reasoning-content" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PrivateEndpointReasoningReturnMechanism other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrivateEndpointReasoningReturnMechanism other && Equals(other);
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
        public static bool operator ==(PrivateEndpointReasoningReturnMechanism left, PrivateEndpointReasoningReturnMechanism right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PrivateEndpointReasoningReturnMechanism left, PrivateEndpointReasoningReturnMechanism right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateEndpointReasoningReturnMechanismExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateEndpointReasoningReturnMechanism value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateEndpointReasoningReturnMechanism? ToEnum(string value)
        {
            return PrivateEndpointReasoningReturnMechanism.FromValue(value);
        }
    }
}