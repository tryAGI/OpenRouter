
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatDebugOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageConfig), TypeInfoPropertyName = "ImageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningFormat), TypeInfoPropertyName = "ReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptCacheBreakpointMode), TypeInfoPropertyName = "PromptCacheBreakpointMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptCacheBreakpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngineEnum), TypeInfoPropertyName = "WebSearchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorReasoningEffort), TypeInfoPropertyName = "AdvisorReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorNestedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AdvisorNestedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorServerToolOpenRouterType), TypeInfoPropertyName = "AdvisorServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorServerToolOpenRouter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentReasoningEffort), TypeInfoPropertyName = "SubagentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentNestedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentServerToolOpenRouterType), TypeInfoPropertyName = "SubagentServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentServerToolOpenRouter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolType), TypeInfoPropertyName = "DatetimeServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilesServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilesServerToolType), TypeInfoPropertyName = "FilesServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilesServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolConfigReasoningEffort), TypeInfoPropertyName = "FusionServerToolConfigReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolConfigReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolConfigToolsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolOpenRouterType), TypeInfoPropertyName = "FusionServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolOpenRouter))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptCacheOptionsMode), TypeInfoPropertyName = "PromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptCacheOptions))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServerToolUseDetails))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RequestTimeoutResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RequestTimeoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PayloadTooLargeResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PayloadTooLargeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnprocessableEntityResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnprocessableEntityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServiceUnavailableResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServiceUnavailableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail), TypeInfoPropertyName = "ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingInputAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyChatContentVideoType), TypeInfoPropertyName = "LegacyChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyChatContentVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentCacheControlType), TypeInfoPropertyName = "ChatContentCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentTextType), TypeInfoPropertyName = "ChatContentTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoType), TypeInfoPropertyName = "ChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItems), TypeInfoPropertyName = "ChatContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant1Type), TypeInfoPropertyName = "ChatContentItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant2Type), TypeInfoPropertyName = "ChatContentItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant3Type), TypeInfoPropertyName = "ChatContentItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorType), TypeInfoPropertyName = "ChatContentItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminatorMappingAssistantContent), TypeInfoPropertyName = "ChatMessagesDiscriminatorMappingAssistantContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantImagesItemsImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantImagesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnion), TypeInfoPropertyName = "ReasoningDetailUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant1Type), TypeInfoPropertyName = "ReasoningDetailUnionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant2Type), TypeInfoPropertyName = "ReasoningDetailUnionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant3Type), TypeInfoPropertyName = "ReasoningDetailUnionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant4Type), TypeInfoPropertyName = "ReasoningDetailUnionVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionDiscriminatorType), TypeInfoPropertyName = "ReasoningDetailUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCallType), TypeInfoPropertyName = "ChatToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminatorMappingDeveloperContent), TypeInfoPropertyName = "ChatMessagesDiscriminatorMappingDeveloperContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessageContent), TypeInfoPropertyName = "ChatSystemMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessageRole), TypeInfoPropertyName = "ChatSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessageContent), TypeInfoPropertyName = "ChatToolMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessageRole), TypeInfoPropertyName = "ChatToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessageContent), TypeInfoPropertyName = "ChatUserMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessageRole), TypeInfoPropertyName = "ChatUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessages), TypeInfoPropertyName = "ChatMessages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant1Role), TypeInfoPropertyName = "ChatMessagesVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant2Role), TypeInfoPropertyName = "ChatMessagesVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminatorRole), TypeInfoPropertyName = "ChatMessagesDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestModalitiesItems), TypeInfoPropertyName = "ChatRequestModalitiesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems), TypeInfoPropertyName = "ChatRequestPluginsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant6Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant7Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8Id), TypeInfoPropertyName = "ChatRequestPluginsItemsVariant8Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId), TypeInfoPropertyName = "ChatRequestPluginsItemsDiscriminatorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionContentTextType), TypeInfoPropertyName = "PredictionContentTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionContent), TypeInfoPropertyName = "PredictionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionType), TypeInfoPropertyName = "PredictionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoningEffort), TypeInfoPropertyName = "ChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum), TypeInfoPropertyName = "ChatReasoningSummaryVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatJsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormat), TypeInfoPropertyName = "ChatRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant2Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminatorType), TypeInfoPropertyName = "ChatRequestResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestServiceTier), TypeInfoPropertyName = "ChatRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestStop), TypeInfoPropertyName = "ChatRequestStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice0), TypeInfoPropertyName = "ChatToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice1), TypeInfoPropertyName = "ChatToolChoice12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice2), TypeInfoPropertyName = "ChatToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceType), TypeInfoPropertyName = "ChatNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatServerToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice), TypeInfoPropertyName = "ChatToolChoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Type), TypeInfoPropertyName = "ChatFunctionToolOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionTool0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSearchModelsServerToolType), TypeInfoPropertyName = "ChatSearchModelsServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSearchModelsServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterWebSearchServerToolType), TypeInfoPropertyName = "OpenRouterWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchShorthandType), TypeInfoPropertyName = "ChatWebSearchShorthandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchShorthand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionTool), TypeInfoPropertyName = "ChatFunctionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFinishReasonEnum), TypeInfoPropertyName = "ChatFinishReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatTokenLogprobTopLogprobsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatTokenLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatResultObject), TypeInfoPropertyName = "ChatResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MetadataLevel?), TypeInfoPropertyName = "NullableMetadataLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlTtl?), TypeInfoPropertyName = "NullableAnthropicCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirectiveType?), TypeInfoPropertyName = "NullableAnthropicCacheControlDirectiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageConfig?), TypeInfoPropertyName = "NullableImageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningFormat?), TypeInfoPropertyName = "NullableReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptCacheBreakpointMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngineEnum?), TypeInfoPropertyName = "NullableWebSearchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorReasoningEffort?), TypeInfoPropertyName = "NullableAdvisorReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AdvisorServerToolOpenRouterType?), TypeInfoPropertyName = "NullableAdvisorServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentReasoningEffort?), TypeInfoPropertyName = "NullableSubagentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubagentServerToolOpenRouterType?), TypeInfoPropertyName = "NullableSubagentServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolType?), TypeInfoPropertyName = "NullableDatetimeServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilesServerToolType?), TypeInfoPropertyName = "NullableFilesServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolConfigReasoningEffort?), TypeInfoPropertyName = "NullableFusionServerToolConfigReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FusionServerToolOpenRouterType?), TypeInfoPropertyName = "NullableFusionServerToolOpenRouterType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptCacheOptionsMode?), TypeInfoPropertyName = "NullablePromptCacheOptionsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesDataCollection?), TypeInfoPropertyName = "NullableProviderPreferencesDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName?), TypeInfoPropertyName = "NullableProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesIgnoreItems?), TypeInfoPropertyName = "NullableProviderPreferencesIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOnlyItems?), TypeInfoPropertyName = "NullableProviderPreferencesOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOrderItems?), TypeInfoPropertyName = "NullableProviderPreferencesOrderItems2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PipelineStageType?), TypeInfoPropertyName = "NullablePipelineStageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RoutingStrategy?), TypeInfoPropertyName = "NullableRoutingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail?), TypeInfoPropertyName = "NullableChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyChatContentVideoType?), TypeInfoPropertyName = "NullableLegacyChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentCacheControlType?), TypeInfoPropertyName = "NullableChatContentCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentTextType?), TypeInfoPropertyName = "NullableChatContentTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoType?), TypeInfoPropertyName = "NullableChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItems?), TypeInfoPropertyName = "NullableChatContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant1Type?), TypeInfoPropertyName = "NullableChatContentItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant2Type?), TypeInfoPropertyName = "NullableChatContentItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsVariant3Type?), TypeInfoPropertyName = "NullableChatContentItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorType?), TypeInfoPropertyName = "NullableChatContentItemsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminatorMappingAssistantContent?), TypeInfoPropertyName = "NullableChatMessagesDiscriminatorMappingAssistantContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnion?), TypeInfoPropertyName = "NullableReasoningDetailUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant1Type?), TypeInfoPropertyName = "NullableReasoningDetailUnionVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant2Type?), TypeInfoPropertyName = "NullableReasoningDetailUnionVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant3Type?), TypeInfoPropertyName = "NullableReasoningDetailUnionVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionVariant4Type?), TypeInfoPropertyName = "NullableReasoningDetailUnionVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionDiscriminatorType?), TypeInfoPropertyName = "NullableReasoningDetailUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCallType?), TypeInfoPropertyName = "NullableChatToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminatorMappingDeveloperContent?), TypeInfoPropertyName = "NullableChatMessagesDiscriminatorMappingDeveloperContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessageContent?), TypeInfoPropertyName = "NullableChatSystemMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessageRole?), TypeInfoPropertyName = "NullableChatSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessageContent?), TypeInfoPropertyName = "NullableChatToolMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessageRole?), TypeInfoPropertyName = "NullableChatToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessageContent?), TypeInfoPropertyName = "NullableChatUserMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessageRole?), TypeInfoPropertyName = "NullableChatUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessages?), TypeInfoPropertyName = "NullableChatMessages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant1Role?), TypeInfoPropertyName = "NullableChatMessagesVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesVariant2Role?), TypeInfoPropertyName = "NullableChatMessagesVariant2Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessagesDiscriminatorRole?), TypeInfoPropertyName = "NullableChatMessagesDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestModalitiesItems?), TypeInfoPropertyName = "NullableChatRequestModalitiesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems?), TypeInfoPropertyName = "NullableChatRequestPluginsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant6Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant7Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8Id?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsVariant8Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId?), TypeInfoPropertyName = "NullableChatRequestPluginsItemsDiscriminatorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionContentTextType?), TypeInfoPropertyName = "NullablePredictionContentTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionContent?), TypeInfoPropertyName = "NullablePredictionContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PredictionType?), TypeInfoPropertyName = "NullablePredictionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoningEffort?), TypeInfoPropertyName = "NullableChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum?), TypeInfoPropertyName = "NullableChatReasoningSummaryVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormat?), TypeInfoPropertyName = "NullableChatRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type?), TypeInfoPropertyName = "NullableChatRequestResponseFormatVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant2Type?), TypeInfoPropertyName = "NullableChatRequestResponseFormatVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type?), TypeInfoPropertyName = "NullableChatRequestResponseFormatVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type?), TypeInfoPropertyName = "NullableChatRequestResponseFormatVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type?), TypeInfoPropertyName = "NullableChatRequestResponseFormatVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminatorType?), TypeInfoPropertyName = "NullableChatRequestResponseFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestServiceTier?), TypeInfoPropertyName = "NullableChatRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestStop?), TypeInfoPropertyName = "NullableChatRequestStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice0?), TypeInfoPropertyName = "NullableChatToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice1?), TypeInfoPropertyName = "NullableChatToolChoice12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice2?), TypeInfoPropertyName = "NullableChatToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceType?), TypeInfoPropertyName = "NullableChatNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice?), TypeInfoPropertyName = "NullableChatToolChoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Type?), TypeInfoPropertyName = "NullableChatFunctionToolOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSearchModelsServerToolType?), TypeInfoPropertyName = "NullableChatSearchModelsServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenRouterWebSearchServerToolType?), TypeInfoPropertyName = "NullableOpenRouterWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchShorthandType?), TypeInfoPropertyName = "NullableChatWebSearchShorthandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionTool?), TypeInfoPropertyName = "NullableChatFunctionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFinishReasonEnum?), TypeInfoPropertyName = "NullableChatFinishReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatResultObject?), TypeInfoPropertyName = "NullableChatResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AdvisorNestedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.SubagentNestedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FusionServerToolConfigToolsItems>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatAssistantImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningDetailUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestModalitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatChoice>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.ImageConfigJsonConverter());
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatContentItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorMappingAssistantContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ReasoningDetailUnionJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorMappingDeveloperContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatSystemMessageContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatToolMessageContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatUserMessageContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatMessagesJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.PredictionContentJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatRequestResponseFormatJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatRequestStopJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatToolChoiceJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ChatFunctionToolJsonConverter());
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

                    || typeToConvert == typeof(global::OpenRouter.ReasoningFormat)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningFormat?)

                    || typeToConvert == typeof(global::OpenRouter.PromptCacheBreakpointMode)

                    || typeToConvert == typeof(global::OpenRouter.PromptCacheBreakpointMode?)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum)

                    || typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum?)

                    || typeToConvert == typeof(global::OpenRouter.AdvisorReasoningEffort)

                    || typeToConvert == typeof(global::OpenRouter.AdvisorReasoningEffort?)

                    || typeToConvert == typeof(global::OpenRouter.AdvisorServerToolOpenRouterType)

                    || typeToConvert == typeof(global::OpenRouter.AdvisorServerToolOpenRouterType?)

                    || typeToConvert == typeof(global::OpenRouter.SubagentReasoningEffort)

                    || typeToConvert == typeof(global::OpenRouter.SubagentReasoningEffort?)

                    || typeToConvert == typeof(global::OpenRouter.SubagentServerToolOpenRouterType)

                    || typeToConvert == typeof(global::OpenRouter.SubagentServerToolOpenRouterType?)

                    || typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.FilesServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.FilesServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.FusionServerToolConfigReasoningEffort)

                    || typeToConvert == typeof(global::OpenRouter.FusionServerToolConfigReasoningEffort?)

                    || typeToConvert == typeof(global::OpenRouter.FusionServerToolOpenRouterType)

                    || typeToConvert == typeof(global::OpenRouter.FusionServerToolOpenRouterType?)

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

                    || typeToConvert == typeof(global::OpenRouter.PromptCacheOptionsMode)

                    || typeToConvert == typeof(global::OpenRouter.PromptCacheOptionsMode?)

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

                    || typeToConvert == typeof(global::OpenRouter.PipelineStageType)

                    || typeToConvert == typeof(global::OpenRouter.PipelineStageType?)

                    || typeToConvert == typeof(global::OpenRouter.RoutingStrategy)

                    || typeToConvert == typeof(global::OpenRouter.RoutingStrategy?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail?)

                    || typeToConvert == typeof(global::OpenRouter.LegacyChatContentVideoType)

                    || typeToConvert == typeof(global::OpenRouter.LegacyChatContentVideoType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentCacheControlType)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentCacheControlType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentTextType)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentTextType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentVideoType)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentVideoType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolCallType)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolCallType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatSystemMessageRole)

                    || typeToConvert == typeof(global::OpenRouter.ChatSystemMessageRole?)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolMessageRole)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolMessageRole?)

                    || typeToConvert == typeof(global::OpenRouter.ChatUserMessageRole)

                    || typeToConvert == typeof(global::OpenRouter.ChatUserMessageRole?)

                    || typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant1Role)

                    || typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant1Role?)

                    || typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant2Role)

                    || typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant2Role?)

                    || typeToConvert == typeof(global::OpenRouter.ChatMessagesDiscriminatorRole)

                    || typeToConvert == typeof(global::OpenRouter.ChatMessagesDiscriminatorRole?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestModalitiesItems)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestModalitiesItems?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8Id)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8Id?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId?)

                    || typeToConvert == typeof(global::OpenRouter.PredictionContentTextType)

                    || typeToConvert == typeof(global::OpenRouter.PredictionContentTextType?)

                    || typeToConvert == typeof(global::OpenRouter.PredictionType)

                    || typeToConvert == typeof(global::OpenRouter.PredictionType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestReasoningEffort)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestReasoningEffort?)

                    || typeToConvert == typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum)

                    || typeToConvert == typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestServiceTier)

                    || typeToConvert == typeof(global::OpenRouter.ChatRequestServiceTier?)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolChoice0)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolChoice0?)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolChoice1)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolChoice1?)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolChoice2)

                    || typeToConvert == typeof(global::OpenRouter.ChatToolChoice2?)

                    || typeToConvert == typeof(global::OpenRouter.ChatNamedToolChoiceType)

                    || typeToConvert == typeof(global::OpenRouter.ChatNamedToolChoiceType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatFunctionToolOneOf0Type)

                    || typeToConvert == typeof(global::OpenRouter.ChatFunctionToolOneOf0Type?)

                    || typeToConvert == typeof(global::OpenRouter.ChatSearchModelsServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.ChatSearchModelsServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType)

                    || typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatWebSearchShorthandType)

                    || typeToConvert == typeof(global::OpenRouter.ChatWebSearchShorthandType?)

                    || typeToConvert == typeof(global::OpenRouter.ChatFinishReasonEnum)

                    || typeToConvert == typeof(global::OpenRouter.ChatFinishReasonEnum?)

                    || typeToConvert == typeof(global::OpenRouter.ChatResultObject)

                    || typeToConvert == typeof(global::OpenRouter.ChatResultObject?);
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

                if (typeToConvert == typeof(global::OpenRouter.ReasoningFormat))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningFormat?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PromptCacheBreakpointMode))
                {
                    return new global::OpenRouter.JsonConverters.PromptCacheBreakpointModeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PromptCacheBreakpointMode?))
                {
                    return new global::OpenRouter.JsonConverters.PromptCacheBreakpointModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.WebSearchEngineEnum?))
                {
                    return new global::OpenRouter.JsonConverters.WebSearchEngineEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AdvisorReasoningEffort))
                {
                    return new global::OpenRouter.JsonConverters.AdvisorReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AdvisorReasoningEffort?))
                {
                    return new global::OpenRouter.JsonConverters.AdvisorReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AdvisorServerToolOpenRouterType))
                {
                    return new global::OpenRouter.JsonConverters.AdvisorServerToolOpenRouterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AdvisorServerToolOpenRouterType?))
                {
                    return new global::OpenRouter.JsonConverters.AdvisorServerToolOpenRouterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SubagentReasoningEffort))
                {
                    return new global::OpenRouter.JsonConverters.SubagentReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SubagentReasoningEffort?))
                {
                    return new global::OpenRouter.JsonConverters.SubagentReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SubagentServerToolOpenRouterType))
                {
                    return new global::OpenRouter.JsonConverters.SubagentServerToolOpenRouterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SubagentServerToolOpenRouterType?))
                {
                    return new global::OpenRouter.JsonConverters.SubagentServerToolOpenRouterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.DatetimeServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatetimeServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.DatetimeServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FilesServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.FilesServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FilesServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.FilesServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FusionServerToolConfigReasoningEffort))
                {
                    return new global::OpenRouter.JsonConverters.FusionServerToolConfigReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FusionServerToolConfigReasoningEffort?))
                {
                    return new global::OpenRouter.JsonConverters.FusionServerToolConfigReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FusionServerToolOpenRouterType))
                {
                    return new global::OpenRouter.JsonConverters.FusionServerToolOpenRouterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FusionServerToolOpenRouterType?))
                {
                    return new global::OpenRouter.JsonConverters.FusionServerToolOpenRouterTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::OpenRouter.PromptCacheOptionsMode))
                {
                    return new global::OpenRouter.JsonConverters.PromptCacheOptionsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PromptCacheOptionsMode?))
                {
                    return new global::OpenRouter.JsonConverters.PromptCacheOptionsModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.LegacyChatContentVideoType))
                {
                    return new global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.LegacyChatContentVideoType?))
                {
                    return new global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentCacheControlType))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentCacheControlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentCacheControlType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentCacheControlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentTextType))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentTextType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentVideoType))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentVideoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentVideoType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentVideoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatContentItemsDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatContentItemsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningDetailUnionDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningDetailUnionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolCallType))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolCallType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatSystemMessageRole))
                {
                    return new global::OpenRouter.JsonConverters.ChatSystemMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatSystemMessageRole?))
                {
                    return new global::OpenRouter.JsonConverters.ChatSystemMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolMessageRole))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolMessageRole?))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatUserMessageRole))
                {
                    return new global::OpenRouter.JsonConverters.ChatUserMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatUserMessageRole?))
                {
                    return new global::OpenRouter.JsonConverters.ChatUserMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant1Role))
                {
                    return new global::OpenRouter.JsonConverters.ChatMessagesVariant1RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant1Role?))
                {
                    return new global::OpenRouter.JsonConverters.ChatMessagesVariant1RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant2Role))
                {
                    return new global::OpenRouter.JsonConverters.ChatMessagesVariant2RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatMessagesVariant2Role?))
                {
                    return new global::OpenRouter.JsonConverters.ChatMessagesVariant2RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatMessagesDiscriminatorRole))
                {
                    return new global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatMessagesDiscriminatorRole?))
                {
                    return new global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestModalitiesItems))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestModalitiesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestModalitiesItems?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestModalitiesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant1IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant1IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant2IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant2IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant3IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant3IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant4IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant4IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant5IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant5IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant6IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant6IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant7IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant7IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8Id))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant8IdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8Id?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant8IdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsDiscriminatorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestPluginsItemsDiscriminatorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PredictionContentTextType))
                {
                    return new global::OpenRouter.JsonConverters.PredictionContentTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PredictionContentTextType?))
                {
                    return new global::OpenRouter.JsonConverters.PredictionContentTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PredictionType))
                {
                    return new global::OpenRouter.JsonConverters.PredictionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PredictionType?))
                {
                    return new global::OpenRouter.JsonConverters.PredictionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestReasoningEffort))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestReasoningEffort?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum))
                {
                    return new global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum?))
                {
                    return new global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestResponseFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestServiceTier))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatRequestServiceTier?))
                {
                    return new global::OpenRouter.JsonConverters.ChatRequestServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolChoice0))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolChoice0JsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolChoice0?))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolChoice0NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolChoice1))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolChoice1JsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolChoice1?))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolChoice1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolChoice2))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolChoice2JsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatToolChoice2?))
                {
                    return new global::OpenRouter.JsonConverters.ChatToolChoice2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatNamedToolChoiceType))
                {
                    return new global::OpenRouter.JsonConverters.ChatNamedToolChoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatNamedToolChoiceType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatNamedToolChoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatFunctionToolOneOf0Type))
                {
                    return new global::OpenRouter.JsonConverters.ChatFunctionToolOneOf0TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatFunctionToolOneOf0Type?))
                {
                    return new global::OpenRouter.JsonConverters.ChatFunctionToolOneOf0TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatSearchModelsServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.ChatSearchModelsServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatSearchModelsServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatSearchModelsServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType))
                {
                    return new global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OpenRouterWebSearchServerToolType?))
                {
                    return new global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatWebSearchShorthandType))
                {
                    return new global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatWebSearchShorthandType?))
                {
                    return new global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatFinishReasonEnum))
                {
                    return new global::OpenRouter.JsonConverters.ChatFinishReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatFinishReasonEnum?))
                {
                    return new global::OpenRouter.JsonConverters.ChatFinishReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatResultObject))
                {
                    return new global::OpenRouter.JsonConverters.ChatResultObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ChatResultObject?))
                {
                    return new global::OpenRouter.JsonConverters.ChatResultObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}