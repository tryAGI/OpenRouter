
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Which apply_patch engine to use. "auto" (default) uses native passthrough when the endpoint advertises native apply_patch support, otherwise falls back to OpenRouter's HITL validator. "native" forces native passthrough — when the endpoint does not support native, the request falls back to HITL. "openrouter" always runs the HITL validator. Native passthrough streams the diff incrementally via `apply_patch_call_operation_diff.delta` events; HITL buffers the diff for atomic delivery as a single delta.
    /// </summary>
    public enum ApplyPatchEngineEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Native,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchEngineEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchEngineEnum value)
        {
            return value switch
            {
                ApplyPatchEngineEnum.Auto => "auto",
                ApplyPatchEngineEnum.Native => "native",
                ApplyPatchEngineEnum.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchEngineEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ApplyPatchEngineEnum.Auto,
                "native" => ApplyPatchEngineEnum.Native,
                "openrouter" => ApplyPatchEngineEnum.Openrouter,
                _ => null,
            };
        }
    }
}