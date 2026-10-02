
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: list
    /// </summary>
    public enum ContainerFileListResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileListResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileListResponseObject value)
        {
            return value switch
            {
                ContainerFileListResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileListResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ContainerFileListResponseObject.List,
                _ => null,
            };
        }
    }
}