
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum EasyInputMessageRoleVariant2
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRoleVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRoleVariant2 value)
        {
            return value switch
            {
                EasyInputMessageRoleVariant2.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRoleVariant2? ToEnum(string value)
        {
            return value switch
            {
                "system" => EasyInputMessageRoleVariant2.System,
                _ => null,
            };
        }
    }
}