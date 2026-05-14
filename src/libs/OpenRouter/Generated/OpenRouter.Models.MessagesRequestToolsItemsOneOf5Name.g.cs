
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf5Name
    {
        /// <summary>
        /// 
        /// </summary>
        Advisor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf5NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf5Name value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf5Name.Advisor => "advisor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf5Name? ToEnum(string value)
        {
            return value switch
            {
                "advisor" => MessagesRequestToolsItemsOneOf5Name.Advisor,
                _ => null,
            };
        }
    }
}