
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputMessageItemPhase0
    {
        /// <summary>
        /// 
        /// </summary>
        Commentary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessageItemPhase0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessageItemPhase0 value)
        {
            return value switch
            {
                OutputMessageItemPhase0.Commentary => "commentary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessageItemPhase0? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => OutputMessageItemPhase0.Commentary,
                _ => null,
            };
        }
    }
}