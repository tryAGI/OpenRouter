
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallAnalysisCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallAnalysisCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallAnalysisCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallAnalysisCompletedEventType value)
        {
            return value switch
            {
                FusionCallAnalysisCompletedEventType.ResponseFusionCallAnalysisCompleted => "response.fusion_call.analysis.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallAnalysisCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.analysis.completed" => FusionCallAnalysisCompletedEventType.ResponseFusionCallAnalysisCompleted,
                _ => null,
            };
        }
    }
}