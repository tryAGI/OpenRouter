
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesToolChoiceVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesToolChoiceVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesToolChoiceVariant4Type value)
        {
            return value switch
            {
                OpenAIResponsesToolChoiceVariant4Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesToolChoiceVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAIResponsesToolChoiceVariant4Type.Function,
                _ => null,
            };
        }
    }
}