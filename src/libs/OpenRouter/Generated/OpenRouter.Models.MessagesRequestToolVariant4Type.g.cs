
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch20250305,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant4Type value)
        {
            return value switch
            {
                MessagesRequestToolVariant4Type.WebSearch20250305 => "web_search_20250305",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_20250305" => MessagesRequestToolVariant4Type.WebSearch20250305,
                _ => null,
            };
        }
    }
}