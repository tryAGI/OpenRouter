
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionCallPanelAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionCallPanelAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionCallPanelAddedEventType value)
        {
            return value switch
            {
                FusionCallPanelAddedEventType.ResponseFusionCallPanelAdded => "response.fusion_call.panel.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionCallPanelAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.fusion_call.panel.added" => FusionCallPanelAddedEventType.ResponseFusionCallPanelAdded,
                _ => null,
            };
        }
    }
}