
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesShellToolResultBlockFileType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesShellToolResultBlockFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesShellToolResultBlockFileType value)
        {
            return value switch
            {
                MessagesShellToolResultBlockFileType.ContainerFileCitation => "container_file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesShellToolResultBlockFileType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => MessagesShellToolResultBlockFileType.ContainerFileCitation,
                _ => null,
            };
        }
    }
}