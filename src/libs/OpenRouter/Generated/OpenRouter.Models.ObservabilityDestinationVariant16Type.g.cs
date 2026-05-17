
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: weave
    /// </summary>
    public enum ObservabilityDestinationVariant16Type
    {
        /// <summary>
        /// weave
        /// </summary>
        Weave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant16Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant16Type.Weave => "weave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant16Type? ToEnum(string value)
        {
            return value switch
            {
                "weave" => ObservabilityDestinationVariant16Type.Weave,
                _ => null,
            };
        }
    }
}