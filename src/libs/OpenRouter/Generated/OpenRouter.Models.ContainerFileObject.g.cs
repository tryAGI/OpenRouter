
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: container.file
    /// </summary>
    public enum ContainerFileObject
    {
        /// <summary>
        ///
        /// </summary>
        ContainerFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileObject value)
        {
            return value switch
            {
                ContainerFileObject.ContainerFile => "container.file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileObject? ToEnum(string value)
        {
            return value switch
            {
                "container.file" => ContainerFileObject.ContainerFile,
                _ => null,
            };
        }
    }
}