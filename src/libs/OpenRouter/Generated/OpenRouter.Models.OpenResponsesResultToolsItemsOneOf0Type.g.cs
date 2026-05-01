
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenResponsesResultToolsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenResponsesResultToolsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenResponsesResultToolsItemsOneOf0Type value)
        {
            return value switch
            {
                OpenResponsesResultToolsItemsOneOf0Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenResponsesResultToolsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenResponsesResultToolsItemsOneOf0Type.Function,
                _ => null,
            };
        }
    }
}