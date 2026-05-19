
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: create_file
    /// </summary>
    public enum ApplyPatchCallOperationVariant1Type
    {
        /// <summary>
        /// create_file
        /// </summary>
        CreateFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOperationVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOperationVariant1Type value)
        {
            return value switch
            {
                ApplyPatchCallOperationVariant1Type.CreateFile => "create_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOperationVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "create_file" => ApplyPatchCallOperationVariant1Type.CreateFile,
                _ => null,
            };
        }
    }
}