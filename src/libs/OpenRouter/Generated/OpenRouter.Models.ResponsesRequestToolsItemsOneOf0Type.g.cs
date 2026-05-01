
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesRequestToolsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestToolsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestToolsItemsOneOf0Type value)
        {
            return value switch
            {
                ResponsesRequestToolsItemsOneOf0Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestToolsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => ResponsesRequestToolsItemsOneOf0Type.Function,
                _ => null,
            };
        }
    }
}