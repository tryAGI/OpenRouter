
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: delete_file
    /// </summary>
    public enum ApplyPatchCallOperationVariant2Type
    {
        /// <summary>
        /// delete_file
        /// </summary>
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationVariant2Type value)
        {
            return value switch
            {
                ApplyPatchCallOperationVariant2Type.DeleteFile => "delete_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "delete_file" => ApplyPatchCallOperationVariant2Type.DeleteFile,
                _ => null,
            };
        }
    }
}