
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// When set to "true", return only models with zero data retention endpoints.<br/>
    /// Example: true
    /// </summary>
    public enum GetModelsZdr
    {
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsZdrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsZdr value)
        {
            return value switch
            {
                GetModelsZdr.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsZdr? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetModelsZdr.True,
                _ => null,
            };
        }
    }
}