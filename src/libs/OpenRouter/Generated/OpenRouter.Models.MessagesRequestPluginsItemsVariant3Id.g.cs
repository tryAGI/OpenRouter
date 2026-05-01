
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: file-parser
    /// </summary>
    public enum MessagesRequestPluginsItemsVariant3Id
    {
        /// <summary>
        /// file-parser
        /// </summary>
        FileParser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsVariant3IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsVariant3Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsVariant3Id.FileParser => "file-parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsVariant3Id? ToEnum(string value)
        {
            return value switch
            {
                "file-parser" => MessagesRequestPluginsItemsVariant3Id.FileParser,
                _ => null,
            };
        }
    }
}