
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.
    /// </summary>
    public enum MetadataLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataLevel value)
        {
            return value switch
            {
                MetadataLevel.Disabled => "disabled",
                MetadataLevel.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataLevel? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => MetadataLevel.Disabled,
                "enabled" => MetadataLevel.Enabled,
                _ => null,
            };
        }
    }
}