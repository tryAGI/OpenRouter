
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ApplyPatchDeleteFileOperationType
    {
        /// <summary>
        ///
        /// </summary>
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchDeleteFileOperationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchDeleteFileOperationType value)
        {
            return value switch
            {
                ApplyPatchDeleteFileOperationType.DeleteFile => "delete_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchDeleteFileOperationType? ToEnum(string value)
        {
            return value switch
            {
                "delete_file" => ApplyPatchDeleteFileOperationType.DeleteFile,
                _ => null,
            };
        }
    }
}