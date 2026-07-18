
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The category of feedback being reported
    /// </summary>
    public enum SubmitGenerationFeedbackRequestCategory
    {
        /// <summary>
        /// 
        /// </summary>
        ApiError,
        /// <summary>
        /// 
        /// </summary>
        Billing,
        /// <summary>
        /// 
        /// </summary>
        Formatting,
        /// <summary>
        /// 
        /// </summary>
        Incoherence,
        /// <summary>
        /// 
        /// </summary>
        IncorrectResponse,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitGenerationFeedbackRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitGenerationFeedbackRequestCategory value)
        {
            return value switch
            {
                SubmitGenerationFeedbackRequestCategory.ApiError => "api_error",
                SubmitGenerationFeedbackRequestCategory.Billing => "billing",
                SubmitGenerationFeedbackRequestCategory.Formatting => "formatting",
                SubmitGenerationFeedbackRequestCategory.Incoherence => "incoherence",
                SubmitGenerationFeedbackRequestCategory.IncorrectResponse => "incorrect_response",
                SubmitGenerationFeedbackRequestCategory.Latency => "latency",
                SubmitGenerationFeedbackRequestCategory.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "api_error" => SubmitGenerationFeedbackRequestCategory.ApiError,
                "billing" => SubmitGenerationFeedbackRequestCategory.Billing,
                "formatting" => SubmitGenerationFeedbackRequestCategory.Formatting,
                "incoherence" => SubmitGenerationFeedbackRequestCategory.Incoherence,
                "incorrect_response" => SubmitGenerationFeedbackRequestCategory.IncorrectResponse,
                "latency" => SubmitGenerationFeedbackRequestCategory.Latency,
                "other" => SubmitGenerationFeedbackRequestCategory.Other,
                _ => null,
            };
        }
    }
}