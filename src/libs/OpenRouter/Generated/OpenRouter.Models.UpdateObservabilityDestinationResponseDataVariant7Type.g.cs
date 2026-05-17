
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: langsmith
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant7Type
    {
        /// <summary>
        /// langsmith
        /// </summary>
        Langsmith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant7Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant7Type.Langsmith => "langsmith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "langsmith" => UpdateObservabilityDestinationResponseDataVariant7Type.Langsmith,
                _ => null,
            };
        }
    }
}