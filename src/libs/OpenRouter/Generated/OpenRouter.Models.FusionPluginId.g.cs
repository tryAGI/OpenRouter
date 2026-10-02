
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FusionPluginId
    {
        /// <summary>
        ///
        /// </summary>
        Fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionPluginId value)
        {
            return value switch
            {
                FusionPluginId.Fusion => "fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionPluginId? ToEnum(string value)
        {
            return value switch
            {
                "fusion" => FusionPluginId.Fusion,
                _ => null,
            };
        }
    }
}