
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemMcpCallErrorVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        HttpError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemMcpCallErrorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemMcpCallErrorVariant4Type value)
        {
            return value switch
            {
                OutputItemMcpCallErrorVariant4Type.HttpError => "http_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemMcpCallErrorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => OutputItemMcpCallErrorVariant4Type.HttpError,
                _ => null,
            };
        }
    }
}