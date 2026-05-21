
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoiceOneOf7Type
    {
        /// <summary>
        /// 
        /// </summary>
        Shell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoiceOneOf7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoiceOneOf7Type value)
        {
            return value switch
            {
                OpenAiResponsesToolChoiceOneOf7Type.Shell => "shell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoiceOneOf7Type? ToEnum(string value)
        {
            return value switch
            {
                "shell" => OpenAiResponsesToolChoiceOneOf7Type.Shell,
                _ => null,
            };
        }
    }
}