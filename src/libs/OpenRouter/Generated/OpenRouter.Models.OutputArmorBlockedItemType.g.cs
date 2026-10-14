
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputArmorBlockedItemType
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter_armorBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputArmorBlockedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputArmorBlockedItemType value)
        {
            return value switch
            {
                OutputArmorBlockedItemType.Openrouter_armorBlocked => "openrouter:armor_blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputArmorBlockedItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:armor_blocked" => OutputArmorBlockedItemType.Openrouter_armorBlocked,
                _ => null,
            };
        }
    }
}