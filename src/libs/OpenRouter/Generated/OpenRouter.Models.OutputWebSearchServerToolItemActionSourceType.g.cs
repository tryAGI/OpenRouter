
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputWebSearchServerToolItemActionSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputWebSearchServerToolItemActionSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputWebSearchServerToolItemActionSourceType value)
        {
            return value switch
            {
                OutputWebSearchServerToolItemActionSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputWebSearchServerToolItemActionSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => OutputWebSearchServerToolItemActionSourceType.Url,
                _ => null,
            };
        }
    }
}