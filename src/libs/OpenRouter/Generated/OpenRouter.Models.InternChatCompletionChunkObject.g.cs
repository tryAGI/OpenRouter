
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InternChatCompletionChunkObject
    {
        /// <summary>
        ///
        /// </summary>
        ChatCompletionChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternChatCompletionChunkObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatCompletionChunkObject value)
        {
            return value switch
            {
                InternChatCompletionChunkObject.ChatCompletionChunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatCompletionChunkObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => InternChatCompletionChunkObject.ChatCompletionChunk,
                _ => null,
            };
        }
    }
}