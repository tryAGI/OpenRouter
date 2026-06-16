
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: container_auto
    /// </summary>
    public enum ShellServerToolEnvironmentVariant1Type
    {
        /// <summary>
        /// container_auto
        /// </summary>
        ContainerAuto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellServerToolEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellServerToolEnvironmentVariant1Type value)
        {
            return value switch
            {
                ShellServerToolEnvironmentVariant1Type.ContainerAuto => "container_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellServerToolEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => ShellServerToolEnvironmentVariant1Type.ContainerAuto,
                _ => null,
            };
        }
    }
}