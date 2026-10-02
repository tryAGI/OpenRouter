
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemApplyPatchCallType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemApplyPatchCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemApplyPatchCallType value)
        {
            return value switch
            {
                OutputItemApplyPatchCallType.ApplyPatchCall => "apply_patch_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemApplyPatchCallType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => OutputItemApplyPatchCallType.ApplyPatchCall,
                _ => null,
            };
        }
    }
}