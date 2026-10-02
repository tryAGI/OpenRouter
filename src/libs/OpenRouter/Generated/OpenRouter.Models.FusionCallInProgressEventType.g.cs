
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallInProgressEventType value)
        {
            return value switch
            {
                FusionCallInProgressEventType.ResponseFusionCallInProgress => "response.fusion_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.in_progress" => FusionCallInProgressEventType.ResponseFusionCallInProgress,
                _ => null,
            };
        }
    }
}