
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputShellServerToolItemFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputShellServerToolItemFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputShellServerToolItemFileType value)
        {
            return value switch
            {
                OutputShellServerToolItemFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputShellServerToolItemFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => OutputShellServerToolItemFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}