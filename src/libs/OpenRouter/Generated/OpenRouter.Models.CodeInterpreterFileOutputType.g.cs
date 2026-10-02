
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeInterpreterFileOutputType
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterFileOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterFileOutputType value)
        {
            return value switch
            {
                CodeInterpreterFileOutputType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterFileOutputType? ToEnum(string value)
        {
            return value switch
            {
                "file" => CodeInterpreterFileOutputType.File,
                _ => null,
            };
        }
    }
}