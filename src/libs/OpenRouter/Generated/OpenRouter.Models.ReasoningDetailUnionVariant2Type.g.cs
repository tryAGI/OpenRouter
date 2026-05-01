
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: reasoning.summary
    /// </summary>
    public enum ReasoningDetailUnionVariant2Type
    {
        /// <summary>
        /// reasoning.summary
        /// </summary>
        ReasoningSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailUnionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailUnionVariant2Type value)
        {
            return value switch
            {
                ReasoningDetailUnionVariant2Type.ReasoningSummary => "reasoning.summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailUnionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.summary" => ReasoningDetailUnionVariant2Type.ReasoningSummary,
                _ => null,
            };
        }
    }
}