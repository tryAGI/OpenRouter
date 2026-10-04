
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
    /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
    /// - deny: use only providers which do not collect user data.<br/>
    /// Example: allow
    /// </summary>
    public readonly partial struct STTRequestProviderDataCollection : global::System.IEquatable<STTRequestProviderDataCollection>
    {
        /// <summary>
        ///
        /// </summary>
        public STTRequestProviderDataCollection(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// (default) allow providers which store user data non-transiently and may train on it
        /// </summary>
        public static STTRequestProviderDataCollection Allow { get; } = new("allow");

        /// <summary>
        /// use only providers which do not collect user data.
        /// </summary>
        public static STTRequestProviderDataCollection Deny { get; } = new("deny");
        /// <summary>
        ///
        /// </summary>
        public static STTRequestProviderDataCollection FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "allow" => Allow,
                "deny" => Deny,
                _ => new STTRequestProviderDataCollection(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "allow" => true,
            "deny" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(STTRequestProviderDataCollection other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTRequestProviderDataCollection other && Equals(other);
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
        public static bool operator ==(STTRequestProviderDataCollection left, STTRequestProviderDataCollection right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(STTRequestProviderDataCollection left, STTRequestProviderDataCollection right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTRequestProviderDataCollectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTRequestProviderDataCollection value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTRequestProviderDataCollection? ToEnum(string value)
        {
            return STTRequestProviderDataCollection.FromValue(value);
        }
    }
}