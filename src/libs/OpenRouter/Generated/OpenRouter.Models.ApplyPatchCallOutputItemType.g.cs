
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOutputItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOutputItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOutputItemType value)
        {
            return value switch
            {
                ApplyPatchCallOutputItemType.ApplyPatchCallOutput => "apply_patch_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOutputItemType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call_output" => ApplyPatchCallOutputItemType.ApplyPatchCallOutput,
                _ => null,
            };
        }
    }
}