
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicImageMimeType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageMimeType value)
        {
            return value switch
            {
                AnthropicImageMimeType.ImageGif => "image/gif",
                AnthropicImageMimeType.ImageJpeg => "image/jpeg",
                AnthropicImageMimeType.ImagePng => "image/png",
                AnthropicImageMimeType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageMimeType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => AnthropicImageMimeType.ImageGif,
                "image/jpeg" => AnthropicImageMimeType.ImageJpeg,
                "image/png" => AnthropicImageMimeType.ImagePng,
                "image/webp" => AnthropicImageMimeType.ImageWebp,
                _ => null,
            };
        }
    }
}