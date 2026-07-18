
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: file-parser
    /// </summary>
    public enum MessagesRequestPluginsItemsVariant4Id
    {
        /// <summary>
        /// file-parser
        /// </summary>
        FileParser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsVariant4IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsVariant4Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsVariant4Id.FileParser => "file-parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsVariant4Id? ToEnum(string value)
        {
            return value switch
            {
                "file-parser" => MessagesRequestPluginsItemsVariant4Id.FileParser,
                _ => null,
            };
        }
    }
}