
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InputMessageItemRoleVariant2
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemRoleVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemRoleVariant2 value)
        {
            return value switch
            {
                InputMessageItemRoleVariant2.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemRoleVariant2? ToEnum(string value)
        {
            return value switch
            {
                "system" => InputMessageItemRoleVariant2.System,
                _ => null,
            };
        }
    }
}