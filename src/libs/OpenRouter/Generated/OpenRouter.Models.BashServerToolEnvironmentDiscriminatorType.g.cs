
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum BashServerToolEnvironmentDiscriminatorType
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
    public static class BashServerToolEnvironmentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashServerToolEnvironmentDiscriminatorType value)
        {
            return value switch
            {
                BashServerToolEnvironmentDiscriminatorType.ContainerAuto => "container_auto",
                BashServerToolEnvironmentDiscriminatorType.ContainerReference => "container_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashServerToolEnvironmentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_auto" => BashServerToolEnvironmentDiscriminatorType.ContainerAuto,
                "container_reference" => BashServerToolEnvironmentDiscriminatorType.ContainerReference,
                _ => null,
            };
        }
    }
}