
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContextCompressionPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        ContextCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextCompressionPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextCompressionPluginId value)
        {
            return value switch
            {
                ContextCompressionPluginId.ContextCompression => "context-compression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextCompressionPluginId? ToEnum(string value)
        {
            return value switch
            {
                "context-compression" => ContextCompressionPluginId.ContextCompression,
                _ => null,
            };
        }
    }
}