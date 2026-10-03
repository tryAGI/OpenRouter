
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant5Type
    {
        /// <summary>
        ///
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant5Type value)
        {
            return value switch
            {
                ModelInputV2Variant5Type.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant5Type? ToEnum(string value)
        {
            return value switch
            {
                "file" => ModelInputV2Variant5Type.File,
                _ => null,
            };
        }
    }
}