
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallAnalysisInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallAnalysisInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallAnalysisInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallAnalysisInProgressEventType value)
        {
            return value switch
            {
                FusionCallAnalysisInProgressEventType.ResponseFusionCallAnalysisInProgress => "response.fusion_call.analysis.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallAnalysisInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.analysis.in_progress" => FusionCallAnalysisInProgressEventType.ResponseFusionCallAnalysisInProgress,
                _ => null,
            };
        }
    }
}