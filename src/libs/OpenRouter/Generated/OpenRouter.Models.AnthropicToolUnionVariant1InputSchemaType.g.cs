
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicToolUnionVariant1InputSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUnionVariant1InputSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUnionVariant1InputSchemaType value)
        {
            return value switch
            {
                AnthropicToolUnionVariant1InputSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUnionVariant1InputSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => AnthropicToolUnionVariant1InputSchemaType.Object,
                _ => null,
            };
        }
    }
}