
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemReferenceItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ItemReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemReferenceItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemReferenceItemType value)
        {
            return value switch
            {
                ItemReferenceItemType.ItemReference => "item_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemReferenceItemType? ToEnum(string value)
        {
            return value switch
            {
                "item_reference" => ItemReferenceItemType.ItemReference,
                _ => null,
            };
        }
    }
}