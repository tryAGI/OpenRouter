
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: fusion
    /// </summary>
    public enum ChatRequestPluginsItemsVariant4Id
    {
        /// <summary>
        /// fusion
        /// </summary>
        Fusion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsVariant4IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsVariant4Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsVariant4Id.Fusion => "fusion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsVariant4Id? ToEnum(string value)
        {
            return value switch
            {
                "fusion" => ChatRequestPluginsItemsVariant4Id.Fusion,
                _ => null,
            };
        }
    }
}