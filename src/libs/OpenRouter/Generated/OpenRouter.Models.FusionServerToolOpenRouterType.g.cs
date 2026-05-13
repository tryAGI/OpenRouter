
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum FusionServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionServerToolOpenRouterType value)
        {
            return value switch
            {
                FusionServerToolOpenRouterType.Openrouter_fusion => "openrouter:fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:fusion" => FusionServerToolOpenRouterType.Openrouter_fusion,
                _ => null,
            };
        }
    }
}