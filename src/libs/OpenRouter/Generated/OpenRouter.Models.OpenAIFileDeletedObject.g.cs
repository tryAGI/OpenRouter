
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIFileDeletedObject
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileDeletedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileDeletedObject value)
        {
            return value switch
            {
                OpenAIFileDeletedObject.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileDeletedObject? ToEnum(string value)
        {
            return value switch
            {
                "file" => OpenAIFileDeletedObject.File,
                _ => null,
            };
        }
    }
}