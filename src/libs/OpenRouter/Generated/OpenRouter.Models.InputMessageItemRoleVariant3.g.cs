
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InputMessageItemRoleVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemRoleVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemRoleVariant3 value)
        {
            return value switch
            {
                InputMessageItemRoleVariant3.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemRoleVariant3? ToEnum(string value)
        {
            return value switch
            {
                "developer" => InputMessageItemRoleVariant3.Developer,
                _ => null,
            };
        }
    }
}