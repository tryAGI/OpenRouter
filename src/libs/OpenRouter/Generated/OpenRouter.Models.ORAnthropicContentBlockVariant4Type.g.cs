
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: container_upload
    /// </summary>
    public enum ORAnthropicContentBlockVariant4Type
    {
        /// <summary>
        /// container_upload
        /// </summary>
        ContainerUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant4Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant4Type.ContainerUpload => "container_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "container_upload" => ORAnthropicContentBlockVariant4Type.ContainerUpload,
                _ => null,
            };
        }
    }
}