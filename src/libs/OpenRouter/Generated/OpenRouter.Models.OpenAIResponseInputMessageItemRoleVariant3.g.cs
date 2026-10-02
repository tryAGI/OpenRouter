
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseInputMessageItemRoleVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseInputMessageItemRoleVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseInputMessageItemRoleVariant3 value)
        {
            return value switch
            {
                OpenAIResponseInputMessageItemRoleVariant3.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseInputMessageItemRoleVariant3? ToEnum(string value)
        {
            return value switch
            {
                "developer" => OpenAIResponseInputMessageItemRoleVariant3.Developer,
                _ => null,
            };
        }
    }
}