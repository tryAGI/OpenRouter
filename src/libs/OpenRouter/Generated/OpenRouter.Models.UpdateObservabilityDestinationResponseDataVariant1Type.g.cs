
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: arize
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant1Type
    {
        /// <summary>
        /// arize
        /// </summary>
        Arize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant1Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant1Type.Arize => "arize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "arize" => UpdateObservabilityDestinationResponseDataVariant1Type.Arize,
                _ => null,
            };
        }
    }
}