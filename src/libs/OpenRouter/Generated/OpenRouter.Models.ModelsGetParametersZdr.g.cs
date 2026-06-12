
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// When set to "true", return only models with zero data retention endpoints.
    /// </summary>
    public enum ModelsGetParametersZdr
    {
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsGetParametersZdrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsGetParametersZdr value)
        {
            return value switch
            {
                ModelsGetParametersZdr.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsGetParametersZdr? ToEnum(string value)
        {
            return value switch
            {
                "true" => ModelsGetParametersZdr.True,
                _ => null,
            };
        }
    }
}