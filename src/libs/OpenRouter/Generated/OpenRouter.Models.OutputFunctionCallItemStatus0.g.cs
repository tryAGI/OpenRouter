
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFunctionCallItemStatus0
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFunctionCallItemStatus0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFunctionCallItemStatus0 value)
        {
            return value switch
            {
                OutputFunctionCallItemStatus0.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFunctionCallItemStatus0? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputFunctionCallItemStatus0.Completed,
                _ => null,
            };
        }
    }
}