
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputApplyPatchCallItemType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputApplyPatchCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputApplyPatchCallItemType value)
        {
            return value switch
            {
                OutputApplyPatchCallItemType.ApplyPatchCall => "apply_patch_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputApplyPatchCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => OutputApplyPatchCallItemType.ApplyPatchCall,
                _ => null,
            };
        }
    }
}