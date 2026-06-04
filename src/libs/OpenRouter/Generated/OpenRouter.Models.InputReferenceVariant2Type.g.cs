
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: image_url
    /// </summary>
    public enum InputReferenceVariant2Type
    {
        /// <summary>
        /// image_url
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputReferenceVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputReferenceVariant2Type value)
        {
            return value switch
            {
                InputReferenceVariant2Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputReferenceVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => InputReferenceVariant2Type.ImageUrl,
                _ => null,
            };
        }
    }
}