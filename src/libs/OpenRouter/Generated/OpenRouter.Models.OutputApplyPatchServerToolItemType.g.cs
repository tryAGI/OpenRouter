
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputApplyPatchServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_applyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputApplyPatchServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputApplyPatchServerToolItemType value)
        {
            return value switch
            {
                OutputApplyPatchServerToolItemType.Openrouter_applyPatch => "openrouter:apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputApplyPatchServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:apply_patch" => OutputApplyPatchServerToolItemType.Openrouter_applyPatch,
                _ => null,
            };
        }
    }
}