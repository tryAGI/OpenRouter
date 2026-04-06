
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
            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningTextContentTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningTextContentTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole3JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole3NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputImageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputImageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputImageDetailJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputImageDetailNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputFileTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputFileTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputAudioTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputAudioTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputAudioInputAudioFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputAudioInputAudioFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputVideoTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputVideoTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseOutputTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseOutputTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileCitationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileCitationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.UrlCitationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.UrlCitationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesRefusalContentTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesRefusalContentTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFileSearchCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFileSearchCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemImageGenerationCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemImageGenerationCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputDatetimeItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputDatetimeItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputDatetimeItemStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputDatetimeItemStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputServerToolItemStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputServerToolItemStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchContextSizeEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchContextSizeEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchUserLocationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchUserLocationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.Preview20250311WebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.Preview20250311WebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolRankingOptionsRankerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolRankingOptionsRankerNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolEnvironmentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolEnvironmentNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolConnectorIdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolConnectorIdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolBackgroundJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolBackgroundNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolInputFidelityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolInputFidelityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolModelJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolModelNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolModerationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolModerationNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolOutputFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolOutputFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolQualityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolQualityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolSizeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolSizeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodexLocalShellToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodexLocalShellToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ShellServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ShellServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ApplyPatchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ApplyPatchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1SyntaxJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1SyntaxNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.DatetimeServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.DatetimeServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolOpenRouterTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolOpenRouterTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoice0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoice0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoice1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoice1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoice2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoice2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatTextConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatTextConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonObjectConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonObjectConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonSchemaConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonSchemaConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TextConfigVerbosityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TextConfigVerbosityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningEffortEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningEffortEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryVerbosityEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryVerbosityEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseIncludesEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseIncludesEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesTruncationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesTruncationNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.DataCollectionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.DataCollectionNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderNameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderNameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.QuantizationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.QuantizationNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderSortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderSortNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderSortConfigByJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderSortConfigByNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderSortConfigPartitionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderSortConfigPartitionNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf0IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf0IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf1IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf1IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf2IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf2IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf3IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf3IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf4IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf4IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf5IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsOneOf5IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ContextCompressionEngineJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ContextCompressionEngineNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseResponsesResultObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseResponsesResultObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesResponseStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesResponseStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesErrorFieldCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesErrorFieldCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.IncompleteDetailsReasonJsonConverter),

            typeof(global::OpenRouter.JsonConverters.IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role3JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role3NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolCallStatusEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolCallStatusEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ServiceTierEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ServiceTierEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TruncationEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TruncationEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationCharLocationParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationCharLocationParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationPageLocationParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationPageLocationParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationContentBlockLocationParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationContentBlockLocationParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationWebSearchResultLocationParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationWebSearchResultLocationParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationSearchResultLocationParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCitationSearchResultLocationParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlTtlJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlTtlNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchQualityLevelJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchQualityLevelNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigEffortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigEffortNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64ImageSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64ImageSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageMimeTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageMimeTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceMediaTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceMediaTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchResultBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchResultBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicInputTokensClearAtLeastTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicInputTokensClearAtLeastTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolUsesKeepTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolUsesKeepTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicInputTokensTriggerTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicInputTokensTriggerTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicThinkingTurnsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicThinkingTurnsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf0IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf0IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf1IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf1IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf2IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf2IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf3IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf3IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf4IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf4IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf5IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsOneOf5IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestSpeedJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestSpeedNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceResponseMediaTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceResponseMediaTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceResponseTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceResponseTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf11TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf11TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf12TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf12TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultStopReasonJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultStopReasonNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageSpeedJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageSpeedNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageIterationsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageIterationsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageIterationsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageIterationsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageSpeedJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageSpeedNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageIterationsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageIterationsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageIterationsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageIterationsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultProviderJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultProviderNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesErrorResponseTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesErrorResponseTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf0IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf0IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf1IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf1IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf2IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf2IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf3IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf3IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf4IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf4IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf5IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsOneOf5IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSystemMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSystemMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatUserMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatUserMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentImageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentImageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentImageImageUrlDetailJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentImageImageUrlDetailNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentAudioTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentAudioTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentVideoTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentVideoTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentFileTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentFileTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatDeveloperMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatDeveloperMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatAssistantMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatAssistantMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailSummaryTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailSummaryTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailSummaryFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailSummaryFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailEncryptedTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailEncryptedTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailEncryptedFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailEncryptedFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailTextFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailTextFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffortNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatTextConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatTextConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatJsonSchemaConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatJsonSchemaConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatGrammarConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatGrammarConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatPythonConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFormatPythonConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoice0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoice0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoice1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoice1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoice2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoice2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatNamedToolChoiceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatNamedToolChoiceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFunctionToolOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFunctionToolOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestModalitiesItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestModalitiesItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFinishReasonEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFinishReasonEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatResultObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatResultObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataApiTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataApiTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderResponseProviderNameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderResponseProviderNameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelsGetParametersCategoryJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelsGetParametersCategoryNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelGroupJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelGroupNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelArchitectureInstructTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelArchitectureInstructTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputModalityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputModalityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ParameterJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ParameterNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InstructType2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InstructType2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EndpointStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EndpointStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GuardrailIntervalNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentOneOf0ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesAnnotationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsOneOf5ContentOneOf0ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsOneOf5ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemFunctionCallStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemWebSearchCallActionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0ValueJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolAllowedToolsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApprovalJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestToolsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedModeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesToolChoiceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestImageConfigJsonConverter),

            typeof(global::OpenRouter.JsonConverters.StoredPromptTemplateVariablesJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestProviderOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestProviderOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestProviderIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestProviderSortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreferredMinThroughputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreferredMaxLatencyJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PDFParserEngineJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseResponsesResultOutputItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0RoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0PhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1RoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf1ContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf2OutputOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf2OutputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseResponsesResultToolsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestSystemJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestProviderOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestProviderOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestProviderIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseMessagesResultUsageIterationsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultUsageIterationsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestProviderOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestProviderOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestProviderIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSystemMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatUserMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatDeveloperMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatAssistantMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestStopJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoiceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFunctionToolJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestImageConfigJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ReasoningItemFormat?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.OutputReasoningItemFormat?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.TextConfigVerbosity?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProviderSortConfigBy?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProviderSortConfigPartition?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ResponsesRequestServiceTier?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ResponsesRequestProvider, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.TextConfigVerbosity?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.OutputReasoningItemFormat?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigEffort?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigFormat, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestContextManagement, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestProvider, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitations, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf1CacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf2CacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageCacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageServerToolUse, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageServiceTier?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultUsageSpeed?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf0CacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf1CacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf2CacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageCacheCreation, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageServerToolUse, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageSpeed?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageCostDetails, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultContainer, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.BaseMessagesResultStopReason?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ReasoningDetailSummaryFormat?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ReasoningDetailEncryptedFormat?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ReasoningDetailTextFormat?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestReasoningEffort?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestProvider, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestServiceTier?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatUsageCompletionTokensDetails, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatUsagePromptTokensDetails, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.GenerationGetResponsesContentApplicationJsonSchemaDataApiType?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ModelArchitectureInstructType?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>),

            typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemReasoningType), TypeInfoPropertyName = "OutputItemReasoningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningTextContentType), TypeInfoPropertyName = "ReasoningTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningSummaryTextType), TypeInfoPropertyName = "ReasoningSummaryTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningSummaryText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemReasoningStatus0), TypeInfoPropertyName = "OutputItemReasoningStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemReasoningStatus1), TypeInfoPropertyName = "OutputItemReasoningStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemReasoningStatus2), TypeInfoPropertyName = "OutputItemReasoningStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemReasoningStatus), TypeInfoPropertyName = "OutputItemReasoningStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItemFormat), TypeInfoPropertyName = "ReasoningItemFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ReasoningItemFormat?, object>), TypeInfoPropertyName = "OneOfReasoningItemFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageType), TypeInfoPropertyName = "EasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole0), TypeInfoPropertyName = "EasyInputMessageRole02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole1), TypeInfoPropertyName = "EasyInputMessageRole12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole2), TypeInfoPropertyName = "EasyInputMessageRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole3), TypeInfoPropertyName = "EasyInputMessageRole32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole), TypeInfoPropertyName = "EasyInputMessageRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputTextType), TypeInfoPropertyName = "InputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputImageType), TypeInfoPropertyName = "InputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputImageDetail), TypeInfoPropertyName = "InputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContentOneOf0Items1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputFileType), TypeInfoPropertyName = "InputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputAudioType), TypeInfoPropertyName = "InputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputAudioInputAudioFormat), TypeInfoPropertyName = "InputAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputVideoType), TypeInfoPropertyName = "InputVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContentOneOf0Items), TypeInfoPropertyName = "EasyInputMessageContentOneOf0Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContent), TypeInfoPropertyName = "EasyInputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessagePhase0), TypeInfoPropertyName = "EasyInputMessagePhase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessagePhase1), TypeInfoPropertyName = "EasyInputMessagePhase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessagePhase), TypeInfoPropertyName = "EasyInputMessagePhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemType), TypeInfoPropertyName = "InputMessageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole0), TypeInfoPropertyName = "InputMessageItemRole02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole1), TypeInfoPropertyName = "InputMessageItemRole12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole2), TypeInfoPropertyName = "InputMessageItemRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole), TypeInfoPropertyName = "InputMessageItemRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemContentItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemContentItems), TypeInfoPropertyName = "InputMessageItemContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallItemType), TypeInfoPropertyName = "FunctionCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemType), TypeInfoPropertyName = "FunctionCallOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items), TypeInfoPropertyName = "FunctionCallOutputItemOutputOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutput), TypeInfoPropertyName = "FunctionCallOutputItemOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageRole), TypeInfoPropertyName = "OutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageType), TypeInfoPropertyName = "OutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus0), TypeInfoPropertyName = "OutputMessageStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus1), TypeInfoPropertyName = "OutputMessageStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus2), TypeInfoPropertyName = "OutputMessageStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus), TypeInfoPropertyName = "OutputMessageStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputTextType), TypeInfoPropertyName = "ResponseOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileCitationType), TypeInfoPropertyName = "FileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UrlCitationType), TypeInfoPropertyName = "UrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.URLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilePathType), TypeInfoPropertyName = "FilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesAnnotation), TypeInfoPropertyName = "OpenAIResponsesAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputTextLogprobsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponsesAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesRefusalContentType), TypeInfoPropertyName = "OpenAiResponsesRefusalContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesRefusalContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageContentItems), TypeInfoPropertyName = "OutputMessageContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessagePhase0), TypeInfoPropertyName = "OutputMessagePhase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessagePhase1), TypeInfoPropertyName = "OutputMessagePhase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessagePhase), TypeInfoPropertyName = "OutputMessagePhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1ItemsOneOf5ContentOneOf0Items), TypeInfoPropertyName = "InputsOneOf1ItemsOneOf5ContentOneOf0Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf5ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1ItemsOneOf5Content), TypeInfoPropertyName = "InputsOneOf1ItemsOneOf5Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1Items5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItemFormat), TypeInfoPropertyName = "OutputReasoningItemFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1Items6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.OutputReasoningItemFormat?, object>), TypeInfoPropertyName = "OneOfOutputReasoningItemFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFunctionCallType), TypeInfoPropertyName = "OutputItemFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFunctionCallStatus0), TypeInfoPropertyName = "OutputItemFunctionCallStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFunctionCallStatus1), TypeInfoPropertyName = "OutputItemFunctionCallStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFunctionCallStatus2), TypeInfoPropertyName = "OutputItemFunctionCallStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFunctionCallStatus), TypeInfoPropertyName = "OutputItemFunctionCallStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallType), TypeInfoPropertyName = "OutputItemWebSearchCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallActionOneOf0Type), TypeInfoPropertyName = "OutputItemWebSearchCallActionOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchSourceType), TypeInfoPropertyName = "WebSearchSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallAction0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallActionOneOf1Type), TypeInfoPropertyName = "OutputItemWebSearchCallActionOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallAction1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallActionOneOf2Type), TypeInfoPropertyName = "OutputItemWebSearchCallActionOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCallAction), TypeInfoPropertyName = "OutputItemWebSearchCallAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchStatus), TypeInfoPropertyName = "WebSearchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFileSearchCallType), TypeInfoPropertyName = "OutputItemFileSearchCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFileSearchCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemImageGenerationCallType), TypeInfoPropertyName = "OutputItemImageGenerationCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationStatus), TypeInfoPropertyName = "ImageGenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputImageGenerationCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputDatetimeItemType), TypeInfoPropertyName = "OutputDatetimeItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputDatetimeItemStatus), TypeInfoPropertyName = "OutputDatetimeItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputDatetimeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputServerToolItemStatus), TypeInfoPropertyName = "OutputServerToolItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1Items), TypeInfoPropertyName = "InputsOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Inputs), TypeInfoPropertyName = "Inputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestToolsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchServerToolType), TypeInfoPropertyName = "PreviewWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchContextSizeEnum), TypeInfoPropertyName = "SearchContextSizeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchUserLocationType), TypeInfoPropertyName = "PreviewWebSearchUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngineEnum), TypeInfoPropertyName = "WebSearchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchDomainFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Preview20250311WebSearchServerToolType), TypeInfoPropertyName = "Preview20250311WebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Preview20250311WebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyWebSearchServerToolType), TypeInfoPropertyName = "LegacyWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationType), TypeInfoPropertyName = "WebSearchUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolType), TypeInfoPropertyName = "WebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolType), TypeInfoPropertyName = "FileSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFiltersOneOf0Type), TypeInfoPropertyName = "FileSearchServerToolFiltersOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items), TypeInfoPropertyName = "FileSearchServerToolFiltersOneOf0ValueOneOf3Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFiltersOneOf0Value), TypeInfoPropertyName = "FileSearchServerToolFiltersOneOf0Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFilters0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CompoundFilterType), TypeInfoPropertyName = "CompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFilters), TypeInfoPropertyName = "FileSearchServerToolFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolRankingOptionsRanker), TypeInfoPropertyName = "FileSearchServerToolRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ComputerUseServerToolType), TypeInfoPropertyName = "ComputerUseServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ComputerUseServerToolEnvironment), TypeInfoPropertyName = "ComputerUseServerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ComputerUseServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolType), TypeInfoPropertyName = "CodeInterpreterServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainerOneOf1Type), TypeInfoPropertyName = "CodeInterpreterServerToolContainerOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit), TypeInfoPropertyName = "CodeInterpreterServerToolContainerOneOf1MemoryLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainer1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>), TypeInfoPropertyName = "OneOfCodeInterpreterServerToolContainerOneOf1MemoryLimitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainer), TypeInfoPropertyName = "CodeInterpreterServerToolContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolType), TypeInfoPropertyName = "McpServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolAllowedTools1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolAllowedTools), TypeInfoPropertyName = "McpServerToolAllowedTools2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolConnectorId), TypeInfoPropertyName = "McpServerToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApprovalOneOf0Never))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApprovalOneOf0Always))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval1), TypeInfoPropertyName = "McpServerToolRequireApproval12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval2), TypeInfoPropertyName = "McpServerToolRequireApproval22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval), TypeInfoPropertyName = "McpServerToolRequireApproval2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolType), TypeInfoPropertyName = "ImageGenerationServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolBackground), TypeInfoPropertyName = "ImageGenerationServerToolBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolInputFidelity), TypeInfoPropertyName = "ImageGenerationServerToolInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolInputImageMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolModel), TypeInfoPropertyName = "ImageGenerationServerToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolModeration), TypeInfoPropertyName = "ImageGenerationServerToolModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOutputFormat), TypeInfoPropertyName = "ImageGenerationServerToolOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolQuality), TypeInfoPropertyName = "ImageGenerationServerToolQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolSize), TypeInfoPropertyName = "ImageGenerationServerToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>), TypeInfoPropertyName = "OneOfImageGenerationServerToolInputFidelityObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodexLocalShellToolType), TypeInfoPropertyName = "CodexLocalShellToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodexLocalShellTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ShellServerToolType), TypeInfoPropertyName = "ShellServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ShellServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApplyPatchServerToolType), TypeInfoPropertyName = "ApplyPatchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApplyPatchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolType), TypeInfoPropertyName = "CustomToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormatOneOf0Type), TypeInfoPropertyName = "CustomToolFormatOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormat0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormatOneOf1Type), TypeInfoPropertyName = "CustomToolFormatOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormatOneOf1Syntax), TypeInfoPropertyName = "CustomToolFormatOneOf1Syntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormat1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormat), TypeInfoPropertyName = "CustomToolFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolType), TypeInfoPropertyName = "DatetimeServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolOpenRouterType), TypeInfoPropertyName = "WebSearchServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolOpenRouterParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolOpenRouter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestToolsItems), TypeInfoPropertyName = "ResponsesRequestToolsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice0), TypeInfoPropertyName = "OpenAiResponsesToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice1), TypeInfoPropertyName = "OpenAiResponsesToolChoice12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice2), TypeInfoPropertyName = "OpenAiResponsesToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf3Type), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type0), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf4Type02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type1), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf4Type12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedType), TypeInfoPropertyName = "ToolChoiceAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedMode0), TypeInfoPropertyName = "ToolChoiceAllowedMode02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedMode1), TypeInfoPropertyName = "ToolChoiceAllowedMode12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedMode), TypeInfoPropertyName = "ToolChoiceAllowedMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesToolChoice), TypeInfoPropertyName = "OpenAIResponsesToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatTextConfigType), TypeInfoPropertyName = "FormatTextConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatTextConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonObjectConfigType), TypeInfoPropertyName = "FormatJsonObjectConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonObjectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonSchemaConfigType), TypeInfoPropertyName = "FormatJsonSchemaConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Formats), TypeInfoPropertyName = "Formats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TextConfigVerbosity), TypeInfoPropertyName = "TextConfigVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TextExtendedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.TextConfigVerbosity?, object>), TypeInfoPropertyName = "OneOfTextConfigVerbosityObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningSummaryVerbosityEnum), TypeInfoPropertyName = "ReasoningSummaryVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestImageConfig), TypeInfoPropertyName = "ResponsesRequestImageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModalityEnum), TypeInfoPropertyName = "OutputModalityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StoredPromptTemplateVariables), TypeInfoPropertyName = "StoredPromptTemplateVariables2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StoredPromptTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseIncludesEnum), TypeInfoPropertyName = "ResponseIncludesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestServiceTier), TypeInfoPropertyName = "ResponsesRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesTruncation), TypeInfoPropertyName = "OpenAIResponsesTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DataCollection), TypeInfoPropertyName = "DataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName), TypeInfoPropertyName = "ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderOrderItems), TypeInfoPropertyName = "ResponsesRequestProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderOnlyItems), TypeInfoPropertyName = "ResponsesRequestProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderIgnoreItems), TypeInfoPropertyName = "ResponsesRequestProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Quantization), TypeInfoPropertyName = "Quantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort), TypeInfoPropertyName = "ProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy), TypeInfoPropertyName = "ProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition), TypeInfoPropertyName = "ProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProviderSortConfigBy?, object>), TypeInfoPropertyName = "OneOfProviderSortConfigByObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProviderSortConfigPartition?, object>), TypeInfoPropertyName = "OneOfProviderSortConfigPartitionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderSort), TypeInfoPropertyName = "ResponsesRequestProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderMaxPriceCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderMaxPriceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderMaxPriceAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderMaxPriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileThroughputCutoffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMinThroughput), TypeInfoPropertyName = "PreferredMinThroughput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileLatencyCutoffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMaxLatency), TypeInfoPropertyName = "PreferredMaxLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsOneOf0Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsOneOf0Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsOneOf1Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsOneOf1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsOneOf2Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsOneOf2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngine), TypeInfoPropertyName = "WebSearchEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsOneOf3Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsOneOf3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine0), TypeInfoPropertyName = "PdfParserEngine02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine1), TypeInfoPropertyName = "PdfParserEngine12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserEngine), TypeInfoPropertyName = "PDFParserEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsOneOf4Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsOneOf4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsOneOf5Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsOneOf5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContextCompressionEngine), TypeInfoPropertyName = "ContextCompressionEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems), TypeInfoPropertyName = "ResponsesRequestPluginsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestServiceTier?, object>), TypeInfoPropertyName = "OneOfResponsesRequestServiceTierObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestProvider, object>), TypeInfoPropertyName = "OneOfResponsesRequestProviderObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultObject), TypeInfoPropertyName = "BaseResponsesResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesResponseStatus), TypeInfoPropertyName = "OpenAIResponsesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemWebSearchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemFileSearchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemImageGenerationCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultOutputItems), TypeInfoPropertyName = "BaseResponsesResultOutputItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesErrorFieldCode), TypeInfoPropertyName = "ResponsesErrorFieldCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesErrorField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.IncompleteDetailsReason), TypeInfoPropertyName = "IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.IncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role0), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role1), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role2), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role3), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Content), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase0), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Phase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Phase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Phase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf1Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf1Role0), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf1Role02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf1Role1), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf1Role12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf1Role2), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf1Role22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf1Role), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf1Role2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf1ContentItems), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf1ContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1ItemsOneOf1ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf2Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf2Output), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf2Output2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolCallStatusEnum), TypeInfoPropertyName = "ToolCallStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf3Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf3Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items), TypeInfoPropertyName = "BaseInputsOneOf1Items2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultInstructions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultToolsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultToolsItems), TypeInfoPropertyName = "BaseResponsesResultToolsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultReasoningEffort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultReasoningSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServiceTierEnum), TypeInfoPropertyName = "ServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseResponsesResultTruncation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TextConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItems), TypeInfoPropertyName = "OutputItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UsageCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputs), TypeInfoPropertyName = "BaseInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseReasoningConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TruncationEnum), TypeInfoPropertyName = "TruncationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenResponsesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseResponsesResultToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod), TypeInfoPropertyName = "AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OAuthExchangeAuthCodeForAPIKeyResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod), TypeInfoPropertyName = "AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType), TypeInfoPropertyName = "AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AuthKeysCodePostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OAuthCreateAuthKeysCodeResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ConflictResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ConflictResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamType), TypeInfoPropertyName = "AnthropicTextBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationCharLocationParamType), TypeInfoPropertyName = "AnthropicCitationCharLocationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationCharLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationPageLocationParamType), TypeInfoPropertyName = "AnthropicCitationPageLocationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationPageLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParamType), TypeInfoPropertyName = "AnthropicCitationContentBlockLocationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType), TypeInfoPropertyName = "AnthropicCitationWebSearchResultLocationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationSearchResultLocationParamType), TypeInfoPropertyName = "AnthropicCitationSearchResultLocationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCitationSearchResultLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItems), TypeInfoPropertyName = "AnthropicTextBlockParamCitationsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirectiveType), TypeInfoPropertyName = "AnthropicCacheControlDirectiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlTtl), TypeInfoPropertyName = "AnthropicCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirective))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicTextBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParamCitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestSystem), TypeInfoPropertyName = "MessagesRequestSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0InputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf0Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf1Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf1Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf2Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf2Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf3Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf3Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4AllowedCallersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesWebSearchServerToolType), TypeInfoPropertyName = "MessagesWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchQualityLevel), TypeInfoPropertyName = "SearchQualityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerToolType), TypeInfoPropertyName = "WebSearchUserLocationServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems), TypeInfoPropertyName = "MessagesRequestToolsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf0Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf1Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf2Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoiceOneOf3Type), TypeInfoPropertyName = "MessagesRequestToolChoiceOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolChoice), TypeInfoPropertyName = "MessagesRequestToolChoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf0Type), TypeInfoPropertyName = "MessagesRequestThinkingOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf1Type), TypeInfoPropertyName = "MessagesRequestThinkingOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinkingOneOf2Type), TypeInfoPropertyName = "MessagesRequestThinkingOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestThinking), TypeInfoPropertyName = "MessagesRequestThinking2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestServiceTier), TypeInfoPropertyName = "MessagesRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigEffort), TypeInfoPropertyName = "MessagesOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigFormatType), TypeInfoPropertyName = "MessagesOutputConfigFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfigFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigEffort?, object>), TypeInfoPropertyName = "OneOfMessagesOutputConfigEffortObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigFormat, object>), TypeInfoPropertyName = "OneOfMessagesOutputConfigFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamRole), TypeInfoPropertyName = "MessagesMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamType), TypeInfoPropertyName = "AnthropicImageBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64ImageSourceType), TypeInfoPropertyName = "AnthropicBase64ImageSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageMimeType), TypeInfoPropertyName = "AnthropicImageMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64ImageSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParamSource), TypeInfoPropertyName = "AnthropicImageBlockParamSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicImageBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamType), TypeInfoPropertyName = "AnthropicDocumentBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSourceType), TypeInfoPropertyName = "AnthropicBase64PdfSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSourceMediaType), TypeInfoPropertyName = "AnthropicBase64PdfSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicBase64PdfSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceType), TypeInfoPropertyName = "AnthropicPlainTextSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceMediaType), TypeInfoPropertyName = "AnthropicPlainTextSourceMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource), TypeInfoPropertyName = "AnthropicDocumentBlockParamSource2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamCitations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>), TypeInfoPropertyName = "OneOfAnthropicDocumentBlockParamCitationsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParamType), TypeInfoPropertyName = "AnthropicSearchResultBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParamCitations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSearchResultBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Content), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf4Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Name), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf7Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultBlockParamType), TypeInfoPropertyName = "AnthropicWebSearchResultBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicWebSearchResultBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf8Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1ItemsOneOf10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items), TypeInfoPropertyName = "MessagesMessageParamContentOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParamContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParamContent), TypeInfoPropertyName = "MessagesMessageParamContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensClearAtLeastType), TypeInfoPropertyName = "AnthropicInputTokensClearAtLeastType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensClearAtLeast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolUsesKeepType), TypeInfoPropertyName = "AnthropicToolUsesKeepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolUsesKeep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensTriggerType), TypeInfoPropertyName = "AnthropicInputTokensTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicInputTokensTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf0Trigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingTurnsType), TypeInfoPropertyName = "AnthropicThinkingTurnsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicThinkingTurns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1Keep22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf1Keep2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Trigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestContextManagementEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderDataCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderOrderItems), TypeInfoPropertyName = "MessagesRequestProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderOnlyItems), TypeInfoPropertyName = "MessagesRequestProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderIgnoreItems), TypeInfoPropertyName = "MessagesRequestProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderMaxPriceCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderMaxPriceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderMaxPriceAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderMaxPriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsOneOf0Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsOneOf0Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsOneOf1Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsOneOf1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsOneOf2Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsOneOf2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsOneOf3Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsOneOf3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsOneOf4Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsOneOf4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsOneOf5Id), TypeInfoPropertyName = "MessagesRequestPluginsItemsOneOf5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItems), TypeInfoPropertyName = "MessagesRequestPluginsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestSpeed), TypeInfoPropertyName = "MessagesRequestSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestContextManagement, object>), TypeInfoPropertyName = "OneOfMessagesRequestContextManagementObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestProvider, object>), TypeInfoPropertyName = "OneOfMessagesRequestProviderObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultType), TypeInfoPropertyName = "BaseMessagesResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultRole), TypeInfoPropertyName = "BaseMessagesResultRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContainer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf0CitationsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1CallerOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf1CallerOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1Caller0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1CallerOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf1CallerOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1Caller1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1CallerOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf1CallerOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1Caller2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf1Caller), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf1Caller2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf3Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4CallerOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf4CallerOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4Caller0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4CallerOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf4CallerOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4Caller1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4CallerOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf4CallerOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4Caller2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4Caller), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf4Caller2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf4Name), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf4Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5CallerOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5CallerOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Caller0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5CallerOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5CallerOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Caller1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5CallerOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5CallerOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Caller2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Caller), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5Caller2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5ContentOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf5Content), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf5Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6CallerOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6CallerOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Caller0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6CallerOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6CallerOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Caller1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6CallerOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6CallerOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Caller2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Caller), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6Caller2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Content0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceResponseMediaType), TypeInfoPropertyName = "AnthropicPlainTextSourceResponseMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceResponseType), TypeInfoPropertyName = "AnthropicPlainTextSourceResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicPlainTextSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitations, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentCitationsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6Content), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf6Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCode), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7ContentOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7Content0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7ContentOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7Content2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf7Content), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf7Content2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf8ContentOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8Content0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf8ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf8Content), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf8Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9ContentOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9ContentOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9Content0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9ContentOneOf1FileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9ContentOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9ContentOneOf2Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9ContentOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9Content2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9ContentOneOf3Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9ContentOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9Content3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf9Content), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf9Content2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf10ContentOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10Content0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf10ContentOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10Content1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf10Content), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf10Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf11Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf12Type), TypeInfoPropertyName = "BaseMessagesResultContentItemsOneOf12Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultContentItems), TypeInfoPropertyName = "BaseMessagesResultContentItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultStopReason), TypeInfoPropertyName = "BaseMessagesResultStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageServerToolUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageServiceTier), TypeInfoPropertyName = "BaseMessagesResultUsageServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageSpeed), TypeInfoPropertyName = "BaseMessagesResultUsageSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf0Type), TypeInfoPropertyName = "BaseMessagesResultUsageIterationsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageIterationsItemsOneOf0CacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf1CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf1Type), TypeInfoPropertyName = "BaseMessagesResultUsageIterationsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf1CacheCreation, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageIterationsItemsOneOf1CacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf2CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageIterationsItemsOneOf2CacheCreation, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageIterationsItemsOneOf2CacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsageIterationsItems), TypeInfoPropertyName = "BaseMessagesResultUsageIterationsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseMessagesResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageCacheCreation, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageCacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageServerToolUse, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageServerToolUseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageServiceTier?, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageServiceTierObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultUsageSpeed?, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultUsageSpeedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultUsageIterationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageServerToolUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageSpeed), TypeInfoPropertyName = "MessagesResultUsageSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItemsOneOf0CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItemsOneOf0Type), TypeInfoPropertyName = "MessagesResultUsageIterationsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf0CacheCreation, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageIterationsItemsOneOf0CacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItemsOneOf1CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItemsOneOf1Type), TypeInfoPropertyName = "MessagesResultUsageIterationsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf1CacheCreation, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageIterationsItemsOneOf1CacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItemsOneOf2CacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf2CacheCreation, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageIterationsItemsOneOf2CacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageIterationsItems), TypeInfoPropertyName = "MessagesResultUsageIterationsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsageCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageCacheCreation, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageCacheCreationObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageServerToolUse, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageServerToolUseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageSpeed?, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageSpeedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultUsageIterationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageCostDetails, object>), TypeInfoPropertyName = "OneOfMessagesResultUsageCostDetailsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultProvider), TypeInfoPropertyName = "MessagesResultProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultContainer, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultContainerObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseMessagesResultContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.BaseMessagesResultStopReason?, object>), TypeInfoPropertyName = "OneOfBaseMessagesResultStopReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponseType), TypeInfoPropertyName = "MessagesErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ActivityItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderDataCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderOrderItems), TypeInfoPropertyName = "ChatRequestProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderOnlyItems), TypeInfoPropertyName = "ChatRequestProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderIgnoreItems), TypeInfoPropertyName = "ChatRequestProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderMaxPriceCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderMaxPriceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderMaxPriceAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderMaxPriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsOneOf0Id), TypeInfoPropertyName = "ChatRequestPluginsItemsOneOf0Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsOneOf1Id), TypeInfoPropertyName = "ChatRequestPluginsItemsOneOf1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsOneOf2Id), TypeInfoPropertyName = "ChatRequestPluginsItemsOneOf2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsOneOf3Id), TypeInfoPropertyName = "ChatRequestPluginsItemsOneOf3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsOneOf4Id), TypeInfoPropertyName = "ChatRequestPluginsItemsOneOf4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsOneOf5Id), TypeInfoPropertyName = "ChatRequestPluginsItemsOneOf5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItems), TypeInfoPropertyName = "ChatRequestPluginsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessageRole), TypeInfoPropertyName = "ChatSystemMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentTextType), TypeInfoPropertyName = "ChatContentTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessageContent), TypeInfoPropertyName = "ChatSystemMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessageRole), TypeInfoPropertyName = "ChatUserMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentImageType), TypeInfoPropertyName = "ChatContentImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentImageImageUrlDetail), TypeInfoPropertyName = "ChatContentImageImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentAudioType), TypeInfoPropertyName = "ChatContentAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyChatContentVideoType), TypeInfoPropertyName = "LegacyChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyChatContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoType), TypeInfoPropertyName = "ChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentFileType), TypeInfoPropertyName = "ChatContentFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItems), TypeInfoPropertyName = "ChatContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessageContent), TypeInfoPropertyName = "ChatUserMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatDeveloperMessageRole), TypeInfoPropertyName = "ChatDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatDeveloperMessageContent), TypeInfoPropertyName = "ChatDeveloperMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatDeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantMessageRole), TypeInfoPropertyName = "ChatAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantMessageContent), TypeInfoPropertyName = "ChatAssistantMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCallType), TypeInfoPropertyName = "ChatToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailSummaryType), TypeInfoPropertyName = "ReasoningDetailSummaryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailSummaryFormat), TypeInfoPropertyName = "ReasoningDetailSummaryFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ReasoningDetailSummaryFormat?, object>), TypeInfoPropertyName = "OneOfReasoningDetailSummaryFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailEncryptedType), TypeInfoPropertyName = "ReasoningDetailEncryptedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailEncryptedFormat), TypeInfoPropertyName = "ReasoningDetailEncryptedFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailEncrypted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ReasoningDetailEncryptedFormat?, object>), TypeInfoPropertyName = "OneOfReasoningDetailEncryptedFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailTextType), TypeInfoPropertyName = "ReasoningDetailTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailTextFormat), TypeInfoPropertyName = "ReasoningDetailTextFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ReasoningDetailTextFormat?, object>), TypeInfoPropertyName = "OneOfReasoningDetailTextFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnion), TypeInfoPropertyName = "ReasoningDetailUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantImagesItemsImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantImagesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessageRole), TypeInfoPropertyName = "ChatToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessageContent), TypeInfoPropertyName = "ChatToolMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatMessages), TypeInfoPropertyName = "ChatMessages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatModelNamesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatModelNamesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoningEffort), TypeInfoPropertyName = "ChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum), TypeInfoPropertyName = "ChatReasoningSummaryVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatRequestReasoningEffort?, object>), TypeInfoPropertyName = "OneOfChatRequestReasoningEffortObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatTextConfigType), TypeInfoPropertyName = "ChatFormatTextConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatTextConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatJsonSchemaConfigType), TypeInfoPropertyName = "ChatFormatJsonSchemaConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatJsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatJsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatGrammarConfigType), TypeInfoPropertyName = "ChatFormatGrammarConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatGrammarConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatPythonConfigType), TypeInfoPropertyName = "ChatFormatPythonConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFormatPythonConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormat), TypeInfoPropertyName = "ChatRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestStop), TypeInfoPropertyName = "ChatRequestStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice0), TypeInfoPropertyName = "ChatToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice1), TypeInfoPropertyName = "ChatToolChoice12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice2), TypeInfoPropertyName = "ChatToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceType), TypeInfoPropertyName = "ChatNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice), TypeInfoPropertyName = "ChatToolChoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Type), TypeInfoPropertyName = "ChatFunctionToolOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionTool0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchServerToolType), TypeInfoPropertyName = "ChatWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchShorthandType), TypeInfoPropertyName = "ChatWebSearchShorthandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatWebSearchShorthand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionTool), TypeInfoPropertyName = "ChatFunctionTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatDebugOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestImageConfig), TypeInfoPropertyName = "ChatRequestImageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestModalitiesItems), TypeInfoPropertyName = "ChatRequestModalitiesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestServiceTier), TypeInfoPropertyName = "ChatRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatRequestProvider, object>), TypeInfoPropertyName = "OneOfChatRequestProviderObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatRequestServiceTier?, object>), TypeInfoPropertyName = "OneOfChatRequestServiceTierObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFinishReasonEnum), TypeInfoPropertyName = "ChatFinishReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatTokenLogprobTopLogprobsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatTokenLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatResultObject), TypeInfoPropertyName = "ChatResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatUsageCompletionTokensDetails, object>), TypeInfoPropertyName = "OneOfChatUsageCompletionTokensDetailsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatUsagePromptTokensDetails, object>), TypeInfoPropertyName = "OneOfChatUsagePromptTokensDetailsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreditsGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreditsGetCreditsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GoneResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GoneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationGetResponsesContentApplicationJsonSchemaDataApiType), TypeInfoPropertyName = "GenerationGetResponsesContentApplicationJsonSchemaDataApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponseProviderName), TypeInfoPropertyName = "ProviderResponseProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.GenerationGetResponsesContentApplicationJsonSchemaDataApiType?, object>), TypeInfoPropertyName = "OneOfGenerationGetResponsesContentApplicationJsonSchemaDataApiTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationsGetGenerationResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsCountResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersCategory), TypeInfoPropertyName = "ModelsGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingImageToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingImageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingInputAudioCache))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingInternalReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingInputCacheRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricingInputCacheWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelGroup), TypeInfoPropertyName = "ModelGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelArchitectureInstructType), TypeInfoPropertyName = "ModelArchitectureInstructType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputModality), TypeInfoPropertyName = "InputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModality), TypeInfoPropertyName = "OutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelArchitecture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ModelArchitectureInstructType?, object>), TypeInfoPropertyName = "OneOfModelArchitectureInstructTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TopProviderInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PerRequestLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Parameter), TypeInfoPropertyName = "Parameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DefaultParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListEndpointsResponseArchitectureTokenizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InstructType2), TypeInfoPropertyName = "InstructType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListEndpointsResponseArchitecture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingImageToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingImageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingInputAudioCache))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingInternalReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingInputCacheRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricingInputCacheWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointQuantization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointStatus), TypeInfoPropertyName = "EndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointThroughputLast30M))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointsListEndpointsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointsListEndpointsZdrResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters), TypeInfoPropertyName = "ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems), TypeInfoPropertyName = "ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>), TypeInfoPropertyName = "OneOfProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersListProvidersResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysListResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset), TypeInfoPropertyName = "KeysPostRequestBodyContentApplicationJsonSchemaLimitReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysPostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysCreateKeysResponse201))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysHashGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysGetKeyResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysDeleteKeysResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset), TypeInfoPropertyName = "KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysHashPatchResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysUpdateKeysResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysGetCurrentKeyResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole), TypeInfoPropertyName = "OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrganizationListOrganizationMembersResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GuardrailInterval), TypeInfoPropertyName = "GuardrailInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Guardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListGuardrailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailRequestResetInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponseDataResetInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponseDataResetInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DeleteGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailRequestResetInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponseDataResetInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListKeyAssignmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MemberAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListMemberAssignmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesDataCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOrderItems), TypeInfoPropertyName = "ProviderPreferencesOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesOnlyItems), TypeInfoPropertyName = "ProviderPreferencesOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesIgnoreItems), TypeInfoPropertyName = "ProviderPreferencesIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesMaxPriceCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesMaxPriceImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesMaxPriceAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesMaxPriceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankCreateRerankResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ExchangeAuthCodeForApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>), TypeInfoPropertyName = "OneOfAuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateAuthKeysCodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>), TypeInfoPropertyName = "OneOfKeysPostRequestBodyContentApplicationJsonSchemaLimitResetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>), TypeInfoPropertyName = "OneOfKeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateRerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningSummaryText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EasyInputMessageContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponsesAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputsOneOf1ItemsOneOf5ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.WebSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputModalityEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponseIncludesEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputMessageContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1ItemsOneOf1ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseResponsesResultToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParamCitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestContextManagementEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItemsOneOf0CitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItemsOneOf5ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultUsageIterationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesResultUsageIterationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseMessagesResultContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningDetailUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatAssistantImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatModelNamesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestModalitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.PublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}