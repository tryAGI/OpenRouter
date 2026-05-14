
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputMessageItemContentItemsOneOf1Detail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageItemContentItemsOneOf1DetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageItemContentItemsOneOf1Detail value)
        {
            return value switch
            {
                InputMessageItemContentItemsOneOf1Detail.Auto => "auto",
                InputMessageItemContentItemsOneOf1Detail.High => "high",
                InputMessageItemContentItemsOneOf1Detail.Low => "low",
                InputMessageItemContentItemsOneOf1Detail.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageItemContentItemsOneOf1Detail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => InputMessageItemContentItemsOneOf1Detail.Auto,
                "high" => InputMessageItemContentItemsOneOf1Detail.High,
                "low" => InputMessageItemContentItemsOneOf1Detail.Low,
                "original" => InputMessageItemContentItemsOneOf1Detail.Original,
                _ => null,
            };
        }
    }
}