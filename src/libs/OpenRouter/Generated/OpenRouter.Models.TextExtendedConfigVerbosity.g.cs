
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextExtendedConfigVerbosity
    {
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
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextExtendedConfigVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextExtendedConfigVerbosity value)
        {
            return value switch
            {
                TextExtendedConfigVerbosity.High => "high",
                TextExtendedConfigVerbosity.Low => "low",
                TextExtendedConfigVerbosity.Max => "max",
                TextExtendedConfigVerbosity.Medium => "medium",
                TextExtendedConfigVerbosity.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextExtendedConfigVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => TextExtendedConfigVerbosity.High,
                "low" => TextExtendedConfigVerbosity.Low,
                "max" => TextExtendedConfigVerbosity.Max,
                "medium" => TextExtendedConfigVerbosity.Medium,
                "xhigh" => TextExtendedConfigVerbosity.Xhigh,
                _ => null,
            };
        }
    }
}