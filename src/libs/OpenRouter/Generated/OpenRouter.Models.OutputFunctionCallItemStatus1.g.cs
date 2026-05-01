
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFunctionCallItemStatus1
    {
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFunctionCallItemStatus1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFunctionCallItemStatus1 value)
        {
            return value switch
            {
                OutputFunctionCallItemStatus1.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFunctionCallItemStatus1? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => OutputFunctionCallItemStatus1.Incomplete,
                _ => null,
            };
        }
    }
}