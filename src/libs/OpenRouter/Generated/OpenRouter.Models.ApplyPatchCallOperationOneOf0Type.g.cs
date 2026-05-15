
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOperationOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        CreateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationOneOf0Type value)
        {
            return value switch
            {
                ApplyPatchCallOperationOneOf0Type.CreateFile => "create_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchCallOperationOneOf0Type.CreateFile,
                _ => null,
            };
        }
    }
}