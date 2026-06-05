
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: openrouter:code_interpreter
    /// </summary>
    public enum OutputItemsVariant13Type
    {
        /// <summary>
        /// openrouter:code_interpreter
        /// </summary>
        Openrouter_codeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemsVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsVariant13Type value)
        {
            return value switch
            {
                OutputItemsVariant13Type.Openrouter_codeInterpreter => "openrouter:code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:code_interpreter" => OutputItemsVariant13Type.Openrouter_codeInterpreter,
                _ => null,
            };
        }
    }
}