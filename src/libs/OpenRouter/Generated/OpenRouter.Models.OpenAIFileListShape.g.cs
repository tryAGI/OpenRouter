
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIFileListShape
    {
        /// <summary>
        ///
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileListShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileListShape value)
        {
            return value switch
            {
                OpenAIFileListShape.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileListShape? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIFileListShape.Openai,
                _ => null,
            };
        }
    }
}