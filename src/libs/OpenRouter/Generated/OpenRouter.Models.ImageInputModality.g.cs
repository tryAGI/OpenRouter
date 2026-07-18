
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageInputModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageInputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageInputModality value)
        {
            return value switch
            {
                ImageInputModality.Audio => "audio",
                ImageInputModality.File => "file",
                ImageInputModality.Image => "image",
                ImageInputModality.Text => "text",
                ImageInputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageInputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ImageInputModality.Audio,
                "file" => ImageInputModality.File,
                "image" => ImageInputModality.Image,
                "text" => ImageInputModality.Text,
                "video" => ImageInputModality.Video,
                _ => null,
            };
        }
    }
}