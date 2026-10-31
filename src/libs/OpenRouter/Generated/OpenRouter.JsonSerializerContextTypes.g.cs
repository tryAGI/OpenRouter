
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AABenchmarkEntry? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ActivityItem? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ActivityResponse? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItem? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemRole? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.AdditionalToolsItemTool>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionTool? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemTool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AdditionalToolsItemToolAllowedCaller>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolAllowedCaller? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerTool? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerTool? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerTool? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerTool? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerTool? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerTool? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerTool? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerTool? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerTool? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellTool? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerTool? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerTool? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomTool? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceTool? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouter? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouter? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerTool? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerTool? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouter? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouter? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerTool? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouter? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouter? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerTool? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouter? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerTool? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemTool2? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorReasoning? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorReasoningEffort? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouterType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItem? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemAgent? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.AgentMessageItemContentItem2>>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.AgentMessageItemContentItem2>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputText? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItem2? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItemType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Alignment? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentCallRecord>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecord? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentAllowedCallRecord? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentAllowedCallRecordOutcome? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleRecord>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRuleRecord? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentBlockedCallRecord? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentBlockedCallRecordOutcome? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecord? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecordDiscriminator? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatAudio? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatImage? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatImageImageUrl? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatImageType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatRejected? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatImage>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatRejectedRole? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatToolCall>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatToolCall? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatToolCallFunction? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatToolCallType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPlugin? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPluginId? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPluginMode? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRule>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRule? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRejected? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItem? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessage? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoning? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCall? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCall? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCall? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCall? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCall? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCall? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCall? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItemDiscriminator? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItemDiscriminatorType? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleWatchItem>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRuleWatchItem? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecordOutcome? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecordReason? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnnotationAddedEvent? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEvent? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBaseUsageIteration? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2Type? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResult? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResultType? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCaller>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAllowedCaller? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSource? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageMimeType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSourceType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSource? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceMediaType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicIterationCacheCreation? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContent? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResult? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutput? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutputType? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicBashCodeExecutionOutput>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResultType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultType? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirective? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlTtl? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirectiveType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheCreation? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCaller? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCaller? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminator? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminatorType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocation? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParam? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParamType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocation? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParamType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocation? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationType? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParam? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParamType? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationsConfig? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocation? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationType? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParamType? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationType? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825CallerType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120CallerType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContent? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResult? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminator? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutput? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutputType? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicCodeExecutionOutput>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResultType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResult? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolErrorCode? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultErrorType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlock? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlockType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIteration? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2Type? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainer? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicContainerSkill>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerSkill? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerSkillType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUpload? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUploadType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCallerType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlock? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.AnthropicBase64PdfSource, global::OpenRouter.AnthropicPlainTextSource>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSource? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParam? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamCitations? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSource? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant2Item>>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant2Item>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentVariant2Item? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParam? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParam? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminator? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSource? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSource? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResultType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFile? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileShape? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileType? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeleted? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeletedShape? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeletedType? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSourceType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileList? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileListShape? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicFile>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Source3? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSource? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminator? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeast? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeastType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTrigger? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTriggerType? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTransformation? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageOutputConfig? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputEffort? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseError? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiErrorType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseErrorType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIteration? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2Type? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputTokensDetails? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceMediaType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlock? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlockType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetails? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsCategory? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguard? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguardResult? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguardResultStatus? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParam? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamCitations? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolUsage? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServiceTier? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSpeed? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSystemClearAt? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlock? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitation? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CitationsItem>? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CitationsItem? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminator? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminator? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminatorType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContent? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlock? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBinding? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBindingMismatchBehavior? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBindingPrefixMismatchBehavior? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingDisplay? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurns? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurnsType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReference? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReferenceType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContent? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultError? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResult? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminator? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultErrorType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25Name? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25Type? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegex? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegexName? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegexType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResult? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResultType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnion? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1InputSchema? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1InputSchemaType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1Type? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2Name? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2Type? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3Name? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3Type? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4Name? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4Type? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocation? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5Name? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5Type? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlock? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlockType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeep? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeepType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTrigger? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTriggerType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIteration? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIterationVariant2? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSourceType? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSourceType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsage? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsageIteration? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlock? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlockType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContent? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultError? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminator? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminatorType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResult? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResult? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParam? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParamType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResult? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultError? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultType? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorType? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocationType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItem? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallStatus? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperation? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperation? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperation? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminator? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEventType? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEventType? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItem? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemStatus? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemType? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperationType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperationType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchEngineEnum? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolType? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolConfig? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouterType? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperationType? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsItem? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsResponse? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMeta? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorAutoMode? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorRule? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorEnvironmentEntry? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorContext? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPlugin? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginId? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginMode? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginOnError? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginOutputMode? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResult? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatus? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Outcome? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Type? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant2? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant2Type? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant3? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant3Type? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusType? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPlugin? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPluginCostTier? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPluginId? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPlugin? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPluginCostTier? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPluginId? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponse? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponseErrorData? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponse? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponseErrorData? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesAnnotation? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEventType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEvent? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputText? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContent? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEventType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEvent? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEventType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEvent? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEventType? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEvent? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEventType? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEvent? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEventType? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEvent? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEventType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEvent? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEventType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputs? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2Item2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>, string>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentVariant1Item? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFile? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudio? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminator? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1?, global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2?>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant1? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant2? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant3? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant4? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItem? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCall? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCall? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateItem? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResult? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlock? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicInputTransformation>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultRole? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicStopReason? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BaseMessagesResultUsage>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultUsage? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningConfig? Type481 { get; set; }
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
        public global::OpenRouter.BaseReasoningDeltaEvent? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDeltaEventType? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEvent? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEventType? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartAddedEvent? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryText? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartAddedEventType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEvent? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEventType? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEventType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEvent? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEventType? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEvent? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEventType? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEvent? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEventType? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResult? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorField? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetails? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultObject? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItem>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItem? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminator? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminatorType? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StoredPromptTemplate? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptions? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceTier? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesResponseStatus? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfig? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoice? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.BaseResponsesResultToolVariant1>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultToolVariant1? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Truncation? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsage? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEvent? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesLogProbs>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesLogProbs? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEventType? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEvent? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEventType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolConfig? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolType? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEngine? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironment? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironment? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironment? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminator? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminatorType? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletedObject? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargets? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletedObjectObject? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionOutcome? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargetsOpenrouter? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargetsUpstream? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchErrorResponse? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchErrorResponseError? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItem? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemCompletionWindow? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemError? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemObject? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemRequestCounts? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemStatus? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsage? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsageCompletionTokensDetails? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CostDetails? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsagePromptTokensDetails? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsageServerToolUse? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListResponse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchListItem>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListResponseObject? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListStatus? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListTimestamp? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObject? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectCompletionWindow? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectError? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectObject? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectRequestCounts? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResult>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResult? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultError? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponse? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FinishReason? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobs? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessage? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1Type? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2ImageUrl? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2UrlCitation? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageImageUrl? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>?>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummary? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncrypted? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailText? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCall? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageRole? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCallFunction? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCallType? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Debug? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimings? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimingsEvent? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Object? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterMetadata? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ArmorSafeguardResult>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Usage? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageCompletionTokensDetails? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsagePromptTokensDetails? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUseDetails? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResult? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Role? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Type? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BatchObjectResultResponseBodyVariant3Usage>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Usage? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<double>, string>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItemObject? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Object? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Usage? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4UsagePromptTokensDetails? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectStatus? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsage? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsageCompletionTokensDetails? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsagePromptTokensDetails? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsageServerToolUse? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseError? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseObject? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseRequestCounts? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseStatus? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsage? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsageCompletionTokensDetails? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsagePromptTokensDetails? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsageServerToolUse? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchProviderPreferences? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderName? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBody? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyCompletionWindow? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyEndpoint? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyRequest? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapability? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapabilityType? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersRequest? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersResponse? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMember? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysRequest? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersRequest? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersResponse? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersRequest? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersResponse? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysRequest? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysResponse? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersRequest? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersResponse? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKey? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKeyDeclaredRegion? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKProviderSlug? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptor? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapability? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapability? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminator? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminatorType? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImage>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImage? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImageImageUrl? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessage? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAudioOutput? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItems? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessageRole? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCall? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatChoice? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFinishReasonEnum? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobs? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudio? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudioInputAudio? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudioType? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentCacheControl? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFile? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFileFile? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFileType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImage? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageImageUrl? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageImageUrlDetail? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentText? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideo? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideo? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminator? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorType? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpoint? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentTextType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInput? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInputProcessing? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDebugOptions? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessage? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdate3? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessageRole? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDynamicServerTool? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfig? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfigType? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfig? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfigType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfig? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatJsonSchemaConfig? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfigType? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfig? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfigType? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfig? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfigType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionTool? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1Function? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1Type? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerTool? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerTool? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthand? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessages? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessage? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessage? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessage? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminator? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorRole? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AllOf<string, object>>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<string, object>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoice? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceFunction? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceType? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnion? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatReasoningSummaryVerbosityEnum? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequest? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControl? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageConfig? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitie>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestModalitie? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem>? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPlugin? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPlugin? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPlugin? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPlugin? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPlugin? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPlugin? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPlugin? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPlugin? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPlugin? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPlugin? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminator? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminatorId? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Prediction? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferences? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoning? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort2? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseFormat? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminator? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminatorType? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeprecatedRoute? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestServiceTier? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamOptions? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TraceConfig? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResult? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResultObject? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsage? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolConfig? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerToolType? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatServerToolChoice? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChoice? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamDelta? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunk? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, object>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamChoice>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkError? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkErrorMetadata? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkObject? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ChatAudioOutput, object>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamDeltaRole? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamToolCall>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCall? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamingResponse? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCallFunction? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCallType? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessageRole? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprob? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprobTopLogprob>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobTopLogprob? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprob>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallFunction? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallType? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant1? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant2? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant3? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessageRole? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsageCompletionTokensDetails? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsagePromptTokensDetails? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolUseDetails? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessageRole? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngineEnum? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchMode? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchConfig? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchQualityLevel? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthandType? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerTool? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.XSearchOptions? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierFiltersFilter? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierScalarFilter? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierSetFilter? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierScalarFilterOperator? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierSetFilterOperator? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClientClosedRequestResponse? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClientClosedRequestResponseErrorData? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDoneEvent? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCompletedEvent? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInProgressEvent? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInterpretingEvent? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallItem? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutput? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutputType? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutput? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutputType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutput? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutputType? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.CodeInterpreterServerToolContainer>? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainer? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerMemoryLimit? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerType? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolType? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellToolType? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItem? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItemType? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEvent? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEventType? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilter? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilterType? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolEnvironment? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolType? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateReasoning? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateItemType? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateReasoningEffort? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponse? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponseErrorData? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicy? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironmentType? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFile? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileObject? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileSource? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileListResponse? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContainerFile>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileListResponseObject? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1Type? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2Type? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironmentType? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterAction? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinAction? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntry? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptInjectionScanScope? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinSlug? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntryInput? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterEntry? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEvent? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEventVariant2? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.ReasoningTextContent, global::OpenRouter.OpenAIResponsesRefusalContent>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContent? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudio? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudioAudioUrl? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudioType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEvent? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEventVariant2? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImage? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImageImageUrl? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImageType? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudio? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MultimodalMedia? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudioType? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFile? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFileType? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideo? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideoType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideo? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideoType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideoVideoUrl? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItem? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItemType? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionEngine? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPluginId? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequest? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequestDeclaredRegion? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyResponse? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BYOKKey, object>? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEvent? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEventType? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateExternalUserRequest? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailRequest? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailDataRegion? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailInterval? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Guardrail, object>? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Guardrail? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequest? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfigNullable? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDataRegionInput? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequestType? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestination? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePresetFromInferenceResponse? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersion? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointRequest? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointActivation? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointDeclaredParameter? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointPricing? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequest? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponse? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponseData? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpoint? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidationNullable? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponseError? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateProviderRequest? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateProviderDataPolicy2? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingRequest? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingRequestRole? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingResponse? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroupMapping? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimSyncJobResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimSyncJob? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequest? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequestDisabledServerTool? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceResponse? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Workspace, object>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Workspace? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CustomToolFormatVariant1, global::OpenRouter.CustomToolFormatVariant2>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant1? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant1Type? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2Syntax? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2Type? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolType? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDeltaEvent? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDoneEvent? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItem? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolCallStatus? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItemType? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItem? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemVariant2? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DABenchmarkEntry? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolConfig? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolType? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEvent? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebug? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebugTimings? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebugTimingsEvent? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventType? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Decisions? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileStats? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswer? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswerBox? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswerType? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxQuestion? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxQuestionType? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswer? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswerType? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestion? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestionType? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAsset? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAssetFormat? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAssetType? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswer? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswerType? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestion? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestionCriteria? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestionType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequest? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.DecisionsImageAsset>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Questions? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestion? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminator? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponse? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Answers? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswer? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminatorType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseUsage? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswerType? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestionType? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DefaultParameters? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25Search? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25SearchType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearch? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearchType? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearch? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearchType? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlProfile? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlProtocol? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategy? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlValidation? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminator? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteBYOKKeyResponse? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteGuardrailResponse? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteObservabilityDestinationResponse? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointResponse? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointResponseData? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteScimGroupMappingResponse? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceBudgetResponse? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceResponse? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessage? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>, string>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideo? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.EasyInputMessagePhaseVariant1?, global::OpenRouter.EasyInputMessagePhaseVariant2?>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhaseVariant1? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhaseVariant2? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant1? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant2? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant3? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant4? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EdgeNetworkTimeoutResponse? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EdgeNetworkTimeoutResponseErrorData? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Embeddings? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointInfo? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointsMetadata? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo>? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapabilityType? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ErrorEvent? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExternalUser? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExternalUserResponse? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAsset? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAssetFormat? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAssetType? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswer? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswerSource? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswerType? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateField? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateFieldType? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswer? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswerSource? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswerType? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeField? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeFieldType? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswer? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswerSource? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswerType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationField? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationFieldType? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswer? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, string>? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswerSource? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswerType? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateField? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldScale? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionEstimateFieldStepVariant2?, global::OpenRouter.ExtractionEstimateFieldStepVariant3?>? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldStepVariant2? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldStepVariant3? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswer? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswerSource? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ExtractionForecastStep>? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastStep? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswerType? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastField? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldInterval? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldScale? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionForecastFieldStepVariant2?, global::OpenRouter.ExtractionForecastFieldStepVariant3?>? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldStepVariant2? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldStepVariant3? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldType? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswer? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswerSource? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<long>>? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswerType? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListField? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListFieldItems? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListFieldType? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswer? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswerSource? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswerType? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberField? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberFieldType? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequest? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ExtractionAsset>? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Fields? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextField? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeField? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminator? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponse? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Answers2? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswer? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswer? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminator? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsUsage? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswerSource? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswerType? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextFieldType? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswerSource? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswerType? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeFieldType? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailableToolCallStatus? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEvent? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEventType? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitation? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitationType? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponse? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeleted? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeleted? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminator? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminatorShape? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponse? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileList? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileList? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminator? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminatorShape? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPluginId? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserOptions? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePath? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePathType? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileProvider? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponse? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFile? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFile? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminator? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminatorShape? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.FileSearchServerToolFilters, global::OpenRouter.CompoundFilter>? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFilters? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFiltersType? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>>? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptions? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptionsRanker? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolType? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolConfig? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolType? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Filter? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilter? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilter? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponse? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponseErrorData? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfig? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfigType? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfig? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfigType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Formats? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfig? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfigType? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImage? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2FrameType? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FreeModelDailyRequests? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDeltaEvent? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDoneEvent? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItem? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallItemSubagentItem>? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemSubagentItem? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemType? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItem? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemVariant2? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionToolType? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResult? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradiction>? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradiction? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionStance>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradictionStance? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItem>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultPartialCoverageItem? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsight>? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultUniqueInsight? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEvent? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEventType? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEvent? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEventType? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEvent? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEventType? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEvent? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEventType? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEvent? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEventType? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEvent? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEventType? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEvent? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEventType? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEvent? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEventType? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEvent? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEventType? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginId? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginPreset? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionPluginTool>? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginTool? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?, bool?>?>, object>? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?, bool?>?>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?>? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfig? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouterType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoning? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoningEffort? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigTool>? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigTool? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionSource? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GatewayTimeoutResponse? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GatewayTimeoutResponseErrorData? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentData? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentError? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.GenerationContentDataInputVariant1, global::OpenRouter.GenerationContentDataInputVariant2>? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInputVariant1? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInputVariant2? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataOutput? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GenerationContentErrorAttempt>? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentErrorAttempt? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentResponse? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponse? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseData? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataApiType? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataDataRegion? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponse? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBYOKKeyResponse? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetGuardrailResponse? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponse? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetResponse? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetVersionResponse? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetDesignatedVersion? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetScimGroupMappingResponse? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetScimSyncJobResponse? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetToolResponse? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetails? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceBudgetResponse? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.WorkspaceBudget, object>? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudget? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceResponse? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GoneResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GoneResponseErrorData? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<object>>? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageEndpoint? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry>? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntry? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>, object>? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallCompletedEvent? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompleted? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallGeneratingEvent? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGenerating? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallInProgressEvent? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgress? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallPartialImageEvent? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCompletedEvent? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCompletedEventType? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsage? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGeneration? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferences? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOptions? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig>? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSort? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfig? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequest? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestAspectRatio? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestBackground? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestOutputFormat? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestQuality? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestResolution? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponse? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItem>? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponseDataItem? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolBackground? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputFidelity? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputImageMask? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolModeration? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOutputFormat? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolQuality? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolType? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolConfig? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouterType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationStatus? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageCompletionTokensDetails? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsagePromptTokensDetails? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageServerToolUse? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenPartialImageEvent? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenPartialImageEventType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEvent? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEventError? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEventType? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEvent? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEventPhase? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEventType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageInputModality? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelArchitecture? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageInputModality>? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality>? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageOutputModality? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelEndpointsResponse? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint>? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelListItem? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelsListResponse? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem>? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryBillable? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryUnit? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageStreamingResponse? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ImageGenPartialImageEvent, global::OpenRouter.ImageGenTextChunkEvent, global::OpenRouter.ImageGenCompletedEvent, global::OpenRouter.ImageGenStreamErrorEvent>? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetailsReason? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEvent? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEventType? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEvent? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEventType? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioInputAudio1? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioInputAudio1Format? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioType? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFileType? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImageDetail? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImageType? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItem? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.InputMessageItemRoleVariant1?, global::OpenRouter.InputMessageItemRoleVariant2?, global::OpenRouter.InputMessageItemRoleVariant3?>? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant1? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant2? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant3? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputModality? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReference? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminator? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorType? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Inputs? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItem? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItem? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant82? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string>? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant8Type? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItem? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant92? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItem? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItem? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItem? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItem? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItem? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItem? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItem? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItem? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItem? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItem? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItem? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItem? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItem? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItem? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItem? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItem? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItem? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMcpServerToolItem? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItem? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItem? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItem? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItem? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItem? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItem? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItem? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItem? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItem? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItem? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItem? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItem? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItem? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItem? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItem? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItem? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItem? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputTextType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoProcessing? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoType? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InstructType? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponse? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponseErrorData? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItemType? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPluginId? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyAssignment? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudget? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudgetResetInterval? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudgetScope? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoType? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInput? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInputProcessing? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchDomainFilter? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchContextSizeEnum? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerToolType? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocation? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysResponse? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BYOKKey>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ModelArchitecture, global::OpenRouter.ListEndpointsResponseArchitecture>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelArchitecture? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponseArchitecture? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputModality>? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModality? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelGroup? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpoint? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListExternalUsersResponse? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ExternalUser>? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListGuardrailsResponse? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListKeyAssignmentsResponse? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListMemberAssignmentsResponse? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MemberAssignment? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListObservabilityDestinationsResponse? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetsResponse? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Preset>? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preset? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetVersionsResponse? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PresetDesignatedVersion?>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPrivateEndpointsResponse? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSummary>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSummary? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListScimGroupMappingsResponse? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ScimGroupMapping>? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListScimGroupsResponse? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ScimGroup>? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroup? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsResponse? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerTool>? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerTool? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsResponseLinks? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceBudgetsResponse? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget>? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceMembersResponse? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspacesResponse? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Workspace>? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemAction? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemActionType? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemType? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItemType? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointVariant2? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointDeclaredRegion? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointResponse? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItemType? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItemType? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolCallError? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItemType? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpError? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpErrorType? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.McpListToolsItemTool>? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemTool? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemType? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolError? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolErrorType? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolAllowedTools>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolAllowedTools? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolConnectorId? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Always? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Never? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant2? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant3? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolType? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionError? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionErrorType? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlock? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlockType? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlock? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesBashToolResultBlockFile>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockFile? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockFileType? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockType? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEvent? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1Type? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2Type? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3Type? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4Type? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Citation? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5Type? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6Type? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventType? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEvent? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlock? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResult? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResult? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResult? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventContentBlock? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventContentBlockType? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventType? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEvent? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEventType? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEvent? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventDelta? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventType? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventUsage? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUsage? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEvent? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEventError? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEventType? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesFallbackParam? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParam? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4Type? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5ContentVariant2Item? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5Type? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6Type? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7Type? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8Type? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9ContentErrorCode? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9ContentType? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Type? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11Type? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlock? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlock? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlock? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultParam? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamRole? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfig? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigEffort? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormat? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormatType? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudget? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudgetType? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEvent? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEventType? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequest? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagement? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Trigger? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminator? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1Type? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnumType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum2? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2Type? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicInputTokensTrigger, object>? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3Type? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestMetadata? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem2>? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem2? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginDiscriminator? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginDiscriminatorId? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguard>? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicSpeed?, object>? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant1? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant1Type? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant2? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant2Type? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant3? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant3Type? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant4? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant4Type? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant1? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant1Type? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant2? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant2Type? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant3? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant3Type? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant4? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant4Type? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1InputSchema? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1Type? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2Name? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2Type? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3Name? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3Type? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4Name? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4Type? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5Name? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5Type? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6Name? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6Type? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerTool? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant13? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResult? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2ContextManagement? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit>? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesResultVariant2Usage>? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2Usage? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerToolType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesShellToolResultBlockFile>? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockFile? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockFileType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockType? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEvent? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessage? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageProvider? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageRole? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageType? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesStartEventMessageUsage>? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageUsage? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventType? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEvent? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEventType? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEvents? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminator? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminatorType? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamingResponse? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant1? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant1Type? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant2? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant2Type? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant3? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant3Type? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4Type? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockType? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant1? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant1Type? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant2? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant2Type? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant3? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant3Type? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockType? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MetadataLevel? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Model? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAliasTarget? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelBenchmarks? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelLinks? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerRequestLimits? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicPricing? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelReasoning? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Parameter>? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Parameter? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TopProviderInfo? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ReasoningEffort?, object>? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort?>? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelResponse? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponse? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponseData? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponse? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Model>? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponseLinks? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPluginId? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionTool? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolAllowedCaller? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolType? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>>? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceToolType? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NativeTools? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponse? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponseErrorData? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthErrorResponse? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthErrorResponseError? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwks? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OAuthJwksKey>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKey? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyAlg? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyCrv? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyKty? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyUse? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestination? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestinationConfig? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfig? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegion>? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDataRegion? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestinationType? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestination? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestinationConfig? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestinationType? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestination? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestinationConfig? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestinationType? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestination? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestinationConfig? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestinationType? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestination? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestination? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestination? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestination? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestination? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestination? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestination? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestination? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3Destination? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestination? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestination? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestination? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestination? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminator? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminatorType? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroup? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupLogic? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRule>? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRule? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRuleField? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRuleOperator? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup>? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestinationConfig? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestinationType? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestinationConfig? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestinationType? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestinationConfig? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestinationType? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationConfig? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationConfigRegion? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationType? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestinationConfig? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestinationType? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestinationConfig? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestinationType? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestinationConfig? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestinationType? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestinationConfig? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestinationType? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfig? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfigAuthMode? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfigProvider? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationType? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestinationConfig? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestinationType? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestinationConfig? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestinationType? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestinationConfig? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestinationType? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationConfig? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationConfigMethod? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationType? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileShape? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileObject? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFilePurpose? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileStatus? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeletedShape? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeletedObject? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileListShape? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIFile>? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileListObject? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallType? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item3>>? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item3>? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputVariant2Item3? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputType? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem>? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallType? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item4>>? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item4>? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputVariant2Item4? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminator? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputType? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentItem4>? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentItem4? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminator? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant1? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant2? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant3? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemType? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitation? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDeltaType? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDoneType? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompletedType? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgressType? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpretingType? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompletedType? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGeneratingType? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgressType? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImageType? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContentType? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompleted? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompletedType? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant1? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant2? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant3? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4Type? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1?, global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2?>? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowed? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7Type? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8Type? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesTruncation? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsageInputTokensDetails? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsageOutputTokensDetails? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgressType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearching? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearchingType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEvent? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEventVariant2? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorField? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorFieldCode? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorMetadata? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, global::OpenRouter.OpenResponsesErrorMetadataAlignment>? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorMetadataAlignment? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEvent? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEventVariant2? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesTopLogprobs>? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesTopLogprobs? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2AccessPrograms? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2AccessProgramsCyber? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItems? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfig? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OpenAIResponsesUsage, global::OpenRouter.UsageVariant12>? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileShape? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileType? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeletedShape? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeletedType? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileListShape? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenRouterFile>? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterAttempt? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterParams? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStage? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RoutingStrategy? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerToolType? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Operator? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OperatorName? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OperatorValueType? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicBashToolResultFile>? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultFile? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultFileType? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultType? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminator? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCaller? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminator? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlockType? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicShellToolResultFile>? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultFile? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultFileType? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultType? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultType? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultParamType? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrganizationSettings? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItemType? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItem? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItemType? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItemType? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItemStatus? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItemType? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputBashServerToolItemFile>? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemFile? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemFileType? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemType? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItemType? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItemType? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputComputerCallItemPendingSafetyCheck>? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemPendingSafetyCheck? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemStatus? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemType? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItem? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItemStatus? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItemType? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItemType? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItemType? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItemType? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItem? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemFailedModel>? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemFailedModel? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemResponse>? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemResponse? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionSource>? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemType? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItemVariant2? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItemType? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEvent? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Item? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventItemDiscriminator? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventItemDiscriminatorType? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventType? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Operation? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallOperationDiscriminator? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallOperationDiscriminatorType? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallStatus? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallType? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputsItem>? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputsItem? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminator? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallStatus? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallType? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCallStatus? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCallType? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEvent? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Item2? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventItemDiscriminator? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventItemDiscriminatorType? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventType? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchStatus? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCallType? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant1? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant2? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant3? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallType? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCallType? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputItemReasoningStatusVariant1?, global::OpenRouter.OutputItemReasoningStatusVariant2?, global::OpenRouter.OutputItemReasoningStatusVariant3?>? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant1? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant2? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant3? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningType? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItem? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItem? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItem? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminator? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorType? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant1? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSource? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant1Type? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant2? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant2Type? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant3? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant3Type? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallType? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMcpServerToolItemType? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemAction? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemType? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputMessagePhaseVariant1?, global::OpenRouter.OutputMessagePhaseVariant2?>? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhaseVariant1? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhaseVariant2? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageRole? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputMessageStatusVariant1?, global::OpenRouter.OutputMessageStatusVariant2?, global::OpenRouter.OutputMessageStatusVariant3?>? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant1? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant2? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant3? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageType? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModalityEnum? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemVariant2? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningFormat? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItemType? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemAction? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallStatus? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemType? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellCallOutputItemFile>? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemFile? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemFileType? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent>? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContent? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemType? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemAction? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellServerToolItemFile>? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemFile? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemFileType? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemType? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItemType? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemCommand? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemType? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItemExecution? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItemType? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputToolSearchServerToolItemMatche>? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemMatche? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemType? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItemType? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemAction? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSource>? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSource? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSourceType? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionType? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemType? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPluginId? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPluginPriceSource? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponse? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponseErrorData? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponse? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponseErrorData? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngine? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant1? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant2? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileLatencyCutoffs? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileThroughputCutoffs? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerfLast30mByWorkload? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Rerank? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Stt? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextGeneration? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Tts? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Unknown? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGeneration? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStageType? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>>? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentText? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionType? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentTextType? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMaxLatency? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMinThroughput? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetStatus? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersionVariant2? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerToolType? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocation? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerToolType? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocationType? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Pricing? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverride>? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverride? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverrideUtcDay>? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverrideUtcDay? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpoint? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettings? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointStatus? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointCheck? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointCheckReason? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointParameterCheck? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointQuantization? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointReasoningReturnMechanism? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointResponse? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsCompletions? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSettingsExcludedParameter>? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsExcludedParameter? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsInputs? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsReasoning? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsToolChoice? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidation? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck>? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointParameterCheck>? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidationResponse? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateProvider? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateProviderDataPolicy? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpointMode? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptionsMode? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOverloadedResponse? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOverloadedResponseErrorData? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesDataCollection? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesMaxPrice? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Quantization>? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Quantization? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseProviderName? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseRoutedServiceTier? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigBy? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigPartition? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.NativeTools>? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicServiceTier? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceSupport? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpoint? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpointVariant2? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapabilityType? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyItem? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMetaVersion? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyResponse? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RankingsDailyItem>? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningConfigVariant12? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDeltaEvent? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncryptedType? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCallType? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummaryType? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailTextType? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminator? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminatorType? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDoneEvent? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemVariant2? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartAddedEvent? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartDoneEvent? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextType? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDeltaEvent? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDoneEvent? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContentType? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDeltaEvent? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDoneEvent? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponse? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponseErrorData? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPluginId? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseIncludesEnum? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponsesAnnotation>? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprob>? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprob? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobTopLogprob>? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprobTopLogprob? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextType? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorFieldCode? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequest? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestAccessPrograms? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestAccessProgramsCyber? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem3? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginDiscriminator? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginDiscriminatorId? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestServiceTier? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolVariant1? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller>? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesStreamingResponse? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEvents? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilterOperator? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroupMappingRole? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimSyncJobStatus? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouterType? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputName>? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolInputName? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngine>? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngine? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolNativeSupport? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolStatus? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolSupportedApiFormat>? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolSupportedApiFormat? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ServerToolNativeSupport, global::OpenRouter.ServerToolDetailsVariant2NativeSupport>? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2NativeSupport? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolNativeModel>? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolNativeModel? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngineByok? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngineDataRegion>? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngineDataRegion? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolExecutedBy? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolPrice>? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolPrice? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEnginePricingSource? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputNameApiFormat>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolInputNameApiFormat? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolOutputName>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolOutputName? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolOutputNameApiFormat? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponse? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponseErrorData? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostItem? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostItemTurnRange? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostMeta? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostMetaVersion? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostResponse? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SessionCostItem>? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilterOperator? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemAction? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemType? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.ShellCallOutputContentOutcomeVariant1, global::OpenRouter.ShellCallOutputContentOutcomeVariant2>? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant1? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant1Type? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant2? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant2Type? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputItemFile>? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemFile? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemFileType? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemType? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolType? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolConfig? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouterType? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEngine? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironment? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminator? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInput? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechTurn? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReference? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudio? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceText? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImage? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminator? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminatorType? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudioInput? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudioType? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImageInput? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImageType? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceTextType? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequest? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputReference>? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProvider? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProviderDataCollection? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestResponseFormat? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenCondition? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIs? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCall? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsed? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCost? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIs? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminator? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIsType? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCallType? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCostType? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsedType? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIsType? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.InputText, global::OpenRouter.InputImage, global::OpenRouter.InputFile>? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompleted? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncomplete? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailed? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAdded? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDone? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEvent? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEvent? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallInProgressEvent? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallSearchingEvent? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallCompletedEvent? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminator? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminatorType? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompletedVariant2? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailedVariant2? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncompleteVariant2? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprob? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobVariant2? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StreamLogprobTopLogprob>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobTopLogprob? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTEntity? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInlineInputAudio? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInputAudio? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUrlInputAudio? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequest? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestProvider? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestProviderDataCollection? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestResponseFormat? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTTimestampGranularity? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTResponse? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTEntity>? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTSegment? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUsage? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWord? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWordType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentNestedTool? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoning? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoningEffort? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolConfig? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouterType? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequest? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequestCategory? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponse? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponseData? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPluginAlgorithm? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPluginId? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationItem? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationModel>? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationModel? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationMacroCategory? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponse? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponseData? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationItem>? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationMacroCategory>? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfigVerbosity? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEventVariant2? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StreamLogprob>? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEventVariant2? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2Verbosity? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequest? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestGrantType? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestRequestedTokenType? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestScope? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestSubjectTokenType? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponse? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponseIssuedTokenType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponseTokenType? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ToolChoiceAllowedModeVariant1?, global::OpenRouter.ToolChoiceAllowedModeVariant2?>? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedModeVariant1? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedModeVariant2? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedType? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemExecution? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemStatus? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemType? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemExecution? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemStatus? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ToolSearchOutputItemTool>? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemTool? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ToolSearchOutputItemToolAllowedCaller>? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemToolAllowedCaller? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemTool2? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemType? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerToolConfig? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerToolType? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponse? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponseErrorData? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponse? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponseErrorData? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarkPricing? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksAAItem? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksAAItemSource? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItem? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItemSource? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItemTournamentStats? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMeta? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaSource? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaVersion? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItem? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItemBenchmarkType? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItemSource? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponse? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItem? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemBenchmarkType? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemPrimaryMetric? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchRunConfig? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemSearchSurface? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemSource? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponse? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponseErrorData? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequest? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequestDeclaredRegion? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyResponse? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateExternalUserRequest? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailRequest? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailResponse? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationRequest? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponse? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateOrganizationSettingsRequest? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointParametersRequest? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointPricingRequest? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointRequest? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.PrivateEndpointPricing, object>? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestCompletions? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestInputs? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestReasoning? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestToolChoice? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderRequest? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderRequestDataPolicy? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingRequest? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingRequestRole? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingResponse? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequest? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceResponse? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetRequest? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetResponse? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitationType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageVariant12? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageVariant1CostDetails? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ValidatePrivateEndpointRequest? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecret? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecretScope? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecretListResponse? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultEffectiveSecret>? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTable? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableCustomOrigin>? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOrigin? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOriginStatus? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOriginStatusState? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithub? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubApp>? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubApp? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppInstallation>? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallation? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationAccountType? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverage? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverageSelection? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationShadowedBy? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppMemberLink>? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppMemberLink? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppMemberLinkVia? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppScope? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubToken>? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubToken? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubTokenScope? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogle? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGoogleAccount>? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogleAccount? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogleAccountScope? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableHostRule>? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableHostRule? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOrigin>? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOrigin? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOriginRoute>? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginRoute? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginStatus? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginStatusState? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSecret>? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSecret? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSecretScope? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSlack? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSlackMemberLink>? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSlackMemberLink? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecret? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretCopyRequest? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretCopyResponse? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret>? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretListResponse? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretResponse? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretWriteRequest? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequest? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestAspectRatio? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestProvider? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestResolution? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponse? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponseStatus? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationUsage? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModel? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatio>? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedAspectRatio? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImage>? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedFrameImage? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolution>? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedResolution? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSize>? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedSize? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelUpscaleFactor? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelsListResponse? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModel>? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchEngineEnum? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPluginId? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolConfig? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolType? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngine? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPluginId? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.WebSearchUserLocation, object>? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolType? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolConfig? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouterType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSourceType? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationType? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerToolType? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetResetInterval? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetInterval? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMemberRole? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequest? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestClassifierDimensions? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestClassifierFilters? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ClassifierFiltersFilter>? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Filter>? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestOrderBy? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestOrderByDirection? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestTimeRange? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequest? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequestResponseFormat? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequest? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequest? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequestCodeChallengeMethod? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequestUsageLimitType? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequest? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestEncodingFormat? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1Type? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2ImageUrl? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UploadFileRequest? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequest? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequestExternal? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequestLimitReset? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequest? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequestLimitReset? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequest? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>>? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequestDocument? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetUserActivityGroupBy? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchListStatus>? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BatchListTimestamp?, object>? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksSource? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksTaskType? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksBenchmarkType? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksSearchSurface? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksArena? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysProvider? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetTaskClassificationsWindow? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsCategory? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsSubcategory? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsSort? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyPeriod? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyModality? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyContextBucket? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyCategory? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyLanguageType? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetSessionCostTurnRange? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListFilesOrder? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsCategory? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsSort? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsDistillable? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsZdr? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsRegion? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelsUserSort? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelsUserClient? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointDraftOnly? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.DeleteScimGroupMappingKeepMembers2?, bool?>? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteScimGroupMappingKeepMembers2? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsApiFormat? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponse? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseData? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataDimension>? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataDimension? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie>? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataGranularitieName? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataMetric>? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataMetric? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataMetricDisplayFormat? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Operator>? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponse? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponseData? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponseDataMetadata? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyResponse? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeResponse? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeResponseData? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCreditsResponse? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCreditsResponseData? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponse? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsResponseDataItem>? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseDataItem? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseDataItemObject? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseObject? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseUsage? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseUsagePromptTokensDetails? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsZdrResponse? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicZdrEndpoint>? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponse? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseData? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion>? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyBudget>? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseDataRateLimit? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListResponse? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListResponseDataItem>? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListResponseDataItem? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysResponse? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysResponseData? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteKeysResponse? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetKeyResponse? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetKeyResponseData? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysResponse? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysResponseData? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse2? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponse? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListOrganizationMembersResponseDataItem>? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponseDataItem? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponseDataItemRole? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetOrganizationSettingsResponse? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateOrganizationSettingsResponse? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.NotFoundResponse>? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.ConflictResponse>? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.UnprocessableEntityResponse>? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.InternalServerResponse>? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.BadGatewayResponse>? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPrivateProvidersResponse? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateProvider>? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateProviderResponse? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateProviderResponse? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateProviderResponseData? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPrivateProviderResponse? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderResponse? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponse? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItem>? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItem? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItemDatacenter? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItemHeadquarters? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponse? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateRerankResponseResult>? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseResult? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseResultDocument? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseUsage? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListInternConnectionsResponse? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListInternConnectionsResponseDataItem>? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListInternConnectionsResponseDataItem? Type2674 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ActivityItem>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AdditionalToolsItemToolAllowedCaller>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.AgentMessageItemContentItem2>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentCallRecord>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentRuleRecord>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentChatImage>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentChatToolCall>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentRule>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentResponsesRejectedItem>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AlignmentRuleWatchItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicAllowedCaller>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicBashCodeExecutionOutput>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicCodeExecutionOutput>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicContainerSkill>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.ContentVariant2Item>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentVariant2Item>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicFile>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextCitation>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CitationsItem>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicToolReference>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResult>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AppRankingsItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.ContentVariant1Item>, string>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentVariant1Item>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicContentBlock>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicInputTransformation>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicUsageIteration>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenResponsesLogProbs>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchListItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResult>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<long>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>?>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ArmorSafeguardResult>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<double>, string>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchSubmitBodyRequest>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceMember>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatAssistantImage>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningDetailUnion>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatToolCall>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AllOf<string, object>>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatMessages>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatRequestModalitie>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StopServerToolsWhenCondition>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatFunctionTool>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatChoice>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatStreamChoice>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatStreamToolCall>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprobTopLogprob>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprob>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?>>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContainerFile>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GuardrailDataRegion>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntryInput>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterEntry>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDataRegionInput>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointDeclaredParameter>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.List<object>>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>, string>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EndpointInfo>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<double?, string>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ExtractionForecastStep>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<long>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?>>>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FunctionCallItemSubagentItem>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradiction>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradictionStance>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultPartialCoverageItem>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultUniqueInsight>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionPluginTool>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?, bool?>?>, object>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?, bool?>?>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionServerToolConfigTool>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GenerationContentErrorAttempt>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntry>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.List<object>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImagePricingEntry>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentPartImage>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationResponseDataItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageInputModality>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageOutputModality>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageEndpoint>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageModelListItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningSummaryText>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BYOKKey>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputModality>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModality>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicEndpoint>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ExternalUser>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Guardrail>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDestination>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Preset>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PresetDesignatedVersion?>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointSummary>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ScimGroupMapping>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ScimGroup>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerTool>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceBudget>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Workspace>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.McpListToolsItemTool>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<string>, global::OpenRouter.McpServerToolAllowedTools>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesBashToolResultBlockFile>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicSafeguardResult>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.List<string>>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesFallbackParam>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem2>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicSafeguard>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesShellToolResultBlockFile>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Parameter>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.DABenchmarkEntry>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningEffort?>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Model>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OAuthJwksKey>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDataRegion>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroupRule>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroup>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIFile>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item3>>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item3>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item4>>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item4>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentItem4>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenResponsesTopLogprobs>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItems>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenRouterFile>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RouterAttempt>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PipelineStage>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicBashToolResultFile>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicShellToolResultFile>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputBashServerToolItemFile>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputComputerCallItemPendingSafetyCheck>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFusionServerToolItemFailedModel>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFusionServerToolItemResponse>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionSource>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputsItem>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningTextContent>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WebSearchSource>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellCallOutputItemFile>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputContent>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellServerToolItemFile>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputToolSearchServerToolItemMatche>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputWebSearchServerToolItemActionSource>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverride>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverrideUtcDay>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointSettingsExcludedParameter>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointCheck>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointParameterCheck>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Quantization>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RankingsDailyItem>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponsesAnnotation>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprob>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobTopLogprob>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseIncludesEnum>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModalityEnum>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem3>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolInputName>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolEngine>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolSupportedApiFormat>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolNativeModel>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolEngineDataRegion>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolPrice>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolInputNameApiFormat>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolOutputName>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SessionCostItem>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputItemFile>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SpeechTurn>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SpeechInputReference>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StreamLogprobTopLogprob>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTTimestampGranularity>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTEntity>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTSegment>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTWord>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SubagentNestedTool>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationModel>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationItem>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationMacroCategory>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StreamLogprob>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ToolSearchOutputItemToolAllowedCaller>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultEffectiveSecret>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableCustomOrigin>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubApp>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubAppInstallation>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubAppMemberLink>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubToken>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGoogleAccount>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableHostRule>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableMcpOrigin>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableMcpOriginRoute>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableSecret>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableSlackMemberLink>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultSecret>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FrameImage>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputReference>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedAspectRatio>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedFrameImage>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedResolution>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedSize>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModel>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ClassifierFiltersFilter>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Filter>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchListStatus>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataDimension>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataMetric>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Operator>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsResponseDataItem>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicZdrEndpoint>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyBudget>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListResponseDataItem>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListOrganizationMembersResponseDataItem>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateProvider>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListProvidersResponseDataItem>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateRerankResponseResult>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListInternConnectionsResponseDataItem>? ListType269 { get; set; }
    }
}