
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedEventType value)
        {
            return value switch
            {
                CreatedEventType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => CreatedEventType.ResponseCreated,
                _ => null,
            };
        }
    }
}