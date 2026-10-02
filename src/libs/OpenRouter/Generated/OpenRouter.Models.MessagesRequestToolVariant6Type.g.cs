
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant6Type
    {
        /// <summary>
        ///
        /// </summary>
        Advisor20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant6Type value)
        {
            return value switch
            {
                MessagesRequestToolVariant6Type.Advisor20260301 => "advisor_20260301",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "advisor_20260301" => MessagesRequestToolVariant6Type.Advisor20260301,
                _ => null,
            };
        }
    }
}