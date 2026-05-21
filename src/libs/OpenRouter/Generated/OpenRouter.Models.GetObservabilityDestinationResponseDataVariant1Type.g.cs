
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: arize
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant1Type
    {
        /// <summary>
        /// arize
        /// </summary>
        Arize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant1Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant1Type.Arize => "arize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "arize" => GetObservabilityDestinationResponseDataVariant1Type.Arize,
                _ => null,
            };
        }
    }
}