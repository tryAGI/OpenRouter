
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InternChatToolCallFunctionName
    {
        /// <summary>
        ///
        /// </summary>
        OpenrouterProvideInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternChatToolCallFunctionNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatToolCallFunctionName value)
        {
            return value switch
            {
                InternChatToolCallFunctionName.OpenrouterProvideInput => "openrouter.provide_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatToolCallFunctionName? ToEnum(string value)
        {
            return value switch
            {
                "openrouter.provide_input" => InternChatToolCallFunctionName.OpenrouterProvideInput,
                _ => null,
            };
        }
    }
}