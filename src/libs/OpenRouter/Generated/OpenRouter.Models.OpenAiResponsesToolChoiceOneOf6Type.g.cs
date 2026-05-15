
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoiceOneOf6Type
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoiceOneOf6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoiceOneOf6Type value)
        {
            return value switch
            {
                OpenAiResponsesToolChoiceOneOf6Type.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoiceOneOf6Type? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => OpenAiResponsesToolChoiceOneOf6Type.ApplyPatch,
                _ => null,
            };
        }
    }
}