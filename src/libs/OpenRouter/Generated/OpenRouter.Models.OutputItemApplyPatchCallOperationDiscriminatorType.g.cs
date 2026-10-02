
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemApplyPatchCallOperationDiscriminatorType
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
    public static class OutputItemApplyPatchCallOperationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemApplyPatchCallOperationDiscriminatorType value)
        {
            return value switch
            {
                OutputItemApplyPatchCallOperationDiscriminatorType.CreateFile => "create_file",
                OutputItemApplyPatchCallOperationDiscriminatorType.DeleteFile => "delete_file",
                OutputItemApplyPatchCallOperationDiscriminatorType.UpdateFile => "update_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemApplyPatchCallOperationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => OutputItemApplyPatchCallOperationDiscriminatorType.CreateFile,
                "delete_file" => OutputItemApplyPatchCallOperationDiscriminatorType.DeleteFile,
                "update_file" => OutputItemApplyPatchCallOperationDiscriminatorType.UpdateFile,
                _ => null,
            };
        }
    }
}