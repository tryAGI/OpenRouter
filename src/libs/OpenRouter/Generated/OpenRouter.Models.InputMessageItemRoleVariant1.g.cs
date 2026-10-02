
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InputMessageItemRoleVariant1
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemRoleVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemRoleVariant1 value)
        {
            return value switch
            {
                InputMessageItemRoleVariant1.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemRoleVariant1? ToEnum(string value)
        {
            return value switch
            {
                "user" => InputMessageItemRoleVariant1.User,
                _ => null,
            };
        }
    }
}