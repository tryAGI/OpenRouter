
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum EasyInputMessageRoleVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRoleVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRoleVariant3 value)
        {
            return value switch
            {
                EasyInputMessageRoleVariant3.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRoleVariant3? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EasyInputMessageRoleVariant3.Assistant,
                _ => null,
            };
        }
    }
}