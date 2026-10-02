
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallPanelDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallPanelDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallPanelDeltaEventType value)
        {
            return value switch
            {
                FusionCallPanelDeltaEventType.ResponseFusionCallPanelDelta => "response.fusion_call.panel.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallPanelDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.panel.delta" => FusionCallPanelDeltaEventType.ResponseFusionCallPanelDelta,
                _ => null,
            };
        }
    }
}