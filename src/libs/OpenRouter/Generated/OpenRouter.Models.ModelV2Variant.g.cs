
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Variant of the model this record serves, the suffix of `id` (`openai/gpt-4:free` is `free`). Every record other than `free` is paid, so `variant.not=free` lists paid models and `variant=batch` the batch variants<br/>
    /// Example: standard
    /// </summary>
    public readonly partial struct ModelV2Variant : global::System.IEquatable<ModelV2Variant>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelV2Variant(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// free` is `free`). Every record other than `free` is paid, so `variant.not=free` lists paid models and `variant=batch` the batch variants
        /// </summary>
        public static ModelV2Variant Batch { get; } = new("batch");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Variant Extended { get; } = new("extended");

        /// <summary>
        /// free` is `free`). Every record other than `free` is paid, so `variant.not=free` lists paid models and `variant=batch` the batch variants
        /// </summary>
        public static ModelV2Variant Free { get; } = new("free");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Variant Standard { get; } = new("standard");

        /// <summary>
        ///
        /// </summary>
        public static ModelV2Variant Thinking { get; } = new("thinking");
        /// <summary>
        ///
        /// </summary>
        public static ModelV2Variant FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "batch" => Batch,
                "extended" => Extended,
                "free" => Free,
                "standard" => Standard,
                "thinking" => Thinking,
                _ => new ModelV2Variant(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "batch" => true,
            "extended" => true,
            "free" => true,
            "standard" => true,
            "thinking" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelV2Variant other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelV2Variant other && Equals(other);
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
        public static bool operator ==(ModelV2Variant left, ModelV2Variant right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelV2Variant left, ModelV2Variant right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelV2VariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelV2Variant value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelV2Variant? ToEnum(string value)
        {
            return ModelV2Variant.FromValue(value);
        }
    }
}