
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOperationOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationOneOf2Type value)
        {
            return value switch
            {
                ApplyPatchCallOperationOneOf2Type.DeleteFile => "delete_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "delete_file" => ApplyPatchCallOperationOneOf2Type.DeleteFile,
                _ => null,
            };
        }
    }
}