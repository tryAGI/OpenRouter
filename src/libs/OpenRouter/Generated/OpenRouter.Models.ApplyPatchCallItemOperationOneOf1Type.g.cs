
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallItemOperationOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallItemOperationOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallItemOperationOneOf1Type value)
        {
            return value switch
            {
                ApplyPatchCallItemOperationOneOf1Type.DeleteFile => "delete_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallItemOperationOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "delete_file" => ApplyPatchCallItemOperationOneOf1Type.DeleteFile,
                _ => null,
            };
        }
    }
}