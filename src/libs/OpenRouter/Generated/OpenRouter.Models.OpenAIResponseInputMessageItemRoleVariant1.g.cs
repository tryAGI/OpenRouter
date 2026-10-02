
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseInputMessageItemRoleVariant1
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseInputMessageItemRoleVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseInputMessageItemRoleVariant1 value)
        {
            return value switch
            {
                OpenAIResponseInputMessageItemRoleVariant1.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseInputMessageItemRoleVariant1? ToEnum(string value)
        {
            return value switch
            {
                "user" => OpenAIResponseInputMessageItemRoleVariant1.User,
                _ => null,
            };
        }
    }
}