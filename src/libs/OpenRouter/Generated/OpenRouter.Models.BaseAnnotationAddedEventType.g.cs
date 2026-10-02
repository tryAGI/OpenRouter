
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseAnnotationAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextAnnotationAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseAnnotationAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseAnnotationAddedEventType value)
        {
            return value switch
            {
                BaseAnnotationAddedEventType.ResponseOutputTextAnnotationAdded => "response.output_text.annotation.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseAnnotationAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.annotation.added" => BaseAnnotationAddedEventType.ResponseOutputTextAnnotationAdded,
                _ => null,
            };
        }
    }
}