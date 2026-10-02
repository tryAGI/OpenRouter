
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseInputMessageItemRoleVariant2
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseInputMessageItemRoleVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseInputMessageItemRoleVariant2 value)
        {
            return value switch
            {
                OpenAIResponseInputMessageItemRoleVariant2.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseInputMessageItemRoleVariant2? ToEnum(string value)
        {
            return value switch
            {
                "system" => OpenAIResponseInputMessageItemRoleVariant2.System,
                _ => null,
            };
        }
    }
}