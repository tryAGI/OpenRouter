
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemCodeInterpreterCallOutputDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Logs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemCodeInterpreterCallOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemCodeInterpreterCallOutputDiscriminatorType value)
        {
            return value switch
            {
                OutputItemCodeInterpreterCallOutputDiscriminatorType.File => "file",
                OutputItemCodeInterpreterCallOutputDiscriminatorType.Image => "image",
                OutputItemCodeInterpreterCallOutputDiscriminatorType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemCodeInterpreterCallOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => OutputItemCodeInterpreterCallOutputDiscriminatorType.File,
                "image" => OutputItemCodeInterpreterCallOutputDiscriminatorType.Image,
                "logs" => OutputItemCodeInterpreterCallOutputDiscriminatorType.Logs,
                _ => null,
            };
        }
    }
}