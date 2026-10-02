
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemDoneEventType value)
        {
            return value switch
            {
                OutputItemDoneEventType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => OutputItemDoneEventType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}