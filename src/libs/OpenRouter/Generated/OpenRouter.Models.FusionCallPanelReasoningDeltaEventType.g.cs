
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallPanelReasoningDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelReasoningDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallPanelReasoningDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallPanelReasoningDeltaEventType value)
        {
            return value switch
            {
                FusionCallPanelReasoningDeltaEventType.ResponseFusionCallPanelReasoningDelta => "response.fusion_call.panel.reasoning.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallPanelReasoningDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.panel.reasoning.delta" => FusionCallPanelReasoningDeltaEventType.ResponseFusionCallPanelReasoningDelta,
                _ => null,
            };
        }
    }
}