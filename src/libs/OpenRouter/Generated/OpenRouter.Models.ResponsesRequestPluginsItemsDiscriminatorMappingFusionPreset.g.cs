
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A curated OpenRouter fusion preset (slugs follow `&lt;task&gt;-&lt;tier&gt;`, e.g. `general-high`). Expands server-side into the preset's analysis_models panel and judge model, so callers never name individual models. Explicitly provided `analysis_models` / `model` take precedence.
    /// </summary>
    public enum ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset
    {
        /// <summary>
        /// 
        /// </summary>
        GeneralBudget,
        /// <summary>
        /// 
        /// </summary>
        GeneralFast,
        /// <summary>
        /// 
        /// </summary>
        GeneralHigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsDiscriminatorMappingFusionPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset.GeneralBudget => "general-budget",
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset.GeneralFast => "general-fast",
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset.GeneralHigh => "general-high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset? ToEnum(string value)
        {
            return value switch
            {
                "general-budget" => ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset.GeneralBudget,
                "general-fast" => ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset.GeneralFast,
                "general-high" => ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset.GeneralHigh,
                _ => null,
            };
        }
    }
}