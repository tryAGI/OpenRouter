
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallItemOperationOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        CreateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallItemOperationOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallItemOperationOneOf0Type value)
        {
            return value switch
            {
                ApplyPatchCallItemOperationOneOf0Type.CreateFile => "create_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallItemOperationOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchCallItemOperationOneOf0Type.CreateFile,
                _ => null,
            };
        }
    }
}