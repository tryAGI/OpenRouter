
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputReferenceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioUrl,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputReferenceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputReferenceDiscriminatorType value)
        {
            return value switch
            {
                InputReferenceDiscriminatorType.AudioUrl => "audio_url",
                InputReferenceDiscriminatorType.ImageUrl => "image_url",
                InputReferenceDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputReferenceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => InputReferenceDiscriminatorType.AudioUrl,
                "image_url" => InputReferenceDiscriminatorType.ImageUrl,
                "video_url" => InputReferenceDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}