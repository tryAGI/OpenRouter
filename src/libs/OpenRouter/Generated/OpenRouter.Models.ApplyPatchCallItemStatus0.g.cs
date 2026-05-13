
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallItemStatus0
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallItemStatus0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallItemStatus0 value)
        {
            return value switch
            {
                ApplyPatchCallItemStatus0.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallItemStatus0? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ApplyPatchCallItemStatus0.InProgress,
                _ => null,
            };
        }
    }
}