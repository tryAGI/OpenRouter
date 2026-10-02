
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputFusionServerToolItemType
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter_fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFusionServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFusionServerToolItemType value)
        {
            return value switch
            {
                OutputFusionServerToolItemType.Openrouter_fusion => "openrouter:fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFusionServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:fusion" => OutputFusionServerToolItemType.Openrouter_fusion,
                _ => null,
            };
        }
    }
}