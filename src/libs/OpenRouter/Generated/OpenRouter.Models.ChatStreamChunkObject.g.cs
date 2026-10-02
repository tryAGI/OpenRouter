
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatStreamChunkObject
    {
        /// <summary>
        ///
        /// </summary>
        ChatCompletionChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamChunkObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamChunkObject value)
        {
            return value switch
            {
                ChatStreamChunkObject.ChatCompletionChunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamChunkObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => ChatStreamChunkObject.ChatCompletionChunk,
                _ => null,
            };
        }
    }
}