
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ApplyPatchCallOperationDiffDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseApplyPatchCallOperationDiffDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationDiffDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationDiffDoneEventType value)
        {
            return value switch
            {
                ApplyPatchCallOperationDiffDoneEventType.ResponseApplyPatchCallOperationDiffDone => "response.apply_patch_call_operation_diff.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationDiffDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.apply_patch_call_operation_diff.done" => ApplyPatchCallOperationDiffDoneEventType.ResponseApplyPatchCallOperationDiffDone,
                _ => null,
            };
        }
    }
}