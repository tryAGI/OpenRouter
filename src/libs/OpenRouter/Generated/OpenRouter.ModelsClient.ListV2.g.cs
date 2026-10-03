
#nullable enable

namespace OpenRouter
{
    public partial class ModelsClient
    {

        private static readonly global::OpenRouter.AutoSDKServer[] s_ListV2Servers = new global::OpenRouter.AutoSDKServer[]
        {            new global::OpenRouter.AutoSDKServer(
                id: "https-openrouter-ai",
                name: "openrouter.ai",
                url: "https://openrouter.ai/",
                description: ""),
        };


        private static readonly global::OpenRouter.EndPointSecurityRequirement s_ListV2SecurityRequirement0 =
            new global::OpenRouter.EndPointSecurityRequirement
            {
                Authorizations = new global::OpenRouter.EndPointAuthorizationRequirement[]
                {                    new global::OpenRouter.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Bearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::OpenRouter.EndPointSecurityRequirement[] s_ListV2SecurityRequirements =
            new global::OpenRouter.EndPointSecurityRequirement[]
            {                s_ListV2SecurityRequirement0,
            };
        partial void PrepareListV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref string? cursor,
            ref global::OpenRouter.ListModelsV2Region? region,
            ref string? sort,
            ref string? id,
            ref string? canonicalSlug,
            ref string? author,
            ref string? name,
            ref string? variant,
            ref string? kind,
            ref string? aliasTargetSlug,
            ref string? aliasTargetName,
            ref string? created,
            ref string? description,
            ref string? contextLength,
            ref string? huggingFaceId,
            ref string? inputs,
            ref string? outputs,
            ref string? endpointsSchemaVersion,
            ref string? endpointsId,
            ref string? endpointsHuggingFaceId,
            ref string? endpointsName,
            ref string? endpointsCreated,
            ref string? endpointsQuantization,
            ref string? endpointsTokenizer,
            ref string? endpointsDescription,
            ref string? endpointsPricingType,
            ref string? endpointsPricingRequestUnit,
            ref string? endpointsPricingRequestCostUsd,
            ref string? endpointsPricingRequestOverridesCostUsd,
            ref string? endpointsPricingWebSearchUnit,
            ref string? endpointsPricingWebSearchCostUsd,
            ref string? endpointsPricingWebSearchOverridesCostUsd,
            ref string? endpointsCapacityType,
            ref string? endpointsCapacityRequestUnit,
            ref string? endpointsCapacityRequestPer,
            ref string? endpointsCapacityRequestValue,
            ref string? endpointsCapacityWebSearchUnit,
            ref string? endpointsCapacityWebSearchPer,
            ref string? endpointsCapacityWebSearchValue,
            ref string? endpointsCapacityConcurrencyUnit,
            ref string? endpointsCapacityConcurrencyValue,
            ref string? endpointsPassthroughParameters,
            ref string? endpointsDeprecationDate,
            ref string? endpointsIsReady,
            ref string? endpointsIsFree,
            ref string? endpointsServiceTier,
            ref string? endpointsDiscountToUser,
            ref string? endpointsOpenrouterSlug,
            ref string? endpointsDatacentersCountryCode,
            ref string? endpointsDatacentersRegion,
            ref string? endpointsDeploymentRegion,
            ref string? endpointsInputsType,
            ref string? endpointsInputsTextPricingType,
            ref string? endpointsInputsTextPricingPromptUnit,
            ref string? endpointsInputsTextPricingPromptCostUsd,
            ref string? endpointsInputsTextPricingPromptOverridesCostUsd,
            ref string? endpointsInputsTextPricingPromptUtcStart,
            ref string? endpointsInputsTextPricingPromptUtcEnd,
            ref string? endpointsInputsTextPricingPromptUtcDays,
            ref string? endpointsInputsTextPricingCachedPromptUnit,
            ref string? endpointsInputsTextPricingCachedPromptCostUsd,
            ref string? endpointsInputsTextPricingCachedPromptOverridesCostUsd,
            ref string? endpointsInputsTextPricingCachedPromptTtlSeconds,
            ref string? endpointsInputsTextPricingCachedPromptImplicit,
            ref string? endpointsInputsTextPricingCachedPromptUtcStart,
            ref string? endpointsInputsTextPricingCachedPromptUtcEnd,
            ref string? endpointsInputsTextPricingCachedPromptUtcDays,
            ref string? endpointsInputsTextPricingCacheWriteUnit,
            ref string? endpointsInputsTextPricingCacheWriteCostUsd,
            ref string? endpointsInputsTextPricingCacheWriteOverridesCostUsd,
            ref string? endpointsInputsTextPricingCacheWriteTtlSeconds,
            ref string? endpointsInputsTextPricingCacheWriteImplicit,
            ref string? endpointsInputsTextPricingCacheWriteUtcStart,
            ref string? endpointsInputsTextPricingCacheWriteUtcEnd,
            ref string? endpointsInputsTextPricingCacheWriteUtcDays,
            ref string? endpointsInputsTextCapacityType,
            ref string? endpointsInputsTextCapacityPromptUnit,
            ref string? endpointsInputsTextCapacityPromptPer,
            ref string? endpointsInputsTextCapacityPromptValue,
            ref string? endpointsInputsTextCapacityCachedPromptUnit,
            ref string? endpointsInputsTextCapacityCachedPromptPer,
            ref string? endpointsInputsTextCapacityCachedPromptValue,
            ref string? endpointsInputsTextCapacityCacheWriteUnit,
            ref string? endpointsInputsTextCapacityCacheWritePer,
            ref string? endpointsInputsTextCapacityCacheWriteValue,
            ref string? endpointsInputsTextPassthroughParameters,
            ref string? endpointsInputsTextParamsMaxPromptLengthValue,
            ref string? endpointsInputsTextParamsMaxPromptLengthUnit,
            ref string? endpointsInputsTextParamsMaxLengthValue,
            ref string? endpointsInputsTextParamsMaxLengthUnit,
            ref string? endpointsInputsImagePricingType,
            ref string? endpointsInputsImagePricingPromptUnit,
            ref string? endpointsInputsImagePricingPromptCostUsd,
            ref string? endpointsInputsImagePricingPromptOverridesCostUsd,
            ref string? endpointsInputsImagePricingPromptUtcStart,
            ref string? endpointsInputsImagePricingPromptUtcEnd,
            ref string? endpointsInputsImagePricingPromptUtcDays,
            ref string? endpointsInputsImagePricingCachedPromptUnit,
            ref string? endpointsInputsImagePricingCachedPromptCostUsd,
            ref string? endpointsInputsImagePricingCachedPromptOverridesCostUsd,
            ref string? endpointsInputsImagePricingCachedPromptTtlSeconds,
            ref string? endpointsInputsImagePricingCachedPromptImplicit,
            ref string? endpointsInputsImagePricingCachedPromptUtcStart,
            ref string? endpointsInputsImagePricingCachedPromptUtcEnd,
            ref string? endpointsInputsImagePricingCachedPromptUtcDays,
            ref string? endpointsInputsImagePricingCacheWriteUnit,
            ref string? endpointsInputsImagePricingCacheWriteCostUsd,
            ref string? endpointsInputsImagePricingCacheWriteOverridesCostUsd,
            ref string? endpointsInputsImagePricingCacheWriteTtlSeconds,
            ref string? endpointsInputsImagePricingCacheWriteImplicit,
            ref string? endpointsInputsImagePricingCacheWriteUtcStart,
            ref string? endpointsInputsImagePricingCacheWriteUtcEnd,
            ref string? endpointsInputsImagePricingCacheWriteUtcDays,
            ref string? endpointsInputsImageCapacityType,
            ref string? endpointsInputsImageCapacityPromptUnit,
            ref string? endpointsInputsImageCapacityPromptPer,
            ref string? endpointsInputsImageCapacityPromptValue,
            ref string? endpointsInputsImageCapacityCachedPromptUnit,
            ref string? endpointsInputsImageCapacityCachedPromptPer,
            ref string? endpointsInputsImageCapacityCachedPromptValue,
            ref string? endpointsInputsImageCapacityCacheWriteUnit,
            ref string? endpointsInputsImageCapacityCacheWritePer,
            ref string? endpointsInputsImageCapacityCacheWriteValue,
            ref string? endpointsInputsImagePassthroughParameters,
            ref string? endpointsInputsImageParamsSourcesType,
            ref string? endpointsInputsImageParamsSourcesValues,
            ref string? endpointsInputsImageParamsFormatsType,
            ref string? endpointsInputsImageParamsFormatsValues,
            ref string? endpointsInputsImageParamsDetailLevelsType,
            ref string? endpointsInputsImageParamsDetailLevelsValues,
            ref string? endpointsInputsImageParamsReferencesType,
            ref string? endpointsInputsImageParamsReferencesMin,
            ref string? endpointsInputsImageParamsReferencesMax,
            ref string? endpointsInputsImageParamsReferencesUnit,
            ref string? endpointsInputsImageParamsRoleType,
            ref string? endpointsInputsImageParamsRoleValues,
            ref string? endpointsInputsImageParamsMaxContentSizeBytesValue,
            ref string? endpointsInputsImageParamsMaxContentSizeBytesUnit,
            ref string? endpointsInputsVideoPricingType,
            ref string? endpointsInputsVideoPricingPromptUnit,
            ref string? endpointsInputsVideoPricingPromptCostUsd,
            ref string? endpointsInputsVideoPricingPromptOverridesCostUsd,
            ref string? endpointsInputsVideoPricingPromptUtcStart,
            ref string? endpointsInputsVideoPricingPromptUtcEnd,
            ref string? endpointsInputsVideoPricingPromptUtcDays,
            ref string? endpointsInputsVideoPricingCachedPromptUnit,
            ref string? endpointsInputsVideoPricingCachedPromptCostUsd,
            ref string? endpointsInputsVideoPricingCachedPromptOverridesCostUsd,
            ref string? endpointsInputsVideoPricingCachedPromptTtlSeconds,
            ref string? endpointsInputsVideoPricingCachedPromptImplicit,
            ref string? endpointsInputsVideoPricingCachedPromptUtcStart,
            ref string? endpointsInputsVideoPricingCachedPromptUtcEnd,
            ref string? endpointsInputsVideoPricingCachedPromptUtcDays,
            ref string? endpointsInputsVideoPricingCacheWriteUnit,
            ref string? endpointsInputsVideoPricingCacheWriteCostUsd,
            ref string? endpointsInputsVideoPricingCacheWriteOverridesCostUsd,
            ref string? endpointsInputsVideoPricingCacheWriteTtlSeconds,
            ref string? endpointsInputsVideoPricingCacheWriteImplicit,
            ref string? endpointsInputsVideoPricingCacheWriteUtcStart,
            ref string? endpointsInputsVideoPricingCacheWriteUtcEnd,
            ref string? endpointsInputsVideoPricingCacheWriteUtcDays,
            ref string? endpointsInputsVideoCapacityType,
            ref string? endpointsInputsVideoCapacityPromptUnit,
            ref string? endpointsInputsVideoCapacityPromptPer,
            ref string? endpointsInputsVideoCapacityPromptValue,
            ref string? endpointsInputsVideoCapacityCachedPromptUnit,
            ref string? endpointsInputsVideoCapacityCachedPromptPer,
            ref string? endpointsInputsVideoCapacityCachedPromptValue,
            ref string? endpointsInputsVideoCapacityCacheWriteUnit,
            ref string? endpointsInputsVideoCapacityCacheWritePer,
            ref string? endpointsInputsVideoCapacityCacheWriteValue,
            ref string? endpointsInputsVideoPassthroughParameters,
            ref string? endpointsInputsVideoParamsSourcesType,
            ref string? endpointsInputsVideoParamsSourcesValues,
            ref string? endpointsInputsVideoParamsFormatsType,
            ref string? endpointsInputsVideoParamsFormatsValues,
            ref string? endpointsInputsVideoParamsMaxDurationSecondsValue,
            ref string? endpointsInputsVideoParamsMaxDurationSecondsUnit,
            ref string? endpointsInputsVideoParamsMaxContentSizeBytesValue,
            ref string? endpointsInputsVideoParamsMaxContentSizeBytesUnit,
            ref string? endpointsInputsAudioPricingType,
            ref string? endpointsInputsAudioPricingPromptUnit,
            ref string? endpointsInputsAudioPricingPromptCostUsd,
            ref string? endpointsInputsAudioPricingPromptOverridesCostUsd,
            ref string? endpointsInputsAudioPricingPromptUtcStart,
            ref string? endpointsInputsAudioPricingPromptUtcEnd,
            ref string? endpointsInputsAudioPricingPromptUtcDays,
            ref string? endpointsInputsAudioPricingCachedPromptUnit,
            ref string? endpointsInputsAudioPricingCachedPromptCostUsd,
            ref string? endpointsInputsAudioPricingCachedPromptOverridesCostUsd,
            ref string? endpointsInputsAudioPricingCachedPromptTtlSeconds,
            ref string? endpointsInputsAudioPricingCachedPromptImplicit,
            ref string? endpointsInputsAudioPricingCachedPromptUtcStart,
            ref string? endpointsInputsAudioPricingCachedPromptUtcEnd,
            ref string? endpointsInputsAudioPricingCachedPromptUtcDays,
            ref string? endpointsInputsAudioPricingCacheWriteUnit,
            ref string? endpointsInputsAudioPricingCacheWriteCostUsd,
            ref string? endpointsInputsAudioPricingCacheWriteOverridesCostUsd,
            ref string? endpointsInputsAudioPricingCacheWriteTtlSeconds,
            ref string? endpointsInputsAudioPricingCacheWriteImplicit,
            ref string? endpointsInputsAudioPricingCacheWriteUtcStart,
            ref string? endpointsInputsAudioPricingCacheWriteUtcEnd,
            ref string? endpointsInputsAudioPricingCacheWriteUtcDays,
            ref string? endpointsInputsAudioCapacityType,
            ref string? endpointsInputsAudioCapacityPromptUnit,
            ref string? endpointsInputsAudioCapacityPromptPer,
            ref string? endpointsInputsAudioCapacityPromptValue,
            ref string? endpointsInputsAudioCapacityCachedPromptUnit,
            ref string? endpointsInputsAudioCapacityCachedPromptPer,
            ref string? endpointsInputsAudioCapacityCachedPromptValue,
            ref string? endpointsInputsAudioCapacityCacheWriteUnit,
            ref string? endpointsInputsAudioCapacityCacheWritePer,
            ref string? endpointsInputsAudioCapacityCacheWriteValue,
            ref string? endpointsInputsAudioPassthroughParameters,
            ref string? endpointsInputsAudioParamsSourcesType,
            ref string? endpointsInputsAudioParamsSourcesValues,
            ref string? endpointsInputsAudioParamsFormatsType,
            ref string? endpointsInputsAudioParamsFormatsValues,
            ref string? endpointsInputsAudioParamsMaxDurationSecondsValue,
            ref string? endpointsInputsAudioParamsMaxDurationSecondsUnit,
            ref string? endpointsInputsAudioParamsMaxContentSizeBytesValue,
            ref string? endpointsInputsAudioParamsMaxContentSizeBytesUnit,
            ref string? endpointsInputsFilePricingType,
            ref string? endpointsInputsFilePricingPromptUnit,
            ref string? endpointsInputsFilePricingPromptCostUsd,
            ref string? endpointsInputsFilePricingPromptOverridesCostUsd,
            ref string? endpointsInputsFilePricingPromptUtcStart,
            ref string? endpointsInputsFilePricingPromptUtcEnd,
            ref string? endpointsInputsFilePricingPromptUtcDays,
            ref string? endpointsInputsFilePricingCachedPromptUnit,
            ref string? endpointsInputsFilePricingCachedPromptCostUsd,
            ref string? endpointsInputsFilePricingCachedPromptOverridesCostUsd,
            ref string? endpointsInputsFilePricingCachedPromptTtlSeconds,
            ref string? endpointsInputsFilePricingCachedPromptImplicit,
            ref string? endpointsInputsFilePricingCachedPromptUtcStart,
            ref string? endpointsInputsFilePricingCachedPromptUtcEnd,
            ref string? endpointsInputsFilePricingCachedPromptUtcDays,
            ref string? endpointsInputsFilePricingCacheWriteUnit,
            ref string? endpointsInputsFilePricingCacheWriteCostUsd,
            ref string? endpointsInputsFilePricingCacheWriteOverridesCostUsd,
            ref string? endpointsInputsFilePricingCacheWriteTtlSeconds,
            ref string? endpointsInputsFilePricingCacheWriteImplicit,
            ref string? endpointsInputsFilePricingCacheWriteUtcStart,
            ref string? endpointsInputsFilePricingCacheWriteUtcEnd,
            ref string? endpointsInputsFilePricingCacheWriteUtcDays,
            ref string? endpointsInputsFileCapacityType,
            ref string? endpointsInputsFileCapacityPromptUnit,
            ref string? endpointsInputsFileCapacityPromptPer,
            ref string? endpointsInputsFileCapacityPromptValue,
            ref string? endpointsInputsFileCapacityCachedPromptUnit,
            ref string? endpointsInputsFileCapacityCachedPromptPer,
            ref string? endpointsInputsFileCapacityCachedPromptValue,
            ref string? endpointsInputsFileCapacityCacheWriteUnit,
            ref string? endpointsInputsFileCapacityCacheWritePer,
            ref string? endpointsInputsFileCapacityCacheWriteValue,
            ref string? endpointsInputsFilePassthroughParameters,
            ref string? endpointsInputsFileParamsSourcesType,
            ref string? endpointsInputsFileParamsSourcesValues,
            ref string? endpointsInputsFileParamsFormatsType,
            ref string? endpointsInputsFileParamsFormatsValues,
            ref string? endpointsInputsFileParamsReferencesType,
            ref string? endpointsInputsFileParamsReferencesMin,
            ref string? endpointsInputsFileParamsReferencesMax,
            ref string? endpointsInputsFileParamsReferencesUnit,
            ref string? endpointsInputsFileParamsMaxContentSizeBytesValue,
            ref string? endpointsInputsFileParamsMaxContentSizeBytesUnit,
            ref string? endpointsOutputsType,
            ref string? endpointsOutputsTextMaxLengthValue,
            ref string? endpointsOutputsTextMaxLengthUnit,
            ref string? endpointsOutputsTextPassthroughParameters,
            ref string? endpointsOutputsTextPricingType,
            ref string? endpointsOutputsTextPricingCompletionUnit,
            ref string? endpointsOutputsTextPricingCompletionCostUsd,
            ref string? endpointsOutputsTextPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsTextPricingCompletionUtcStart,
            ref string? endpointsOutputsTextPricingCompletionUtcEnd,
            ref string? endpointsOutputsTextPricingCompletionUtcDays,
            ref string? endpointsOutputsTextPricingInternalReasoningUnit,
            ref string? endpointsOutputsTextPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsTextPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsTextPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsTextPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsTextPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsTextCapacityType,
            ref string? endpointsOutputsTextCapacityCompletionUnit,
            ref string? endpointsOutputsTextCapacityCompletionPer,
            ref string? endpointsOutputsTextCapacityCompletionValue,
            ref string? endpointsOutputsTextCapacityInternalReasoningUnit,
            ref string? endpointsOutputsTextCapacityInternalReasoningPer,
            ref string? endpointsOutputsTextCapacityInternalReasoningValue,
            ref string? endpointsOutputsTextCapacityConcurrencyUnit,
            ref string? endpointsOutputsTextCapacityConcurrencyValue,
            ref string? endpointsOutputsTextStreaming,
            ref string? endpointsOutputsTextParams,
            ref string? endpointsOutputsImagePassthroughParameters,
            ref string? endpointsOutputsImagePricingType,
            ref string? endpointsOutputsImagePricingCompletionUnit,
            ref string? endpointsOutputsImagePricingCompletionCostUsd,
            ref string? endpointsOutputsImagePricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsImagePricingCompletionUtcStart,
            ref string? endpointsOutputsImagePricingCompletionUtcEnd,
            ref string? endpointsOutputsImagePricingCompletionUtcDays,
            ref string? endpointsOutputsImagePricingInternalReasoningUnit,
            ref string? endpointsOutputsImagePricingInternalReasoningCostUsd,
            ref string? endpointsOutputsImagePricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsImagePricingInternalReasoningUtcStart,
            ref string? endpointsOutputsImagePricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsImagePricingInternalReasoningUtcDays,
            ref string? endpointsOutputsImageCapacityType,
            ref string? endpointsOutputsImageCapacityCompletionUnit,
            ref string? endpointsOutputsImageCapacityCompletionPer,
            ref string? endpointsOutputsImageCapacityCompletionValue,
            ref string? endpointsOutputsImageCapacityInternalReasoningUnit,
            ref string? endpointsOutputsImageCapacityInternalReasoningPer,
            ref string? endpointsOutputsImageCapacityInternalReasoningValue,
            ref string? endpointsOutputsImageCapacityConcurrencyUnit,
            ref string? endpointsOutputsImageCapacityConcurrencyValue,
            ref string? endpointsOutputsImageStreaming,
            ref string? endpointsOutputsImageParams,
            ref string? endpointsOutputsVideoPassthroughParameters,
            ref string? endpointsOutputsVideoPricingType,
            ref string? endpointsOutputsVideoPricingCompletionUnit,
            ref string? endpointsOutputsVideoPricingCompletionCostUsd,
            ref string? endpointsOutputsVideoPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsVideoPricingCompletionUtcStart,
            ref string? endpointsOutputsVideoPricingCompletionUtcEnd,
            ref string? endpointsOutputsVideoPricingCompletionUtcDays,
            ref string? endpointsOutputsVideoPricingInternalReasoningUnit,
            ref string? endpointsOutputsVideoPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsVideoPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsVideoPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsVideoPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsVideoCapacityType,
            ref string? endpointsOutputsVideoCapacityCompletionUnit,
            ref string? endpointsOutputsVideoCapacityCompletionPer,
            ref string? endpointsOutputsVideoCapacityCompletionValue,
            ref string? endpointsOutputsVideoCapacityInternalReasoningUnit,
            ref string? endpointsOutputsVideoCapacityInternalReasoningPer,
            ref string? endpointsOutputsVideoCapacityInternalReasoningValue,
            ref string? endpointsOutputsVideoCapacityConcurrencyUnit,
            ref string? endpointsOutputsVideoCapacityConcurrencyValue,
            ref string? endpointsOutputsVideoStreaming,
            ref string? endpointsOutputsVideoParams,
            ref string? endpointsOutputsSpeechPassthroughParameters,
            ref string? endpointsOutputsSpeechPricingType,
            ref string? endpointsOutputsSpeechPricingCompletionUnit,
            ref string? endpointsOutputsSpeechPricingCompletionCostUsd,
            ref string? endpointsOutputsSpeechPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsSpeechPricingCompletionUtcStart,
            ref string? endpointsOutputsSpeechPricingCompletionUtcEnd,
            ref string? endpointsOutputsSpeechPricingCompletionUtcDays,
            ref string? endpointsOutputsSpeechPricingInternalReasoningUnit,
            ref string? endpointsOutputsSpeechPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsSpeechPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsSpeechPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsSpeechPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsSpeechCapacityType,
            ref string? endpointsOutputsSpeechCapacityCompletionUnit,
            ref string? endpointsOutputsSpeechCapacityCompletionPer,
            ref string? endpointsOutputsSpeechCapacityCompletionValue,
            ref string? endpointsOutputsSpeechCapacityInternalReasoningUnit,
            ref string? endpointsOutputsSpeechCapacityInternalReasoningPer,
            ref string? endpointsOutputsSpeechCapacityInternalReasoningValue,
            ref string? endpointsOutputsSpeechCapacityConcurrencyUnit,
            ref string? endpointsOutputsSpeechCapacityConcurrencyValue,
            ref string? endpointsOutputsSpeechStreaming,
            ref string? endpointsOutputsSpeechParams,
            ref string? endpointsOutputsTranscriptionPassthroughParameters,
            ref string? endpointsOutputsTranscriptionPricingType,
            ref string? endpointsOutputsTranscriptionPricingCompletionUnit,
            ref string? endpointsOutputsTranscriptionPricingCompletionCostUsd,
            ref string? endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsTranscriptionPricingCompletionUtcStart,
            ref string? endpointsOutputsTranscriptionPricingCompletionUtcEnd,
            ref string? endpointsOutputsTranscriptionPricingCompletionUtcDays,
            ref string? endpointsOutputsTranscriptionPricingInternalReasoningUnit,
            ref string? endpointsOutputsTranscriptionPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsTranscriptionPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsTranscriptionPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsTranscriptionCapacityType,
            ref string? endpointsOutputsTranscriptionCapacityCompletionUnit,
            ref string? endpointsOutputsTranscriptionCapacityCompletionPer,
            ref string? endpointsOutputsTranscriptionCapacityCompletionValue,
            ref string? endpointsOutputsTranscriptionCapacityInternalReasoningUnit,
            ref string? endpointsOutputsTranscriptionCapacityInternalReasoningPer,
            ref string? endpointsOutputsTranscriptionCapacityInternalReasoningValue,
            ref string? endpointsOutputsTranscriptionCapacityConcurrencyUnit,
            ref string? endpointsOutputsTranscriptionCapacityConcurrencyValue,
            ref string? endpointsOutputsTranscriptionStreaming,
            ref string? endpointsOutputsTranscriptionParams,
            ref string? endpointsOutputsEmbeddingsPassthroughParameters,
            ref string? endpointsOutputsEmbeddingsPricingType,
            ref string? endpointsOutputsEmbeddingsPricingCompletionUnit,
            ref string? endpointsOutputsEmbeddingsPricingCompletionCostUsd,
            ref string? endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsEmbeddingsPricingCompletionUtcStart,
            ref string? endpointsOutputsEmbeddingsPricingCompletionUtcEnd,
            ref string? endpointsOutputsEmbeddingsPricingCompletionUtcDays,
            ref string? endpointsOutputsEmbeddingsPricingInternalReasoningUnit,
            ref string? endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsEmbeddingsCapacityType,
            ref string? endpointsOutputsEmbeddingsCapacityCompletionUnit,
            ref string? endpointsOutputsEmbeddingsCapacityCompletionPer,
            ref string? endpointsOutputsEmbeddingsCapacityCompletionValue,
            ref string? endpointsOutputsEmbeddingsCapacityInternalReasoningUnit,
            ref string? endpointsOutputsEmbeddingsCapacityInternalReasoningPer,
            ref string? endpointsOutputsEmbeddingsCapacityInternalReasoningValue,
            ref string? endpointsOutputsEmbeddingsCapacityConcurrencyUnit,
            ref string? endpointsOutputsEmbeddingsCapacityConcurrencyValue,
            ref string? endpointsOutputsEmbeddingsParams,
            ref string? endpointsOutputsRerankPassthroughParameters,
            ref string? endpointsOutputsRerankPricingType,
            ref string? endpointsOutputsRerankPricingCompletionUnit,
            ref string? endpointsOutputsRerankPricingCompletionCostUsd,
            ref string? endpointsOutputsRerankPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsRerankPricingCompletionUtcStart,
            ref string? endpointsOutputsRerankPricingCompletionUtcEnd,
            ref string? endpointsOutputsRerankPricingCompletionUtcDays,
            ref string? endpointsOutputsRerankPricingInternalReasoningUnit,
            ref string? endpointsOutputsRerankPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsRerankPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsRerankPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsRerankPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsRerankCapacityType,
            ref string? endpointsOutputsRerankCapacityCompletionUnit,
            ref string? endpointsOutputsRerankCapacityCompletionPer,
            ref string? endpointsOutputsRerankCapacityCompletionValue,
            ref string? endpointsOutputsRerankCapacityInternalReasoningUnit,
            ref string? endpointsOutputsRerankCapacityInternalReasoningPer,
            ref string? endpointsOutputsRerankCapacityInternalReasoningValue,
            ref string? endpointsOutputsRerankCapacityConcurrencyUnit,
            ref string? endpointsOutputsRerankCapacityConcurrencyValue,
            ref string? endpointsOutputsRerankParams,
            ref string? endpointsOutputsDecisionsPassthroughParameters,
            ref string? endpointsOutputsDecisionsPricingType,
            ref string? endpointsOutputsDecisionsPricingCompletionUnit,
            ref string? endpointsOutputsDecisionsPricingCompletionCostUsd,
            ref string? endpointsOutputsDecisionsPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsDecisionsPricingCompletionUtcStart,
            ref string? endpointsOutputsDecisionsPricingCompletionUtcEnd,
            ref string? endpointsOutputsDecisionsPricingCompletionUtcDays,
            ref string? endpointsOutputsDecisionsPricingInternalReasoningUnit,
            ref string? endpointsOutputsDecisionsPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsDecisionsPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsDecisionsPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsDecisionsPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsDecisionsCapacityType,
            ref string? endpointsOutputsDecisionsCapacityCompletionUnit,
            ref string? endpointsOutputsDecisionsCapacityCompletionPer,
            ref string? endpointsOutputsDecisionsCapacityCompletionValue,
            ref string? endpointsOutputsDecisionsCapacityInternalReasoningUnit,
            ref string? endpointsOutputsDecisionsCapacityInternalReasoningPer,
            ref string? endpointsOutputsDecisionsCapacityInternalReasoningValue,
            ref string? endpointsOutputsDecisionsCapacityConcurrencyUnit,
            ref string? endpointsOutputsDecisionsCapacityConcurrencyValue,
            ref string? endpointsOutputsDecisionsParams,
            ref string? endpointsOutputsAudioPassthroughParameters,
            ref string? endpointsOutputsAudioPricingType,
            ref string? endpointsOutputsAudioPricingCompletionUnit,
            ref string? endpointsOutputsAudioPricingCompletionCostUsd,
            ref string? endpointsOutputsAudioPricingCompletionOverridesCostUsd,
            ref string? endpointsOutputsAudioPricingCompletionUtcStart,
            ref string? endpointsOutputsAudioPricingCompletionUtcEnd,
            ref string? endpointsOutputsAudioPricingCompletionUtcDays,
            ref string? endpointsOutputsAudioPricingInternalReasoningUnit,
            ref string? endpointsOutputsAudioPricingInternalReasoningCostUsd,
            ref string? endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd,
            ref string? endpointsOutputsAudioPricingInternalReasoningUtcStart,
            ref string? endpointsOutputsAudioPricingInternalReasoningUtcEnd,
            ref string? endpointsOutputsAudioPricingInternalReasoningUtcDays,
            ref string? endpointsOutputsAudioCapacityType,
            ref string? endpointsOutputsAudioCapacityCompletionUnit,
            ref string? endpointsOutputsAudioCapacityCompletionPer,
            ref string? endpointsOutputsAudioCapacityCompletionValue,
            ref string? endpointsOutputsAudioCapacityInternalReasoningUnit,
            ref string? endpointsOutputsAudioCapacityInternalReasoningPer,
            ref string? endpointsOutputsAudioCapacityInternalReasoningValue,
            ref string? endpointsOutputsAudioCapacityConcurrencyUnit,
            ref string? endpointsOutputsAudioCapacityConcurrencyValue,
            ref string? endpointsOutputsAudioStreaming,
            ref string? endpointsOutputsAudioParams,
            ref string? endpointsProviderSlug,
            ref string? endpointsProviderTag,
            ref string? endpointsProviderName,
            ref string? endpointsDataPolicyTraining,
            ref string? endpointsDataPolicyRetainsPrompts,
            ref string? endpointsDataPolicyRetentionDays);
        partial void PrepareListV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            string? cursor,
            global::OpenRouter.ListModelsV2Region? region,
            string? sort,
            string? id,
            string? canonicalSlug,
            string? author,
            string? name,
            string? variant,
            string? kind,
            string? aliasTargetSlug,
            string? aliasTargetName,
            string? created,
            string? description,
            string? contextLength,
            string? huggingFaceId,
            string? inputs,
            string? outputs,
            string? endpointsSchemaVersion,
            string? endpointsId,
            string? endpointsHuggingFaceId,
            string? endpointsName,
            string? endpointsCreated,
            string? endpointsQuantization,
            string? endpointsTokenizer,
            string? endpointsDescription,
            string? endpointsPricingType,
            string? endpointsPricingRequestUnit,
            string? endpointsPricingRequestCostUsd,
            string? endpointsPricingRequestOverridesCostUsd,
            string? endpointsPricingWebSearchUnit,
            string? endpointsPricingWebSearchCostUsd,
            string? endpointsPricingWebSearchOverridesCostUsd,
            string? endpointsCapacityType,
            string? endpointsCapacityRequestUnit,
            string? endpointsCapacityRequestPer,
            string? endpointsCapacityRequestValue,
            string? endpointsCapacityWebSearchUnit,
            string? endpointsCapacityWebSearchPer,
            string? endpointsCapacityWebSearchValue,
            string? endpointsCapacityConcurrencyUnit,
            string? endpointsCapacityConcurrencyValue,
            string? endpointsPassthroughParameters,
            string? endpointsDeprecationDate,
            string? endpointsIsReady,
            string? endpointsIsFree,
            string? endpointsServiceTier,
            string? endpointsDiscountToUser,
            string? endpointsOpenrouterSlug,
            string? endpointsDatacentersCountryCode,
            string? endpointsDatacentersRegion,
            string? endpointsDeploymentRegion,
            string? endpointsInputsType,
            string? endpointsInputsTextPricingType,
            string? endpointsInputsTextPricingPromptUnit,
            string? endpointsInputsTextPricingPromptCostUsd,
            string? endpointsInputsTextPricingPromptOverridesCostUsd,
            string? endpointsInputsTextPricingPromptUtcStart,
            string? endpointsInputsTextPricingPromptUtcEnd,
            string? endpointsInputsTextPricingPromptUtcDays,
            string? endpointsInputsTextPricingCachedPromptUnit,
            string? endpointsInputsTextPricingCachedPromptCostUsd,
            string? endpointsInputsTextPricingCachedPromptOverridesCostUsd,
            string? endpointsInputsTextPricingCachedPromptTtlSeconds,
            string? endpointsInputsTextPricingCachedPromptImplicit,
            string? endpointsInputsTextPricingCachedPromptUtcStart,
            string? endpointsInputsTextPricingCachedPromptUtcEnd,
            string? endpointsInputsTextPricingCachedPromptUtcDays,
            string? endpointsInputsTextPricingCacheWriteUnit,
            string? endpointsInputsTextPricingCacheWriteCostUsd,
            string? endpointsInputsTextPricingCacheWriteOverridesCostUsd,
            string? endpointsInputsTextPricingCacheWriteTtlSeconds,
            string? endpointsInputsTextPricingCacheWriteImplicit,
            string? endpointsInputsTextPricingCacheWriteUtcStart,
            string? endpointsInputsTextPricingCacheWriteUtcEnd,
            string? endpointsInputsTextPricingCacheWriteUtcDays,
            string? endpointsInputsTextCapacityType,
            string? endpointsInputsTextCapacityPromptUnit,
            string? endpointsInputsTextCapacityPromptPer,
            string? endpointsInputsTextCapacityPromptValue,
            string? endpointsInputsTextCapacityCachedPromptUnit,
            string? endpointsInputsTextCapacityCachedPromptPer,
            string? endpointsInputsTextCapacityCachedPromptValue,
            string? endpointsInputsTextCapacityCacheWriteUnit,
            string? endpointsInputsTextCapacityCacheWritePer,
            string? endpointsInputsTextCapacityCacheWriteValue,
            string? endpointsInputsTextPassthroughParameters,
            string? endpointsInputsTextParamsMaxPromptLengthValue,
            string? endpointsInputsTextParamsMaxPromptLengthUnit,
            string? endpointsInputsTextParamsMaxLengthValue,
            string? endpointsInputsTextParamsMaxLengthUnit,
            string? endpointsInputsImagePricingType,
            string? endpointsInputsImagePricingPromptUnit,
            string? endpointsInputsImagePricingPromptCostUsd,
            string? endpointsInputsImagePricingPromptOverridesCostUsd,
            string? endpointsInputsImagePricingPromptUtcStart,
            string? endpointsInputsImagePricingPromptUtcEnd,
            string? endpointsInputsImagePricingPromptUtcDays,
            string? endpointsInputsImagePricingCachedPromptUnit,
            string? endpointsInputsImagePricingCachedPromptCostUsd,
            string? endpointsInputsImagePricingCachedPromptOverridesCostUsd,
            string? endpointsInputsImagePricingCachedPromptTtlSeconds,
            string? endpointsInputsImagePricingCachedPromptImplicit,
            string? endpointsInputsImagePricingCachedPromptUtcStart,
            string? endpointsInputsImagePricingCachedPromptUtcEnd,
            string? endpointsInputsImagePricingCachedPromptUtcDays,
            string? endpointsInputsImagePricingCacheWriteUnit,
            string? endpointsInputsImagePricingCacheWriteCostUsd,
            string? endpointsInputsImagePricingCacheWriteOverridesCostUsd,
            string? endpointsInputsImagePricingCacheWriteTtlSeconds,
            string? endpointsInputsImagePricingCacheWriteImplicit,
            string? endpointsInputsImagePricingCacheWriteUtcStart,
            string? endpointsInputsImagePricingCacheWriteUtcEnd,
            string? endpointsInputsImagePricingCacheWriteUtcDays,
            string? endpointsInputsImageCapacityType,
            string? endpointsInputsImageCapacityPromptUnit,
            string? endpointsInputsImageCapacityPromptPer,
            string? endpointsInputsImageCapacityPromptValue,
            string? endpointsInputsImageCapacityCachedPromptUnit,
            string? endpointsInputsImageCapacityCachedPromptPer,
            string? endpointsInputsImageCapacityCachedPromptValue,
            string? endpointsInputsImageCapacityCacheWriteUnit,
            string? endpointsInputsImageCapacityCacheWritePer,
            string? endpointsInputsImageCapacityCacheWriteValue,
            string? endpointsInputsImagePassthroughParameters,
            string? endpointsInputsImageParamsSourcesType,
            string? endpointsInputsImageParamsSourcesValues,
            string? endpointsInputsImageParamsFormatsType,
            string? endpointsInputsImageParamsFormatsValues,
            string? endpointsInputsImageParamsDetailLevelsType,
            string? endpointsInputsImageParamsDetailLevelsValues,
            string? endpointsInputsImageParamsReferencesType,
            string? endpointsInputsImageParamsReferencesMin,
            string? endpointsInputsImageParamsReferencesMax,
            string? endpointsInputsImageParamsReferencesUnit,
            string? endpointsInputsImageParamsRoleType,
            string? endpointsInputsImageParamsRoleValues,
            string? endpointsInputsImageParamsMaxContentSizeBytesValue,
            string? endpointsInputsImageParamsMaxContentSizeBytesUnit,
            string? endpointsInputsVideoPricingType,
            string? endpointsInputsVideoPricingPromptUnit,
            string? endpointsInputsVideoPricingPromptCostUsd,
            string? endpointsInputsVideoPricingPromptOverridesCostUsd,
            string? endpointsInputsVideoPricingPromptUtcStart,
            string? endpointsInputsVideoPricingPromptUtcEnd,
            string? endpointsInputsVideoPricingPromptUtcDays,
            string? endpointsInputsVideoPricingCachedPromptUnit,
            string? endpointsInputsVideoPricingCachedPromptCostUsd,
            string? endpointsInputsVideoPricingCachedPromptOverridesCostUsd,
            string? endpointsInputsVideoPricingCachedPromptTtlSeconds,
            string? endpointsInputsVideoPricingCachedPromptImplicit,
            string? endpointsInputsVideoPricingCachedPromptUtcStart,
            string? endpointsInputsVideoPricingCachedPromptUtcEnd,
            string? endpointsInputsVideoPricingCachedPromptUtcDays,
            string? endpointsInputsVideoPricingCacheWriteUnit,
            string? endpointsInputsVideoPricingCacheWriteCostUsd,
            string? endpointsInputsVideoPricingCacheWriteOverridesCostUsd,
            string? endpointsInputsVideoPricingCacheWriteTtlSeconds,
            string? endpointsInputsVideoPricingCacheWriteImplicit,
            string? endpointsInputsVideoPricingCacheWriteUtcStart,
            string? endpointsInputsVideoPricingCacheWriteUtcEnd,
            string? endpointsInputsVideoPricingCacheWriteUtcDays,
            string? endpointsInputsVideoCapacityType,
            string? endpointsInputsVideoCapacityPromptUnit,
            string? endpointsInputsVideoCapacityPromptPer,
            string? endpointsInputsVideoCapacityPromptValue,
            string? endpointsInputsVideoCapacityCachedPromptUnit,
            string? endpointsInputsVideoCapacityCachedPromptPer,
            string? endpointsInputsVideoCapacityCachedPromptValue,
            string? endpointsInputsVideoCapacityCacheWriteUnit,
            string? endpointsInputsVideoCapacityCacheWritePer,
            string? endpointsInputsVideoCapacityCacheWriteValue,
            string? endpointsInputsVideoPassthroughParameters,
            string? endpointsInputsVideoParamsSourcesType,
            string? endpointsInputsVideoParamsSourcesValues,
            string? endpointsInputsVideoParamsFormatsType,
            string? endpointsInputsVideoParamsFormatsValues,
            string? endpointsInputsVideoParamsMaxDurationSecondsValue,
            string? endpointsInputsVideoParamsMaxDurationSecondsUnit,
            string? endpointsInputsVideoParamsMaxContentSizeBytesValue,
            string? endpointsInputsVideoParamsMaxContentSizeBytesUnit,
            string? endpointsInputsAudioPricingType,
            string? endpointsInputsAudioPricingPromptUnit,
            string? endpointsInputsAudioPricingPromptCostUsd,
            string? endpointsInputsAudioPricingPromptOverridesCostUsd,
            string? endpointsInputsAudioPricingPromptUtcStart,
            string? endpointsInputsAudioPricingPromptUtcEnd,
            string? endpointsInputsAudioPricingPromptUtcDays,
            string? endpointsInputsAudioPricingCachedPromptUnit,
            string? endpointsInputsAudioPricingCachedPromptCostUsd,
            string? endpointsInputsAudioPricingCachedPromptOverridesCostUsd,
            string? endpointsInputsAudioPricingCachedPromptTtlSeconds,
            string? endpointsInputsAudioPricingCachedPromptImplicit,
            string? endpointsInputsAudioPricingCachedPromptUtcStart,
            string? endpointsInputsAudioPricingCachedPromptUtcEnd,
            string? endpointsInputsAudioPricingCachedPromptUtcDays,
            string? endpointsInputsAudioPricingCacheWriteUnit,
            string? endpointsInputsAudioPricingCacheWriteCostUsd,
            string? endpointsInputsAudioPricingCacheWriteOverridesCostUsd,
            string? endpointsInputsAudioPricingCacheWriteTtlSeconds,
            string? endpointsInputsAudioPricingCacheWriteImplicit,
            string? endpointsInputsAudioPricingCacheWriteUtcStart,
            string? endpointsInputsAudioPricingCacheWriteUtcEnd,
            string? endpointsInputsAudioPricingCacheWriteUtcDays,
            string? endpointsInputsAudioCapacityType,
            string? endpointsInputsAudioCapacityPromptUnit,
            string? endpointsInputsAudioCapacityPromptPer,
            string? endpointsInputsAudioCapacityPromptValue,
            string? endpointsInputsAudioCapacityCachedPromptUnit,
            string? endpointsInputsAudioCapacityCachedPromptPer,
            string? endpointsInputsAudioCapacityCachedPromptValue,
            string? endpointsInputsAudioCapacityCacheWriteUnit,
            string? endpointsInputsAudioCapacityCacheWritePer,
            string? endpointsInputsAudioCapacityCacheWriteValue,
            string? endpointsInputsAudioPassthroughParameters,
            string? endpointsInputsAudioParamsSourcesType,
            string? endpointsInputsAudioParamsSourcesValues,
            string? endpointsInputsAudioParamsFormatsType,
            string? endpointsInputsAudioParamsFormatsValues,
            string? endpointsInputsAudioParamsMaxDurationSecondsValue,
            string? endpointsInputsAudioParamsMaxDurationSecondsUnit,
            string? endpointsInputsAudioParamsMaxContentSizeBytesValue,
            string? endpointsInputsAudioParamsMaxContentSizeBytesUnit,
            string? endpointsInputsFilePricingType,
            string? endpointsInputsFilePricingPromptUnit,
            string? endpointsInputsFilePricingPromptCostUsd,
            string? endpointsInputsFilePricingPromptOverridesCostUsd,
            string? endpointsInputsFilePricingPromptUtcStart,
            string? endpointsInputsFilePricingPromptUtcEnd,
            string? endpointsInputsFilePricingPromptUtcDays,
            string? endpointsInputsFilePricingCachedPromptUnit,
            string? endpointsInputsFilePricingCachedPromptCostUsd,
            string? endpointsInputsFilePricingCachedPromptOverridesCostUsd,
            string? endpointsInputsFilePricingCachedPromptTtlSeconds,
            string? endpointsInputsFilePricingCachedPromptImplicit,
            string? endpointsInputsFilePricingCachedPromptUtcStart,
            string? endpointsInputsFilePricingCachedPromptUtcEnd,
            string? endpointsInputsFilePricingCachedPromptUtcDays,
            string? endpointsInputsFilePricingCacheWriteUnit,
            string? endpointsInputsFilePricingCacheWriteCostUsd,
            string? endpointsInputsFilePricingCacheWriteOverridesCostUsd,
            string? endpointsInputsFilePricingCacheWriteTtlSeconds,
            string? endpointsInputsFilePricingCacheWriteImplicit,
            string? endpointsInputsFilePricingCacheWriteUtcStart,
            string? endpointsInputsFilePricingCacheWriteUtcEnd,
            string? endpointsInputsFilePricingCacheWriteUtcDays,
            string? endpointsInputsFileCapacityType,
            string? endpointsInputsFileCapacityPromptUnit,
            string? endpointsInputsFileCapacityPromptPer,
            string? endpointsInputsFileCapacityPromptValue,
            string? endpointsInputsFileCapacityCachedPromptUnit,
            string? endpointsInputsFileCapacityCachedPromptPer,
            string? endpointsInputsFileCapacityCachedPromptValue,
            string? endpointsInputsFileCapacityCacheWriteUnit,
            string? endpointsInputsFileCapacityCacheWritePer,
            string? endpointsInputsFileCapacityCacheWriteValue,
            string? endpointsInputsFilePassthroughParameters,
            string? endpointsInputsFileParamsSourcesType,
            string? endpointsInputsFileParamsSourcesValues,
            string? endpointsInputsFileParamsFormatsType,
            string? endpointsInputsFileParamsFormatsValues,
            string? endpointsInputsFileParamsReferencesType,
            string? endpointsInputsFileParamsReferencesMin,
            string? endpointsInputsFileParamsReferencesMax,
            string? endpointsInputsFileParamsReferencesUnit,
            string? endpointsInputsFileParamsMaxContentSizeBytesValue,
            string? endpointsInputsFileParamsMaxContentSizeBytesUnit,
            string? endpointsOutputsType,
            string? endpointsOutputsTextMaxLengthValue,
            string? endpointsOutputsTextMaxLengthUnit,
            string? endpointsOutputsTextPassthroughParameters,
            string? endpointsOutputsTextPricingType,
            string? endpointsOutputsTextPricingCompletionUnit,
            string? endpointsOutputsTextPricingCompletionCostUsd,
            string? endpointsOutputsTextPricingCompletionOverridesCostUsd,
            string? endpointsOutputsTextPricingCompletionUtcStart,
            string? endpointsOutputsTextPricingCompletionUtcEnd,
            string? endpointsOutputsTextPricingCompletionUtcDays,
            string? endpointsOutputsTextPricingInternalReasoningUnit,
            string? endpointsOutputsTextPricingInternalReasoningCostUsd,
            string? endpointsOutputsTextPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsTextPricingInternalReasoningUtcStart,
            string? endpointsOutputsTextPricingInternalReasoningUtcEnd,
            string? endpointsOutputsTextPricingInternalReasoningUtcDays,
            string? endpointsOutputsTextCapacityType,
            string? endpointsOutputsTextCapacityCompletionUnit,
            string? endpointsOutputsTextCapacityCompletionPer,
            string? endpointsOutputsTextCapacityCompletionValue,
            string? endpointsOutputsTextCapacityInternalReasoningUnit,
            string? endpointsOutputsTextCapacityInternalReasoningPer,
            string? endpointsOutputsTextCapacityInternalReasoningValue,
            string? endpointsOutputsTextCapacityConcurrencyUnit,
            string? endpointsOutputsTextCapacityConcurrencyValue,
            string? endpointsOutputsTextStreaming,
            string? endpointsOutputsTextParams,
            string? endpointsOutputsImagePassthroughParameters,
            string? endpointsOutputsImagePricingType,
            string? endpointsOutputsImagePricingCompletionUnit,
            string? endpointsOutputsImagePricingCompletionCostUsd,
            string? endpointsOutputsImagePricingCompletionOverridesCostUsd,
            string? endpointsOutputsImagePricingCompletionUtcStart,
            string? endpointsOutputsImagePricingCompletionUtcEnd,
            string? endpointsOutputsImagePricingCompletionUtcDays,
            string? endpointsOutputsImagePricingInternalReasoningUnit,
            string? endpointsOutputsImagePricingInternalReasoningCostUsd,
            string? endpointsOutputsImagePricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsImagePricingInternalReasoningUtcStart,
            string? endpointsOutputsImagePricingInternalReasoningUtcEnd,
            string? endpointsOutputsImagePricingInternalReasoningUtcDays,
            string? endpointsOutputsImageCapacityType,
            string? endpointsOutputsImageCapacityCompletionUnit,
            string? endpointsOutputsImageCapacityCompletionPer,
            string? endpointsOutputsImageCapacityCompletionValue,
            string? endpointsOutputsImageCapacityInternalReasoningUnit,
            string? endpointsOutputsImageCapacityInternalReasoningPer,
            string? endpointsOutputsImageCapacityInternalReasoningValue,
            string? endpointsOutputsImageCapacityConcurrencyUnit,
            string? endpointsOutputsImageCapacityConcurrencyValue,
            string? endpointsOutputsImageStreaming,
            string? endpointsOutputsImageParams,
            string? endpointsOutputsVideoPassthroughParameters,
            string? endpointsOutputsVideoPricingType,
            string? endpointsOutputsVideoPricingCompletionUnit,
            string? endpointsOutputsVideoPricingCompletionCostUsd,
            string? endpointsOutputsVideoPricingCompletionOverridesCostUsd,
            string? endpointsOutputsVideoPricingCompletionUtcStart,
            string? endpointsOutputsVideoPricingCompletionUtcEnd,
            string? endpointsOutputsVideoPricingCompletionUtcDays,
            string? endpointsOutputsVideoPricingInternalReasoningUnit,
            string? endpointsOutputsVideoPricingInternalReasoningCostUsd,
            string? endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsVideoPricingInternalReasoningUtcStart,
            string? endpointsOutputsVideoPricingInternalReasoningUtcEnd,
            string? endpointsOutputsVideoPricingInternalReasoningUtcDays,
            string? endpointsOutputsVideoCapacityType,
            string? endpointsOutputsVideoCapacityCompletionUnit,
            string? endpointsOutputsVideoCapacityCompletionPer,
            string? endpointsOutputsVideoCapacityCompletionValue,
            string? endpointsOutputsVideoCapacityInternalReasoningUnit,
            string? endpointsOutputsVideoCapacityInternalReasoningPer,
            string? endpointsOutputsVideoCapacityInternalReasoningValue,
            string? endpointsOutputsVideoCapacityConcurrencyUnit,
            string? endpointsOutputsVideoCapacityConcurrencyValue,
            string? endpointsOutputsVideoStreaming,
            string? endpointsOutputsVideoParams,
            string? endpointsOutputsSpeechPassthroughParameters,
            string? endpointsOutputsSpeechPricingType,
            string? endpointsOutputsSpeechPricingCompletionUnit,
            string? endpointsOutputsSpeechPricingCompletionCostUsd,
            string? endpointsOutputsSpeechPricingCompletionOverridesCostUsd,
            string? endpointsOutputsSpeechPricingCompletionUtcStart,
            string? endpointsOutputsSpeechPricingCompletionUtcEnd,
            string? endpointsOutputsSpeechPricingCompletionUtcDays,
            string? endpointsOutputsSpeechPricingInternalReasoningUnit,
            string? endpointsOutputsSpeechPricingInternalReasoningCostUsd,
            string? endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcStart,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcEnd,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcDays,
            string? endpointsOutputsSpeechCapacityType,
            string? endpointsOutputsSpeechCapacityCompletionUnit,
            string? endpointsOutputsSpeechCapacityCompletionPer,
            string? endpointsOutputsSpeechCapacityCompletionValue,
            string? endpointsOutputsSpeechCapacityInternalReasoningUnit,
            string? endpointsOutputsSpeechCapacityInternalReasoningPer,
            string? endpointsOutputsSpeechCapacityInternalReasoningValue,
            string? endpointsOutputsSpeechCapacityConcurrencyUnit,
            string? endpointsOutputsSpeechCapacityConcurrencyValue,
            string? endpointsOutputsSpeechStreaming,
            string? endpointsOutputsSpeechParams,
            string? endpointsOutputsTranscriptionPassthroughParameters,
            string? endpointsOutputsTranscriptionPricingType,
            string? endpointsOutputsTranscriptionPricingCompletionUnit,
            string? endpointsOutputsTranscriptionPricingCompletionCostUsd,
            string? endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd,
            string? endpointsOutputsTranscriptionPricingCompletionUtcStart,
            string? endpointsOutputsTranscriptionPricingCompletionUtcEnd,
            string? endpointsOutputsTranscriptionPricingCompletionUtcDays,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUnit,
            string? endpointsOutputsTranscriptionPricingInternalReasoningCostUsd,
            string? endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcStart,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcDays,
            string? endpointsOutputsTranscriptionCapacityType,
            string? endpointsOutputsTranscriptionCapacityCompletionUnit,
            string? endpointsOutputsTranscriptionCapacityCompletionPer,
            string? endpointsOutputsTranscriptionCapacityCompletionValue,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningUnit,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningPer,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningValue,
            string? endpointsOutputsTranscriptionCapacityConcurrencyUnit,
            string? endpointsOutputsTranscriptionCapacityConcurrencyValue,
            string? endpointsOutputsTranscriptionStreaming,
            string? endpointsOutputsTranscriptionParams,
            string? endpointsOutputsEmbeddingsPassthroughParameters,
            string? endpointsOutputsEmbeddingsPricingType,
            string? endpointsOutputsEmbeddingsPricingCompletionUnit,
            string? endpointsOutputsEmbeddingsPricingCompletionCostUsd,
            string? endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcStart,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcEnd,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcDays,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUnit,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays,
            string? endpointsOutputsEmbeddingsCapacityType,
            string? endpointsOutputsEmbeddingsCapacityCompletionUnit,
            string? endpointsOutputsEmbeddingsCapacityCompletionPer,
            string? endpointsOutputsEmbeddingsCapacityCompletionValue,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningUnit,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningPer,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningValue,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyUnit,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyValue,
            string? endpointsOutputsEmbeddingsParams,
            string? endpointsOutputsRerankPassthroughParameters,
            string? endpointsOutputsRerankPricingType,
            string? endpointsOutputsRerankPricingCompletionUnit,
            string? endpointsOutputsRerankPricingCompletionCostUsd,
            string? endpointsOutputsRerankPricingCompletionOverridesCostUsd,
            string? endpointsOutputsRerankPricingCompletionUtcStart,
            string? endpointsOutputsRerankPricingCompletionUtcEnd,
            string? endpointsOutputsRerankPricingCompletionUtcDays,
            string? endpointsOutputsRerankPricingInternalReasoningUnit,
            string? endpointsOutputsRerankPricingInternalReasoningCostUsd,
            string? endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsRerankPricingInternalReasoningUtcStart,
            string? endpointsOutputsRerankPricingInternalReasoningUtcEnd,
            string? endpointsOutputsRerankPricingInternalReasoningUtcDays,
            string? endpointsOutputsRerankCapacityType,
            string? endpointsOutputsRerankCapacityCompletionUnit,
            string? endpointsOutputsRerankCapacityCompletionPer,
            string? endpointsOutputsRerankCapacityCompletionValue,
            string? endpointsOutputsRerankCapacityInternalReasoningUnit,
            string? endpointsOutputsRerankCapacityInternalReasoningPer,
            string? endpointsOutputsRerankCapacityInternalReasoningValue,
            string? endpointsOutputsRerankCapacityConcurrencyUnit,
            string? endpointsOutputsRerankCapacityConcurrencyValue,
            string? endpointsOutputsRerankParams,
            string? endpointsOutputsDecisionsPassthroughParameters,
            string? endpointsOutputsDecisionsPricingType,
            string? endpointsOutputsDecisionsPricingCompletionUnit,
            string? endpointsOutputsDecisionsPricingCompletionCostUsd,
            string? endpointsOutputsDecisionsPricingCompletionOverridesCostUsd,
            string? endpointsOutputsDecisionsPricingCompletionUtcStart,
            string? endpointsOutputsDecisionsPricingCompletionUtcEnd,
            string? endpointsOutputsDecisionsPricingCompletionUtcDays,
            string? endpointsOutputsDecisionsPricingInternalReasoningUnit,
            string? endpointsOutputsDecisionsPricingInternalReasoningCostUsd,
            string? endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcStart,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcEnd,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcDays,
            string? endpointsOutputsDecisionsCapacityType,
            string? endpointsOutputsDecisionsCapacityCompletionUnit,
            string? endpointsOutputsDecisionsCapacityCompletionPer,
            string? endpointsOutputsDecisionsCapacityCompletionValue,
            string? endpointsOutputsDecisionsCapacityInternalReasoningUnit,
            string? endpointsOutputsDecisionsCapacityInternalReasoningPer,
            string? endpointsOutputsDecisionsCapacityInternalReasoningValue,
            string? endpointsOutputsDecisionsCapacityConcurrencyUnit,
            string? endpointsOutputsDecisionsCapacityConcurrencyValue,
            string? endpointsOutputsDecisionsParams,
            string? endpointsOutputsAudioPassthroughParameters,
            string? endpointsOutputsAudioPricingType,
            string? endpointsOutputsAudioPricingCompletionUnit,
            string? endpointsOutputsAudioPricingCompletionCostUsd,
            string? endpointsOutputsAudioPricingCompletionOverridesCostUsd,
            string? endpointsOutputsAudioPricingCompletionUtcStart,
            string? endpointsOutputsAudioPricingCompletionUtcEnd,
            string? endpointsOutputsAudioPricingCompletionUtcDays,
            string? endpointsOutputsAudioPricingInternalReasoningUnit,
            string? endpointsOutputsAudioPricingInternalReasoningCostUsd,
            string? endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd,
            string? endpointsOutputsAudioPricingInternalReasoningUtcStart,
            string? endpointsOutputsAudioPricingInternalReasoningUtcEnd,
            string? endpointsOutputsAudioPricingInternalReasoningUtcDays,
            string? endpointsOutputsAudioCapacityType,
            string? endpointsOutputsAudioCapacityCompletionUnit,
            string? endpointsOutputsAudioCapacityCompletionPer,
            string? endpointsOutputsAudioCapacityCompletionValue,
            string? endpointsOutputsAudioCapacityInternalReasoningUnit,
            string? endpointsOutputsAudioCapacityInternalReasoningPer,
            string? endpointsOutputsAudioCapacityInternalReasoningValue,
            string? endpointsOutputsAudioCapacityConcurrencyUnit,
            string? endpointsOutputsAudioCapacityConcurrencyValue,
            string? endpointsOutputsAudioStreaming,
            string? endpointsOutputsAudioParams,
            string? endpointsProviderSlug,
            string? endpointsProviderTag,
            string? endpointsProviderName,
            string? endpointsDataPolicyTraining,
            string? endpointsDataPolicyRetainsPrompts,
            string? endpointsDataPolicyRetentionDays);
        partial void ProcessListV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List models with V2 endpoint documents<br/>
        /// Returns every publicly served model together with each of its endpoints in the Models API V2 document format. The V2 document is the schema providers publish to OpenRouter, so each endpoint is reported in the shape it was declared, with pricing attached to the modality it applies to (`inputs`/`outputs`, each with its `params`). Operator-only fields such as capacity and `discount_to_user` are not part of the public document.<br/>
        /// Without credentials the response is the public catalog. With an API key it is the catalog that key can route to, the same one `GET /api/v1/models/user` serves: models and endpoints the account was granted private access to are included, and endpoints the account or key guardrails, provider preferences, BYOK and privacy settings exclude are omitted, along with routers and aliases left with nothing to route to. A key that does not resolve is rejected with 401.<br/>
        /// Every field of the response document is a filter, named by its dotted JSON path: `&lt;path&gt;=&lt;value&gt;` tests equality and `&lt;path&gt;.&lt;operator&gt;=&lt;value&gt;` applies `gt`, `gte`, `lt`, `lte`, `between`, `in`, `exists`, `contains`, `starts_with` or `ends_with` as the field type allows; `&lt;path&gt;.not.&lt;operator&gt;=&lt;value&gt;` (or `&lt;path&gt;.not=&lt;value&gt;` for not-equal) keeps the records where no value matches. Suffixes, arithmetic operators, parentheses and the list comma are read before percent-decoding, so an encoded character is always literal: a map key spelled like an operator or `not` is reached by encoding one of its characters (`params.n%6Ft.exists=true`), a `/` or `+` inside a literal is `%2F` or `%2B`, and arithmetic is spelled with the bare characters (`created/10`, `context_length+1`). `in` takes a comma-separated list and `between` the inclusive lower and upper bound (a literal comma is `%2C`); strings compare trimmed and lower-cased on both sides, so `author=Anthropic` and `name.contains=claude` match. A filter under `endpoints.` keeps only the endpoints that satisfy every such filter and omits models left with none. A path through a repeated object is existential (`endpoints.pricing.type=request` matches an endpoint with some request-priced entry); the members of a typed collection are addressed by their type (`endpoints.inputs.text.params.max_length.value.gte=1000000`, `endpoints.inputs.text.pricing.prompt.cost_usd.lte=0.000001`), and a dynamic key is written in the path (`endpoints.outputs.text.params.tools.type=boolean`, `endpoints.outputs.text.params.temperature.range.max.gte=2`). Both sides of an operator are operands of one grammar: a literal, a path, or an arithmetic expression over numeric paths and numbers, so a filter relates any two of them (`endpoints.inputs.text.pricing.prompt.cost_usd.gte=endpoints.outputs.text.pricing.completion.cost_usd*100`, `10000.lte=endpoints.inputs.text.params.max_length.value`, `endpoints.id=id`). Arithmetic requires numeric paths, each operator applies to the type its operands share, and text that names no field path is a literal (`id=openai/gpt-4`), so the field names at the root of the document are reserved words. A parameter that is not a field path is rejected with a 400 whose `error.metadata` names the `code`, `parameter` and `reason`.<br/>
        /// `sort` takes comma-separated paths or expressions, `-` prefixed for descending; a key must be a scalar path or expression (`created`, `endpoints.inputs.text.pricing.prompt.cost_usd`); a model sorts by the best value in the sort direction across its endpoints and across the time windows of a price, missing values sort last and `id` ascending breaks ties, so the order is total even without `sort`. Pagination is opt-in: pass `limit` and follow `links.next`, which carries an opaque `cursor` bound to the filters and sort; `offset` remains supported. `total_count` is the number of models matching the filters.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip (0 when omitted); kept for compatibility, prefer `cursor`. Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (500 when omitted, max 1000). Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 500
        /// </param>
        /// <param name="cursor">
        /// Opaque keyset cursor from the previous page's `links.next`. Bound to the filters and sort it was issued for; a cursor sent with different filters or sort is rejected.<br/>
        /// Example: eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ
        /// </param>
        /// <param name="region">
        /// Only return endpoints in the given data region ("eu" or "us"); models left without an endpoint are omitted.<br/>
        /// Example: eu
        /// </param>
        /// <param name="sort">
        /// Comma-separated sort keys, each a path below or an arithmetic expression over numeric paths; prefix with `-` for descending. A key under `endpoints.` ranks each model by its best endpoint value in the sort direction. Missing values sort last and `id` ascending breaks ties. Keys: `id`, `canonical_slug`, `author`, `name`, `variant`, `kind`, `alias_target.slug`, `alias_target.name`, `created`, `description`, `context_length`, `hugging_face_id`, `endpoints.schema_version`, `endpoints.id`, `endpoints.hugging_face_id`, `endpoints.name`, `endpoints.created`, `endpoints.quantization`, `endpoints.tokenizer`, `endpoints.description`, `endpoints.pricing.request.unit`, `endpoints.pricing.request.cost_usd`, `endpoints.pricing.web_search.unit`, `endpoints.pricing.web_search.cost_usd`, `endpoints.capacity.request.unit`, `endpoints.capacity.request.per`, `endpoints.capacity.request.value`, `endpoints.capacity.web_search.unit`, `endpoints.capacity.web_search.per`, `endpoints.capacity.web_search.value`, `endpoints.capacity.concurrency.unit`, `endpoints.capacity.concurrency.value`, `endpoints.deprecation_date`, `endpoints.is_ready`, `endpoints.is_free`, `endpoints.service_tier`, `endpoints.discount_to_user`, `endpoints.openrouter.slug`, `endpoints.deployment_region`, `endpoints.inputs.text.pricing.prompt.unit`, `endpoints.inputs.text.pricing.prompt.cost_usd`, `endpoints.inputs.text.pricing.prompt.utc_start`, `endpoints.inputs.text.pricing.prompt.utc_end`, `endpoints.inputs.text.pricing.cached_prompt.unit`, `endpoints.inputs.text.pricing.cached_prompt.cost_usd`, `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.text.pricing.cached_prompt.implicit`, `endpoints.inputs.text.pricing.cached_prompt.utc_start`, `endpoints.inputs.text.pricing.cached_prompt.utc_end`, `endpoints.inputs.text.pricing.cache_write.unit`, `endpoints.inputs.text.pricing.cache_write.cost_usd`, `endpoints.inputs.text.pricing.cache_write.ttl_seconds`, `endpoints.inputs.text.pricing.cache_write.implicit`, `endpoints.inputs.text.pricing.cache_write.utc_start`, `endpoints.inputs.text.pricing.cache_write.utc_end`, `endpoints.inputs.text.capacity.prompt.unit`, `endpoints.inputs.text.capacity.prompt.per`, `endpoints.inputs.text.capacity.prompt.value`, `endpoints.inputs.text.capacity.cached_prompt.unit`, `endpoints.inputs.text.capacity.cached_prompt.per`, `endpoints.inputs.text.capacity.cached_prompt.value`, `endpoints.inputs.text.capacity.cache_write.unit`, `endpoints.inputs.text.capacity.cache_write.per`, `endpoints.inputs.text.capacity.cache_write.value`, `endpoints.inputs.text.params.max_prompt_length.value`, `endpoints.inputs.text.params.max_prompt_length.unit`, `endpoints.inputs.text.params.max_length.value`, `endpoints.inputs.text.params.max_length.unit`, `endpoints.inputs.image.pricing.prompt.unit`, `endpoints.inputs.image.pricing.prompt.cost_usd`, `endpoints.inputs.image.pricing.prompt.utc_start`, `endpoints.inputs.image.pricing.prompt.utc_end`, `endpoints.inputs.image.pricing.cached_prompt.unit`, `endpoints.inputs.image.pricing.cached_prompt.cost_usd`, `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.image.pricing.cached_prompt.implicit`, `endpoints.inputs.image.pricing.cached_prompt.utc_start`, `endpoints.inputs.image.pricing.cached_prompt.utc_end`, `endpoints.inputs.image.pricing.cache_write.unit`, `endpoints.inputs.image.pricing.cache_write.cost_usd`, `endpoints.inputs.image.pricing.cache_write.ttl_seconds`, `endpoints.inputs.image.pricing.cache_write.implicit`, `endpoints.inputs.image.pricing.cache_write.utc_start`, `endpoints.inputs.image.pricing.cache_write.utc_end`, `endpoints.inputs.image.capacity.prompt.unit`, `endpoints.inputs.image.capacity.prompt.per`, `endpoints.inputs.image.capacity.prompt.value`, `endpoints.inputs.image.capacity.cached_prompt.unit`, `endpoints.inputs.image.capacity.cached_prompt.per`, `endpoints.inputs.image.capacity.cached_prompt.value`, `endpoints.inputs.image.capacity.cache_write.unit`, `endpoints.inputs.image.capacity.cache_write.per`, `endpoints.inputs.image.capacity.cache_write.value`, `endpoints.inputs.image.params.sources.type`, `endpoints.inputs.image.params.formats.type`, `endpoints.inputs.image.params.detail_levels.type`, `endpoints.inputs.image.params.references.type`, `endpoints.inputs.image.params.references.min`, `endpoints.inputs.image.params.references.max`, `endpoints.inputs.image.params.references.unit`, `endpoints.inputs.image.params.role.type`, `endpoints.inputs.image.params.max_content_size_bytes.value`, `endpoints.inputs.image.params.max_content_size_bytes.unit`, `endpoints.inputs.video.pricing.prompt.unit`, `endpoints.inputs.video.pricing.prompt.cost_usd`, `endpoints.inputs.video.pricing.prompt.utc_start`, `endpoints.inputs.video.pricing.prompt.utc_end`, `endpoints.inputs.video.pricing.cached_prompt.unit`, `endpoints.inputs.video.pricing.cached_prompt.cost_usd`, `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.video.pricing.cached_prompt.implicit`, `endpoints.inputs.video.pricing.cached_prompt.utc_start`, `endpoints.inputs.video.pricing.cached_prompt.utc_end`, `endpoints.inputs.video.pricing.cache_write.unit`, `endpoints.inputs.video.pricing.cache_write.cost_usd`, `endpoints.inputs.video.pricing.cache_write.ttl_seconds`, `endpoints.inputs.video.pricing.cache_write.implicit`, `endpoints.inputs.video.pricing.cache_write.utc_start`, `endpoints.inputs.video.pricing.cache_write.utc_end`, `endpoints.inputs.video.capacity.prompt.unit`, `endpoints.inputs.video.capacity.prompt.per`, `endpoints.inputs.video.capacity.prompt.value`, `endpoints.inputs.video.capacity.cached_prompt.unit`, `endpoints.inputs.video.capacity.cached_prompt.per`, `endpoints.inputs.video.capacity.cached_prompt.value`, `endpoints.inputs.video.capacity.cache_write.unit`, `endpoints.inputs.video.capacity.cache_write.per`, `endpoints.inputs.video.capacity.cache_write.value`, `endpoints.inputs.video.params.sources.type`, `endpoints.inputs.video.params.formats.type`, `endpoints.inputs.video.params.max_duration_seconds.value`, `endpoints.inputs.video.params.max_duration_seconds.unit`, `endpoints.inputs.video.params.max_content_size_bytes.value`, `endpoints.inputs.video.params.max_content_size_bytes.unit`, `endpoints.inputs.audio.pricing.prompt.unit`, `endpoints.inputs.audio.pricing.prompt.cost_usd`, `endpoints.inputs.audio.pricing.prompt.utc_start`, `endpoints.inputs.audio.pricing.prompt.utc_end`, `endpoints.inputs.audio.pricing.cached_prompt.unit`, `endpoints.inputs.audio.pricing.cached_prompt.cost_usd`, `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.audio.pricing.cached_prompt.implicit`, `endpoints.inputs.audio.pricing.cached_prompt.utc_start`, `endpoints.inputs.audio.pricing.cached_prompt.utc_end`, `endpoints.inputs.audio.pricing.cache_write.unit`, `endpoints.inputs.audio.pricing.cache_write.cost_usd`, `endpoints.inputs.audio.pricing.cache_write.ttl_seconds`, `endpoints.inputs.audio.pricing.cache_write.implicit`, `endpoints.inputs.audio.pricing.cache_write.utc_start`, `endpoints.inputs.audio.pricing.cache_write.utc_end`, `endpoints.inputs.audio.capacity.prompt.unit`, `endpoints.inputs.audio.capacity.prompt.per`, `endpoints.inputs.audio.capacity.prompt.value`, `endpoints.inputs.audio.capacity.cached_prompt.unit`, `endpoints.inputs.audio.capacity.cached_prompt.per`, `endpoints.inputs.audio.capacity.cached_prompt.value`, `endpoints.inputs.audio.capacity.cache_write.unit`, `endpoints.inputs.audio.capacity.cache_write.per`, `endpoints.inputs.audio.capacity.cache_write.value`, `endpoints.inputs.audio.params.sources.type`, `endpoints.inputs.audio.params.formats.type`, `endpoints.inputs.audio.params.max_duration_seconds.value`, `endpoints.inputs.audio.params.max_duration_seconds.unit`, `endpoints.inputs.audio.params.max_content_size_bytes.value`, `endpoints.inputs.audio.params.max_content_size_bytes.unit`, `endpoints.inputs.file.pricing.prompt.unit`, `endpoints.inputs.file.pricing.prompt.cost_usd`, `endpoints.inputs.file.pricing.prompt.utc_start`, `endpoints.inputs.file.pricing.prompt.utc_end`, `endpoints.inputs.file.pricing.cached_prompt.unit`, `endpoints.inputs.file.pricing.cached_prompt.cost_usd`, `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.file.pricing.cached_prompt.implicit`, `endpoints.inputs.file.pricing.cached_prompt.utc_start`, `endpoints.inputs.file.pricing.cached_prompt.utc_end`, `endpoints.inputs.file.pricing.cache_write.unit`, `endpoints.inputs.file.pricing.cache_write.cost_usd`, `endpoints.inputs.file.pricing.cache_write.ttl_seconds`, `endpoints.inputs.file.pricing.cache_write.implicit`, `endpoints.inputs.file.pricing.cache_write.utc_start`, `endpoints.inputs.file.pricing.cache_write.utc_end`, `endpoints.inputs.file.capacity.prompt.unit`, `endpoints.inputs.file.capacity.prompt.per`, `endpoints.inputs.file.capacity.prompt.value`, `endpoints.inputs.file.capacity.cached_prompt.unit`, `endpoints.inputs.file.capacity.cached_prompt.per`, `endpoints.inputs.file.capacity.cached_prompt.value`, `endpoints.inputs.file.capacity.cache_write.unit`, `endpoints.inputs.file.capacity.cache_write.per`, `endpoints.inputs.file.capacity.cache_write.value`, `endpoints.inputs.file.params.sources.type`, `endpoints.inputs.file.params.formats.type`, `endpoints.inputs.file.params.references.type`, `endpoints.inputs.file.params.references.min`, `endpoints.inputs.file.params.references.max`, `endpoints.inputs.file.params.references.unit`, `endpoints.inputs.file.params.max_content_size_bytes.value`, `endpoints.inputs.file.params.max_content_size_bytes.unit`, `endpoints.outputs.text.max_length.value`, `endpoints.outputs.text.max_length.unit`, `endpoints.outputs.text.pricing.completion.unit`, `endpoints.outputs.text.pricing.completion.cost_usd`, `endpoints.outputs.text.pricing.completion.utc_start`, `endpoints.outputs.text.pricing.completion.utc_end`, `endpoints.outputs.text.pricing.internal_reasoning.unit`, `endpoints.outputs.text.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.text.pricing.internal_reasoning.utc_start`, `endpoints.outputs.text.pricing.internal_reasoning.utc_end`, `endpoints.outputs.text.capacity.completion.unit`, `endpoints.outputs.text.capacity.completion.per`, `endpoints.outputs.text.capacity.completion.value`, `endpoints.outputs.text.capacity.internal_reasoning.unit`, `endpoints.outputs.text.capacity.internal_reasoning.per`, `endpoints.outputs.text.capacity.internal_reasoning.value`, `endpoints.outputs.text.capacity.concurrency.unit`, `endpoints.outputs.text.capacity.concurrency.value`, `endpoints.outputs.text.streaming`, `endpoints.outputs.image.pricing.completion.unit`, `endpoints.outputs.image.pricing.completion.cost_usd`, `endpoints.outputs.image.pricing.completion.utc_start`, `endpoints.outputs.image.pricing.completion.utc_end`, `endpoints.outputs.image.pricing.internal_reasoning.unit`, `endpoints.outputs.image.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.image.pricing.internal_reasoning.utc_start`, `endpoints.outputs.image.pricing.internal_reasoning.utc_end`, `endpoints.outputs.image.capacity.completion.unit`, `endpoints.outputs.image.capacity.completion.per`, `endpoints.outputs.image.capacity.completion.value`, `endpoints.outputs.image.capacity.internal_reasoning.unit`, `endpoints.outputs.image.capacity.internal_reasoning.per`, `endpoints.outputs.image.capacity.internal_reasoning.value`, `endpoints.outputs.image.capacity.concurrency.unit`, `endpoints.outputs.image.capacity.concurrency.value`, `endpoints.outputs.image.streaming`, `endpoints.outputs.video.pricing.completion.unit`, `endpoints.outputs.video.pricing.completion.cost_usd`, `endpoints.outputs.video.pricing.completion.utc_start`, `endpoints.outputs.video.pricing.completion.utc_end`, `endpoints.outputs.video.pricing.internal_reasoning.unit`, `endpoints.outputs.video.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.video.pricing.internal_reasoning.utc_start`, `endpoints.outputs.video.pricing.internal_reasoning.utc_end`, `endpoints.outputs.video.capacity.completion.unit`, `endpoints.outputs.video.capacity.completion.per`, `endpoints.outputs.video.capacity.completion.value`, `endpoints.outputs.video.capacity.internal_reasoning.unit`, `endpoints.outputs.video.capacity.internal_reasoning.per`, `endpoints.outputs.video.capacity.internal_reasoning.value`, `endpoints.outputs.video.capacity.concurrency.unit`, `endpoints.outputs.video.capacity.concurrency.value`, `endpoints.outputs.video.streaming`, `endpoints.outputs.speech.pricing.completion.unit`, `endpoints.outputs.speech.pricing.completion.cost_usd`, `endpoints.outputs.speech.pricing.completion.utc_start`, `endpoints.outputs.speech.pricing.completion.utc_end`, `endpoints.outputs.speech.pricing.internal_reasoning.unit`, `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_start`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_end`, `endpoints.outputs.speech.capacity.completion.unit`, `endpoints.outputs.speech.capacity.completion.per`, `endpoints.outputs.speech.capacity.completion.value`, `endpoints.outputs.speech.capacity.internal_reasoning.unit`, `endpoints.outputs.speech.capacity.internal_reasoning.per`, `endpoints.outputs.speech.capacity.internal_reasoning.value`, `endpoints.outputs.speech.capacity.concurrency.unit`, `endpoints.outputs.speech.capacity.concurrency.value`, `endpoints.outputs.speech.streaming`, `endpoints.outputs.transcription.pricing.completion.unit`, `endpoints.outputs.transcription.pricing.completion.cost_usd`, `endpoints.outputs.transcription.pricing.completion.utc_start`, `endpoints.outputs.transcription.pricing.completion.utc_end`, `endpoints.outputs.transcription.pricing.internal_reasoning.unit`, `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end`, `endpoints.outputs.transcription.capacity.completion.unit`, `endpoints.outputs.transcription.capacity.completion.per`, `endpoints.outputs.transcription.capacity.completion.value`, `endpoints.outputs.transcription.capacity.internal_reasoning.unit`, `endpoints.outputs.transcription.capacity.internal_reasoning.per`, `endpoints.outputs.transcription.capacity.internal_reasoning.value`, `endpoints.outputs.transcription.capacity.concurrency.unit`, `endpoints.outputs.transcription.capacity.concurrency.value`, `endpoints.outputs.transcription.streaming`, `endpoints.outputs.embeddings.pricing.completion.unit`, `endpoints.outputs.embeddings.pricing.completion.cost_usd`, `endpoints.outputs.embeddings.pricing.completion.utc_start`, `endpoints.outputs.embeddings.pricing.completion.utc_end`, `endpoints.outputs.embeddings.pricing.internal_reasoning.unit`, `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end`, `endpoints.outputs.embeddings.capacity.completion.unit`, `endpoints.outputs.embeddings.capacity.completion.per`, `endpoints.outputs.embeddings.capacity.completion.value`, `endpoints.outputs.embeddings.capacity.internal_reasoning.unit`, `endpoints.outputs.embeddings.capacity.internal_reasoning.per`, `endpoints.outputs.embeddings.capacity.internal_reasoning.value`, `endpoints.outputs.embeddings.capacity.concurrency.unit`, `endpoints.outputs.embeddings.capacity.concurrency.value`, `endpoints.outputs.rerank.pricing.completion.unit`, `endpoints.outputs.rerank.pricing.completion.cost_usd`, `endpoints.outputs.rerank.pricing.completion.utc_start`, `endpoints.outputs.rerank.pricing.completion.utc_end`, `endpoints.outputs.rerank.pricing.internal_reasoning.unit`, `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end`, `endpoints.outputs.rerank.capacity.completion.unit`, `endpoints.outputs.rerank.capacity.completion.per`, `endpoints.outputs.rerank.capacity.completion.value`, `endpoints.outputs.rerank.capacity.internal_reasoning.unit`, `endpoints.outputs.rerank.capacity.internal_reasoning.per`, `endpoints.outputs.rerank.capacity.internal_reasoning.value`, `endpoints.outputs.rerank.capacity.concurrency.unit`, `endpoints.outputs.rerank.capacity.concurrency.value`, `endpoints.outputs.decisions.pricing.completion.unit`, `endpoints.outputs.decisions.pricing.completion.cost_usd`, `endpoints.outputs.decisions.pricing.completion.utc_start`, `endpoints.outputs.decisions.pricing.completion.utc_end`, `endpoints.outputs.decisions.pricing.internal_reasoning.unit`, `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end`, `endpoints.outputs.decisions.capacity.completion.unit`, `endpoints.outputs.decisions.capacity.completion.per`, `endpoints.outputs.decisions.capacity.completion.value`, `endpoints.outputs.decisions.capacity.internal_reasoning.unit`, `endpoints.outputs.decisions.capacity.internal_reasoning.per`, `endpoints.outputs.decisions.capacity.internal_reasoning.value`, `endpoints.outputs.decisions.capacity.concurrency.unit`, `endpoints.outputs.decisions.capacity.concurrency.value`, `endpoints.outputs.audio.pricing.completion.unit`, `endpoints.outputs.audio.pricing.completion.cost_usd`, `endpoints.outputs.audio.pricing.completion.utc_start`, `endpoints.outputs.audio.pricing.completion.utc_end`, `endpoints.outputs.audio.pricing.internal_reasoning.unit`, `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_start`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_end`, `endpoints.outputs.audio.capacity.completion.unit`, `endpoints.outputs.audio.capacity.completion.per`, `endpoints.outputs.audio.capacity.completion.value`, `endpoints.outputs.audio.capacity.internal_reasoning.unit`, `endpoints.outputs.audio.capacity.internal_reasoning.per`, `endpoints.outputs.audio.capacity.internal_reasoning.value`, `endpoints.outputs.audio.capacity.concurrency.unit`, `endpoints.outputs.audio.capacity.concurrency.value`, `endpoints.outputs.audio.streaming`, `endpoints.provider.slug`, `endpoints.provider.tag`, `endpoints.provider.name`, `endpoints.data_policy.training`, `endpoints.data_policy.retains_prompts`, `endpoints.data_policy.retention_days`.<br/>
        /// Example: -created,endpoints.inputs.text.pricing.prompt.cost_usd
        /// </param>
        /// <param name="id">
        /// Filter where the value at `id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="canonicalSlug">
        /// Filter where the value at `canonical_slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="author">
        /// Filter where the value at `author` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="name">
        /// Filter where the value at `name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="variant">
        /// Filter where the value at `variant` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `free`, `extended`, `standard`, `thinking`, `batch`.
        /// </param>
        /// <param name="kind">
        /// Filter where the value at `kind` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `model`, `router`, `alias`.
        /// </param>
        /// <param name="aliasTargetSlug">
        /// Filter where the value at `alias_target.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="aliasTargetName">
        /// Filter where the value at `alias_target.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="created">
        /// Filter where the value at `created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="description">
        /// Filter where the value at `description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="contextLength">
        /// Filter where the value at `context_length` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="huggingFaceId">
        /// Filter where the value at `hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="inputs">
        /// Filter where any element at `inputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `file`, `audio`, `video`.
        /// </param>
        /// <param name="outputs">
        /// Filter where any element at `outputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `embeddings`, `audio`, `video`, `rerank`, `decisions`, `speech`, `transcription`.
        /// </param>
        /// <param name="endpointsSchemaVersion">
        /// Filter where the value at `endpoints.schema_version` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsId">
        /// Filter where the value at `endpoints.id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsHuggingFaceId">
        /// Filter where the value at `endpoints.hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsName">
        /// Filter where the value at `endpoints.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCreated">
        /// Filter where the value at `endpoints.created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsQuantization">
        /// Filter where the value at `endpoints.quantization` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `int4`, `int8`, `fp4`, `mxfp4`, `nvfp4`, `fp6`, `fp8`, `mxfp8`, `fp16`, `bf16`, `fp32`.
        /// </param>
        /// <param name="endpointsTokenizer">
        /// Filter where the value at `endpoints.tokenizer` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDescription">
        /// Filter where the value at `endpoints.description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingType">
        /// Filter where any value at `endpoints.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`.
        /// </param>
        /// <param name="endpointsPricingRequestUnit">
        /// Filter where the value at `endpoints.pricing.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsPricingRequestCostUsd">
        /// Filter where the value at `endpoints.pricing.request.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingRequestOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.request.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchUnit">
        /// Filter where the value at `endpoints.pricing.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsPricingWebSearchCostUsd">
        /// Filter where the value at `endpoints.pricing.web_search.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.web_search.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityType">
        /// Filter where any value at `endpoints.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`, `concurrency`.
        /// </param>
        /// <param name="endpointsCapacityRequestUnit">
        /// Filter where the value at `endpoints.capacity.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityRequestPer">
        /// Filter where the value at `endpoints.capacity.request.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityRequestValue">
        /// Filter where the value at `endpoints.capacity.request.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityWebSearchUnit">
        /// Filter where the value at `endpoints.capacity.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchPer">
        /// Filter where the value at `endpoints.capacity.web_search.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchValue">
        /// Filter where the value at `endpoints.capacity.web_search.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPassthroughParameters">
        /// Filter on the entries of `endpoints.passthrough_parameters`: `endpoints.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.passthrough_parameters.&lt;key&gt;.type`, `endpoints.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsDeprecationDate">
        /// Filter where the value at `endpoints.deprecation_date` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsReady">
        /// Filter where the value at `endpoints.is_ready` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsFree">
        /// Filter where the value at `endpoints.is_free` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsServiceTier">
        /// Filter where the value at `endpoints.service_tier` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `flex`, `priority`, `ultrafast`, `fast`.
        /// </param>
        /// <param name="endpointsDiscountToUser">
        /// Filter where the value at `endpoints.discount_to_user` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOpenrouterSlug">
        /// Filter where the value at `endpoints.openrouter.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersCountryCode">
        /// Filter where any value at `endpoints.datacenters.country_code` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersRegion">
        /// Filter where any value at `endpoints.datacenters.region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDeploymentRegion">
        /// Filter where the value at `endpoints.deployment_region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsType">
        /// Filter where any value at `endpoints.inputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `audio`, `file`.
        /// </param>
        /// <param name="endpointsInputsTextPricingType">
        /// Filter where any value at `endpoints.inputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityType">
        /// Filter where any value at `endpoints.inputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.text.passthrough_parameters`: `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingType">
        /// Filter where any value at `endpoints.inputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityType">
        /// Filter where any value at `endpoints.inputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.image.passthrough_parameters`: `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.image.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.image.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.image.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.image.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `image/png`, `image/jpeg`, `image/webp`, `image/gif`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsType">
        /// Filter where the value at `endpoints.inputs.image.params.detail_levels.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsValues">
        /// Filter where any element at `endpoints.inputs.image.params.detail_levels.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `auto`, `low`, `high`, `original`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.image.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.image.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.image.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleType">
        /// Filter where the value at `endpoints.inputs.image.params.role.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleValues">
        /// Filter where any element at `endpoints.inputs.image.params.role.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `reference`, `first_frame`, `last_frame`.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingType">
        /// Filter where any value at `endpoints.inputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityType">
        /// Filter where any value at `endpoints.inputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.video.passthrough_parameters`: `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.video.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.video.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.video.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.video.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `video/mp4`, `video/webm`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingType">
        /// Filter where any value at `endpoints.inputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityType">
        /// Filter where any value at `endpoints.inputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.audio.passthrough_parameters`: `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.audio.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.audio.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.audio.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.audio.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `audio/wav`, `audio/mpeg`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingType">
        /// Filter where any value at `endpoints.inputs.file.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityType">
        /// Filter where any value at `endpoints.inputs.file.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.file.passthrough_parameters`: `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.file.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.file.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.file.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.file.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `application/pdf`, `text/plain`, `text/markdown`, `text/html`, `text/csv`, `application/json`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.file.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.file.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.file.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsType">
        /// Filter where any value at `endpoints.outputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `speech`, `transcription`, `embeddings`, `rerank`, `decisions`, `audio`.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthValue">
        /// Filter where the value at `endpoints.outputs.text.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthUnit">
        /// Filter where the value at `endpoints.outputs.text.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.text.passthrough_parameters`: `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTextPricingType">
        /// Filter where any value at `endpoints.outputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityType">
        /// Filter where any value at `endpoints.outputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextStreaming">
        /// Filter where the value at `endpoints.outputs.text.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextParams">
        /// Filter on the entries of `endpoints.outputs.text.params`: `endpoints.outputs.text.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.params.&lt;key&gt;.type`, `endpoints.outputs.text.params.&lt;key&gt;.range.min`, `endpoints.outputs.text.params.&lt;key&gt;.range.max`, `endpoints.outputs.text.params.&lt;key&gt;.range.default`, `endpoints.outputs.text.params.&lt;key&gt;.range.values`, `endpoints.outputs.text.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.image.passthrough_parameters`: `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePricingType">
        /// Filter where any value at `endpoints.outputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityType">
        /// Filter where any value at `endpoints.outputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageStreaming">
        /// Filter where the value at `endpoints.outputs.image.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageParams">
        /// Filter on the entries of `endpoints.outputs.image.params`: `endpoints.outputs.image.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.params.&lt;key&gt;.type`, `endpoints.outputs.image.params.&lt;key&gt;.range.min`, `endpoints.outputs.image.params.&lt;key&gt;.range.max`, `endpoints.outputs.image.params.&lt;key&gt;.range.default`, `endpoints.outputs.image.params.&lt;key&gt;.range.values`, `endpoints.outputs.image.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.video.passthrough_parameters`: `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingType">
        /// Filter where any value at `endpoints.outputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityType">
        /// Filter where any value at `endpoints.outputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoStreaming">
        /// Filter where the value at `endpoints.outputs.video.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoParams">
        /// Filter on the entries of `endpoints.outputs.video.params`: `endpoints.outputs.video.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.params.&lt;key&gt;.type`, `endpoints.outputs.video.params.&lt;key&gt;.range.min`, `endpoints.outputs.video.params.&lt;key&gt;.range.max`, `endpoints.outputs.video.params.&lt;key&gt;.range.default`, `endpoints.outputs.video.params.&lt;key&gt;.range.values`, `endpoints.outputs.video.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.speech.passthrough_parameters`: `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingType">
        /// Filter where any value at `endpoints.outputs.speech.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityType">
        /// Filter where any value at `endpoints.outputs.speech.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechStreaming">
        /// Filter where the value at `endpoints.outputs.speech.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechParams">
        /// Filter on the entries of `endpoints.outputs.speech.params`: `endpoints.outputs.speech.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.params.&lt;key&gt;.type`, `endpoints.outputs.speech.params.&lt;key&gt;.range.min`, `endpoints.outputs.speech.params.&lt;key&gt;.range.max`, `endpoints.outputs.speech.params.&lt;key&gt;.range.default`, `endpoints.outputs.speech.params.&lt;key&gt;.range.values`, `endpoints.outputs.speech.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.transcription.passthrough_parameters`: `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingType">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityType">
        /// Filter where any value at `endpoints.outputs.transcription.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionStreaming">
        /// Filter where the value at `endpoints.outputs.transcription.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionParams">
        /// Filter on the entries of `endpoints.outputs.transcription.params`: `endpoints.outputs.transcription.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.params.&lt;key&gt;.type`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.embeddings.passthrough_parameters`: `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingType">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityType">
        /// Filter where any value at `endpoints.outputs.embeddings.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsParams">
        /// Filter on the entries of `endpoints.outputs.embeddings.params`: `endpoints.outputs.embeddings.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.params.&lt;key&gt;.type`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.rerank.passthrough_parameters`: `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingType">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityType">
        /// Filter where any value at `endpoints.outputs.rerank.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankParams">
        /// Filter on the entries of `endpoints.outputs.rerank.params`: `endpoints.outputs.rerank.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.params.&lt;key&gt;.type`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.decisions.passthrough_parameters`: `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingType">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityType">
        /// Filter where any value at `endpoints.outputs.decisions.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsParams">
        /// Filter on the entries of `endpoints.outputs.decisions.params`: `endpoints.outputs.decisions.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.params.&lt;key&gt;.type`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.audio.passthrough_parameters`: `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingType">
        /// Filter where any value at `endpoints.outputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityType">
        /// Filter where any value at `endpoints.outputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioStreaming">
        /// Filter where the value at `endpoints.outputs.audio.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioParams">
        /// Filter on the entries of `endpoints.outputs.audio.params`: `endpoints.outputs.audio.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.params.&lt;key&gt;.type`, `endpoints.outputs.audio.params.&lt;key&gt;.range.min`, `endpoints.outputs.audio.params.&lt;key&gt;.range.max`, `endpoints.outputs.audio.params.&lt;key&gt;.range.default`, `endpoints.outputs.audio.params.&lt;key&gt;.range.values`, `endpoints.outputs.audio.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsProviderSlug">
        /// Filter where the value at `endpoints.provider.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderTag">
        /// Filter where the value at `endpoints.provider.tag` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderName">
        /// Filter where the value at `endpoints.provider.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyTraining">
        /// Filter where the value at `endpoints.data_policy.training` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetainsPrompts">
        /// Filter where the value at `endpoints.data_policy.retains_prompts` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetentionDays">
        /// Filter where the value at `endpoints.data_policy.retention_days` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.ModelsV2ListResponse> ListV2Async(
            int? offset = default,
            int? limit = default,
            string? cursor = default,
            global::OpenRouter.ListModelsV2Region? region = default,
            string? sort = default,
            string? id = default,
            string? canonicalSlug = default,
            string? author = default,
            string? name = default,
            string? variant = default,
            string? kind = default,
            string? aliasTargetSlug = default,
            string? aliasTargetName = default,
            string? created = default,
            string? description = default,
            string? contextLength = default,
            string? huggingFaceId = default,
            string? inputs = default,
            string? outputs = default,
            string? endpointsSchemaVersion = default,
            string? endpointsId = default,
            string? endpointsHuggingFaceId = default,
            string? endpointsName = default,
            string? endpointsCreated = default,
            string? endpointsQuantization = default,
            string? endpointsTokenizer = default,
            string? endpointsDescription = default,
            string? endpointsPricingType = default,
            string? endpointsPricingRequestUnit = default,
            string? endpointsPricingRequestCostUsd = default,
            string? endpointsPricingRequestOverridesCostUsd = default,
            string? endpointsPricingWebSearchUnit = default,
            string? endpointsPricingWebSearchCostUsd = default,
            string? endpointsPricingWebSearchOverridesCostUsd = default,
            string? endpointsCapacityType = default,
            string? endpointsCapacityRequestUnit = default,
            string? endpointsCapacityRequestPer = default,
            string? endpointsCapacityRequestValue = default,
            string? endpointsCapacityWebSearchUnit = default,
            string? endpointsCapacityWebSearchPer = default,
            string? endpointsCapacityWebSearchValue = default,
            string? endpointsCapacityConcurrencyUnit = default,
            string? endpointsCapacityConcurrencyValue = default,
            string? endpointsPassthroughParameters = default,
            string? endpointsDeprecationDate = default,
            string? endpointsIsReady = default,
            string? endpointsIsFree = default,
            string? endpointsServiceTier = default,
            string? endpointsDiscountToUser = default,
            string? endpointsOpenrouterSlug = default,
            string? endpointsDatacentersCountryCode = default,
            string? endpointsDatacentersRegion = default,
            string? endpointsDeploymentRegion = default,
            string? endpointsInputsType = default,
            string? endpointsInputsTextPricingType = default,
            string? endpointsInputsTextPricingPromptUnit = default,
            string? endpointsInputsTextPricingPromptCostUsd = default,
            string? endpointsInputsTextPricingPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingPromptUtcStart = default,
            string? endpointsInputsTextPricingPromptUtcEnd = default,
            string? endpointsInputsTextPricingPromptUtcDays = default,
            string? endpointsInputsTextPricingCachedPromptUnit = default,
            string? endpointsInputsTextPricingCachedPromptCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsTextPricingCachedPromptImplicit = default,
            string? endpointsInputsTextPricingCachedPromptUtcStart = default,
            string? endpointsInputsTextPricingCachedPromptUtcEnd = default,
            string? endpointsInputsTextPricingCachedPromptUtcDays = default,
            string? endpointsInputsTextPricingCacheWriteUnit = default,
            string? endpointsInputsTextPricingCacheWriteCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsTextPricingCacheWriteImplicit = default,
            string? endpointsInputsTextPricingCacheWriteUtcStart = default,
            string? endpointsInputsTextPricingCacheWriteUtcEnd = default,
            string? endpointsInputsTextPricingCacheWriteUtcDays = default,
            string? endpointsInputsTextCapacityType = default,
            string? endpointsInputsTextCapacityPromptUnit = default,
            string? endpointsInputsTextCapacityPromptPer = default,
            string? endpointsInputsTextCapacityPromptValue = default,
            string? endpointsInputsTextCapacityCachedPromptUnit = default,
            string? endpointsInputsTextCapacityCachedPromptPer = default,
            string? endpointsInputsTextCapacityCachedPromptValue = default,
            string? endpointsInputsTextCapacityCacheWriteUnit = default,
            string? endpointsInputsTextCapacityCacheWritePer = default,
            string? endpointsInputsTextCapacityCacheWriteValue = default,
            string? endpointsInputsTextPassthroughParameters = default,
            string? endpointsInputsTextParamsMaxPromptLengthValue = default,
            string? endpointsInputsTextParamsMaxPromptLengthUnit = default,
            string? endpointsInputsTextParamsMaxLengthValue = default,
            string? endpointsInputsTextParamsMaxLengthUnit = default,
            string? endpointsInputsImagePricingType = default,
            string? endpointsInputsImagePricingPromptUnit = default,
            string? endpointsInputsImagePricingPromptCostUsd = default,
            string? endpointsInputsImagePricingPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingPromptUtcStart = default,
            string? endpointsInputsImagePricingPromptUtcEnd = default,
            string? endpointsInputsImagePricingPromptUtcDays = default,
            string? endpointsInputsImagePricingCachedPromptUnit = default,
            string? endpointsInputsImagePricingCachedPromptCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsImagePricingCachedPromptImplicit = default,
            string? endpointsInputsImagePricingCachedPromptUtcStart = default,
            string? endpointsInputsImagePricingCachedPromptUtcEnd = default,
            string? endpointsInputsImagePricingCachedPromptUtcDays = default,
            string? endpointsInputsImagePricingCacheWriteUnit = default,
            string? endpointsInputsImagePricingCacheWriteCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsImagePricingCacheWriteImplicit = default,
            string? endpointsInputsImagePricingCacheWriteUtcStart = default,
            string? endpointsInputsImagePricingCacheWriteUtcEnd = default,
            string? endpointsInputsImagePricingCacheWriteUtcDays = default,
            string? endpointsInputsImageCapacityType = default,
            string? endpointsInputsImageCapacityPromptUnit = default,
            string? endpointsInputsImageCapacityPromptPer = default,
            string? endpointsInputsImageCapacityPromptValue = default,
            string? endpointsInputsImageCapacityCachedPromptUnit = default,
            string? endpointsInputsImageCapacityCachedPromptPer = default,
            string? endpointsInputsImageCapacityCachedPromptValue = default,
            string? endpointsInputsImageCapacityCacheWriteUnit = default,
            string? endpointsInputsImageCapacityCacheWritePer = default,
            string? endpointsInputsImageCapacityCacheWriteValue = default,
            string? endpointsInputsImagePassthroughParameters = default,
            string? endpointsInputsImageParamsSourcesType = default,
            string? endpointsInputsImageParamsSourcesValues = default,
            string? endpointsInputsImageParamsFormatsType = default,
            string? endpointsInputsImageParamsFormatsValues = default,
            string? endpointsInputsImageParamsDetailLevelsType = default,
            string? endpointsInputsImageParamsDetailLevelsValues = default,
            string? endpointsInputsImageParamsReferencesType = default,
            string? endpointsInputsImageParamsReferencesMin = default,
            string? endpointsInputsImageParamsReferencesMax = default,
            string? endpointsInputsImageParamsReferencesUnit = default,
            string? endpointsInputsImageParamsRoleType = default,
            string? endpointsInputsImageParamsRoleValues = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsVideoPricingType = default,
            string? endpointsInputsVideoPricingPromptUnit = default,
            string? endpointsInputsVideoPricingPromptCostUsd = default,
            string? endpointsInputsVideoPricingPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingPromptUtcStart = default,
            string? endpointsInputsVideoPricingPromptUtcEnd = default,
            string? endpointsInputsVideoPricingPromptUtcDays = default,
            string? endpointsInputsVideoPricingCachedPromptUnit = default,
            string? endpointsInputsVideoPricingCachedPromptCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsVideoPricingCachedPromptImplicit = default,
            string? endpointsInputsVideoPricingCachedPromptUtcStart = default,
            string? endpointsInputsVideoPricingCachedPromptUtcEnd = default,
            string? endpointsInputsVideoPricingCachedPromptUtcDays = default,
            string? endpointsInputsVideoPricingCacheWriteUnit = default,
            string? endpointsInputsVideoPricingCacheWriteCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsVideoPricingCacheWriteImplicit = default,
            string? endpointsInputsVideoPricingCacheWriteUtcStart = default,
            string? endpointsInputsVideoPricingCacheWriteUtcEnd = default,
            string? endpointsInputsVideoPricingCacheWriteUtcDays = default,
            string? endpointsInputsVideoCapacityType = default,
            string? endpointsInputsVideoCapacityPromptUnit = default,
            string? endpointsInputsVideoCapacityPromptPer = default,
            string? endpointsInputsVideoCapacityPromptValue = default,
            string? endpointsInputsVideoCapacityCachedPromptUnit = default,
            string? endpointsInputsVideoCapacityCachedPromptPer = default,
            string? endpointsInputsVideoCapacityCachedPromptValue = default,
            string? endpointsInputsVideoCapacityCacheWriteUnit = default,
            string? endpointsInputsVideoCapacityCacheWritePer = default,
            string? endpointsInputsVideoCapacityCacheWriteValue = default,
            string? endpointsInputsVideoPassthroughParameters = default,
            string? endpointsInputsVideoParamsSourcesType = default,
            string? endpointsInputsVideoParamsSourcesValues = default,
            string? endpointsInputsVideoParamsFormatsType = default,
            string? endpointsInputsVideoParamsFormatsValues = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsValue = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsAudioPricingType = default,
            string? endpointsInputsAudioPricingPromptUnit = default,
            string? endpointsInputsAudioPricingPromptCostUsd = default,
            string? endpointsInputsAudioPricingPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingPromptUtcStart = default,
            string? endpointsInputsAudioPricingPromptUtcEnd = default,
            string? endpointsInputsAudioPricingPromptUtcDays = default,
            string? endpointsInputsAudioPricingCachedPromptUnit = default,
            string? endpointsInputsAudioPricingCachedPromptCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsAudioPricingCachedPromptImplicit = default,
            string? endpointsInputsAudioPricingCachedPromptUtcStart = default,
            string? endpointsInputsAudioPricingCachedPromptUtcEnd = default,
            string? endpointsInputsAudioPricingCachedPromptUtcDays = default,
            string? endpointsInputsAudioPricingCacheWriteUnit = default,
            string? endpointsInputsAudioPricingCacheWriteCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsAudioPricingCacheWriteImplicit = default,
            string? endpointsInputsAudioPricingCacheWriteUtcStart = default,
            string? endpointsInputsAudioPricingCacheWriteUtcEnd = default,
            string? endpointsInputsAudioPricingCacheWriteUtcDays = default,
            string? endpointsInputsAudioCapacityType = default,
            string? endpointsInputsAudioCapacityPromptUnit = default,
            string? endpointsInputsAudioCapacityPromptPer = default,
            string? endpointsInputsAudioCapacityPromptValue = default,
            string? endpointsInputsAudioCapacityCachedPromptUnit = default,
            string? endpointsInputsAudioCapacityCachedPromptPer = default,
            string? endpointsInputsAudioCapacityCachedPromptValue = default,
            string? endpointsInputsAudioCapacityCacheWriteUnit = default,
            string? endpointsInputsAudioCapacityCacheWritePer = default,
            string? endpointsInputsAudioCapacityCacheWriteValue = default,
            string? endpointsInputsAudioPassthroughParameters = default,
            string? endpointsInputsAudioParamsSourcesType = default,
            string? endpointsInputsAudioParamsSourcesValues = default,
            string? endpointsInputsAudioParamsFormatsType = default,
            string? endpointsInputsAudioParamsFormatsValues = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsValue = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsFilePricingType = default,
            string? endpointsInputsFilePricingPromptUnit = default,
            string? endpointsInputsFilePricingPromptCostUsd = default,
            string? endpointsInputsFilePricingPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingPromptUtcStart = default,
            string? endpointsInputsFilePricingPromptUtcEnd = default,
            string? endpointsInputsFilePricingPromptUtcDays = default,
            string? endpointsInputsFilePricingCachedPromptUnit = default,
            string? endpointsInputsFilePricingCachedPromptCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsFilePricingCachedPromptImplicit = default,
            string? endpointsInputsFilePricingCachedPromptUtcStart = default,
            string? endpointsInputsFilePricingCachedPromptUtcEnd = default,
            string? endpointsInputsFilePricingCachedPromptUtcDays = default,
            string? endpointsInputsFilePricingCacheWriteUnit = default,
            string? endpointsInputsFilePricingCacheWriteCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsFilePricingCacheWriteImplicit = default,
            string? endpointsInputsFilePricingCacheWriteUtcStart = default,
            string? endpointsInputsFilePricingCacheWriteUtcEnd = default,
            string? endpointsInputsFilePricingCacheWriteUtcDays = default,
            string? endpointsInputsFileCapacityType = default,
            string? endpointsInputsFileCapacityPromptUnit = default,
            string? endpointsInputsFileCapacityPromptPer = default,
            string? endpointsInputsFileCapacityPromptValue = default,
            string? endpointsInputsFileCapacityCachedPromptUnit = default,
            string? endpointsInputsFileCapacityCachedPromptPer = default,
            string? endpointsInputsFileCapacityCachedPromptValue = default,
            string? endpointsInputsFileCapacityCacheWriteUnit = default,
            string? endpointsInputsFileCapacityCacheWritePer = default,
            string? endpointsInputsFileCapacityCacheWriteValue = default,
            string? endpointsInputsFilePassthroughParameters = default,
            string? endpointsInputsFileParamsSourcesType = default,
            string? endpointsInputsFileParamsSourcesValues = default,
            string? endpointsInputsFileParamsFormatsType = default,
            string? endpointsInputsFileParamsFormatsValues = default,
            string? endpointsInputsFileParamsReferencesType = default,
            string? endpointsInputsFileParamsReferencesMin = default,
            string? endpointsInputsFileParamsReferencesMax = default,
            string? endpointsInputsFileParamsReferencesUnit = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesUnit = default,
            string? endpointsOutputsType = default,
            string? endpointsOutputsTextMaxLengthValue = default,
            string? endpointsOutputsTextMaxLengthUnit = default,
            string? endpointsOutputsTextPassthroughParameters = default,
            string? endpointsOutputsTextPricingType = default,
            string? endpointsOutputsTextPricingCompletionUnit = default,
            string? endpointsOutputsTextPricingCompletionCostUsd = default,
            string? endpointsOutputsTextPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTextPricingCompletionUtcStart = default,
            string? endpointsOutputsTextPricingCompletionUtcEnd = default,
            string? endpointsOutputsTextPricingCompletionUtcDays = default,
            string? endpointsOutputsTextPricingInternalReasoningUnit = default,
            string? endpointsOutputsTextPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTextCapacityType = default,
            string? endpointsOutputsTextCapacityCompletionUnit = default,
            string? endpointsOutputsTextCapacityCompletionPer = default,
            string? endpointsOutputsTextCapacityCompletionValue = default,
            string? endpointsOutputsTextCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTextCapacityInternalReasoningPer = default,
            string? endpointsOutputsTextCapacityInternalReasoningValue = default,
            string? endpointsOutputsTextCapacityConcurrencyUnit = default,
            string? endpointsOutputsTextCapacityConcurrencyValue = default,
            string? endpointsOutputsTextStreaming = default,
            string? endpointsOutputsTextParams = default,
            string? endpointsOutputsImagePassthroughParameters = default,
            string? endpointsOutputsImagePricingType = default,
            string? endpointsOutputsImagePricingCompletionUnit = default,
            string? endpointsOutputsImagePricingCompletionCostUsd = default,
            string? endpointsOutputsImagePricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsImagePricingCompletionUtcStart = default,
            string? endpointsOutputsImagePricingCompletionUtcEnd = default,
            string? endpointsOutputsImagePricingCompletionUtcDays = default,
            string? endpointsOutputsImagePricingInternalReasoningUnit = default,
            string? endpointsOutputsImagePricingInternalReasoningCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcStart = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcDays = default,
            string? endpointsOutputsImageCapacityType = default,
            string? endpointsOutputsImageCapacityCompletionUnit = default,
            string? endpointsOutputsImageCapacityCompletionPer = default,
            string? endpointsOutputsImageCapacityCompletionValue = default,
            string? endpointsOutputsImageCapacityInternalReasoningUnit = default,
            string? endpointsOutputsImageCapacityInternalReasoningPer = default,
            string? endpointsOutputsImageCapacityInternalReasoningValue = default,
            string? endpointsOutputsImageCapacityConcurrencyUnit = default,
            string? endpointsOutputsImageCapacityConcurrencyValue = default,
            string? endpointsOutputsImageStreaming = default,
            string? endpointsOutputsImageParams = default,
            string? endpointsOutputsVideoPassthroughParameters = default,
            string? endpointsOutputsVideoPricingType = default,
            string? endpointsOutputsVideoPricingCompletionUnit = default,
            string? endpointsOutputsVideoPricingCompletionCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionUtcStart = default,
            string? endpointsOutputsVideoPricingCompletionUtcEnd = default,
            string? endpointsOutputsVideoPricingCompletionUtcDays = default,
            string? endpointsOutputsVideoPricingInternalReasoningUnit = default,
            string? endpointsOutputsVideoPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsVideoCapacityType = default,
            string? endpointsOutputsVideoCapacityCompletionUnit = default,
            string? endpointsOutputsVideoCapacityCompletionPer = default,
            string? endpointsOutputsVideoCapacityCompletionValue = default,
            string? endpointsOutputsVideoCapacityInternalReasoningUnit = default,
            string? endpointsOutputsVideoCapacityInternalReasoningPer = default,
            string? endpointsOutputsVideoCapacityInternalReasoningValue = default,
            string? endpointsOutputsVideoCapacityConcurrencyUnit = default,
            string? endpointsOutputsVideoCapacityConcurrencyValue = default,
            string? endpointsOutputsVideoStreaming = default,
            string? endpointsOutputsVideoParams = default,
            string? endpointsOutputsSpeechPassthroughParameters = default,
            string? endpointsOutputsSpeechPricingType = default,
            string? endpointsOutputsSpeechPricingCompletionUnit = default,
            string? endpointsOutputsSpeechPricingCompletionCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcStart = default,
            string? endpointsOutputsSpeechPricingCompletionUtcEnd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcDays = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUnit = default,
            string? endpointsOutputsSpeechPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsSpeechCapacityType = default,
            string? endpointsOutputsSpeechCapacityCompletionUnit = default,
            string? endpointsOutputsSpeechCapacityCompletionPer = default,
            string? endpointsOutputsSpeechCapacityCompletionValue = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningUnit = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningPer = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningValue = default,
            string? endpointsOutputsSpeechCapacityConcurrencyUnit = default,
            string? endpointsOutputsSpeechCapacityConcurrencyValue = default,
            string? endpointsOutputsSpeechStreaming = default,
            string? endpointsOutputsSpeechParams = default,
            string? endpointsOutputsTranscriptionPassthroughParameters = default,
            string? endpointsOutputsTranscriptionPricingType = default,
            string? endpointsOutputsTranscriptionPricingCompletionUnit = default,
            string? endpointsOutputsTranscriptionPricingCompletionCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcStart = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcDays = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTranscriptionCapacityType = default,
            string? endpointsOutputsTranscriptionCapacityCompletionUnit = default,
            string? endpointsOutputsTranscriptionCapacityCompletionPer = default,
            string? endpointsOutputsTranscriptionCapacityCompletionValue = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningPer = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningValue = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyUnit = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyValue = default,
            string? endpointsOutputsTranscriptionStreaming = default,
            string? endpointsOutputsTranscriptionParams = default,
            string? endpointsOutputsEmbeddingsPassthroughParameters = default,
            string? endpointsOutputsEmbeddingsPricingType = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUnit = default,
            string? endpointsOutputsEmbeddingsPricingCompletionCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcDays = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsEmbeddingsCapacityType = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionUnit = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionPer = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionValue = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningPer = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningValue = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyUnit = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyValue = default,
            string? endpointsOutputsEmbeddingsParams = default,
            string? endpointsOutputsRerankPassthroughParameters = default,
            string? endpointsOutputsRerankPricingType = default,
            string? endpointsOutputsRerankPricingCompletionUnit = default,
            string? endpointsOutputsRerankPricingCompletionCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionUtcStart = default,
            string? endpointsOutputsRerankPricingCompletionUtcEnd = default,
            string? endpointsOutputsRerankPricingCompletionUtcDays = default,
            string? endpointsOutputsRerankPricingInternalReasoningUnit = default,
            string? endpointsOutputsRerankPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsRerankCapacityType = default,
            string? endpointsOutputsRerankCapacityCompletionUnit = default,
            string? endpointsOutputsRerankCapacityCompletionPer = default,
            string? endpointsOutputsRerankCapacityCompletionValue = default,
            string? endpointsOutputsRerankCapacityInternalReasoningUnit = default,
            string? endpointsOutputsRerankCapacityInternalReasoningPer = default,
            string? endpointsOutputsRerankCapacityInternalReasoningValue = default,
            string? endpointsOutputsRerankCapacityConcurrencyUnit = default,
            string? endpointsOutputsRerankCapacityConcurrencyValue = default,
            string? endpointsOutputsRerankParams = default,
            string? endpointsOutputsDecisionsPassthroughParameters = default,
            string? endpointsOutputsDecisionsPricingType = default,
            string? endpointsOutputsDecisionsPricingCompletionUnit = default,
            string? endpointsOutputsDecisionsPricingCompletionCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcStart = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcEnd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcDays = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsDecisionsCapacityType = default,
            string? endpointsOutputsDecisionsCapacityCompletionUnit = default,
            string? endpointsOutputsDecisionsCapacityCompletionPer = default,
            string? endpointsOutputsDecisionsCapacityCompletionValue = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningPer = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningValue = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyUnit = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyValue = default,
            string? endpointsOutputsDecisionsParams = default,
            string? endpointsOutputsAudioPassthroughParameters = default,
            string? endpointsOutputsAudioPricingType = default,
            string? endpointsOutputsAudioPricingCompletionUnit = default,
            string? endpointsOutputsAudioPricingCompletionCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionUtcStart = default,
            string? endpointsOutputsAudioPricingCompletionUtcEnd = default,
            string? endpointsOutputsAudioPricingCompletionUtcDays = default,
            string? endpointsOutputsAudioPricingInternalReasoningUnit = default,
            string? endpointsOutputsAudioPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsAudioCapacityType = default,
            string? endpointsOutputsAudioCapacityCompletionUnit = default,
            string? endpointsOutputsAudioCapacityCompletionPer = default,
            string? endpointsOutputsAudioCapacityCompletionValue = default,
            string? endpointsOutputsAudioCapacityInternalReasoningUnit = default,
            string? endpointsOutputsAudioCapacityInternalReasoningPer = default,
            string? endpointsOutputsAudioCapacityInternalReasoningValue = default,
            string? endpointsOutputsAudioCapacityConcurrencyUnit = default,
            string? endpointsOutputsAudioCapacityConcurrencyValue = default,
            string? endpointsOutputsAudioStreaming = default,
            string? endpointsOutputsAudioParams = default,
            string? endpointsProviderSlug = default,
            string? endpointsProviderTag = default,
            string? endpointsProviderName = default,
            string? endpointsDataPolicyTraining = default,
            string? endpointsDataPolicyRetainsPrompts = default,
            string? endpointsDataPolicyRetentionDays = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListV2AsResponseAsync(
                offset: offset,
                limit: limit,
                cursor: cursor,
                region: region,
                sort: sort,
                id: id,
                canonicalSlug: canonicalSlug,
                author: author,
                name: name,
                variant: variant,
                kind: kind,
                aliasTargetSlug: aliasTargetSlug,
                aliasTargetName: aliasTargetName,
                created: created,
                description: description,
                contextLength: contextLength,
                huggingFaceId: huggingFaceId,
                inputs: inputs,
                outputs: outputs,
                endpointsSchemaVersion: endpointsSchemaVersion,
                endpointsId: endpointsId,
                endpointsHuggingFaceId: endpointsHuggingFaceId,
                endpointsName: endpointsName,
                endpointsCreated: endpointsCreated,
                endpointsQuantization: endpointsQuantization,
                endpointsTokenizer: endpointsTokenizer,
                endpointsDescription: endpointsDescription,
                endpointsPricingType: endpointsPricingType,
                endpointsPricingRequestUnit: endpointsPricingRequestUnit,
                endpointsPricingRequestCostUsd: endpointsPricingRequestCostUsd,
                endpointsPricingRequestOverridesCostUsd: endpointsPricingRequestOverridesCostUsd,
                endpointsPricingWebSearchUnit: endpointsPricingWebSearchUnit,
                endpointsPricingWebSearchCostUsd: endpointsPricingWebSearchCostUsd,
                endpointsPricingWebSearchOverridesCostUsd: endpointsPricingWebSearchOverridesCostUsd,
                endpointsCapacityType: endpointsCapacityType,
                endpointsCapacityRequestUnit: endpointsCapacityRequestUnit,
                endpointsCapacityRequestPer: endpointsCapacityRequestPer,
                endpointsCapacityRequestValue: endpointsCapacityRequestValue,
                endpointsCapacityWebSearchUnit: endpointsCapacityWebSearchUnit,
                endpointsCapacityWebSearchPer: endpointsCapacityWebSearchPer,
                endpointsCapacityWebSearchValue: endpointsCapacityWebSearchValue,
                endpointsCapacityConcurrencyUnit: endpointsCapacityConcurrencyUnit,
                endpointsCapacityConcurrencyValue: endpointsCapacityConcurrencyValue,
                endpointsPassthroughParameters: endpointsPassthroughParameters,
                endpointsDeprecationDate: endpointsDeprecationDate,
                endpointsIsReady: endpointsIsReady,
                endpointsIsFree: endpointsIsFree,
                endpointsServiceTier: endpointsServiceTier,
                endpointsDiscountToUser: endpointsDiscountToUser,
                endpointsOpenrouterSlug: endpointsOpenrouterSlug,
                endpointsDatacentersCountryCode: endpointsDatacentersCountryCode,
                endpointsDatacentersRegion: endpointsDatacentersRegion,
                endpointsDeploymentRegion: endpointsDeploymentRegion,
                endpointsInputsType: endpointsInputsType,
                endpointsInputsTextPricingType: endpointsInputsTextPricingType,
                endpointsInputsTextPricingPromptUnit: endpointsInputsTextPricingPromptUnit,
                endpointsInputsTextPricingPromptCostUsd: endpointsInputsTextPricingPromptCostUsd,
                endpointsInputsTextPricingPromptOverridesCostUsd: endpointsInputsTextPricingPromptOverridesCostUsd,
                endpointsInputsTextPricingPromptUtcStart: endpointsInputsTextPricingPromptUtcStart,
                endpointsInputsTextPricingPromptUtcEnd: endpointsInputsTextPricingPromptUtcEnd,
                endpointsInputsTextPricingPromptUtcDays: endpointsInputsTextPricingPromptUtcDays,
                endpointsInputsTextPricingCachedPromptUnit: endpointsInputsTextPricingCachedPromptUnit,
                endpointsInputsTextPricingCachedPromptCostUsd: endpointsInputsTextPricingCachedPromptCostUsd,
                endpointsInputsTextPricingCachedPromptOverridesCostUsd: endpointsInputsTextPricingCachedPromptOverridesCostUsd,
                endpointsInputsTextPricingCachedPromptTtlSeconds: endpointsInputsTextPricingCachedPromptTtlSeconds,
                endpointsInputsTextPricingCachedPromptImplicit: endpointsInputsTextPricingCachedPromptImplicit,
                endpointsInputsTextPricingCachedPromptUtcStart: endpointsInputsTextPricingCachedPromptUtcStart,
                endpointsInputsTextPricingCachedPromptUtcEnd: endpointsInputsTextPricingCachedPromptUtcEnd,
                endpointsInputsTextPricingCachedPromptUtcDays: endpointsInputsTextPricingCachedPromptUtcDays,
                endpointsInputsTextPricingCacheWriteUnit: endpointsInputsTextPricingCacheWriteUnit,
                endpointsInputsTextPricingCacheWriteCostUsd: endpointsInputsTextPricingCacheWriteCostUsd,
                endpointsInputsTextPricingCacheWriteOverridesCostUsd: endpointsInputsTextPricingCacheWriteOverridesCostUsd,
                endpointsInputsTextPricingCacheWriteTtlSeconds: endpointsInputsTextPricingCacheWriteTtlSeconds,
                endpointsInputsTextPricingCacheWriteImplicit: endpointsInputsTextPricingCacheWriteImplicit,
                endpointsInputsTextPricingCacheWriteUtcStart: endpointsInputsTextPricingCacheWriteUtcStart,
                endpointsInputsTextPricingCacheWriteUtcEnd: endpointsInputsTextPricingCacheWriteUtcEnd,
                endpointsInputsTextPricingCacheWriteUtcDays: endpointsInputsTextPricingCacheWriteUtcDays,
                endpointsInputsTextCapacityType: endpointsInputsTextCapacityType,
                endpointsInputsTextCapacityPromptUnit: endpointsInputsTextCapacityPromptUnit,
                endpointsInputsTextCapacityPromptPer: endpointsInputsTextCapacityPromptPer,
                endpointsInputsTextCapacityPromptValue: endpointsInputsTextCapacityPromptValue,
                endpointsInputsTextCapacityCachedPromptUnit: endpointsInputsTextCapacityCachedPromptUnit,
                endpointsInputsTextCapacityCachedPromptPer: endpointsInputsTextCapacityCachedPromptPer,
                endpointsInputsTextCapacityCachedPromptValue: endpointsInputsTextCapacityCachedPromptValue,
                endpointsInputsTextCapacityCacheWriteUnit: endpointsInputsTextCapacityCacheWriteUnit,
                endpointsInputsTextCapacityCacheWritePer: endpointsInputsTextCapacityCacheWritePer,
                endpointsInputsTextCapacityCacheWriteValue: endpointsInputsTextCapacityCacheWriteValue,
                endpointsInputsTextPassthroughParameters: endpointsInputsTextPassthroughParameters,
                endpointsInputsTextParamsMaxPromptLengthValue: endpointsInputsTextParamsMaxPromptLengthValue,
                endpointsInputsTextParamsMaxPromptLengthUnit: endpointsInputsTextParamsMaxPromptLengthUnit,
                endpointsInputsTextParamsMaxLengthValue: endpointsInputsTextParamsMaxLengthValue,
                endpointsInputsTextParamsMaxLengthUnit: endpointsInputsTextParamsMaxLengthUnit,
                endpointsInputsImagePricingType: endpointsInputsImagePricingType,
                endpointsInputsImagePricingPromptUnit: endpointsInputsImagePricingPromptUnit,
                endpointsInputsImagePricingPromptCostUsd: endpointsInputsImagePricingPromptCostUsd,
                endpointsInputsImagePricingPromptOverridesCostUsd: endpointsInputsImagePricingPromptOverridesCostUsd,
                endpointsInputsImagePricingPromptUtcStart: endpointsInputsImagePricingPromptUtcStart,
                endpointsInputsImagePricingPromptUtcEnd: endpointsInputsImagePricingPromptUtcEnd,
                endpointsInputsImagePricingPromptUtcDays: endpointsInputsImagePricingPromptUtcDays,
                endpointsInputsImagePricingCachedPromptUnit: endpointsInputsImagePricingCachedPromptUnit,
                endpointsInputsImagePricingCachedPromptCostUsd: endpointsInputsImagePricingCachedPromptCostUsd,
                endpointsInputsImagePricingCachedPromptOverridesCostUsd: endpointsInputsImagePricingCachedPromptOverridesCostUsd,
                endpointsInputsImagePricingCachedPromptTtlSeconds: endpointsInputsImagePricingCachedPromptTtlSeconds,
                endpointsInputsImagePricingCachedPromptImplicit: endpointsInputsImagePricingCachedPromptImplicit,
                endpointsInputsImagePricingCachedPromptUtcStart: endpointsInputsImagePricingCachedPromptUtcStart,
                endpointsInputsImagePricingCachedPromptUtcEnd: endpointsInputsImagePricingCachedPromptUtcEnd,
                endpointsInputsImagePricingCachedPromptUtcDays: endpointsInputsImagePricingCachedPromptUtcDays,
                endpointsInputsImagePricingCacheWriteUnit: endpointsInputsImagePricingCacheWriteUnit,
                endpointsInputsImagePricingCacheWriteCostUsd: endpointsInputsImagePricingCacheWriteCostUsd,
                endpointsInputsImagePricingCacheWriteOverridesCostUsd: endpointsInputsImagePricingCacheWriteOverridesCostUsd,
                endpointsInputsImagePricingCacheWriteTtlSeconds: endpointsInputsImagePricingCacheWriteTtlSeconds,
                endpointsInputsImagePricingCacheWriteImplicit: endpointsInputsImagePricingCacheWriteImplicit,
                endpointsInputsImagePricingCacheWriteUtcStart: endpointsInputsImagePricingCacheWriteUtcStart,
                endpointsInputsImagePricingCacheWriteUtcEnd: endpointsInputsImagePricingCacheWriteUtcEnd,
                endpointsInputsImagePricingCacheWriteUtcDays: endpointsInputsImagePricingCacheWriteUtcDays,
                endpointsInputsImageCapacityType: endpointsInputsImageCapacityType,
                endpointsInputsImageCapacityPromptUnit: endpointsInputsImageCapacityPromptUnit,
                endpointsInputsImageCapacityPromptPer: endpointsInputsImageCapacityPromptPer,
                endpointsInputsImageCapacityPromptValue: endpointsInputsImageCapacityPromptValue,
                endpointsInputsImageCapacityCachedPromptUnit: endpointsInputsImageCapacityCachedPromptUnit,
                endpointsInputsImageCapacityCachedPromptPer: endpointsInputsImageCapacityCachedPromptPer,
                endpointsInputsImageCapacityCachedPromptValue: endpointsInputsImageCapacityCachedPromptValue,
                endpointsInputsImageCapacityCacheWriteUnit: endpointsInputsImageCapacityCacheWriteUnit,
                endpointsInputsImageCapacityCacheWritePer: endpointsInputsImageCapacityCacheWritePer,
                endpointsInputsImageCapacityCacheWriteValue: endpointsInputsImageCapacityCacheWriteValue,
                endpointsInputsImagePassthroughParameters: endpointsInputsImagePassthroughParameters,
                endpointsInputsImageParamsSourcesType: endpointsInputsImageParamsSourcesType,
                endpointsInputsImageParamsSourcesValues: endpointsInputsImageParamsSourcesValues,
                endpointsInputsImageParamsFormatsType: endpointsInputsImageParamsFormatsType,
                endpointsInputsImageParamsFormatsValues: endpointsInputsImageParamsFormatsValues,
                endpointsInputsImageParamsDetailLevelsType: endpointsInputsImageParamsDetailLevelsType,
                endpointsInputsImageParamsDetailLevelsValues: endpointsInputsImageParamsDetailLevelsValues,
                endpointsInputsImageParamsReferencesType: endpointsInputsImageParamsReferencesType,
                endpointsInputsImageParamsReferencesMin: endpointsInputsImageParamsReferencesMin,
                endpointsInputsImageParamsReferencesMax: endpointsInputsImageParamsReferencesMax,
                endpointsInputsImageParamsReferencesUnit: endpointsInputsImageParamsReferencesUnit,
                endpointsInputsImageParamsRoleType: endpointsInputsImageParamsRoleType,
                endpointsInputsImageParamsRoleValues: endpointsInputsImageParamsRoleValues,
                endpointsInputsImageParamsMaxContentSizeBytesValue: endpointsInputsImageParamsMaxContentSizeBytesValue,
                endpointsInputsImageParamsMaxContentSizeBytesUnit: endpointsInputsImageParamsMaxContentSizeBytesUnit,
                endpointsInputsVideoPricingType: endpointsInputsVideoPricingType,
                endpointsInputsVideoPricingPromptUnit: endpointsInputsVideoPricingPromptUnit,
                endpointsInputsVideoPricingPromptCostUsd: endpointsInputsVideoPricingPromptCostUsd,
                endpointsInputsVideoPricingPromptOverridesCostUsd: endpointsInputsVideoPricingPromptOverridesCostUsd,
                endpointsInputsVideoPricingPromptUtcStart: endpointsInputsVideoPricingPromptUtcStart,
                endpointsInputsVideoPricingPromptUtcEnd: endpointsInputsVideoPricingPromptUtcEnd,
                endpointsInputsVideoPricingPromptUtcDays: endpointsInputsVideoPricingPromptUtcDays,
                endpointsInputsVideoPricingCachedPromptUnit: endpointsInputsVideoPricingCachedPromptUnit,
                endpointsInputsVideoPricingCachedPromptCostUsd: endpointsInputsVideoPricingCachedPromptCostUsd,
                endpointsInputsVideoPricingCachedPromptOverridesCostUsd: endpointsInputsVideoPricingCachedPromptOverridesCostUsd,
                endpointsInputsVideoPricingCachedPromptTtlSeconds: endpointsInputsVideoPricingCachedPromptTtlSeconds,
                endpointsInputsVideoPricingCachedPromptImplicit: endpointsInputsVideoPricingCachedPromptImplicit,
                endpointsInputsVideoPricingCachedPromptUtcStart: endpointsInputsVideoPricingCachedPromptUtcStart,
                endpointsInputsVideoPricingCachedPromptUtcEnd: endpointsInputsVideoPricingCachedPromptUtcEnd,
                endpointsInputsVideoPricingCachedPromptUtcDays: endpointsInputsVideoPricingCachedPromptUtcDays,
                endpointsInputsVideoPricingCacheWriteUnit: endpointsInputsVideoPricingCacheWriteUnit,
                endpointsInputsVideoPricingCacheWriteCostUsd: endpointsInputsVideoPricingCacheWriteCostUsd,
                endpointsInputsVideoPricingCacheWriteOverridesCostUsd: endpointsInputsVideoPricingCacheWriteOverridesCostUsd,
                endpointsInputsVideoPricingCacheWriteTtlSeconds: endpointsInputsVideoPricingCacheWriteTtlSeconds,
                endpointsInputsVideoPricingCacheWriteImplicit: endpointsInputsVideoPricingCacheWriteImplicit,
                endpointsInputsVideoPricingCacheWriteUtcStart: endpointsInputsVideoPricingCacheWriteUtcStart,
                endpointsInputsVideoPricingCacheWriteUtcEnd: endpointsInputsVideoPricingCacheWriteUtcEnd,
                endpointsInputsVideoPricingCacheWriteUtcDays: endpointsInputsVideoPricingCacheWriteUtcDays,
                endpointsInputsVideoCapacityType: endpointsInputsVideoCapacityType,
                endpointsInputsVideoCapacityPromptUnit: endpointsInputsVideoCapacityPromptUnit,
                endpointsInputsVideoCapacityPromptPer: endpointsInputsVideoCapacityPromptPer,
                endpointsInputsVideoCapacityPromptValue: endpointsInputsVideoCapacityPromptValue,
                endpointsInputsVideoCapacityCachedPromptUnit: endpointsInputsVideoCapacityCachedPromptUnit,
                endpointsInputsVideoCapacityCachedPromptPer: endpointsInputsVideoCapacityCachedPromptPer,
                endpointsInputsVideoCapacityCachedPromptValue: endpointsInputsVideoCapacityCachedPromptValue,
                endpointsInputsVideoCapacityCacheWriteUnit: endpointsInputsVideoCapacityCacheWriteUnit,
                endpointsInputsVideoCapacityCacheWritePer: endpointsInputsVideoCapacityCacheWritePer,
                endpointsInputsVideoCapacityCacheWriteValue: endpointsInputsVideoCapacityCacheWriteValue,
                endpointsInputsVideoPassthroughParameters: endpointsInputsVideoPassthroughParameters,
                endpointsInputsVideoParamsSourcesType: endpointsInputsVideoParamsSourcesType,
                endpointsInputsVideoParamsSourcesValues: endpointsInputsVideoParamsSourcesValues,
                endpointsInputsVideoParamsFormatsType: endpointsInputsVideoParamsFormatsType,
                endpointsInputsVideoParamsFormatsValues: endpointsInputsVideoParamsFormatsValues,
                endpointsInputsVideoParamsMaxDurationSecondsValue: endpointsInputsVideoParamsMaxDurationSecondsValue,
                endpointsInputsVideoParamsMaxDurationSecondsUnit: endpointsInputsVideoParamsMaxDurationSecondsUnit,
                endpointsInputsVideoParamsMaxContentSizeBytesValue: endpointsInputsVideoParamsMaxContentSizeBytesValue,
                endpointsInputsVideoParamsMaxContentSizeBytesUnit: endpointsInputsVideoParamsMaxContentSizeBytesUnit,
                endpointsInputsAudioPricingType: endpointsInputsAudioPricingType,
                endpointsInputsAudioPricingPromptUnit: endpointsInputsAudioPricingPromptUnit,
                endpointsInputsAudioPricingPromptCostUsd: endpointsInputsAudioPricingPromptCostUsd,
                endpointsInputsAudioPricingPromptOverridesCostUsd: endpointsInputsAudioPricingPromptOverridesCostUsd,
                endpointsInputsAudioPricingPromptUtcStart: endpointsInputsAudioPricingPromptUtcStart,
                endpointsInputsAudioPricingPromptUtcEnd: endpointsInputsAudioPricingPromptUtcEnd,
                endpointsInputsAudioPricingPromptUtcDays: endpointsInputsAudioPricingPromptUtcDays,
                endpointsInputsAudioPricingCachedPromptUnit: endpointsInputsAudioPricingCachedPromptUnit,
                endpointsInputsAudioPricingCachedPromptCostUsd: endpointsInputsAudioPricingCachedPromptCostUsd,
                endpointsInputsAudioPricingCachedPromptOverridesCostUsd: endpointsInputsAudioPricingCachedPromptOverridesCostUsd,
                endpointsInputsAudioPricingCachedPromptTtlSeconds: endpointsInputsAudioPricingCachedPromptTtlSeconds,
                endpointsInputsAudioPricingCachedPromptImplicit: endpointsInputsAudioPricingCachedPromptImplicit,
                endpointsInputsAudioPricingCachedPromptUtcStart: endpointsInputsAudioPricingCachedPromptUtcStart,
                endpointsInputsAudioPricingCachedPromptUtcEnd: endpointsInputsAudioPricingCachedPromptUtcEnd,
                endpointsInputsAudioPricingCachedPromptUtcDays: endpointsInputsAudioPricingCachedPromptUtcDays,
                endpointsInputsAudioPricingCacheWriteUnit: endpointsInputsAudioPricingCacheWriteUnit,
                endpointsInputsAudioPricingCacheWriteCostUsd: endpointsInputsAudioPricingCacheWriteCostUsd,
                endpointsInputsAudioPricingCacheWriteOverridesCostUsd: endpointsInputsAudioPricingCacheWriteOverridesCostUsd,
                endpointsInputsAudioPricingCacheWriteTtlSeconds: endpointsInputsAudioPricingCacheWriteTtlSeconds,
                endpointsInputsAudioPricingCacheWriteImplicit: endpointsInputsAudioPricingCacheWriteImplicit,
                endpointsInputsAudioPricingCacheWriteUtcStart: endpointsInputsAudioPricingCacheWriteUtcStart,
                endpointsInputsAudioPricingCacheWriteUtcEnd: endpointsInputsAudioPricingCacheWriteUtcEnd,
                endpointsInputsAudioPricingCacheWriteUtcDays: endpointsInputsAudioPricingCacheWriteUtcDays,
                endpointsInputsAudioCapacityType: endpointsInputsAudioCapacityType,
                endpointsInputsAudioCapacityPromptUnit: endpointsInputsAudioCapacityPromptUnit,
                endpointsInputsAudioCapacityPromptPer: endpointsInputsAudioCapacityPromptPer,
                endpointsInputsAudioCapacityPromptValue: endpointsInputsAudioCapacityPromptValue,
                endpointsInputsAudioCapacityCachedPromptUnit: endpointsInputsAudioCapacityCachedPromptUnit,
                endpointsInputsAudioCapacityCachedPromptPer: endpointsInputsAudioCapacityCachedPromptPer,
                endpointsInputsAudioCapacityCachedPromptValue: endpointsInputsAudioCapacityCachedPromptValue,
                endpointsInputsAudioCapacityCacheWriteUnit: endpointsInputsAudioCapacityCacheWriteUnit,
                endpointsInputsAudioCapacityCacheWritePer: endpointsInputsAudioCapacityCacheWritePer,
                endpointsInputsAudioCapacityCacheWriteValue: endpointsInputsAudioCapacityCacheWriteValue,
                endpointsInputsAudioPassthroughParameters: endpointsInputsAudioPassthroughParameters,
                endpointsInputsAudioParamsSourcesType: endpointsInputsAudioParamsSourcesType,
                endpointsInputsAudioParamsSourcesValues: endpointsInputsAudioParamsSourcesValues,
                endpointsInputsAudioParamsFormatsType: endpointsInputsAudioParamsFormatsType,
                endpointsInputsAudioParamsFormatsValues: endpointsInputsAudioParamsFormatsValues,
                endpointsInputsAudioParamsMaxDurationSecondsValue: endpointsInputsAudioParamsMaxDurationSecondsValue,
                endpointsInputsAudioParamsMaxDurationSecondsUnit: endpointsInputsAudioParamsMaxDurationSecondsUnit,
                endpointsInputsAudioParamsMaxContentSizeBytesValue: endpointsInputsAudioParamsMaxContentSizeBytesValue,
                endpointsInputsAudioParamsMaxContentSizeBytesUnit: endpointsInputsAudioParamsMaxContentSizeBytesUnit,
                endpointsInputsFilePricingType: endpointsInputsFilePricingType,
                endpointsInputsFilePricingPromptUnit: endpointsInputsFilePricingPromptUnit,
                endpointsInputsFilePricingPromptCostUsd: endpointsInputsFilePricingPromptCostUsd,
                endpointsInputsFilePricingPromptOverridesCostUsd: endpointsInputsFilePricingPromptOverridesCostUsd,
                endpointsInputsFilePricingPromptUtcStart: endpointsInputsFilePricingPromptUtcStart,
                endpointsInputsFilePricingPromptUtcEnd: endpointsInputsFilePricingPromptUtcEnd,
                endpointsInputsFilePricingPromptUtcDays: endpointsInputsFilePricingPromptUtcDays,
                endpointsInputsFilePricingCachedPromptUnit: endpointsInputsFilePricingCachedPromptUnit,
                endpointsInputsFilePricingCachedPromptCostUsd: endpointsInputsFilePricingCachedPromptCostUsd,
                endpointsInputsFilePricingCachedPromptOverridesCostUsd: endpointsInputsFilePricingCachedPromptOverridesCostUsd,
                endpointsInputsFilePricingCachedPromptTtlSeconds: endpointsInputsFilePricingCachedPromptTtlSeconds,
                endpointsInputsFilePricingCachedPromptImplicit: endpointsInputsFilePricingCachedPromptImplicit,
                endpointsInputsFilePricingCachedPromptUtcStart: endpointsInputsFilePricingCachedPromptUtcStart,
                endpointsInputsFilePricingCachedPromptUtcEnd: endpointsInputsFilePricingCachedPromptUtcEnd,
                endpointsInputsFilePricingCachedPromptUtcDays: endpointsInputsFilePricingCachedPromptUtcDays,
                endpointsInputsFilePricingCacheWriteUnit: endpointsInputsFilePricingCacheWriteUnit,
                endpointsInputsFilePricingCacheWriteCostUsd: endpointsInputsFilePricingCacheWriteCostUsd,
                endpointsInputsFilePricingCacheWriteOverridesCostUsd: endpointsInputsFilePricingCacheWriteOverridesCostUsd,
                endpointsInputsFilePricingCacheWriteTtlSeconds: endpointsInputsFilePricingCacheWriteTtlSeconds,
                endpointsInputsFilePricingCacheWriteImplicit: endpointsInputsFilePricingCacheWriteImplicit,
                endpointsInputsFilePricingCacheWriteUtcStart: endpointsInputsFilePricingCacheWriteUtcStart,
                endpointsInputsFilePricingCacheWriteUtcEnd: endpointsInputsFilePricingCacheWriteUtcEnd,
                endpointsInputsFilePricingCacheWriteUtcDays: endpointsInputsFilePricingCacheWriteUtcDays,
                endpointsInputsFileCapacityType: endpointsInputsFileCapacityType,
                endpointsInputsFileCapacityPromptUnit: endpointsInputsFileCapacityPromptUnit,
                endpointsInputsFileCapacityPromptPer: endpointsInputsFileCapacityPromptPer,
                endpointsInputsFileCapacityPromptValue: endpointsInputsFileCapacityPromptValue,
                endpointsInputsFileCapacityCachedPromptUnit: endpointsInputsFileCapacityCachedPromptUnit,
                endpointsInputsFileCapacityCachedPromptPer: endpointsInputsFileCapacityCachedPromptPer,
                endpointsInputsFileCapacityCachedPromptValue: endpointsInputsFileCapacityCachedPromptValue,
                endpointsInputsFileCapacityCacheWriteUnit: endpointsInputsFileCapacityCacheWriteUnit,
                endpointsInputsFileCapacityCacheWritePer: endpointsInputsFileCapacityCacheWritePer,
                endpointsInputsFileCapacityCacheWriteValue: endpointsInputsFileCapacityCacheWriteValue,
                endpointsInputsFilePassthroughParameters: endpointsInputsFilePassthroughParameters,
                endpointsInputsFileParamsSourcesType: endpointsInputsFileParamsSourcesType,
                endpointsInputsFileParamsSourcesValues: endpointsInputsFileParamsSourcesValues,
                endpointsInputsFileParamsFormatsType: endpointsInputsFileParamsFormatsType,
                endpointsInputsFileParamsFormatsValues: endpointsInputsFileParamsFormatsValues,
                endpointsInputsFileParamsReferencesType: endpointsInputsFileParamsReferencesType,
                endpointsInputsFileParamsReferencesMin: endpointsInputsFileParamsReferencesMin,
                endpointsInputsFileParamsReferencesMax: endpointsInputsFileParamsReferencesMax,
                endpointsInputsFileParamsReferencesUnit: endpointsInputsFileParamsReferencesUnit,
                endpointsInputsFileParamsMaxContentSizeBytesValue: endpointsInputsFileParamsMaxContentSizeBytesValue,
                endpointsInputsFileParamsMaxContentSizeBytesUnit: endpointsInputsFileParamsMaxContentSizeBytesUnit,
                endpointsOutputsType: endpointsOutputsType,
                endpointsOutputsTextMaxLengthValue: endpointsOutputsTextMaxLengthValue,
                endpointsOutputsTextMaxLengthUnit: endpointsOutputsTextMaxLengthUnit,
                endpointsOutputsTextPassthroughParameters: endpointsOutputsTextPassthroughParameters,
                endpointsOutputsTextPricingType: endpointsOutputsTextPricingType,
                endpointsOutputsTextPricingCompletionUnit: endpointsOutputsTextPricingCompletionUnit,
                endpointsOutputsTextPricingCompletionCostUsd: endpointsOutputsTextPricingCompletionCostUsd,
                endpointsOutputsTextPricingCompletionOverridesCostUsd: endpointsOutputsTextPricingCompletionOverridesCostUsd,
                endpointsOutputsTextPricingCompletionUtcStart: endpointsOutputsTextPricingCompletionUtcStart,
                endpointsOutputsTextPricingCompletionUtcEnd: endpointsOutputsTextPricingCompletionUtcEnd,
                endpointsOutputsTextPricingCompletionUtcDays: endpointsOutputsTextPricingCompletionUtcDays,
                endpointsOutputsTextPricingInternalReasoningUnit: endpointsOutputsTextPricingInternalReasoningUnit,
                endpointsOutputsTextPricingInternalReasoningCostUsd: endpointsOutputsTextPricingInternalReasoningCostUsd,
                endpointsOutputsTextPricingInternalReasoningOverridesCostUsd: endpointsOutputsTextPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsTextPricingInternalReasoningUtcStart: endpointsOutputsTextPricingInternalReasoningUtcStart,
                endpointsOutputsTextPricingInternalReasoningUtcEnd: endpointsOutputsTextPricingInternalReasoningUtcEnd,
                endpointsOutputsTextPricingInternalReasoningUtcDays: endpointsOutputsTextPricingInternalReasoningUtcDays,
                endpointsOutputsTextCapacityType: endpointsOutputsTextCapacityType,
                endpointsOutputsTextCapacityCompletionUnit: endpointsOutputsTextCapacityCompletionUnit,
                endpointsOutputsTextCapacityCompletionPer: endpointsOutputsTextCapacityCompletionPer,
                endpointsOutputsTextCapacityCompletionValue: endpointsOutputsTextCapacityCompletionValue,
                endpointsOutputsTextCapacityInternalReasoningUnit: endpointsOutputsTextCapacityInternalReasoningUnit,
                endpointsOutputsTextCapacityInternalReasoningPer: endpointsOutputsTextCapacityInternalReasoningPer,
                endpointsOutputsTextCapacityInternalReasoningValue: endpointsOutputsTextCapacityInternalReasoningValue,
                endpointsOutputsTextCapacityConcurrencyUnit: endpointsOutputsTextCapacityConcurrencyUnit,
                endpointsOutputsTextCapacityConcurrencyValue: endpointsOutputsTextCapacityConcurrencyValue,
                endpointsOutputsTextStreaming: endpointsOutputsTextStreaming,
                endpointsOutputsTextParams: endpointsOutputsTextParams,
                endpointsOutputsImagePassthroughParameters: endpointsOutputsImagePassthroughParameters,
                endpointsOutputsImagePricingType: endpointsOutputsImagePricingType,
                endpointsOutputsImagePricingCompletionUnit: endpointsOutputsImagePricingCompletionUnit,
                endpointsOutputsImagePricingCompletionCostUsd: endpointsOutputsImagePricingCompletionCostUsd,
                endpointsOutputsImagePricingCompletionOverridesCostUsd: endpointsOutputsImagePricingCompletionOverridesCostUsd,
                endpointsOutputsImagePricingCompletionUtcStart: endpointsOutputsImagePricingCompletionUtcStart,
                endpointsOutputsImagePricingCompletionUtcEnd: endpointsOutputsImagePricingCompletionUtcEnd,
                endpointsOutputsImagePricingCompletionUtcDays: endpointsOutputsImagePricingCompletionUtcDays,
                endpointsOutputsImagePricingInternalReasoningUnit: endpointsOutputsImagePricingInternalReasoningUnit,
                endpointsOutputsImagePricingInternalReasoningCostUsd: endpointsOutputsImagePricingInternalReasoningCostUsd,
                endpointsOutputsImagePricingInternalReasoningOverridesCostUsd: endpointsOutputsImagePricingInternalReasoningOverridesCostUsd,
                endpointsOutputsImagePricingInternalReasoningUtcStart: endpointsOutputsImagePricingInternalReasoningUtcStart,
                endpointsOutputsImagePricingInternalReasoningUtcEnd: endpointsOutputsImagePricingInternalReasoningUtcEnd,
                endpointsOutputsImagePricingInternalReasoningUtcDays: endpointsOutputsImagePricingInternalReasoningUtcDays,
                endpointsOutputsImageCapacityType: endpointsOutputsImageCapacityType,
                endpointsOutputsImageCapacityCompletionUnit: endpointsOutputsImageCapacityCompletionUnit,
                endpointsOutputsImageCapacityCompletionPer: endpointsOutputsImageCapacityCompletionPer,
                endpointsOutputsImageCapacityCompletionValue: endpointsOutputsImageCapacityCompletionValue,
                endpointsOutputsImageCapacityInternalReasoningUnit: endpointsOutputsImageCapacityInternalReasoningUnit,
                endpointsOutputsImageCapacityInternalReasoningPer: endpointsOutputsImageCapacityInternalReasoningPer,
                endpointsOutputsImageCapacityInternalReasoningValue: endpointsOutputsImageCapacityInternalReasoningValue,
                endpointsOutputsImageCapacityConcurrencyUnit: endpointsOutputsImageCapacityConcurrencyUnit,
                endpointsOutputsImageCapacityConcurrencyValue: endpointsOutputsImageCapacityConcurrencyValue,
                endpointsOutputsImageStreaming: endpointsOutputsImageStreaming,
                endpointsOutputsImageParams: endpointsOutputsImageParams,
                endpointsOutputsVideoPassthroughParameters: endpointsOutputsVideoPassthroughParameters,
                endpointsOutputsVideoPricingType: endpointsOutputsVideoPricingType,
                endpointsOutputsVideoPricingCompletionUnit: endpointsOutputsVideoPricingCompletionUnit,
                endpointsOutputsVideoPricingCompletionCostUsd: endpointsOutputsVideoPricingCompletionCostUsd,
                endpointsOutputsVideoPricingCompletionOverridesCostUsd: endpointsOutputsVideoPricingCompletionOverridesCostUsd,
                endpointsOutputsVideoPricingCompletionUtcStart: endpointsOutputsVideoPricingCompletionUtcStart,
                endpointsOutputsVideoPricingCompletionUtcEnd: endpointsOutputsVideoPricingCompletionUtcEnd,
                endpointsOutputsVideoPricingCompletionUtcDays: endpointsOutputsVideoPricingCompletionUtcDays,
                endpointsOutputsVideoPricingInternalReasoningUnit: endpointsOutputsVideoPricingInternalReasoningUnit,
                endpointsOutputsVideoPricingInternalReasoningCostUsd: endpointsOutputsVideoPricingInternalReasoningCostUsd,
                endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd: endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsVideoPricingInternalReasoningUtcStart: endpointsOutputsVideoPricingInternalReasoningUtcStart,
                endpointsOutputsVideoPricingInternalReasoningUtcEnd: endpointsOutputsVideoPricingInternalReasoningUtcEnd,
                endpointsOutputsVideoPricingInternalReasoningUtcDays: endpointsOutputsVideoPricingInternalReasoningUtcDays,
                endpointsOutputsVideoCapacityType: endpointsOutputsVideoCapacityType,
                endpointsOutputsVideoCapacityCompletionUnit: endpointsOutputsVideoCapacityCompletionUnit,
                endpointsOutputsVideoCapacityCompletionPer: endpointsOutputsVideoCapacityCompletionPer,
                endpointsOutputsVideoCapacityCompletionValue: endpointsOutputsVideoCapacityCompletionValue,
                endpointsOutputsVideoCapacityInternalReasoningUnit: endpointsOutputsVideoCapacityInternalReasoningUnit,
                endpointsOutputsVideoCapacityInternalReasoningPer: endpointsOutputsVideoCapacityInternalReasoningPer,
                endpointsOutputsVideoCapacityInternalReasoningValue: endpointsOutputsVideoCapacityInternalReasoningValue,
                endpointsOutputsVideoCapacityConcurrencyUnit: endpointsOutputsVideoCapacityConcurrencyUnit,
                endpointsOutputsVideoCapacityConcurrencyValue: endpointsOutputsVideoCapacityConcurrencyValue,
                endpointsOutputsVideoStreaming: endpointsOutputsVideoStreaming,
                endpointsOutputsVideoParams: endpointsOutputsVideoParams,
                endpointsOutputsSpeechPassthroughParameters: endpointsOutputsSpeechPassthroughParameters,
                endpointsOutputsSpeechPricingType: endpointsOutputsSpeechPricingType,
                endpointsOutputsSpeechPricingCompletionUnit: endpointsOutputsSpeechPricingCompletionUnit,
                endpointsOutputsSpeechPricingCompletionCostUsd: endpointsOutputsSpeechPricingCompletionCostUsd,
                endpointsOutputsSpeechPricingCompletionOverridesCostUsd: endpointsOutputsSpeechPricingCompletionOverridesCostUsd,
                endpointsOutputsSpeechPricingCompletionUtcStart: endpointsOutputsSpeechPricingCompletionUtcStart,
                endpointsOutputsSpeechPricingCompletionUtcEnd: endpointsOutputsSpeechPricingCompletionUtcEnd,
                endpointsOutputsSpeechPricingCompletionUtcDays: endpointsOutputsSpeechPricingCompletionUtcDays,
                endpointsOutputsSpeechPricingInternalReasoningUnit: endpointsOutputsSpeechPricingInternalReasoningUnit,
                endpointsOutputsSpeechPricingInternalReasoningCostUsd: endpointsOutputsSpeechPricingInternalReasoningCostUsd,
                endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd: endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsSpeechPricingInternalReasoningUtcStart: endpointsOutputsSpeechPricingInternalReasoningUtcStart,
                endpointsOutputsSpeechPricingInternalReasoningUtcEnd: endpointsOutputsSpeechPricingInternalReasoningUtcEnd,
                endpointsOutputsSpeechPricingInternalReasoningUtcDays: endpointsOutputsSpeechPricingInternalReasoningUtcDays,
                endpointsOutputsSpeechCapacityType: endpointsOutputsSpeechCapacityType,
                endpointsOutputsSpeechCapacityCompletionUnit: endpointsOutputsSpeechCapacityCompletionUnit,
                endpointsOutputsSpeechCapacityCompletionPer: endpointsOutputsSpeechCapacityCompletionPer,
                endpointsOutputsSpeechCapacityCompletionValue: endpointsOutputsSpeechCapacityCompletionValue,
                endpointsOutputsSpeechCapacityInternalReasoningUnit: endpointsOutputsSpeechCapacityInternalReasoningUnit,
                endpointsOutputsSpeechCapacityInternalReasoningPer: endpointsOutputsSpeechCapacityInternalReasoningPer,
                endpointsOutputsSpeechCapacityInternalReasoningValue: endpointsOutputsSpeechCapacityInternalReasoningValue,
                endpointsOutputsSpeechCapacityConcurrencyUnit: endpointsOutputsSpeechCapacityConcurrencyUnit,
                endpointsOutputsSpeechCapacityConcurrencyValue: endpointsOutputsSpeechCapacityConcurrencyValue,
                endpointsOutputsSpeechStreaming: endpointsOutputsSpeechStreaming,
                endpointsOutputsSpeechParams: endpointsOutputsSpeechParams,
                endpointsOutputsTranscriptionPassthroughParameters: endpointsOutputsTranscriptionPassthroughParameters,
                endpointsOutputsTranscriptionPricingType: endpointsOutputsTranscriptionPricingType,
                endpointsOutputsTranscriptionPricingCompletionUnit: endpointsOutputsTranscriptionPricingCompletionUnit,
                endpointsOutputsTranscriptionPricingCompletionCostUsd: endpointsOutputsTranscriptionPricingCompletionCostUsd,
                endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd: endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd,
                endpointsOutputsTranscriptionPricingCompletionUtcStart: endpointsOutputsTranscriptionPricingCompletionUtcStart,
                endpointsOutputsTranscriptionPricingCompletionUtcEnd: endpointsOutputsTranscriptionPricingCompletionUtcEnd,
                endpointsOutputsTranscriptionPricingCompletionUtcDays: endpointsOutputsTranscriptionPricingCompletionUtcDays,
                endpointsOutputsTranscriptionPricingInternalReasoningUnit: endpointsOutputsTranscriptionPricingInternalReasoningUnit,
                endpointsOutputsTranscriptionPricingInternalReasoningCostUsd: endpointsOutputsTranscriptionPricingInternalReasoningCostUsd,
                endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd: endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsTranscriptionPricingInternalReasoningUtcStart: endpointsOutputsTranscriptionPricingInternalReasoningUtcStart,
                endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd: endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd,
                endpointsOutputsTranscriptionPricingInternalReasoningUtcDays: endpointsOutputsTranscriptionPricingInternalReasoningUtcDays,
                endpointsOutputsTranscriptionCapacityType: endpointsOutputsTranscriptionCapacityType,
                endpointsOutputsTranscriptionCapacityCompletionUnit: endpointsOutputsTranscriptionCapacityCompletionUnit,
                endpointsOutputsTranscriptionCapacityCompletionPer: endpointsOutputsTranscriptionCapacityCompletionPer,
                endpointsOutputsTranscriptionCapacityCompletionValue: endpointsOutputsTranscriptionCapacityCompletionValue,
                endpointsOutputsTranscriptionCapacityInternalReasoningUnit: endpointsOutputsTranscriptionCapacityInternalReasoningUnit,
                endpointsOutputsTranscriptionCapacityInternalReasoningPer: endpointsOutputsTranscriptionCapacityInternalReasoningPer,
                endpointsOutputsTranscriptionCapacityInternalReasoningValue: endpointsOutputsTranscriptionCapacityInternalReasoningValue,
                endpointsOutputsTranscriptionCapacityConcurrencyUnit: endpointsOutputsTranscriptionCapacityConcurrencyUnit,
                endpointsOutputsTranscriptionCapacityConcurrencyValue: endpointsOutputsTranscriptionCapacityConcurrencyValue,
                endpointsOutputsTranscriptionStreaming: endpointsOutputsTranscriptionStreaming,
                endpointsOutputsTranscriptionParams: endpointsOutputsTranscriptionParams,
                endpointsOutputsEmbeddingsPassthroughParameters: endpointsOutputsEmbeddingsPassthroughParameters,
                endpointsOutputsEmbeddingsPricingType: endpointsOutputsEmbeddingsPricingType,
                endpointsOutputsEmbeddingsPricingCompletionUnit: endpointsOutputsEmbeddingsPricingCompletionUnit,
                endpointsOutputsEmbeddingsPricingCompletionCostUsd: endpointsOutputsEmbeddingsPricingCompletionCostUsd,
                endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd: endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd,
                endpointsOutputsEmbeddingsPricingCompletionUtcStart: endpointsOutputsEmbeddingsPricingCompletionUtcStart,
                endpointsOutputsEmbeddingsPricingCompletionUtcEnd: endpointsOutputsEmbeddingsPricingCompletionUtcEnd,
                endpointsOutputsEmbeddingsPricingCompletionUtcDays: endpointsOutputsEmbeddingsPricingCompletionUtcDays,
                endpointsOutputsEmbeddingsPricingInternalReasoningUnit: endpointsOutputsEmbeddingsPricingInternalReasoningUnit,
                endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd: endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd,
                endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd: endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart: endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart,
                endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd: endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd,
                endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays: endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays,
                endpointsOutputsEmbeddingsCapacityType: endpointsOutputsEmbeddingsCapacityType,
                endpointsOutputsEmbeddingsCapacityCompletionUnit: endpointsOutputsEmbeddingsCapacityCompletionUnit,
                endpointsOutputsEmbeddingsCapacityCompletionPer: endpointsOutputsEmbeddingsCapacityCompletionPer,
                endpointsOutputsEmbeddingsCapacityCompletionValue: endpointsOutputsEmbeddingsCapacityCompletionValue,
                endpointsOutputsEmbeddingsCapacityInternalReasoningUnit: endpointsOutputsEmbeddingsCapacityInternalReasoningUnit,
                endpointsOutputsEmbeddingsCapacityInternalReasoningPer: endpointsOutputsEmbeddingsCapacityInternalReasoningPer,
                endpointsOutputsEmbeddingsCapacityInternalReasoningValue: endpointsOutputsEmbeddingsCapacityInternalReasoningValue,
                endpointsOutputsEmbeddingsCapacityConcurrencyUnit: endpointsOutputsEmbeddingsCapacityConcurrencyUnit,
                endpointsOutputsEmbeddingsCapacityConcurrencyValue: endpointsOutputsEmbeddingsCapacityConcurrencyValue,
                endpointsOutputsEmbeddingsParams: endpointsOutputsEmbeddingsParams,
                endpointsOutputsRerankPassthroughParameters: endpointsOutputsRerankPassthroughParameters,
                endpointsOutputsRerankPricingType: endpointsOutputsRerankPricingType,
                endpointsOutputsRerankPricingCompletionUnit: endpointsOutputsRerankPricingCompletionUnit,
                endpointsOutputsRerankPricingCompletionCostUsd: endpointsOutputsRerankPricingCompletionCostUsd,
                endpointsOutputsRerankPricingCompletionOverridesCostUsd: endpointsOutputsRerankPricingCompletionOverridesCostUsd,
                endpointsOutputsRerankPricingCompletionUtcStart: endpointsOutputsRerankPricingCompletionUtcStart,
                endpointsOutputsRerankPricingCompletionUtcEnd: endpointsOutputsRerankPricingCompletionUtcEnd,
                endpointsOutputsRerankPricingCompletionUtcDays: endpointsOutputsRerankPricingCompletionUtcDays,
                endpointsOutputsRerankPricingInternalReasoningUnit: endpointsOutputsRerankPricingInternalReasoningUnit,
                endpointsOutputsRerankPricingInternalReasoningCostUsd: endpointsOutputsRerankPricingInternalReasoningCostUsd,
                endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd: endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsRerankPricingInternalReasoningUtcStart: endpointsOutputsRerankPricingInternalReasoningUtcStart,
                endpointsOutputsRerankPricingInternalReasoningUtcEnd: endpointsOutputsRerankPricingInternalReasoningUtcEnd,
                endpointsOutputsRerankPricingInternalReasoningUtcDays: endpointsOutputsRerankPricingInternalReasoningUtcDays,
                endpointsOutputsRerankCapacityType: endpointsOutputsRerankCapacityType,
                endpointsOutputsRerankCapacityCompletionUnit: endpointsOutputsRerankCapacityCompletionUnit,
                endpointsOutputsRerankCapacityCompletionPer: endpointsOutputsRerankCapacityCompletionPer,
                endpointsOutputsRerankCapacityCompletionValue: endpointsOutputsRerankCapacityCompletionValue,
                endpointsOutputsRerankCapacityInternalReasoningUnit: endpointsOutputsRerankCapacityInternalReasoningUnit,
                endpointsOutputsRerankCapacityInternalReasoningPer: endpointsOutputsRerankCapacityInternalReasoningPer,
                endpointsOutputsRerankCapacityInternalReasoningValue: endpointsOutputsRerankCapacityInternalReasoningValue,
                endpointsOutputsRerankCapacityConcurrencyUnit: endpointsOutputsRerankCapacityConcurrencyUnit,
                endpointsOutputsRerankCapacityConcurrencyValue: endpointsOutputsRerankCapacityConcurrencyValue,
                endpointsOutputsRerankParams: endpointsOutputsRerankParams,
                endpointsOutputsDecisionsPassthroughParameters: endpointsOutputsDecisionsPassthroughParameters,
                endpointsOutputsDecisionsPricingType: endpointsOutputsDecisionsPricingType,
                endpointsOutputsDecisionsPricingCompletionUnit: endpointsOutputsDecisionsPricingCompletionUnit,
                endpointsOutputsDecisionsPricingCompletionCostUsd: endpointsOutputsDecisionsPricingCompletionCostUsd,
                endpointsOutputsDecisionsPricingCompletionOverridesCostUsd: endpointsOutputsDecisionsPricingCompletionOverridesCostUsd,
                endpointsOutputsDecisionsPricingCompletionUtcStart: endpointsOutputsDecisionsPricingCompletionUtcStart,
                endpointsOutputsDecisionsPricingCompletionUtcEnd: endpointsOutputsDecisionsPricingCompletionUtcEnd,
                endpointsOutputsDecisionsPricingCompletionUtcDays: endpointsOutputsDecisionsPricingCompletionUtcDays,
                endpointsOutputsDecisionsPricingInternalReasoningUnit: endpointsOutputsDecisionsPricingInternalReasoningUnit,
                endpointsOutputsDecisionsPricingInternalReasoningCostUsd: endpointsOutputsDecisionsPricingInternalReasoningCostUsd,
                endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd: endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsDecisionsPricingInternalReasoningUtcStart: endpointsOutputsDecisionsPricingInternalReasoningUtcStart,
                endpointsOutputsDecisionsPricingInternalReasoningUtcEnd: endpointsOutputsDecisionsPricingInternalReasoningUtcEnd,
                endpointsOutputsDecisionsPricingInternalReasoningUtcDays: endpointsOutputsDecisionsPricingInternalReasoningUtcDays,
                endpointsOutputsDecisionsCapacityType: endpointsOutputsDecisionsCapacityType,
                endpointsOutputsDecisionsCapacityCompletionUnit: endpointsOutputsDecisionsCapacityCompletionUnit,
                endpointsOutputsDecisionsCapacityCompletionPer: endpointsOutputsDecisionsCapacityCompletionPer,
                endpointsOutputsDecisionsCapacityCompletionValue: endpointsOutputsDecisionsCapacityCompletionValue,
                endpointsOutputsDecisionsCapacityInternalReasoningUnit: endpointsOutputsDecisionsCapacityInternalReasoningUnit,
                endpointsOutputsDecisionsCapacityInternalReasoningPer: endpointsOutputsDecisionsCapacityInternalReasoningPer,
                endpointsOutputsDecisionsCapacityInternalReasoningValue: endpointsOutputsDecisionsCapacityInternalReasoningValue,
                endpointsOutputsDecisionsCapacityConcurrencyUnit: endpointsOutputsDecisionsCapacityConcurrencyUnit,
                endpointsOutputsDecisionsCapacityConcurrencyValue: endpointsOutputsDecisionsCapacityConcurrencyValue,
                endpointsOutputsDecisionsParams: endpointsOutputsDecisionsParams,
                endpointsOutputsAudioPassthroughParameters: endpointsOutputsAudioPassthroughParameters,
                endpointsOutputsAudioPricingType: endpointsOutputsAudioPricingType,
                endpointsOutputsAudioPricingCompletionUnit: endpointsOutputsAudioPricingCompletionUnit,
                endpointsOutputsAudioPricingCompletionCostUsd: endpointsOutputsAudioPricingCompletionCostUsd,
                endpointsOutputsAudioPricingCompletionOverridesCostUsd: endpointsOutputsAudioPricingCompletionOverridesCostUsd,
                endpointsOutputsAudioPricingCompletionUtcStart: endpointsOutputsAudioPricingCompletionUtcStart,
                endpointsOutputsAudioPricingCompletionUtcEnd: endpointsOutputsAudioPricingCompletionUtcEnd,
                endpointsOutputsAudioPricingCompletionUtcDays: endpointsOutputsAudioPricingCompletionUtcDays,
                endpointsOutputsAudioPricingInternalReasoningUnit: endpointsOutputsAudioPricingInternalReasoningUnit,
                endpointsOutputsAudioPricingInternalReasoningCostUsd: endpointsOutputsAudioPricingInternalReasoningCostUsd,
                endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd: endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsAudioPricingInternalReasoningUtcStart: endpointsOutputsAudioPricingInternalReasoningUtcStart,
                endpointsOutputsAudioPricingInternalReasoningUtcEnd: endpointsOutputsAudioPricingInternalReasoningUtcEnd,
                endpointsOutputsAudioPricingInternalReasoningUtcDays: endpointsOutputsAudioPricingInternalReasoningUtcDays,
                endpointsOutputsAudioCapacityType: endpointsOutputsAudioCapacityType,
                endpointsOutputsAudioCapacityCompletionUnit: endpointsOutputsAudioCapacityCompletionUnit,
                endpointsOutputsAudioCapacityCompletionPer: endpointsOutputsAudioCapacityCompletionPer,
                endpointsOutputsAudioCapacityCompletionValue: endpointsOutputsAudioCapacityCompletionValue,
                endpointsOutputsAudioCapacityInternalReasoningUnit: endpointsOutputsAudioCapacityInternalReasoningUnit,
                endpointsOutputsAudioCapacityInternalReasoningPer: endpointsOutputsAudioCapacityInternalReasoningPer,
                endpointsOutputsAudioCapacityInternalReasoningValue: endpointsOutputsAudioCapacityInternalReasoningValue,
                endpointsOutputsAudioCapacityConcurrencyUnit: endpointsOutputsAudioCapacityConcurrencyUnit,
                endpointsOutputsAudioCapacityConcurrencyValue: endpointsOutputsAudioCapacityConcurrencyValue,
                endpointsOutputsAudioStreaming: endpointsOutputsAudioStreaming,
                endpointsOutputsAudioParams: endpointsOutputsAudioParams,
                endpointsProviderSlug: endpointsProviderSlug,
                endpointsProviderTag: endpointsProviderTag,
                endpointsProviderName: endpointsProviderName,
                endpointsDataPolicyTraining: endpointsDataPolicyTraining,
                endpointsDataPolicyRetainsPrompts: endpointsDataPolicyRetainsPrompts,
                endpointsDataPolicyRetentionDays: endpointsDataPolicyRetentionDays,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List models with V2 endpoint documents<br/>
        /// Returns every publicly served model together with each of its endpoints in the Models API V2 document format. The V2 document is the schema providers publish to OpenRouter, so each endpoint is reported in the shape it was declared, with pricing attached to the modality it applies to (`inputs`/`outputs`, each with its `params`). Operator-only fields such as capacity and `discount_to_user` are not part of the public document.<br/>
        /// Without credentials the response is the public catalog. With an API key it is the catalog that key can route to, the same one `GET /api/v1/models/user` serves: models and endpoints the account was granted private access to are included, and endpoints the account or key guardrails, provider preferences, BYOK and privacy settings exclude are omitted, along with routers and aliases left with nothing to route to. A key that does not resolve is rejected with 401.<br/>
        /// Every field of the response document is a filter, named by its dotted JSON path: `&lt;path&gt;=&lt;value&gt;` tests equality and `&lt;path&gt;.&lt;operator&gt;=&lt;value&gt;` applies `gt`, `gte`, `lt`, `lte`, `between`, `in`, `exists`, `contains`, `starts_with` or `ends_with` as the field type allows; `&lt;path&gt;.not.&lt;operator&gt;=&lt;value&gt;` (or `&lt;path&gt;.not=&lt;value&gt;` for not-equal) keeps the records where no value matches. Suffixes, arithmetic operators, parentheses and the list comma are read before percent-decoding, so an encoded character is always literal: a map key spelled like an operator or `not` is reached by encoding one of its characters (`params.n%6Ft.exists=true`), a `/` or `+` inside a literal is `%2F` or `%2B`, and arithmetic is spelled with the bare characters (`created/10`, `context_length+1`). `in` takes a comma-separated list and `between` the inclusive lower and upper bound (a literal comma is `%2C`); strings compare trimmed and lower-cased on both sides, so `author=Anthropic` and `name.contains=claude` match. A filter under `endpoints.` keeps only the endpoints that satisfy every such filter and omits models left with none. A path through a repeated object is existential (`endpoints.pricing.type=request` matches an endpoint with some request-priced entry); the members of a typed collection are addressed by their type (`endpoints.inputs.text.params.max_length.value.gte=1000000`, `endpoints.inputs.text.pricing.prompt.cost_usd.lte=0.000001`), and a dynamic key is written in the path (`endpoints.outputs.text.params.tools.type=boolean`, `endpoints.outputs.text.params.temperature.range.max.gte=2`). Both sides of an operator are operands of one grammar: a literal, a path, or an arithmetic expression over numeric paths and numbers, so a filter relates any two of them (`endpoints.inputs.text.pricing.prompt.cost_usd.gte=endpoints.outputs.text.pricing.completion.cost_usd*100`, `10000.lte=endpoints.inputs.text.params.max_length.value`, `endpoints.id=id`). Arithmetic requires numeric paths, each operator applies to the type its operands share, and text that names no field path is a literal (`id=openai/gpt-4`), so the field names at the root of the document are reserved words. A parameter that is not a field path is rejected with a 400 whose `error.metadata` names the `code`, `parameter` and `reason`.<br/>
        /// `sort` takes comma-separated paths or expressions, `-` prefixed for descending; a key must be a scalar path or expression (`created`, `endpoints.inputs.text.pricing.prompt.cost_usd`); a model sorts by the best value in the sort direction across its endpoints and across the time windows of a price, missing values sort last and `id` ascending breaks ties, so the order is total even without `sort`. Pagination is opt-in: pass `limit` and follow `links.next`, which carries an opaque `cursor` bound to the filters and sort; `offset` remains supported. `total_count` is the number of models matching the filters.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip (0 when omitted); kept for compatibility, prefer `cursor`. Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (500 when omitted, max 1000). Supplying limit, cursor or offset paginates the list; when all are omitted, the full list is returned.<br/>
        /// Example: 500
        /// </param>
        /// <param name="cursor">
        /// Opaque keyset cursor from the previous page's `links.next`. Bound to the filters and sort it was issued for; a cursor sent with different filters or sort is rejected.<br/>
        /// Example: eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ
        /// </param>
        /// <param name="region">
        /// Only return endpoints in the given data region ("eu" or "us"); models left without an endpoint are omitted.<br/>
        /// Example: eu
        /// </param>
        /// <param name="sort">
        /// Comma-separated sort keys, each a path below or an arithmetic expression over numeric paths; prefix with `-` for descending. A key under `endpoints.` ranks each model by its best endpoint value in the sort direction. Missing values sort last and `id` ascending breaks ties. Keys: `id`, `canonical_slug`, `author`, `name`, `variant`, `kind`, `alias_target.slug`, `alias_target.name`, `created`, `description`, `context_length`, `hugging_face_id`, `endpoints.schema_version`, `endpoints.id`, `endpoints.hugging_face_id`, `endpoints.name`, `endpoints.created`, `endpoints.quantization`, `endpoints.tokenizer`, `endpoints.description`, `endpoints.pricing.request.unit`, `endpoints.pricing.request.cost_usd`, `endpoints.pricing.web_search.unit`, `endpoints.pricing.web_search.cost_usd`, `endpoints.capacity.request.unit`, `endpoints.capacity.request.per`, `endpoints.capacity.request.value`, `endpoints.capacity.web_search.unit`, `endpoints.capacity.web_search.per`, `endpoints.capacity.web_search.value`, `endpoints.capacity.concurrency.unit`, `endpoints.capacity.concurrency.value`, `endpoints.deprecation_date`, `endpoints.is_ready`, `endpoints.is_free`, `endpoints.service_tier`, `endpoints.discount_to_user`, `endpoints.openrouter.slug`, `endpoints.deployment_region`, `endpoints.inputs.text.pricing.prompt.unit`, `endpoints.inputs.text.pricing.prompt.cost_usd`, `endpoints.inputs.text.pricing.prompt.utc_start`, `endpoints.inputs.text.pricing.prompt.utc_end`, `endpoints.inputs.text.pricing.cached_prompt.unit`, `endpoints.inputs.text.pricing.cached_prompt.cost_usd`, `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.text.pricing.cached_prompt.implicit`, `endpoints.inputs.text.pricing.cached_prompt.utc_start`, `endpoints.inputs.text.pricing.cached_prompt.utc_end`, `endpoints.inputs.text.pricing.cache_write.unit`, `endpoints.inputs.text.pricing.cache_write.cost_usd`, `endpoints.inputs.text.pricing.cache_write.ttl_seconds`, `endpoints.inputs.text.pricing.cache_write.implicit`, `endpoints.inputs.text.pricing.cache_write.utc_start`, `endpoints.inputs.text.pricing.cache_write.utc_end`, `endpoints.inputs.text.capacity.prompt.unit`, `endpoints.inputs.text.capacity.prompt.per`, `endpoints.inputs.text.capacity.prompt.value`, `endpoints.inputs.text.capacity.cached_prompt.unit`, `endpoints.inputs.text.capacity.cached_prompt.per`, `endpoints.inputs.text.capacity.cached_prompt.value`, `endpoints.inputs.text.capacity.cache_write.unit`, `endpoints.inputs.text.capacity.cache_write.per`, `endpoints.inputs.text.capacity.cache_write.value`, `endpoints.inputs.text.params.max_prompt_length.value`, `endpoints.inputs.text.params.max_prompt_length.unit`, `endpoints.inputs.text.params.max_length.value`, `endpoints.inputs.text.params.max_length.unit`, `endpoints.inputs.image.pricing.prompt.unit`, `endpoints.inputs.image.pricing.prompt.cost_usd`, `endpoints.inputs.image.pricing.prompt.utc_start`, `endpoints.inputs.image.pricing.prompt.utc_end`, `endpoints.inputs.image.pricing.cached_prompt.unit`, `endpoints.inputs.image.pricing.cached_prompt.cost_usd`, `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.image.pricing.cached_prompt.implicit`, `endpoints.inputs.image.pricing.cached_prompt.utc_start`, `endpoints.inputs.image.pricing.cached_prompt.utc_end`, `endpoints.inputs.image.pricing.cache_write.unit`, `endpoints.inputs.image.pricing.cache_write.cost_usd`, `endpoints.inputs.image.pricing.cache_write.ttl_seconds`, `endpoints.inputs.image.pricing.cache_write.implicit`, `endpoints.inputs.image.pricing.cache_write.utc_start`, `endpoints.inputs.image.pricing.cache_write.utc_end`, `endpoints.inputs.image.capacity.prompt.unit`, `endpoints.inputs.image.capacity.prompt.per`, `endpoints.inputs.image.capacity.prompt.value`, `endpoints.inputs.image.capacity.cached_prompt.unit`, `endpoints.inputs.image.capacity.cached_prompt.per`, `endpoints.inputs.image.capacity.cached_prompt.value`, `endpoints.inputs.image.capacity.cache_write.unit`, `endpoints.inputs.image.capacity.cache_write.per`, `endpoints.inputs.image.capacity.cache_write.value`, `endpoints.inputs.image.params.sources.type`, `endpoints.inputs.image.params.formats.type`, `endpoints.inputs.image.params.detail_levels.type`, `endpoints.inputs.image.params.references.type`, `endpoints.inputs.image.params.references.min`, `endpoints.inputs.image.params.references.max`, `endpoints.inputs.image.params.references.unit`, `endpoints.inputs.image.params.role.type`, `endpoints.inputs.image.params.max_content_size_bytes.value`, `endpoints.inputs.image.params.max_content_size_bytes.unit`, `endpoints.inputs.video.pricing.prompt.unit`, `endpoints.inputs.video.pricing.prompt.cost_usd`, `endpoints.inputs.video.pricing.prompt.utc_start`, `endpoints.inputs.video.pricing.prompt.utc_end`, `endpoints.inputs.video.pricing.cached_prompt.unit`, `endpoints.inputs.video.pricing.cached_prompt.cost_usd`, `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.video.pricing.cached_prompt.implicit`, `endpoints.inputs.video.pricing.cached_prompt.utc_start`, `endpoints.inputs.video.pricing.cached_prompt.utc_end`, `endpoints.inputs.video.pricing.cache_write.unit`, `endpoints.inputs.video.pricing.cache_write.cost_usd`, `endpoints.inputs.video.pricing.cache_write.ttl_seconds`, `endpoints.inputs.video.pricing.cache_write.implicit`, `endpoints.inputs.video.pricing.cache_write.utc_start`, `endpoints.inputs.video.pricing.cache_write.utc_end`, `endpoints.inputs.video.capacity.prompt.unit`, `endpoints.inputs.video.capacity.prompt.per`, `endpoints.inputs.video.capacity.prompt.value`, `endpoints.inputs.video.capacity.cached_prompt.unit`, `endpoints.inputs.video.capacity.cached_prompt.per`, `endpoints.inputs.video.capacity.cached_prompt.value`, `endpoints.inputs.video.capacity.cache_write.unit`, `endpoints.inputs.video.capacity.cache_write.per`, `endpoints.inputs.video.capacity.cache_write.value`, `endpoints.inputs.video.params.sources.type`, `endpoints.inputs.video.params.formats.type`, `endpoints.inputs.video.params.max_duration_seconds.value`, `endpoints.inputs.video.params.max_duration_seconds.unit`, `endpoints.inputs.video.params.max_content_size_bytes.value`, `endpoints.inputs.video.params.max_content_size_bytes.unit`, `endpoints.inputs.audio.pricing.prompt.unit`, `endpoints.inputs.audio.pricing.prompt.cost_usd`, `endpoints.inputs.audio.pricing.prompt.utc_start`, `endpoints.inputs.audio.pricing.prompt.utc_end`, `endpoints.inputs.audio.pricing.cached_prompt.unit`, `endpoints.inputs.audio.pricing.cached_prompt.cost_usd`, `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.audio.pricing.cached_prompt.implicit`, `endpoints.inputs.audio.pricing.cached_prompt.utc_start`, `endpoints.inputs.audio.pricing.cached_prompt.utc_end`, `endpoints.inputs.audio.pricing.cache_write.unit`, `endpoints.inputs.audio.pricing.cache_write.cost_usd`, `endpoints.inputs.audio.pricing.cache_write.ttl_seconds`, `endpoints.inputs.audio.pricing.cache_write.implicit`, `endpoints.inputs.audio.pricing.cache_write.utc_start`, `endpoints.inputs.audio.pricing.cache_write.utc_end`, `endpoints.inputs.audio.capacity.prompt.unit`, `endpoints.inputs.audio.capacity.prompt.per`, `endpoints.inputs.audio.capacity.prompt.value`, `endpoints.inputs.audio.capacity.cached_prompt.unit`, `endpoints.inputs.audio.capacity.cached_prompt.per`, `endpoints.inputs.audio.capacity.cached_prompt.value`, `endpoints.inputs.audio.capacity.cache_write.unit`, `endpoints.inputs.audio.capacity.cache_write.per`, `endpoints.inputs.audio.capacity.cache_write.value`, `endpoints.inputs.audio.params.sources.type`, `endpoints.inputs.audio.params.formats.type`, `endpoints.inputs.audio.params.max_duration_seconds.value`, `endpoints.inputs.audio.params.max_duration_seconds.unit`, `endpoints.inputs.audio.params.max_content_size_bytes.value`, `endpoints.inputs.audio.params.max_content_size_bytes.unit`, `endpoints.inputs.file.pricing.prompt.unit`, `endpoints.inputs.file.pricing.prompt.cost_usd`, `endpoints.inputs.file.pricing.prompt.utc_start`, `endpoints.inputs.file.pricing.prompt.utc_end`, `endpoints.inputs.file.pricing.cached_prompt.unit`, `endpoints.inputs.file.pricing.cached_prompt.cost_usd`, `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds`, `endpoints.inputs.file.pricing.cached_prompt.implicit`, `endpoints.inputs.file.pricing.cached_prompt.utc_start`, `endpoints.inputs.file.pricing.cached_prompt.utc_end`, `endpoints.inputs.file.pricing.cache_write.unit`, `endpoints.inputs.file.pricing.cache_write.cost_usd`, `endpoints.inputs.file.pricing.cache_write.ttl_seconds`, `endpoints.inputs.file.pricing.cache_write.implicit`, `endpoints.inputs.file.pricing.cache_write.utc_start`, `endpoints.inputs.file.pricing.cache_write.utc_end`, `endpoints.inputs.file.capacity.prompt.unit`, `endpoints.inputs.file.capacity.prompt.per`, `endpoints.inputs.file.capacity.prompt.value`, `endpoints.inputs.file.capacity.cached_prompt.unit`, `endpoints.inputs.file.capacity.cached_prompt.per`, `endpoints.inputs.file.capacity.cached_prompt.value`, `endpoints.inputs.file.capacity.cache_write.unit`, `endpoints.inputs.file.capacity.cache_write.per`, `endpoints.inputs.file.capacity.cache_write.value`, `endpoints.inputs.file.params.sources.type`, `endpoints.inputs.file.params.formats.type`, `endpoints.inputs.file.params.references.type`, `endpoints.inputs.file.params.references.min`, `endpoints.inputs.file.params.references.max`, `endpoints.inputs.file.params.references.unit`, `endpoints.inputs.file.params.max_content_size_bytes.value`, `endpoints.inputs.file.params.max_content_size_bytes.unit`, `endpoints.outputs.text.max_length.value`, `endpoints.outputs.text.max_length.unit`, `endpoints.outputs.text.pricing.completion.unit`, `endpoints.outputs.text.pricing.completion.cost_usd`, `endpoints.outputs.text.pricing.completion.utc_start`, `endpoints.outputs.text.pricing.completion.utc_end`, `endpoints.outputs.text.pricing.internal_reasoning.unit`, `endpoints.outputs.text.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.text.pricing.internal_reasoning.utc_start`, `endpoints.outputs.text.pricing.internal_reasoning.utc_end`, `endpoints.outputs.text.capacity.completion.unit`, `endpoints.outputs.text.capacity.completion.per`, `endpoints.outputs.text.capacity.completion.value`, `endpoints.outputs.text.capacity.internal_reasoning.unit`, `endpoints.outputs.text.capacity.internal_reasoning.per`, `endpoints.outputs.text.capacity.internal_reasoning.value`, `endpoints.outputs.text.capacity.concurrency.unit`, `endpoints.outputs.text.capacity.concurrency.value`, `endpoints.outputs.text.streaming`, `endpoints.outputs.image.pricing.completion.unit`, `endpoints.outputs.image.pricing.completion.cost_usd`, `endpoints.outputs.image.pricing.completion.utc_start`, `endpoints.outputs.image.pricing.completion.utc_end`, `endpoints.outputs.image.pricing.internal_reasoning.unit`, `endpoints.outputs.image.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.image.pricing.internal_reasoning.utc_start`, `endpoints.outputs.image.pricing.internal_reasoning.utc_end`, `endpoints.outputs.image.capacity.completion.unit`, `endpoints.outputs.image.capacity.completion.per`, `endpoints.outputs.image.capacity.completion.value`, `endpoints.outputs.image.capacity.internal_reasoning.unit`, `endpoints.outputs.image.capacity.internal_reasoning.per`, `endpoints.outputs.image.capacity.internal_reasoning.value`, `endpoints.outputs.image.capacity.concurrency.unit`, `endpoints.outputs.image.capacity.concurrency.value`, `endpoints.outputs.image.streaming`, `endpoints.outputs.video.pricing.completion.unit`, `endpoints.outputs.video.pricing.completion.cost_usd`, `endpoints.outputs.video.pricing.completion.utc_start`, `endpoints.outputs.video.pricing.completion.utc_end`, `endpoints.outputs.video.pricing.internal_reasoning.unit`, `endpoints.outputs.video.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.video.pricing.internal_reasoning.utc_start`, `endpoints.outputs.video.pricing.internal_reasoning.utc_end`, `endpoints.outputs.video.capacity.completion.unit`, `endpoints.outputs.video.capacity.completion.per`, `endpoints.outputs.video.capacity.completion.value`, `endpoints.outputs.video.capacity.internal_reasoning.unit`, `endpoints.outputs.video.capacity.internal_reasoning.per`, `endpoints.outputs.video.capacity.internal_reasoning.value`, `endpoints.outputs.video.capacity.concurrency.unit`, `endpoints.outputs.video.capacity.concurrency.value`, `endpoints.outputs.video.streaming`, `endpoints.outputs.speech.pricing.completion.unit`, `endpoints.outputs.speech.pricing.completion.cost_usd`, `endpoints.outputs.speech.pricing.completion.utc_start`, `endpoints.outputs.speech.pricing.completion.utc_end`, `endpoints.outputs.speech.pricing.internal_reasoning.unit`, `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_start`, `endpoints.outputs.speech.pricing.internal_reasoning.utc_end`, `endpoints.outputs.speech.capacity.completion.unit`, `endpoints.outputs.speech.capacity.completion.per`, `endpoints.outputs.speech.capacity.completion.value`, `endpoints.outputs.speech.capacity.internal_reasoning.unit`, `endpoints.outputs.speech.capacity.internal_reasoning.per`, `endpoints.outputs.speech.capacity.internal_reasoning.value`, `endpoints.outputs.speech.capacity.concurrency.unit`, `endpoints.outputs.speech.capacity.concurrency.value`, `endpoints.outputs.speech.streaming`, `endpoints.outputs.transcription.pricing.completion.unit`, `endpoints.outputs.transcription.pricing.completion.cost_usd`, `endpoints.outputs.transcription.pricing.completion.utc_start`, `endpoints.outputs.transcription.pricing.completion.utc_end`, `endpoints.outputs.transcription.pricing.internal_reasoning.unit`, `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start`, `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end`, `endpoints.outputs.transcription.capacity.completion.unit`, `endpoints.outputs.transcription.capacity.completion.per`, `endpoints.outputs.transcription.capacity.completion.value`, `endpoints.outputs.transcription.capacity.internal_reasoning.unit`, `endpoints.outputs.transcription.capacity.internal_reasoning.per`, `endpoints.outputs.transcription.capacity.internal_reasoning.value`, `endpoints.outputs.transcription.capacity.concurrency.unit`, `endpoints.outputs.transcription.capacity.concurrency.value`, `endpoints.outputs.transcription.streaming`, `endpoints.outputs.embeddings.pricing.completion.unit`, `endpoints.outputs.embeddings.pricing.completion.cost_usd`, `endpoints.outputs.embeddings.pricing.completion.utc_start`, `endpoints.outputs.embeddings.pricing.completion.utc_end`, `endpoints.outputs.embeddings.pricing.internal_reasoning.unit`, `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start`, `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end`, `endpoints.outputs.embeddings.capacity.completion.unit`, `endpoints.outputs.embeddings.capacity.completion.per`, `endpoints.outputs.embeddings.capacity.completion.value`, `endpoints.outputs.embeddings.capacity.internal_reasoning.unit`, `endpoints.outputs.embeddings.capacity.internal_reasoning.per`, `endpoints.outputs.embeddings.capacity.internal_reasoning.value`, `endpoints.outputs.embeddings.capacity.concurrency.unit`, `endpoints.outputs.embeddings.capacity.concurrency.value`, `endpoints.outputs.rerank.pricing.completion.unit`, `endpoints.outputs.rerank.pricing.completion.cost_usd`, `endpoints.outputs.rerank.pricing.completion.utc_start`, `endpoints.outputs.rerank.pricing.completion.utc_end`, `endpoints.outputs.rerank.pricing.internal_reasoning.unit`, `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start`, `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end`, `endpoints.outputs.rerank.capacity.completion.unit`, `endpoints.outputs.rerank.capacity.completion.per`, `endpoints.outputs.rerank.capacity.completion.value`, `endpoints.outputs.rerank.capacity.internal_reasoning.unit`, `endpoints.outputs.rerank.capacity.internal_reasoning.per`, `endpoints.outputs.rerank.capacity.internal_reasoning.value`, `endpoints.outputs.rerank.capacity.concurrency.unit`, `endpoints.outputs.rerank.capacity.concurrency.value`, `endpoints.outputs.decisions.pricing.completion.unit`, `endpoints.outputs.decisions.pricing.completion.cost_usd`, `endpoints.outputs.decisions.pricing.completion.utc_start`, `endpoints.outputs.decisions.pricing.completion.utc_end`, `endpoints.outputs.decisions.pricing.internal_reasoning.unit`, `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start`, `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end`, `endpoints.outputs.decisions.capacity.completion.unit`, `endpoints.outputs.decisions.capacity.completion.per`, `endpoints.outputs.decisions.capacity.completion.value`, `endpoints.outputs.decisions.capacity.internal_reasoning.unit`, `endpoints.outputs.decisions.capacity.internal_reasoning.per`, `endpoints.outputs.decisions.capacity.internal_reasoning.value`, `endpoints.outputs.decisions.capacity.concurrency.unit`, `endpoints.outputs.decisions.capacity.concurrency.value`, `endpoints.outputs.audio.pricing.completion.unit`, `endpoints.outputs.audio.pricing.completion.cost_usd`, `endpoints.outputs.audio.pricing.completion.utc_start`, `endpoints.outputs.audio.pricing.completion.utc_end`, `endpoints.outputs.audio.pricing.internal_reasoning.unit`, `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_start`, `endpoints.outputs.audio.pricing.internal_reasoning.utc_end`, `endpoints.outputs.audio.capacity.completion.unit`, `endpoints.outputs.audio.capacity.completion.per`, `endpoints.outputs.audio.capacity.completion.value`, `endpoints.outputs.audio.capacity.internal_reasoning.unit`, `endpoints.outputs.audio.capacity.internal_reasoning.per`, `endpoints.outputs.audio.capacity.internal_reasoning.value`, `endpoints.outputs.audio.capacity.concurrency.unit`, `endpoints.outputs.audio.capacity.concurrency.value`, `endpoints.outputs.audio.streaming`, `endpoints.provider.slug`, `endpoints.provider.tag`, `endpoints.provider.name`, `endpoints.data_policy.training`, `endpoints.data_policy.retains_prompts`, `endpoints.data_policy.retention_days`.<br/>
        /// Example: -created,endpoints.inputs.text.pricing.prompt.cost_usd
        /// </param>
        /// <param name="id">
        /// Filter where the value at `id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="canonicalSlug">
        /// Filter where the value at `canonical_slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="author">
        /// Filter where the value at `author` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="name">
        /// Filter where the value at `name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="variant">
        /// Filter where the value at `variant` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `free`, `extended`, `standard`, `thinking`, `batch`.
        /// </param>
        /// <param name="kind">
        /// Filter where the value at `kind` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `model`, `router`, `alias`.
        /// </param>
        /// <param name="aliasTargetSlug">
        /// Filter where the value at `alias_target.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="aliasTargetName">
        /// Filter where the value at `alias_target.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="created">
        /// Filter where the value at `created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="description">
        /// Filter where the value at `description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="contextLength">
        /// Filter where the value at `context_length` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="huggingFaceId">
        /// Filter where the value at `hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="inputs">
        /// Filter where any element at `inputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `file`, `audio`, `video`.
        /// </param>
        /// <param name="outputs">
        /// Filter where any element at `outputs` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `embeddings`, `audio`, `video`, `rerank`, `decisions`, `speech`, `transcription`.
        /// </param>
        /// <param name="endpointsSchemaVersion">
        /// Filter where the value at `endpoints.schema_version` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsId">
        /// Filter where the value at `endpoints.id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsHuggingFaceId">
        /// Filter where the value at `endpoints.hugging_face_id` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsName">
        /// Filter where the value at `endpoints.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCreated">
        /// Filter where the value at `endpoints.created` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsQuantization">
        /// Filter where the value at `endpoints.quantization` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `int4`, `int8`, `fp4`, `mxfp4`, `nvfp4`, `fp6`, `fp8`, `mxfp8`, `fp16`, `bf16`, `fp32`.
        /// </param>
        /// <param name="endpointsTokenizer">
        /// Filter where the value at `endpoints.tokenizer` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDescription">
        /// Filter where the value at `endpoints.description` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingType">
        /// Filter where any value at `endpoints.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`.
        /// </param>
        /// <param name="endpointsPricingRequestUnit">
        /// Filter where the value at `endpoints.pricing.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsPricingRequestCostUsd">
        /// Filter where the value at `endpoints.pricing.request.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingRequestOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.request.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchUnit">
        /// Filter where the value at `endpoints.pricing.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsPricingWebSearchCostUsd">
        /// Filter where the value at `endpoints.pricing.web_search.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPricingWebSearchOverridesCostUsd">
        /// Filter where any value at `endpoints.pricing.web_search.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityType">
        /// Filter where any value at `endpoints.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`, `web_search`, `concurrency`.
        /// </param>
        /// <param name="endpointsCapacityRequestUnit">
        /// Filter where the value at `endpoints.capacity.request.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityRequestPer">
        /// Filter where the value at `endpoints.capacity.request.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityRequestValue">
        /// Filter where the value at `endpoints.capacity.request.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityWebSearchUnit">
        /// Filter where the value at `endpoints.capacity.web_search.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `search`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchPer">
        /// Filter where the value at `endpoints.capacity.web_search.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsCapacityWebSearchValue">
        /// Filter where the value at `endpoints.capacity.web_search.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsPassthroughParameters">
        /// Filter on the entries of `endpoints.passthrough_parameters`: `endpoints.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.passthrough_parameters.&lt;key&gt;.type`, `endpoints.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsDeprecationDate">
        /// Filter where the value at `endpoints.deprecation_date` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsReady">
        /// Filter where the value at `endpoints.is_ready` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsIsFree">
        /// Filter where the value at `endpoints.is_free` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsServiceTier">
        /// Filter where the value at `endpoints.service_tier` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `flex`, `priority`, `ultrafast`, `fast`.
        /// </param>
        /// <param name="endpointsDiscountToUser">
        /// Filter where the value at `endpoints.discount_to_user` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOpenrouterSlug">
        /// Filter where the value at `endpoints.openrouter.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersCountryCode">
        /// Filter where any value at `endpoints.datacenters.country_code` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDatacentersRegion">
        /// Filter where any value at `endpoints.datacenters.region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDeploymentRegion">
        /// Filter where the value at `endpoints.deployment_region` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsType">
        /// Filter where any value at `endpoints.inputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `audio`, `file`.
        /// </param>
        /// <param name="endpointsInputsTextPricingType">
        /// Filter where any value at `endpoints.inputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.text.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.text.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.text.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityType">
        /// Filter where any value at `endpoints.inputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsTextCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.text.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.text.passthrough_parameters`: `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxPromptLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_prompt_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthValue">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsTextParamsMaxLengthUnit">
        /// Filter where the value at `endpoints.inputs.text.params.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingType">
        /// Filter where any value at `endpoints.inputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.image.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.image.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.image.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityType">
        /// Filter where any value at `endpoints.inputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsImageCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.image.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.image.passthrough_parameters`: `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.image.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.image.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.image.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.image.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `image/png`, `image/jpeg`, `image/webp`, `image/gif`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsType">
        /// Filter where the value at `endpoints.inputs.image.params.detail_levels.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsDetailLevelsValues">
        /// Filter where any element at `endpoints.inputs.image.params.detail_levels.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `auto`, `low`, `high`, `original`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.image.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.image.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.image.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleType">
        /// Filter where the value at `endpoints.inputs.image.params.role.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsImageParamsRoleValues">
        /// Filter where any element at `endpoints.inputs.image.params.role.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `reference`, `first_frame`, `last_frame`.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsImageParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.image.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingType">
        /// Filter where any value at `endpoints.inputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.video.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.video.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.video.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityType">
        /// Filter where any value at `endpoints.inputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsVideoCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.video.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.video.passthrough_parameters`: `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.video.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.video.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.video.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.video.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `video/mp4`, `video/webm`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsVideoParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.video.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingType">
        /// Filter where any value at `endpoints.inputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.audio.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.audio.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.audio.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityType">
        /// Filter where any value at `endpoints.inputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsAudioCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.audio.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.audio.passthrough_parameters`: `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.audio.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.audio.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.audio.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.audio.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `audio/wav`, `audio/mpeg`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.value` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxDurationSecondsUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_duration_seconds.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsAudioParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.audio.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingType">
        /// Filter where any value at `endpoints.inputs.file.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cached_prompt.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cached_prompt.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCachedPromptUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cached_prompt.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteCostUsd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteOverridesCostUsd">
        /// Filter where any value at `endpoints.inputs.file.pricing.cache_write.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteTtlSeconds">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.ttl_seconds` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteImplicit">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.implicit` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcStart">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcEnd">
        /// Filter where the value at `endpoints.inputs.file.pricing.cache_write.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePricingCacheWriteUtcDays">
        /// Filter where any element at `endpoints.inputs.file.pricing.cache_write.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityType">
        /// Filter where any value at `endpoints.inputs.file.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `prompt`, `cached_prompt`, `cache_write`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptPer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCachedPromptValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cached_prompt.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteUnit">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWritePer">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsInputsFileCapacityCacheWriteValue">
        /// Filter where the value at `endpoints.inputs.file.capacity.cache_write.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFilePassthroughParameters">
        /// Filter on the entries of `endpoints.inputs.file.passthrough_parameters`: `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.type`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.inputs.file.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesType">
        /// Filter where the value at `endpoints.inputs.file.params.sources.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsSourcesValues">
        /// Filter where any element at `endpoints.inputs.file.params.sources.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `url`, `base64`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsType">
        /// Filter where the value at `endpoints.inputs.file.params.formats.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `enum`.
        /// </param>
        /// <param name="endpointsInputsFileParamsFormatsValues">
        /// Filter where any element at `endpoints.inputs.file.params.formats.values` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `application/pdf`, `text/plain`, `text/markdown`, `text/html`, `text/csv`, `application/json`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesType">
        /// Filter where the value at `endpoints.inputs.file.params.references.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `integer`.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMin">
        /// Filter where the value at `endpoints.inputs.file.params.references.min` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesMax">
        /// Filter where the value at `endpoints.inputs.file.params.references.max` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsReferencesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.references.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesValue">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsInputsFileParamsMaxContentSizeBytesUnit">
        /// Filter where the value at `endpoints.inputs.file.params.max_content_size_bytes.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsType">
        /// Filter where any value at `endpoints.outputs.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `text`, `image`, `video`, `speech`, `transcription`, `embeddings`, `rerank`, `decisions`, `audio`.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthValue">
        /// Filter where the value at `endpoints.outputs.text.max_length.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextMaxLengthUnit">
        /// Filter where the value at `endpoints.outputs.text.max_length.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `second`, `pixel`, `byte`, `token`, `character`.
        /// </param>
        /// <param name="endpointsOutputsTextPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.text.passthrough_parameters`: `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.text.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTextPricingType">
        /// Filter where any value at `endpoints.outputs.text.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.text.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.text.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.text.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityType">
        /// Filter where any value at `endpoints.outputs.text.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTextCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.text.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextStreaming">
        /// Filter where the value at `endpoints.outputs.text.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTextParams">
        /// Filter on the entries of `endpoints.outputs.text.params`: `endpoints.outputs.text.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.text.params.&lt;key&gt;.type`, `endpoints.outputs.text.params.&lt;key&gt;.range.min`, `endpoints.outputs.text.params.&lt;key&gt;.range.max`, `endpoints.outputs.text.params.&lt;key&gt;.range.default`, `endpoints.outputs.text.params.&lt;key&gt;.range.values`, `endpoints.outputs.text.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.image.passthrough_parameters`: `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.image.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsImagePricingType">
        /// Filter where any value at `endpoints.outputs.image.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.image.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.image.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImagePricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.image.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityType">
        /// Filter where any value at `endpoints.outputs.image.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsImageCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.image.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageStreaming">
        /// Filter where the value at `endpoints.outputs.image.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsImageParams">
        /// Filter on the entries of `endpoints.outputs.image.params`: `endpoints.outputs.image.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.image.params.&lt;key&gt;.type`, `endpoints.outputs.image.params.&lt;key&gt;.range.min`, `endpoints.outputs.image.params.&lt;key&gt;.range.max`, `endpoints.outputs.image.params.&lt;key&gt;.range.default`, `endpoints.outputs.image.params.&lt;key&gt;.range.values`, `endpoints.outputs.image.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.video.passthrough_parameters`: `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.video.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingType">
        /// Filter where any value at `endpoints.outputs.video.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.video.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.video.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.video.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityType">
        /// Filter where any value at `endpoints.outputs.video.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsVideoCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.video.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoStreaming">
        /// Filter where the value at `endpoints.outputs.video.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsVideoParams">
        /// Filter on the entries of `endpoints.outputs.video.params`: `endpoints.outputs.video.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.video.params.&lt;key&gt;.type`, `endpoints.outputs.video.params.&lt;key&gt;.range.min`, `endpoints.outputs.video.params.&lt;key&gt;.range.max`, `endpoints.outputs.video.params.&lt;key&gt;.range.default`, `endpoints.outputs.video.params.&lt;key&gt;.range.values`, `endpoints.outputs.video.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.speech.passthrough_parameters`: `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.speech.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingType">
        /// Filter where any value at `endpoints.outputs.speech.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.speech.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.speech.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.speech.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityType">
        /// Filter where any value at `endpoints.outputs.speech.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsSpeechCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.speech.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechStreaming">
        /// Filter where the value at `endpoints.outputs.speech.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsSpeechParams">
        /// Filter on the entries of `endpoints.outputs.speech.params`: `endpoints.outputs.speech.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.speech.params.&lt;key&gt;.type`, `endpoints.outputs.speech.params.&lt;key&gt;.range.min`, `endpoints.outputs.speech.params.&lt;key&gt;.range.max`, `endpoints.outputs.speech.params.&lt;key&gt;.range.default`, `endpoints.outputs.speech.params.&lt;key&gt;.range.values`, `endpoints.outputs.speech.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.transcription.passthrough_parameters`: `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingType">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.transcription.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.transcription.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityType">
        /// Filter where any value at `endpoints.outputs.transcription.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.transcription.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionStreaming">
        /// Filter where the value at `endpoints.outputs.transcription.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsTranscriptionParams">
        /// Filter on the entries of `endpoints.outputs.transcription.params`: `endpoints.outputs.transcription.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.transcription.params.&lt;key&gt;.type`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.min`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.max`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.default`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.values`, `endpoints.outputs.transcription.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.embeddings.passthrough_parameters`: `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingType">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.embeddings.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.embeddings.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityType">
        /// Filter where any value at `endpoints.outputs.embeddings.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.embeddings.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsEmbeddingsParams">
        /// Filter on the entries of `endpoints.outputs.embeddings.params`: `endpoints.outputs.embeddings.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.embeddings.params.&lt;key&gt;.type`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.min`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.max`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.default`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.values`, `endpoints.outputs.embeddings.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.rerank.passthrough_parameters`: `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingType">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.rerank.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.rerank.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityType">
        /// Filter where any value at `endpoints.outputs.rerank.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsRerankCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.rerank.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsRerankParams">
        /// Filter on the entries of `endpoints.outputs.rerank.params`: `endpoints.outputs.rerank.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.rerank.params.&lt;key&gt;.type`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.min`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.max`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.default`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.values`, `endpoints.outputs.rerank.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.decisions.passthrough_parameters`: `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingType">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.decisions.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.decisions.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityType">
        /// Filter where any value at `endpoints.outputs.decisions.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsDecisionsCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.decisions.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsDecisionsParams">
        /// Filter on the entries of `endpoints.outputs.decisions.params`: `endpoints.outputs.decisions.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.decisions.params.&lt;key&gt;.type`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.min`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.max`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.default`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.values`, `endpoints.outputs.decisions.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPassthroughParameters">
        /// Filter on the entries of `endpoints.outputs.audio.passthrough_parameters`: `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.type`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.min`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.max`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.default`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.values`, `endpoints.outputs.audio.passthrough_parameters.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingType">
        /// Filter where any value at `endpoints.outputs.audio.pricing.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.completion.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.completion.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingCompletionUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.completion.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningCostUsd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd">
        /// Filter where any value at `endpoints.outputs.audio.pricing.internal_reasoning.overrides.cost_usd` (number) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcStart">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_start` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcEnd">
        /// Filter where the value at `endpoints.outputs.audio.pricing.internal_reasoning.utc_end` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioPricingInternalReasoningUtcDays">
        /// Filter where any element at `endpoints.outputs.audio.pricing.internal_reasoning.utc_days` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `monday`, `tuesday`, `wednesday`, `thursday`, `friday`, `saturday`, `sunday`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityType">
        /// Filter where any value at `endpoints.outputs.audio.capacity.type` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `completion`, `internal_reasoning`, `concurrency`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityCompletionValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.completion.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `token`, `image`, `megapixel`, `second`, `character`, `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningPer">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.per` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `minute`, `hour`, `day`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityInternalReasoningValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.internal_reasoning.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyUnit">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.unit` (enum) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches. One of: `request`.
        /// </param>
        /// <param name="endpointsOutputsAudioCapacityConcurrencyValue">
        /// Filter where the value at `endpoints.outputs.audio.capacity.concurrency.value` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioStreaming">
        /// Filter where the value at `endpoints.outputs.audio.streaming` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsOutputsAudioParams">
        /// Filter on the entries of `endpoints.outputs.audio.params`: `endpoints.outputs.audio.params.&lt;key&gt;.exists=true` keeps records that have the entry, and the entry's fields follow the key (`endpoints.outputs.audio.params.&lt;key&gt;.type`, `endpoints.outputs.audio.params.&lt;key&gt;.range.min`, `endpoints.outputs.audio.params.&lt;key&gt;.range.max`, `endpoints.outputs.audio.params.&lt;key&gt;.range.default`, `endpoints.outputs.audio.params.&lt;key&gt;.range.values`, `endpoints.outputs.audio.params.&lt;key&gt;.range.unit`). Only `exists` applies to the map itself.
        /// </param>
        /// <param name="endpointsProviderSlug">
        /// Filter where the value at `endpoints.provider.slug` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderTag">
        /// Filter where the value at `endpoints.provider.tag` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsProviderName">
        /// Filter where the value at `endpoints.provider.name` (string) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.contains`, `.starts_with`, `.ends_with`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyTraining">
        /// Filter where the value at `endpoints.data_policy.training` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetainsPrompts">
        /// Filter where the value at `endpoints.data_policy.retains_prompts` (boolean) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="endpointsDataPolicyRetentionDays">
        /// Filter where the value at `endpoints.data_policy.retention_days` (integer) equals the value, itself a literal, a path or an arithmetic expression of the same type; append an operator suffix for `.in`, `.gt`, `.gte`, `.lt`, `.lte`, `.between`, `.exists`, and `.not` before the operator (or alone, for not-equal) to keep the records where no value matches.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsV2ListResponse>> ListV2AsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? cursor = default,
            global::OpenRouter.ListModelsV2Region? region = default,
            string? sort = default,
            string? id = default,
            string? canonicalSlug = default,
            string? author = default,
            string? name = default,
            string? variant = default,
            string? kind = default,
            string? aliasTargetSlug = default,
            string? aliasTargetName = default,
            string? created = default,
            string? description = default,
            string? contextLength = default,
            string? huggingFaceId = default,
            string? inputs = default,
            string? outputs = default,
            string? endpointsSchemaVersion = default,
            string? endpointsId = default,
            string? endpointsHuggingFaceId = default,
            string? endpointsName = default,
            string? endpointsCreated = default,
            string? endpointsQuantization = default,
            string? endpointsTokenizer = default,
            string? endpointsDescription = default,
            string? endpointsPricingType = default,
            string? endpointsPricingRequestUnit = default,
            string? endpointsPricingRequestCostUsd = default,
            string? endpointsPricingRequestOverridesCostUsd = default,
            string? endpointsPricingWebSearchUnit = default,
            string? endpointsPricingWebSearchCostUsd = default,
            string? endpointsPricingWebSearchOverridesCostUsd = default,
            string? endpointsCapacityType = default,
            string? endpointsCapacityRequestUnit = default,
            string? endpointsCapacityRequestPer = default,
            string? endpointsCapacityRequestValue = default,
            string? endpointsCapacityWebSearchUnit = default,
            string? endpointsCapacityWebSearchPer = default,
            string? endpointsCapacityWebSearchValue = default,
            string? endpointsCapacityConcurrencyUnit = default,
            string? endpointsCapacityConcurrencyValue = default,
            string? endpointsPassthroughParameters = default,
            string? endpointsDeprecationDate = default,
            string? endpointsIsReady = default,
            string? endpointsIsFree = default,
            string? endpointsServiceTier = default,
            string? endpointsDiscountToUser = default,
            string? endpointsOpenrouterSlug = default,
            string? endpointsDatacentersCountryCode = default,
            string? endpointsDatacentersRegion = default,
            string? endpointsDeploymentRegion = default,
            string? endpointsInputsType = default,
            string? endpointsInputsTextPricingType = default,
            string? endpointsInputsTextPricingPromptUnit = default,
            string? endpointsInputsTextPricingPromptCostUsd = default,
            string? endpointsInputsTextPricingPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingPromptUtcStart = default,
            string? endpointsInputsTextPricingPromptUtcEnd = default,
            string? endpointsInputsTextPricingPromptUtcDays = default,
            string? endpointsInputsTextPricingCachedPromptUnit = default,
            string? endpointsInputsTextPricingCachedPromptCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsTextPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsTextPricingCachedPromptImplicit = default,
            string? endpointsInputsTextPricingCachedPromptUtcStart = default,
            string? endpointsInputsTextPricingCachedPromptUtcEnd = default,
            string? endpointsInputsTextPricingCachedPromptUtcDays = default,
            string? endpointsInputsTextPricingCacheWriteUnit = default,
            string? endpointsInputsTextPricingCacheWriteCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsTextPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsTextPricingCacheWriteImplicit = default,
            string? endpointsInputsTextPricingCacheWriteUtcStart = default,
            string? endpointsInputsTextPricingCacheWriteUtcEnd = default,
            string? endpointsInputsTextPricingCacheWriteUtcDays = default,
            string? endpointsInputsTextCapacityType = default,
            string? endpointsInputsTextCapacityPromptUnit = default,
            string? endpointsInputsTextCapacityPromptPer = default,
            string? endpointsInputsTextCapacityPromptValue = default,
            string? endpointsInputsTextCapacityCachedPromptUnit = default,
            string? endpointsInputsTextCapacityCachedPromptPer = default,
            string? endpointsInputsTextCapacityCachedPromptValue = default,
            string? endpointsInputsTextCapacityCacheWriteUnit = default,
            string? endpointsInputsTextCapacityCacheWritePer = default,
            string? endpointsInputsTextCapacityCacheWriteValue = default,
            string? endpointsInputsTextPassthroughParameters = default,
            string? endpointsInputsTextParamsMaxPromptLengthValue = default,
            string? endpointsInputsTextParamsMaxPromptLengthUnit = default,
            string? endpointsInputsTextParamsMaxLengthValue = default,
            string? endpointsInputsTextParamsMaxLengthUnit = default,
            string? endpointsInputsImagePricingType = default,
            string? endpointsInputsImagePricingPromptUnit = default,
            string? endpointsInputsImagePricingPromptCostUsd = default,
            string? endpointsInputsImagePricingPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingPromptUtcStart = default,
            string? endpointsInputsImagePricingPromptUtcEnd = default,
            string? endpointsInputsImagePricingPromptUtcDays = default,
            string? endpointsInputsImagePricingCachedPromptUnit = default,
            string? endpointsInputsImagePricingCachedPromptCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsImagePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsImagePricingCachedPromptImplicit = default,
            string? endpointsInputsImagePricingCachedPromptUtcStart = default,
            string? endpointsInputsImagePricingCachedPromptUtcEnd = default,
            string? endpointsInputsImagePricingCachedPromptUtcDays = default,
            string? endpointsInputsImagePricingCacheWriteUnit = default,
            string? endpointsInputsImagePricingCacheWriteCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsImagePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsImagePricingCacheWriteImplicit = default,
            string? endpointsInputsImagePricingCacheWriteUtcStart = default,
            string? endpointsInputsImagePricingCacheWriteUtcEnd = default,
            string? endpointsInputsImagePricingCacheWriteUtcDays = default,
            string? endpointsInputsImageCapacityType = default,
            string? endpointsInputsImageCapacityPromptUnit = default,
            string? endpointsInputsImageCapacityPromptPer = default,
            string? endpointsInputsImageCapacityPromptValue = default,
            string? endpointsInputsImageCapacityCachedPromptUnit = default,
            string? endpointsInputsImageCapacityCachedPromptPer = default,
            string? endpointsInputsImageCapacityCachedPromptValue = default,
            string? endpointsInputsImageCapacityCacheWriteUnit = default,
            string? endpointsInputsImageCapacityCacheWritePer = default,
            string? endpointsInputsImageCapacityCacheWriteValue = default,
            string? endpointsInputsImagePassthroughParameters = default,
            string? endpointsInputsImageParamsSourcesType = default,
            string? endpointsInputsImageParamsSourcesValues = default,
            string? endpointsInputsImageParamsFormatsType = default,
            string? endpointsInputsImageParamsFormatsValues = default,
            string? endpointsInputsImageParamsDetailLevelsType = default,
            string? endpointsInputsImageParamsDetailLevelsValues = default,
            string? endpointsInputsImageParamsReferencesType = default,
            string? endpointsInputsImageParamsReferencesMin = default,
            string? endpointsInputsImageParamsReferencesMax = default,
            string? endpointsInputsImageParamsReferencesUnit = default,
            string? endpointsInputsImageParamsRoleType = default,
            string? endpointsInputsImageParamsRoleValues = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsImageParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsVideoPricingType = default,
            string? endpointsInputsVideoPricingPromptUnit = default,
            string? endpointsInputsVideoPricingPromptCostUsd = default,
            string? endpointsInputsVideoPricingPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingPromptUtcStart = default,
            string? endpointsInputsVideoPricingPromptUtcEnd = default,
            string? endpointsInputsVideoPricingPromptUtcDays = default,
            string? endpointsInputsVideoPricingCachedPromptUnit = default,
            string? endpointsInputsVideoPricingCachedPromptCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsVideoPricingCachedPromptImplicit = default,
            string? endpointsInputsVideoPricingCachedPromptUtcStart = default,
            string? endpointsInputsVideoPricingCachedPromptUtcEnd = default,
            string? endpointsInputsVideoPricingCachedPromptUtcDays = default,
            string? endpointsInputsVideoPricingCacheWriteUnit = default,
            string? endpointsInputsVideoPricingCacheWriteCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsVideoPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsVideoPricingCacheWriteImplicit = default,
            string? endpointsInputsVideoPricingCacheWriteUtcStart = default,
            string? endpointsInputsVideoPricingCacheWriteUtcEnd = default,
            string? endpointsInputsVideoPricingCacheWriteUtcDays = default,
            string? endpointsInputsVideoCapacityType = default,
            string? endpointsInputsVideoCapacityPromptUnit = default,
            string? endpointsInputsVideoCapacityPromptPer = default,
            string? endpointsInputsVideoCapacityPromptValue = default,
            string? endpointsInputsVideoCapacityCachedPromptUnit = default,
            string? endpointsInputsVideoCapacityCachedPromptPer = default,
            string? endpointsInputsVideoCapacityCachedPromptValue = default,
            string? endpointsInputsVideoCapacityCacheWriteUnit = default,
            string? endpointsInputsVideoCapacityCacheWritePer = default,
            string? endpointsInputsVideoCapacityCacheWriteValue = default,
            string? endpointsInputsVideoPassthroughParameters = default,
            string? endpointsInputsVideoParamsSourcesType = default,
            string? endpointsInputsVideoParamsSourcesValues = default,
            string? endpointsInputsVideoParamsFormatsType = default,
            string? endpointsInputsVideoParamsFormatsValues = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsValue = default,
            string? endpointsInputsVideoParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsVideoParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsAudioPricingType = default,
            string? endpointsInputsAudioPricingPromptUnit = default,
            string? endpointsInputsAudioPricingPromptCostUsd = default,
            string? endpointsInputsAudioPricingPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingPromptUtcStart = default,
            string? endpointsInputsAudioPricingPromptUtcEnd = default,
            string? endpointsInputsAudioPricingPromptUtcDays = default,
            string? endpointsInputsAudioPricingCachedPromptUnit = default,
            string? endpointsInputsAudioPricingCachedPromptCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCachedPromptTtlSeconds = default,
            string? endpointsInputsAudioPricingCachedPromptImplicit = default,
            string? endpointsInputsAudioPricingCachedPromptUtcStart = default,
            string? endpointsInputsAudioPricingCachedPromptUtcEnd = default,
            string? endpointsInputsAudioPricingCachedPromptUtcDays = default,
            string? endpointsInputsAudioPricingCacheWriteUnit = default,
            string? endpointsInputsAudioPricingCacheWriteCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsAudioPricingCacheWriteTtlSeconds = default,
            string? endpointsInputsAudioPricingCacheWriteImplicit = default,
            string? endpointsInputsAudioPricingCacheWriteUtcStart = default,
            string? endpointsInputsAudioPricingCacheWriteUtcEnd = default,
            string? endpointsInputsAudioPricingCacheWriteUtcDays = default,
            string? endpointsInputsAudioCapacityType = default,
            string? endpointsInputsAudioCapacityPromptUnit = default,
            string? endpointsInputsAudioCapacityPromptPer = default,
            string? endpointsInputsAudioCapacityPromptValue = default,
            string? endpointsInputsAudioCapacityCachedPromptUnit = default,
            string? endpointsInputsAudioCapacityCachedPromptPer = default,
            string? endpointsInputsAudioCapacityCachedPromptValue = default,
            string? endpointsInputsAudioCapacityCacheWriteUnit = default,
            string? endpointsInputsAudioCapacityCacheWritePer = default,
            string? endpointsInputsAudioCapacityCacheWriteValue = default,
            string? endpointsInputsAudioPassthroughParameters = default,
            string? endpointsInputsAudioParamsSourcesType = default,
            string? endpointsInputsAudioParamsSourcesValues = default,
            string? endpointsInputsAudioParamsFormatsType = default,
            string? endpointsInputsAudioParamsFormatsValues = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsValue = default,
            string? endpointsInputsAudioParamsMaxDurationSecondsUnit = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsAudioParamsMaxContentSizeBytesUnit = default,
            string? endpointsInputsFilePricingType = default,
            string? endpointsInputsFilePricingPromptUnit = default,
            string? endpointsInputsFilePricingPromptCostUsd = default,
            string? endpointsInputsFilePricingPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingPromptUtcStart = default,
            string? endpointsInputsFilePricingPromptUtcEnd = default,
            string? endpointsInputsFilePricingPromptUtcDays = default,
            string? endpointsInputsFilePricingCachedPromptUnit = default,
            string? endpointsInputsFilePricingCachedPromptCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptOverridesCostUsd = default,
            string? endpointsInputsFilePricingCachedPromptTtlSeconds = default,
            string? endpointsInputsFilePricingCachedPromptImplicit = default,
            string? endpointsInputsFilePricingCachedPromptUtcStart = default,
            string? endpointsInputsFilePricingCachedPromptUtcEnd = default,
            string? endpointsInputsFilePricingCachedPromptUtcDays = default,
            string? endpointsInputsFilePricingCacheWriteUnit = default,
            string? endpointsInputsFilePricingCacheWriteCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteOverridesCostUsd = default,
            string? endpointsInputsFilePricingCacheWriteTtlSeconds = default,
            string? endpointsInputsFilePricingCacheWriteImplicit = default,
            string? endpointsInputsFilePricingCacheWriteUtcStart = default,
            string? endpointsInputsFilePricingCacheWriteUtcEnd = default,
            string? endpointsInputsFilePricingCacheWriteUtcDays = default,
            string? endpointsInputsFileCapacityType = default,
            string? endpointsInputsFileCapacityPromptUnit = default,
            string? endpointsInputsFileCapacityPromptPer = default,
            string? endpointsInputsFileCapacityPromptValue = default,
            string? endpointsInputsFileCapacityCachedPromptUnit = default,
            string? endpointsInputsFileCapacityCachedPromptPer = default,
            string? endpointsInputsFileCapacityCachedPromptValue = default,
            string? endpointsInputsFileCapacityCacheWriteUnit = default,
            string? endpointsInputsFileCapacityCacheWritePer = default,
            string? endpointsInputsFileCapacityCacheWriteValue = default,
            string? endpointsInputsFilePassthroughParameters = default,
            string? endpointsInputsFileParamsSourcesType = default,
            string? endpointsInputsFileParamsSourcesValues = default,
            string? endpointsInputsFileParamsFormatsType = default,
            string? endpointsInputsFileParamsFormatsValues = default,
            string? endpointsInputsFileParamsReferencesType = default,
            string? endpointsInputsFileParamsReferencesMin = default,
            string? endpointsInputsFileParamsReferencesMax = default,
            string? endpointsInputsFileParamsReferencesUnit = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesValue = default,
            string? endpointsInputsFileParamsMaxContentSizeBytesUnit = default,
            string? endpointsOutputsType = default,
            string? endpointsOutputsTextMaxLengthValue = default,
            string? endpointsOutputsTextMaxLengthUnit = default,
            string? endpointsOutputsTextPassthroughParameters = default,
            string? endpointsOutputsTextPricingType = default,
            string? endpointsOutputsTextPricingCompletionUnit = default,
            string? endpointsOutputsTextPricingCompletionCostUsd = default,
            string? endpointsOutputsTextPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTextPricingCompletionUtcStart = default,
            string? endpointsOutputsTextPricingCompletionUtcEnd = default,
            string? endpointsOutputsTextPricingCompletionUtcDays = default,
            string? endpointsOutputsTextPricingInternalReasoningUnit = default,
            string? endpointsOutputsTextPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTextPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTextCapacityType = default,
            string? endpointsOutputsTextCapacityCompletionUnit = default,
            string? endpointsOutputsTextCapacityCompletionPer = default,
            string? endpointsOutputsTextCapacityCompletionValue = default,
            string? endpointsOutputsTextCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTextCapacityInternalReasoningPer = default,
            string? endpointsOutputsTextCapacityInternalReasoningValue = default,
            string? endpointsOutputsTextCapacityConcurrencyUnit = default,
            string? endpointsOutputsTextCapacityConcurrencyValue = default,
            string? endpointsOutputsTextStreaming = default,
            string? endpointsOutputsTextParams = default,
            string? endpointsOutputsImagePassthroughParameters = default,
            string? endpointsOutputsImagePricingType = default,
            string? endpointsOutputsImagePricingCompletionUnit = default,
            string? endpointsOutputsImagePricingCompletionCostUsd = default,
            string? endpointsOutputsImagePricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsImagePricingCompletionUtcStart = default,
            string? endpointsOutputsImagePricingCompletionUtcEnd = default,
            string? endpointsOutputsImagePricingCompletionUtcDays = default,
            string? endpointsOutputsImagePricingInternalReasoningUnit = default,
            string? endpointsOutputsImagePricingInternalReasoningCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcStart = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsImagePricingInternalReasoningUtcDays = default,
            string? endpointsOutputsImageCapacityType = default,
            string? endpointsOutputsImageCapacityCompletionUnit = default,
            string? endpointsOutputsImageCapacityCompletionPer = default,
            string? endpointsOutputsImageCapacityCompletionValue = default,
            string? endpointsOutputsImageCapacityInternalReasoningUnit = default,
            string? endpointsOutputsImageCapacityInternalReasoningPer = default,
            string? endpointsOutputsImageCapacityInternalReasoningValue = default,
            string? endpointsOutputsImageCapacityConcurrencyUnit = default,
            string? endpointsOutputsImageCapacityConcurrencyValue = default,
            string? endpointsOutputsImageStreaming = default,
            string? endpointsOutputsImageParams = default,
            string? endpointsOutputsVideoPassthroughParameters = default,
            string? endpointsOutputsVideoPricingType = default,
            string? endpointsOutputsVideoPricingCompletionUnit = default,
            string? endpointsOutputsVideoPricingCompletionCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingCompletionUtcStart = default,
            string? endpointsOutputsVideoPricingCompletionUtcEnd = default,
            string? endpointsOutputsVideoPricingCompletionUtcDays = default,
            string? endpointsOutputsVideoPricingInternalReasoningUnit = default,
            string? endpointsOutputsVideoPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsVideoPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsVideoCapacityType = default,
            string? endpointsOutputsVideoCapacityCompletionUnit = default,
            string? endpointsOutputsVideoCapacityCompletionPer = default,
            string? endpointsOutputsVideoCapacityCompletionValue = default,
            string? endpointsOutputsVideoCapacityInternalReasoningUnit = default,
            string? endpointsOutputsVideoCapacityInternalReasoningPer = default,
            string? endpointsOutputsVideoCapacityInternalReasoningValue = default,
            string? endpointsOutputsVideoCapacityConcurrencyUnit = default,
            string? endpointsOutputsVideoCapacityConcurrencyValue = default,
            string? endpointsOutputsVideoStreaming = default,
            string? endpointsOutputsVideoParams = default,
            string? endpointsOutputsSpeechPassthroughParameters = default,
            string? endpointsOutputsSpeechPricingType = default,
            string? endpointsOutputsSpeechPricingCompletionUnit = default,
            string? endpointsOutputsSpeechPricingCompletionCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcStart = default,
            string? endpointsOutputsSpeechPricingCompletionUtcEnd = default,
            string? endpointsOutputsSpeechPricingCompletionUtcDays = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUnit = default,
            string? endpointsOutputsSpeechPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsSpeechPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsSpeechCapacityType = default,
            string? endpointsOutputsSpeechCapacityCompletionUnit = default,
            string? endpointsOutputsSpeechCapacityCompletionPer = default,
            string? endpointsOutputsSpeechCapacityCompletionValue = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningUnit = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningPer = default,
            string? endpointsOutputsSpeechCapacityInternalReasoningValue = default,
            string? endpointsOutputsSpeechCapacityConcurrencyUnit = default,
            string? endpointsOutputsSpeechCapacityConcurrencyValue = default,
            string? endpointsOutputsSpeechStreaming = default,
            string? endpointsOutputsSpeechParams = default,
            string? endpointsOutputsTranscriptionPassthroughParameters = default,
            string? endpointsOutputsTranscriptionPricingType = default,
            string? endpointsOutputsTranscriptionPricingCompletionUnit = default,
            string? endpointsOutputsTranscriptionPricingCompletionCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcStart = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingCompletionUtcDays = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsTranscriptionPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsTranscriptionCapacityType = default,
            string? endpointsOutputsTranscriptionCapacityCompletionUnit = default,
            string? endpointsOutputsTranscriptionCapacityCompletionPer = default,
            string? endpointsOutputsTranscriptionCapacityCompletionValue = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningUnit = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningPer = default,
            string? endpointsOutputsTranscriptionCapacityInternalReasoningValue = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyUnit = default,
            string? endpointsOutputsTranscriptionCapacityConcurrencyValue = default,
            string? endpointsOutputsTranscriptionStreaming = default,
            string? endpointsOutputsTranscriptionParams = default,
            string? endpointsOutputsEmbeddingsPassthroughParameters = default,
            string? endpointsOutputsEmbeddingsPricingType = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUnit = default,
            string? endpointsOutputsEmbeddingsPricingCompletionCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingCompletionUtcDays = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsEmbeddingsCapacityType = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionUnit = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionPer = default,
            string? endpointsOutputsEmbeddingsCapacityCompletionValue = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningPer = default,
            string? endpointsOutputsEmbeddingsCapacityInternalReasoningValue = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyUnit = default,
            string? endpointsOutputsEmbeddingsCapacityConcurrencyValue = default,
            string? endpointsOutputsEmbeddingsParams = default,
            string? endpointsOutputsRerankPassthroughParameters = default,
            string? endpointsOutputsRerankPricingType = default,
            string? endpointsOutputsRerankPricingCompletionUnit = default,
            string? endpointsOutputsRerankPricingCompletionCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingCompletionUtcStart = default,
            string? endpointsOutputsRerankPricingCompletionUtcEnd = default,
            string? endpointsOutputsRerankPricingCompletionUtcDays = default,
            string? endpointsOutputsRerankPricingInternalReasoningUnit = default,
            string? endpointsOutputsRerankPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsRerankPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsRerankCapacityType = default,
            string? endpointsOutputsRerankCapacityCompletionUnit = default,
            string? endpointsOutputsRerankCapacityCompletionPer = default,
            string? endpointsOutputsRerankCapacityCompletionValue = default,
            string? endpointsOutputsRerankCapacityInternalReasoningUnit = default,
            string? endpointsOutputsRerankCapacityInternalReasoningPer = default,
            string? endpointsOutputsRerankCapacityInternalReasoningValue = default,
            string? endpointsOutputsRerankCapacityConcurrencyUnit = default,
            string? endpointsOutputsRerankCapacityConcurrencyValue = default,
            string? endpointsOutputsRerankParams = default,
            string? endpointsOutputsDecisionsPassthroughParameters = default,
            string? endpointsOutputsDecisionsPricingType = default,
            string? endpointsOutputsDecisionsPricingCompletionUnit = default,
            string? endpointsOutputsDecisionsPricingCompletionCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcStart = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcEnd = default,
            string? endpointsOutputsDecisionsPricingCompletionUtcDays = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsDecisionsPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsDecisionsCapacityType = default,
            string? endpointsOutputsDecisionsCapacityCompletionUnit = default,
            string? endpointsOutputsDecisionsCapacityCompletionPer = default,
            string? endpointsOutputsDecisionsCapacityCompletionValue = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningUnit = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningPer = default,
            string? endpointsOutputsDecisionsCapacityInternalReasoningValue = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyUnit = default,
            string? endpointsOutputsDecisionsCapacityConcurrencyValue = default,
            string? endpointsOutputsDecisionsParams = default,
            string? endpointsOutputsAudioPassthroughParameters = default,
            string? endpointsOutputsAudioPricingType = default,
            string? endpointsOutputsAudioPricingCompletionUnit = default,
            string? endpointsOutputsAudioPricingCompletionCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingCompletionUtcStart = default,
            string? endpointsOutputsAudioPricingCompletionUtcEnd = default,
            string? endpointsOutputsAudioPricingCompletionUtcDays = default,
            string? endpointsOutputsAudioPricingInternalReasoningUnit = default,
            string? endpointsOutputsAudioPricingInternalReasoningCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcStart = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcEnd = default,
            string? endpointsOutputsAudioPricingInternalReasoningUtcDays = default,
            string? endpointsOutputsAudioCapacityType = default,
            string? endpointsOutputsAudioCapacityCompletionUnit = default,
            string? endpointsOutputsAudioCapacityCompletionPer = default,
            string? endpointsOutputsAudioCapacityCompletionValue = default,
            string? endpointsOutputsAudioCapacityInternalReasoningUnit = default,
            string? endpointsOutputsAudioCapacityInternalReasoningPer = default,
            string? endpointsOutputsAudioCapacityInternalReasoningValue = default,
            string? endpointsOutputsAudioCapacityConcurrencyUnit = default,
            string? endpointsOutputsAudioCapacityConcurrencyValue = default,
            string? endpointsOutputsAudioStreaming = default,
            string? endpointsOutputsAudioParams = default,
            string? endpointsProviderSlug = default,
            string? endpointsProviderTag = default,
            string? endpointsProviderName = default,
            string? endpointsDataPolicyTraining = default,
            string? endpointsDataPolicyRetainsPrompts = default,
            string? endpointsDataPolicyRetentionDays = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListV2Arguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                cursor: ref cursor,
                region: ref region,
                sort: ref sort,
                id: ref id,
                canonicalSlug: ref canonicalSlug,
                author: ref author,
                name: ref name,
                variant: ref variant,
                kind: ref kind,
                aliasTargetSlug: ref aliasTargetSlug,
                aliasTargetName: ref aliasTargetName,
                created: ref created,
                description: ref description,
                contextLength: ref contextLength,
                huggingFaceId: ref huggingFaceId,
                inputs: ref inputs,
                outputs: ref outputs,
                endpointsSchemaVersion: ref endpointsSchemaVersion,
                endpointsId: ref endpointsId,
                endpointsHuggingFaceId: ref endpointsHuggingFaceId,
                endpointsName: ref endpointsName,
                endpointsCreated: ref endpointsCreated,
                endpointsQuantization: ref endpointsQuantization,
                endpointsTokenizer: ref endpointsTokenizer,
                endpointsDescription: ref endpointsDescription,
                endpointsPricingType: ref endpointsPricingType,
                endpointsPricingRequestUnit: ref endpointsPricingRequestUnit,
                endpointsPricingRequestCostUsd: ref endpointsPricingRequestCostUsd,
                endpointsPricingRequestOverridesCostUsd: ref endpointsPricingRequestOverridesCostUsd,
                endpointsPricingWebSearchUnit: ref endpointsPricingWebSearchUnit,
                endpointsPricingWebSearchCostUsd: ref endpointsPricingWebSearchCostUsd,
                endpointsPricingWebSearchOverridesCostUsd: ref endpointsPricingWebSearchOverridesCostUsd,
                endpointsCapacityType: ref endpointsCapacityType,
                endpointsCapacityRequestUnit: ref endpointsCapacityRequestUnit,
                endpointsCapacityRequestPer: ref endpointsCapacityRequestPer,
                endpointsCapacityRequestValue: ref endpointsCapacityRequestValue,
                endpointsCapacityWebSearchUnit: ref endpointsCapacityWebSearchUnit,
                endpointsCapacityWebSearchPer: ref endpointsCapacityWebSearchPer,
                endpointsCapacityWebSearchValue: ref endpointsCapacityWebSearchValue,
                endpointsCapacityConcurrencyUnit: ref endpointsCapacityConcurrencyUnit,
                endpointsCapacityConcurrencyValue: ref endpointsCapacityConcurrencyValue,
                endpointsPassthroughParameters: ref endpointsPassthroughParameters,
                endpointsDeprecationDate: ref endpointsDeprecationDate,
                endpointsIsReady: ref endpointsIsReady,
                endpointsIsFree: ref endpointsIsFree,
                endpointsServiceTier: ref endpointsServiceTier,
                endpointsDiscountToUser: ref endpointsDiscountToUser,
                endpointsOpenrouterSlug: ref endpointsOpenrouterSlug,
                endpointsDatacentersCountryCode: ref endpointsDatacentersCountryCode,
                endpointsDatacentersRegion: ref endpointsDatacentersRegion,
                endpointsDeploymentRegion: ref endpointsDeploymentRegion,
                endpointsInputsType: ref endpointsInputsType,
                endpointsInputsTextPricingType: ref endpointsInputsTextPricingType,
                endpointsInputsTextPricingPromptUnit: ref endpointsInputsTextPricingPromptUnit,
                endpointsInputsTextPricingPromptCostUsd: ref endpointsInputsTextPricingPromptCostUsd,
                endpointsInputsTextPricingPromptOverridesCostUsd: ref endpointsInputsTextPricingPromptOverridesCostUsd,
                endpointsInputsTextPricingPromptUtcStart: ref endpointsInputsTextPricingPromptUtcStart,
                endpointsInputsTextPricingPromptUtcEnd: ref endpointsInputsTextPricingPromptUtcEnd,
                endpointsInputsTextPricingPromptUtcDays: ref endpointsInputsTextPricingPromptUtcDays,
                endpointsInputsTextPricingCachedPromptUnit: ref endpointsInputsTextPricingCachedPromptUnit,
                endpointsInputsTextPricingCachedPromptCostUsd: ref endpointsInputsTextPricingCachedPromptCostUsd,
                endpointsInputsTextPricingCachedPromptOverridesCostUsd: ref endpointsInputsTextPricingCachedPromptOverridesCostUsd,
                endpointsInputsTextPricingCachedPromptTtlSeconds: ref endpointsInputsTextPricingCachedPromptTtlSeconds,
                endpointsInputsTextPricingCachedPromptImplicit: ref endpointsInputsTextPricingCachedPromptImplicit,
                endpointsInputsTextPricingCachedPromptUtcStart: ref endpointsInputsTextPricingCachedPromptUtcStart,
                endpointsInputsTextPricingCachedPromptUtcEnd: ref endpointsInputsTextPricingCachedPromptUtcEnd,
                endpointsInputsTextPricingCachedPromptUtcDays: ref endpointsInputsTextPricingCachedPromptUtcDays,
                endpointsInputsTextPricingCacheWriteUnit: ref endpointsInputsTextPricingCacheWriteUnit,
                endpointsInputsTextPricingCacheWriteCostUsd: ref endpointsInputsTextPricingCacheWriteCostUsd,
                endpointsInputsTextPricingCacheWriteOverridesCostUsd: ref endpointsInputsTextPricingCacheWriteOverridesCostUsd,
                endpointsInputsTextPricingCacheWriteTtlSeconds: ref endpointsInputsTextPricingCacheWriteTtlSeconds,
                endpointsInputsTextPricingCacheWriteImplicit: ref endpointsInputsTextPricingCacheWriteImplicit,
                endpointsInputsTextPricingCacheWriteUtcStart: ref endpointsInputsTextPricingCacheWriteUtcStart,
                endpointsInputsTextPricingCacheWriteUtcEnd: ref endpointsInputsTextPricingCacheWriteUtcEnd,
                endpointsInputsTextPricingCacheWriteUtcDays: ref endpointsInputsTextPricingCacheWriteUtcDays,
                endpointsInputsTextCapacityType: ref endpointsInputsTextCapacityType,
                endpointsInputsTextCapacityPromptUnit: ref endpointsInputsTextCapacityPromptUnit,
                endpointsInputsTextCapacityPromptPer: ref endpointsInputsTextCapacityPromptPer,
                endpointsInputsTextCapacityPromptValue: ref endpointsInputsTextCapacityPromptValue,
                endpointsInputsTextCapacityCachedPromptUnit: ref endpointsInputsTextCapacityCachedPromptUnit,
                endpointsInputsTextCapacityCachedPromptPer: ref endpointsInputsTextCapacityCachedPromptPer,
                endpointsInputsTextCapacityCachedPromptValue: ref endpointsInputsTextCapacityCachedPromptValue,
                endpointsInputsTextCapacityCacheWriteUnit: ref endpointsInputsTextCapacityCacheWriteUnit,
                endpointsInputsTextCapacityCacheWritePer: ref endpointsInputsTextCapacityCacheWritePer,
                endpointsInputsTextCapacityCacheWriteValue: ref endpointsInputsTextCapacityCacheWriteValue,
                endpointsInputsTextPassthroughParameters: ref endpointsInputsTextPassthroughParameters,
                endpointsInputsTextParamsMaxPromptLengthValue: ref endpointsInputsTextParamsMaxPromptLengthValue,
                endpointsInputsTextParamsMaxPromptLengthUnit: ref endpointsInputsTextParamsMaxPromptLengthUnit,
                endpointsInputsTextParamsMaxLengthValue: ref endpointsInputsTextParamsMaxLengthValue,
                endpointsInputsTextParamsMaxLengthUnit: ref endpointsInputsTextParamsMaxLengthUnit,
                endpointsInputsImagePricingType: ref endpointsInputsImagePricingType,
                endpointsInputsImagePricingPromptUnit: ref endpointsInputsImagePricingPromptUnit,
                endpointsInputsImagePricingPromptCostUsd: ref endpointsInputsImagePricingPromptCostUsd,
                endpointsInputsImagePricingPromptOverridesCostUsd: ref endpointsInputsImagePricingPromptOverridesCostUsd,
                endpointsInputsImagePricingPromptUtcStart: ref endpointsInputsImagePricingPromptUtcStart,
                endpointsInputsImagePricingPromptUtcEnd: ref endpointsInputsImagePricingPromptUtcEnd,
                endpointsInputsImagePricingPromptUtcDays: ref endpointsInputsImagePricingPromptUtcDays,
                endpointsInputsImagePricingCachedPromptUnit: ref endpointsInputsImagePricingCachedPromptUnit,
                endpointsInputsImagePricingCachedPromptCostUsd: ref endpointsInputsImagePricingCachedPromptCostUsd,
                endpointsInputsImagePricingCachedPromptOverridesCostUsd: ref endpointsInputsImagePricingCachedPromptOverridesCostUsd,
                endpointsInputsImagePricingCachedPromptTtlSeconds: ref endpointsInputsImagePricingCachedPromptTtlSeconds,
                endpointsInputsImagePricingCachedPromptImplicit: ref endpointsInputsImagePricingCachedPromptImplicit,
                endpointsInputsImagePricingCachedPromptUtcStart: ref endpointsInputsImagePricingCachedPromptUtcStart,
                endpointsInputsImagePricingCachedPromptUtcEnd: ref endpointsInputsImagePricingCachedPromptUtcEnd,
                endpointsInputsImagePricingCachedPromptUtcDays: ref endpointsInputsImagePricingCachedPromptUtcDays,
                endpointsInputsImagePricingCacheWriteUnit: ref endpointsInputsImagePricingCacheWriteUnit,
                endpointsInputsImagePricingCacheWriteCostUsd: ref endpointsInputsImagePricingCacheWriteCostUsd,
                endpointsInputsImagePricingCacheWriteOverridesCostUsd: ref endpointsInputsImagePricingCacheWriteOverridesCostUsd,
                endpointsInputsImagePricingCacheWriteTtlSeconds: ref endpointsInputsImagePricingCacheWriteTtlSeconds,
                endpointsInputsImagePricingCacheWriteImplicit: ref endpointsInputsImagePricingCacheWriteImplicit,
                endpointsInputsImagePricingCacheWriteUtcStart: ref endpointsInputsImagePricingCacheWriteUtcStart,
                endpointsInputsImagePricingCacheWriteUtcEnd: ref endpointsInputsImagePricingCacheWriteUtcEnd,
                endpointsInputsImagePricingCacheWriteUtcDays: ref endpointsInputsImagePricingCacheWriteUtcDays,
                endpointsInputsImageCapacityType: ref endpointsInputsImageCapacityType,
                endpointsInputsImageCapacityPromptUnit: ref endpointsInputsImageCapacityPromptUnit,
                endpointsInputsImageCapacityPromptPer: ref endpointsInputsImageCapacityPromptPer,
                endpointsInputsImageCapacityPromptValue: ref endpointsInputsImageCapacityPromptValue,
                endpointsInputsImageCapacityCachedPromptUnit: ref endpointsInputsImageCapacityCachedPromptUnit,
                endpointsInputsImageCapacityCachedPromptPer: ref endpointsInputsImageCapacityCachedPromptPer,
                endpointsInputsImageCapacityCachedPromptValue: ref endpointsInputsImageCapacityCachedPromptValue,
                endpointsInputsImageCapacityCacheWriteUnit: ref endpointsInputsImageCapacityCacheWriteUnit,
                endpointsInputsImageCapacityCacheWritePer: ref endpointsInputsImageCapacityCacheWritePer,
                endpointsInputsImageCapacityCacheWriteValue: ref endpointsInputsImageCapacityCacheWriteValue,
                endpointsInputsImagePassthroughParameters: ref endpointsInputsImagePassthroughParameters,
                endpointsInputsImageParamsSourcesType: ref endpointsInputsImageParamsSourcesType,
                endpointsInputsImageParamsSourcesValues: ref endpointsInputsImageParamsSourcesValues,
                endpointsInputsImageParamsFormatsType: ref endpointsInputsImageParamsFormatsType,
                endpointsInputsImageParamsFormatsValues: ref endpointsInputsImageParamsFormatsValues,
                endpointsInputsImageParamsDetailLevelsType: ref endpointsInputsImageParamsDetailLevelsType,
                endpointsInputsImageParamsDetailLevelsValues: ref endpointsInputsImageParamsDetailLevelsValues,
                endpointsInputsImageParamsReferencesType: ref endpointsInputsImageParamsReferencesType,
                endpointsInputsImageParamsReferencesMin: ref endpointsInputsImageParamsReferencesMin,
                endpointsInputsImageParamsReferencesMax: ref endpointsInputsImageParamsReferencesMax,
                endpointsInputsImageParamsReferencesUnit: ref endpointsInputsImageParamsReferencesUnit,
                endpointsInputsImageParamsRoleType: ref endpointsInputsImageParamsRoleType,
                endpointsInputsImageParamsRoleValues: ref endpointsInputsImageParamsRoleValues,
                endpointsInputsImageParamsMaxContentSizeBytesValue: ref endpointsInputsImageParamsMaxContentSizeBytesValue,
                endpointsInputsImageParamsMaxContentSizeBytesUnit: ref endpointsInputsImageParamsMaxContentSizeBytesUnit,
                endpointsInputsVideoPricingType: ref endpointsInputsVideoPricingType,
                endpointsInputsVideoPricingPromptUnit: ref endpointsInputsVideoPricingPromptUnit,
                endpointsInputsVideoPricingPromptCostUsd: ref endpointsInputsVideoPricingPromptCostUsd,
                endpointsInputsVideoPricingPromptOverridesCostUsd: ref endpointsInputsVideoPricingPromptOverridesCostUsd,
                endpointsInputsVideoPricingPromptUtcStart: ref endpointsInputsVideoPricingPromptUtcStart,
                endpointsInputsVideoPricingPromptUtcEnd: ref endpointsInputsVideoPricingPromptUtcEnd,
                endpointsInputsVideoPricingPromptUtcDays: ref endpointsInputsVideoPricingPromptUtcDays,
                endpointsInputsVideoPricingCachedPromptUnit: ref endpointsInputsVideoPricingCachedPromptUnit,
                endpointsInputsVideoPricingCachedPromptCostUsd: ref endpointsInputsVideoPricingCachedPromptCostUsd,
                endpointsInputsVideoPricingCachedPromptOverridesCostUsd: ref endpointsInputsVideoPricingCachedPromptOverridesCostUsd,
                endpointsInputsVideoPricingCachedPromptTtlSeconds: ref endpointsInputsVideoPricingCachedPromptTtlSeconds,
                endpointsInputsVideoPricingCachedPromptImplicit: ref endpointsInputsVideoPricingCachedPromptImplicit,
                endpointsInputsVideoPricingCachedPromptUtcStart: ref endpointsInputsVideoPricingCachedPromptUtcStart,
                endpointsInputsVideoPricingCachedPromptUtcEnd: ref endpointsInputsVideoPricingCachedPromptUtcEnd,
                endpointsInputsVideoPricingCachedPromptUtcDays: ref endpointsInputsVideoPricingCachedPromptUtcDays,
                endpointsInputsVideoPricingCacheWriteUnit: ref endpointsInputsVideoPricingCacheWriteUnit,
                endpointsInputsVideoPricingCacheWriteCostUsd: ref endpointsInputsVideoPricingCacheWriteCostUsd,
                endpointsInputsVideoPricingCacheWriteOverridesCostUsd: ref endpointsInputsVideoPricingCacheWriteOverridesCostUsd,
                endpointsInputsVideoPricingCacheWriteTtlSeconds: ref endpointsInputsVideoPricingCacheWriteTtlSeconds,
                endpointsInputsVideoPricingCacheWriteImplicit: ref endpointsInputsVideoPricingCacheWriteImplicit,
                endpointsInputsVideoPricingCacheWriteUtcStart: ref endpointsInputsVideoPricingCacheWriteUtcStart,
                endpointsInputsVideoPricingCacheWriteUtcEnd: ref endpointsInputsVideoPricingCacheWriteUtcEnd,
                endpointsInputsVideoPricingCacheWriteUtcDays: ref endpointsInputsVideoPricingCacheWriteUtcDays,
                endpointsInputsVideoCapacityType: ref endpointsInputsVideoCapacityType,
                endpointsInputsVideoCapacityPromptUnit: ref endpointsInputsVideoCapacityPromptUnit,
                endpointsInputsVideoCapacityPromptPer: ref endpointsInputsVideoCapacityPromptPer,
                endpointsInputsVideoCapacityPromptValue: ref endpointsInputsVideoCapacityPromptValue,
                endpointsInputsVideoCapacityCachedPromptUnit: ref endpointsInputsVideoCapacityCachedPromptUnit,
                endpointsInputsVideoCapacityCachedPromptPer: ref endpointsInputsVideoCapacityCachedPromptPer,
                endpointsInputsVideoCapacityCachedPromptValue: ref endpointsInputsVideoCapacityCachedPromptValue,
                endpointsInputsVideoCapacityCacheWriteUnit: ref endpointsInputsVideoCapacityCacheWriteUnit,
                endpointsInputsVideoCapacityCacheWritePer: ref endpointsInputsVideoCapacityCacheWritePer,
                endpointsInputsVideoCapacityCacheWriteValue: ref endpointsInputsVideoCapacityCacheWriteValue,
                endpointsInputsVideoPassthroughParameters: ref endpointsInputsVideoPassthroughParameters,
                endpointsInputsVideoParamsSourcesType: ref endpointsInputsVideoParamsSourcesType,
                endpointsInputsVideoParamsSourcesValues: ref endpointsInputsVideoParamsSourcesValues,
                endpointsInputsVideoParamsFormatsType: ref endpointsInputsVideoParamsFormatsType,
                endpointsInputsVideoParamsFormatsValues: ref endpointsInputsVideoParamsFormatsValues,
                endpointsInputsVideoParamsMaxDurationSecondsValue: ref endpointsInputsVideoParamsMaxDurationSecondsValue,
                endpointsInputsVideoParamsMaxDurationSecondsUnit: ref endpointsInputsVideoParamsMaxDurationSecondsUnit,
                endpointsInputsVideoParamsMaxContentSizeBytesValue: ref endpointsInputsVideoParamsMaxContentSizeBytesValue,
                endpointsInputsVideoParamsMaxContentSizeBytesUnit: ref endpointsInputsVideoParamsMaxContentSizeBytesUnit,
                endpointsInputsAudioPricingType: ref endpointsInputsAudioPricingType,
                endpointsInputsAudioPricingPromptUnit: ref endpointsInputsAudioPricingPromptUnit,
                endpointsInputsAudioPricingPromptCostUsd: ref endpointsInputsAudioPricingPromptCostUsd,
                endpointsInputsAudioPricingPromptOverridesCostUsd: ref endpointsInputsAudioPricingPromptOverridesCostUsd,
                endpointsInputsAudioPricingPromptUtcStart: ref endpointsInputsAudioPricingPromptUtcStart,
                endpointsInputsAudioPricingPromptUtcEnd: ref endpointsInputsAudioPricingPromptUtcEnd,
                endpointsInputsAudioPricingPromptUtcDays: ref endpointsInputsAudioPricingPromptUtcDays,
                endpointsInputsAudioPricingCachedPromptUnit: ref endpointsInputsAudioPricingCachedPromptUnit,
                endpointsInputsAudioPricingCachedPromptCostUsd: ref endpointsInputsAudioPricingCachedPromptCostUsd,
                endpointsInputsAudioPricingCachedPromptOverridesCostUsd: ref endpointsInputsAudioPricingCachedPromptOverridesCostUsd,
                endpointsInputsAudioPricingCachedPromptTtlSeconds: ref endpointsInputsAudioPricingCachedPromptTtlSeconds,
                endpointsInputsAudioPricingCachedPromptImplicit: ref endpointsInputsAudioPricingCachedPromptImplicit,
                endpointsInputsAudioPricingCachedPromptUtcStart: ref endpointsInputsAudioPricingCachedPromptUtcStart,
                endpointsInputsAudioPricingCachedPromptUtcEnd: ref endpointsInputsAudioPricingCachedPromptUtcEnd,
                endpointsInputsAudioPricingCachedPromptUtcDays: ref endpointsInputsAudioPricingCachedPromptUtcDays,
                endpointsInputsAudioPricingCacheWriteUnit: ref endpointsInputsAudioPricingCacheWriteUnit,
                endpointsInputsAudioPricingCacheWriteCostUsd: ref endpointsInputsAudioPricingCacheWriteCostUsd,
                endpointsInputsAudioPricingCacheWriteOverridesCostUsd: ref endpointsInputsAudioPricingCacheWriteOverridesCostUsd,
                endpointsInputsAudioPricingCacheWriteTtlSeconds: ref endpointsInputsAudioPricingCacheWriteTtlSeconds,
                endpointsInputsAudioPricingCacheWriteImplicit: ref endpointsInputsAudioPricingCacheWriteImplicit,
                endpointsInputsAudioPricingCacheWriteUtcStart: ref endpointsInputsAudioPricingCacheWriteUtcStart,
                endpointsInputsAudioPricingCacheWriteUtcEnd: ref endpointsInputsAudioPricingCacheWriteUtcEnd,
                endpointsInputsAudioPricingCacheWriteUtcDays: ref endpointsInputsAudioPricingCacheWriteUtcDays,
                endpointsInputsAudioCapacityType: ref endpointsInputsAudioCapacityType,
                endpointsInputsAudioCapacityPromptUnit: ref endpointsInputsAudioCapacityPromptUnit,
                endpointsInputsAudioCapacityPromptPer: ref endpointsInputsAudioCapacityPromptPer,
                endpointsInputsAudioCapacityPromptValue: ref endpointsInputsAudioCapacityPromptValue,
                endpointsInputsAudioCapacityCachedPromptUnit: ref endpointsInputsAudioCapacityCachedPromptUnit,
                endpointsInputsAudioCapacityCachedPromptPer: ref endpointsInputsAudioCapacityCachedPromptPer,
                endpointsInputsAudioCapacityCachedPromptValue: ref endpointsInputsAudioCapacityCachedPromptValue,
                endpointsInputsAudioCapacityCacheWriteUnit: ref endpointsInputsAudioCapacityCacheWriteUnit,
                endpointsInputsAudioCapacityCacheWritePer: ref endpointsInputsAudioCapacityCacheWritePer,
                endpointsInputsAudioCapacityCacheWriteValue: ref endpointsInputsAudioCapacityCacheWriteValue,
                endpointsInputsAudioPassthroughParameters: ref endpointsInputsAudioPassthroughParameters,
                endpointsInputsAudioParamsSourcesType: ref endpointsInputsAudioParamsSourcesType,
                endpointsInputsAudioParamsSourcesValues: ref endpointsInputsAudioParamsSourcesValues,
                endpointsInputsAudioParamsFormatsType: ref endpointsInputsAudioParamsFormatsType,
                endpointsInputsAudioParamsFormatsValues: ref endpointsInputsAudioParamsFormatsValues,
                endpointsInputsAudioParamsMaxDurationSecondsValue: ref endpointsInputsAudioParamsMaxDurationSecondsValue,
                endpointsInputsAudioParamsMaxDurationSecondsUnit: ref endpointsInputsAudioParamsMaxDurationSecondsUnit,
                endpointsInputsAudioParamsMaxContentSizeBytesValue: ref endpointsInputsAudioParamsMaxContentSizeBytesValue,
                endpointsInputsAudioParamsMaxContentSizeBytesUnit: ref endpointsInputsAudioParamsMaxContentSizeBytesUnit,
                endpointsInputsFilePricingType: ref endpointsInputsFilePricingType,
                endpointsInputsFilePricingPromptUnit: ref endpointsInputsFilePricingPromptUnit,
                endpointsInputsFilePricingPromptCostUsd: ref endpointsInputsFilePricingPromptCostUsd,
                endpointsInputsFilePricingPromptOverridesCostUsd: ref endpointsInputsFilePricingPromptOverridesCostUsd,
                endpointsInputsFilePricingPromptUtcStart: ref endpointsInputsFilePricingPromptUtcStart,
                endpointsInputsFilePricingPromptUtcEnd: ref endpointsInputsFilePricingPromptUtcEnd,
                endpointsInputsFilePricingPromptUtcDays: ref endpointsInputsFilePricingPromptUtcDays,
                endpointsInputsFilePricingCachedPromptUnit: ref endpointsInputsFilePricingCachedPromptUnit,
                endpointsInputsFilePricingCachedPromptCostUsd: ref endpointsInputsFilePricingCachedPromptCostUsd,
                endpointsInputsFilePricingCachedPromptOverridesCostUsd: ref endpointsInputsFilePricingCachedPromptOverridesCostUsd,
                endpointsInputsFilePricingCachedPromptTtlSeconds: ref endpointsInputsFilePricingCachedPromptTtlSeconds,
                endpointsInputsFilePricingCachedPromptImplicit: ref endpointsInputsFilePricingCachedPromptImplicit,
                endpointsInputsFilePricingCachedPromptUtcStart: ref endpointsInputsFilePricingCachedPromptUtcStart,
                endpointsInputsFilePricingCachedPromptUtcEnd: ref endpointsInputsFilePricingCachedPromptUtcEnd,
                endpointsInputsFilePricingCachedPromptUtcDays: ref endpointsInputsFilePricingCachedPromptUtcDays,
                endpointsInputsFilePricingCacheWriteUnit: ref endpointsInputsFilePricingCacheWriteUnit,
                endpointsInputsFilePricingCacheWriteCostUsd: ref endpointsInputsFilePricingCacheWriteCostUsd,
                endpointsInputsFilePricingCacheWriteOverridesCostUsd: ref endpointsInputsFilePricingCacheWriteOverridesCostUsd,
                endpointsInputsFilePricingCacheWriteTtlSeconds: ref endpointsInputsFilePricingCacheWriteTtlSeconds,
                endpointsInputsFilePricingCacheWriteImplicit: ref endpointsInputsFilePricingCacheWriteImplicit,
                endpointsInputsFilePricingCacheWriteUtcStart: ref endpointsInputsFilePricingCacheWriteUtcStart,
                endpointsInputsFilePricingCacheWriteUtcEnd: ref endpointsInputsFilePricingCacheWriteUtcEnd,
                endpointsInputsFilePricingCacheWriteUtcDays: ref endpointsInputsFilePricingCacheWriteUtcDays,
                endpointsInputsFileCapacityType: ref endpointsInputsFileCapacityType,
                endpointsInputsFileCapacityPromptUnit: ref endpointsInputsFileCapacityPromptUnit,
                endpointsInputsFileCapacityPromptPer: ref endpointsInputsFileCapacityPromptPer,
                endpointsInputsFileCapacityPromptValue: ref endpointsInputsFileCapacityPromptValue,
                endpointsInputsFileCapacityCachedPromptUnit: ref endpointsInputsFileCapacityCachedPromptUnit,
                endpointsInputsFileCapacityCachedPromptPer: ref endpointsInputsFileCapacityCachedPromptPer,
                endpointsInputsFileCapacityCachedPromptValue: ref endpointsInputsFileCapacityCachedPromptValue,
                endpointsInputsFileCapacityCacheWriteUnit: ref endpointsInputsFileCapacityCacheWriteUnit,
                endpointsInputsFileCapacityCacheWritePer: ref endpointsInputsFileCapacityCacheWritePer,
                endpointsInputsFileCapacityCacheWriteValue: ref endpointsInputsFileCapacityCacheWriteValue,
                endpointsInputsFilePassthroughParameters: ref endpointsInputsFilePassthroughParameters,
                endpointsInputsFileParamsSourcesType: ref endpointsInputsFileParamsSourcesType,
                endpointsInputsFileParamsSourcesValues: ref endpointsInputsFileParamsSourcesValues,
                endpointsInputsFileParamsFormatsType: ref endpointsInputsFileParamsFormatsType,
                endpointsInputsFileParamsFormatsValues: ref endpointsInputsFileParamsFormatsValues,
                endpointsInputsFileParamsReferencesType: ref endpointsInputsFileParamsReferencesType,
                endpointsInputsFileParamsReferencesMin: ref endpointsInputsFileParamsReferencesMin,
                endpointsInputsFileParamsReferencesMax: ref endpointsInputsFileParamsReferencesMax,
                endpointsInputsFileParamsReferencesUnit: ref endpointsInputsFileParamsReferencesUnit,
                endpointsInputsFileParamsMaxContentSizeBytesValue: ref endpointsInputsFileParamsMaxContentSizeBytesValue,
                endpointsInputsFileParamsMaxContentSizeBytesUnit: ref endpointsInputsFileParamsMaxContentSizeBytesUnit,
                endpointsOutputsType: ref endpointsOutputsType,
                endpointsOutputsTextMaxLengthValue: ref endpointsOutputsTextMaxLengthValue,
                endpointsOutputsTextMaxLengthUnit: ref endpointsOutputsTextMaxLengthUnit,
                endpointsOutputsTextPassthroughParameters: ref endpointsOutputsTextPassthroughParameters,
                endpointsOutputsTextPricingType: ref endpointsOutputsTextPricingType,
                endpointsOutputsTextPricingCompletionUnit: ref endpointsOutputsTextPricingCompletionUnit,
                endpointsOutputsTextPricingCompletionCostUsd: ref endpointsOutputsTextPricingCompletionCostUsd,
                endpointsOutputsTextPricingCompletionOverridesCostUsd: ref endpointsOutputsTextPricingCompletionOverridesCostUsd,
                endpointsOutputsTextPricingCompletionUtcStart: ref endpointsOutputsTextPricingCompletionUtcStart,
                endpointsOutputsTextPricingCompletionUtcEnd: ref endpointsOutputsTextPricingCompletionUtcEnd,
                endpointsOutputsTextPricingCompletionUtcDays: ref endpointsOutputsTextPricingCompletionUtcDays,
                endpointsOutputsTextPricingInternalReasoningUnit: ref endpointsOutputsTextPricingInternalReasoningUnit,
                endpointsOutputsTextPricingInternalReasoningCostUsd: ref endpointsOutputsTextPricingInternalReasoningCostUsd,
                endpointsOutputsTextPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsTextPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsTextPricingInternalReasoningUtcStart: ref endpointsOutputsTextPricingInternalReasoningUtcStart,
                endpointsOutputsTextPricingInternalReasoningUtcEnd: ref endpointsOutputsTextPricingInternalReasoningUtcEnd,
                endpointsOutputsTextPricingInternalReasoningUtcDays: ref endpointsOutputsTextPricingInternalReasoningUtcDays,
                endpointsOutputsTextCapacityType: ref endpointsOutputsTextCapacityType,
                endpointsOutputsTextCapacityCompletionUnit: ref endpointsOutputsTextCapacityCompletionUnit,
                endpointsOutputsTextCapacityCompletionPer: ref endpointsOutputsTextCapacityCompletionPer,
                endpointsOutputsTextCapacityCompletionValue: ref endpointsOutputsTextCapacityCompletionValue,
                endpointsOutputsTextCapacityInternalReasoningUnit: ref endpointsOutputsTextCapacityInternalReasoningUnit,
                endpointsOutputsTextCapacityInternalReasoningPer: ref endpointsOutputsTextCapacityInternalReasoningPer,
                endpointsOutputsTextCapacityInternalReasoningValue: ref endpointsOutputsTextCapacityInternalReasoningValue,
                endpointsOutputsTextCapacityConcurrencyUnit: ref endpointsOutputsTextCapacityConcurrencyUnit,
                endpointsOutputsTextCapacityConcurrencyValue: ref endpointsOutputsTextCapacityConcurrencyValue,
                endpointsOutputsTextStreaming: ref endpointsOutputsTextStreaming,
                endpointsOutputsTextParams: ref endpointsOutputsTextParams,
                endpointsOutputsImagePassthroughParameters: ref endpointsOutputsImagePassthroughParameters,
                endpointsOutputsImagePricingType: ref endpointsOutputsImagePricingType,
                endpointsOutputsImagePricingCompletionUnit: ref endpointsOutputsImagePricingCompletionUnit,
                endpointsOutputsImagePricingCompletionCostUsd: ref endpointsOutputsImagePricingCompletionCostUsd,
                endpointsOutputsImagePricingCompletionOverridesCostUsd: ref endpointsOutputsImagePricingCompletionOverridesCostUsd,
                endpointsOutputsImagePricingCompletionUtcStart: ref endpointsOutputsImagePricingCompletionUtcStart,
                endpointsOutputsImagePricingCompletionUtcEnd: ref endpointsOutputsImagePricingCompletionUtcEnd,
                endpointsOutputsImagePricingCompletionUtcDays: ref endpointsOutputsImagePricingCompletionUtcDays,
                endpointsOutputsImagePricingInternalReasoningUnit: ref endpointsOutputsImagePricingInternalReasoningUnit,
                endpointsOutputsImagePricingInternalReasoningCostUsd: ref endpointsOutputsImagePricingInternalReasoningCostUsd,
                endpointsOutputsImagePricingInternalReasoningOverridesCostUsd: ref endpointsOutputsImagePricingInternalReasoningOverridesCostUsd,
                endpointsOutputsImagePricingInternalReasoningUtcStart: ref endpointsOutputsImagePricingInternalReasoningUtcStart,
                endpointsOutputsImagePricingInternalReasoningUtcEnd: ref endpointsOutputsImagePricingInternalReasoningUtcEnd,
                endpointsOutputsImagePricingInternalReasoningUtcDays: ref endpointsOutputsImagePricingInternalReasoningUtcDays,
                endpointsOutputsImageCapacityType: ref endpointsOutputsImageCapacityType,
                endpointsOutputsImageCapacityCompletionUnit: ref endpointsOutputsImageCapacityCompletionUnit,
                endpointsOutputsImageCapacityCompletionPer: ref endpointsOutputsImageCapacityCompletionPer,
                endpointsOutputsImageCapacityCompletionValue: ref endpointsOutputsImageCapacityCompletionValue,
                endpointsOutputsImageCapacityInternalReasoningUnit: ref endpointsOutputsImageCapacityInternalReasoningUnit,
                endpointsOutputsImageCapacityInternalReasoningPer: ref endpointsOutputsImageCapacityInternalReasoningPer,
                endpointsOutputsImageCapacityInternalReasoningValue: ref endpointsOutputsImageCapacityInternalReasoningValue,
                endpointsOutputsImageCapacityConcurrencyUnit: ref endpointsOutputsImageCapacityConcurrencyUnit,
                endpointsOutputsImageCapacityConcurrencyValue: ref endpointsOutputsImageCapacityConcurrencyValue,
                endpointsOutputsImageStreaming: ref endpointsOutputsImageStreaming,
                endpointsOutputsImageParams: ref endpointsOutputsImageParams,
                endpointsOutputsVideoPassthroughParameters: ref endpointsOutputsVideoPassthroughParameters,
                endpointsOutputsVideoPricingType: ref endpointsOutputsVideoPricingType,
                endpointsOutputsVideoPricingCompletionUnit: ref endpointsOutputsVideoPricingCompletionUnit,
                endpointsOutputsVideoPricingCompletionCostUsd: ref endpointsOutputsVideoPricingCompletionCostUsd,
                endpointsOutputsVideoPricingCompletionOverridesCostUsd: ref endpointsOutputsVideoPricingCompletionOverridesCostUsd,
                endpointsOutputsVideoPricingCompletionUtcStart: ref endpointsOutputsVideoPricingCompletionUtcStart,
                endpointsOutputsVideoPricingCompletionUtcEnd: ref endpointsOutputsVideoPricingCompletionUtcEnd,
                endpointsOutputsVideoPricingCompletionUtcDays: ref endpointsOutputsVideoPricingCompletionUtcDays,
                endpointsOutputsVideoPricingInternalReasoningUnit: ref endpointsOutputsVideoPricingInternalReasoningUnit,
                endpointsOutputsVideoPricingInternalReasoningCostUsd: ref endpointsOutputsVideoPricingInternalReasoningCostUsd,
                endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsVideoPricingInternalReasoningUtcStart: ref endpointsOutputsVideoPricingInternalReasoningUtcStart,
                endpointsOutputsVideoPricingInternalReasoningUtcEnd: ref endpointsOutputsVideoPricingInternalReasoningUtcEnd,
                endpointsOutputsVideoPricingInternalReasoningUtcDays: ref endpointsOutputsVideoPricingInternalReasoningUtcDays,
                endpointsOutputsVideoCapacityType: ref endpointsOutputsVideoCapacityType,
                endpointsOutputsVideoCapacityCompletionUnit: ref endpointsOutputsVideoCapacityCompletionUnit,
                endpointsOutputsVideoCapacityCompletionPer: ref endpointsOutputsVideoCapacityCompletionPer,
                endpointsOutputsVideoCapacityCompletionValue: ref endpointsOutputsVideoCapacityCompletionValue,
                endpointsOutputsVideoCapacityInternalReasoningUnit: ref endpointsOutputsVideoCapacityInternalReasoningUnit,
                endpointsOutputsVideoCapacityInternalReasoningPer: ref endpointsOutputsVideoCapacityInternalReasoningPer,
                endpointsOutputsVideoCapacityInternalReasoningValue: ref endpointsOutputsVideoCapacityInternalReasoningValue,
                endpointsOutputsVideoCapacityConcurrencyUnit: ref endpointsOutputsVideoCapacityConcurrencyUnit,
                endpointsOutputsVideoCapacityConcurrencyValue: ref endpointsOutputsVideoCapacityConcurrencyValue,
                endpointsOutputsVideoStreaming: ref endpointsOutputsVideoStreaming,
                endpointsOutputsVideoParams: ref endpointsOutputsVideoParams,
                endpointsOutputsSpeechPassthroughParameters: ref endpointsOutputsSpeechPassthroughParameters,
                endpointsOutputsSpeechPricingType: ref endpointsOutputsSpeechPricingType,
                endpointsOutputsSpeechPricingCompletionUnit: ref endpointsOutputsSpeechPricingCompletionUnit,
                endpointsOutputsSpeechPricingCompletionCostUsd: ref endpointsOutputsSpeechPricingCompletionCostUsd,
                endpointsOutputsSpeechPricingCompletionOverridesCostUsd: ref endpointsOutputsSpeechPricingCompletionOverridesCostUsd,
                endpointsOutputsSpeechPricingCompletionUtcStart: ref endpointsOutputsSpeechPricingCompletionUtcStart,
                endpointsOutputsSpeechPricingCompletionUtcEnd: ref endpointsOutputsSpeechPricingCompletionUtcEnd,
                endpointsOutputsSpeechPricingCompletionUtcDays: ref endpointsOutputsSpeechPricingCompletionUtcDays,
                endpointsOutputsSpeechPricingInternalReasoningUnit: ref endpointsOutputsSpeechPricingInternalReasoningUnit,
                endpointsOutputsSpeechPricingInternalReasoningCostUsd: ref endpointsOutputsSpeechPricingInternalReasoningCostUsd,
                endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsSpeechPricingInternalReasoningUtcStart: ref endpointsOutputsSpeechPricingInternalReasoningUtcStart,
                endpointsOutputsSpeechPricingInternalReasoningUtcEnd: ref endpointsOutputsSpeechPricingInternalReasoningUtcEnd,
                endpointsOutputsSpeechPricingInternalReasoningUtcDays: ref endpointsOutputsSpeechPricingInternalReasoningUtcDays,
                endpointsOutputsSpeechCapacityType: ref endpointsOutputsSpeechCapacityType,
                endpointsOutputsSpeechCapacityCompletionUnit: ref endpointsOutputsSpeechCapacityCompletionUnit,
                endpointsOutputsSpeechCapacityCompletionPer: ref endpointsOutputsSpeechCapacityCompletionPer,
                endpointsOutputsSpeechCapacityCompletionValue: ref endpointsOutputsSpeechCapacityCompletionValue,
                endpointsOutputsSpeechCapacityInternalReasoningUnit: ref endpointsOutputsSpeechCapacityInternalReasoningUnit,
                endpointsOutputsSpeechCapacityInternalReasoningPer: ref endpointsOutputsSpeechCapacityInternalReasoningPer,
                endpointsOutputsSpeechCapacityInternalReasoningValue: ref endpointsOutputsSpeechCapacityInternalReasoningValue,
                endpointsOutputsSpeechCapacityConcurrencyUnit: ref endpointsOutputsSpeechCapacityConcurrencyUnit,
                endpointsOutputsSpeechCapacityConcurrencyValue: ref endpointsOutputsSpeechCapacityConcurrencyValue,
                endpointsOutputsSpeechStreaming: ref endpointsOutputsSpeechStreaming,
                endpointsOutputsSpeechParams: ref endpointsOutputsSpeechParams,
                endpointsOutputsTranscriptionPassthroughParameters: ref endpointsOutputsTranscriptionPassthroughParameters,
                endpointsOutputsTranscriptionPricingType: ref endpointsOutputsTranscriptionPricingType,
                endpointsOutputsTranscriptionPricingCompletionUnit: ref endpointsOutputsTranscriptionPricingCompletionUnit,
                endpointsOutputsTranscriptionPricingCompletionCostUsd: ref endpointsOutputsTranscriptionPricingCompletionCostUsd,
                endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd: ref endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd,
                endpointsOutputsTranscriptionPricingCompletionUtcStart: ref endpointsOutputsTranscriptionPricingCompletionUtcStart,
                endpointsOutputsTranscriptionPricingCompletionUtcEnd: ref endpointsOutputsTranscriptionPricingCompletionUtcEnd,
                endpointsOutputsTranscriptionPricingCompletionUtcDays: ref endpointsOutputsTranscriptionPricingCompletionUtcDays,
                endpointsOutputsTranscriptionPricingInternalReasoningUnit: ref endpointsOutputsTranscriptionPricingInternalReasoningUnit,
                endpointsOutputsTranscriptionPricingInternalReasoningCostUsd: ref endpointsOutputsTranscriptionPricingInternalReasoningCostUsd,
                endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsTranscriptionPricingInternalReasoningUtcStart: ref endpointsOutputsTranscriptionPricingInternalReasoningUtcStart,
                endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd: ref endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd,
                endpointsOutputsTranscriptionPricingInternalReasoningUtcDays: ref endpointsOutputsTranscriptionPricingInternalReasoningUtcDays,
                endpointsOutputsTranscriptionCapacityType: ref endpointsOutputsTranscriptionCapacityType,
                endpointsOutputsTranscriptionCapacityCompletionUnit: ref endpointsOutputsTranscriptionCapacityCompletionUnit,
                endpointsOutputsTranscriptionCapacityCompletionPer: ref endpointsOutputsTranscriptionCapacityCompletionPer,
                endpointsOutputsTranscriptionCapacityCompletionValue: ref endpointsOutputsTranscriptionCapacityCompletionValue,
                endpointsOutputsTranscriptionCapacityInternalReasoningUnit: ref endpointsOutputsTranscriptionCapacityInternalReasoningUnit,
                endpointsOutputsTranscriptionCapacityInternalReasoningPer: ref endpointsOutputsTranscriptionCapacityInternalReasoningPer,
                endpointsOutputsTranscriptionCapacityInternalReasoningValue: ref endpointsOutputsTranscriptionCapacityInternalReasoningValue,
                endpointsOutputsTranscriptionCapacityConcurrencyUnit: ref endpointsOutputsTranscriptionCapacityConcurrencyUnit,
                endpointsOutputsTranscriptionCapacityConcurrencyValue: ref endpointsOutputsTranscriptionCapacityConcurrencyValue,
                endpointsOutputsTranscriptionStreaming: ref endpointsOutputsTranscriptionStreaming,
                endpointsOutputsTranscriptionParams: ref endpointsOutputsTranscriptionParams,
                endpointsOutputsEmbeddingsPassthroughParameters: ref endpointsOutputsEmbeddingsPassthroughParameters,
                endpointsOutputsEmbeddingsPricingType: ref endpointsOutputsEmbeddingsPricingType,
                endpointsOutputsEmbeddingsPricingCompletionUnit: ref endpointsOutputsEmbeddingsPricingCompletionUnit,
                endpointsOutputsEmbeddingsPricingCompletionCostUsd: ref endpointsOutputsEmbeddingsPricingCompletionCostUsd,
                endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd: ref endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd,
                endpointsOutputsEmbeddingsPricingCompletionUtcStart: ref endpointsOutputsEmbeddingsPricingCompletionUtcStart,
                endpointsOutputsEmbeddingsPricingCompletionUtcEnd: ref endpointsOutputsEmbeddingsPricingCompletionUtcEnd,
                endpointsOutputsEmbeddingsPricingCompletionUtcDays: ref endpointsOutputsEmbeddingsPricingCompletionUtcDays,
                endpointsOutputsEmbeddingsPricingInternalReasoningUnit: ref endpointsOutputsEmbeddingsPricingInternalReasoningUnit,
                endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd: ref endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd,
                endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart: ref endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart,
                endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd: ref endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd,
                endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays: ref endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays,
                endpointsOutputsEmbeddingsCapacityType: ref endpointsOutputsEmbeddingsCapacityType,
                endpointsOutputsEmbeddingsCapacityCompletionUnit: ref endpointsOutputsEmbeddingsCapacityCompletionUnit,
                endpointsOutputsEmbeddingsCapacityCompletionPer: ref endpointsOutputsEmbeddingsCapacityCompletionPer,
                endpointsOutputsEmbeddingsCapacityCompletionValue: ref endpointsOutputsEmbeddingsCapacityCompletionValue,
                endpointsOutputsEmbeddingsCapacityInternalReasoningUnit: ref endpointsOutputsEmbeddingsCapacityInternalReasoningUnit,
                endpointsOutputsEmbeddingsCapacityInternalReasoningPer: ref endpointsOutputsEmbeddingsCapacityInternalReasoningPer,
                endpointsOutputsEmbeddingsCapacityInternalReasoningValue: ref endpointsOutputsEmbeddingsCapacityInternalReasoningValue,
                endpointsOutputsEmbeddingsCapacityConcurrencyUnit: ref endpointsOutputsEmbeddingsCapacityConcurrencyUnit,
                endpointsOutputsEmbeddingsCapacityConcurrencyValue: ref endpointsOutputsEmbeddingsCapacityConcurrencyValue,
                endpointsOutputsEmbeddingsParams: ref endpointsOutputsEmbeddingsParams,
                endpointsOutputsRerankPassthroughParameters: ref endpointsOutputsRerankPassthroughParameters,
                endpointsOutputsRerankPricingType: ref endpointsOutputsRerankPricingType,
                endpointsOutputsRerankPricingCompletionUnit: ref endpointsOutputsRerankPricingCompletionUnit,
                endpointsOutputsRerankPricingCompletionCostUsd: ref endpointsOutputsRerankPricingCompletionCostUsd,
                endpointsOutputsRerankPricingCompletionOverridesCostUsd: ref endpointsOutputsRerankPricingCompletionOverridesCostUsd,
                endpointsOutputsRerankPricingCompletionUtcStart: ref endpointsOutputsRerankPricingCompletionUtcStart,
                endpointsOutputsRerankPricingCompletionUtcEnd: ref endpointsOutputsRerankPricingCompletionUtcEnd,
                endpointsOutputsRerankPricingCompletionUtcDays: ref endpointsOutputsRerankPricingCompletionUtcDays,
                endpointsOutputsRerankPricingInternalReasoningUnit: ref endpointsOutputsRerankPricingInternalReasoningUnit,
                endpointsOutputsRerankPricingInternalReasoningCostUsd: ref endpointsOutputsRerankPricingInternalReasoningCostUsd,
                endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsRerankPricingInternalReasoningUtcStart: ref endpointsOutputsRerankPricingInternalReasoningUtcStart,
                endpointsOutputsRerankPricingInternalReasoningUtcEnd: ref endpointsOutputsRerankPricingInternalReasoningUtcEnd,
                endpointsOutputsRerankPricingInternalReasoningUtcDays: ref endpointsOutputsRerankPricingInternalReasoningUtcDays,
                endpointsOutputsRerankCapacityType: ref endpointsOutputsRerankCapacityType,
                endpointsOutputsRerankCapacityCompletionUnit: ref endpointsOutputsRerankCapacityCompletionUnit,
                endpointsOutputsRerankCapacityCompletionPer: ref endpointsOutputsRerankCapacityCompletionPer,
                endpointsOutputsRerankCapacityCompletionValue: ref endpointsOutputsRerankCapacityCompletionValue,
                endpointsOutputsRerankCapacityInternalReasoningUnit: ref endpointsOutputsRerankCapacityInternalReasoningUnit,
                endpointsOutputsRerankCapacityInternalReasoningPer: ref endpointsOutputsRerankCapacityInternalReasoningPer,
                endpointsOutputsRerankCapacityInternalReasoningValue: ref endpointsOutputsRerankCapacityInternalReasoningValue,
                endpointsOutputsRerankCapacityConcurrencyUnit: ref endpointsOutputsRerankCapacityConcurrencyUnit,
                endpointsOutputsRerankCapacityConcurrencyValue: ref endpointsOutputsRerankCapacityConcurrencyValue,
                endpointsOutputsRerankParams: ref endpointsOutputsRerankParams,
                endpointsOutputsDecisionsPassthroughParameters: ref endpointsOutputsDecisionsPassthroughParameters,
                endpointsOutputsDecisionsPricingType: ref endpointsOutputsDecisionsPricingType,
                endpointsOutputsDecisionsPricingCompletionUnit: ref endpointsOutputsDecisionsPricingCompletionUnit,
                endpointsOutputsDecisionsPricingCompletionCostUsd: ref endpointsOutputsDecisionsPricingCompletionCostUsd,
                endpointsOutputsDecisionsPricingCompletionOverridesCostUsd: ref endpointsOutputsDecisionsPricingCompletionOverridesCostUsd,
                endpointsOutputsDecisionsPricingCompletionUtcStart: ref endpointsOutputsDecisionsPricingCompletionUtcStart,
                endpointsOutputsDecisionsPricingCompletionUtcEnd: ref endpointsOutputsDecisionsPricingCompletionUtcEnd,
                endpointsOutputsDecisionsPricingCompletionUtcDays: ref endpointsOutputsDecisionsPricingCompletionUtcDays,
                endpointsOutputsDecisionsPricingInternalReasoningUnit: ref endpointsOutputsDecisionsPricingInternalReasoningUnit,
                endpointsOutputsDecisionsPricingInternalReasoningCostUsd: ref endpointsOutputsDecisionsPricingInternalReasoningCostUsd,
                endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsDecisionsPricingInternalReasoningUtcStart: ref endpointsOutputsDecisionsPricingInternalReasoningUtcStart,
                endpointsOutputsDecisionsPricingInternalReasoningUtcEnd: ref endpointsOutputsDecisionsPricingInternalReasoningUtcEnd,
                endpointsOutputsDecisionsPricingInternalReasoningUtcDays: ref endpointsOutputsDecisionsPricingInternalReasoningUtcDays,
                endpointsOutputsDecisionsCapacityType: ref endpointsOutputsDecisionsCapacityType,
                endpointsOutputsDecisionsCapacityCompletionUnit: ref endpointsOutputsDecisionsCapacityCompletionUnit,
                endpointsOutputsDecisionsCapacityCompletionPer: ref endpointsOutputsDecisionsCapacityCompletionPer,
                endpointsOutputsDecisionsCapacityCompletionValue: ref endpointsOutputsDecisionsCapacityCompletionValue,
                endpointsOutputsDecisionsCapacityInternalReasoningUnit: ref endpointsOutputsDecisionsCapacityInternalReasoningUnit,
                endpointsOutputsDecisionsCapacityInternalReasoningPer: ref endpointsOutputsDecisionsCapacityInternalReasoningPer,
                endpointsOutputsDecisionsCapacityInternalReasoningValue: ref endpointsOutputsDecisionsCapacityInternalReasoningValue,
                endpointsOutputsDecisionsCapacityConcurrencyUnit: ref endpointsOutputsDecisionsCapacityConcurrencyUnit,
                endpointsOutputsDecisionsCapacityConcurrencyValue: ref endpointsOutputsDecisionsCapacityConcurrencyValue,
                endpointsOutputsDecisionsParams: ref endpointsOutputsDecisionsParams,
                endpointsOutputsAudioPassthroughParameters: ref endpointsOutputsAudioPassthroughParameters,
                endpointsOutputsAudioPricingType: ref endpointsOutputsAudioPricingType,
                endpointsOutputsAudioPricingCompletionUnit: ref endpointsOutputsAudioPricingCompletionUnit,
                endpointsOutputsAudioPricingCompletionCostUsd: ref endpointsOutputsAudioPricingCompletionCostUsd,
                endpointsOutputsAudioPricingCompletionOverridesCostUsd: ref endpointsOutputsAudioPricingCompletionOverridesCostUsd,
                endpointsOutputsAudioPricingCompletionUtcStart: ref endpointsOutputsAudioPricingCompletionUtcStart,
                endpointsOutputsAudioPricingCompletionUtcEnd: ref endpointsOutputsAudioPricingCompletionUtcEnd,
                endpointsOutputsAudioPricingCompletionUtcDays: ref endpointsOutputsAudioPricingCompletionUtcDays,
                endpointsOutputsAudioPricingInternalReasoningUnit: ref endpointsOutputsAudioPricingInternalReasoningUnit,
                endpointsOutputsAudioPricingInternalReasoningCostUsd: ref endpointsOutputsAudioPricingInternalReasoningCostUsd,
                endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd: ref endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd,
                endpointsOutputsAudioPricingInternalReasoningUtcStart: ref endpointsOutputsAudioPricingInternalReasoningUtcStart,
                endpointsOutputsAudioPricingInternalReasoningUtcEnd: ref endpointsOutputsAudioPricingInternalReasoningUtcEnd,
                endpointsOutputsAudioPricingInternalReasoningUtcDays: ref endpointsOutputsAudioPricingInternalReasoningUtcDays,
                endpointsOutputsAudioCapacityType: ref endpointsOutputsAudioCapacityType,
                endpointsOutputsAudioCapacityCompletionUnit: ref endpointsOutputsAudioCapacityCompletionUnit,
                endpointsOutputsAudioCapacityCompletionPer: ref endpointsOutputsAudioCapacityCompletionPer,
                endpointsOutputsAudioCapacityCompletionValue: ref endpointsOutputsAudioCapacityCompletionValue,
                endpointsOutputsAudioCapacityInternalReasoningUnit: ref endpointsOutputsAudioCapacityInternalReasoningUnit,
                endpointsOutputsAudioCapacityInternalReasoningPer: ref endpointsOutputsAudioCapacityInternalReasoningPer,
                endpointsOutputsAudioCapacityInternalReasoningValue: ref endpointsOutputsAudioCapacityInternalReasoningValue,
                endpointsOutputsAudioCapacityConcurrencyUnit: ref endpointsOutputsAudioCapacityConcurrencyUnit,
                endpointsOutputsAudioCapacityConcurrencyValue: ref endpointsOutputsAudioCapacityConcurrencyValue,
                endpointsOutputsAudioStreaming: ref endpointsOutputsAudioStreaming,
                endpointsOutputsAudioParams: ref endpointsOutputsAudioParams,
                endpointsProviderSlug: ref endpointsProviderSlug,
                endpointsProviderTag: ref endpointsProviderTag,
                endpointsProviderName: ref endpointsProviderName,
                endpointsDataPolicyTraining: ref endpointsDataPolicyTraining,
                endpointsDataPolicyRetainsPrompts: ref endpointsDataPolicyRetainsPrompts,
                endpointsDataPolicyRetentionDays: ref endpointsDataPolicyRetentionDays);


            var __authorizations = global::OpenRouter.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListV2SecurityRequirements,
                operationName: "ListV2Async");

            using var __timeoutCancellationTokenSource = global::OpenRouter.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::OpenRouter.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::OpenRouter.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::OpenRouter.PathBuilder(
                                path: "/api/v2/models",
                                baseUri: ResolveBaseUri(
                                servers: s_ListV2Servers,
                                defaultBaseUrl: "https://openrouter.ai/"));
                            __pathBuilder
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("region", region?.ToValueString())
                                .AddOptionalParameter("sort", sort)
                                .AddOptionalParameter("id", id)
                                .AddOptionalParameter("canonical_slug", canonicalSlug)
                                .AddOptionalParameter("author", author)
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("variant", variant)
                                .AddOptionalParameter("kind", kind)
                                .AddOptionalParameter("alias_target.slug", aliasTargetSlug)
                                .AddOptionalParameter("alias_target.name", aliasTargetName)
                                .AddOptionalParameter("created", created)
                                .AddOptionalParameter("description", description)
                                .AddOptionalParameter("context_length", contextLength)
                                .AddOptionalParameter("hugging_face_id", huggingFaceId)
                                .AddOptionalParameter("inputs", inputs)
                                .AddOptionalParameter("outputs", outputs)
                                .AddOptionalParameter("endpoints.schema_version", endpointsSchemaVersion)
                                .AddOptionalParameter("endpoints.id", endpointsId)
                                .AddOptionalParameter("endpoints.hugging_face_id", endpointsHuggingFaceId)
                                .AddOptionalParameter("endpoints.name", endpointsName)
                                .AddOptionalParameter("endpoints.created", endpointsCreated)
                                .AddOptionalParameter("endpoints.quantization", endpointsQuantization)
                                .AddOptionalParameter("endpoints.tokenizer", endpointsTokenizer)
                                .AddOptionalParameter("endpoints.description", endpointsDescription)
                                .AddOptionalParameter("endpoints.pricing.type", endpointsPricingType)
                                .AddOptionalParameter("endpoints.pricing.request.unit", endpointsPricingRequestUnit)
                                .AddOptionalParameter("endpoints.pricing.request.cost_usd", endpointsPricingRequestCostUsd)
                                .AddOptionalParameter("endpoints.pricing.request.overrides.cost_usd", endpointsPricingRequestOverridesCostUsd)
                                .AddOptionalParameter("endpoints.pricing.web_search.unit", endpointsPricingWebSearchUnit)
                                .AddOptionalParameter("endpoints.pricing.web_search.cost_usd", endpointsPricingWebSearchCostUsd)
                                .AddOptionalParameter("endpoints.pricing.web_search.overrides.cost_usd", endpointsPricingWebSearchOverridesCostUsd)
                                .AddOptionalParameter("endpoints.capacity.type", endpointsCapacityType)
                                .AddOptionalParameter("endpoints.capacity.request.unit", endpointsCapacityRequestUnit)
                                .AddOptionalParameter("endpoints.capacity.request.per", endpointsCapacityRequestPer)
                                .AddOptionalParameter("endpoints.capacity.request.value", endpointsCapacityRequestValue)
                                .AddOptionalParameter("endpoints.capacity.web_search.unit", endpointsCapacityWebSearchUnit)
                                .AddOptionalParameter("endpoints.capacity.web_search.per", endpointsCapacityWebSearchPer)
                                .AddOptionalParameter("endpoints.capacity.web_search.value", endpointsCapacityWebSearchValue)
                                .AddOptionalParameter("endpoints.capacity.concurrency.unit", endpointsCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.capacity.concurrency.value", endpointsCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.passthrough_parameters", endpointsPassthroughParameters)
                                .AddOptionalParameter("endpoints.deprecation_date", endpointsDeprecationDate)
                                .AddOptionalParameter("endpoints.is_ready", endpointsIsReady)
                                .AddOptionalParameter("endpoints.is_free", endpointsIsFree)
                                .AddOptionalParameter("endpoints.service_tier", endpointsServiceTier)
                                .AddOptionalParameter("endpoints.discount_to_user", endpointsDiscountToUser)
                                .AddOptionalParameter("endpoints.openrouter.slug", endpointsOpenrouterSlug)
                                .AddOptionalParameter("endpoints.datacenters.country_code", endpointsDatacentersCountryCode)
                                .AddOptionalParameter("endpoints.datacenters.region", endpointsDatacentersRegion)
                                .AddOptionalParameter("endpoints.deployment_region", endpointsDeploymentRegion)
                                .AddOptionalParameter("endpoints.inputs.type", endpointsInputsType)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.type", endpointsInputsTextPricingType)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.prompt.unit", endpointsInputsTextPricingPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.prompt.cost_usd", endpointsInputsTextPricingPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.prompt.overrides.cost_usd", endpointsInputsTextPricingPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.prompt.utc_start", endpointsInputsTextPricingPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.prompt.utc_end", endpointsInputsTextPricingPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.prompt.utc_days", endpointsInputsTextPricingPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.unit", endpointsInputsTextPricingCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.cost_usd", endpointsInputsTextPricingCachedPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.overrides.cost_usd", endpointsInputsTextPricingCachedPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.ttl_seconds", endpointsInputsTextPricingCachedPromptTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.implicit", endpointsInputsTextPricingCachedPromptImplicit)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.utc_start", endpointsInputsTextPricingCachedPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.utc_end", endpointsInputsTextPricingCachedPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cached_prompt.utc_days", endpointsInputsTextPricingCachedPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.unit", endpointsInputsTextPricingCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.cost_usd", endpointsInputsTextPricingCacheWriteCostUsd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.overrides.cost_usd", endpointsInputsTextPricingCacheWriteOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.ttl_seconds", endpointsInputsTextPricingCacheWriteTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.implicit", endpointsInputsTextPricingCacheWriteImplicit)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.utc_start", endpointsInputsTextPricingCacheWriteUtcStart)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.utc_end", endpointsInputsTextPricingCacheWriteUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.text.pricing.cache_write.utc_days", endpointsInputsTextPricingCacheWriteUtcDays)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.type", endpointsInputsTextCapacityType)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.prompt.unit", endpointsInputsTextCapacityPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.prompt.per", endpointsInputsTextCapacityPromptPer)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.prompt.value", endpointsInputsTextCapacityPromptValue)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.cached_prompt.unit", endpointsInputsTextCapacityCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.cached_prompt.per", endpointsInputsTextCapacityCachedPromptPer)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.cached_prompt.value", endpointsInputsTextCapacityCachedPromptValue)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.cache_write.unit", endpointsInputsTextCapacityCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.cache_write.per", endpointsInputsTextCapacityCacheWritePer)
                                .AddOptionalParameter("endpoints.inputs.text.capacity.cache_write.value", endpointsInputsTextCapacityCacheWriteValue)
                                .AddOptionalParameter("endpoints.inputs.text.passthrough_parameters", endpointsInputsTextPassthroughParameters)
                                .AddOptionalParameter("endpoints.inputs.text.params.max_prompt_length.value", endpointsInputsTextParamsMaxPromptLengthValue)
                                .AddOptionalParameter("endpoints.inputs.text.params.max_prompt_length.unit", endpointsInputsTextParamsMaxPromptLengthUnit)
                                .AddOptionalParameter("endpoints.inputs.text.params.max_length.value", endpointsInputsTextParamsMaxLengthValue)
                                .AddOptionalParameter("endpoints.inputs.text.params.max_length.unit", endpointsInputsTextParamsMaxLengthUnit)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.type", endpointsInputsImagePricingType)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.prompt.unit", endpointsInputsImagePricingPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.prompt.cost_usd", endpointsInputsImagePricingPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.prompt.overrides.cost_usd", endpointsInputsImagePricingPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.prompt.utc_start", endpointsInputsImagePricingPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.prompt.utc_end", endpointsInputsImagePricingPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.prompt.utc_days", endpointsInputsImagePricingPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.unit", endpointsInputsImagePricingCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.cost_usd", endpointsInputsImagePricingCachedPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.overrides.cost_usd", endpointsInputsImagePricingCachedPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.ttl_seconds", endpointsInputsImagePricingCachedPromptTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.implicit", endpointsInputsImagePricingCachedPromptImplicit)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.utc_start", endpointsInputsImagePricingCachedPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.utc_end", endpointsInputsImagePricingCachedPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cached_prompt.utc_days", endpointsInputsImagePricingCachedPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.unit", endpointsInputsImagePricingCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.cost_usd", endpointsInputsImagePricingCacheWriteCostUsd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.overrides.cost_usd", endpointsInputsImagePricingCacheWriteOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.ttl_seconds", endpointsInputsImagePricingCacheWriteTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.implicit", endpointsInputsImagePricingCacheWriteImplicit)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.utc_start", endpointsInputsImagePricingCacheWriteUtcStart)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.utc_end", endpointsInputsImagePricingCacheWriteUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.image.pricing.cache_write.utc_days", endpointsInputsImagePricingCacheWriteUtcDays)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.type", endpointsInputsImageCapacityType)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.prompt.unit", endpointsInputsImageCapacityPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.prompt.per", endpointsInputsImageCapacityPromptPer)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.prompt.value", endpointsInputsImageCapacityPromptValue)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.cached_prompt.unit", endpointsInputsImageCapacityCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.cached_prompt.per", endpointsInputsImageCapacityCachedPromptPer)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.cached_prompt.value", endpointsInputsImageCapacityCachedPromptValue)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.cache_write.unit", endpointsInputsImageCapacityCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.cache_write.per", endpointsInputsImageCapacityCacheWritePer)
                                .AddOptionalParameter("endpoints.inputs.image.capacity.cache_write.value", endpointsInputsImageCapacityCacheWriteValue)
                                .AddOptionalParameter("endpoints.inputs.image.passthrough_parameters", endpointsInputsImagePassthroughParameters)
                                .AddOptionalParameter("endpoints.inputs.image.params.sources.type", endpointsInputsImageParamsSourcesType)
                                .AddOptionalParameter("endpoints.inputs.image.params.sources.values", endpointsInputsImageParamsSourcesValues)
                                .AddOptionalParameter("endpoints.inputs.image.params.formats.type", endpointsInputsImageParamsFormatsType)
                                .AddOptionalParameter("endpoints.inputs.image.params.formats.values", endpointsInputsImageParamsFormatsValues)
                                .AddOptionalParameter("endpoints.inputs.image.params.detail_levels.type", endpointsInputsImageParamsDetailLevelsType)
                                .AddOptionalParameter("endpoints.inputs.image.params.detail_levels.values", endpointsInputsImageParamsDetailLevelsValues)
                                .AddOptionalParameter("endpoints.inputs.image.params.references.type", endpointsInputsImageParamsReferencesType)
                                .AddOptionalParameter("endpoints.inputs.image.params.references.min", endpointsInputsImageParamsReferencesMin)
                                .AddOptionalParameter("endpoints.inputs.image.params.references.max", endpointsInputsImageParamsReferencesMax)
                                .AddOptionalParameter("endpoints.inputs.image.params.references.unit", endpointsInputsImageParamsReferencesUnit)
                                .AddOptionalParameter("endpoints.inputs.image.params.role.type", endpointsInputsImageParamsRoleType)
                                .AddOptionalParameter("endpoints.inputs.image.params.role.values", endpointsInputsImageParamsRoleValues)
                                .AddOptionalParameter("endpoints.inputs.image.params.max_content_size_bytes.value", endpointsInputsImageParamsMaxContentSizeBytesValue)
                                .AddOptionalParameter("endpoints.inputs.image.params.max_content_size_bytes.unit", endpointsInputsImageParamsMaxContentSizeBytesUnit)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.type", endpointsInputsVideoPricingType)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.prompt.unit", endpointsInputsVideoPricingPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.prompt.cost_usd", endpointsInputsVideoPricingPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.prompt.overrides.cost_usd", endpointsInputsVideoPricingPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.prompt.utc_start", endpointsInputsVideoPricingPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.prompt.utc_end", endpointsInputsVideoPricingPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.prompt.utc_days", endpointsInputsVideoPricingPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.unit", endpointsInputsVideoPricingCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.cost_usd", endpointsInputsVideoPricingCachedPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.overrides.cost_usd", endpointsInputsVideoPricingCachedPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.ttl_seconds", endpointsInputsVideoPricingCachedPromptTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.implicit", endpointsInputsVideoPricingCachedPromptImplicit)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.utc_start", endpointsInputsVideoPricingCachedPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.utc_end", endpointsInputsVideoPricingCachedPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cached_prompt.utc_days", endpointsInputsVideoPricingCachedPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.unit", endpointsInputsVideoPricingCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.cost_usd", endpointsInputsVideoPricingCacheWriteCostUsd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.overrides.cost_usd", endpointsInputsVideoPricingCacheWriteOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.ttl_seconds", endpointsInputsVideoPricingCacheWriteTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.implicit", endpointsInputsVideoPricingCacheWriteImplicit)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.utc_start", endpointsInputsVideoPricingCacheWriteUtcStart)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.utc_end", endpointsInputsVideoPricingCacheWriteUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.video.pricing.cache_write.utc_days", endpointsInputsVideoPricingCacheWriteUtcDays)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.type", endpointsInputsVideoCapacityType)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.prompt.unit", endpointsInputsVideoCapacityPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.prompt.per", endpointsInputsVideoCapacityPromptPer)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.prompt.value", endpointsInputsVideoCapacityPromptValue)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.cached_prompt.unit", endpointsInputsVideoCapacityCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.cached_prompt.per", endpointsInputsVideoCapacityCachedPromptPer)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.cached_prompt.value", endpointsInputsVideoCapacityCachedPromptValue)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.cache_write.unit", endpointsInputsVideoCapacityCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.cache_write.per", endpointsInputsVideoCapacityCacheWritePer)
                                .AddOptionalParameter("endpoints.inputs.video.capacity.cache_write.value", endpointsInputsVideoCapacityCacheWriteValue)
                                .AddOptionalParameter("endpoints.inputs.video.passthrough_parameters", endpointsInputsVideoPassthroughParameters)
                                .AddOptionalParameter("endpoints.inputs.video.params.sources.type", endpointsInputsVideoParamsSourcesType)
                                .AddOptionalParameter("endpoints.inputs.video.params.sources.values", endpointsInputsVideoParamsSourcesValues)
                                .AddOptionalParameter("endpoints.inputs.video.params.formats.type", endpointsInputsVideoParamsFormatsType)
                                .AddOptionalParameter("endpoints.inputs.video.params.formats.values", endpointsInputsVideoParamsFormatsValues)
                                .AddOptionalParameter("endpoints.inputs.video.params.max_duration_seconds.value", endpointsInputsVideoParamsMaxDurationSecondsValue)
                                .AddOptionalParameter("endpoints.inputs.video.params.max_duration_seconds.unit", endpointsInputsVideoParamsMaxDurationSecondsUnit)
                                .AddOptionalParameter("endpoints.inputs.video.params.max_content_size_bytes.value", endpointsInputsVideoParamsMaxContentSizeBytesValue)
                                .AddOptionalParameter("endpoints.inputs.video.params.max_content_size_bytes.unit", endpointsInputsVideoParamsMaxContentSizeBytesUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.type", endpointsInputsAudioPricingType)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.prompt.unit", endpointsInputsAudioPricingPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.prompt.cost_usd", endpointsInputsAudioPricingPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.prompt.overrides.cost_usd", endpointsInputsAudioPricingPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.prompt.utc_start", endpointsInputsAudioPricingPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.prompt.utc_end", endpointsInputsAudioPricingPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.prompt.utc_days", endpointsInputsAudioPricingPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.unit", endpointsInputsAudioPricingCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.cost_usd", endpointsInputsAudioPricingCachedPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.overrides.cost_usd", endpointsInputsAudioPricingCachedPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.ttl_seconds", endpointsInputsAudioPricingCachedPromptTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.implicit", endpointsInputsAudioPricingCachedPromptImplicit)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.utc_start", endpointsInputsAudioPricingCachedPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.utc_end", endpointsInputsAudioPricingCachedPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cached_prompt.utc_days", endpointsInputsAudioPricingCachedPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.unit", endpointsInputsAudioPricingCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.cost_usd", endpointsInputsAudioPricingCacheWriteCostUsd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.overrides.cost_usd", endpointsInputsAudioPricingCacheWriteOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.ttl_seconds", endpointsInputsAudioPricingCacheWriteTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.implicit", endpointsInputsAudioPricingCacheWriteImplicit)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.utc_start", endpointsInputsAudioPricingCacheWriteUtcStart)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.utc_end", endpointsInputsAudioPricingCacheWriteUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.audio.pricing.cache_write.utc_days", endpointsInputsAudioPricingCacheWriteUtcDays)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.type", endpointsInputsAudioCapacityType)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.prompt.unit", endpointsInputsAudioCapacityPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.prompt.per", endpointsInputsAudioCapacityPromptPer)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.prompt.value", endpointsInputsAudioCapacityPromptValue)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.cached_prompt.unit", endpointsInputsAudioCapacityCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.cached_prompt.per", endpointsInputsAudioCapacityCachedPromptPer)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.cached_prompt.value", endpointsInputsAudioCapacityCachedPromptValue)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.cache_write.unit", endpointsInputsAudioCapacityCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.cache_write.per", endpointsInputsAudioCapacityCacheWritePer)
                                .AddOptionalParameter("endpoints.inputs.audio.capacity.cache_write.value", endpointsInputsAudioCapacityCacheWriteValue)
                                .AddOptionalParameter("endpoints.inputs.audio.passthrough_parameters", endpointsInputsAudioPassthroughParameters)
                                .AddOptionalParameter("endpoints.inputs.audio.params.sources.type", endpointsInputsAudioParamsSourcesType)
                                .AddOptionalParameter("endpoints.inputs.audio.params.sources.values", endpointsInputsAudioParamsSourcesValues)
                                .AddOptionalParameter("endpoints.inputs.audio.params.formats.type", endpointsInputsAudioParamsFormatsType)
                                .AddOptionalParameter("endpoints.inputs.audio.params.formats.values", endpointsInputsAudioParamsFormatsValues)
                                .AddOptionalParameter("endpoints.inputs.audio.params.max_duration_seconds.value", endpointsInputsAudioParamsMaxDurationSecondsValue)
                                .AddOptionalParameter("endpoints.inputs.audio.params.max_duration_seconds.unit", endpointsInputsAudioParamsMaxDurationSecondsUnit)
                                .AddOptionalParameter("endpoints.inputs.audio.params.max_content_size_bytes.value", endpointsInputsAudioParamsMaxContentSizeBytesValue)
                                .AddOptionalParameter("endpoints.inputs.audio.params.max_content_size_bytes.unit", endpointsInputsAudioParamsMaxContentSizeBytesUnit)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.type", endpointsInputsFilePricingType)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.prompt.unit", endpointsInputsFilePricingPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.prompt.cost_usd", endpointsInputsFilePricingPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.prompt.overrides.cost_usd", endpointsInputsFilePricingPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.prompt.utc_start", endpointsInputsFilePricingPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.prompt.utc_end", endpointsInputsFilePricingPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.prompt.utc_days", endpointsInputsFilePricingPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.unit", endpointsInputsFilePricingCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.cost_usd", endpointsInputsFilePricingCachedPromptCostUsd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.overrides.cost_usd", endpointsInputsFilePricingCachedPromptOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.ttl_seconds", endpointsInputsFilePricingCachedPromptTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.implicit", endpointsInputsFilePricingCachedPromptImplicit)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.utc_start", endpointsInputsFilePricingCachedPromptUtcStart)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.utc_end", endpointsInputsFilePricingCachedPromptUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cached_prompt.utc_days", endpointsInputsFilePricingCachedPromptUtcDays)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.unit", endpointsInputsFilePricingCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.cost_usd", endpointsInputsFilePricingCacheWriteCostUsd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.overrides.cost_usd", endpointsInputsFilePricingCacheWriteOverridesCostUsd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.ttl_seconds", endpointsInputsFilePricingCacheWriteTtlSeconds)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.implicit", endpointsInputsFilePricingCacheWriteImplicit)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.utc_start", endpointsInputsFilePricingCacheWriteUtcStart)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.utc_end", endpointsInputsFilePricingCacheWriteUtcEnd)
                                .AddOptionalParameter("endpoints.inputs.file.pricing.cache_write.utc_days", endpointsInputsFilePricingCacheWriteUtcDays)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.type", endpointsInputsFileCapacityType)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.prompt.unit", endpointsInputsFileCapacityPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.prompt.per", endpointsInputsFileCapacityPromptPer)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.prompt.value", endpointsInputsFileCapacityPromptValue)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.cached_prompt.unit", endpointsInputsFileCapacityCachedPromptUnit)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.cached_prompt.per", endpointsInputsFileCapacityCachedPromptPer)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.cached_prompt.value", endpointsInputsFileCapacityCachedPromptValue)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.cache_write.unit", endpointsInputsFileCapacityCacheWriteUnit)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.cache_write.per", endpointsInputsFileCapacityCacheWritePer)
                                .AddOptionalParameter("endpoints.inputs.file.capacity.cache_write.value", endpointsInputsFileCapacityCacheWriteValue)
                                .AddOptionalParameter("endpoints.inputs.file.passthrough_parameters", endpointsInputsFilePassthroughParameters)
                                .AddOptionalParameter("endpoints.inputs.file.params.sources.type", endpointsInputsFileParamsSourcesType)
                                .AddOptionalParameter("endpoints.inputs.file.params.sources.values", endpointsInputsFileParamsSourcesValues)
                                .AddOptionalParameter("endpoints.inputs.file.params.formats.type", endpointsInputsFileParamsFormatsType)
                                .AddOptionalParameter("endpoints.inputs.file.params.formats.values", endpointsInputsFileParamsFormatsValues)
                                .AddOptionalParameter("endpoints.inputs.file.params.references.type", endpointsInputsFileParamsReferencesType)
                                .AddOptionalParameter("endpoints.inputs.file.params.references.min", endpointsInputsFileParamsReferencesMin)
                                .AddOptionalParameter("endpoints.inputs.file.params.references.max", endpointsInputsFileParamsReferencesMax)
                                .AddOptionalParameter("endpoints.inputs.file.params.references.unit", endpointsInputsFileParamsReferencesUnit)
                                .AddOptionalParameter("endpoints.inputs.file.params.max_content_size_bytes.value", endpointsInputsFileParamsMaxContentSizeBytesValue)
                                .AddOptionalParameter("endpoints.inputs.file.params.max_content_size_bytes.unit", endpointsInputsFileParamsMaxContentSizeBytesUnit)
                                .AddOptionalParameter("endpoints.outputs.type", endpointsOutputsType)
                                .AddOptionalParameter("endpoints.outputs.text.max_length.value", endpointsOutputsTextMaxLengthValue)
                                .AddOptionalParameter("endpoints.outputs.text.max_length.unit", endpointsOutputsTextMaxLengthUnit)
                                .AddOptionalParameter("endpoints.outputs.text.passthrough_parameters", endpointsOutputsTextPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.type", endpointsOutputsTextPricingType)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.completion.unit", endpointsOutputsTextPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.completion.cost_usd", endpointsOutputsTextPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.completion.overrides.cost_usd", endpointsOutputsTextPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.completion.utc_start", endpointsOutputsTextPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.completion.utc_end", endpointsOutputsTextPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.completion.utc_days", endpointsOutputsTextPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.internal_reasoning.unit", endpointsOutputsTextPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.internal_reasoning.cost_usd", endpointsOutputsTextPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsTextPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.internal_reasoning.utc_start", endpointsOutputsTextPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.internal_reasoning.utc_end", endpointsOutputsTextPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.text.pricing.internal_reasoning.utc_days", endpointsOutputsTextPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.type", endpointsOutputsTextCapacityType)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.completion.unit", endpointsOutputsTextCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.completion.per", endpointsOutputsTextCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.completion.value", endpointsOutputsTextCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.internal_reasoning.unit", endpointsOutputsTextCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.internal_reasoning.per", endpointsOutputsTextCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.internal_reasoning.value", endpointsOutputsTextCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.concurrency.unit", endpointsOutputsTextCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.text.capacity.concurrency.value", endpointsOutputsTextCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.text.streaming", endpointsOutputsTextStreaming)
                                .AddOptionalParameter("endpoints.outputs.text.params", endpointsOutputsTextParams)
                                .AddOptionalParameter("endpoints.outputs.image.passthrough_parameters", endpointsOutputsImagePassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.type", endpointsOutputsImagePricingType)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.completion.unit", endpointsOutputsImagePricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.completion.cost_usd", endpointsOutputsImagePricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.completion.overrides.cost_usd", endpointsOutputsImagePricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.completion.utc_start", endpointsOutputsImagePricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.completion.utc_end", endpointsOutputsImagePricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.completion.utc_days", endpointsOutputsImagePricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.internal_reasoning.unit", endpointsOutputsImagePricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.internal_reasoning.cost_usd", endpointsOutputsImagePricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsImagePricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.internal_reasoning.utc_start", endpointsOutputsImagePricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.internal_reasoning.utc_end", endpointsOutputsImagePricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.image.pricing.internal_reasoning.utc_days", endpointsOutputsImagePricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.type", endpointsOutputsImageCapacityType)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.completion.unit", endpointsOutputsImageCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.completion.per", endpointsOutputsImageCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.completion.value", endpointsOutputsImageCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.internal_reasoning.unit", endpointsOutputsImageCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.internal_reasoning.per", endpointsOutputsImageCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.internal_reasoning.value", endpointsOutputsImageCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.concurrency.unit", endpointsOutputsImageCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.image.capacity.concurrency.value", endpointsOutputsImageCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.image.streaming", endpointsOutputsImageStreaming)
                                .AddOptionalParameter("endpoints.outputs.image.params", endpointsOutputsImageParams)
                                .AddOptionalParameter("endpoints.outputs.video.passthrough_parameters", endpointsOutputsVideoPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.type", endpointsOutputsVideoPricingType)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.completion.unit", endpointsOutputsVideoPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.completion.cost_usd", endpointsOutputsVideoPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.completion.overrides.cost_usd", endpointsOutputsVideoPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.completion.utc_start", endpointsOutputsVideoPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.completion.utc_end", endpointsOutputsVideoPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.completion.utc_days", endpointsOutputsVideoPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.internal_reasoning.unit", endpointsOutputsVideoPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.internal_reasoning.cost_usd", endpointsOutputsVideoPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.internal_reasoning.utc_start", endpointsOutputsVideoPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.internal_reasoning.utc_end", endpointsOutputsVideoPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.video.pricing.internal_reasoning.utc_days", endpointsOutputsVideoPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.type", endpointsOutputsVideoCapacityType)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.completion.unit", endpointsOutputsVideoCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.completion.per", endpointsOutputsVideoCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.completion.value", endpointsOutputsVideoCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.internal_reasoning.unit", endpointsOutputsVideoCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.internal_reasoning.per", endpointsOutputsVideoCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.internal_reasoning.value", endpointsOutputsVideoCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.concurrency.unit", endpointsOutputsVideoCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.video.capacity.concurrency.value", endpointsOutputsVideoCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.video.streaming", endpointsOutputsVideoStreaming)
                                .AddOptionalParameter("endpoints.outputs.video.params", endpointsOutputsVideoParams)
                                .AddOptionalParameter("endpoints.outputs.speech.passthrough_parameters", endpointsOutputsSpeechPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.type", endpointsOutputsSpeechPricingType)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.completion.unit", endpointsOutputsSpeechPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.completion.cost_usd", endpointsOutputsSpeechPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.completion.overrides.cost_usd", endpointsOutputsSpeechPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.completion.utc_start", endpointsOutputsSpeechPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.completion.utc_end", endpointsOutputsSpeechPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.completion.utc_days", endpointsOutputsSpeechPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.internal_reasoning.unit", endpointsOutputsSpeechPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.internal_reasoning.cost_usd", endpointsOutputsSpeechPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.internal_reasoning.utc_start", endpointsOutputsSpeechPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.internal_reasoning.utc_end", endpointsOutputsSpeechPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.speech.pricing.internal_reasoning.utc_days", endpointsOutputsSpeechPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.type", endpointsOutputsSpeechCapacityType)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.completion.unit", endpointsOutputsSpeechCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.completion.per", endpointsOutputsSpeechCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.completion.value", endpointsOutputsSpeechCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.internal_reasoning.unit", endpointsOutputsSpeechCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.internal_reasoning.per", endpointsOutputsSpeechCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.internal_reasoning.value", endpointsOutputsSpeechCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.concurrency.unit", endpointsOutputsSpeechCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.speech.capacity.concurrency.value", endpointsOutputsSpeechCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.speech.streaming", endpointsOutputsSpeechStreaming)
                                .AddOptionalParameter("endpoints.outputs.speech.params", endpointsOutputsSpeechParams)
                                .AddOptionalParameter("endpoints.outputs.transcription.passthrough_parameters", endpointsOutputsTranscriptionPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.type", endpointsOutputsTranscriptionPricingType)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.completion.unit", endpointsOutputsTranscriptionPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.completion.cost_usd", endpointsOutputsTranscriptionPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.completion.overrides.cost_usd", endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.completion.utc_start", endpointsOutputsTranscriptionPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.completion.utc_end", endpointsOutputsTranscriptionPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.completion.utc_days", endpointsOutputsTranscriptionPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.internal_reasoning.unit", endpointsOutputsTranscriptionPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.internal_reasoning.cost_usd", endpointsOutputsTranscriptionPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.internal_reasoning.utc_start", endpointsOutputsTranscriptionPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.internal_reasoning.utc_end", endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.transcription.pricing.internal_reasoning.utc_days", endpointsOutputsTranscriptionPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.type", endpointsOutputsTranscriptionCapacityType)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.completion.unit", endpointsOutputsTranscriptionCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.completion.per", endpointsOutputsTranscriptionCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.completion.value", endpointsOutputsTranscriptionCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.internal_reasoning.unit", endpointsOutputsTranscriptionCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.internal_reasoning.per", endpointsOutputsTranscriptionCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.internal_reasoning.value", endpointsOutputsTranscriptionCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.concurrency.unit", endpointsOutputsTranscriptionCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.transcription.capacity.concurrency.value", endpointsOutputsTranscriptionCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.transcription.streaming", endpointsOutputsTranscriptionStreaming)
                                .AddOptionalParameter("endpoints.outputs.transcription.params", endpointsOutputsTranscriptionParams)
                                .AddOptionalParameter("endpoints.outputs.embeddings.passthrough_parameters", endpointsOutputsEmbeddingsPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.type", endpointsOutputsEmbeddingsPricingType)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.completion.unit", endpointsOutputsEmbeddingsPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.completion.cost_usd", endpointsOutputsEmbeddingsPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.completion.overrides.cost_usd", endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.completion.utc_start", endpointsOutputsEmbeddingsPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.completion.utc_end", endpointsOutputsEmbeddingsPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.completion.utc_days", endpointsOutputsEmbeddingsPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.internal_reasoning.unit", endpointsOutputsEmbeddingsPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.internal_reasoning.cost_usd", endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.internal_reasoning.utc_start", endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.internal_reasoning.utc_end", endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.embeddings.pricing.internal_reasoning.utc_days", endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.type", endpointsOutputsEmbeddingsCapacityType)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.completion.unit", endpointsOutputsEmbeddingsCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.completion.per", endpointsOutputsEmbeddingsCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.completion.value", endpointsOutputsEmbeddingsCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.internal_reasoning.unit", endpointsOutputsEmbeddingsCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.internal_reasoning.per", endpointsOutputsEmbeddingsCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.internal_reasoning.value", endpointsOutputsEmbeddingsCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.concurrency.unit", endpointsOutputsEmbeddingsCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.embeddings.capacity.concurrency.value", endpointsOutputsEmbeddingsCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.embeddings.params", endpointsOutputsEmbeddingsParams)
                                .AddOptionalParameter("endpoints.outputs.rerank.passthrough_parameters", endpointsOutputsRerankPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.type", endpointsOutputsRerankPricingType)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.completion.unit", endpointsOutputsRerankPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.completion.cost_usd", endpointsOutputsRerankPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.completion.overrides.cost_usd", endpointsOutputsRerankPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.completion.utc_start", endpointsOutputsRerankPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.completion.utc_end", endpointsOutputsRerankPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.completion.utc_days", endpointsOutputsRerankPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.internal_reasoning.unit", endpointsOutputsRerankPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.internal_reasoning.cost_usd", endpointsOutputsRerankPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.internal_reasoning.utc_start", endpointsOutputsRerankPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.internal_reasoning.utc_end", endpointsOutputsRerankPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.rerank.pricing.internal_reasoning.utc_days", endpointsOutputsRerankPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.type", endpointsOutputsRerankCapacityType)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.completion.unit", endpointsOutputsRerankCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.completion.per", endpointsOutputsRerankCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.completion.value", endpointsOutputsRerankCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.internal_reasoning.unit", endpointsOutputsRerankCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.internal_reasoning.per", endpointsOutputsRerankCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.internal_reasoning.value", endpointsOutputsRerankCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.concurrency.unit", endpointsOutputsRerankCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.rerank.capacity.concurrency.value", endpointsOutputsRerankCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.rerank.params", endpointsOutputsRerankParams)
                                .AddOptionalParameter("endpoints.outputs.decisions.passthrough_parameters", endpointsOutputsDecisionsPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.type", endpointsOutputsDecisionsPricingType)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.completion.unit", endpointsOutputsDecisionsPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.completion.cost_usd", endpointsOutputsDecisionsPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.completion.overrides.cost_usd", endpointsOutputsDecisionsPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.completion.utc_start", endpointsOutputsDecisionsPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.completion.utc_end", endpointsOutputsDecisionsPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.completion.utc_days", endpointsOutputsDecisionsPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.internal_reasoning.unit", endpointsOutputsDecisionsPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.internal_reasoning.cost_usd", endpointsOutputsDecisionsPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.internal_reasoning.utc_start", endpointsOutputsDecisionsPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.internal_reasoning.utc_end", endpointsOutputsDecisionsPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.decisions.pricing.internal_reasoning.utc_days", endpointsOutputsDecisionsPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.type", endpointsOutputsDecisionsCapacityType)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.completion.unit", endpointsOutputsDecisionsCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.completion.per", endpointsOutputsDecisionsCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.completion.value", endpointsOutputsDecisionsCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.internal_reasoning.unit", endpointsOutputsDecisionsCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.internal_reasoning.per", endpointsOutputsDecisionsCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.internal_reasoning.value", endpointsOutputsDecisionsCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.concurrency.unit", endpointsOutputsDecisionsCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.decisions.capacity.concurrency.value", endpointsOutputsDecisionsCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.decisions.params", endpointsOutputsDecisionsParams)
                                .AddOptionalParameter("endpoints.outputs.audio.passthrough_parameters", endpointsOutputsAudioPassthroughParameters)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.type", endpointsOutputsAudioPricingType)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.completion.unit", endpointsOutputsAudioPricingCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.completion.cost_usd", endpointsOutputsAudioPricingCompletionCostUsd)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.completion.overrides.cost_usd", endpointsOutputsAudioPricingCompletionOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.completion.utc_start", endpointsOutputsAudioPricingCompletionUtcStart)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.completion.utc_end", endpointsOutputsAudioPricingCompletionUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.completion.utc_days", endpointsOutputsAudioPricingCompletionUtcDays)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.internal_reasoning.unit", endpointsOutputsAudioPricingInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.internal_reasoning.cost_usd", endpointsOutputsAudioPricingInternalReasoningCostUsd)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.internal_reasoning.overrides.cost_usd", endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.internal_reasoning.utc_start", endpointsOutputsAudioPricingInternalReasoningUtcStart)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.internal_reasoning.utc_end", endpointsOutputsAudioPricingInternalReasoningUtcEnd)
                                .AddOptionalParameter("endpoints.outputs.audio.pricing.internal_reasoning.utc_days", endpointsOutputsAudioPricingInternalReasoningUtcDays)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.type", endpointsOutputsAudioCapacityType)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.completion.unit", endpointsOutputsAudioCapacityCompletionUnit)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.completion.per", endpointsOutputsAudioCapacityCompletionPer)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.completion.value", endpointsOutputsAudioCapacityCompletionValue)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.internal_reasoning.unit", endpointsOutputsAudioCapacityInternalReasoningUnit)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.internal_reasoning.per", endpointsOutputsAudioCapacityInternalReasoningPer)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.internal_reasoning.value", endpointsOutputsAudioCapacityInternalReasoningValue)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.concurrency.unit", endpointsOutputsAudioCapacityConcurrencyUnit)
                                .AddOptionalParameter("endpoints.outputs.audio.capacity.concurrency.value", endpointsOutputsAudioCapacityConcurrencyValue)
                                .AddOptionalParameter("endpoints.outputs.audio.streaming", endpointsOutputsAudioStreaming)
                                .AddOptionalParameter("endpoints.outputs.audio.params", endpointsOutputsAudioParams)
                                .AddOptionalParameter("endpoints.provider.slug", endpointsProviderSlug)
                                .AddOptionalParameter("endpoints.provider.tag", endpointsProviderTag)
                                .AddOptionalParameter("endpoints.provider.name", endpointsProviderName)
                                .AddOptionalParameter("endpoints.data_policy.training", endpointsDataPolicyTraining)
                                .AddOptionalParameter("endpoints.data_policy.retains_prompts", endpointsDataPolicyRetainsPrompts)
                                .AddOptionalParameter("endpoints.data_policy.retention_days", endpointsDataPolicyRetentionDays)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::OpenRouter.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                global::OpenRouter.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListV2Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    offset: offset,
                    limit: limit,
                    cursor: cursor,
                    region: region,
                    sort: sort,
                    id: id,
                    canonicalSlug: canonicalSlug,
                    author: author,
                    name: name,
                    variant: variant,
                    kind: kind,
                    aliasTargetSlug: aliasTargetSlug,
                    aliasTargetName: aliasTargetName,
                    created: created,
                    description: description,
                    contextLength: contextLength,
                    huggingFaceId: huggingFaceId,
                    inputs: inputs,
                    outputs: outputs,
                    endpointsSchemaVersion: endpointsSchemaVersion,
                    endpointsId: endpointsId,
                    endpointsHuggingFaceId: endpointsHuggingFaceId,
                    endpointsName: endpointsName,
                    endpointsCreated: endpointsCreated,
                    endpointsQuantization: endpointsQuantization,
                    endpointsTokenizer: endpointsTokenizer,
                    endpointsDescription: endpointsDescription,
                    endpointsPricingType: endpointsPricingType,
                    endpointsPricingRequestUnit: endpointsPricingRequestUnit,
                    endpointsPricingRequestCostUsd: endpointsPricingRequestCostUsd,
                    endpointsPricingRequestOverridesCostUsd: endpointsPricingRequestOverridesCostUsd,
                    endpointsPricingWebSearchUnit: endpointsPricingWebSearchUnit,
                    endpointsPricingWebSearchCostUsd: endpointsPricingWebSearchCostUsd,
                    endpointsPricingWebSearchOverridesCostUsd: endpointsPricingWebSearchOverridesCostUsd,
                    endpointsCapacityType: endpointsCapacityType,
                    endpointsCapacityRequestUnit: endpointsCapacityRequestUnit,
                    endpointsCapacityRequestPer: endpointsCapacityRequestPer,
                    endpointsCapacityRequestValue: endpointsCapacityRequestValue,
                    endpointsCapacityWebSearchUnit: endpointsCapacityWebSearchUnit,
                    endpointsCapacityWebSearchPer: endpointsCapacityWebSearchPer,
                    endpointsCapacityWebSearchValue: endpointsCapacityWebSearchValue,
                    endpointsCapacityConcurrencyUnit: endpointsCapacityConcurrencyUnit,
                    endpointsCapacityConcurrencyValue: endpointsCapacityConcurrencyValue,
                    endpointsPassthroughParameters: endpointsPassthroughParameters,
                    endpointsDeprecationDate: endpointsDeprecationDate,
                    endpointsIsReady: endpointsIsReady,
                    endpointsIsFree: endpointsIsFree,
                    endpointsServiceTier: endpointsServiceTier,
                    endpointsDiscountToUser: endpointsDiscountToUser,
                    endpointsOpenrouterSlug: endpointsOpenrouterSlug,
                    endpointsDatacentersCountryCode: endpointsDatacentersCountryCode,
                    endpointsDatacentersRegion: endpointsDatacentersRegion,
                    endpointsDeploymentRegion: endpointsDeploymentRegion,
                    endpointsInputsType: endpointsInputsType,
                    endpointsInputsTextPricingType: endpointsInputsTextPricingType,
                    endpointsInputsTextPricingPromptUnit: endpointsInputsTextPricingPromptUnit,
                    endpointsInputsTextPricingPromptCostUsd: endpointsInputsTextPricingPromptCostUsd,
                    endpointsInputsTextPricingPromptOverridesCostUsd: endpointsInputsTextPricingPromptOverridesCostUsd,
                    endpointsInputsTextPricingPromptUtcStart: endpointsInputsTextPricingPromptUtcStart,
                    endpointsInputsTextPricingPromptUtcEnd: endpointsInputsTextPricingPromptUtcEnd,
                    endpointsInputsTextPricingPromptUtcDays: endpointsInputsTextPricingPromptUtcDays,
                    endpointsInputsTextPricingCachedPromptUnit: endpointsInputsTextPricingCachedPromptUnit,
                    endpointsInputsTextPricingCachedPromptCostUsd: endpointsInputsTextPricingCachedPromptCostUsd,
                    endpointsInputsTextPricingCachedPromptOverridesCostUsd: endpointsInputsTextPricingCachedPromptOverridesCostUsd,
                    endpointsInputsTextPricingCachedPromptTtlSeconds: endpointsInputsTextPricingCachedPromptTtlSeconds,
                    endpointsInputsTextPricingCachedPromptImplicit: endpointsInputsTextPricingCachedPromptImplicit,
                    endpointsInputsTextPricingCachedPromptUtcStart: endpointsInputsTextPricingCachedPromptUtcStart,
                    endpointsInputsTextPricingCachedPromptUtcEnd: endpointsInputsTextPricingCachedPromptUtcEnd,
                    endpointsInputsTextPricingCachedPromptUtcDays: endpointsInputsTextPricingCachedPromptUtcDays,
                    endpointsInputsTextPricingCacheWriteUnit: endpointsInputsTextPricingCacheWriteUnit,
                    endpointsInputsTextPricingCacheWriteCostUsd: endpointsInputsTextPricingCacheWriteCostUsd,
                    endpointsInputsTextPricingCacheWriteOverridesCostUsd: endpointsInputsTextPricingCacheWriteOverridesCostUsd,
                    endpointsInputsTextPricingCacheWriteTtlSeconds: endpointsInputsTextPricingCacheWriteTtlSeconds,
                    endpointsInputsTextPricingCacheWriteImplicit: endpointsInputsTextPricingCacheWriteImplicit,
                    endpointsInputsTextPricingCacheWriteUtcStart: endpointsInputsTextPricingCacheWriteUtcStart,
                    endpointsInputsTextPricingCacheWriteUtcEnd: endpointsInputsTextPricingCacheWriteUtcEnd,
                    endpointsInputsTextPricingCacheWriteUtcDays: endpointsInputsTextPricingCacheWriteUtcDays,
                    endpointsInputsTextCapacityType: endpointsInputsTextCapacityType,
                    endpointsInputsTextCapacityPromptUnit: endpointsInputsTextCapacityPromptUnit,
                    endpointsInputsTextCapacityPromptPer: endpointsInputsTextCapacityPromptPer,
                    endpointsInputsTextCapacityPromptValue: endpointsInputsTextCapacityPromptValue,
                    endpointsInputsTextCapacityCachedPromptUnit: endpointsInputsTextCapacityCachedPromptUnit,
                    endpointsInputsTextCapacityCachedPromptPer: endpointsInputsTextCapacityCachedPromptPer,
                    endpointsInputsTextCapacityCachedPromptValue: endpointsInputsTextCapacityCachedPromptValue,
                    endpointsInputsTextCapacityCacheWriteUnit: endpointsInputsTextCapacityCacheWriteUnit,
                    endpointsInputsTextCapacityCacheWritePer: endpointsInputsTextCapacityCacheWritePer,
                    endpointsInputsTextCapacityCacheWriteValue: endpointsInputsTextCapacityCacheWriteValue,
                    endpointsInputsTextPassthroughParameters: endpointsInputsTextPassthroughParameters,
                    endpointsInputsTextParamsMaxPromptLengthValue: endpointsInputsTextParamsMaxPromptLengthValue,
                    endpointsInputsTextParamsMaxPromptLengthUnit: endpointsInputsTextParamsMaxPromptLengthUnit,
                    endpointsInputsTextParamsMaxLengthValue: endpointsInputsTextParamsMaxLengthValue,
                    endpointsInputsTextParamsMaxLengthUnit: endpointsInputsTextParamsMaxLengthUnit,
                    endpointsInputsImagePricingType: endpointsInputsImagePricingType,
                    endpointsInputsImagePricingPromptUnit: endpointsInputsImagePricingPromptUnit,
                    endpointsInputsImagePricingPromptCostUsd: endpointsInputsImagePricingPromptCostUsd,
                    endpointsInputsImagePricingPromptOverridesCostUsd: endpointsInputsImagePricingPromptOverridesCostUsd,
                    endpointsInputsImagePricingPromptUtcStart: endpointsInputsImagePricingPromptUtcStart,
                    endpointsInputsImagePricingPromptUtcEnd: endpointsInputsImagePricingPromptUtcEnd,
                    endpointsInputsImagePricingPromptUtcDays: endpointsInputsImagePricingPromptUtcDays,
                    endpointsInputsImagePricingCachedPromptUnit: endpointsInputsImagePricingCachedPromptUnit,
                    endpointsInputsImagePricingCachedPromptCostUsd: endpointsInputsImagePricingCachedPromptCostUsd,
                    endpointsInputsImagePricingCachedPromptOverridesCostUsd: endpointsInputsImagePricingCachedPromptOverridesCostUsd,
                    endpointsInputsImagePricingCachedPromptTtlSeconds: endpointsInputsImagePricingCachedPromptTtlSeconds,
                    endpointsInputsImagePricingCachedPromptImplicit: endpointsInputsImagePricingCachedPromptImplicit,
                    endpointsInputsImagePricingCachedPromptUtcStart: endpointsInputsImagePricingCachedPromptUtcStart,
                    endpointsInputsImagePricingCachedPromptUtcEnd: endpointsInputsImagePricingCachedPromptUtcEnd,
                    endpointsInputsImagePricingCachedPromptUtcDays: endpointsInputsImagePricingCachedPromptUtcDays,
                    endpointsInputsImagePricingCacheWriteUnit: endpointsInputsImagePricingCacheWriteUnit,
                    endpointsInputsImagePricingCacheWriteCostUsd: endpointsInputsImagePricingCacheWriteCostUsd,
                    endpointsInputsImagePricingCacheWriteOverridesCostUsd: endpointsInputsImagePricingCacheWriteOverridesCostUsd,
                    endpointsInputsImagePricingCacheWriteTtlSeconds: endpointsInputsImagePricingCacheWriteTtlSeconds,
                    endpointsInputsImagePricingCacheWriteImplicit: endpointsInputsImagePricingCacheWriteImplicit,
                    endpointsInputsImagePricingCacheWriteUtcStart: endpointsInputsImagePricingCacheWriteUtcStart,
                    endpointsInputsImagePricingCacheWriteUtcEnd: endpointsInputsImagePricingCacheWriteUtcEnd,
                    endpointsInputsImagePricingCacheWriteUtcDays: endpointsInputsImagePricingCacheWriteUtcDays,
                    endpointsInputsImageCapacityType: endpointsInputsImageCapacityType,
                    endpointsInputsImageCapacityPromptUnit: endpointsInputsImageCapacityPromptUnit,
                    endpointsInputsImageCapacityPromptPer: endpointsInputsImageCapacityPromptPer,
                    endpointsInputsImageCapacityPromptValue: endpointsInputsImageCapacityPromptValue,
                    endpointsInputsImageCapacityCachedPromptUnit: endpointsInputsImageCapacityCachedPromptUnit,
                    endpointsInputsImageCapacityCachedPromptPer: endpointsInputsImageCapacityCachedPromptPer,
                    endpointsInputsImageCapacityCachedPromptValue: endpointsInputsImageCapacityCachedPromptValue,
                    endpointsInputsImageCapacityCacheWriteUnit: endpointsInputsImageCapacityCacheWriteUnit,
                    endpointsInputsImageCapacityCacheWritePer: endpointsInputsImageCapacityCacheWritePer,
                    endpointsInputsImageCapacityCacheWriteValue: endpointsInputsImageCapacityCacheWriteValue,
                    endpointsInputsImagePassthroughParameters: endpointsInputsImagePassthroughParameters,
                    endpointsInputsImageParamsSourcesType: endpointsInputsImageParamsSourcesType,
                    endpointsInputsImageParamsSourcesValues: endpointsInputsImageParamsSourcesValues,
                    endpointsInputsImageParamsFormatsType: endpointsInputsImageParamsFormatsType,
                    endpointsInputsImageParamsFormatsValues: endpointsInputsImageParamsFormatsValues,
                    endpointsInputsImageParamsDetailLevelsType: endpointsInputsImageParamsDetailLevelsType,
                    endpointsInputsImageParamsDetailLevelsValues: endpointsInputsImageParamsDetailLevelsValues,
                    endpointsInputsImageParamsReferencesType: endpointsInputsImageParamsReferencesType,
                    endpointsInputsImageParamsReferencesMin: endpointsInputsImageParamsReferencesMin,
                    endpointsInputsImageParamsReferencesMax: endpointsInputsImageParamsReferencesMax,
                    endpointsInputsImageParamsReferencesUnit: endpointsInputsImageParamsReferencesUnit,
                    endpointsInputsImageParamsRoleType: endpointsInputsImageParamsRoleType,
                    endpointsInputsImageParamsRoleValues: endpointsInputsImageParamsRoleValues,
                    endpointsInputsImageParamsMaxContentSizeBytesValue: endpointsInputsImageParamsMaxContentSizeBytesValue,
                    endpointsInputsImageParamsMaxContentSizeBytesUnit: endpointsInputsImageParamsMaxContentSizeBytesUnit,
                    endpointsInputsVideoPricingType: endpointsInputsVideoPricingType,
                    endpointsInputsVideoPricingPromptUnit: endpointsInputsVideoPricingPromptUnit,
                    endpointsInputsVideoPricingPromptCostUsd: endpointsInputsVideoPricingPromptCostUsd,
                    endpointsInputsVideoPricingPromptOverridesCostUsd: endpointsInputsVideoPricingPromptOverridesCostUsd,
                    endpointsInputsVideoPricingPromptUtcStart: endpointsInputsVideoPricingPromptUtcStart,
                    endpointsInputsVideoPricingPromptUtcEnd: endpointsInputsVideoPricingPromptUtcEnd,
                    endpointsInputsVideoPricingPromptUtcDays: endpointsInputsVideoPricingPromptUtcDays,
                    endpointsInputsVideoPricingCachedPromptUnit: endpointsInputsVideoPricingCachedPromptUnit,
                    endpointsInputsVideoPricingCachedPromptCostUsd: endpointsInputsVideoPricingCachedPromptCostUsd,
                    endpointsInputsVideoPricingCachedPromptOverridesCostUsd: endpointsInputsVideoPricingCachedPromptOverridesCostUsd,
                    endpointsInputsVideoPricingCachedPromptTtlSeconds: endpointsInputsVideoPricingCachedPromptTtlSeconds,
                    endpointsInputsVideoPricingCachedPromptImplicit: endpointsInputsVideoPricingCachedPromptImplicit,
                    endpointsInputsVideoPricingCachedPromptUtcStart: endpointsInputsVideoPricingCachedPromptUtcStart,
                    endpointsInputsVideoPricingCachedPromptUtcEnd: endpointsInputsVideoPricingCachedPromptUtcEnd,
                    endpointsInputsVideoPricingCachedPromptUtcDays: endpointsInputsVideoPricingCachedPromptUtcDays,
                    endpointsInputsVideoPricingCacheWriteUnit: endpointsInputsVideoPricingCacheWriteUnit,
                    endpointsInputsVideoPricingCacheWriteCostUsd: endpointsInputsVideoPricingCacheWriteCostUsd,
                    endpointsInputsVideoPricingCacheWriteOverridesCostUsd: endpointsInputsVideoPricingCacheWriteOverridesCostUsd,
                    endpointsInputsVideoPricingCacheWriteTtlSeconds: endpointsInputsVideoPricingCacheWriteTtlSeconds,
                    endpointsInputsVideoPricingCacheWriteImplicit: endpointsInputsVideoPricingCacheWriteImplicit,
                    endpointsInputsVideoPricingCacheWriteUtcStart: endpointsInputsVideoPricingCacheWriteUtcStart,
                    endpointsInputsVideoPricingCacheWriteUtcEnd: endpointsInputsVideoPricingCacheWriteUtcEnd,
                    endpointsInputsVideoPricingCacheWriteUtcDays: endpointsInputsVideoPricingCacheWriteUtcDays,
                    endpointsInputsVideoCapacityType: endpointsInputsVideoCapacityType,
                    endpointsInputsVideoCapacityPromptUnit: endpointsInputsVideoCapacityPromptUnit,
                    endpointsInputsVideoCapacityPromptPer: endpointsInputsVideoCapacityPromptPer,
                    endpointsInputsVideoCapacityPromptValue: endpointsInputsVideoCapacityPromptValue,
                    endpointsInputsVideoCapacityCachedPromptUnit: endpointsInputsVideoCapacityCachedPromptUnit,
                    endpointsInputsVideoCapacityCachedPromptPer: endpointsInputsVideoCapacityCachedPromptPer,
                    endpointsInputsVideoCapacityCachedPromptValue: endpointsInputsVideoCapacityCachedPromptValue,
                    endpointsInputsVideoCapacityCacheWriteUnit: endpointsInputsVideoCapacityCacheWriteUnit,
                    endpointsInputsVideoCapacityCacheWritePer: endpointsInputsVideoCapacityCacheWritePer,
                    endpointsInputsVideoCapacityCacheWriteValue: endpointsInputsVideoCapacityCacheWriteValue,
                    endpointsInputsVideoPassthroughParameters: endpointsInputsVideoPassthroughParameters,
                    endpointsInputsVideoParamsSourcesType: endpointsInputsVideoParamsSourcesType,
                    endpointsInputsVideoParamsSourcesValues: endpointsInputsVideoParamsSourcesValues,
                    endpointsInputsVideoParamsFormatsType: endpointsInputsVideoParamsFormatsType,
                    endpointsInputsVideoParamsFormatsValues: endpointsInputsVideoParamsFormatsValues,
                    endpointsInputsVideoParamsMaxDurationSecondsValue: endpointsInputsVideoParamsMaxDurationSecondsValue,
                    endpointsInputsVideoParamsMaxDurationSecondsUnit: endpointsInputsVideoParamsMaxDurationSecondsUnit,
                    endpointsInputsVideoParamsMaxContentSizeBytesValue: endpointsInputsVideoParamsMaxContentSizeBytesValue,
                    endpointsInputsVideoParamsMaxContentSizeBytesUnit: endpointsInputsVideoParamsMaxContentSizeBytesUnit,
                    endpointsInputsAudioPricingType: endpointsInputsAudioPricingType,
                    endpointsInputsAudioPricingPromptUnit: endpointsInputsAudioPricingPromptUnit,
                    endpointsInputsAudioPricingPromptCostUsd: endpointsInputsAudioPricingPromptCostUsd,
                    endpointsInputsAudioPricingPromptOverridesCostUsd: endpointsInputsAudioPricingPromptOverridesCostUsd,
                    endpointsInputsAudioPricingPromptUtcStart: endpointsInputsAudioPricingPromptUtcStart,
                    endpointsInputsAudioPricingPromptUtcEnd: endpointsInputsAudioPricingPromptUtcEnd,
                    endpointsInputsAudioPricingPromptUtcDays: endpointsInputsAudioPricingPromptUtcDays,
                    endpointsInputsAudioPricingCachedPromptUnit: endpointsInputsAudioPricingCachedPromptUnit,
                    endpointsInputsAudioPricingCachedPromptCostUsd: endpointsInputsAudioPricingCachedPromptCostUsd,
                    endpointsInputsAudioPricingCachedPromptOverridesCostUsd: endpointsInputsAudioPricingCachedPromptOverridesCostUsd,
                    endpointsInputsAudioPricingCachedPromptTtlSeconds: endpointsInputsAudioPricingCachedPromptTtlSeconds,
                    endpointsInputsAudioPricingCachedPromptImplicit: endpointsInputsAudioPricingCachedPromptImplicit,
                    endpointsInputsAudioPricingCachedPromptUtcStart: endpointsInputsAudioPricingCachedPromptUtcStart,
                    endpointsInputsAudioPricingCachedPromptUtcEnd: endpointsInputsAudioPricingCachedPromptUtcEnd,
                    endpointsInputsAudioPricingCachedPromptUtcDays: endpointsInputsAudioPricingCachedPromptUtcDays,
                    endpointsInputsAudioPricingCacheWriteUnit: endpointsInputsAudioPricingCacheWriteUnit,
                    endpointsInputsAudioPricingCacheWriteCostUsd: endpointsInputsAudioPricingCacheWriteCostUsd,
                    endpointsInputsAudioPricingCacheWriteOverridesCostUsd: endpointsInputsAudioPricingCacheWriteOverridesCostUsd,
                    endpointsInputsAudioPricingCacheWriteTtlSeconds: endpointsInputsAudioPricingCacheWriteTtlSeconds,
                    endpointsInputsAudioPricingCacheWriteImplicit: endpointsInputsAudioPricingCacheWriteImplicit,
                    endpointsInputsAudioPricingCacheWriteUtcStart: endpointsInputsAudioPricingCacheWriteUtcStart,
                    endpointsInputsAudioPricingCacheWriteUtcEnd: endpointsInputsAudioPricingCacheWriteUtcEnd,
                    endpointsInputsAudioPricingCacheWriteUtcDays: endpointsInputsAudioPricingCacheWriteUtcDays,
                    endpointsInputsAudioCapacityType: endpointsInputsAudioCapacityType,
                    endpointsInputsAudioCapacityPromptUnit: endpointsInputsAudioCapacityPromptUnit,
                    endpointsInputsAudioCapacityPromptPer: endpointsInputsAudioCapacityPromptPer,
                    endpointsInputsAudioCapacityPromptValue: endpointsInputsAudioCapacityPromptValue,
                    endpointsInputsAudioCapacityCachedPromptUnit: endpointsInputsAudioCapacityCachedPromptUnit,
                    endpointsInputsAudioCapacityCachedPromptPer: endpointsInputsAudioCapacityCachedPromptPer,
                    endpointsInputsAudioCapacityCachedPromptValue: endpointsInputsAudioCapacityCachedPromptValue,
                    endpointsInputsAudioCapacityCacheWriteUnit: endpointsInputsAudioCapacityCacheWriteUnit,
                    endpointsInputsAudioCapacityCacheWritePer: endpointsInputsAudioCapacityCacheWritePer,
                    endpointsInputsAudioCapacityCacheWriteValue: endpointsInputsAudioCapacityCacheWriteValue,
                    endpointsInputsAudioPassthroughParameters: endpointsInputsAudioPassthroughParameters,
                    endpointsInputsAudioParamsSourcesType: endpointsInputsAudioParamsSourcesType,
                    endpointsInputsAudioParamsSourcesValues: endpointsInputsAudioParamsSourcesValues,
                    endpointsInputsAudioParamsFormatsType: endpointsInputsAudioParamsFormatsType,
                    endpointsInputsAudioParamsFormatsValues: endpointsInputsAudioParamsFormatsValues,
                    endpointsInputsAudioParamsMaxDurationSecondsValue: endpointsInputsAudioParamsMaxDurationSecondsValue,
                    endpointsInputsAudioParamsMaxDurationSecondsUnit: endpointsInputsAudioParamsMaxDurationSecondsUnit,
                    endpointsInputsAudioParamsMaxContentSizeBytesValue: endpointsInputsAudioParamsMaxContentSizeBytesValue,
                    endpointsInputsAudioParamsMaxContentSizeBytesUnit: endpointsInputsAudioParamsMaxContentSizeBytesUnit,
                    endpointsInputsFilePricingType: endpointsInputsFilePricingType,
                    endpointsInputsFilePricingPromptUnit: endpointsInputsFilePricingPromptUnit,
                    endpointsInputsFilePricingPromptCostUsd: endpointsInputsFilePricingPromptCostUsd,
                    endpointsInputsFilePricingPromptOverridesCostUsd: endpointsInputsFilePricingPromptOverridesCostUsd,
                    endpointsInputsFilePricingPromptUtcStart: endpointsInputsFilePricingPromptUtcStart,
                    endpointsInputsFilePricingPromptUtcEnd: endpointsInputsFilePricingPromptUtcEnd,
                    endpointsInputsFilePricingPromptUtcDays: endpointsInputsFilePricingPromptUtcDays,
                    endpointsInputsFilePricingCachedPromptUnit: endpointsInputsFilePricingCachedPromptUnit,
                    endpointsInputsFilePricingCachedPromptCostUsd: endpointsInputsFilePricingCachedPromptCostUsd,
                    endpointsInputsFilePricingCachedPromptOverridesCostUsd: endpointsInputsFilePricingCachedPromptOverridesCostUsd,
                    endpointsInputsFilePricingCachedPromptTtlSeconds: endpointsInputsFilePricingCachedPromptTtlSeconds,
                    endpointsInputsFilePricingCachedPromptImplicit: endpointsInputsFilePricingCachedPromptImplicit,
                    endpointsInputsFilePricingCachedPromptUtcStart: endpointsInputsFilePricingCachedPromptUtcStart,
                    endpointsInputsFilePricingCachedPromptUtcEnd: endpointsInputsFilePricingCachedPromptUtcEnd,
                    endpointsInputsFilePricingCachedPromptUtcDays: endpointsInputsFilePricingCachedPromptUtcDays,
                    endpointsInputsFilePricingCacheWriteUnit: endpointsInputsFilePricingCacheWriteUnit,
                    endpointsInputsFilePricingCacheWriteCostUsd: endpointsInputsFilePricingCacheWriteCostUsd,
                    endpointsInputsFilePricingCacheWriteOverridesCostUsd: endpointsInputsFilePricingCacheWriteOverridesCostUsd,
                    endpointsInputsFilePricingCacheWriteTtlSeconds: endpointsInputsFilePricingCacheWriteTtlSeconds,
                    endpointsInputsFilePricingCacheWriteImplicit: endpointsInputsFilePricingCacheWriteImplicit,
                    endpointsInputsFilePricingCacheWriteUtcStart: endpointsInputsFilePricingCacheWriteUtcStart,
                    endpointsInputsFilePricingCacheWriteUtcEnd: endpointsInputsFilePricingCacheWriteUtcEnd,
                    endpointsInputsFilePricingCacheWriteUtcDays: endpointsInputsFilePricingCacheWriteUtcDays,
                    endpointsInputsFileCapacityType: endpointsInputsFileCapacityType,
                    endpointsInputsFileCapacityPromptUnit: endpointsInputsFileCapacityPromptUnit,
                    endpointsInputsFileCapacityPromptPer: endpointsInputsFileCapacityPromptPer,
                    endpointsInputsFileCapacityPromptValue: endpointsInputsFileCapacityPromptValue,
                    endpointsInputsFileCapacityCachedPromptUnit: endpointsInputsFileCapacityCachedPromptUnit,
                    endpointsInputsFileCapacityCachedPromptPer: endpointsInputsFileCapacityCachedPromptPer,
                    endpointsInputsFileCapacityCachedPromptValue: endpointsInputsFileCapacityCachedPromptValue,
                    endpointsInputsFileCapacityCacheWriteUnit: endpointsInputsFileCapacityCacheWriteUnit,
                    endpointsInputsFileCapacityCacheWritePer: endpointsInputsFileCapacityCacheWritePer,
                    endpointsInputsFileCapacityCacheWriteValue: endpointsInputsFileCapacityCacheWriteValue,
                    endpointsInputsFilePassthroughParameters: endpointsInputsFilePassthroughParameters,
                    endpointsInputsFileParamsSourcesType: endpointsInputsFileParamsSourcesType,
                    endpointsInputsFileParamsSourcesValues: endpointsInputsFileParamsSourcesValues,
                    endpointsInputsFileParamsFormatsType: endpointsInputsFileParamsFormatsType,
                    endpointsInputsFileParamsFormatsValues: endpointsInputsFileParamsFormatsValues,
                    endpointsInputsFileParamsReferencesType: endpointsInputsFileParamsReferencesType,
                    endpointsInputsFileParamsReferencesMin: endpointsInputsFileParamsReferencesMin,
                    endpointsInputsFileParamsReferencesMax: endpointsInputsFileParamsReferencesMax,
                    endpointsInputsFileParamsReferencesUnit: endpointsInputsFileParamsReferencesUnit,
                    endpointsInputsFileParamsMaxContentSizeBytesValue: endpointsInputsFileParamsMaxContentSizeBytesValue,
                    endpointsInputsFileParamsMaxContentSizeBytesUnit: endpointsInputsFileParamsMaxContentSizeBytesUnit,
                    endpointsOutputsType: endpointsOutputsType,
                    endpointsOutputsTextMaxLengthValue: endpointsOutputsTextMaxLengthValue,
                    endpointsOutputsTextMaxLengthUnit: endpointsOutputsTextMaxLengthUnit,
                    endpointsOutputsTextPassthroughParameters: endpointsOutputsTextPassthroughParameters,
                    endpointsOutputsTextPricingType: endpointsOutputsTextPricingType,
                    endpointsOutputsTextPricingCompletionUnit: endpointsOutputsTextPricingCompletionUnit,
                    endpointsOutputsTextPricingCompletionCostUsd: endpointsOutputsTextPricingCompletionCostUsd,
                    endpointsOutputsTextPricingCompletionOverridesCostUsd: endpointsOutputsTextPricingCompletionOverridesCostUsd,
                    endpointsOutputsTextPricingCompletionUtcStart: endpointsOutputsTextPricingCompletionUtcStart,
                    endpointsOutputsTextPricingCompletionUtcEnd: endpointsOutputsTextPricingCompletionUtcEnd,
                    endpointsOutputsTextPricingCompletionUtcDays: endpointsOutputsTextPricingCompletionUtcDays,
                    endpointsOutputsTextPricingInternalReasoningUnit: endpointsOutputsTextPricingInternalReasoningUnit,
                    endpointsOutputsTextPricingInternalReasoningCostUsd: endpointsOutputsTextPricingInternalReasoningCostUsd,
                    endpointsOutputsTextPricingInternalReasoningOverridesCostUsd: endpointsOutputsTextPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsTextPricingInternalReasoningUtcStart: endpointsOutputsTextPricingInternalReasoningUtcStart,
                    endpointsOutputsTextPricingInternalReasoningUtcEnd: endpointsOutputsTextPricingInternalReasoningUtcEnd,
                    endpointsOutputsTextPricingInternalReasoningUtcDays: endpointsOutputsTextPricingInternalReasoningUtcDays,
                    endpointsOutputsTextCapacityType: endpointsOutputsTextCapacityType,
                    endpointsOutputsTextCapacityCompletionUnit: endpointsOutputsTextCapacityCompletionUnit,
                    endpointsOutputsTextCapacityCompletionPer: endpointsOutputsTextCapacityCompletionPer,
                    endpointsOutputsTextCapacityCompletionValue: endpointsOutputsTextCapacityCompletionValue,
                    endpointsOutputsTextCapacityInternalReasoningUnit: endpointsOutputsTextCapacityInternalReasoningUnit,
                    endpointsOutputsTextCapacityInternalReasoningPer: endpointsOutputsTextCapacityInternalReasoningPer,
                    endpointsOutputsTextCapacityInternalReasoningValue: endpointsOutputsTextCapacityInternalReasoningValue,
                    endpointsOutputsTextCapacityConcurrencyUnit: endpointsOutputsTextCapacityConcurrencyUnit,
                    endpointsOutputsTextCapacityConcurrencyValue: endpointsOutputsTextCapacityConcurrencyValue,
                    endpointsOutputsTextStreaming: endpointsOutputsTextStreaming,
                    endpointsOutputsTextParams: endpointsOutputsTextParams,
                    endpointsOutputsImagePassthroughParameters: endpointsOutputsImagePassthroughParameters,
                    endpointsOutputsImagePricingType: endpointsOutputsImagePricingType,
                    endpointsOutputsImagePricingCompletionUnit: endpointsOutputsImagePricingCompletionUnit,
                    endpointsOutputsImagePricingCompletionCostUsd: endpointsOutputsImagePricingCompletionCostUsd,
                    endpointsOutputsImagePricingCompletionOverridesCostUsd: endpointsOutputsImagePricingCompletionOverridesCostUsd,
                    endpointsOutputsImagePricingCompletionUtcStart: endpointsOutputsImagePricingCompletionUtcStart,
                    endpointsOutputsImagePricingCompletionUtcEnd: endpointsOutputsImagePricingCompletionUtcEnd,
                    endpointsOutputsImagePricingCompletionUtcDays: endpointsOutputsImagePricingCompletionUtcDays,
                    endpointsOutputsImagePricingInternalReasoningUnit: endpointsOutputsImagePricingInternalReasoningUnit,
                    endpointsOutputsImagePricingInternalReasoningCostUsd: endpointsOutputsImagePricingInternalReasoningCostUsd,
                    endpointsOutputsImagePricingInternalReasoningOverridesCostUsd: endpointsOutputsImagePricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsImagePricingInternalReasoningUtcStart: endpointsOutputsImagePricingInternalReasoningUtcStart,
                    endpointsOutputsImagePricingInternalReasoningUtcEnd: endpointsOutputsImagePricingInternalReasoningUtcEnd,
                    endpointsOutputsImagePricingInternalReasoningUtcDays: endpointsOutputsImagePricingInternalReasoningUtcDays,
                    endpointsOutputsImageCapacityType: endpointsOutputsImageCapacityType,
                    endpointsOutputsImageCapacityCompletionUnit: endpointsOutputsImageCapacityCompletionUnit,
                    endpointsOutputsImageCapacityCompletionPer: endpointsOutputsImageCapacityCompletionPer,
                    endpointsOutputsImageCapacityCompletionValue: endpointsOutputsImageCapacityCompletionValue,
                    endpointsOutputsImageCapacityInternalReasoningUnit: endpointsOutputsImageCapacityInternalReasoningUnit,
                    endpointsOutputsImageCapacityInternalReasoningPer: endpointsOutputsImageCapacityInternalReasoningPer,
                    endpointsOutputsImageCapacityInternalReasoningValue: endpointsOutputsImageCapacityInternalReasoningValue,
                    endpointsOutputsImageCapacityConcurrencyUnit: endpointsOutputsImageCapacityConcurrencyUnit,
                    endpointsOutputsImageCapacityConcurrencyValue: endpointsOutputsImageCapacityConcurrencyValue,
                    endpointsOutputsImageStreaming: endpointsOutputsImageStreaming,
                    endpointsOutputsImageParams: endpointsOutputsImageParams,
                    endpointsOutputsVideoPassthroughParameters: endpointsOutputsVideoPassthroughParameters,
                    endpointsOutputsVideoPricingType: endpointsOutputsVideoPricingType,
                    endpointsOutputsVideoPricingCompletionUnit: endpointsOutputsVideoPricingCompletionUnit,
                    endpointsOutputsVideoPricingCompletionCostUsd: endpointsOutputsVideoPricingCompletionCostUsd,
                    endpointsOutputsVideoPricingCompletionOverridesCostUsd: endpointsOutputsVideoPricingCompletionOverridesCostUsd,
                    endpointsOutputsVideoPricingCompletionUtcStart: endpointsOutputsVideoPricingCompletionUtcStart,
                    endpointsOutputsVideoPricingCompletionUtcEnd: endpointsOutputsVideoPricingCompletionUtcEnd,
                    endpointsOutputsVideoPricingCompletionUtcDays: endpointsOutputsVideoPricingCompletionUtcDays,
                    endpointsOutputsVideoPricingInternalReasoningUnit: endpointsOutputsVideoPricingInternalReasoningUnit,
                    endpointsOutputsVideoPricingInternalReasoningCostUsd: endpointsOutputsVideoPricingInternalReasoningCostUsd,
                    endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd: endpointsOutputsVideoPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsVideoPricingInternalReasoningUtcStart: endpointsOutputsVideoPricingInternalReasoningUtcStart,
                    endpointsOutputsVideoPricingInternalReasoningUtcEnd: endpointsOutputsVideoPricingInternalReasoningUtcEnd,
                    endpointsOutputsVideoPricingInternalReasoningUtcDays: endpointsOutputsVideoPricingInternalReasoningUtcDays,
                    endpointsOutputsVideoCapacityType: endpointsOutputsVideoCapacityType,
                    endpointsOutputsVideoCapacityCompletionUnit: endpointsOutputsVideoCapacityCompletionUnit,
                    endpointsOutputsVideoCapacityCompletionPer: endpointsOutputsVideoCapacityCompletionPer,
                    endpointsOutputsVideoCapacityCompletionValue: endpointsOutputsVideoCapacityCompletionValue,
                    endpointsOutputsVideoCapacityInternalReasoningUnit: endpointsOutputsVideoCapacityInternalReasoningUnit,
                    endpointsOutputsVideoCapacityInternalReasoningPer: endpointsOutputsVideoCapacityInternalReasoningPer,
                    endpointsOutputsVideoCapacityInternalReasoningValue: endpointsOutputsVideoCapacityInternalReasoningValue,
                    endpointsOutputsVideoCapacityConcurrencyUnit: endpointsOutputsVideoCapacityConcurrencyUnit,
                    endpointsOutputsVideoCapacityConcurrencyValue: endpointsOutputsVideoCapacityConcurrencyValue,
                    endpointsOutputsVideoStreaming: endpointsOutputsVideoStreaming,
                    endpointsOutputsVideoParams: endpointsOutputsVideoParams,
                    endpointsOutputsSpeechPassthroughParameters: endpointsOutputsSpeechPassthroughParameters,
                    endpointsOutputsSpeechPricingType: endpointsOutputsSpeechPricingType,
                    endpointsOutputsSpeechPricingCompletionUnit: endpointsOutputsSpeechPricingCompletionUnit,
                    endpointsOutputsSpeechPricingCompletionCostUsd: endpointsOutputsSpeechPricingCompletionCostUsd,
                    endpointsOutputsSpeechPricingCompletionOverridesCostUsd: endpointsOutputsSpeechPricingCompletionOverridesCostUsd,
                    endpointsOutputsSpeechPricingCompletionUtcStart: endpointsOutputsSpeechPricingCompletionUtcStart,
                    endpointsOutputsSpeechPricingCompletionUtcEnd: endpointsOutputsSpeechPricingCompletionUtcEnd,
                    endpointsOutputsSpeechPricingCompletionUtcDays: endpointsOutputsSpeechPricingCompletionUtcDays,
                    endpointsOutputsSpeechPricingInternalReasoningUnit: endpointsOutputsSpeechPricingInternalReasoningUnit,
                    endpointsOutputsSpeechPricingInternalReasoningCostUsd: endpointsOutputsSpeechPricingInternalReasoningCostUsd,
                    endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd: endpointsOutputsSpeechPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsSpeechPricingInternalReasoningUtcStart: endpointsOutputsSpeechPricingInternalReasoningUtcStart,
                    endpointsOutputsSpeechPricingInternalReasoningUtcEnd: endpointsOutputsSpeechPricingInternalReasoningUtcEnd,
                    endpointsOutputsSpeechPricingInternalReasoningUtcDays: endpointsOutputsSpeechPricingInternalReasoningUtcDays,
                    endpointsOutputsSpeechCapacityType: endpointsOutputsSpeechCapacityType,
                    endpointsOutputsSpeechCapacityCompletionUnit: endpointsOutputsSpeechCapacityCompletionUnit,
                    endpointsOutputsSpeechCapacityCompletionPer: endpointsOutputsSpeechCapacityCompletionPer,
                    endpointsOutputsSpeechCapacityCompletionValue: endpointsOutputsSpeechCapacityCompletionValue,
                    endpointsOutputsSpeechCapacityInternalReasoningUnit: endpointsOutputsSpeechCapacityInternalReasoningUnit,
                    endpointsOutputsSpeechCapacityInternalReasoningPer: endpointsOutputsSpeechCapacityInternalReasoningPer,
                    endpointsOutputsSpeechCapacityInternalReasoningValue: endpointsOutputsSpeechCapacityInternalReasoningValue,
                    endpointsOutputsSpeechCapacityConcurrencyUnit: endpointsOutputsSpeechCapacityConcurrencyUnit,
                    endpointsOutputsSpeechCapacityConcurrencyValue: endpointsOutputsSpeechCapacityConcurrencyValue,
                    endpointsOutputsSpeechStreaming: endpointsOutputsSpeechStreaming,
                    endpointsOutputsSpeechParams: endpointsOutputsSpeechParams,
                    endpointsOutputsTranscriptionPassthroughParameters: endpointsOutputsTranscriptionPassthroughParameters,
                    endpointsOutputsTranscriptionPricingType: endpointsOutputsTranscriptionPricingType,
                    endpointsOutputsTranscriptionPricingCompletionUnit: endpointsOutputsTranscriptionPricingCompletionUnit,
                    endpointsOutputsTranscriptionPricingCompletionCostUsd: endpointsOutputsTranscriptionPricingCompletionCostUsd,
                    endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd: endpointsOutputsTranscriptionPricingCompletionOverridesCostUsd,
                    endpointsOutputsTranscriptionPricingCompletionUtcStart: endpointsOutputsTranscriptionPricingCompletionUtcStart,
                    endpointsOutputsTranscriptionPricingCompletionUtcEnd: endpointsOutputsTranscriptionPricingCompletionUtcEnd,
                    endpointsOutputsTranscriptionPricingCompletionUtcDays: endpointsOutputsTranscriptionPricingCompletionUtcDays,
                    endpointsOutputsTranscriptionPricingInternalReasoningUnit: endpointsOutputsTranscriptionPricingInternalReasoningUnit,
                    endpointsOutputsTranscriptionPricingInternalReasoningCostUsd: endpointsOutputsTranscriptionPricingInternalReasoningCostUsd,
                    endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd: endpointsOutputsTranscriptionPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsTranscriptionPricingInternalReasoningUtcStart: endpointsOutputsTranscriptionPricingInternalReasoningUtcStart,
                    endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd: endpointsOutputsTranscriptionPricingInternalReasoningUtcEnd,
                    endpointsOutputsTranscriptionPricingInternalReasoningUtcDays: endpointsOutputsTranscriptionPricingInternalReasoningUtcDays,
                    endpointsOutputsTranscriptionCapacityType: endpointsOutputsTranscriptionCapacityType,
                    endpointsOutputsTranscriptionCapacityCompletionUnit: endpointsOutputsTranscriptionCapacityCompletionUnit,
                    endpointsOutputsTranscriptionCapacityCompletionPer: endpointsOutputsTranscriptionCapacityCompletionPer,
                    endpointsOutputsTranscriptionCapacityCompletionValue: endpointsOutputsTranscriptionCapacityCompletionValue,
                    endpointsOutputsTranscriptionCapacityInternalReasoningUnit: endpointsOutputsTranscriptionCapacityInternalReasoningUnit,
                    endpointsOutputsTranscriptionCapacityInternalReasoningPer: endpointsOutputsTranscriptionCapacityInternalReasoningPer,
                    endpointsOutputsTranscriptionCapacityInternalReasoningValue: endpointsOutputsTranscriptionCapacityInternalReasoningValue,
                    endpointsOutputsTranscriptionCapacityConcurrencyUnit: endpointsOutputsTranscriptionCapacityConcurrencyUnit,
                    endpointsOutputsTranscriptionCapacityConcurrencyValue: endpointsOutputsTranscriptionCapacityConcurrencyValue,
                    endpointsOutputsTranscriptionStreaming: endpointsOutputsTranscriptionStreaming,
                    endpointsOutputsTranscriptionParams: endpointsOutputsTranscriptionParams,
                    endpointsOutputsEmbeddingsPassthroughParameters: endpointsOutputsEmbeddingsPassthroughParameters,
                    endpointsOutputsEmbeddingsPricingType: endpointsOutputsEmbeddingsPricingType,
                    endpointsOutputsEmbeddingsPricingCompletionUnit: endpointsOutputsEmbeddingsPricingCompletionUnit,
                    endpointsOutputsEmbeddingsPricingCompletionCostUsd: endpointsOutputsEmbeddingsPricingCompletionCostUsd,
                    endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd: endpointsOutputsEmbeddingsPricingCompletionOverridesCostUsd,
                    endpointsOutputsEmbeddingsPricingCompletionUtcStart: endpointsOutputsEmbeddingsPricingCompletionUtcStart,
                    endpointsOutputsEmbeddingsPricingCompletionUtcEnd: endpointsOutputsEmbeddingsPricingCompletionUtcEnd,
                    endpointsOutputsEmbeddingsPricingCompletionUtcDays: endpointsOutputsEmbeddingsPricingCompletionUtcDays,
                    endpointsOutputsEmbeddingsPricingInternalReasoningUnit: endpointsOutputsEmbeddingsPricingInternalReasoningUnit,
                    endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd: endpointsOutputsEmbeddingsPricingInternalReasoningCostUsd,
                    endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd: endpointsOutputsEmbeddingsPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart: endpointsOutputsEmbeddingsPricingInternalReasoningUtcStart,
                    endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd: endpointsOutputsEmbeddingsPricingInternalReasoningUtcEnd,
                    endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays: endpointsOutputsEmbeddingsPricingInternalReasoningUtcDays,
                    endpointsOutputsEmbeddingsCapacityType: endpointsOutputsEmbeddingsCapacityType,
                    endpointsOutputsEmbeddingsCapacityCompletionUnit: endpointsOutputsEmbeddingsCapacityCompletionUnit,
                    endpointsOutputsEmbeddingsCapacityCompletionPer: endpointsOutputsEmbeddingsCapacityCompletionPer,
                    endpointsOutputsEmbeddingsCapacityCompletionValue: endpointsOutputsEmbeddingsCapacityCompletionValue,
                    endpointsOutputsEmbeddingsCapacityInternalReasoningUnit: endpointsOutputsEmbeddingsCapacityInternalReasoningUnit,
                    endpointsOutputsEmbeddingsCapacityInternalReasoningPer: endpointsOutputsEmbeddingsCapacityInternalReasoningPer,
                    endpointsOutputsEmbeddingsCapacityInternalReasoningValue: endpointsOutputsEmbeddingsCapacityInternalReasoningValue,
                    endpointsOutputsEmbeddingsCapacityConcurrencyUnit: endpointsOutputsEmbeddingsCapacityConcurrencyUnit,
                    endpointsOutputsEmbeddingsCapacityConcurrencyValue: endpointsOutputsEmbeddingsCapacityConcurrencyValue,
                    endpointsOutputsEmbeddingsParams: endpointsOutputsEmbeddingsParams,
                    endpointsOutputsRerankPassthroughParameters: endpointsOutputsRerankPassthroughParameters,
                    endpointsOutputsRerankPricingType: endpointsOutputsRerankPricingType,
                    endpointsOutputsRerankPricingCompletionUnit: endpointsOutputsRerankPricingCompletionUnit,
                    endpointsOutputsRerankPricingCompletionCostUsd: endpointsOutputsRerankPricingCompletionCostUsd,
                    endpointsOutputsRerankPricingCompletionOverridesCostUsd: endpointsOutputsRerankPricingCompletionOverridesCostUsd,
                    endpointsOutputsRerankPricingCompletionUtcStart: endpointsOutputsRerankPricingCompletionUtcStart,
                    endpointsOutputsRerankPricingCompletionUtcEnd: endpointsOutputsRerankPricingCompletionUtcEnd,
                    endpointsOutputsRerankPricingCompletionUtcDays: endpointsOutputsRerankPricingCompletionUtcDays,
                    endpointsOutputsRerankPricingInternalReasoningUnit: endpointsOutputsRerankPricingInternalReasoningUnit,
                    endpointsOutputsRerankPricingInternalReasoningCostUsd: endpointsOutputsRerankPricingInternalReasoningCostUsd,
                    endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd: endpointsOutputsRerankPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsRerankPricingInternalReasoningUtcStart: endpointsOutputsRerankPricingInternalReasoningUtcStart,
                    endpointsOutputsRerankPricingInternalReasoningUtcEnd: endpointsOutputsRerankPricingInternalReasoningUtcEnd,
                    endpointsOutputsRerankPricingInternalReasoningUtcDays: endpointsOutputsRerankPricingInternalReasoningUtcDays,
                    endpointsOutputsRerankCapacityType: endpointsOutputsRerankCapacityType,
                    endpointsOutputsRerankCapacityCompletionUnit: endpointsOutputsRerankCapacityCompletionUnit,
                    endpointsOutputsRerankCapacityCompletionPer: endpointsOutputsRerankCapacityCompletionPer,
                    endpointsOutputsRerankCapacityCompletionValue: endpointsOutputsRerankCapacityCompletionValue,
                    endpointsOutputsRerankCapacityInternalReasoningUnit: endpointsOutputsRerankCapacityInternalReasoningUnit,
                    endpointsOutputsRerankCapacityInternalReasoningPer: endpointsOutputsRerankCapacityInternalReasoningPer,
                    endpointsOutputsRerankCapacityInternalReasoningValue: endpointsOutputsRerankCapacityInternalReasoningValue,
                    endpointsOutputsRerankCapacityConcurrencyUnit: endpointsOutputsRerankCapacityConcurrencyUnit,
                    endpointsOutputsRerankCapacityConcurrencyValue: endpointsOutputsRerankCapacityConcurrencyValue,
                    endpointsOutputsRerankParams: endpointsOutputsRerankParams,
                    endpointsOutputsDecisionsPassthroughParameters: endpointsOutputsDecisionsPassthroughParameters,
                    endpointsOutputsDecisionsPricingType: endpointsOutputsDecisionsPricingType,
                    endpointsOutputsDecisionsPricingCompletionUnit: endpointsOutputsDecisionsPricingCompletionUnit,
                    endpointsOutputsDecisionsPricingCompletionCostUsd: endpointsOutputsDecisionsPricingCompletionCostUsd,
                    endpointsOutputsDecisionsPricingCompletionOverridesCostUsd: endpointsOutputsDecisionsPricingCompletionOverridesCostUsd,
                    endpointsOutputsDecisionsPricingCompletionUtcStart: endpointsOutputsDecisionsPricingCompletionUtcStart,
                    endpointsOutputsDecisionsPricingCompletionUtcEnd: endpointsOutputsDecisionsPricingCompletionUtcEnd,
                    endpointsOutputsDecisionsPricingCompletionUtcDays: endpointsOutputsDecisionsPricingCompletionUtcDays,
                    endpointsOutputsDecisionsPricingInternalReasoningUnit: endpointsOutputsDecisionsPricingInternalReasoningUnit,
                    endpointsOutputsDecisionsPricingInternalReasoningCostUsd: endpointsOutputsDecisionsPricingInternalReasoningCostUsd,
                    endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd: endpointsOutputsDecisionsPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsDecisionsPricingInternalReasoningUtcStart: endpointsOutputsDecisionsPricingInternalReasoningUtcStart,
                    endpointsOutputsDecisionsPricingInternalReasoningUtcEnd: endpointsOutputsDecisionsPricingInternalReasoningUtcEnd,
                    endpointsOutputsDecisionsPricingInternalReasoningUtcDays: endpointsOutputsDecisionsPricingInternalReasoningUtcDays,
                    endpointsOutputsDecisionsCapacityType: endpointsOutputsDecisionsCapacityType,
                    endpointsOutputsDecisionsCapacityCompletionUnit: endpointsOutputsDecisionsCapacityCompletionUnit,
                    endpointsOutputsDecisionsCapacityCompletionPer: endpointsOutputsDecisionsCapacityCompletionPer,
                    endpointsOutputsDecisionsCapacityCompletionValue: endpointsOutputsDecisionsCapacityCompletionValue,
                    endpointsOutputsDecisionsCapacityInternalReasoningUnit: endpointsOutputsDecisionsCapacityInternalReasoningUnit,
                    endpointsOutputsDecisionsCapacityInternalReasoningPer: endpointsOutputsDecisionsCapacityInternalReasoningPer,
                    endpointsOutputsDecisionsCapacityInternalReasoningValue: endpointsOutputsDecisionsCapacityInternalReasoningValue,
                    endpointsOutputsDecisionsCapacityConcurrencyUnit: endpointsOutputsDecisionsCapacityConcurrencyUnit,
                    endpointsOutputsDecisionsCapacityConcurrencyValue: endpointsOutputsDecisionsCapacityConcurrencyValue,
                    endpointsOutputsDecisionsParams: endpointsOutputsDecisionsParams,
                    endpointsOutputsAudioPassthroughParameters: endpointsOutputsAudioPassthroughParameters,
                    endpointsOutputsAudioPricingType: endpointsOutputsAudioPricingType,
                    endpointsOutputsAudioPricingCompletionUnit: endpointsOutputsAudioPricingCompletionUnit,
                    endpointsOutputsAudioPricingCompletionCostUsd: endpointsOutputsAudioPricingCompletionCostUsd,
                    endpointsOutputsAudioPricingCompletionOverridesCostUsd: endpointsOutputsAudioPricingCompletionOverridesCostUsd,
                    endpointsOutputsAudioPricingCompletionUtcStart: endpointsOutputsAudioPricingCompletionUtcStart,
                    endpointsOutputsAudioPricingCompletionUtcEnd: endpointsOutputsAudioPricingCompletionUtcEnd,
                    endpointsOutputsAudioPricingCompletionUtcDays: endpointsOutputsAudioPricingCompletionUtcDays,
                    endpointsOutputsAudioPricingInternalReasoningUnit: endpointsOutputsAudioPricingInternalReasoningUnit,
                    endpointsOutputsAudioPricingInternalReasoningCostUsd: endpointsOutputsAudioPricingInternalReasoningCostUsd,
                    endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd: endpointsOutputsAudioPricingInternalReasoningOverridesCostUsd,
                    endpointsOutputsAudioPricingInternalReasoningUtcStart: endpointsOutputsAudioPricingInternalReasoningUtcStart,
                    endpointsOutputsAudioPricingInternalReasoningUtcEnd: endpointsOutputsAudioPricingInternalReasoningUtcEnd,
                    endpointsOutputsAudioPricingInternalReasoningUtcDays: endpointsOutputsAudioPricingInternalReasoningUtcDays,
                    endpointsOutputsAudioCapacityType: endpointsOutputsAudioCapacityType,
                    endpointsOutputsAudioCapacityCompletionUnit: endpointsOutputsAudioCapacityCompletionUnit,
                    endpointsOutputsAudioCapacityCompletionPer: endpointsOutputsAudioCapacityCompletionPer,
                    endpointsOutputsAudioCapacityCompletionValue: endpointsOutputsAudioCapacityCompletionValue,
                    endpointsOutputsAudioCapacityInternalReasoningUnit: endpointsOutputsAudioCapacityInternalReasoningUnit,
                    endpointsOutputsAudioCapacityInternalReasoningPer: endpointsOutputsAudioCapacityInternalReasoningPer,
                    endpointsOutputsAudioCapacityInternalReasoningValue: endpointsOutputsAudioCapacityInternalReasoningValue,
                    endpointsOutputsAudioCapacityConcurrencyUnit: endpointsOutputsAudioCapacityConcurrencyUnit,
                    endpointsOutputsAudioCapacityConcurrencyValue: endpointsOutputsAudioCapacityConcurrencyValue,
                    endpointsOutputsAudioStreaming: endpointsOutputsAudioStreaming,
                    endpointsOutputsAudioParams: endpointsOutputsAudioParams,
                    endpointsProviderSlug: endpointsProviderSlug,
                    endpointsProviderTag: endpointsProviderTag,
                    endpointsProviderName: endpointsProviderName,
                    endpointsDataPolicyTraining: endpointsDataPolicyTraining,
                    endpointsDataPolicyRetainsPrompts: endpointsDataPolicyRetainsPrompts,
                    endpointsDataPolicyRetentionDays: endpointsDataPolicyRetentionDays);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/api/v2/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::OpenRouter.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/api/v2/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::OpenRouter.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::OpenRouter.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/api/v2/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListV2Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/api/v2/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/api/v2/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request - Invalid request parameters or malformed input
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::OpenRouter.BadRequestResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::OpenRouter.BadRequestResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::OpenRouter.BadRequestResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.BadRequestResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized - Authentication required or invalid credentials
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::OpenRouter.UnauthorizedResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::OpenRouter.UnauthorizedResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::OpenRouter.UnauthorizedResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.UnauthorizedResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal Server Error - Unexpected server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::OpenRouter.InternalServerResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::OpenRouter.InternalServerResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::OpenRouter.InternalServerResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternalServerResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListV2ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::OpenRouter.ModelsV2ListResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsV2ListResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::OpenRouter.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::OpenRouter.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::OpenRouter.ModelsV2ListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsV2ListResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::OpenRouter.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::OpenRouter.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}