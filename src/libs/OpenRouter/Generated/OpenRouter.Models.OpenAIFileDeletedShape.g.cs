
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIFileDeletedShape
    {
        /// <summary>
        ///
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileDeletedShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileDeletedShape value)
        {
            return value switch
            {
                OpenAIFileDeletedShape.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileDeletedShape? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIFileDeletedShape.Openai,
                _ => null,
            };
        }
    }
}