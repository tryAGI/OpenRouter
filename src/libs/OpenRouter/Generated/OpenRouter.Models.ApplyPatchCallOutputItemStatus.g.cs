
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOutputItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOutputItemStatus value)
        {
            return value switch
            {
                ApplyPatchCallOutputItemStatus.Completed => "completed",
                ApplyPatchCallOutputItemStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOutputItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ApplyPatchCallOutputItemStatus.Completed,
                "failed" => ApplyPatchCallOutputItemStatus.Failed,
                _ => null,
            };
        }
    }
}