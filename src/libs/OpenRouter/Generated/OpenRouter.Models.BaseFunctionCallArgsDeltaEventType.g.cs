
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseFunctionCallArgsDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseFunctionCallArgsDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseFunctionCallArgsDeltaEventType value)
        {
            return value switch
            {
                BaseFunctionCallArgsDeltaEventType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseFunctionCallArgsDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => BaseFunctionCallArgsDeltaEventType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}