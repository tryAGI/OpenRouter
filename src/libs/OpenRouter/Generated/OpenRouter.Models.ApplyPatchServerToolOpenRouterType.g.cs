
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_applyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchServerToolOpenRouterType value)
        {
            return value switch
            {
                ApplyPatchServerToolOpenRouterType.Openrouter_applyPatch => "openrouter:apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:apply_patch" => ApplyPatchServerToolOpenRouterType.Openrouter_applyPatch,
                _ => null,
            };
        }
    }
}