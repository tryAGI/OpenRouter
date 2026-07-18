
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: reasoning.summary
    /// </summary>
    public enum ReasoningDetailUnionVariant3Type
    {
        /// <summary>
        /// reasoning.summary
        /// </summary>
        ReasoningSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailUnionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailUnionVariant3Type value)
        {
            return value switch
            {
                ReasoningDetailUnionVariant3Type.ReasoningSummary => "reasoning.summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailUnionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.summary" => ReasoningDetailUnionVariant3Type.ReasoningSummary,
                _ => null,
            };
        }
    }
}