
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaType? ToEnum(string value)
        {
            return value switch
            {
                "text/plain" => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaType.TextPlain,
                _ => null,
            };
        }
    }
}