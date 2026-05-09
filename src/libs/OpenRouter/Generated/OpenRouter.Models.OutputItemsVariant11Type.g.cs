
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:code_interpreter
    /// </summary>
    public enum OutputItemsVariant11Type
    {
        /// <summary>
        /// openrouter:code_interpreter
        /// </summary>
        Openrouter_codeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant11Type value)
        {
            return value switch
            {
                OutputItemsVariant11Type.Openrouter_codeInterpreter => "openrouter:code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:code_interpreter" => OutputItemsVariant11Type.Openrouter_codeInterpreter,
                _ => null,
            };
        }
    }
}