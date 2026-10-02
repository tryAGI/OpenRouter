
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemWebSearchCallActionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        FindInPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionVariant3Type value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionVariant3Type.FindInPage => "find_in_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => OutputItemWebSearchCallActionVariant3Type.FindInPage,
                _ => null,
            };
        }
    }
}