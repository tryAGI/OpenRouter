
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicBashToolResultFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicBashToolResultFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicBashToolResultFileType value)
        {
            return value switch
            {
                ORAnthropicBashToolResultFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicBashToolResultFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => ORAnthropicBashToolResultFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}