
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MetadataLevel? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlTtl? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirectiveType? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirective? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDebugOptions? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageConfig? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseIncludesEnum? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContentType? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContent? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus0? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus1? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus2? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextType? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryText? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningFormat? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItem? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpointMode? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpoint? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputText? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Type? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageContentOneOf0Items1? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFile? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudio? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideo? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageContentOneOf0Items? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EasyInputMessageContentOneOf0Items>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageContent? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhase0? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhase1? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhase? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRole0? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRole1? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRole2? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRole3? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRole? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessage? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemContentItemsOneOf1Detail? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemContentItemsOneOf1Type? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemContentItems1? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemContentItems? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRole0? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRole1? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRole2? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRole? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItem? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputMessageItemContentItems>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolCallStatus? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItem? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant1Type? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant2Type? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsVariant3Type? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsDiscriminator? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutputOneOf1ItemsDiscriminatorType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemOutput? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemType? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItem? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant1? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant1Type? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant2? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant2Type? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant3? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationVariant3Type? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminator? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallStatus? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItem? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemStatus? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemType? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItem? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitationType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitation? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UrlCitationType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitation? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePathType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePath? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesAnnotation? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprobsItems? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputText? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponsesAnnotation>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobsItems>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesRefusalContentType? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContent? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1ItemsOneOf7Content? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items7? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items8? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemStatus0? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemStatus1? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemStatus2? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemStatus? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItem? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItem? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSourceType? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSource? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemActionOneOf0Type? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemAction0? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemActionOneOf1Type? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemAction1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemActionOneOf2Type? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemAction2? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemAction? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchStatus? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItemType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItem? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItemType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItem? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationStatus? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItemType? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItem? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItemsOneOf0Type? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItemsOneOf1Type? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItem? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallStatus? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItem? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItem? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItemsType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionType? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemAction? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItem? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItem? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItem? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItem? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItem? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemCommand? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemType? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItem? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItem? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItemType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItem? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItem? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemAction? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItem? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMcpServerToolItemType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMcpServerToolItem? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItemType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItem? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradictionsItemsStancesItems? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradictionsItems? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionsItemsStancesItems>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultPartialCoverageItems? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultUniqueInsightsItems? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResult? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionsItems>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItems>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsightsItems>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionResponsesItems? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionSource? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItem? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionResponsesItems>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionSource>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItem? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItemType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItem? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItem? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemActionType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemAction? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItem? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItemType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItem? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemAction? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItem? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemOutputItems? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItem? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputItemOutputItems>? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemToolsItems? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItem? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.McpListToolsItemToolsItems>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItemType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItem? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItemType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItem? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItemType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItem? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItemType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItem? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1Type? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2Type? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3Type? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemOutput? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItem? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItemType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItem? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItemType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItem? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItemType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItem? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemRole? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolsItemsOneOf0Type? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolsItems0? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngineEnum? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchDomainFilter? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchContextSizeEnum? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerToolType? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocationType? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocation? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerTool? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerToolType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerTool? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerToolType? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationType? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocation? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerTool? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerTool? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFiltersOneOf0Type? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFiltersOneOf0Value? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFilters0? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilterType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilter? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFilters? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptionsRanker? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptions? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerTool? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolEnvironment? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerTool? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerOneOf1MemoryLimit? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerOneOf1Type? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainer1? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainer? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerTool? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolAllowedTools1? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolAllowedTools? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolConnectorId? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalOneOf0Always? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalOneOf0Never? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApproval0? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApproval1? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApproval2? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApproval? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerTool? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolBackground? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputFidelity? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputImageMask? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolModeration? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOutputFormat? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolQuality? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerTool? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellToolType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellTool? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerTool? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerTool? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatOneOf0Type? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormat0? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatOneOf1Syntax? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatOneOf1Type? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormat1? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormat? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomTool? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolAllowedCallersItems? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionTool? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCallersItems>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceToolToolsItems? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceToolType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceTool? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceToolToolsItems>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorReasoningEffort? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorReasoning? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorNestedTool? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolConfig? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AdvisorNestedTool>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouterType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouter? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoningEffort? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoning? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentNestedTool? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolConfig? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouterType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouter? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolConfig? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerTool? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolConfig? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerTool? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoningEffort? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoning? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigToolsItems? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfig? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigToolsItems>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouterType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouter? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolConfig? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouterType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolConfig? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouterType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouter? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchEngineEnum? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolConfig? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolType? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerTool? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchQualityLevel? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerToolType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerTool? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolConfig? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouterType? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouter? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchEngineEnum? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolConfig? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouterType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouter? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEngine? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironment? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentVariant1? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentVariant1Type? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentVariant2? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentVariant2Type? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminator? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminatorType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolConfig? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerTool? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEngine? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironment? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentVariant1? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentVariant1Type? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentVariant2? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentVariant2Type? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminator? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolConfig? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouterType? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouter? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolsItems27? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolsItems? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemType? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItem? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AdditionalToolsItemToolsItems>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemAgent? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItemsOneOf1Detail? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItemsOneOf1Type? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItems1? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItemsOneOf2Type? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItems2? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItems? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItem? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AgentMessageItemContentItems>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1Items>? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Inputs? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModalityEnum? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionEngine? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PdfParserEngine0? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PdfParserEngine1? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngine? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserOptions? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionPreset? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingParetoRouterPriceSource? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngine? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPluginId? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPluginUserLocationType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPluginUserLocation? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPluginId? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItems? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant1? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant1Id? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant2? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant2Id? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant3? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant3Id? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4Id? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5Id? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6Id? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7Id? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant8? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant8Id? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant9? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant10? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminator? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImage? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StoredPromptTemplateVariables? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StoredPromptTemplate? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptionsMode? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptions? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesDataCollection? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderName? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesIgnoreItems? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesMaxPrice? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesOnlyItems? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesOrderItems? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileLatencyCutoffs? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMaxLatency? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileThroughputCutoffs? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMinThroughput? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Quantization? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSort? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigBy? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigPartition? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfig? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesSort? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferences? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesIgnoreItems>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOnlyItems>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderPreferencesOrderItems>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Quantization>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningContext? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningEffort? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningMode? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryVerbosity? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningConfig? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestServiceTier? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIsType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCallType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCostType? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsedType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIsType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenCondition? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant1? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant2? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant3? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant4? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant5? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminator? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfigType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfig? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfigType? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfig? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfigType? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfig? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Formats? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVerbosity? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfig? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice0? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice1? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice2? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoiceOneOf3Type? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice3? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type0? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type1? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoiceOneOf4Type? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice4? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedMode0? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedMode1? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedMode? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowed? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoiceOneOf6Type? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice6? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoiceOneOf7Type? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesToolChoice7? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoice? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolsItemsOneOf0Type? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolsItems0? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolsItems? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TraceConfig? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesTruncation? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequest? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItems>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolsItems>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorFieldCode? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorField? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetailsReason? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetails? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1Type? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2Type? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3Type? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4Type? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminator? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Content? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase0? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role0? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role1? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role2? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role3? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Role? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Type? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1Items0? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItems? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1Type? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant2Type? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant3Type? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant4Type? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminator? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemRole0? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemRole1? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemRole2? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemRole? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseInputMessageItemType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItem? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseInputMessageItemContentItems>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant1Type? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant2Type? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsVariant3Type? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminator? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1ItemsDiscriminatorType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutput? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallOutputType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseFunctionToolCallType? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCall? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCallType? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCall? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageContentItems? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhase0? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhase1? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhase? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageRole? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatus0? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatus1? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatus2? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatus? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageType? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessage? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageContentItems>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCall? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant1? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant1Type? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2Type? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3Type? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminator? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsDiscriminatorType? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutput? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsOneOf1Items? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BaseInputsOneOf1Items>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputs? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultObject? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemContentItems? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemPhase0? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemPhase1? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemPhase? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemRole? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus0? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus1? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus2? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItemType? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus0? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus1? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus2? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemType? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemAction? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallStatus? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcomeOneOf0Type? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcomeOneOf1Type? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItems? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemType? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItems? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant1? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant1Type? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant2? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant3? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant3Type? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant4? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant4Type? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant5? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant6? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant7? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant8? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputMessageItemContentItems>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant9? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant9Type? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant10? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant10Type? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant11? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant11Type? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant12? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant12Type? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant13? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant13Type? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant14? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant14Type? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant15? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant16? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant16Type? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant17? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant17Type? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant18? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant18Type? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant19? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant19Type? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant20? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant21? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant22? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant23? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant24? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant25? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant26? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant27? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant28? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant29? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellCallOutputItemOutputItems>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsVariant30? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminator? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorType? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningConfig? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceTier? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesResponseStatus? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultToolsItemsOneOf0Type? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultToolsItems0? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultToolsItems? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Truncation? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesUsageInputTokensDetails? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAiResponsesUsageOutputTokensDetails? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageCostDetails? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolUseDetails? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Usage? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiErrorType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterAttempt? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointInfo? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointsMetadata? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterParams? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStageType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStage? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RoutingStrategy? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterMetadata? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResult? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesResultToolsItems>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponseErrorData? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponseErrorData? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponseErrorData? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponseErrorData? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponseErrorData? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponseErrorData? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponseErrorData? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponseErrorData? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponse? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponseErrorData? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponse? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponseErrorData? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponse? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponseErrorData? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponse? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponseErrorData? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponse? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthExchangeAuthCodeForAPIKeyResponse200? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AuthKeysCodePostResponsesContentApplicationJsonSchemaData? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthCreateAuthKeysCodeResponse200? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponseErrorData? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponse? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestAspectRatio? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestBackground? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorMappingImageUrlImageUrl? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImage? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestOutputFormat? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferencesOptions? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferencesOrderItems? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferencesSort? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferences? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOrderItems>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestQuality? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestResolution? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponseDataItems? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheCreation? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageCompletionTokensDetails? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CostDetails? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicIterationCacheCreation? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationType? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIteration? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationType? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIteration? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationType? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIteration? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsageIteration? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsagePromptTokensDetails? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageServerToolUse? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSpeed? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsage? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponse? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItems>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageInputModality? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageOutputModality? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelArchitecture? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageInputModality>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapabilityType? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapabilityType? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptor? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant1? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant1Type? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant2? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorVariant3? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminator? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminatorType? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SupportedParameters? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelListItem? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelsListResponse? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryBillable? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryUnit? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntry? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageEndpoint? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry>? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelEndpointsResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOptions? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProvider? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestResponseFormat? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequest? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInputAudio? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SttRequestProvider? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SttRequestResponseFormat? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTTimestampGranularity? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequest? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTSegment? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUsage? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWord? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTResponse? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ActivityItem? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ActivityResponse? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem>? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaData? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems>? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems>? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BetaAnalyticsGetAnalyticsMetaResponse200? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFilters? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaData? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems>? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BetaAnalyticsQueryAnalyticsResponse200? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BenchmarksGetParametersSource? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BenchmarksGetParametersTaskType? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BenchmarksGetParametersArena? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarkPricing? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorMappingDesignArenaTournamentStats? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItems? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminator? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaSource? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaVersion? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMeta? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponse? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UnifiedBenchmarksResponseDataItems>? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ByokGetParametersProvider? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKProviderSlug? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKey? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysResponse? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BYOKKey>? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequest? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateByokKeyResponseData? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetByokKeyResponseData? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBYOKKeyResponse? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteBYOKKeyResponse? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequest? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateByokKeyResponseData? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAudioOutput? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorMappingFileFile? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrlDetail? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorMappingImageUrlImageUrl? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorMappingInputAudioInputAudio? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoType? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInput? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentCacheControlType? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentCacheControl? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentTextType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoType? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInput? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItems? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant1? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant1Type? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant2? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant2Type? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant3? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant3Type? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant4? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant5? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsVariant6? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminator? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorType? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorMappingAssistantContent? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImagesItemsImageUrl? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImagesItems? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImagesItems>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnion? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant1? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant1Type? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant2? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant2Type? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant3? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant3Type? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant4? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionVariant4Type? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminator? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminatorType? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallFunction? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallType? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCall? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentText? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorMappingDeveloperContent? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessageContent? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessageRole? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessageContent? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessageRole? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessageContent? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessageRole? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessages? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant1? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant1Role? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant2? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant2Role? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant3? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant4? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesVariant5? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminator? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorRole? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestModalitiesItems? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItems? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant1? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant1Id? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant2? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant2Id? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant3? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant3Id? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant4Id? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant5Id? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant6Id? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant7Id? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant8? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant8Id? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant9? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant10? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsDiscriminator? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentTextType? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentText? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContent? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionType? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Prediction? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatReasoningSummaryVerbosityEnum? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoning? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatJsonSchemaConfig? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormat? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant1? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant1Type? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant2? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant2Type? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant3? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant3Type? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant4? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant4Type? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant5? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatVariant5Type? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminator? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminatorType? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestServiceTier? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestStop? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamOptions? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice0? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice1? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice2? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceFunction? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceType? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoice? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatServerToolChoice? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolOneOf0Function? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolOneOf0Type? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionTool0? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerToolType? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerTool? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchConfig? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerToolType? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerTool? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthandType? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthand? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionTool? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequest? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages>? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitiesItems>? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestPluginsItems>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFinishReasonEnum? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobTopLogprobsItems? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprob? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobs? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprob>? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessage? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatChoice? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResultObject? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsageCompletionTokensDetails? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsagePromptTokensDetails? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsage? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResult? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassificationsTaskGetParametersWindow? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationModel? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationItem? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationModel>? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationMacroCategory? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponseData? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationItem>? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationMacroCategory>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponse? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreditsGetResponsesContentApplicationJsonSchemaData? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreditsGetCreditsResponse200? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsAppRankingsGetParametersCategory? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsAppRankingsGetParametersSort? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsItem? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMetaVersion? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMeta? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsResponse? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem>? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsRankingsDailyGetParametersModality? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsRankingsDailyGetParametersCategory? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyItem? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyResponse? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RankingsDailyItem>? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1ImageUrl? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MultimodalMedia? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudioType? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudio? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideoType? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideo? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFileType? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFile? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProvider? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputModality? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InstructType? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModality? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelGroup? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelArchitecture? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputModality>? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AABenchmarkEntry? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DABenchmarkEntry? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelBenchmarks? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DefaultParameters? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelLinks? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerRequestLimits? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverride? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicPricing? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverride>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelReasoning? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Parameter? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TopProviderInfo? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Model? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Parameter>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Model>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponseLinks? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponse? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileStats? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpointPricing? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointStatus? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpointThroughputLast30M? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpoint? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointsListEndpointsZdrResponse200? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint>? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponseArchitecture? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointsListEndpointsResponse200? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileMetadataType? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileMetadata? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FileMetadata>? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseType? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponse? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataApiType? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataDataRegion? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseProviderName? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseRoutedServiceTier? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponse? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseData? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponse? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInput0? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInput1? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInput? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataOutput? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentData? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentResponse? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequestCategory? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequest? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponseData? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponse? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinAction? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptInjectionScanScope? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinSlug? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntry? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterAction? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterEntry? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailInterval? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Guardrail? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListGuardrailsResponse? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntryInput? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailRequest? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailResponseData? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailResponse? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetGuardrailResponseData? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetGuardrailResponse? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteGuardrailResponse? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailRequest? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailResponseData? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailResponse? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyAssignment? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListKeyAssignmentsResponse? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysRequest? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysResponse? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysRequest? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysResponse? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MemberAssignment? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListMemberAssignmentsResponse? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersRequest? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersResponse? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersRequest? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersResponse? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyGetResponsesContentApplicationJsonSchemaData? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiKeysGetCurrentKeyResponse200? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiKeysListResponse200? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems>? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeysPostResponsesContentApplicationJsonSchemaData? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiKeysCreateKeysResponse201? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeysHashGetResponsesContentApplicationJsonSchemaData? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiKeysGetKeyResponse200? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiKeysDeleteKeysResponse200? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeysHashPatchResponsesContentApplicationJsonSchemaData? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiKeysUpdateKeysResponse200? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeastType? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeast? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0ClearToolInputs? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeepType? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeep? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1Type? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2Type? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Type? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItems0? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurnsType? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurns? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1Type? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep1? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep2? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Keep? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf1Type? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItems1? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Trigger? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf2Type? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItems2? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditsItems? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagement? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestContextManagementEditsItems>? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesFallbackParam? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItems? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1Type? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2Type? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3Type? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4Type? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminator? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamType? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParam? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParamCitationsItems>? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageMimeType? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSourceType? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSource? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant1? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant2? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminator? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamType? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParam? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamCitations? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceMediaType? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceType? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSource? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceMediaType? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceType? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSource? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminator? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Content? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2Type? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSource2? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSourceType? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSource? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSourceType? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSource? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSource? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamType? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParam? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf3Type? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items3? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2Type? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamCitations? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamType? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParam? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Content? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4Type? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items4? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf5Type? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items5? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf6Type? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items6? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf7Type? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items7? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParamType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParam? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content1? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Content? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf8Type? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items8? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf10Type? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items10? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlockType? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlock? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParamContentOneOf1Items>? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContent? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamRole? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParam? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestMetadata? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigEffort? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormatType? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormat? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudgetType? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudget? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfig? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItems? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant1? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant1Id? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant2? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant2Id? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant3? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant3Id? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant4? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant4Id? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant5? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant5Id? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant6? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant6Id? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant7? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant7Id? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant8? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant8Id? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant9? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsVariant10? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsDiscriminator? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestSystem? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingDisplay? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingOneOf0Type? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinking0? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingOneOf1Type? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinking1? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingOneOf2Type? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinking2? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinking? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceOneOf0Type? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoice0? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceOneOf1Type? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoice1? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceOneOf2Type? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoice2? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceOneOf3Type? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoice3? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoice? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf0InputSchema? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf0Type? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems0? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf1Name? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf1Type? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems1? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf2Name? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf2Type? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems2? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf3Name? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf3Type? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocationType? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocation? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems3? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAllowedCallersItems? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCallersItems>? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf4Name? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf4Type? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems4? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf5Name? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItemsOneOf5Type? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems5? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerToolType? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerTool? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems12? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolsItems? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequest? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainer? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutputType? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutput? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResultType? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContent? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicBashCodeExecutionOutput>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutputType? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutput? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResultType? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolErrorCode? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultErrorType? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResultType? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContent? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentVariant1? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicCodeExecutionOutput>? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentVariant2? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentVariant3? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminator? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCaller? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerVariant1? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerVariant1Type? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerVariant2? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerVariant2Type? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerVariant3? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerVariant3Type? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerDiscriminator? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicNullableCallerDiscriminatorType? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicServerToolUseBlockType? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitation? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant1? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant1Type? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant2? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant2Type? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant3? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant3Type? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant4? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant4Type? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant5? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationVariant5Type? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminator? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminatorType? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContent? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultErrorType? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReferenceType? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReference? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultType? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContent? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentVariant1? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentVariant2? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference>? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminator? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCaller? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant1? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant1Type? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant2? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant2Type? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant3? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerVariant3Type? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminator? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminatorType? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationsConfig? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockSource? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockType? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlock? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorType? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContent? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentVariant1? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentVariant1Type? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentVariant2? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminator? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminatorType? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultType? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResult? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorType? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultError? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlock? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant1? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant1Type? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant2? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant2Type? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant3? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant3Type? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant4? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant4Type? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant5? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant5Type? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant6? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant6Type? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant7? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant8? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant8Type? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant9? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant9Type? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant10? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant10Type? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant11? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant11Type? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant12? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant12Type? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant13? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant13Type? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant14? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant14Type? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminator? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultRole? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsCategory? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetails? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicStopReason? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultType? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputTokensDetails? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolUsage? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServiceTier? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultUsage? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultContextManagementAppliedEditsItems? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultContextManagement? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems>? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResult? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorDetail? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorResponseType? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorResponse? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelResponse? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsGetParametersCategory? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsGetParametersSort? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsGetParametersDistillable? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsGetParametersZdr? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsGetParametersRegion? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponseData? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponse? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupLogic? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsField? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsOperator? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRulesItemsValue? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRulesItems? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroup? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRulesItems>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfig? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup>? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingBraintrustConfig? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingClickhouseConfig? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingDatadogConfig? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingGrafanaConfig? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangfuseConfig? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingLangsmithConfig? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfig? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingOpikConfig? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingOtelCollectorConfig? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingPosthogConfig? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingS3Config? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingSentryConfig? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingSnowflakeConfig? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWeaveConfig? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestination? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant1? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant1Type? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant2? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant2Type? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant3? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant3Type? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant4? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant4Type? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant5? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant5Type? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant6? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant6Type? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant7? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant7Type? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant8? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant8Type? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant9? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant9Type? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant10? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant10Type? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant11? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant11Type? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant12? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant12Type? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant13? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant13Type? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant14? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant14Type? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant15? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant15Type? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant16? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant16Type? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant17? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant17Type? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminator? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminatorType? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListObservabilityDestinationsResponse? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination>? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfigNullable? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequestType? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequest? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseData? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1Type? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2Type? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3Type? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4Type? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5Type? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6Type? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7Type? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8Type? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9Type? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10Type? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11Type? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12Type? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13Type? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14Type? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15Type? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16Type? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminator? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponse? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseData? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant1Type? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant2Type? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant3Type? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant4Type? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant5Type? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant6Type? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant7Type? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant8Type? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant9Type? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant10Type? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant11Type? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant12Type? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant13Type? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant14Type? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant15Type? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant16Type? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant17Type? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminator? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponse? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteObservabilityDestinationResponse? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationRequestFilterRules? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationRequest? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseData? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant1Type? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant2Type? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant3Type? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant4Type? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant5Type? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant6Type? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant7Type? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant8Type? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant9Type? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant11Type? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant12Type? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant13Type? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant14Type? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant15Type? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant16Type? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant17Type? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminator? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorType? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponse? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItemsRole? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrganizationListOrganizationMembersResponse200? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems>? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetStatus? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preset? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetsResponse? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Preset>? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetDesignatedVersion? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersion? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetResponse? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePresetFromInferenceResponse? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetVersionsResponse? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PresetDesignatedVersion>? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetVersionResponse? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProvidersListProvidersResponse200? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems>? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderSort? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProvider? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaUsage? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RerankCreateRerankResponse200? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestAspectRatio? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageImageUrl? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageType? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageFrameType? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImage? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorMappingAudioUrlAudioUrl? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorMappingVideoUrlVideoUrl? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReference? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceVariant1? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceVariant1Type? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceVariant2? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceVariant2Type? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceVariant3? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceVariant3Type? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminator? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorType? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestProviderOptions? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestProvider? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestResolution? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequest? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponseStatus? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationUsage? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponse? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedAspectRatiosItems? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedFrameImagesItems? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedResolutionsItems? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedSizesItems? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModel? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatiosItems>? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImagesItems>? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolutionsItems>? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSizesItems>? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelsListResponse? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModel>? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Workspace? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspacesResponse? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Workspace>? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequest? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceResponseData? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceResponse? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceResponseData? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceResponse? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceResponse? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequest? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceResponseData? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceResponse? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetResetInterval? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudget? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceBudgetsResponse? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget>? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetInterval? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetRequest? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetResponseDataResetInterval? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetResponseData? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetResponse? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceBudgetResponse? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMemberRole? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMember? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceMembersResponse? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember>? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersRequest? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersResponse? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersRequest? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersResponse? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForApiKeyRequest? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequest? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequest? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems>? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequest? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UploadFileRequest? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequest? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequest? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequest? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems>? Type1892 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningTextContent>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningSummaryText>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EasyInputMessageContentOneOf0Items>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputMessageItemContentItems>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FunctionCallOutputItemOutputOneOf1Items>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobsItemsTopLogprobsItems>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponsesAnnotation>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobsItems>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WebSearchSource>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItemsDiscriminatorMappingComputerCallPendingSafetyChecksItems>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputWebSearchServerToolItemActionSourcesItems>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradictionsItemsStancesItems>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradictionsItems>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultPartialCoverageItems>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultUniqueInsightsItems>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItemsDiscriminatorMappingOpenrouterFusionResponsesItems>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionSource>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputItemOutputItems>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.McpListToolsItemToolsItems>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.NamespaceFunctionToolAllowedCallersItems>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.NamespaceToolToolsItems>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AdvisorNestedTool>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SubagentNestedTool>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionServerToolConfigToolsItems>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AdditionalToolsItemToolsItems>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AgentMessageItemContentItems>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputsOneOf1Items>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItems>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesIgnoreItems>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOnlyItems>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderPreferencesOrderItems>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Quantization>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StopServerToolsWhenCondition>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseIncludesEnum>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModalityEnum>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestPluginsItems>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestToolsItems>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAiResponseInputMessageItemContentItems>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAiResponseFunctionToolCallOutputOutputOneOf1Items>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputMessageContentItems>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1Items>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BaseInputsOneOf1Items>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputMessageItemContentItems>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellCallOutputItemOutputItems>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EndpointInfo>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RouterAttempt>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PipelineStage>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItems>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenResponsesResultToolsItems>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationProviderPreferencesOrderItems>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentPartImage>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicUsageIteration>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationResponseDataItems>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageInputModality>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageOutputModality>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageModelListItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImagePricingEntry>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageEndpoint>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTTimestampGranularity>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTSegment>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTWord>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ActivityItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UnifiedBenchmarksResponseDataItems>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BYOKKey>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatAssistantImagesItems>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningDetailUnion>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatToolCall>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatMessages>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatRequestModalitiesItems>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatRequestPluginsItems>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatFunctionTool>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprobTopLogprobsItems>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprob>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatChoice>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationModel>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationItem>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationMacroCategory>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AppRankingsItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RankingsDailyItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputModality>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModality>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.DABenchmarkEntry>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverride>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningEffort>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Parameter>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Model>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicEndpoint>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FileMetadata>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntry>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterEntry>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Guardrail>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntryInput>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeysGetResponsesContentApplicationJsonSchemaDataItems>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestContextManagementEditsItems>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParamCitationsItems>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParamContentOneOf1Items>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicAllowedCallersItems>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesFallbackParam>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestPluginsItems>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesRequestToolsItems>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicBashCodeExecutionOutput>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicCodeExecutionOutput>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicToolReference>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResult>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextCitation>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesResultContextManagementAppliedEditsItems>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicContentBlock>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroupRulesItems>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroup>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDestination>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OrganizationMembersGetResponsesContentApplicationJsonSchemaDataItems>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Preset>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PresetDesignatedVersion>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProvidersGetResponsesContentApplicationJsonSchemaDataItems>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FrameImage>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputReference>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedAspectRatiosItems>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedFrameImagesItems>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedResolutionsItems>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedSizesItems>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModel>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Workspace>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceBudget>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceMember>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems>? ListType170 { get; set; }
    }
}