
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesRefusalContentType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesRefusalContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesRefusalContentType value)
        {
            return value switch
            {
                OpenAIResponsesRefusalContentType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesRefusalContentType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => OpenAIResponsesRefusalContentType.Refusal,
                _ => null,
            };
        }
    }
}