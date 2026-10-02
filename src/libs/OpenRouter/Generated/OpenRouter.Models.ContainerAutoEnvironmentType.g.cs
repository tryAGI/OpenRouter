
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ContainerAutoEnvironmentType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerAuto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerAutoEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerAutoEnvironmentType value)
        {
            return value switch
            {
                ContainerAutoEnvironmentType.ContainerAuto => "container_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerAutoEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => ContainerAutoEnvironmentType.ContainerAuto,
                _ => null,
            };
        }
    }
}