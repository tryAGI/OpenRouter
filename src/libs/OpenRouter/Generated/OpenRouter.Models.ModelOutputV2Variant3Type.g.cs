
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelOutputV2Variant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputV2Variant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputV2Variant3Type value)
        {
            return value switch
            {
                ModelOutputV2Variant3Type.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputV2Variant3Type? ToEnum(string value)
        {
            return value switch
            {
                "video" => ModelOutputV2Variant3Type.Video,
                _ => null,
            };
        }
    }
}