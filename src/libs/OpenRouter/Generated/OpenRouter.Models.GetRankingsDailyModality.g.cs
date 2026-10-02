
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Restrict to models for a modality surface: `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.<br/>
    /// Example: text
    /// </summary>
    public readonly partial struct GetRankingsDailyModality : global::System.IEquatable<GetRankingsDailyModality>
    {
        /// <summary>
        ///
        /// </summary>
        public GetRankingsDailyModality(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        public static GetRankingsDailyModality Audio { get; } = new("audio");

        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        public static GetRankingsDailyModality Image { get; } = new("image");

        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        public static GetRankingsDailyModality ImageOutput { get; } = new("image_output");

        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        public static GetRankingsDailyModality Text { get; } = new("text");

        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        public static GetRankingsDailyModality ToolCalling { get; } = new("tool_calling");
        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyModality FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "image" => Image,
                "image_output" => ImageOutput,
                "text" => Text,
                "tool_calling" => ToolCalling,
                _ => new GetRankingsDailyModality(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "image" => true,
            "image_output" => true,
            "text" => true,
            "tool_calling" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetRankingsDailyModality other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRankingsDailyModality other && Equals(other);
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
        public static bool operator ==(GetRankingsDailyModality left, GetRankingsDailyModality right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetRankingsDailyModality left, GetRankingsDailyModality right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRankingsDailyModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRankingsDailyModality value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRankingsDailyModality? ToEnum(string value)
        {
            return GetRankingsDailyModality.FromValue(value);
        }
    }
}