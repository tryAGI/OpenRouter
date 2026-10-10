
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum DeferredToolsSearchStrategyDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Bm25,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsSearchStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsSearchStrategyDiscriminatorType value)
        {
            return value switch
            {
                DeferredToolsSearchStrategyDiscriminatorType.Bm25 => "bm25",
                DeferredToolsSearchStrategyDiscriminatorType.Custom => "custom",
                DeferredToolsSearchStrategyDiscriminatorType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsSearchStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bm25" => DeferredToolsSearchStrategyDiscriminatorType.Bm25,
                "custom" => DeferredToolsSearchStrategyDiscriminatorType.Custom,
                "regex" => DeferredToolsSearchStrategyDiscriminatorType.Regex,
                _ => null,
            };
        }
    }
}