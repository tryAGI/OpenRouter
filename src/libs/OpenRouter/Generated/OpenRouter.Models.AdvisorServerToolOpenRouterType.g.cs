
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdvisorServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_advisor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvisorServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvisorServerToolOpenRouterType value)
        {
            return value switch
            {
                AdvisorServerToolOpenRouterType.Openrouter_advisor => "openrouter:advisor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvisorServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:advisor" => AdvisorServerToolOpenRouterType.Openrouter_advisor,
                _ => null,
            };
        }
    }
}