
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseFunctionCallArgsDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseFunctionCallArgsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseFunctionCallArgsDoneEventType value)
        {
            return value switch
            {
                BaseFunctionCallArgsDoneEventType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseFunctionCallArgsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => BaseFunctionCallArgsDoneEventType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}