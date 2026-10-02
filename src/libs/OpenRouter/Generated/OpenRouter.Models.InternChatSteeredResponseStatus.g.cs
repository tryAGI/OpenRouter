
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The message was handed to the turn already running on this session.
    /// </summary>
    public enum InternChatSteeredResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Steered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternChatSteeredResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatSteeredResponseStatus value)
        {
            return value switch
            {
                InternChatSteeredResponseStatus.Steered => "steered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatSteeredResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "steered" => InternChatSteeredResponseStatus.Steered,
                _ => null,
            };
        }
    }
}