
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: container_auto
    /// </summary>
    public enum BashServerToolEnvironmentVariant1Type
    {
        /// <summary>
        /// container_auto
        /// </summary>
        ContainerAuto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashServerToolEnvironmentVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashServerToolEnvironmentVariant1Type value)
        {
            return value switch
            {
                BashServerToolEnvironmentVariant1Type.ContainerAuto => "container_auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashServerToolEnvironmentVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => BashServerToolEnvironmentVariant1Type.ContainerAuto,
                _ => null,
            };
        }
    }
}