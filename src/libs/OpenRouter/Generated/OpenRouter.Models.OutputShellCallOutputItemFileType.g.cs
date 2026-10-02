
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputShellCallOutputItemFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputShellCallOutputItemFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputShellCallOutputItemFileType value)
        {
            return value switch
            {
                OutputShellCallOutputItemFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputShellCallOutputItemFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => OutputShellCallOutputItemFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}