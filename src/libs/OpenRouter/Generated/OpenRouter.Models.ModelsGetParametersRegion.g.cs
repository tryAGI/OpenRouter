
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Filter to models with endpoints in the given data region. Currently only "eu" is supported.
    /// </summary>
    public enum ModelsGetParametersRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsGetParametersRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsGetParametersRegion value)
        {
            return value switch
            {
                ModelsGetParametersRegion.Eu => "eu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsGetParametersRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => ModelsGetParametersRegion.Eu,
                _ => null,
            };
        }
    }
}