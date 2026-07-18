
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: reasoning.text
    /// </summary>
    public enum ReasoningDetailUnionVariant4Type
    {
        /// <summary>
        /// reasoning.text
        /// </summary>
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailUnionVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailUnionVariant4Type value)
        {
            return value switch
            {
                ReasoningDetailUnionVariant4Type.ReasoningText => "reasoning.text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailUnionVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.text" => ReasoningDetailUnionVariant4Type.ReasoningText,
                _ => null,
            };
        }
    }
}