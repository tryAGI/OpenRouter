
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ArmorSafeguardResultStatusType
    {
        /// <summary>
        ///
        /// </summary>
        Available,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorSafeguardResultStatusTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorSafeguardResultStatusType value)
        {
            return value switch
            {
                ArmorSafeguardResultStatusType.Available => "available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorSafeguardResultStatusType? ToEnum(string value)
        {
            return value switch
            {
                "available" => ArmorSafeguardResultStatusType.Available,
                _ => null,
            };
        }
    }
}