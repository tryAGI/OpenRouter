
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ShellCallOutputItemFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallOutputItemFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallOutputItemFileType value)
        {
            return value switch
            {
                ShellCallOutputItemFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallOutputItemFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => ShellCallOutputItemFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}