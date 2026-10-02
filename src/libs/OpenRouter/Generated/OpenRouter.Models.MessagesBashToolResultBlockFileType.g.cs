
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesBashToolResultBlockFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesBashToolResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesBashToolResultBlockFileType value)
        {
            return value switch
            {
                MessagesBashToolResultBlockFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesBashToolResultBlockFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => MessagesBashToolResultBlockFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}