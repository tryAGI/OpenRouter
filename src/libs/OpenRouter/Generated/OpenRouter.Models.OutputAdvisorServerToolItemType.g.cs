
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputAdvisorServerToolItemType
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter_advisor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputAdvisorServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputAdvisorServerToolItemType value)
        {
            return value switch
            {
                OutputAdvisorServerToolItemType.Openrouter_advisor => "openrouter:advisor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputAdvisorServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:advisor" => OutputAdvisorServerToolItemType.Openrouter_advisor,
                _ => null,
            };
        }
    }
}