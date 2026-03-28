
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchServerToolType value)
        {
            return value switch
            {
                ApplyPatchServerToolType.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => ApplyPatchServerToolType.ApplyPatch,
                _ => null,
            };
        }
    }
}