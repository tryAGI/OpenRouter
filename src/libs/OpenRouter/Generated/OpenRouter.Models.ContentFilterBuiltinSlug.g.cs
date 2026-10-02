
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The builtin filter identifier<br/>
    /// Example: regex-prompt-injection
    /// </summary>
    public readonly partial struct ContentFilterBuiltinSlug : global::System.IEquatable<ContentFilterBuiltinSlug>
    {
        /// <summary>
        ///
        /// </summary>
        public ContentFilterBuiltinSlug(string value)
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
        public static ContentFilterBuiltinSlug Address { get; } = new("address");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug CreditCard { get; } = new("credit-card");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug Email { get; } = new("email");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug IpAddress { get; } = new("ip-address");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug PersonName { get; } = new("person-name");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug Phone { get; } = new("phone");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug RegexPromptInjection { get; } = new("regex-prompt-injection");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug Secrets { get; } = new("secrets");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug Ssn { get; } = new("ssn");
        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinSlug FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "address" => Address,
                "credit-card" => CreditCard,
                "email" => Email,
                "ip-address" => IpAddress,
                "person-name" => PersonName,
                "phone" => Phone,
                "regex-prompt-injection" => RegexPromptInjection,
                "secrets" => Secrets,
                "ssn" => Ssn,
                _ => new ContentFilterBuiltinSlug(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "address" => true,
            "credit-card" => true,
            "email" => true,
            "ip-address" => true,
            "person-name" => true,
            "phone" => true,
            "regex-prompt-injection" => true,
            "secrets" => true,
            "ssn" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ContentFilterBuiltinSlug other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentFilterBuiltinSlug other && Equals(other);
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
        public static bool operator ==(ContentFilterBuiltinSlug left, ContentFilterBuiltinSlug right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentFilterBuiltinSlug left, ContentFilterBuiltinSlug right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterBuiltinSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterBuiltinSlug value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterBuiltinSlug? ToEnum(string value)
        {
            return ContentFilterBuiltinSlug.FromValue(value);
        }
    }
}