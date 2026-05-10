
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType
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
    public static class AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType value)
        {
            return value switch
            {
                AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType.Image => "image",
                AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType.Image,
                "text" => AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}