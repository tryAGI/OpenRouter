
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeInterpreterLogsOutputType
    {
        /// <summary>
        ///
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterLogsOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterLogsOutputType value)
        {
            return value switch
            {
                CodeInterpreterLogsOutputType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterLogsOutputType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => CodeInterpreterLogsOutputType.Logs,
                _ => null,
            };
        }
    }
}