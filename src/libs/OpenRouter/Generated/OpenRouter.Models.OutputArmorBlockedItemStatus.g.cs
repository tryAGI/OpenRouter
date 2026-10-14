
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputArmorBlockedItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputArmorBlockedItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputArmorBlockedItemStatus value)
        {
            return value switch
            {
                OutputArmorBlockedItemStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputArmorBlockedItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputArmorBlockedItemStatus.Completed,
                _ => null,
            };
        }
    }
}