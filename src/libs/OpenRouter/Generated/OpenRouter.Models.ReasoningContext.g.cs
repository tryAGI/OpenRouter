
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.
    /// </summary>
    public enum ReasoningContext
    {
        /// <summary>
        /// 
        /// </summary>
        AllTurns,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        CurrentTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningContextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningContext value)
        {
            return value switch
            {
                ReasoningContext.AllTurns => "all_turns",
                ReasoningContext.Auto => "auto",
                ReasoningContext.CurrentTurn => "current_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningContext? ToEnum(string value)
        {
            return value switch
            {
                "all_turns" => ReasoningContext.AllTurns,
                "auto" => ReasoningContext.Auto,
                "current_turn" => ReasoningContext.CurrentTurn,
                _ => null,
            };
        }
    }
}