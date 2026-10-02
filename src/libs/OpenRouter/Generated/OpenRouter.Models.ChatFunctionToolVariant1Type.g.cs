
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatFunctionToolVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFunctionToolVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFunctionToolVariant1Type value)
        {
            return value switch
            {
                ChatFunctionToolVariant1Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFunctionToolVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatFunctionToolVariant1Type.Function,
                _ => null,
            };
        }
    }
}