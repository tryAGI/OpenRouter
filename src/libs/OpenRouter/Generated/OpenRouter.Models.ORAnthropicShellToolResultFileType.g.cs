
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicShellToolResultFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicShellToolResultFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicShellToolResultFileType value)
        {
            return value switch
            {
                ORAnthropicShellToolResultFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicShellToolResultFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => ORAnthropicShellToolResultFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}