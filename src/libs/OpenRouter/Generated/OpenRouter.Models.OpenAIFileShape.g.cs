
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIFileShape
    {
        /// <summary>
        ///
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileShape value)
        {
            return value switch
            {
                OpenAIFileShape.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileShape? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIFileShape.Openai,
                _ => null,
            };
        }
    }
}