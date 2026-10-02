
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesToolChoiceVariant7Type
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesToolChoiceVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesToolChoiceVariant7Type value)
        {
            return value switch
            {
                OpenAIResponsesToolChoiceVariant7Type.ApplyPatch => "apply_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesToolChoiceVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => OpenAIResponsesToolChoiceVariant7Type.ApplyPatch,
                _ => null,
            };
        }
    }
}