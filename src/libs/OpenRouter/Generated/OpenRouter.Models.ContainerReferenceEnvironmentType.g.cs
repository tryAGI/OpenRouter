
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ContainerReferenceEnvironmentType
    {
        /// <summary>
        ///
        /// </summary>
        ContainerReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerReferenceEnvironmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerReferenceEnvironmentType value)
        {
            return value switch
            {
                ContainerReferenceEnvironmentType.ContainerReference => "container_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerReferenceEnvironmentType? ToEnum(string value)
        {
            return value switch
            {
                "container_reference" => ContainerReferenceEnvironmentType.ContainerReference,
                _ => null,
            };
        }
    }
}