
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter-held request and result artifacts were purged.
    /// </summary>
    public enum BatchDeletionTargetsOpenrouter
    {
        /// <summary>
        ///
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchDeletionTargetsOpenrouterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchDeletionTargetsOpenrouter value)
        {
            return value switch
            {
                BatchDeletionTargetsOpenrouter.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchDeletionTargetsOpenrouter? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => BatchDeletionTargetsOpenrouter.Deleted,
                _ => null,
            };
        }
    }
}