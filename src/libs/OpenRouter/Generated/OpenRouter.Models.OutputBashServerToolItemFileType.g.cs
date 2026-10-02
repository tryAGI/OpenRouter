
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputBashServerToolItemFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputBashServerToolItemFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputBashServerToolItemFileType value)
        {
            return value switch
            {
                OutputBashServerToolItemFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputBashServerToolItemFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => OutputBashServerToolItemFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}