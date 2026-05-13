
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallItemOperationOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallItemOperationOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallItemOperationOneOf2Type value)
        {
            return value switch
            {
                ApplyPatchCallItemOperationOneOf2Type.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallItemOperationOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => ApplyPatchCallItemOperationOneOf2Type.UpdateFile,
                _ => null,
            };
        }
    }
}