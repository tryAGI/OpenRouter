
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIFileStatus
    {
        /// <summary>
        ///
        /// </summary>
        Processed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileStatus value)
        {
            return value switch
            {
                OpenAIFileStatus.Processed => "processed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "processed" => OpenAIFileStatus.Processed,
                _ => null,
            };
        }
    }
}