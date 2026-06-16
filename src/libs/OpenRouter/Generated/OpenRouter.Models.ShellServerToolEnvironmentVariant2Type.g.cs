
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: container_reference
    /// </summary>
    public enum ShellServerToolEnvironmentVariant2Type
    {
        /// <summary>
        /// container_reference
        /// </summary>
        ContainerReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellServerToolEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellServerToolEnvironmentVariant2Type value)
        {
            return value switch
            {
                ShellServerToolEnvironmentVariant2Type.ContainerReference => "container_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellServerToolEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => ShellServerToolEnvironmentVariant2Type.ContainerReference,
                _ => null,
            };
        }
    }
}