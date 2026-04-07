
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicContainerUploadType
    {
        /// <summary>
        /// 
        /// </summary>
        ContainerUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicContainerUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicContainerUploadType value)
        {
            return value switch
            {
                AnthropicContainerUploadType.ContainerUpload => "container_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicContainerUploadType? ToEnum(string value)
        {
            return value switch
            {
                "container_upload" => AnthropicContainerUploadType.ContainerUpload,
                _ => null,
            };
        }
    }
}