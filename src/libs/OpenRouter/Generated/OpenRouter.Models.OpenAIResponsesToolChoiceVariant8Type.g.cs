
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesToolChoiceVariant8Type
    {
        /// <summary>
        ///
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesToolChoiceVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesToolChoiceVariant8Type value)
        {
            return value switch
            {
                OpenAIResponsesToolChoiceVariant8Type.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesToolChoiceVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "shell" => OpenAIResponsesToolChoiceVariant8Type.Shell,
                _ => null,
            };
        }
    }
}