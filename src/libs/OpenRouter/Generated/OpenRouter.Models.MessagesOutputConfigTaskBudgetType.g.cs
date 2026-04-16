
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesOutputConfigTaskBudgetType
    {
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesOutputConfigTaskBudgetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesOutputConfigTaskBudgetType value)
        {
            return value switch
            {
                MessagesOutputConfigTaskBudgetType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesOutputConfigTaskBudgetType? ToEnum(string value)
        {
            return value switch
            {
                "tokens" => MessagesOutputConfigTaskBudgetType.Tokens,
                _ => null,
            };
        }
    }
}