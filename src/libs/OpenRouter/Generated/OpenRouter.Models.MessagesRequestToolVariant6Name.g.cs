
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant6Name
    {
        /// <summary>
        ///
        /// </summary>
        Advisor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant6NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant6Name value)
        {
            return value switch
            {
                MessagesRequestToolVariant6Name.Advisor => "advisor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant6Name? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => MessagesRequestToolVariant6Name.Advisor,
                _ => null,
            };
        }
    }
}