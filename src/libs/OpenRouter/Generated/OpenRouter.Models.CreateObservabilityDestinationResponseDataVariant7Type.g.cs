
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: langsmith
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant7Type
    {
        /// <summary>
        /// langsmith
        /// </summary>
        Langsmith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant7Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant7Type.Langsmith => "langsmith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "langsmith" => CreateObservabilityDestinationResponseDataVariant7Type.Langsmith,
                _ => null,
            };
        }
    }
}