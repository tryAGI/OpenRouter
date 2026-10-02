
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemWebSearchCallActionVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionVariant1Type value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionVariant1Type.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "search" => OutputItemWebSearchCallActionVariant1Type.Search,
                _ => null,
            };
        }
    }
}