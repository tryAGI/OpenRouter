
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemWebSearchCallActionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        OpenPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionVariant2Type value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionVariant2Type.OpenPage => "open_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "open_page" => OutputItemWebSearchCallActionVariant2Type.OpenPage,
                _ => null,
            };
        }
    }
}