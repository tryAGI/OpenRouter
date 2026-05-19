
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOperationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CreateFile,
        /// <summary>
        /// 
        /// </summary>
        DeleteFile,
        /// <summary>
        /// 
        /// </summary>
        UpdateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationDiscriminatorType value)
        {
            return value switch
            {
                ApplyPatchCallOperationDiscriminatorType.CreateFile => "create_file",
                ApplyPatchCallOperationDiscriminatorType.DeleteFile => "delete_file",
                ApplyPatchCallOperationDiscriminatorType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchCallOperationDiscriminatorType.CreateFile,
                "delete_file" => ApplyPatchCallOperationDiscriminatorType.DeleteFile,
                "update_file" => ApplyPatchCallOperationDiscriminatorType.UpdateFile,
                _ => null,
            };
        }
    }
}