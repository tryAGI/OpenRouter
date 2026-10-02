
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemAddedEventType value)
        {
            return value switch
            {
                OutputItemAddedEventType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => OutputItemAddedEventType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}