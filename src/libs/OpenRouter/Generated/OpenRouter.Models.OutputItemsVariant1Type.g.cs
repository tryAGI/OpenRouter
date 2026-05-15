
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: apply_patch_call
    /// </summary>
    public enum OutputItemsVariant1Type
    {
        /// <summary>
        /// apply_patch_call
        /// </summary>
        ApplyPatchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant1Type value)
        {
            return value switch
            {
                OutputItemsVariant1Type.ApplyPatchCall => "apply_patch_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => OutputItemsVariant1Type.ApplyPatchCall,
                _ => null,
            };
        }
    }
}