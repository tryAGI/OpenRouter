
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOperationOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationOneOf1Type value)
        {
            return value switch
            {
                ApplyPatchCallOperationOneOf1Type.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "update_file" => ApplyPatchCallOperationOneOf1Type.UpdateFile,
                _ => null,
            };
        }
    }
}