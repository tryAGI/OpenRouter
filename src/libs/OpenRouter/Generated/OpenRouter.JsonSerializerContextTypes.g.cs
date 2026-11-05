
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
        public global::OpenRouter.OutputItemCompaction? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItemDiscriminator? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItemDiscriminatorType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleWatchItem>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRuleWatchItem? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecordOutcome? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecordReason? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnnotationAddedEvent? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEvent? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBaseUsageIteration? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2Type? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResult? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResultType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCaller>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAllowedCaller? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSource? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageMimeType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSourceType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSource? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceMediaType? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceType? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicIterationCacheCreation? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResult? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutput? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutputType? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicBashCodeExecutionOutput>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResultType? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultType? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirective? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlTtl? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirectiveType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheCreation? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCaller? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCaller? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminator? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminatorType? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocation? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationType? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParam? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParamType? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocation? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParamType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocation? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParam? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParamType? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationsConfig? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocation? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationType? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParamType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825CallerType? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120CallerType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContent? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResult? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminator? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutput? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutputType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicCodeExecutionOutput>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResultType? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResult? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultType? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolErrorCode? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultErrorType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlock? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlockType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIteration? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2Type? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainer? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicContainerSkill>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerSkill? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerSkillType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUpload? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUploadType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCallerType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlock? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.AnthropicBase64PdfSource, global::OpenRouter.AnthropicPlainTextSource>? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSource? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockType? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParam? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamCitations? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSource? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant2Item>>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant2Item>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentVariant2Item? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParam? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParam? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminator? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSource? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSource? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResultType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFile? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileShape? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeleted? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeletedShape? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeletedType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSourceType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileList? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileListShape? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicFile>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Source3? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSource? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminator? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeast? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeastType? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTrigger? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTriggerType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTransformation? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageOutputConfig? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputEffort? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseError? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiErrorType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseErrorType? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseType? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIteration? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2Type? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputTokensDetails? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceMediaType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceType? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlock? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlockType? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetails? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsCategory? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsType? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguard? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguardResult? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguardResultStatus? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParam? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamCitations? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamType? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolUsage? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServiceTier? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSpeed? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSystemClearAt? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlock? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitation? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CitationsItem>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CitationsItem? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminator? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminator? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminatorType? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContent? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultType? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlock? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockType? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBinding? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBindingMismatchBehavior? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBindingPrefixMismatchBehavior? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingDisplay? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurns? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurnsType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReference? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReferenceType? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContent? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultError? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResult? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminator? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultErrorType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25Name? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25Type? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegex? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegexName? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegexType? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResult? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResultType? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnion? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1InputSchema? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1InputSchemaType? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1Type? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2Name? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2Type? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3Name? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3Type? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4Name? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4Type? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocation? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5Name? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5Type? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlock? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlockType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeep? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeepType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTrigger? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTriggerType? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIteration? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIterationVariant2? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSourceType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSourceType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsage? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsageIteration? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlock? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlockType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContent? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultError? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminator? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminatorType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResult? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResult? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultType? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParam? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParamType? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResult? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultError? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorType? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocationType? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItem? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallStatus? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemType? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperation? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperation? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperation? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminator? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEventType? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEventType? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItem? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemStatus? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperationType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperationType? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchEngineEnum? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolType? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolConfig? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouterType? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperationType? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsItem? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsResponse? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMeta? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorAutoMode? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorRule? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorEnvironmentEntry? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorContext? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPlugin? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginId? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginMode? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginOnError? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginOutputMode? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResult? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatus? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Outcome? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Type? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant2? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant2Type? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant3Type? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultType? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPlugin? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPluginCostTier? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPluginId? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPlugin? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPluginCostTier? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPluginId? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponse? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponseErrorData? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponse? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponseErrorData? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesAnnotation? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEventType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEvent? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputText? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContent? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEventType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEvent? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEventType? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEvent? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEventType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEvent? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEventType? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEvent? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEventType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEvent? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEventType? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEvent? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEventType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputs? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2Item2? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>, string>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentVariant1Item? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFile? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudio? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminator? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1?, global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2?>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant1? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant2? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant3? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant4? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItem? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCall? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCall? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateItem? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResult? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock>? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlock? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicInputTransformation>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultRole? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicStopReason? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultType? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BaseMessagesResultUsage>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultUsage? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningConfig? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningContext? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningEffort? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningMode? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryVerbosity? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDeltaEvent? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDeltaEventType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEvent? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEventType? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartAddedEvent? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryText? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartAddedEventType? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEvent? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEventType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEventType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEvent? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEventType? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEvent? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEventType? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEvent? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEventType? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResult? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorField? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetails? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultObject? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItem>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItem? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminator? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminatorType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StoredPromptTemplate? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptions? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceTier? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesResponseStatus? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfig? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoice? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.BaseResponsesResultToolVariant1>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultToolVariant1? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Truncation? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsage? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEvent? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesLogProbs>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesLogProbs? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEventType? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEvent? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEventType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolConfig? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEngine? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironment? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironment? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironment? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminator? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminatorType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletedObject? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargets? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletedObjectObject? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionOutcome? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargetsOpenrouter? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargetsUpstream? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchErrorResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchErrorResponseError? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItem? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemCompletionWindow? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemError? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemObject? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemRequestCounts? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemStatus? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsage? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsageCompletionTokensDetails? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CostDetails? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsagePromptTokensDetails? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsageServerToolUse? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListResponse? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchListItem>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListResponseObject? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListStatus? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListTimestamp? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObject? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectCompletionWindow? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectError? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectObject? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectRequestCounts? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResult>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResult? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultError? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponse? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FinishReason? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobs? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob>? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessage? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1Type? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2ImageUrl? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2UrlCitation? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageImageUrl? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>?>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummary? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncrypted? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailText? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCall? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageRole? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCallFunction? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCallType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Debug? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimings? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimingsEvent? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Object? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterMetadata? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ArmorSafeguardResult>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Usage? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageCompletionTokensDetails? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsagePromptTokensDetails? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUse? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUseDetails? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResult? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Role? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Type? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BatchObjectResultResponseBodyVariant3Usage>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Usage? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<double>, string>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItemObject? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Object? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Usage? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4UsagePromptTokensDetails? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectStatus? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsage? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsageCompletionTokensDetails? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsagePromptTokensDetails? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsageServerToolUse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponse? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseError? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseObject? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseRequestCounts? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseStatus? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsage? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsageCompletionTokensDetails? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsagePromptTokensDetails? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsageServerToolUse? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchProviderPreferences? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderName? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBody? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyCompletionWindow? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyEndpoint? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapability? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapabilityType? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersRequest? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersResponse? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMember? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysRequest? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysResponse? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersRequest? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersResponse? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersRequest? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersResponse? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysRequest? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysResponse? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersRequest? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersResponse? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKey? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKeyDeclaredRegion? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKProviderSlug? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptor? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapability? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapability? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminator? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminatorType? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImage>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImage? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImageImageUrl? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessage? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAudioOutput? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItems? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessageRole? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCall? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatChoice? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFinishReasonEnum? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobs? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudio? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudioInputAudio? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudioType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentCacheControl? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFile? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFileFile? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFileType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImage? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageImageUrl? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageImageUrlDetail? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentText? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideo? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideo? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminator? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpoint? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentTextType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInput? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInputProcessing? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDebugOptions? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessage? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdate3? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessageRole? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDynamicServerTool? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfig? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfigType? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfig? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfigType? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfig? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatJsonSchemaConfig? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfigType? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfig? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfigType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfig? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfigType? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionTool? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1Function? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1Type? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerTool? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerTool? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthand? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessages? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessage? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessage? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessage? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminator? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorRole? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AllOf<string, object>>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<string, object>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoice? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceFunction? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceType? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnion? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatReasoningSummaryVerbosityEnum? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequest? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControl? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageConfig? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitie>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestModalitie? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPlugin? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPlugin? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPlugin? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPlugin? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPlugin? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPlugin? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPlugin? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPlugin? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPlugin? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPlugin? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminator? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminatorId? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Prediction? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferences? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoning? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort2? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseFormat? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminator? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminatorType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeprecatedRoute? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestServiceTier? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamOptions? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TraceConfig? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResult? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResultObject? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsage? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolConfig? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerToolType? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatServerToolChoice? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChoice? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamDelta? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunk? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, object>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamChoice>? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkError? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkErrorMetadata? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkObject? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ChatAudioOutput, object>? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamDeltaRole? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamToolCall>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCall? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamingResponse? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCallFunction? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCallType? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessageRole? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprob? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprobTopLogprob>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobTopLogprob? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprob>? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallFunction? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallType? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant1? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant2? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant3? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessageRole? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsageCompletionTokensDetails? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsDetails? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsagePromptTokensDetails? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolUseDetails? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessageRole? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngineEnum? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchMode? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchConfig? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchQualityLevel? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthandType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerTool? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.XSearchOptions? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierFiltersFilter? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierScalarFilter? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierSetFilter? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierScalarFilterOperator? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?>? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierSetFilterOperator? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClientClosedRequestResponse? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClientClosedRequestResponseErrorData? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDoneEvent? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCompletedEvent? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInProgressEvent? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInterpretingEvent? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallItem? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutput? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutputType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutput? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutputType? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutput? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutputType? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.CodeInterpreterServerToolContainer>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainer? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerMemoryLimit? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerType? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolType? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellToolType? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItem? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItemType? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionTriggerItem? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionTriggerItemType? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEvent? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEventType? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilter? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilterType? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolEnvironment? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolType? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateReasoning? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateItemType? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateReasoningEffort? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponse? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponseErrorData? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicy? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironmentType? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFile? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileObject? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileSource? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileListResponse? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContainerFile>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileListResponseObject? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1Type? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2Type? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironmentType? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterAction? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinAction? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntry? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptInjectionScanScope? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinSlug? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntryInput? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterEntry? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEvent? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEventVariant2? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.ReasoningTextContent, global::OpenRouter.OpenAIResponsesRefusalContent>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContent? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudio? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudioAudioUrl? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudioType? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEvent? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEventVariant2? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImage? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImageImageUrl? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImageType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudio? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MultimodalMedia? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudioType? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFile? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFileType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideo? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideoType? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideo? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideoType? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideoVideoUrl? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItem? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItemType? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionEngine? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPluginId? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequest? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequestDeclaredRegion? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BYOKKey, object>? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEvent? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEventType? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateExternalUserRequest? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailRequest? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailDataRegion? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailInterval? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailResponse? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Guardrail, object>? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Guardrail? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequest? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfigNullable? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDataRegionInput? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequestType? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponse? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestination? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePresetFromInferenceResponse? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersion? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointRequest? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointActivation? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointDeclaredParameter? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointPricing? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequest? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponse? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponseData? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpoint? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidationNullable? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponseError? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateProviderRequest? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingRequest? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingRequestRole? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingResponse? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroupMapping? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimSyncJobResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimSyncJob? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequest? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequestDisabledServerTool? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceResponse? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Workspace, object>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Workspace? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CustomToolFormatVariant1, global::OpenRouter.CustomToolFormatVariant2>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant1? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant1Type? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2Syntax? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2Type? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolType? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDeltaEvent? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDoneEvent? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItem? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolCallStatus? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItemType? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItem? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemVariant2? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DABenchmarkEntry? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolConfig? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolType? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEvent? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebug? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebugTimings? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebugTimingsEvent? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Decisions? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object>? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileStats? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswer? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswerBox? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswerType? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxQuestion? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxQuestionType? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswer? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswerType? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestion? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestionType? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAsset? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAssetFormat? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAssetType? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswer? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswerType? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestion? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestionCriteria? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestionType? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRefusalAnswer? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRefusalAnswerType? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequest? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.DecisionsImageAsset>? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Questions? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestion? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminator? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponse? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.DecisionsUrlCitationAnnotation>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUrlCitationAnnotation? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Answers? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswer? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminator? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminatorType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseUsage? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUsageInputTokensDetails? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswerType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestionType? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUrlCitationAnnotationType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUrlCitationAnnotationUrlCitation? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DefaultParameters? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25Search? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25SearchType? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearch? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearchType? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearch? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearchType? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlProfile? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlProtocol? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategy? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlValidation? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminator? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteBYOKKeyResponse? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteGuardrailResponse? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteObservabilityDestinationResponse? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointResponse? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointResponseData? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteScimGroupMappingResponse? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceBudgetResponse? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceResponse? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessage? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>, string>? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideo? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.EasyInputMessagePhaseVariant1?, global::OpenRouter.EasyInputMessagePhaseVariant2?>? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhaseVariant1? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhaseVariant2? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant1? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant2? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant3? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant4? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageType? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EdgeNetworkTimeoutResponse? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EdgeNetworkTimeoutResponseErrorData? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Embeddings? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointInfo? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointsMetadata? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo>? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapabilityType? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ErrorEvent? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExternalUser? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExternalUserResponse? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAsset? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAssetFormat? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAssetType? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswer? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswerSource? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswerType? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateField? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateFieldType? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswer? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswerSource? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswerType? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeField? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeFieldType? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswer? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswerSource? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswerType? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationField? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationFieldType? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswer? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, string>? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswerSource? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswerType? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateField? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldScale? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionEstimateFieldStepVariant2?, global::OpenRouter.ExtractionEstimateFieldStepVariant3?>? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldStepVariant2? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldStepVariant3? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldType? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswer? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswerSource? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ExtractionForecastStep>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastStep? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswerType? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastField? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldInterval? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldScale? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionForecastFieldStepVariant2?, global::OpenRouter.ExtractionForecastFieldStepVariant3?>? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldStepVariant2? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldStepVariant3? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldType? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswer? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswerSource? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<long>>? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswerType? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListField? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListFieldItems? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListFieldType? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswer? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswerSource? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswerType? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberField? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberFieldType? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Extractions? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequest? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ExtractionAsset>? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Fields? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextField? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeField? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminator? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponse? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Answers2? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswer? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswer? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminator? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsUsage? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswerSource? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswerType? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextFieldType? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswerSource? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswerType? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeFieldType? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailableToolCallStatus? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEvent? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEventType? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitation? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitationType? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponse? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeleted? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeleted? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminator? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminatorShape? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponse? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileList? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileList? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminator? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminatorShape? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPluginId? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserOptions? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePath? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePathType? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileProvider? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponse? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFile? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFile? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminator? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminatorShape? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.FileSearchServerToolFilters, global::OpenRouter.CompoundFilter>? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFilters? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFiltersType? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>>? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptions? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptionsRanker? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolConfig? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolType? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Filter? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilter? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilter? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponse? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponseErrorData? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfig? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfigType? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfig? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfigType? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Formats? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfig? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfigType? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImage? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2FrameType? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FreeModelDailyRequests? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDeltaEvent? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDoneEvent? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItem? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallItemSubagentItem>? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemSubagentItem? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemType? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItem? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemVariant2? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionToolType? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResult? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradiction>? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradiction? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionStance>? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradictionStance? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItem>? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultPartialCoverageItem? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsight>? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultUniqueInsight? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEvent? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEventType? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEvent? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEventType? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEvent? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEventType? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEvent? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEventType? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEvent? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEventType? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEvent? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEventType? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEvent? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEventType? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEvent? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEventType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEvent? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEventType? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginId? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginPreset? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionPluginTool>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginTool? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?, bool?>?>, object>? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?, bool?>?>? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?>? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfig? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouterType? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoning? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoningEffort? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigTool>? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigTool? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionSource? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GatewayTimeoutResponse? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GatewayTimeoutResponseErrorData? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentData? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentError? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.GenerationContentDataInputVariant1, global::OpenRouter.GenerationContentDataInputVariant2>? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInputVariant1? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInputVariant2? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataOutput? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GenerationContentErrorAttempt>? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentErrorAttempt? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentResponse? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponse? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseData? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataApiType? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataDataRegion? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponse? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBYOKKeyResponse? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetGuardrailResponse? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponse? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetVersionResponse? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetDesignatedVersion? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetScimGroupMappingResponse? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetScimSyncJobResponse? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetToolResponse? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetails? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceBudgetResponse? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.WorkspaceBudget, object>? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudget? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceResponse? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GoneResponse? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GoneResponseErrorData? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<object>>? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageEndpoint? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry>? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntry? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>, object>? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallCompletedEvent? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompleted? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallGeneratingEvent? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGenerating? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallInProgressEvent? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgress? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallPartialImageEvent? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCompletedEvent? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCompletedEventType? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsage? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGeneration? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferences? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOptions? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig>? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSort? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfig? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequest? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestAspectRatio? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestBackground? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ContentPartImage, object>? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestOutputFormat? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestQuality? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestResolution? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponse? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItem>? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponseDataItem? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolBackground? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputFidelity? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputImageMask? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolModeration? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOutputFormat? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolQuality? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolConfig? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouterType? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationStatus? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageCompletionTokensDetails? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsagePromptTokensDetails? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageServerToolUse? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenPartialImageEvent? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenPartialImageEventType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEvent? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEventError? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEventType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEvent? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEventPhase? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEventType? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageInputModality? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelArchitecture? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageInputModality>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality>? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageOutputModality? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelEndpointsResponse? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelListItem? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelsListResponse? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem>? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryBillable? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryUnit? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageStreamingResponse? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ImageGenPartialImageEvent, global::OpenRouter.ImageGenTextChunkEvent, global::OpenRouter.ImageGenCompletedEvent, global::OpenRouter.ImageGenStreamErrorEvent>? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetailsReason? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEvent? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEventType? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEvent? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEventType? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioInputAudio1? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioInputAudio1Format? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFileType? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImageDetail? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImageType? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItem? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.InputMessageItemRoleVariant1?, global::OpenRouter.InputMessageItemRoleVariant2?, global::OpenRouter.InputMessageItemRoleVariant3?>? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant1? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant2? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant3? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemType? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputModality? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReference? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminator? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorType? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Inputs? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItem? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItem? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant82? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string>? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant8Type? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItem? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant92? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItem? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItem? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItem? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItem? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItem? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItem? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItem? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItem? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItem? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItem? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItem? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItem? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItem? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItem? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItem? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItem? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItem? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItem? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItem? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItem? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItem? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItem? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItem? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItem? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItem? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItem? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItem? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItem? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItem? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItem? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItem? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItem? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItem? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItem? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputTextType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoProcessing? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoType? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InstructType? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponse? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponseErrorData? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItemType? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPluginId? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyAssignment? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudget? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudgetResetInterval? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudgetScope? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoType? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInput? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInputProcessing? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchDomainFilter? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchContextSizeEnum? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerToolType? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocation? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysResponse? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BYOKKey>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ModelArchitecture, global::OpenRouter.ListEndpointsResponseArchitecture>? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelArchitecture? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponseArchitecture? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputModality>? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModality? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelGroup? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpoint? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListExternalUsersResponse? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ExternalUser>? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListGuardrailsResponse? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListKeyAssignmentsResponse? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListMemberAssignmentsResponse? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MemberAssignment? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListObservabilityDestinationsResponse? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetsResponse? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Preset>? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preset? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetVersionsResponse? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PresetDesignatedVersion?>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPrivateEndpointsResponse? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSummary>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSummary? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListScimGroupMappingsResponse? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ScimGroupMapping>? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListScimGroupsResponse? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ScimGroup>? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroup? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsResponse? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerTool>? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerTool? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsResponseLinks? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceBudgetsResponse? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget>? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceMembersResponse? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspacesResponse? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Workspace>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemAction? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemActionType? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemType? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItemType? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointVariant2? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointDeclaredRegion? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointResponse? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItemType? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItemType? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDeltaEvent? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDeltaEventType? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDoneEvent? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDoneEventType? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallCompletedEvent? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallCompletedEventType? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallFailedEvent? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallFailedEventType? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallInProgressEvent? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallInProgressEventType? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolCallError? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItemType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpError? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpErrorType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsCompletedEvent? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsCompletedEventType? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsFailedEvent? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsFailedEventType? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsInProgressEvent? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsInProgressEventType? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.McpListToolsItemTool>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemTool? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemType? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolError? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolErrorType? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolAllowedTools>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolAllowedTools? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolConnectorId? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Always? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Never? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant2? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant3? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolType? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionError? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionErrorType? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlock? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlockType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlock? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesBashToolResultBlockFile>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockFile? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockFileType? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockType? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEvent? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1Type? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2Type? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3Type? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4Type? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Citation? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5Type? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6Type? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventType? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEvent? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlock? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResult? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResult? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResult? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventContentBlock? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventContentBlockType? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventType? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEvent? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEventType? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEvent? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventDelta? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventType? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventUsage? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUsage? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEvent? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEventError? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEventType? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesFallbackParam? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParam? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4Type? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5ContentVariant2Item? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5Type? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6Type? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7Type? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8Type? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content>? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9ContentErrorCode? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9ContentType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Type? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11Type? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlock? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlock? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlock? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultParam? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamRole? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfig? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigEffort? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormat? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormatType? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudget? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudgetType? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEvent? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEventType? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequest? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagement? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Trigger? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminator? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1Type? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnumType? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum2? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2Type? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicInputTokensTrigger, object>? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3Type? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestMetadata? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem2>? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem2? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginDiscriminator? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginDiscriminatorId? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguard>? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicSpeed?, object>? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant1? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant1Type? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant2? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant2Type? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant3? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant3Type? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant4? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant4Type? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant1? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant1Type? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant2? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant2Type? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant3? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant3Type? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant4? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant4Type? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1InputSchema? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1Type? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2Name? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2Type? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3Name? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3Type? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4Name? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4Type? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5Name? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5Type? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6Name? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6Type? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerTool? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant13? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResult? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2ContextManagement? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit>? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesResultVariant2Usage>? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2Usage? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2UsageDeferredToolsDetails? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerToolType? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesShellToolResultBlockFile>? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockFile? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockFileType? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockType? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEvent? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessage? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageProvider? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageRole? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageType? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesStartEventMessageUsage>? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageUsage? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventType? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEvent? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEventType? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEvents? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminator? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminatorType? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamingResponse? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant1? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant1Type? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant2? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant2Type? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant3? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant3Type? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4Type? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockType? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant1? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant1Type? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant2? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant2Type? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant3? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant3Type? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockType? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MetadataLevel? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Model? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAliasTarget? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelBenchmarks? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelLinks? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerRequestLimits? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicPricing? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelReasoning? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Parameter>? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Parameter? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TopProviderInfo? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ReasoningEffort?, object>? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort?>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelResponse? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponse? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponseData? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponse? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Model>? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponseLinks? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPluginId? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionTool? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolAllowedCaller? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolType? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>>? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceToolType? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NativeTools? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponse? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponseErrorData? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthErrorResponse? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthErrorResponseError? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwks? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OAuthJwksKey>? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKey? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyAlg? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyCrv? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyKty? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyUse? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestination? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestinationConfig? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfig? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegion>? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDataRegion? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestinationType? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestination? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestinationConfig? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestinationType? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestination? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestinationConfig? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestinationType? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestination? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestinationConfig? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestinationType? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestination? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestination? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestination? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestination? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestination? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestination? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestination? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestination? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3Destination? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestination? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestination? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestination? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestination? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminator? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminatorType? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroup? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupLogic? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRule>? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRule? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRuleField? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRuleOperator? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup>? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestinationConfig? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestinationType? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestinationConfig? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestinationType? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestinationConfig? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestinationType? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationConfig? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationConfigRegion? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationType? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestinationConfig? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestinationType? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestinationConfig? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestinationType? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestinationConfig? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestinationType? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestinationConfig? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestinationType? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfig? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfigAuthMode? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfigProvider? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationType? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestinationConfig? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestinationType? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestinationConfig? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestinationType? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestinationConfig? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestinationType? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationConfig? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationConfigMethod? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationType? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileShape? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileObject? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFilePurpose? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileStatus? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeletedShape? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeletedObject? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileListShape? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIFile>? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileListObject? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallType? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item3>>? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item3>? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputVariant2Item3? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputType? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem>? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallType? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item4>>? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item4>? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputVariant2Item4? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminator? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputType? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentItem4>? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentItem4? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminator? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant1? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant2? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant3? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemType? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitation? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDeltaType? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDoneType? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompletedType? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgressType? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpretingType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompletedType? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGeneratingType? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgressType? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImageType? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContentType? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompleted? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompletedType? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant1? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant2? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant3? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4Type? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1?, global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2?>? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowed? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7Type? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8Type? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesTruncation? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsageInputTokensDetails? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsageOutputTokensDetails? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgressType? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearching? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearchingType? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEvent? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEventVariant2? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorField? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorFieldCode? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorMetadata? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, global::OpenRouter.OpenResponsesErrorMetadataAlignment>? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorMetadataAlignment? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEvent? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEventVariant2? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesTopLogprobs>? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesTopLogprobs? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2AccessPrograms? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2AccessProgramsCyber? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItems? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfig? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OpenAIResponsesUsage, global::OpenRouter.UsageVariant12>? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileShape? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileType? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeletedShape? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeletedType? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileListShape? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenRouterFile>? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterAttempt? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterParams? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStage? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RoutingStrategy? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerToolType? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Operator? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OperatorName? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OperatorValueType? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicBashToolResultFile>? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultFile? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultFileType? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultType? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminator? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCaller? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminator? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlockType? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicShellToolResultFile>? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultFile? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultFileType? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultType? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultType? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultParamType? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrganizationSettings? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItemType? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItem? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItemType? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItemType? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItemStatus? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItemType? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputBashServerToolItemFile>? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemFile? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemFileType? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemType? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItemType? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItemType? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCompactionItem? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCompactionItemType? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputComputerCallItemPendingSafetyCheck>? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemPendingSafetyCheck? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemStatus? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemType? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItem? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItemStatus? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItemType? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItemType? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItemType? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItemType? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItem? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemFailedModel>? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemFailedModel? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemResponse>? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemResponse? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionSource>? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemType? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItemVariant2? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItemType? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEvent? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Item? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventItemDiscriminator? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventItemDiscriminatorType? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventType? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Operation? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallOperationDiscriminator? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallOperationDiscriminatorType? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallStatus? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallType? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputsItem>? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputsItem? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminator? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallStatus? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallType? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCompactionType? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCallStatus? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCallType? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEvent? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Item2? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventItemDiscriminator? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventItemDiscriminatorType? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventType? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchStatus? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCallType? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant1? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant2? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant3? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallType? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCallType? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputItemReasoningStatusVariant1?, global::OpenRouter.OutputItemReasoningStatusVariant2?, global::OpenRouter.OutputItemReasoningStatusVariant3?>? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant1? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant2? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant3? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningType? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItem? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItem? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItem? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminator? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorType? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant1? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSource? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant1Type? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant2? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant2Type? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant3? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant3Type? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallType? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemAction? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemType? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputMessagePhaseVariant1?, global::OpenRouter.OutputMessagePhaseVariant2?>? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhaseVariant1? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhaseVariant2? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageRole? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputMessageStatusVariant1?, global::OpenRouter.OutputMessageStatusVariant2?, global::OpenRouter.OutputMessageStatusVariant3?>? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant1? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant2? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant3? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageType? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModalityEnum? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemVariant2? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningFormat? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItemType? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemAction? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallStatus? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemType? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellCallOutputItemFile>? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemFile? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemFileType? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent>? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContent? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemType? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemAction? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellServerToolItemFile>? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemFile? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemFileType? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemType? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItemType? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemCommand? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemType? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItemExecution? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItemType? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemFormat? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputToolSearchServerToolItemMatche>? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemMatche? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemType? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItemType? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemAction? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSource>? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSource? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSourceType? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionType? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemType? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPluginId? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPluginPriceSource? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponse? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponseErrorData? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponse? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponseErrorData? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngine? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant1? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant2? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileLatencyCutoffs? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileThroughputCutoffs? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerfLast30mByWorkload? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Rerank? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Stt? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextGeneration? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Tts? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Unknown? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGeneration? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStageType? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>>? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentText? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionType? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentTextType? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMaxLatency? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMinThroughput? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetStatus? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersionVariant2? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerToolType? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocation? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerToolType? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocationType? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Pricing? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverride>? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverride? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverrideUtcDay>? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverrideUtcDay? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpoint? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettings? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointStatus? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointCheck? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointCheckReason? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointParameterCheck? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointQuantization? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointReasoningReturnMechanism? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointResponse? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsCompletions? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSettingsExcludedParameter>? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsExcludedParameter? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsInputs? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsReasoning? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsToolChoice? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidation? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck>? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointParameterCheck>? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidationResponse? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateProvider? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpointMode? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptionsMode? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOverloadedResponse? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOverloadedResponseErrorData? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesDataCollection? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesMaxPrice? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Quantization>? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Quantization? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseProviderName? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseRoutedServiceTier? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigBy? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigPartition? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.NativeTools>? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicServiceTier? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceSupport? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpoint? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpointVariant2? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapabilityType? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyItem? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMetaVersion? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyResponse? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RankingsDailyItem>? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningConfigVariant12? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDeltaEvent? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncryptedType? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCallType? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummaryType? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailTextType? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminator? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminatorType? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDoneEvent? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemVariant2? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartAddedEvent? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartDoneEvent? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextType? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDeltaEvent? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDoneEvent? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContentType? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDeltaEvent? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDoneEvent? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponse? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponseErrorData? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPluginId? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseIncludesEnum? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponsesAnnotation>? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprob>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprob? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobTopLogprob>? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprobTopLogprob? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextType? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorFieldCode? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequest? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestAccessPrograms? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestAccessProgramsCyber? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem3? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginDiscriminator? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginDiscriminatorId? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestServiceTier? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolVariant1? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller>? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesStreamingResponse? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEvents? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilterOperator? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroupMappingRole? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimSyncJobStatus? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouterType? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputName>? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolInputName? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngine>? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngine? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolNativeSupport? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolStatus? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolSupportedApiFormat>? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolSupportedApiFormat? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ServerToolNativeSupport, global::OpenRouter.ServerToolDetailsVariant2NativeSupport>? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2NativeSupport? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolNativeModel>? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolNativeModel? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngineByok? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngineDataRegion>? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngineDataRegion? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolExecutedBy? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolPrice>? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolPrice? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEnginePricingSource? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputNameApiFormat>? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolInputNameApiFormat? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolOutputName>? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolOutputName? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolOutputNameApiFormat? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponse? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponseErrorData? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostItem? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostItemTurnRange? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostMeta? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostMetaVersion? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostResponse? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SessionCostItem>? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilterOperator? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemAction? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemType? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.ShellCallOutputContentOutcomeVariant1, global::OpenRouter.ShellCallOutputContentOutcomeVariant2>? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant1? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant1Type? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant2? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant2Type? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputItemFile>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemFile? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemFileType? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemType? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolType? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolConfig? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouterType? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEngine? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironment? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminator? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInput? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechTurn? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReference? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudio? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceText? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImage? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminator? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminatorType? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudioInput? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudioType? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImageInput? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImageType? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceTextType? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequest? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputReference>? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProvider? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProviderDataCollection? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestResponseFormat? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenCondition? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIs? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCall? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsed? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCost? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIs? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminator? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIsType? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCallType? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCostType? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsedType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIsType? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.InputText, global::OpenRouter.InputImage, global::OpenRouter.InputFile>? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompleted? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncomplete? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailed? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAdded? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDone? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEvent? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEvent? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallInProgressEvent? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallSearchingEvent? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallCompletedEvent? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminator? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminatorType? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompletedVariant2? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailedVariant2? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncompleteVariant2? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprob? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobVariant2? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StreamLogprobTopLogprob>? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobTopLogprob? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTEntity? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInlineInputAudio? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInputAudio? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUrlInputAudio? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequest? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestProvider? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestProviderDataCollection? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestResponseFormat? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTTimestampGranularity? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTResponse? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTEntity>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTSegment? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUsage? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWord? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWordType? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentNestedTool? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoning? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoningEffort? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolConfig? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouterType? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequest? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequestCategory? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponse? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponseData? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPluginAlgorithm? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPluginId? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationItem? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationModel>? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationModel? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationMacroCategory? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponse? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponseData? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationItem>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationMacroCategory>? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfigVerbosity? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEventVariant2? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StreamLogprob>? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEventVariant2? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2Verbosity? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequest? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestGrantType? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestRequestedTokenType? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestScope? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestSubjectTokenType? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponse? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponseIssuedTokenType? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponseTokenType? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ToolChoiceAllowedModeVariant1?, global::OpenRouter.ToolChoiceAllowedModeVariant2?>? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedModeVariant1? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedModeVariant2? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedType? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemExecution? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemStatus? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemType? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemExecution? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemStatus? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ToolSearchOutputItemTool>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemTool? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ToolSearchOutputItemToolAllowedCaller>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemToolAllowedCaller? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemTool2? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemType? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerToolConfig? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerToolType? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponse? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponseErrorData? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponse? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponseErrorData? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarkPricing? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksAAItem? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksAAItemSource? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItem? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItemSource? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItemTournamentStats? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMeta? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaSource? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaVersion? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItem? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItemBenchmarkType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItemSource? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponse? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>>? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItem? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemBenchmarkType? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemPrimaryMetric? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchRunConfig? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemSearchSurface? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemSource? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponse? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponseErrorData? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequest? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequestDeclaredRegion? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyResponse? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateExternalUserRequest? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailRequest? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailResponse? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationRequest? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponse? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateOrganizationSettingsRequest? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointRequest? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.PrivateEndpointPricing, object>? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestCompletions? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestInputs? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestReasoning? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestToolChoice? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderRequest? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingRequest? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingRequestRole? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingResponse? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequest? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceResponse? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetRequest? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetResponse? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitationType? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageVariant12? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageVariant1CostDetails? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ValidatePrivateEndpointRequest? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecret? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecretScope? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecretListResponse? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultEffectiveSecret>? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTable? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableCustomOrigin>? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOrigin? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOriginStatus? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOriginStatusState? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithub? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubApp>? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubApp? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppInstallation>? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallation? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationAccountType? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverage? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverageSelection? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationShadowedBy? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppMemberLink>? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppMemberLink? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppMemberLinkVia? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppScope? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubToken>? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubToken? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubTokenScope? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogle? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGoogleAccount>? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogleAccount? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogleAccountScope? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableHostRule>? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableHostRule? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOrigin>? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOrigin? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOriginRoute>? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginRoute? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginStatus? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginStatusState? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSecret>? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSecret? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSecretScope? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSlack? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSlackMemberLink>? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSlackMemberLink? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecret? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretCopyRequest? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretCopyResponse? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret>? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretListResponse? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretResponse? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretWriteRequest? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequest? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestAspectRatio? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestProvider? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestResolution? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponse? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponseStatus? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationUsage? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModel? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatio>? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedAspectRatio? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImage>? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedFrameImage? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolution>? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedResolution? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSize>? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedSize? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelUpscaleFactor? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelsListResponse? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModel>? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchEngineEnum? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPluginId? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolConfig? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolType? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngine? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPluginId? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.WebSearchUserLocation, object>? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolType? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolConfig? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouterType? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSourceType? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationType? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerToolType? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetResetInterval? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetInterval? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMemberRole? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequest? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestClassifierDimensions? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestClassifierFilters? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ClassifierFiltersFilter>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Filter>? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestOrderBy? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestOrderByDirection? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestTimeRange? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequest? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequestResponseFormat? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequest? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequest? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequestCodeChallengeMethod? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequestUsageLimitType? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequest? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestEncodingFormat? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1Type? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2ImageUrl? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UploadFileRequest? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequest? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequestExternal? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequestLimitReset? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequest? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequestLimitReset? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequest? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>>? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequestDocument? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetUserActivityGroupBy? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchListStatus>? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BatchListTimestamp?, object>? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksSource? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksTaskType? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksBenchmarkType? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksSearchSurface? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksArena? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysProvider? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetTaskClassificationsWindow? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsCategory? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsSubcategory? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsSort? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyPeriod? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyModality? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyContextBucket? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyCategory? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyLanguageType? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetSessionCostTurnRange? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListFilesOrder? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsCategory? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsSort? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsDistillable? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsZdr? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsRegion? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelsUserSort? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelsUserClient? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointDraftOnly? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.DeleteScimGroupMappingKeepMembers2?, bool?>? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteScimGroupMappingKeepMembers2? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsApiFormat? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponse? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseData? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataDimension>? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataDimension? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie>? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataGranularitieName? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataMetric>? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataMetric? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataMetricDisplayFormat? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Operator>? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponse? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponseData? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponseDataMetadata? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyResponse? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeResponse? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeResponseData? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCreditsResponse? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCreditsResponseData? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponse? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsResponseDataItem>? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseDataItem? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseDataItemObject? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseObject? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseUsage? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseUsagePromptTokensDetails? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsZdrResponse? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicZdrEndpoint>? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponse? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseData? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion>? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyBudget>? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseDataRateLimit? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListResponse? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListResponseDataItem>? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListResponseDataItem? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysResponse? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysResponseData? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteKeysResponse? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetKeyResponse? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetKeyResponseData? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysResponse? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysResponseData? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse2? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponse? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListOrganizationMembersResponseDataItem>? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponseDataItem? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponseDataItemRole? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetOrganizationSettingsResponse? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateOrganizationSettingsResponse? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.NotFoundResponse>? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.ConflictResponse>? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.UnprocessableEntityResponse>? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.InternalServerResponse>? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.BadGatewayResponse>? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPrivateProvidersResponse? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateProvider>? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateProviderResponse? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateProviderResponse? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateProviderResponseData? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPrivateProviderResponse? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderResponse? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponse? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItem>? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItem? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItemDatacenter? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItemHeadquarters? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponse? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateRerankResponseResult>? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseResult? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseResultDocument? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseUsage? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListInternConnectionsResponse? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListInternConnectionsResponseDataItem>? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListInternConnectionsResponseDataItem? Type2701 { get; set; }

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
        public global::System.Collections.Generic.List<global::OpenRouter.DecisionsUrlCitationAnnotation>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>, string>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EndpointInfo>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<double?, string>>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ExtractionForecastStep>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<long>>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?>>>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FunctionCallItemSubagentItem>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradiction>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradictionStance>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultPartialCoverageItem>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultUniqueInsight>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionPluginTool>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?, bool?>?>, object>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?, bool?>?>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionServerToolConfigTool>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GenerationContentErrorAttempt>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntry>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.List<object>>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImagePricingEntry>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentPartImage>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationResponseDataItem>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageInputModality>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageOutputModality>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageEndpoint>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageModelListItem>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningSummaryText>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BYOKKey>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputModality>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModality>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicEndpoint>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ExternalUser>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Guardrail>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDestination>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Preset>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PresetDesignatedVersion?>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointSummary>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ScimGroupMapping>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ScimGroup>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerTool>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceBudget>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Workspace>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.McpListToolsItemTool>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<string>, global::OpenRouter.McpServerToolAllowedTools>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesBashToolResultBlockFile>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicSafeguardResult>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.List<string>>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesFallbackParam>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem2>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicSafeguard>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesShellToolResultBlockFile>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Parameter>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.DABenchmarkEntry>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningEffort?>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Model>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OAuthJwksKey>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDataRegion>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroupRule>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroup>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIFile>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item3>>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item3>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item4>>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item4>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentItem4>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenResponsesTopLogprobs>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItems>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenRouterFile>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RouterAttempt>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PipelineStage>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicBashToolResultFile>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicShellToolResultFile>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputBashServerToolItemFile>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputComputerCallItemPendingSafetyCheck>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFusionServerToolItemFailedModel>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFusionServerToolItemResponse>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionSource>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputsItem>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningTextContent>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WebSearchSource>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellCallOutputItemFile>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputContent>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellServerToolItemFile>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputToolSearchServerToolItemMatche>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputWebSearchServerToolItemActionSource>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverride>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverrideUtcDay>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointSettingsExcludedParameter>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointCheck>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointParameterCheck>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Quantization>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RankingsDailyItem>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponsesAnnotation>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprob>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobTopLogprob>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseIncludesEnum>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModalityEnum>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem3>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolInputName>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolEngine>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolSupportedApiFormat>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolNativeModel>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolEngineDataRegion>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolPrice>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolInputNameApiFormat>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolOutputName>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SessionCostItem>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputItemFile>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SpeechTurn>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SpeechInputReference>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StreamLogprobTopLogprob>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTTimestampGranularity>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTEntity>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTSegment>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTWord>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SubagentNestedTool>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationModel>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationItem>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationMacroCategory>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StreamLogprob>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ToolSearchOutputItemToolAllowedCaller>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultEffectiveSecret>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableCustomOrigin>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubApp>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubAppInstallation>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubAppMemberLink>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubToken>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGoogleAccount>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableHostRule>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableMcpOrigin>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableMcpOriginRoute>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableSecret>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableSlackMemberLink>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultSecret>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FrameImage>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputReference>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedAspectRatio>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedFrameImage>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedResolution>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedSize>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModel>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ClassifierFiltersFilter>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Filter>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchListStatus>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataDimension>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataMetric>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Operator>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsResponseDataItem>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicZdrEndpoint>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyBudget>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListResponseDataItem>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListOrganizationMembersResponseDataItem>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateProvider>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListProvidersResponseDataItem>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateRerankResponseResult>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListInternConnectionsResponseDataItem>? ListType270 { get; set; }
    }
}