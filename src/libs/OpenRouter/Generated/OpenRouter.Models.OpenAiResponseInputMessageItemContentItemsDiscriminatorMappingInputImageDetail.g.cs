
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail value)
        {
            return value switch
            {
                OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail.Auto => "auto",
                OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail.High => "high",
                OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail.Auto,
                "high" => OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail.High,
                "low" => OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail.Low,
                _ => null,
            };
        }
    }
}