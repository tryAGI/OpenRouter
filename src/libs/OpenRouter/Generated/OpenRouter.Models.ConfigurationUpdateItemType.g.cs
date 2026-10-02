
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ConfigurationUpdateItemType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigurationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigurationUpdateItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurationUpdateItemType value)
        {
            return value switch
            {
                ConfigurationUpdateItemType.ConfigurationUpdate => "configuration_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurationUpdateItemType? ToEnum(string value)
        {
            return value switch
            {
                "configuration_update" => ConfigurationUpdateItemType.ConfigurationUpdate,
                _ => null,
            };
        }
    }
}