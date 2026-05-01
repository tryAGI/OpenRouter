
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: reasoning.encrypted
    /// </summary>
    public enum ReasoningDetailUnionVariant1Type
    {
        /// <summary>
        /// reasoning.encrypted
        /// </summary>
        ReasoningEncrypted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailUnionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailUnionVariant1Type value)
        {
            return value switch
            {
                ReasoningDetailUnionVariant1Type.ReasoningEncrypted => "reasoning.encrypted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailUnionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.encrypted" => ReasoningDetailUnionVariant1Type.ReasoningEncrypted,
                _ => null,
            };
        }
    }
}