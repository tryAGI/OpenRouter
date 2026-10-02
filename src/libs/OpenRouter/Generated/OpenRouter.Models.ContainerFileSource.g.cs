
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Container files are always produced by the assistant sandbox.<br/>
    /// Example: assistant
    /// </summary>
    public enum ContainerFileSource
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileSource value)
        {
            return value switch
            {
                ContainerFileSource.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileSource? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ContainerFileSource.Assistant,
                _ => null,
            };
        }
    }
}