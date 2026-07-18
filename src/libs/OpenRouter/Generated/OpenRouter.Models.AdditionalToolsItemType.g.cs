
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdditionalToolsItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemType value)
        {
            return value switch
            {
                AdditionalToolsItemType.AdditionalTools => "additional_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => AdditionalToolsItemType.AdditionalTools,
                _ => null,
            };
        }
    }
}