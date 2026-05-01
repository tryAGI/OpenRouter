
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputWebSearchCallItemActionOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        FindInPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebSearchCallItemActionOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebSearchCallItemActionOneOf2Type value)
        {
            return value switch
            {
                OutputWebSearchCallItemActionOneOf2Type.FindInPage => "find_in_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebSearchCallItemActionOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => OutputWebSearchCallItemActionOneOf2Type.FindInPage,
                _ => null,
            };
        }
    }
}