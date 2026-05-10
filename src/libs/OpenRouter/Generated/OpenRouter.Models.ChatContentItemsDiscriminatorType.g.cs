
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatContentItemsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
        /// <summary>
        /// 
        /// </summary>
        InputVideo,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentItemsDiscriminatorType value)
        {
            return value switch
            {
                ChatContentItemsDiscriminatorType.File => "file",
                ChatContentItemsDiscriminatorType.ImageUrl => "image_url",
                ChatContentItemsDiscriminatorType.InputAudio => "input_audio",
                ChatContentItemsDiscriminatorType.InputVideo => "input_video",
                ChatContentItemsDiscriminatorType.Text => "text",
                ChatContentItemsDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => ChatContentItemsDiscriminatorType.File,
                "image_url" => ChatContentItemsDiscriminatorType.ImageUrl,
                "input_audio" => ChatContentItemsDiscriminatorType.InputAudio,
                "input_video" => ChatContentItemsDiscriminatorType.InputVideo,
                "text" => ChatContentItemsDiscriminatorType.Text,
                "video_url" => ChatContentItemsDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}