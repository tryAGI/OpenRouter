
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: python
    /// </summary>
    public enum ChatRequestResponseFormatVariant4Type
    {
        /// <summary>
        /// python
        /// </summary>
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestResponseFormatVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestResponseFormatVariant4Type value)
        {
            return value switch
            {
                ChatRequestResponseFormatVariant4Type.Python => "python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestResponseFormatVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "python" => ChatRequestResponseFormatVariant4Type.Python,
                _ => null,
            };
        }
    }
}