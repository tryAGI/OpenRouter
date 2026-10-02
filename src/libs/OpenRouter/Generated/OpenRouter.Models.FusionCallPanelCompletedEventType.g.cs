
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallPanelCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallPanelCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallPanelCompletedEventType value)
        {
            return value switch
            {
                FusionCallPanelCompletedEventType.ResponseFusionCallPanelCompleted => "response.fusion_call.panel.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallPanelCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.panel.completed" => FusionCallPanelCompletedEventType.ResponseFusionCallPanelCompleted,
                _ => null,
            };
        }
    }
}