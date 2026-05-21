
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: arize
    /// </summary>
    public enum ObservabilityDestinationVariant1Type
    {
        /// <summary>
        /// arize
        /// </summary>
        Arize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant1Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant1Type.Arize => "arize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "arize" => ObservabilityDestinationVariant1Type.Arize,
                _ => null,
            };
        }
    }
}