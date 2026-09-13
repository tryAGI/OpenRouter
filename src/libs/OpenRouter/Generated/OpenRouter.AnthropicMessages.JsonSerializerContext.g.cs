
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MetadataLevel), TypeInfoPropertyName = "MetadataLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlTtl), TypeInfoPropertyName = "AnthropicCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirectiveType), TypeInfoPropertyName = "AnthropicCacheControlDirectiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirective))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngineEnum), TypeInfoPropertyName = "WebSearchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolType), TypeInfoPropertyName = "DatetimeServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType), TypeInfoPropertyName = "ImageGenerationServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchModelsServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchEngineEnum), TypeInfoPropertyName = "WebFetchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerToolType), TypeInfoPropertyName = "WebFetchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchQualityLevel), TypeInfoPropertyName = "SearchQualityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerToolType), TypeInfoPropertyName = "WebSearchUserLocationServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEngine), TypeInfoPropertyName = "BashServerToolEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironment), TypeInfoPropertyName = "BashServerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentVariant1Type), TypeInfoPropertyName = "BashServerToolEnvironmentVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentVariant2Type), TypeInfoPropertyName = "BashServerToolEnvironmentVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminatorType), TypeInfoPropertyName = "BashServerToolEnvironmentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolType), TypeInfoPropertyName = "BashServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContextCompressionEngine), TypeInfoPropertyName = "ContextCompressionEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine0), TypeInfoPropertyName = "PdfParserEngine02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine1), TypeInfoPropertyName = "PdfParserEngine12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserEngine), TypeInfoPropertyName = "PDFParserEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset), TypeInfoPropertyName = "ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4), TypeInfoPropertyName = "ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters), TypeInfoPropertyName = "ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource), TypeInfoPropertyName = "ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngine), TypeInfoPropertyName = "WebSearchEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginId), TypeInfoPropertyName = "WebSearchPluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginUserLocationType), TypeInfoPropertyName = "WebSearchPluginUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchPluginId), TypeInfoPropertyName = "WebFetchPluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesDataCollection), TypeInfoPropertyName = "ProviderPreferencesDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName), TypeInfoPropertyName = "ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesIgnoreItems), TypeInfoPropertyName = "ProviderPreferencesIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOnlyItems), TypeInfoPropertyName = "ProviderPreferencesOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOrderItems), TypeInfoPropertyName = "ProviderPreferencesOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileLatencyCutoffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMaxLatency), TypeInfoPropertyName = "PreferredMaxLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileThroughputCutoffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMinThroughput), TypeInfoPropertyName = "PreferredMinThroughput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Quantization), TypeInfoPropertyName = "Quantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort), TypeInfoPropertyName = "ProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy), TypeInfoPropertyName = "ProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition), TypeInfoPropertyName = "ProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesSort), TypeInfoPropertyName = "ProviderPreferencesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIsType), TypeInfoPropertyName = "StopServerToolsWhenFinishReasonIsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenHasToolCallType), TypeInfoPropertyName = "StopServerToolsWhenHasToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenMaxCostType), TypeInfoPropertyName = "StopServerToolsWhenMaxCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsedType), TypeInfoPropertyName = "StopServerToolsWhenMaxTokensUsedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenStepCountIsType), TypeInfoPropertyName = "StopServerToolsWhenStepCountIsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenCondition), TypeInfoPropertyName = "StopServerToolsWhenCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType), TypeInfoPropertyName = "StopServerToolsWhenConditionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TraceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiErrorType), TypeInfoPropertyName = "ApiErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RouterAttempt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RouterParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PipelineStageType), TypeInfoPropertyName = "PipelineStageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PipelineStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RoutingStrategy), TypeInfoPropertyName = "RoutingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicIterationCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIterationType), TypeInfoPropertyName = "AnthropicCompactionUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIterationType), TypeInfoPropertyName = "AnthropicMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType), TypeInfoPropertyName = "AnthropicAdvisorMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUnknownUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUsageIteration), TypeInfoPropertyName = "AnthropicUsageIteration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSpeed), TypeInfoPropertyName = "AnthropicSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterWebSearchServerToolType), TypeInfoPropertyName = "OpenRouterWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType), TypeInfoPropertyName = "AnthropicInputTokensClearAtLeastType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensClearAtLeast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolUsesKeepType), TypeInfoPropertyName = "AnthropicToolUsesKeepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolUsesKeep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0Trigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingTurnsType), TypeInfoPropertyName = "AnthropicThinkingTurnsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingTurns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1Keep22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1Keep2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Trigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestContextManagementEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesFallbackParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItems), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItemsVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItemsVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamType), TypeInfoPropertyName = "AnthropicTextBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParamCitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageMimeType), TypeInfoPropertyName = "AnthropicImageMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlImageSourceType), TypeInfoPropertyName = "AnthropicUrlImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSource), TypeInfoPropertyName = "AnthropicImageBlockParamSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type), TypeInfoPropertyName = "AnthropicImageBlockParamSourceVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType), TypeInfoPropertyName = "AnthropicImageBlockParamSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamType), TypeInfoPropertyName = "AnthropicImageBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamCitations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType), TypeInfoPropertyName = "AnthropicBase64PdfSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSourceType), TypeInfoPropertyName = "AnthropicBase64PdfSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType), TypeInfoPropertyName = "AnthropicPlainTextSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceType), TypeInfoPropertyName = "AnthropicPlainTextSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlPdfSourceType), TypeInfoPropertyName = "AnthropicUrlPdfSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlPdfSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicFileDocumentSourceType), TypeInfoPropertyName = "AnthropicFileDocumentSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicFileDocumentSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource), TypeInfoPropertyName = "AnthropicDocumentBlockParamSource2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamType), TypeInfoPropertyName = "AnthropicDocumentBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParamCitations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParamType), TypeInfoPropertyName = "AnthropicSearchResultBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Content), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType), TypeInfoPropertyName = "AnthropicWebSearchResultBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesAdvisorToolResultBlockType), TypeInfoPropertyName = "MessagesAdvisorToolResultBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesAdvisorToolResultBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParamContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContent), TypeInfoPropertyName = "MessagesMessageParamContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamRole), TypeInfoPropertyName = "MessagesMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigEffort), TypeInfoPropertyName = "MessagesOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigFormatType), TypeInfoPropertyName = "MessagesOutputConfigFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigTaskBudgetType), TypeInfoPropertyName = "MessagesOutputConfigTaskBudgetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigTaskBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems), TypeInfoPropertyName = "MessagesRequestPluginsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant6Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant7Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsVariant8Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId), TypeInfoPropertyName = "MessagesRequestPluginsItemsDiscriminatorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestSystem), TypeInfoPropertyName = "MessagesRequestSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingDisplay), TypeInfoPropertyName = "AnthropicThinkingDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type), TypeInfoPropertyName = "MessagesRequestThinkingOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type), TypeInfoPropertyName = "MessagesRequestThinkingOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type), TypeInfoPropertyName = "MessagesRequestThinkingOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking), TypeInfoPropertyName = "MessagesRequestThinking2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice), TypeInfoPropertyName = "MessagesRequestToolChoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0InputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf1Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf2Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf3Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolUserLocationType), TypeInfoPropertyName = "AnthropicWebSearchToolUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAllowedCallersItems), TypeInfoPropertyName = "AnthropicAllowedCallersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCallersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf5Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesSearchModelsServerToolType), TypeInfoPropertyName = "MessagesSearchModelsServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesSearchModelsServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems), TypeInfoPropertyName = "MessagesRequestToolsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicContainer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionOutputType), TypeInfoPropertyName = "AnthropicBashCodeExecutionOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionResultType), TypeInfoPropertyName = "AnthropicBashCodeExecutionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode), TypeInfoPropertyName = "AnthropicBashCodeExecutionToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType), TypeInfoPropertyName = "AnthropicBashCodeExecutionToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContent), TypeInfoPropertyName = "AnthropicBashCodeExecutionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicBashCodeExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType), TypeInfoPropertyName = "AnthropicBashCodeExecutionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionOutputType), TypeInfoPropertyName = "AnthropicCodeExecutionOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionResultType), TypeInfoPropertyName = "AnthropicCodeExecutionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServerToolErrorCode), TypeInfoPropertyName = "AnthropicServerToolErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultErrorType), TypeInfoPropertyName = "AnthropicCodeExecutionToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResultType), TypeInfoPropertyName = "AnthropicEncryptedCodeExecutionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContent), TypeInfoPropertyName = "AnthropicCodeExecutionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicCodeExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType), TypeInfoPropertyName = "AnthropicCodeExecutionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCaller), TypeInfoPropertyName = "OrAnthropicNullableCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1Type), TypeInfoPropertyName = "OrAnthropicNullableCallerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2Type), TypeInfoPropertyName = "OrAnthropicNullableCallerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3Type), TypeInfoPropertyName = "OrAnthropicNullableCallerVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType), TypeInfoPropertyName = "OrAnthropicNullableCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicServerToolUseBlockType), TypeInfoPropertyName = "OrAnthropicServerToolUseBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitation), TypeInfoPropertyName = "AnthropicTextCitation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant1Type), TypeInfoPropertyName = "AnthropicTextCitationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant2Type), TypeInfoPropertyName = "AnthropicTextCitationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant3Type), TypeInfoPropertyName = "AnthropicTextCitationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant4Type), TypeInfoPropertyName = "AnthropicTextCitationVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant5Type), TypeInfoPropertyName = "AnthropicTextCitationVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationDiscriminatorType), TypeInfoPropertyName = "AnthropicTextCitationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionCreateResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionStrReplaceResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionViewResultFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionViewResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContent), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType), TypeInfoPropertyName = "AnthropicTextEditorCodeExecutionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchResultErrorType), TypeInfoPropertyName = "AnthropicToolSearchResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolReferenceType), TypeInfoPropertyName = "AnthropicToolReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchResultType), TypeInfoPropertyName = "AnthropicToolSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContent), TypeInfoPropertyName = "AnthropicToolSearchContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminatorType), TypeInfoPropertyName = "AnthropicToolSearchContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCaller), TypeInfoPropertyName = "AnthropicCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant1Type), TypeInfoPropertyName = "AnthropicCallerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant2Type), TypeInfoPropertyName = "AnthropicCallerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant3Type), TypeInfoPropertyName = "AnthropicCallerVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerDiscriminatorType), TypeInfoPropertyName = "AnthropicCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockSource), TypeInfoPropertyName = "AnthropicDocumentBlockSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockType), TypeInfoPropertyName = "AnthropicDocumentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode), TypeInfoPropertyName = "AnthropicWebFetchToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorType), TypeInfoPropertyName = "AnthropicWebFetchToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContent), TypeInfoPropertyName = "AnthropicWebFetchContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentVariant1Type), TypeInfoPropertyName = "AnthropicWebFetchContentVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminatorType), TypeInfoPropertyName = "AnthropicWebFetchContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultType), TypeInfoPropertyName = "AnthropicWebSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode), TypeInfoPropertyName = "AnthropicWebSearchToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorType), TypeInfoPropertyName = "AnthropicWebSearchToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent), TypeInfoPropertyName = "OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlock), TypeInfoPropertyName = "ORAnthropicContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant1Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant2Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant3Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant4Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant5Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant6Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant9Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant10Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant11Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant12Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant13Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant14Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminatorType), TypeInfoPropertyName = "ORAnthropicContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultRole), TypeInfoPropertyName = "MessagesResultRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory), TypeInfoPropertyName = "AnthropicRefusalStopDetailsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetailsType), TypeInfoPropertyName = "AnthropicRefusalStopDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicStopReason), TypeInfoPropertyName = "ORAnthropicStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultType), TypeInfoPropertyName = "MessagesResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServerToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServiceTier), TypeInfoPropertyName = "AnthropicServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultContextManagementAppliedEditsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponseType), TypeInfoPropertyName = "MessagesErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MetadataLevel?), TypeInfoPropertyName = "NullableMetadataLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlTtl?), TypeInfoPropertyName = "NullableAnthropicCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirectiveType?), TypeInfoPropertyName = "NullableAnthropicCacheControlDirectiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngineEnum?), TypeInfoPropertyName = "NullableWebSearchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolType?), TypeInfoPropertyName = "NullableDatetimeServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType?), TypeInfoPropertyName = "NullableImageGenerationServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchEngineEnum?), TypeInfoPropertyName = "NullableWebFetchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerToolType?), TypeInfoPropertyName = "NullableWebFetchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchQualityLevel?), TypeInfoPropertyName = "NullableSearchQualityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerToolType?), TypeInfoPropertyName = "NullableWebSearchUserLocationServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEngine?), TypeInfoPropertyName = "NullableBashServerToolEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironment?), TypeInfoPropertyName = "NullableBashServerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentVariant1Type?), TypeInfoPropertyName = "NullableBashServerToolEnvironmentVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentVariant2Type?), TypeInfoPropertyName = "NullableBashServerToolEnvironmentVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminatorType?), TypeInfoPropertyName = "NullableBashServerToolEnvironmentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BashServerToolType?), TypeInfoPropertyName = "NullableBashServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContextCompressionEngine?), TypeInfoPropertyName = "NullableContextCompressionEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine0?), TypeInfoPropertyName = "NullablePdfParserEngine02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine1?), TypeInfoPropertyName = "NullablePdfParserEngine12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserEngine?), TypeInfoPropertyName = "NullablePDFParserEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset?), TypeInfoPropertyName = "NullableResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4?), TypeInfoPropertyName = "NullableResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters?), TypeInfoPropertyName = "NullableResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource?), TypeInfoPropertyName = "NullableResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngine?), TypeInfoPropertyName = "NullableWebSearchEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginId?), TypeInfoPropertyName = "NullableWebSearchPluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginUserLocationType?), TypeInfoPropertyName = "NullableWebSearchPluginUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchPluginId?), TypeInfoPropertyName = "NullableWebFetchPluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesDataCollection?), TypeInfoPropertyName = "NullableProviderPreferencesDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName?), TypeInfoPropertyName = "NullableProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesIgnoreItems?), TypeInfoPropertyName = "NullableProviderPreferencesIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOnlyItems?), TypeInfoPropertyName = "NullableProviderPreferencesOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOrderItems?), TypeInfoPropertyName = "NullableProviderPreferencesOrderItems2")]
    internal sealed partial class AnthropicMessagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMaxLatency?), TypeInfoPropertyName = "NullablePreferredMaxLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMinThroughput?), TypeInfoPropertyName = "NullablePreferredMinThroughput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Quantization?), TypeInfoPropertyName = "NullableQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort?), TypeInfoPropertyName = "NullableProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy?), TypeInfoPropertyName = "NullableProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition?), TypeInfoPropertyName = "NullableProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesSort?), TypeInfoPropertyName = "NullableProviderPreferencesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIsType?), TypeInfoPropertyName = "NullableStopServerToolsWhenFinishReasonIsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenHasToolCallType?), TypeInfoPropertyName = "NullableStopServerToolsWhenHasToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenMaxCostType?), TypeInfoPropertyName = "NullableStopServerToolsWhenMaxCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsedType?), TypeInfoPropertyName = "NullableStopServerToolsWhenMaxTokensUsedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenStepCountIsType?), TypeInfoPropertyName = "NullableStopServerToolsWhenStepCountIsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenCondition?), TypeInfoPropertyName = "NullableStopServerToolsWhenCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType?), TypeInfoPropertyName = "NullableStopServerToolsWhenConditionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiErrorType?), TypeInfoPropertyName = "NullableApiErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PipelineStageType?), TypeInfoPropertyName = "NullablePipelineStageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RoutingStrategy?), TypeInfoPropertyName = "NullableRoutingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIterationType?), TypeInfoPropertyName = "NullableAnthropicCompactionUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIterationType?), TypeInfoPropertyName = "NullableAnthropicMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType?), TypeInfoPropertyName = "NullableAnthropicAdvisorMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUsageIteration?), TypeInfoPropertyName = "NullableAnthropicUsageIteration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSpeed?), TypeInfoPropertyName = "NullableAnthropicSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterWebSearchServerToolType?), TypeInfoPropertyName = "NullableOpenRouterWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType?), TypeInfoPropertyName = "NullableAnthropicInputTokensClearAtLeastType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolUsesKeepType?), TypeInfoPropertyName = "NullableAnthropicToolUsesKeepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf0Trigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingTurnsType?), TypeInfoPropertyName = "NullableAnthropicThinkingTurnsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf1Keep22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf1Keep2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems?), TypeInfoPropertyName = "NullableMessagesRequestContextManagementEditsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItems?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItemsVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItemsVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamCitationsItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamType?), TypeInfoPropertyName = "NullableAnthropicTextBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageMimeType?), TypeInfoPropertyName = "NullableAnthropicImageMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlImageSourceType?), TypeInfoPropertyName = "NullableAnthropicUrlImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSource?), TypeInfoPropertyName = "NullableAnthropicImageBlockParamSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type?), TypeInfoPropertyName = "NullableAnthropicImageBlockParamSourceVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicImageBlockParamSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamType?), TypeInfoPropertyName = "NullableAnthropicImageBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType?), TypeInfoPropertyName = "NullableAnthropicBase64PdfSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSourceType?), TypeInfoPropertyName = "NullableAnthropicBase64PdfSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType?), TypeInfoPropertyName = "NullableAnthropicPlainTextSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceType?), TypeInfoPropertyName = "NullableAnthropicPlainTextSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockParamSourceOneOf2Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockParamSourceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlPdfSourceType?), TypeInfoPropertyName = "NullableAnthropicUrlPdfSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicFileDocumentSourceType?), TypeInfoPropertyName = "NullableAnthropicFileDocumentSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockParamSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamType?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParamType?), TypeInfoPropertyName = "NullableAnthropicSearchResultBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Content?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf4Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType?), TypeInfoPropertyName = "NullableAnthropicWebSearchResultBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf8Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1ItemsOneOf10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesAdvisorToolResultBlockType?), TypeInfoPropertyName = "NullableMessagesAdvisorToolResultBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items?), TypeInfoPropertyName = "NullableMessagesMessageParamContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContent?), TypeInfoPropertyName = "NullableMessagesMessageParamContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamRole?), TypeInfoPropertyName = "NullableMessagesMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigEffort?), TypeInfoPropertyName = "NullableMessagesOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigFormatType?), TypeInfoPropertyName = "NullableMessagesOutputConfigFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigTaskBudgetType?), TypeInfoPropertyName = "NullableMessagesOutputConfigTaskBudgetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant6Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant7Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8Id?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsVariant8Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId?), TypeInfoPropertyName = "NullableMessagesRequestPluginsItemsDiscriminatorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestSystem?), TypeInfoPropertyName = "NullableMessagesRequestSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingDisplay?), TypeInfoPropertyName = "NullableAnthropicThinkingDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type?), TypeInfoPropertyName = "NullableMessagesRequestThinkingOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type?), TypeInfoPropertyName = "NullableMessagesRequestThinkingOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type?), TypeInfoPropertyName = "NullableMessagesRequestThinkingOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking?), TypeInfoPropertyName = "NullableMessagesRequestThinking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type?), TypeInfoPropertyName = "NullableMessagesRequestToolChoiceOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type?), TypeInfoPropertyName = "NullableMessagesRequestToolChoiceOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type?), TypeInfoPropertyName = "NullableMessagesRequestToolChoiceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type?), TypeInfoPropertyName = "NullableMessagesRequestToolChoiceOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice?), TypeInfoPropertyName = "NullableMessagesRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf1Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf2Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf3Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolUserLocationType?), TypeInfoPropertyName = "NullableAnthropicWebSearchToolUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAllowedCallersItems?), TypeInfoPropertyName = "NullableAnthropicAllowedCallersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf4Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Name?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf5Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Type?), TypeInfoPropertyName = "NullableMessagesRequestToolsItemsOneOf5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesSearchModelsServerToolType?), TypeInfoPropertyName = "NullableMessagesSearchModelsServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems?), TypeInfoPropertyName = "NullableMessagesRequestToolsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionOutputType?), TypeInfoPropertyName = "NullableAnthropicBashCodeExecutionOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionResultType?), TypeInfoPropertyName = "NullableAnthropicBashCodeExecutionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode?), TypeInfoPropertyName = "NullableAnthropicBashCodeExecutionToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType?), TypeInfoPropertyName = "NullableAnthropicBashCodeExecutionToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContent?), TypeInfoPropertyName = "NullableAnthropicBashCodeExecutionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicBashCodeExecutionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionOutputType?), TypeInfoPropertyName = "NullableAnthropicCodeExecutionOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionResultType?), TypeInfoPropertyName = "NullableAnthropicCodeExecutionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServerToolErrorCode?), TypeInfoPropertyName = "NullableAnthropicServerToolErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultErrorType?), TypeInfoPropertyName = "NullableAnthropicCodeExecutionToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResultType?), TypeInfoPropertyName = "NullableAnthropicEncryptedCodeExecutionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContent?), TypeInfoPropertyName = "NullableAnthropicCodeExecutionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicCodeExecutionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCaller?), TypeInfoPropertyName = "NullableOrAnthropicNullableCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1Type?), TypeInfoPropertyName = "NullableOrAnthropicNullableCallerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2Type?), TypeInfoPropertyName = "NullableOrAnthropicNullableCallerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3Type?), TypeInfoPropertyName = "NullableOrAnthropicNullableCallerVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType?), TypeInfoPropertyName = "NullableOrAnthropicNullableCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicServerToolUseBlockType?), TypeInfoPropertyName = "NullableOrAnthropicServerToolUseBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitation?), TypeInfoPropertyName = "NullableAnthropicTextCitation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant1Type?), TypeInfoPropertyName = "NullableAnthropicTextCitationVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant2Type?), TypeInfoPropertyName = "NullableAnthropicTextCitationVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant3Type?), TypeInfoPropertyName = "NullableAnthropicTextCitationVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant4Type?), TypeInfoPropertyName = "NullableAnthropicTextCitationVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationVariant5Type?), TypeInfoPropertyName = "NullableAnthropicTextCitationVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextCitationDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicTextCitationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionCreateResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionStrReplaceResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionViewResultFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionViewResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContent?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicTextEditorCodeExecutionContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchResultErrorType?), TypeInfoPropertyName = "NullableAnthropicToolSearchResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolReferenceType?), TypeInfoPropertyName = "NullableAnthropicToolReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchResultType?), TypeInfoPropertyName = "NullableAnthropicToolSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContent?), TypeInfoPropertyName = "NullableAnthropicToolSearchContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicToolSearchContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCaller?), TypeInfoPropertyName = "NullableAnthropicCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant1Type?), TypeInfoPropertyName = "NullableAnthropicCallerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant2Type?), TypeInfoPropertyName = "NullableAnthropicCallerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant3Type?), TypeInfoPropertyName = "NullableAnthropicCallerVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockSource?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockType?), TypeInfoPropertyName = "NullableAnthropicDocumentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode?), TypeInfoPropertyName = "NullableAnthropicWebFetchToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorType?), TypeInfoPropertyName = "NullableAnthropicWebFetchToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContent?), TypeInfoPropertyName = "NullableAnthropicWebFetchContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentVariant1Type?), TypeInfoPropertyName = "NullableAnthropicWebFetchContentVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicWebFetchContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultType?), TypeInfoPropertyName = "NullableAnthropicWebSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode?), TypeInfoPropertyName = "NullableAnthropicWebSearchToolResultErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorType?), TypeInfoPropertyName = "NullableAnthropicWebSearchToolResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent?), TypeInfoPropertyName = "NullableOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlock?), TypeInfoPropertyName = "NullableORAnthropicContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant1Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant2Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant3Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant4Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant5Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant6Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant9Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant10Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant11Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant12Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant13Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant14Type?), TypeInfoPropertyName = "NullableORAnthropicContentBlockVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminatorType?), TypeInfoPropertyName = "NullableORAnthropicContentBlockDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultRole?), TypeInfoPropertyName = "NullableMessagesResultRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory?), TypeInfoPropertyName = "NullableAnthropicRefusalStopDetailsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetailsType?), TypeInfoPropertyName = "NullableAnthropicRefusalStopDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicStopReason?), TypeInfoPropertyName = "NullableORAnthropicStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultType?), TypeInfoPropertyName = "NullableMessagesResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServiceTier?), TypeInfoPropertyName = "NullableAnthropicServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponseType?), TypeInfoPropertyName = "NullableMessagesErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.StopServerToolsWhenCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EndpointInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RouterAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.PipelineStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicUsageIteration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestContextManagementEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParamCitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicAllowedCallersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesFallbackParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicBashCodeExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicCodeExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicToolReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicContentBlock>))]
    internal sealed partial class AnthropicMessagesSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicMessagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnthropicMessagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::OpenRouter.JsonConverters.BashServerToolEnvironmentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.PDFParserEngineJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3ItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4JsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ProviderPreferencesIgnoreItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ProviderPreferencesOnlyItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ProviderPreferencesOrderItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.PreferredMaxLatencyJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.PreferredMinThroughputJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ProviderPreferencesSortJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.StopServerToolsWhenConditionJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicUsageIterationJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesMessageParamContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestSystemJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestThinkingJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicCodeExecutionContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicTextCitationJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicToolSearchContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicCallerJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicDocumentBlockSourceJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicWebFetchContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ORAnthropicContentBlockJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::OpenRouter.MetadataLevel)

                    || typeToConvert == typeof(global::OpenRouter.MetadataLevel?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlTtl)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlTtl?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlDirectiveType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlDirectiveType?)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum?)

                    || typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType?)

                    || typeToConvert == typeof(global::OpenRouter.WebFetchEngineEnum)

                    || typeToConvert == typeof(global::OpenRouter.WebFetchEngineEnum?)

                    || typeToConvert == typeof(global::OpenRouter.WebFetchServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.WebFetchServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.SearchQualityLevel)

                    || typeToConvert == typeof(global::OpenRouter.SearchQualityLevel?)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchUserLocationServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchUserLocationServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEngine)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEngine?)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.BashServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.ContextCompressionEngine)

                    || typeToConvert == typeof(global::OpenRouter.ContextCompressionEngine?)

                    || typeToConvert == typeof(global::OpenRouter.PdfParserEngine0)

                    || typeToConvert == typeof(global::OpenRouter.PdfParserEngine0?)

                    || typeToConvert == typeof(global::OpenRouter.PdfParserEngine1)

                    || typeToConvert == typeof(global::OpenRouter.PdfParserEngine1?)

                    || typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset)

                    || typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset?)

                    || typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource)

                    || typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource?)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchEngine)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchEngine?)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchPluginId)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchPluginId?)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchPluginUserLocationType)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchPluginUserLocationType?)

                    || typeToConvert == typeof(global::OpenRouter.WebFetchPluginId)

                    || typeToConvert == typeof(global::OpenRouter.WebFetchPluginId?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderPreferencesDataCollection)

                    || typeToConvert == typeof(global::OpenRouter.ProviderPreferencesDataCollection?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderName)

                    || typeToConvert == typeof(global::OpenRouter.ProviderName?)

                    || typeToConvert == typeof(global::OpenRouter.Quantization)

                    || typeToConvert == typeof(global::OpenRouter.Quantization?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSort)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSort?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition?)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIsType)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIsType?)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenHasToolCallType)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenHasToolCallType?)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxCostType)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxCostType?)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsedType)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsedType?)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenStepCountIsType)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenStepCountIsType?)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.ApiErrorType)

                    || typeToConvert == typeof(global::OpenRouter.ApiErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.PipelineStageType)

                    || typeToConvert == typeof(global::OpenRouter.PipelineStageType?)

                    || typeToConvert == typeof(global::OpenRouter.RoutingStrategy)

                    || typeToConvert == typeof(global::OpenRouter.RoutingStrategy?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicSpeed)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicSpeed?)

                    || typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolUsesKeepType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolUsesKeepType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicThinkingTurnsType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicThinkingTurnsType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageMimeType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageMimeType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicUrlImageSourceType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicUrlImageSourceType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicUrlPdfSourceType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicUrlPdfSourceType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicFileDocumentSourceType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicFileDocumentSourceType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicSearchResultBlockParamType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicSearchResultBlockParamType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesAdvisorToolResultBlockType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesAdvisorToolResultBlockType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamRole)

                    || typeToConvert == typeof(global::OpenRouter.MessagesMessageParamRole?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigEffort)

                    || typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigEffort?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigFormatType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigFormatType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigTaskBudgetType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigTaskBudgetType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8Id)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8Id?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicThinkingDisplay)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicThinkingDisplay?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolUserLocationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolUserLocationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicAllowedCallersItems)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicAllowedCallersItems?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Name)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Name?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Type)

                    || typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Type?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesSearchModelsServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesSearchModelsServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionOutputType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionOutputType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionOutputType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionOutputType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicServerToolErrorCode)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicServerToolErrorCode?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionToolResultErrorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionToolResultErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicServerToolUseBlockType)

                    || typeToConvert == typeof(global::OpenRouter.OrAnthropicServerToolUseBlockType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultErrorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolReferenceType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolReferenceType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCallerDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorType?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant6Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant6Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant9Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant9Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant10Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant10Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant11Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant11Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant12Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant12Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant13Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant13Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant14Type)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant14Type?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesResultRole)

                    || typeToConvert == typeof(global::OpenRouter.MessagesResultRole?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsType?)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicStopReason)

                    || typeToConvert == typeof(global::OpenRouter.ORAnthropicStopReason?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesResultType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesResultType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicServiceTier)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicServiceTier?)

                    || typeToConvert == typeof(global::OpenRouter.MessagesErrorResponseType)

                    || typeToConvert == typeof(global::OpenRouter.MessagesErrorResponseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.MetadataLevel))
                {
                    return new global::OpenRouter.JsonConverters.MetadataLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MetadataLevel?))
                {
                    return new global::OpenRouter.JsonConverters.MetadataLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlTtl))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCacheControlTtlJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlTtl?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCacheControlTtlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlDirectiveType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCacheControlDirectiveType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum?))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchEngineEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.DatetimeServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.DatetimeServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationServerToolOpenRouterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType?))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationServerToolOpenRouterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebFetchEngineEnum))
                {
                    return new global::OpenRouter.JsonConverters.WebFetchEngineEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebFetchEngineEnum?))
                {
                    return new global::OpenRouter.JsonConverters.WebFetchEngineEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebFetchServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.WebFetchServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebFetchServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.WebFetchServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SearchQualityLevel))
                {
                    return new global::OpenRouter.JsonConverters.SearchQualityLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SearchQualityLevel?))
                {
                    return new global::OpenRouter.JsonConverters.SearchQualityLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchUserLocationServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchUserLocationServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchUserLocationServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchUserLocationServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEngine))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEngine?))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEnvironmentVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEnvironmentVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEnvironmentVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEnvironmentVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEnvironmentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolEnvironmentDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolEnvironmentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BashServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.BashServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContextCompressionEngine))
                {
                    return new global::OpenRouter.JsonConverters.ContextCompressionEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContextCompressionEngine?))
                {
                    return new global::OpenRouter.JsonConverters.ContextCompressionEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PdfParserEngine0))
                {
                    return new global::OpenRouter.JsonConverters.PdfParserEngine0JsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PdfParserEngine0?))
                {
                    return new global::OpenRouter.JsonConverters.PdfParserEngine0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PdfParserEngine1))
                {
                    return new global::OpenRouter.JsonConverters.PdfParserEngine1JsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PdfParserEngine1?))
                {
                    return new global::OpenRouter.JsonConverters.PdfParserEngine1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset))
                {
                    return new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPresetJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset?))
                {
                    return new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource))
                {
                    return new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource?))
                {
                    return new global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchEngine))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchEngine?))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchPluginId))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchPluginIdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchPluginId?))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchPluginIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchPluginUserLocationType))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchPluginUserLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchPluginUserLocationType?))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchPluginUserLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebFetchPluginId))
                {
                    return new global::OpenRouter.JsonConverters.WebFetchPluginIdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebFetchPluginId?))
                {
                    return new global::OpenRouter.JsonConverters.WebFetchPluginIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderPreferencesDataCollection))
                {
                    return new global::OpenRouter.JsonConverters.ProviderPreferencesDataCollectionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderPreferencesDataCollection?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderPreferencesDataCollectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderName))
                {
                    return new global::OpenRouter.JsonConverters.ProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderName?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.Quantization))
                {
                    return new global::OpenRouter.JsonConverters.QuantizationJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.Quantization?))
                {
                    return new global::OpenRouter.JsonConverters.QuantizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSort))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSort?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigByJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigPartitionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigPartitionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIsType))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenFinishReasonIsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIsType?))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenFinishReasonIsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenHasToolCallType))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenHasToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenHasToolCallType?))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenHasToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxCostType))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenMaxCostTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxCostType?))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenMaxCostTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsedType))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenMaxTokensUsedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsedType?))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenMaxTokensUsedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenStepCountIsType))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenStepCountIsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenStepCountIsType?))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenStepCountIsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenConditionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.StopServerToolsWhenConditionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ApiErrorType))
                {
                    return new global::OpenRouter.JsonConverters.ApiErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ApiErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.ApiErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PipelineStageType))
                {
                    return new global::OpenRouter.JsonConverters.PipelineStageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PipelineStageType?))
                {
                    return new global::OpenRouter.JsonConverters.PipelineStageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RoutingStrategy))
                {
                    return new global::OpenRouter.JsonConverters.RoutingStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RoutingStrategy?))
                {
                    return new global::OpenRouter.JsonConverters.RoutingStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCompactionUsageIterationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCompactionUsageIterationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicAdvisorMessageUsageIterationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicAdvisorMessageUsageIterationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicSpeed))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicSpeed?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicInputTokensClearAtLeastTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicInputTokensClearAtLeastTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolUsesKeepType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolUsesKeepTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolUsesKeepType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolUsesKeepTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicThinkingTurnsType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicThinkingTurnsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicThinkingTurnsType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicThinkingTurnsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2JsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextBlockParamType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageMimeType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageMimeType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicUrlImageSourceType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicUrlImageSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicUrlImageSourceType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicUrlImageSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicImageBlockParamType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBase64PdfSourceType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicPlainTextSourceMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicPlainTextSourceMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicPlainTextSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicPlainTextSourceType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicPlainTextSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicUrlPdfSourceType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicUrlPdfSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicUrlPdfSourceType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicUrlPdfSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicFileDocumentSourceType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicFileDocumentSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicFileDocumentSourceType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicFileDocumentSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockParamType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicSearchResultBlockParamType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicSearchResultBlockParamType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchResultBlockParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchResultBlockParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesAdvisorToolResultBlockType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesAdvisorToolResultBlockTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesAdvisorToolResultBlockType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesAdvisorToolResultBlockTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamRole))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesMessageParamRole?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigEffort))
                {
                    return new global::OpenRouter.JsonConverters.MessagesOutputConfigEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigEffort?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesOutputConfigEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigFormatType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigFormatType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigTaskBudgetType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesOutputConfigTaskBudgetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesOutputConfigTaskBudgetType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesOutputConfigTaskBudgetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant1IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant1IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant2IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant2IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant3IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant3IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant4IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant4IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant5IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant5IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant6IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant6IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant7IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant7IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8Id))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant8IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant8Id?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant8IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsDiscriminatorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsDiscriminatorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicThinkingDisplay))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicThinkingDisplayJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicThinkingDisplay?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicThinkingDisplayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1NameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1NameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2NameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2NameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolUserLocationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchToolUserLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolUserLocationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchToolUserLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicAllowedCallersItems))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicAllowedCallersItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicAllowedCallersItems?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicAllowedCallersItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Name))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf5NameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Name?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf5NameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Type))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf5Type?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesSearchModelsServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesSearchModelsServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesSearchModelsServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesSearchModelsServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionOutputType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionOutputType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionOutputType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionOutputType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicServerToolErrorCode))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicServerToolErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicServerToolErrorCode?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicServerToolErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionToolResultErrorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionToolResultErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionToolResultErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionToolResultErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicEncryptedCodeExecutionResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicEncryptedCodeExecutionResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCodeExecutionContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicNullableCallerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicServerToolUseBlockType))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicServerToolUseBlockTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OrAnthropicServerToolUseBlockType?))
                {
                    return new global::OpenRouter.JsonConverters.OrAnthropicServerToolUseBlockTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextCitationDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextCitationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionCreateResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionCreateResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionStrReplaceResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionStrReplaceResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultErrorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolSearchResultErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolSearchResultErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolReferenceType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolReferenceType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolSearchResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolSearchResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolSearchContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicToolSearchContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCallerDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCallerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicDocumentBlockType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicDocumentBlockTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchToolResultErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchContentVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchContentVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebFetchContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchResultType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicWebSearchToolResultErrorType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant6Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant6TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant6Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant6TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant8TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant8TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant9Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant9TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant9Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant9TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant10Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant10TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant10Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant10TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant11Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant11TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant11Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant11TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant12Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant12TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant12Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant12TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant13Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant13TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant13Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant13TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant14Type))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant14TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockVariant14Type?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant14TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicContentBlockDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesResultRole))
                {
                    return new global::OpenRouter.JsonConverters.MessagesResultRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesResultRole?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesResultRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicRefusalStopDetailsType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicStopReason))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicStopReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ORAnthropicStopReason?))
                {
                    return new global::OpenRouter.JsonConverters.ORAnthropicStopReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesResultType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesResultType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicServiceTier))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicServiceTier?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesErrorResponseType))
                {
                    return new global::OpenRouter.JsonConverters.MessagesErrorResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.MessagesErrorResponseType?))
                {
                    return new global::OpenRouter.JsonConverters.MessagesErrorResponseTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AnthropicMessagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new AnthropicMessagesSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}