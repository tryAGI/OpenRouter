
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallPanelFailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallPanelFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallPanelFailedEventType value)
        {
            return value switch
            {
                FusionCallPanelFailedEventType.ResponseFusionCallPanelFailed => "response.fusion_call.panel.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallPanelFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.panel.failed" => FusionCallPanelFailedEventType.ResponseFusionCallPanelFailed,
                _ => null,
            };
        }
    }
}