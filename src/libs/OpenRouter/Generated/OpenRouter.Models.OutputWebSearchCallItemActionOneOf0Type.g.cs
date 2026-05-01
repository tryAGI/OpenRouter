
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputWebSearchCallItemActionOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebSearchCallItemActionOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebSearchCallItemActionOneOf0Type value)
        {
            return value switch
            {
                OutputWebSearchCallItemActionOneOf0Type.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebSearchCallItemActionOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "search" => OutputWebSearchCallItemActionOneOf0Type.Search,
                _ => null,
            };
        }
    }
}