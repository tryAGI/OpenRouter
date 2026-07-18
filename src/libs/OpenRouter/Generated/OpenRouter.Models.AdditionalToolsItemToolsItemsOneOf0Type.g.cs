
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdditionalToolsItemToolsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemToolsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemToolsItemsOneOf0Type value)
        {
            return value switch
            {
                AdditionalToolsItemToolsItemsOneOf0Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemToolsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => AdditionalToolsItemToolsItemsOneOf0Type.Function,
                _ => null,
            };
        }
    }
}