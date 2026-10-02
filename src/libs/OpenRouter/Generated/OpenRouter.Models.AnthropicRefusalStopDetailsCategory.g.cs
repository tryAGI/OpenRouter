
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicRefusalStopDetailsCategory : global::System.IEquatable<AnthropicRefusalStopDetailsCategory>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicRefusalStopDetailsCategory(string value)
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
        public static AnthropicRefusalStopDetailsCategory Bio { get; } = new("bio");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory Cyber { get; } = new("cyber");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory FrontierLlm { get; } = new("frontier_llm");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory GeneralHarms { get; } = new("general_harms");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory ReasoningExtraction { get; } = new("reasoning_extraction");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "bio" => Bio,
                "cyber" => Cyber,
                "frontier_llm" => FrontierLlm,
                "general_harms" => GeneralHarms,
                "reasoning_extraction" => ReasoningExtraction,
                _ => new AnthropicRefusalStopDetailsCategory(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "bio" => true,
            "cyber" => true,
            "frontier_llm" => true,
            "general_harms" => true,
            "reasoning_extraction" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicRefusalStopDetailsCategory other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicRefusalStopDetailsCategory other && Equals(other);
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
        public static bool operator ==(AnthropicRefusalStopDetailsCategory left, AnthropicRefusalStopDetailsCategory right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicRefusalStopDetailsCategory left, AnthropicRefusalStopDetailsCategory right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicRefusalStopDetailsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicRefusalStopDetailsCategory value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicRefusalStopDetailsCategory? ToEnum(string value)
        {
            return AnthropicRefusalStopDetailsCategory.FromValue(value);
        }
    }
}