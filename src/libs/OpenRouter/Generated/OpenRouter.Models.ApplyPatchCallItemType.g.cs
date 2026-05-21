
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallItemType value)
        {
            return value switch
            {
                ApplyPatchCallItemType.ApplyPatchCall => "apply_patch_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallItemType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => ApplyPatchCallItemType.ApplyPatchCall,
                _ => null,
            };
        }
    }
}