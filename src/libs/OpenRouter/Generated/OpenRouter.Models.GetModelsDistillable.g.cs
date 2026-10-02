
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.<br/>
    /// Example: true
    /// </summary>
    public readonly partial struct GetModelsDistillable : global::System.IEquatable<GetModelsDistillable>
    {
        /// <summary>
        ///
        /// </summary>
        public GetModelsDistillable(string value)
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
        public static GetModelsDistillable False { get; } = new("false");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsDistillable True { get; } = new("true");
        /// <summary>
        ///
        /// </summary>
        public static GetModelsDistillable FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "false" => False,
                "true" => True,
                _ => new GetModelsDistillable(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "false" => true,
            "true" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetModelsDistillable other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetModelsDistillable other && Equals(other);
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
        public static bool operator ==(GetModelsDistillable left, GetModelsDistillable right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetModelsDistillable left, GetModelsDistillable right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsDistillableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsDistillable value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsDistillable? ToEnum(string value)
        {
            return GetModelsDistillable.FromValue(value);
        }
    }
}