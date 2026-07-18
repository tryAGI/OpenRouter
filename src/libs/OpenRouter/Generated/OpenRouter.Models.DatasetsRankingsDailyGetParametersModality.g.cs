
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Restrict to models for a modality surface: `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
    /// </summary>
    public enum DatasetsRankingsDailyGetParametersModality
    {
        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        Audio,
        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        Image,
        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        ImageOutput,
        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        Text,
        /// <summary>
        /// `text` / `image_output` match output modality, `image` / `audio` match input modality, and `tool_calling` keeps only rows that recorded at least one tool call. Exact dataset — cannot be combined with `category` or `language_type`.
        /// </summary>
        ToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsRankingsDailyGetParametersModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsRankingsDailyGetParametersModality value)
        {
            return value switch
            {
                DatasetsRankingsDailyGetParametersModality.Audio => "audio",
                DatasetsRankingsDailyGetParametersModality.Image => "image",
                DatasetsRankingsDailyGetParametersModality.ImageOutput => "image_output",
                DatasetsRankingsDailyGetParametersModality.Text => "text",
                DatasetsRankingsDailyGetParametersModality.ToolCalling => "tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsRankingsDailyGetParametersModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => DatasetsRankingsDailyGetParametersModality.Audio,
                "image" => DatasetsRankingsDailyGetParametersModality.Image,
                "image_output" => DatasetsRankingsDailyGetParametersModality.ImageOutput,
                "text" => DatasetsRankingsDailyGetParametersModality.Text,
                "tool_calling" => DatasetsRankingsDailyGetParametersModality.ToolCalling,
                _ => null,
            };
        }
    }
}