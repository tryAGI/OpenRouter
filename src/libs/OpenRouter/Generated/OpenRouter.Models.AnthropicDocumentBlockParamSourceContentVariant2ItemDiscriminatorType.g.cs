
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType.Image => "image",
                AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType.Image,
                "text" => AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}