
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum NamespaceFunctionToolAllowedCallersItems
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Programmatic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamespaceFunctionToolAllowedCallersItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamespaceFunctionToolAllowedCallersItems value)
        {
            return value switch
            {
                NamespaceFunctionToolAllowedCallersItems.Direct => "direct",
                NamespaceFunctionToolAllowedCallersItems.Programmatic => "programmatic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamespaceFunctionToolAllowedCallersItems? ToEnum(string value)
        {
            return value switch
            {
                "direct" => NamespaceFunctionToolAllowedCallersItems.Direct,
                "programmatic" => NamespaceFunctionToolAllowedCallersItems.Programmatic,
                _ => null,
            };
        }
    }
}