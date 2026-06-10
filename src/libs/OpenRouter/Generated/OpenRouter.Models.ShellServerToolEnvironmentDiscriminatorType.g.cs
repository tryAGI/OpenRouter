
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShellServerToolEnvironmentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerAuto,
        /// <summary>
        /// 
        /// </summary>
        ContainerReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellServerToolEnvironmentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellServerToolEnvironmentDiscriminatorType value)
        {
            return value switch
            {
                ShellServerToolEnvironmentDiscriminatorType.ContainerAuto => "container_auto",
                ShellServerToolEnvironmentDiscriminatorType.ContainerReference => "container_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellServerToolEnvironmentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => ShellServerToolEnvironmentDiscriminatorType.ContainerAuto,
                "container_reference" => ShellServerToolEnvironmentDiscriminatorType.ContainerReference,
                _ => null,
            };
        }
    }
}