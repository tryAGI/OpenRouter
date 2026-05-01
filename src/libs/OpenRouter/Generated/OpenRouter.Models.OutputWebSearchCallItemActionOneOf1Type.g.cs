
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputWebSearchCallItemActionOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        OpenPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebSearchCallItemActionOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebSearchCallItemActionOneOf1Type value)
        {
            return value switch
            {
                OutputWebSearchCallItemActionOneOf1Type.OpenPage => "open_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebSearchCallItemActionOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "open_page" => OutputWebSearchCallItemActionOneOf1Type.OpenPage,
                _ => null,
            };
        }
    }
}