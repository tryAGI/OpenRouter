
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image detail level for vision models. `original` is an OpenRouter extension (not in the OpenAI Chat Completions spec) requesting true original-resolution media; it is downgraded to `high` for providers that lack an original-resolution tier.
    /// </summary>
    public enum ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail value)
        {
            return value switch
            {
                ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.Auto => "auto",
                ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.High => "high",
                ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.Low => "low",
                ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.Auto,
                "high" => ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.High,
                "low" => ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.Low,
                "original" => ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail.Original,
                _ => null,
            };
        }
    }
}