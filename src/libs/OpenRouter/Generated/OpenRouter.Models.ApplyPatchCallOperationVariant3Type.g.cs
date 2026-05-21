
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: update_file
    /// </summary>
    public enum ApplyPatchCallOperationVariant3Type
    {
        /// <summary>
        /// update_file
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationVariant3Type value)
        {
            return value switch
            {
                ApplyPatchCallOperationVariant3Type.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => ApplyPatchCallOperationVariant3Type.UpdateFile,
                _ => null,
            };
        }
    }
}