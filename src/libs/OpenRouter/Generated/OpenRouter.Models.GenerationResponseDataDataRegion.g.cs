
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The data region this generation was routed through. 'europe' for EU-routed requests, 'global' otherwise.
    /// </summary>
    public enum GenerationResponseDataDataRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Europe,
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataDataRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataDataRegion value)
        {
            return value switch
            {
                GenerationResponseDataDataRegion.Europe => "europe",
                GenerationResponseDataDataRegion.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataDataRegion? ToEnum(string value)
        {
            return value switch
            {
                "europe" => GenerationResponseDataDataRegion.Europe,
                "global" => GenerationResponseDataDataRegion.Global,
                _ => null,
            };
        }
    }
}