
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessageContentOneOf0ItemsOneOf1Detail
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
    public static class EasyInputMessageContentOneOf0ItemsOneOf1DetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageContentOneOf0ItemsOneOf1Detail value)
        {
            return value switch
            {
                EasyInputMessageContentOneOf0ItemsOneOf1Detail.Auto => "auto",
                EasyInputMessageContentOneOf0ItemsOneOf1Detail.High => "high",
                EasyInputMessageContentOneOf0ItemsOneOf1Detail.Low => "low",
                EasyInputMessageContentOneOf0ItemsOneOf1Detail.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageContentOneOf0ItemsOneOf1Detail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => EasyInputMessageContentOneOf0ItemsOneOf1Detail.Auto,
                "high" => EasyInputMessageContentOneOf0ItemsOneOf1Detail.High,
                "low" => EasyInputMessageContentOneOf0ItemsOneOf1Detail.Low,
                "original" => EasyInputMessageContentOneOf0ItemsOneOf1Detail.Original,
                _ => null,
            };
        }
    }
}