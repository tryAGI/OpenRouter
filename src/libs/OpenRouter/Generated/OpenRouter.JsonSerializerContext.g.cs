
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
            typeof(global::OpenRouter.JsonConverters.ResponseIncludesEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseIncludesEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningTextContentTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningTextContentTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentOneOf0ItemsOneOf1DetailJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentOneOf0ItemsOneOf1DetailNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentOneOf0ItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentOneOf0ItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputVideoTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputVideoTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole3JsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRole3NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemContentItemsOneOf1DetailJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemContentItemsOneOf1DetailNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemContentItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemContentItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRole2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolCallStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetailJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetailNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileCitationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileCitationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.UrlCitationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.UrlCitationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FilePathTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FilePathTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseOutputTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponseOutputTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesRefusalContentTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesRefusalContentTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFileSearchCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFileSearchCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputImageGenerationCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputImageGenerationCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemOutputsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemOutputsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemOutputsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemOutputsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsDiscriminatorMappingComputerCallStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsDiscriminatorMappingComputerCallStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemActionSourcesItemsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemActionSourcesItemsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemActionTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemActionTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemCommandJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemCommandNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputTextEditorServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebFetchServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebFetchServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputToolSearchServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputToolSearchServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMemoryServerToolItemActionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMemoryServerToolItemActionNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMemoryServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMemoryServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMcpServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMcpServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputSearchModelsServerToolItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputSearchModelsServerToolItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ContextCompressionEngineJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ContextCompressionEngineNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.PdfParserEngine1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchPluginIdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchPluginIdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchPluginUserLocationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchPluginUserLocationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant1IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant1IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant2IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant2IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant3IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant3IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant4IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant4IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant5IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant5IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant6IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsVariant6IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesDataCollectionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesDataCollectionNullableJsonConverter),

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

            typeof(global::OpenRouter.JsonConverters.ReasoningEffortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningEffortNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryVerbosityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningSummaryVerbosityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatTextConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatTextConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonObjectConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonObjectConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonSchemaConfigTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatJsonSchemaConfigTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TextExtendedConfigVerbosityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TextExtendedConfigVerbosityNullableJsonConverter),

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

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedMode1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestToolsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestToolsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchContextSizeEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchContextSizeEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchUserLocationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreviewWebSearchUserLocationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.Preview20250311WebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.Preview20250311WebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CompoundFilterTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CompoundFilterTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolRankingOptionsRankerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolRankingOptionsRankerNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolEnvironmentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolEnvironmentNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ComputerUseServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolConnectorIdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolConnectorIdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApproval2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolTypeNullableJsonConverter),

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

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodexLocalShellToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodexLocalShellToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ShellServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ShellServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ApplyPatchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ApplyPatchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1SyntaxJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1SyntaxNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.DatetimeServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.DatetimeServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolOpenRouterTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageGenerationServerToolOpenRouterTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSearchModelsServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSearchModelsServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebFetchEngineEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebFetchEngineEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebFetchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebFetchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolOpenRouterTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchServerToolOpenRouterTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesTruncationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesTruncationNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesErrorFieldCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesErrorFieldCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.IncompleteDetailsReasonJsonConverter),

            typeof(global::OpenRouter.JsonConverters.IncompleteDetailsReasonNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role3JsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role3NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRole0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRole0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRole1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRole1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRole2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRole2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemImageGenerationCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemImageGenerationCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenResponsesResultObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenResponsesResultObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemPhase0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemPhase0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemPhase1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemPhase1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatus0JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatus0NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatus1JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatus1NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatus2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatus2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant7TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant7TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant8TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant8TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant9TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant9TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant10TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant10TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant11TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant11TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant13TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant13TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant14TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsVariant14TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ServiceTier2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.ServiceTier2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesResponseStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesResponseStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenResponsesResultToolsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenResponsesResultToolsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TruncationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.TruncationNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SpeechRequestResponseFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlTtlJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlTtlNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestCacheControlTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestCacheControlTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetailJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetailNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.LegacyChatContentVideoTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentCacheControlTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentCacheControlTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentTextTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentTextTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentVideoTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentVideoTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolCallTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolCallTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSystemMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSystemMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatUserMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatUserMessageRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesVariant1RoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesVariant1RoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesVariant2RoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesVariant2RoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestModalitiesItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestModalitiesItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant1IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant1IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant2IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant2IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant3IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant3IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant4IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant4IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant5IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant5IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant6IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsVariant6IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffortNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatVariant5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestServiceTierNullableJsonConverter),

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

            typeof(global::OpenRouter.JsonConverters.SearchQualityLevelJsonConverter),

            typeof(global::OpenRouter.JsonConverters.SearchQualityLevelNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WebSearchUserLocationServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFinishReasonEnumJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFinishReasonEnumNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatResultObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatResultObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputModalityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputModalityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelArchitectureInstructTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelArchitectureInstructTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputModalityNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelGroupJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelGroupNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ParameterJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ParameterNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EndpointStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EndpointStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InstructType2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.InstructType2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GenerationResponseDataApiTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GenerationResponseDataApiTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderResponseProviderNameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderResponseProviderNameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GuardrailIntervalNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter),

            typeof(global::OpenRouter.JsonConverters.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCacheControlDirectiveTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicInputTokensClearAtLeastTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicInputTokensClearAtLeastTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolUsesKeepTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolUsesKeepTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicThinkingTurnsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicThinkingTurnsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2JsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2NullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TriggerTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TriggerTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageMimeTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageMimeTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicUrlImageSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicUrlImageSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceMediaTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceMediaTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicPlainTextSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicUrlPdfSourceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicUrlPdfSourceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicServerToolNameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicServerToolNameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchResultBlockParamTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchResultBlockParamTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf10TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigEffortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigEffortNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigFormatTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigTaskBudgetTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesOutputConfigTaskBudgetTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant1IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant1IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant2IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant2IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant3IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant3IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant4IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant4IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant5IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant5IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant6IdJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsVariant6IdNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicSpeedJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicSpeedNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicThinkingDisplayJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicThinkingDisplayNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf0TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolUserLocationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolUserLocationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4NameNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsOneOf4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionOutputTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionOutputTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionToolResultErrorTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionOutputTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionOutputTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicServerToolErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicServerToolErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionToolResultErrorTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionToolResultErrorTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicEncryptedCodeExecutionResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicEncryptedCodeExecutionResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecution20250825CallerTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecution20250825CallerTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecution20260120CallerTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecution20260120CallerTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDirectCallerTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDirectCallerTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationVariant5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionCreateResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionCreateResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionStrReplaceResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionStrReplaceResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionToolResultErrorTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultFileTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultFileTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionViewResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchResultErrorTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchResultErrorTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolReferenceTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolReferenceTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchToolResultErrorTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchContentVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchContentVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorErrorCodeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorErrorCodeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebSearchToolResultErrorTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant1TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant1TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant2TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant2TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant3TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant3TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant4TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant5TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant5TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant6TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant6TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant7TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant7TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant8TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant8TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant9TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant9TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant10TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant10TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant11TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant11TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant12TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant12TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant13TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockVariant13TypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsCategoryJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsCategoryNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicRefusalStopDetailsTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicStopReasonJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicStopReasonNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesResultTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicServiceTierJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicServiceTierNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCompactionUsageIterationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCompactionUsageIterationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesErrorResponseTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesErrorResponseTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelsGetParametersCategoryJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ModelsGetParametersCategoryNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestAspectRatioJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestAspectRatioNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FrameImageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FrameImageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FrameImageFrameTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FrameImageFrameTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ContentPartImageTypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ContentPartImageTypeNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestResolutionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestResolutionNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoGenerationResponseStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoGenerationResponseStatusNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedAspectRatiosItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedAspectRatiosItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedFrameImagesItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedFrameImagesItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedResolutionsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedResolutionsItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedSizesItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.VideoModelSupportedSizesItemsNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WorkspaceMemberRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.WorkspaceMemberRoleNullableJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ImageConfigJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningItemStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentOneOf0ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessagePhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EasyInputMessageRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputMessageItemRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FunctionCallOutputItemOutputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesAnnotationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsOneOf5ContentOneOf0ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsOneOf5ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputFunctionCallItemStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputWebSearchCallItemActionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputCodeInterpreterCallItemOutputsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.InputsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PDFParserEngineJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestPluginsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.StoredPromptTemplateVariablesJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreferredMaxLatencyJsonConverter),

            typeof(global::OpenRouter.JsonConverters.PreferredMinThroughputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ProviderPreferencesSortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FormatsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponsesToolChoiceOneOf4TypeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedModeJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAIResponsesToolChoiceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersOneOf0ValueJsonConverter),

            typeof(global::OpenRouter.JsonConverters.FileSearchServerToolFiltersJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CodeInterpreterServerToolContainerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolAllowedToolsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.McpServerToolRequireApprovalJsonConverter),

            typeof(global::OpenRouter.JsonConverters.CustomToolFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ResponsesRequestToolsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0PhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsOneOf0RoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemRoleJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallOutputOutputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessagePhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.BaseInputsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemPhaseJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputMessageItemStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputReasoningItemStatusJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OutputItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OpenResponsesResultToolsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorMappingAssistantContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorMappingDeveloperContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatSystemMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatUserMessageContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatMessagesJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestPluginsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatRequestStopJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatToolChoiceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ChatFunctionToolJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter),

            typeof(global::OpenRouter.JsonConverters.GenerationContentDataInputJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestContextManagementEditsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceOneOf2ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentOneOf1ItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesMessageParamContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestPluginsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestSystemJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.MessagesRequestToolsItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicBashCodeExecutionContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCodeExecutionContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicCallerJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextCitationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicTextEditorCodeExecutionContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicToolSearchContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockSourceJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContentJsonConverter),

            typeof(global::OpenRouter.JsonConverters.ORAnthropicContentBlockJsonConverter),

            typeof(global::OpenRouter.JsonConverters.AnthropicUsageIterationJsonConverter),

            typeof(global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsJsonConverter),

            typeof(global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderSortJsonConverter),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProviderSortConfigBy?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProviderSortConfigPartition?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProviderPreferencesDataCollection?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.TextExtendedConfigVerbosity?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ResponsesRequestServiceTier?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ServiceTier2?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestReasoningEffort?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestServiceTier?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatUsageCompletionTokensDetails, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatUsagePromptTokensDetails, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ModelArchitectureInstructType?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.InstructType2?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.GenerationResponseDataApiType?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigEffort?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigFormat, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigTaskBudget, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestContextManagement, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AnthropicRefusalStopDetailsCategory?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultContextManagement, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>),

            typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>),

            typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageConfig), TypeInfoPropertyName = "ImageConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseIncludesEnum), TypeInfoPropertyName = "ResponseIncludesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningTextContentType), TypeInfoPropertyName = "ReasoningTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItemStatus0), TypeInfoPropertyName = "ReasoningItemStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItemStatus1), TypeInfoPropertyName = "ReasoningItemStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItemStatus2), TypeInfoPropertyName = "ReasoningItemStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItemStatus), TypeInfoPropertyName = "ReasoningItemStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningSummaryTextType), TypeInfoPropertyName = "ReasoningSummaryTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningSummaryText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItemType), TypeInfoPropertyName = "ReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningFormat), TypeInfoPropertyName = "ReasoningFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail), TypeInfoPropertyName = "EasyInputMessageContentOneOf0ItemsOneOf1Detail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Type), TypeInfoPropertyName = "EasyInputMessageContentOneOf0ItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContentOneOf0Items1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputVideoType), TypeInfoPropertyName = "InputVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContentOneOf0Items), TypeInfoPropertyName = "EasyInputMessageContentOneOf0Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageContent), TypeInfoPropertyName = "EasyInputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessagePhase0), TypeInfoPropertyName = "EasyInputMessagePhase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessagePhase1), TypeInfoPropertyName = "EasyInputMessagePhase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessagePhase), TypeInfoPropertyName = "EasyInputMessagePhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole0), TypeInfoPropertyName = "EasyInputMessageRole02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole1), TypeInfoPropertyName = "EasyInputMessageRole12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole2), TypeInfoPropertyName = "EasyInputMessageRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole3), TypeInfoPropertyName = "EasyInputMessageRole32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageRole), TypeInfoPropertyName = "EasyInputMessageRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessageType), TypeInfoPropertyName = "EasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemContentItemsOneOf1Detail), TypeInfoPropertyName = "InputMessageItemContentItemsOneOf1Detail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemContentItemsOneOf1Type), TypeInfoPropertyName = "InputMessageItemContentItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemContentItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemContentItems), TypeInfoPropertyName = "InputMessageItemContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole0), TypeInfoPropertyName = "InputMessageItemRole02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole1), TypeInfoPropertyName = "InputMessageItemRole12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole2), TypeInfoPropertyName = "InputMessageItemRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemRole), TypeInfoPropertyName = "InputMessageItemRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItemType), TypeInfoPropertyName = "InputMessageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolCallStatus), TypeInfoPropertyName = "ToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallItemType), TypeInfoPropertyName = "FunctionCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items), TypeInfoPropertyName = "FunctionCallOutputItemOutputOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1Type), TypeInfoPropertyName = "FunctionCallOutputItemOutputOneOf1ItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2Type), TypeInfoPropertyName = "FunctionCallOutputItemOutputOneOf1ItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3Type), TypeInfoPropertyName = "FunctionCallOutputItemOutputOneOf1ItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemOutput), TypeInfoPropertyName = "FunctionCallOutputItemOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItemType), TypeInfoPropertyName = "FunctionCallOutputItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FunctionCallOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileCitationType), TypeInfoPropertyName = "FileCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UrlCitationType), TypeInfoPropertyName = "UrlCitationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.URLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilePathType), TypeInfoPropertyName = "FilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesAnnotation), TypeInfoPropertyName = "OpenAIResponsesAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputTextLogprobsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputTextType), TypeInfoPropertyName = "ResponseOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponseOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponsesAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesRefusalContentType), TypeInfoPropertyName = "OpenAiResponsesRefusalContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesRefusalContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1ItemsOneOf5ContentOneOf0Items), TypeInfoPropertyName = "InputsOneOf1ItemsOneOf5ContentOneOf0Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf5ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1ItemsOneOf5Content), TypeInfoPropertyName = "InputsOneOf1ItemsOneOf5Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1Items5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1Items6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItemStatus0), TypeInfoPropertyName = "OutputFunctionCallItemStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItemStatus1), TypeInfoPropertyName = "OutputFunctionCallItemStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItemStatus2), TypeInfoPropertyName = "OutputFunctionCallItemStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItemStatus), TypeInfoPropertyName = "OutputFunctionCallItemStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItemType), TypeInfoPropertyName = "OutputFunctionCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFunctionCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchSourceType), TypeInfoPropertyName = "WebSearchSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemActionOneOf0Type), TypeInfoPropertyName = "OutputWebSearchCallItemActionOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemAction0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemActionOneOf1Type), TypeInfoPropertyName = "OutputWebSearchCallItemActionOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemAction1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemActionOneOf2Type), TypeInfoPropertyName = "OutputWebSearchCallItemActionOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemAction), TypeInfoPropertyName = "OutputWebSearchCallItemAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchStatus), TypeInfoPropertyName = "WebSearchStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItemType), TypeInfoPropertyName = "OutputWebSearchCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFileSearchCallItemType), TypeInfoPropertyName = "OutputFileSearchCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFileSearchCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationStatus), TypeInfoPropertyName = "ImageGenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputImageGenerationCallItemType), TypeInfoPropertyName = "OutputImageGenerationCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputImageGenerationCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItemsOneOf0Type), TypeInfoPropertyName = "OutputCodeInterpreterCallItemOutputsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItemsOneOf1Type), TypeInfoPropertyName = "OutputCodeInterpreterCallItemOutputsItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems), TypeInfoPropertyName = "OutputCodeInterpreterCallItemOutputsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItemType), TypeInfoPropertyName = "OutputCodeInterpreterCallItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallStatus), TypeInfoPropertyName = "OutputItemsDiscriminatorMappingComputerCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputComputerCallItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputDatetimeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItemsType), TypeInfoPropertyName = "OutputWebSearchServerToolItemActionSourcesItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchServerToolItemActionType), TypeInfoPropertyName = "OutputWebSearchServerToolItemActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchServerToolItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchServerToolItemType), TypeInfoPropertyName = "OutputWebSearchServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebSearchServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputFileSearchServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputImageGenerationServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputBrowserUseServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputBashServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputTextEditorServerToolItemCommand), TypeInfoPropertyName = "OutputTextEditorServerToolItemCommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputTextEditorServerToolItemType), TypeInfoPropertyName = "OutputTextEditorServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputTextEditorServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputApplyPatchServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebFetchServerToolItemType), TypeInfoPropertyName = "OutputWebFetchServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputWebFetchServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputToolSearchServerToolItemType), TypeInfoPropertyName = "OutputToolSearchServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputToolSearchServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMemoryServerToolItemAction), TypeInfoPropertyName = "OutputMemoryServerToolItemAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMemoryServerToolItemType), TypeInfoPropertyName = "OutputMemoryServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMemoryServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMcpServerToolItemType), TypeInfoPropertyName = "OutputMcpServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMcpServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputSearchModelsServerToolItemType), TypeInfoPropertyName = "OutputSearchModelsServerToolItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputSearchModelsServerToolItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputsOneOf1Items), TypeInfoPropertyName = "InputsOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Inputs), TypeInfoPropertyName = "Inputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModalityEnum), TypeInfoPropertyName = "OutputModalityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContextCompressionEngine), TypeInfoPropertyName = "ContextCompressionEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine0), TypeInfoPropertyName = "PdfParserEngine02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PdfParserEngine1), TypeInfoPropertyName = "PdfParserEngine12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserEngine), TypeInfoPropertyName = "PDFParserEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PDFParserOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngine), TypeInfoPropertyName = "WebSearchEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginId), TypeInfoPropertyName = "WebSearchPluginId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginUserLocationType), TypeInfoPropertyName = "WebSearchPluginUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchPluginUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItems), TypeInfoPropertyName = "ResponsesRequestPluginsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsVariant1Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsVariant2Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsVariant3Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsVariant4Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsVariant5Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6Id), TypeInfoPropertyName = "ResponsesRequestPluginsItemsVariant6Id2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StoredPromptTemplateVariables), TypeInfoPropertyName = "StoredPromptTemplateVariables2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.StoredPromptTemplate))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProviderSortConfigBy?, object>), TypeInfoPropertyName = "OneOfProviderSortConfigByObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProviderSortConfigPartition?, object>), TypeInfoPropertyName = "OneOfProviderSortConfigPartitionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferencesSort), TypeInfoPropertyName = "ProviderPreferencesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderPreferences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProviderPreferencesDataCollection?, object>), TypeInfoPropertyName = "OneOfProviderPreferencesDataCollectionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningEffort), TypeInfoPropertyName = "ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningSummaryVerbosity), TypeInfoPropertyName = "ReasoningSummaryVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestServiceTier), TypeInfoPropertyName = "ResponsesRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatTextConfigType), TypeInfoPropertyName = "FormatTextConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatTextConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonObjectConfigType), TypeInfoPropertyName = "FormatJsonObjectConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonObjectConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonSchemaConfigType), TypeInfoPropertyName = "FormatJsonSchemaConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FormatJsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Formats), TypeInfoPropertyName = "Formats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TextExtendedConfigVerbosity), TypeInfoPropertyName = "TextExtendedConfigVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TextExtendedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.TextExtendedConfigVerbosity?, object>), TypeInfoPropertyName = "OneOfTextExtendedConfigVerbosityObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice0), TypeInfoPropertyName = "OpenAiResponsesToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice1), TypeInfoPropertyName = "OpenAiResponsesToolChoice12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice2), TypeInfoPropertyName = "OpenAiResponsesToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf3Type), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type0), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf4Type02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type1), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf4Type12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type), TypeInfoPropertyName = "OpenAiResponsesToolChoiceOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponsesToolChoice4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedMode0), TypeInfoPropertyName = "ToolChoiceAllowedMode02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedMode1), TypeInfoPropertyName = "ToolChoiceAllowedMode12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedMode), TypeInfoPropertyName = "ToolChoiceAllowedMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowedType), TypeInfoPropertyName = "ToolChoiceAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ToolChoiceAllowed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesToolChoice), TypeInfoPropertyName = "OpenAIResponsesToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestToolsItemsOneOf0Type), TypeInfoPropertyName = "ResponsesRequestToolsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestToolsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchEngineEnum), TypeInfoPropertyName = "WebSearchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchDomainFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchContextSizeEnum), TypeInfoPropertyName = "SearchContextSizeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchServerToolType), TypeInfoPropertyName = "PreviewWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchUserLocationType), TypeInfoPropertyName = "PreviewWebSearchUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreviewWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Preview20250311WebSearchServerToolType), TypeInfoPropertyName = "Preview20250311WebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Preview20250311WebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyWebSearchServerToolType), TypeInfoPropertyName = "LegacyWebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationType), TypeInfoPropertyName = "WebSearchUserLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyWebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolType), TypeInfoPropertyName = "WebSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFiltersOneOf0Type), TypeInfoPropertyName = "FileSearchServerToolFiltersOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items), TypeInfoPropertyName = "FileSearchServerToolFiltersOneOf0ValueOneOf3Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFiltersOneOf0Value), TypeInfoPropertyName = "FileSearchServerToolFiltersOneOf0Value2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFilters0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CompoundFilterType), TypeInfoPropertyName = "CompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolFilters), TypeInfoPropertyName = "FileSearchServerToolFilters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolRankingOptionsRanker), TypeInfoPropertyName = "FileSearchServerToolRankingOptionsRanker2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerToolType), TypeInfoPropertyName = "FileSearchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FileSearchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ComputerUseServerToolEnvironment), TypeInfoPropertyName = "ComputerUseServerToolEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ComputerUseServerToolType), TypeInfoPropertyName = "ComputerUseServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ComputerUseServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit), TypeInfoPropertyName = "CodeInterpreterServerToolContainerOneOf1MemoryLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainerOneOf1Type), TypeInfoPropertyName = "CodeInterpreterServerToolContainerOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainer1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit?, object>), TypeInfoPropertyName = "OneOfCodeInterpreterServerToolContainerOneOf1MemoryLimitObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolContainer), TypeInfoPropertyName = "CodeInterpreterServerToolContainer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerToolType), TypeInfoPropertyName = "CodeInterpreterServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodeInterpreterServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolAllowedTools1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolAllowedTools), TypeInfoPropertyName = "McpServerToolAllowedTools2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolConnectorId), TypeInfoPropertyName = "McpServerToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApprovalOneOf0Always))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApprovalOneOf0Never))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval1), TypeInfoPropertyName = "McpServerToolRequireApproval12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval2), TypeInfoPropertyName = "McpServerToolRequireApproval22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolRequireApproval), TypeInfoPropertyName = "McpServerToolRequireApproval2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerToolType), TypeInfoPropertyName = "McpServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.McpServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolBackground), TypeInfoPropertyName = "ImageGenerationServerToolBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolInputFidelity), TypeInfoPropertyName = "ImageGenerationServerToolInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolInputImageMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolModel), TypeInfoPropertyName = "ImageGenerationServerToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolModeration), TypeInfoPropertyName = "ImageGenerationServerToolModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOutputFormat), TypeInfoPropertyName = "ImageGenerationServerToolOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolQuality), TypeInfoPropertyName = "ImageGenerationServerToolQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolSize), TypeInfoPropertyName = "ImageGenerationServerToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolType), TypeInfoPropertyName = "ImageGenerationServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationServerToolInputFidelity?, object>), TypeInfoPropertyName = "OneOfImageGenerationServerToolInputFidelityObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodexLocalShellToolType), TypeInfoPropertyName = "CodexLocalShellToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CodexLocalShellTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ShellServerToolType), TypeInfoPropertyName = "ShellServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ShellServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApplyPatchServerToolType), TypeInfoPropertyName = "ApplyPatchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApplyPatchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormatOneOf0Type), TypeInfoPropertyName = "CustomToolFormatOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormat0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormatOneOf1Syntax), TypeInfoPropertyName = "CustomToolFormatOneOf1Syntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormatOneOf1Type), TypeInfoPropertyName = "CustomToolFormatOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormat1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolFormat), TypeInfoPropertyName = "CustomToolFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomToolType), TypeInfoPropertyName = "CustomToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CustomTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerToolType), TypeInfoPropertyName = "DatetimeServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatetimeServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouterType), TypeInfoPropertyName = "ImageGenerationServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchModelsServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSearchModelsServerToolType), TypeInfoPropertyName = "ChatSearchModelsServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatSearchModelsServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchEngineEnum), TypeInfoPropertyName = "WebFetchEngineEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerToolType), TypeInfoPropertyName = "WebFetchServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebFetchServerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolOpenRouterParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolOpenRouterType), TypeInfoPropertyName = "WebSearchServerToolOpenRouterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchServerToolOpenRouter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequestToolsItems), TypeInfoPropertyName = "ResponsesRequestToolsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TraceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesTruncation), TypeInfoPropertyName = "OpenAIResponsesTruncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestServiceTier?, object>), TypeInfoPropertyName = "OneOfResponsesRequestServiceTierObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesErrorFieldCode), TypeInfoPropertyName = "ResponsesErrorFieldCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ResponsesErrorField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.IncompleteDetailsReason), TypeInfoPropertyName = "IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.IncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Content), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase0), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Phase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Phase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Phase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role0), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role1), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role2), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role3), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Role2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Type), TypeInfoPropertyName = "BaseInputsOneOf1ItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItems), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1Type), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2Type), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3Type), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4Type), TypeInfoPropertyName = "OpenAiResponseInputMessageItemContentItemsVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole0), TypeInfoPropertyName = "OpenAiResponseInputMessageItemRole02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole1), TypeInfoPropertyName = "OpenAiResponseInputMessageItemRole12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole2), TypeInfoPropertyName = "OpenAiResponseInputMessageItemRole22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole), TypeInfoPropertyName = "OpenAiResponseInputMessageItemRole2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseInputMessageItemType), TypeInfoPropertyName = "OpenAiResponseInputMessageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponseInputMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseInputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallOutputOutputOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1Type), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3Type), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutput), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallOutputOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallOutputType), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponseFunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAiResponseFunctionToolCallType), TypeInfoPropertyName = "OpenAiResponseFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponseFunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemImageGenerationCallType), TypeInfoPropertyName = "OutputItemImageGenerationCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemImageGenerationCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageContentItems), TypeInfoPropertyName = "OutputMessageContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessagePhase0), TypeInfoPropertyName = "OutputMessagePhase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessagePhase1), TypeInfoPropertyName = "OutputMessagePhase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessagePhase), TypeInfoPropertyName = "OutputMessagePhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageRole), TypeInfoPropertyName = "OutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus0), TypeInfoPropertyName = "OutputMessageStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus1), TypeInfoPropertyName = "OutputMessageStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus2), TypeInfoPropertyName = "OutputMessageStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageStatus), TypeInfoPropertyName = "OutputMessageStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageType), TypeInfoPropertyName = "OutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputsOneOf1Items), TypeInfoPropertyName = "BaseInputsOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseInputs), TypeInfoPropertyName = "BaseInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenResponsesResultObject), TypeInfoPropertyName = "OpenResponsesResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemContentItems), TypeInfoPropertyName = "OutputMessageItemContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemPhase0), TypeInfoPropertyName = "OutputMessageItemPhase02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemPhase1), TypeInfoPropertyName = "OutputMessageItemPhase12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemPhase), TypeInfoPropertyName = "OutputMessageItemPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemRole), TypeInfoPropertyName = "OutputMessageItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemStatus0), TypeInfoPropertyName = "OutputMessageItemStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemStatus1), TypeInfoPropertyName = "OutputMessageItemStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemStatus2), TypeInfoPropertyName = "OutputMessageItemStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemStatus), TypeInfoPropertyName = "OutputMessageItemStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputMessageItemType), TypeInfoPropertyName = "OutputMessageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItemStatus0), TypeInfoPropertyName = "OutputReasoningItemStatus02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItemStatus1), TypeInfoPropertyName = "OutputReasoningItemStatus12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItemStatus2), TypeInfoPropertyName = "OutputReasoningItemStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItemStatus), TypeInfoPropertyName = "OutputReasoningItemStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputReasoningItemType), TypeInfoPropertyName = "OutputReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItems), TypeInfoPropertyName = "OutputItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant2Type), TypeInfoPropertyName = "OutputItemsVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant7Type), TypeInfoPropertyName = "OutputItemsVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant8Type), TypeInfoPropertyName = "OutputItemsVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant9Type), TypeInfoPropertyName = "OutputItemsVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant10Type), TypeInfoPropertyName = "OutputItemsVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant11Type), TypeInfoPropertyName = "OutputItemsVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant13Type), TypeInfoPropertyName = "OutputItemsVariant13Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant14Type), TypeInfoPropertyName = "OutputItemsVariant14Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BaseReasoningConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServiceTier2), TypeInfoPropertyName = "ServiceTier22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenAIResponsesResponseStatus), TypeInfoPropertyName = "OpenAIResponsesResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenResponsesResultToolsItemsOneOf0Type), TypeInfoPropertyName = "OpenResponsesResultToolsItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenResponsesResultToolsItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenResponsesResultToolsItems), TypeInfoPropertyName = "OpenResponsesResultToolsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Truncation), TypeInfoPropertyName = "Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UsageCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OpenResponsesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ServiceTier2?, object>), TypeInfoPropertyName = "OneOfServiceTier2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesResultToolsItems>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ActivityItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SpeechRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SpeechRequestResponseFormat), TypeInfoPropertyName = "SpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.STTInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SttRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.STTRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.STTUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.STTResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlTtl), TypeInfoPropertyName = "AnthropicCacheControlTtl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestCacheControlType), TypeInfoPropertyName = "ChatRequestCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatDebugOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatAudioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingFileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail), TypeInfoPropertyName = "ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentItemsDiscriminatorMappingInputAudioInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.LegacyChatContentVideoType), TypeInfoPropertyName = "LegacyChatContentVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentCacheControlType), TypeInfoPropertyName = "ChatContentCacheControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentCacheControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentTextType), TypeInfoPropertyName = "ChatContentTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatContentVideoType), TypeInfoPropertyName = "ChatContentVideoType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningDetailUnionDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoningEffort), TypeInfoPropertyName = "ChatRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatReasoningSummaryVerbosityEnum), TypeInfoPropertyName = "ChatReasoningSummaryVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatRequestReasoningEffort?, object>), TypeInfoPropertyName = "OneOfChatRequestReasoningEffortObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatJsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormat), TypeInfoPropertyName = "ChatRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant1Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant3Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant4Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatVariant5Type), TypeInfoPropertyName = "ChatRequestResponseFormatVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestResponseFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestServiceTier), TypeInfoPropertyName = "ChatRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatRequestStop), TypeInfoPropertyName = "ChatRequestStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice0), TypeInfoPropertyName = "ChatToolChoice02")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice1), TypeInfoPropertyName = "ChatToolChoice12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice2), TypeInfoPropertyName = "ChatToolChoice22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoiceType), TypeInfoPropertyName = "ChatNamedToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatNamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatToolChoice), TypeInfoPropertyName = "ChatToolChoice2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionToolOneOf0Type), TypeInfoPropertyName = "ChatFunctionToolOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatFunctionTool0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SearchQualityLevel), TypeInfoPropertyName = "SearchQualityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerToolType), TypeInfoPropertyName = "WebSearchUserLocationServerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WebSearchUserLocationServerTool))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatRequestServiceTier?, object>), TypeInfoPropertyName = "OneOfChatRequestServiceTierObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatUsageCompletionTokensDetails, object>), TypeInfoPropertyName = "OneOfChatUsageCompletionTokensDetailsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ChatUsagePromptTokensDetails, object>), TypeInfoPropertyName = "OneOfChatUsagePromptTokensDetailsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ChatResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreditsGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreditsGetCreditsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?, object>), TypeInfoPropertyName = "OneOfEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputModality), TypeInfoPropertyName = "InputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelArchitectureInstructType), TypeInfoPropertyName = "ModelArchitectureInstructType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModality), TypeInfoPropertyName = "OutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelGroup), TypeInfoPropertyName = "ModelGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelArchitecture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ModelArchitectureInstructType?, object>), TypeInfoPropertyName = "OneOfModelArchitectureInstructTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DefaultParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PerRequestLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Parameter), TypeInfoPropertyName = "Parameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TopProviderInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointStatus), TypeInfoPropertyName = "EndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpointThroughputLast30M))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointsListEndpointsZdrResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InstructType2), TypeInfoPropertyName = "InstructType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListEndpointsResponseArchitecture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.InstructType2?, object>), TypeInfoPropertyName = "OneOfInstructType2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EndpointsListEndpointsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseDataApiType), TypeInfoPropertyName = "GenerationResponseDataApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponseProviderName), TypeInfoPropertyName = "ProviderResponseProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.GenerationResponseDataApiType?, object>), TypeInfoPropertyName = "OneOfGenerationResponseDataApiTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput), TypeInfoPropertyName = "GenerationContentDataInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GuardrailInterval), TypeInfoPropertyName = "GuardrailInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Guardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListGuardrailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DeleteGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListKeyAssignmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MemberAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListMemberAssignmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ApiKeysGetCurrentKeyResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirectiveType), TypeInfoPropertyName = "AnthropicCacheControlDirectiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheControlDirective))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2TriggerType), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf2TriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Trigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItemsOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItems), TypeInfoPropertyName = "MessagesRequestContextManagementEditsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestContextManagementEditsItems>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type), TypeInfoPropertyName = "AnthropicDocumentBlockParamSourceOneOf2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlPdfSourceType), TypeInfoPropertyName = "AnthropicUrlPdfSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUrlPdfSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamSource), TypeInfoPropertyName = "AnthropicDocumentBlockParamSource2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParamType), TypeInfoPropertyName = "AnthropicDocumentBlockParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDocumentBlockParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>), TypeInfoPropertyName = "OneOfAnthropicDocumentBlockParamCitationsObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServerToolName), TypeInfoPropertyName = "AnthropicServerToolName2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigEffort?, object>), TypeInfoPropertyName = "OneOfMessagesOutputConfigEffortObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigFormat, object>), TypeInfoPropertyName = "OneOfMessagesOutputConfigFormatObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigTaskBudget, object>), TypeInfoPropertyName = "OneOfMessagesOutputConfigTaskBudgetObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestServiceTier), TypeInfoPropertyName = "MessagesRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSpeed), TypeInfoPropertyName = "AnthropicSpeed2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4AllowedCallersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Name), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItemsOneOf4Type), TypeInfoPropertyName = "MessagesRequestToolsItemsOneOf4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequestToolsItems), TypeInfoPropertyName = "MessagesRequestToolsItems2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestContextManagement, object>), TypeInfoPropertyName = "OneOfMessagesRequestContextManagementObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecution20250825CallerType), TypeInfoPropertyName = "AnthropicCodeExecution20250825CallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCodeExecution20260120CallerType), TypeInfoPropertyName = "AnthropicCodeExecution20260120CallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicDirectCallerType), TypeInfoPropertyName = "AnthropicDirectCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCaller), TypeInfoPropertyName = "AnthropicCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCallerDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchResultErrorType), TypeInfoPropertyName = "AnthropicToolSearchResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolReferenceType), TypeInfoPropertyName = "AnthropicToolReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchResultType), TypeInfoPropertyName = "AnthropicToolSearchResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContent), TypeInfoPropertyName = "AnthropicToolSearchContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicToolSearchContentDiscriminator))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant7Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8Type), TypeInfoPropertyName = "ORAnthropicContentBlockVariant8Type2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultRole), TypeInfoPropertyName = "MessagesResultRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetailsCategory), TypeInfoPropertyName = "AnthropicRefusalStopDetailsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetailsType), TypeInfoPropertyName = "AnthropicRefusalStopDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicRefusalStopDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.AnthropicRefusalStopDetailsCategory?, object>), TypeInfoPropertyName = "OneOfAnthropicRefusalStopDetailsCategoryObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ORAnthropicStopReason), TypeInfoPropertyName = "ORAnthropicStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultType), TypeInfoPropertyName = "MessagesResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServerToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicServiceTier), TypeInfoPropertyName = "AnthropicServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicIterationCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIterationType), TypeInfoPropertyName = "AnthropicCompactionUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIterationType), TypeInfoPropertyName = "AnthropicMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUnknownUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUsageIteration), TypeInfoPropertyName = "AnthropicUsageIteration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultContextManagementAppliedEditsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResultContextManagement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.MessagesResultContextManagement, object>), TypeInfoPropertyName = "OneOfMessagesResultContextManagementObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponseType), TypeInfoPropertyName = "MessagesErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MessagesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersCategory), TypeInfoPropertyName = "ModelsGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsCountResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole), TypeInfoPropertyName = "OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OrganizationListOrganizationMembersResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems), TypeInfoPropertyName = "ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters), TypeInfoPropertyName = "ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>), TypeInfoPropertyName = "OneOfProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProvidersListProvidersResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderSort), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?, object>), TypeInfoPropertyName = "OneOfRerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankCreateRerankResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestAspectRatio), TypeInfoPropertyName = "VideoGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageType), TypeInfoPropertyName = "FrameImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageFrameType), TypeInfoPropertyName = "FrameImageFrameType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartImageType), TypeInfoPropertyName = "ContentPartImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestProviderOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestResolution), TypeInfoPropertyName = "VideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationResponseStatus), TypeInfoPropertyName = "VideoGenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems), TypeInfoPropertyName = "VideoModelSupportedAspectRatiosItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems), TypeInfoPropertyName = "VideoModelSupportedFrameImagesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedResolutionsItems), TypeInfoPropertyName = "VideoModelSupportedResolutionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedSizesItems), TypeInfoPropertyName = "VideoModelSupportedSizesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatiosItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolutionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSizesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Workspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListWorkspacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateWorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateWorkspaceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetWorkspaceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DeleteWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateWorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateWorkspaceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAddWorkspaceMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WorkspaceMemberRole), TypeInfoPropertyName = "WorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.WorkspaceMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAddWorkspaceMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkRemoveWorkspaceMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkRemoveWorkspaceMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ExchangeAuthCodeForApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>), TypeInfoPropertyName = "OneOfAuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateAuthKeysCodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>), TypeInfoPropertyName = "OneOfKeysPostRequestBodyContentApplicationJsonSchemaLimitResetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OneOf<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>), TypeInfoPropertyName = "OneOfKeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateRerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningSummaryText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EasyInputMessageContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponsesAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputsOneOf1ItemsOneOf5ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.WebSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponseIncludesEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputModalityEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OpenAiResponseInputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputMessageContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputMessageItemContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OpenResponsesResultToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatAssistantImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningDetailUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestModalitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatFunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ChatChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.PublicEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestContextManagementEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParamCitationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestToolsItemsOneOf4AllowedCallersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestPluginsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicBashCodeExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicCodeExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicToolReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextCitation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicUsageIteration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FrameImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ContentPartImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedAspectRatiosItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedFrameImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedResolutionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedSizesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Workspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.WorkspaceMember>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}