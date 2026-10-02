
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenRouterFileDeletedType
    {
        /// <summary>
        ///
        /// </summary>
        FileDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterFileDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterFileDeletedType value)
        {
            return value switch
            {
                OpenRouterFileDeletedType.FileDeleted => "file_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterFileDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "file_deleted" => OpenRouterFileDeletedType.FileDeleted,
                _ => null,
            };
        }
    }
}