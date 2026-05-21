
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: weave
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant16Type
    {
        /// <summary>
        /// weave
        /// </summary>
        Weave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant16TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant16Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant16Type.Weave => "weave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant16Type? ToEnum(string value)
        {
            return value switch
            {
                "weave" => GetObservabilityDestinationResponseDataVariant16Type.Weave,
                _ => null,
            };
        }
    }
}