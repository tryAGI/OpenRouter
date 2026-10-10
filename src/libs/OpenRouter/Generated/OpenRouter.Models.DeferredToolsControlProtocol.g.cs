
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DeferredToolsControlProtocol
    {
        /// <summary>
        ///
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlProtocol value)
        {
            return value switch
            {
                DeferredToolsControlProtocol.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlProtocol? ToEnum(string value)
        {
            return value switch
            {
                "v1" => DeferredToolsControlProtocol.V1,
                _ => null,
            };
        }
    }
}