
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallCompletedEventType value)
        {
            return value switch
            {
                FusionCallCompletedEventType.ResponseFusionCallCompleted => "response.fusion_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.completed" => FusionCallCompletedEventType.ResponseFusionCallCompleted,
                _ => null,
            };
        }
    }
}