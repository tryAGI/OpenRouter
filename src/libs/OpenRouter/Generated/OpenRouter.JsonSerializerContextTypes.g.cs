
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
        public global::OpenRouter.AccountGuardrailPolicy? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicy? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicy? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyDiscriminator? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicyRequest? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequest? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyRequestDiscriminator? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyRequestDiscriminatorPolicyType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyResponse? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ActivityItem? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ActivityResponse? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ActivityItem>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItem? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemRole? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.AdditionalToolsItemTool>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionTool? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemTool? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AdditionalToolsItemToolAllowedCaller>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolAllowedCaller? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerTool? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerTool? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerTool? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerTool? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerTool? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerTool? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerTool? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerTool? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerTool? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellTool? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerTool? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerTool? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomTool? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceTool? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouter? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouter? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerTool? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerTool? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouter? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouter? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerTool? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouter? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouter? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerTool? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouter? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerTool? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemTool2? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolOpenRouter? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorReasoning? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorReasoningEffort? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolConfig? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouterType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItem? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemAgent? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.AgentMessageItemContentItem2>>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.AgentMessageItemContentItem2>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputText? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImage? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItem2? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemContentItemType? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItemType? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Alignment? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentCallRecord>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecord? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentAllowedCallRecord? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentAllowedCallRecordOutcome? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleRecord>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRuleRecord? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentBlockedCallRecord? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentBlockedCallRecordOutcome? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecord? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecordDiscriminator? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatAudio? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatImage? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatImageImageUrl? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatImageType? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatRejected? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatImage>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatRejectedRole? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentChatToolCall>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatToolCall? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatToolCallFunction? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentChatToolCallType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPlugin? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPluginId? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPluginMode? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRule>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRule? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRejected? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentResponsesRejectedItem>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItem? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessage? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoning? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCall? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCall? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCall? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCall? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCall? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCall? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCall? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCompaction? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpListTools? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCall? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpApprovalRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItemDiscriminator? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentResponsesRejectedItemDiscriminatorType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleWatchItem>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentRuleWatchItem? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecordOutcome? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentUnavailableCallRecordReason? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnnotationAddedEvent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEvent? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBaseUsageIteration? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2Type? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResult? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResultType? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicAllowedCaller>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAllowedCaller? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSource? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageMimeType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64ImageSourceType? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSource? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceMediaType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBase64PdfSourceType? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicIterationCacheCreation? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContent? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResult? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutput? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionOutputType? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicBashCodeExecutionOutput>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResultType? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultType? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorErrorCode? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultErrorType? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirective? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlTtl? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheControlDirectiveType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCacheCreation? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCaller? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCaller? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825Caller? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120Caller? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminator? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCallerDiscriminatorType? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocation? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationType? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParam? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationCharLocationParamType? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocation? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationType? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParam? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationContentBlockLocationParamType? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocation? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationType? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParam? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationPageLocationParamType? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationsConfig? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocation? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParam? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationSearchResultLocationParamType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocation? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20250825CallerType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecution20260120CallerType? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContent? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResult? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminator? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutput? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionOutputType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicCodeExecutionOutput>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResultType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResult? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolErrorCode? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultErrorType? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlock? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlockType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIteration? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIterationVariant2Type? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainer? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicContainerSkill>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerSkill? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerSkillType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUpload? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUploadType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDirectCallerType? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlock? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.AnthropicBase64PdfSource, global::OpenRouter.AnthropicPlainTextSource>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSource? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockType? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParam? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamCitations? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSource? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant2Item>>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant2Item>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentVariant2Item? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParam? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParam? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminator? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceContentVariant2ItemDiscriminatorType? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamSourceType? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSource? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSource? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParamType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResultType? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFile? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileShape? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeleted? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeletedShape? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDeletedType? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileDocumentSourceType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileList? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicFileListShape? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicFile>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Source3? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSource? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamSourceDiscriminatorType? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParamType? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeast? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensClearAtLeastType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTrigger? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTokensTriggerType? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicInputTransformation? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageOutputConfig? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputEffort? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseError? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApiErrorType? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseErrorType? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessagesErrorResponseType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIteration? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIterationVariant2Type? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicOutputTokensDetails? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceMediaType? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicPlainTextSourceType? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlock? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlockType? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetails? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsCategory? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRefusalStopDetailsType? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguard? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguardResult? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSafeguardResultStatus? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParam? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamCitations? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParamType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServerToolUsage? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicServiceTier? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSpeed? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicSystemClearAt? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlock? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextCitation>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitation? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockType? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CitationsItem>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CitationsItem? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParamType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminator? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextCitationDiscriminatorType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContent? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResultType? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResultType? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorErrorCode? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultErrorType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultFileType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResultType? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlock? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockType? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBinding? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBindingMismatchBehavior? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlockBindingPrefixMismatchBehavior? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingDisplay? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurns? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingTurnsType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReference? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolReferenceType? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContent? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultError? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResult? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminator? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchContentDiscriminatorType? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicToolReference>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultType? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchResultErrorType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25Name? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolBm25Type? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegex? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegexName? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolRegexType? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResult? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResultType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnion? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1InputSchema? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1InputSchemaType? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1Type? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2Name? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2Type? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3Name? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3Type? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4Name? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4Type? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocation? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5Name? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5Type? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlock? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlockType? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeep? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesKeepType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTrigger? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUsesTriggerType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIteration? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIterationVariant2? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlImageSourceType? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUrlPdfSourceType? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsage? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUsageIteration? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlock? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchBlockType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContent? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultError? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminator? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchContentDiscriminatorType? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResult? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultType? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorErrorCode? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResultErrorType? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResult? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultType? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParam? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchResultBlockParamType? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResult? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, global::OpenRouter.AnthropicWebSearchToolResultError>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultError? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultType? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorErrorCode? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultErrorType? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolUserLocationType? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItem? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperation? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallStatus? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItemType? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperation? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperation? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperation? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminator? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiscriminatorType? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEventType? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEventType? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItem? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemStatus? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItemType? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCreateFileOperationType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchDeleteFileOperationType? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchEngineEnum? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolType? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolConfig? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouterType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchUpdateFileOperationType? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsItem? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AppRankingsResponse? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMeta? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorAutoMode? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorRule>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorRule? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.ArmorEnvironmentEntry>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorEnvironmentEntry? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorContext? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPlugin? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginId? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginMode? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginOnError? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorPluginOutputMode? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResult? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatus? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Outcome? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant1Type? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant2? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant2Type? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant3? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusToolUsesVariant3Type? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultStatusType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ArmorSafeguardResultType? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPlugin? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPluginCostTier? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPluginId? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPlugin? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPluginCostTier? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPluginId? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponse? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadGatewayResponseErrorData? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponse? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BadRequestResponseErrorData? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesAnnotation? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEventType? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEvent? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputText? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContent? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEventType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEvent? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEventType? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEvent? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDeltaEventType? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEvent? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseCustomToolCallInputDoneEventType? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEvent? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseErrorEventType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEvent? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEventType? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEvent? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEventType? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputs? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2Item2? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>, string>? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentVariant1Item? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFile? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudio? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminator? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1?, global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2?>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant1? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant3? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemRoleVariant4? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseInputsVariant2ItemType? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItem? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCall? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCall? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutput? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateItem? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResult? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicContentBlock>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlock? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicInputTransformation>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultRole? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicStopReason? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultType? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BaseMessagesResultUsage>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseMessagesResultUsage? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningConfig? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningContext? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningEffort? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningMode? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryVerbosity? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDeltaEvent? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDeltaEventType? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEvent? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEventType? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartAddedEvent? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryText? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartAddedEventType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEvent? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEventType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEventType? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEvent? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEventType? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEvent? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEventType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEventType? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResult? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorField? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetails? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultObject? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItem>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItem? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminator? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultOutputItemDiscriminatorType? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StoredPromptTemplate? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptions? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceTier? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesResponseStatus? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfig? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoice? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.BaseResponsesResultToolVariant1>? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultToolVariant1? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Truncation? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsage? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEvent? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesLogProbs>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesLogProbs? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEventType? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEvent? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEventType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolConfig? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolType? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEngine? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironment? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironment? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironment? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminator? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BashServerToolEnvironmentDiscriminatorType? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletedObject? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargets? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletedObjectObject? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionOutcome? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargetsOpenrouter? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchDeletionTargetsUpstream? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchErrorResponse? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchErrorResponseError? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItem? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemCompletionWindow? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemError? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemObject? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemRequestCounts? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemStatus? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsage? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsageCompletionTokensDetails? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CostDetails? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsagePromptTokensDetails? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListItemUsageServerToolUse? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListResponse? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchListItem>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListResponseObject? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListStatus? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchListTimestamp? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObject? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectCompletionWindow? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectError? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectObject? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectRequestCounts? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResult>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResult? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultError? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponse? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Choice? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FinishReason? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobs? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<long>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItemTopLogprob? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessage? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1Type? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2ImageUrl? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2Type? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2UrlCitation? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImage? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageImageUrl? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>?>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ReasoningDetailSummary, global::OpenRouter.ReasoningDetailEncrypted, global::OpenRouter.ReasoningDetailText, global::OpenRouter.ReasoningDetailServerToolCall>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummary? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncrypted? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailText? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCall? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageRole? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCall? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCallFunction? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageToolCallType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Debug? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimings? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimingsEvent? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Object? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterMetadata? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ArmorSafeguardResult>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1Usage? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageCompletionTokensDetails? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsagePromptTokensDetails? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUse? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1UsageServerToolUseDetails? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResult? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Role? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Type? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.BatchObjectResultResponseBodyVariant3Usage>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant3Usage? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<double>, string>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItemObject? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Object? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Usage? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4UsagePromptTokensDetails? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectStatus? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsage? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsageCompletionTokensDetails? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsagePromptTokensDetails? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchObjectUsageServerToolUse? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponse? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseError? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseObject? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseRequestCounts? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseStatus? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsage? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsageCompletionTokensDetails? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsagePromptTokensDetails? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchPaymentRequiredResponseUsageServerToolUse? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchProviderPreferences? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderName? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBody? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyCompletionWindow? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyEndpoint? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BatchSubmitBodyRequest? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapability? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BooleanCapabilityType? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailBudgetPolicyConfig? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicyPolicyType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailBudgetPolicyAuthoringConfig? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicyRequestFloorReassignment? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicyRequestPolicyType? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicy? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicyPolicyType? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicyDetail? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicyDetailPolicyType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicyDetailReference? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicyDetailResponse? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicyResponse? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicySummary? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetGuardrailPolicySummaryPolicyType? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersRequest? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAddWorkspaceMembersResponse? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMember? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysRequest? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignKeysResponse? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersRequest? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkAssignMembersResponse? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersRequest? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkRemoveWorkspaceMembersResponse? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysRequest? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignKeysResponse? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersRequest? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BulkUnassignMembersResponse? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKey? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKKeyDeclaredRegion? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BYOKProviderSlug? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptor? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapability? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapability? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminator? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CapabilityDescriptorDiscriminatorType? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChangeGuardrailPolicyAssignmentRequest? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.GuardrailPolicyAssignmentState, object>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailPolicyAssignmentState? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChangeGuardrailPolicyAssignmentRequestPolicyType? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatAssistantImage>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImage? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantImageImageUrl? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessage? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAudioOutput? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItems? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatAssistantMessageRole? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatToolCall>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCall? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatChoice? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFinishReasonEnum? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobs? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudio? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudioInputAudio? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentAudioType? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentCacheControl? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFile? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFileFile? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentFileType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImage? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageImageUrl? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageImageUrlDetail? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentImageType? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentText? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideo? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideo? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminator? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentItemsDiscriminatorType? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpoint? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentTextType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoType? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInput? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatContentVideoInputProcessing? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDebugOptions? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessage? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdate3? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDeveloperMessageRole? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatDynamicServerTool? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfig? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatGrammarConfigType? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfig? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonObjectConfigType? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfig? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatJsonSchemaConfig? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatJsonSchemaConfigType? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfig? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatPythonConfigType? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfig? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFormatTextConfigType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionTool? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1Function? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatFunctionToolVariant1Type? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerTool? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerTool? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthand? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessages? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessage? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessage? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessage? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminator? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatMessagesDiscriminatorRole? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AllOf<string, object>>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<string, object>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoice? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceFunction? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatNamedToolChoiceType? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnion? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatReasoningSummaryVerbosityEnum? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequest? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControl? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageConfig? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitie>? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestModalitie? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPlugin? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPlugin? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPlugin? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPlugin? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPlugin? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPlugin? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPlugin? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPlugin? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPlugin? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPlugin? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminator? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminatorId? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Prediction? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferences? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoning? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestReasoningEffort2? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseFormat? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminator? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestResponseFormatDiscriminatorType? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeprecatedRoute? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestServiceTier? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamOptions? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoice? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TraceConfig? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResult? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatChoice>? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatResultObject? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsage? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolConfig? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSearchModelsServerToolType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatServerToolChoice? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChoice? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamDelta? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunk? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, object>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamChoice>? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkError? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkErrorMetadata? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamChunkObject? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ChatAudioOutput, object>? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamDeltaRole? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamToolCall>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCall? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamingResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCallFunction? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatStreamToolCallType? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatSystemMessageRole? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprob? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprobTopLogprob>? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatTokenLogprobTopLogprob? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatTokenLogprob>? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallFunction? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolCallType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant1? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant2? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolChoiceVariant3? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatToolMessageRole? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsageCompletionTokensDetails? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsDetails? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUsagePromptTokensDetails? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolUseDetails? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatUserMessageRole? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngineEnum? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchMode? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchConfig? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchQualityLevel? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatWebSearchShorthandType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerTool? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.XSearchOptions? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierFiltersFilter? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierScalarFilter? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierSetFilter? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierScalarFilterOperator? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClassifierSetFilterOperator? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClientClosedRequestResponse? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ClientClosedRequestResponseErrorData? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDoneEvent? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCompletedEvent? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInProgressEvent? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInterpretingEvent? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallItem? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutput? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterFileOutputType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutput? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterImageOutputType? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutput? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterLogsOutputType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.CodeInterpreterServerToolContainer>? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainer? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerMemoryLimit? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolContainerType? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerToolType? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodexLocalShellToolType? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItem? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItemType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionTriggerItem? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionTriggerItemType? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEvent? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEventType? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilter? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompoundFilterType? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolEnvironment? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ComputerUseServerToolType? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateReasoning? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateItemType? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConfigurationUpdateReasoningEffort? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponse? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ConflictResponseErrorData? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicy? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerAutoEnvironmentType? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFile? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileObject? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileSource? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileListResponse? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContainerFile>? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerFileListResponseObject? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant1Type? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerNetworkPolicyVariant2Type? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContainerReferenceEnvironmentType? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterAction? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinAction? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntry? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptInjectionScanScope? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinSlug? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterBuiltinEntryInput? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterEntry? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEvent? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEventVariant2? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.ReasoningTextContent, global::OpenRouter.OpenAIResponsesRefusalContent>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContent? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudio? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudioAudioUrl? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAudioType? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEvent? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEventVariant2? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImage? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImageImageUrl? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartImageType? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudio? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MultimodalMedia? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputAudioType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFile? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputFileType? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideo? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartInputVideoType? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideo? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideoType? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartVideoVideoUrl? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItem? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItemType? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionEngine? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPluginId? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBudgetGuardrailPolicyRequest? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBudgetGuardrailPolicyRequestPolicyType? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequest? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyRequestDeclaredRegion? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateBYOKKeyResponse? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BYOKKey, object>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateCreditPurchaseRequest? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEvent? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEventType? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateExternalUserRequest? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailRequest? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailDataRegion? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailInterval? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateGuardrailResponse? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Guardrail, object>? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Guardrail? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateModelAvailabilityGuardrailPolicyRequest? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModelAvailabilityPolicyAuthoringConfig? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateModelAvailabilityGuardrailPolicyRequestPolicyType? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateModerationGuardrailPolicyRequest? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfig? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateModerationGuardrailPolicyRequestPolicyType? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequest? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfigNullable? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDataRegionInput? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationRequestType? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponse? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestination? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePresetFromInferenceResponse? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersion? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointRequest? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointActivation? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointDeclaredParameter? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointPricing? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequest? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponse? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponseData? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpoint? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidationNullable? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateEndpointValidationFailedResponseError? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateProviderRequest? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingRequest? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingRequestRole? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimGroupMappingResponse? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroupMapping? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateScimSyncJobResponse? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimSyncJob? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequest? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceRequestDisabledServerTool? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateWorkspaceResponse? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Workspace, object>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Workspace? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreditPurchase? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreditPurchaseStatus? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreditPurchaseResponse? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CustomToolFormatVariant1, global::OpenRouter.CustomToolFormatVariant2>? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant1? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant1Type? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2Syntax? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolFormatVariant2Type? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolType? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDeltaEvent? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDoneEvent? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItem? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolCallStatus? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItemType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItem? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItemVariant2? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DABenchmarkEntry? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolConfig? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DatetimeServerToolType? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEvent? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebug? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebugTimings? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventDebugTimingsEvent? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEventType? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Decisions? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object>? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileStats? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswer? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswerBox? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxAnswerType? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxQuestion? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsBoxQuestionType? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswer? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswerType? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestion? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestionType? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAsset? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAssetFormat? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsImageAssetType? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswer? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswerType? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestion? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestionCriteria? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestionType? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRefusalAnswer? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRefusalAnswerType? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequest? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.DecisionsImageAsset>? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Questions? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestion? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminator? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponse? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.DecisionsUrlCitationAnnotation>? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUrlCitationAnnotation? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Answers? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswer? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminator? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminatorType? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseUsage? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUsageInputTokensDetails? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswerType? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.IList<object>>>? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestionType? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUrlCitationAnnotationType? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsUrlCitationAnnotationUrlCitation? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DefaultParameters? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25Search? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredBm25SearchType? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearch? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredCustomSearchType? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearch? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredRegexSearchType? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlInterface? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlProfile? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlProtocol? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlScope? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategy? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsControlValidation? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminator? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteBYOKKeyResponse? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteGuardrailPolicyResponse? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteGuardrailResponse? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteObservabilityDestinationResponse? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointResponse? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointResponseData? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteScimGroupMappingResponse? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceBudgetResponse? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteWorkspaceResponse? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessage? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>, string>? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideo? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.EasyInputMessagePhaseVariant1?, global::OpenRouter.EasyInputMessagePhaseVariant2?>? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhaseVariant1? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessagePhaseVariant2? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant1? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant2? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant3? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageRoleVariant4? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessageType? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EdgeNetworkTimeoutResponse? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EdgeNetworkTimeoutResponseErrorData? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Embeddings? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointInfo? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EndpointsMetadata? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.EndpointInfo>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EnumCapabilityType? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ErrorEvent? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExternalUser? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExternalUserResponse? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAsset? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAssetFormat? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionAssetType? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswer? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswerSource? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswerType? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateField? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateFieldType? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswer? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswerSource? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswerType? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeField? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeFieldType? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswer? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswerSource? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswerType? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationField? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationFieldType? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswer? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, string>? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswerSource? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswerType? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateField? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldScale? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionEstimateFieldStepVariant2?, global::OpenRouter.ExtractionEstimateFieldStepVariant3?>? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldStepVariant2? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldStepVariant3? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateFieldType? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswer? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswerSource? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ExtractionForecastStep>? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastStep? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswerType? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastField? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldInterval? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldScale? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionForecastFieldStepVariant2?, global::OpenRouter.ExtractionForecastFieldStepVariant3?>? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldStepVariant2? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldStepVariant3? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastFieldType? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswer? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswerSource? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<long>>? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswerType? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListField? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListFieldItems? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListFieldType? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswer? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswerSource? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswerType? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberField? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberFieldType? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Extractions? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequest? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ExtractionAsset>? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Fields? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextField? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeField? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminator? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponse? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Answers2? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswer? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswer? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminator? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsUsage? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswerSource? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswerType? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextFieldType? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswerSource? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswerType? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeFieldType? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailableToolCallStatus? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEvent? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEventType? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitation? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileCitationType? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponse? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeleted? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeleted? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminator? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileDeleteResponseDiscriminatorShape? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponse? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileList? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileList? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminator? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileListResponseDiscriminatorShape? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPluginId? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserOptions? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePath? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilePathType? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileProvider? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponse? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFile? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFile? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminator? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileResponseDiscriminatorShape? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.FileSearchServerToolFilters, global::OpenRouter.CompoundFilter>? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFilters? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolFiltersType? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptions? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolRankingOptionsRanker? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileSearchServerToolType? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolConfig? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FilesServerToolType? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Filter? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilter? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilter? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponse? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ForbiddenResponseErrorData? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfig? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonObjectConfigType? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfig? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatJsonSchemaConfigType? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Formats? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfig? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FormatTextConfigType? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImage? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FrameImageVariant2FrameType? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FreeModelDailyRequests? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDeltaEvent? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDoneEvent? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItem? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FunctionCallItemSubagentItem>? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemSubagentItem? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItemType? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItem? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemVariant2? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionToolType? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResult? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradiction>? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradiction? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultContradictionStance>? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultContradictionStance? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultPartialCoverageItem>? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultPartialCoverageItem? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionAnalysisResultUniqueInsight>? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionAnalysisResultUniqueInsight? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEvent? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEventType? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEvent? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEventType? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEvent? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEventType? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEvent? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEventType? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEvent? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEventType? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEvent? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEventType? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEvent? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEventType? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEvent? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEventType? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEvent? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEventType? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginId? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginPreset? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionPluginTool>? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPluginTool? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?, bool?>?>, object>? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?, bool?>?>? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?>? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfig? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouterType? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoning? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigReasoningEffort? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionServerToolConfigTool>? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionServerToolConfigTool? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionSource? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GatewayTimeoutResponse? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GatewayTimeoutResponseErrorData? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentData? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentError? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.GenerationContentDataInputVariant1, global::OpenRouter.GenerationContentDataInputVariant2>? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInputVariant1? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataInputVariant2? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentDataOutput? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GenerationContentErrorAttempt>? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentErrorAttempt? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationContentResponse? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponse? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseData? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataApiType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GenerationResponseDataDataRegion? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponse? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBYOKKeyResponse? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetGuardrailResponse? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponse? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetResponse? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPresetVersionResponse? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetDesignatedVersion? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetScimGroupMappingResponse? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetScimSyncJobResponse? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetToolResponse? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetails? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceBudgetResponse? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.WorkspaceBudget, object>? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudget? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetWorkspaceResponse? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GoneResponse? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GoneResponseErrorData? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailBudgetPolicyAuthoringConfigResetInterval? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModelAvailabilityPolicyConfig? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigArmor? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigArmorMode? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigArmorOnError? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltin>? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltin? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinAction? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinScanScope? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinSlug? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigContentFilter>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilter? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilterAction? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigLakeraInjectionProtectionMode? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigModelArmorInjectionConfidenceLevel? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigModelArmorInjectionProtectionMode? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigPiiFilter>? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigPiiFilter? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailModerationPolicyConfigPiiFilterAction? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GuardrailPolicyAssignmentResponse? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<object>>? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageEndpoint? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntry? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>, object>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallCompletedEvent? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompleted? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallGeneratingEvent? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGenerating? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallInProgressEvent? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgress? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallPartialImageEvent? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImage? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCompletedEvent? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCompletedEventType? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsage? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGeneration? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationProviderPreferences? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOptions? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig>? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSort? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfig? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequest? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestAspectRatio? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestBackground? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ContentPartImage, object>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestOutputFormat? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestQuality? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationRequestResolution? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponse? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItem>? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationResponseDataItem? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolBackground? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputFidelity? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolInputImageMask? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolModeration? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOutputFormat? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolQuality? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolType? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolConfig? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouterType? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationStatus? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageCompletionTokensDetails? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsagePromptTokensDetails? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenerationUsageServerToolUse? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenPartialImageEvent? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenPartialImageEventType? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEvent? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEventError? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenStreamErrorEventType? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEvent? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEventPhase? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenTextChunkEventType? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageInputModality? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelArchitecture? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageInputModality>? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageOutputModality? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelEndpointsResponse? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint>? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelListItem? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageModelsListResponse? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryBillable? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImagePricingEntryUnit? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageStreamingResponse? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ImageGenPartialImageEvent, global::OpenRouter.ImageGenTextChunkEvent, global::OpenRouter.ImageGenCompletedEvent, global::OpenRouter.ImageGenStreamErrorEvent>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteDetailsReason? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEvent? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEventType? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEvent? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEventType? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioInputAudio1? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioInputAudio1Format? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputAudioType? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputFileType? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImageDetail? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputImageType? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItem? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.InputMessageItemRoleVariant1?, global::OpenRouter.InputMessageItemRoleVariant2?, global::OpenRouter.InputMessageItemRoleVariant3?>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant1? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant2? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemRoleVariant3? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItemType? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputModality? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReference? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminator? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputReferenceDiscriminatorType? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Inputs? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItem? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OutputMessageItem?, global::OpenRouter.InputsVariant2ItemVariant82>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItem? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant82? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant8Type? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OutputReasoningItem?, global::OpenRouter.InputsVariant2ItemVariant92>? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItem? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsVariant2ItemVariant92? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItem? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItem? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItem? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItem? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItem? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItem? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItem? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItem? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItem? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItem? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItem? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItem? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItem? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItem? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItem? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItem? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItem? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItem? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItem? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItem? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItem? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItem? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItem? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItem? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItem? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItem? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItem? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItem? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItem? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItem? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItem? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItem? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItem? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItem? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputTextType? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoProcessing? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputVideoType? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InstructType? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponse? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InternalServerResponseErrorData? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItemType? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPluginId? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyAssignment? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudget? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudgetResetInterval? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.KeyBudgetScope? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoType? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInput? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyChatContentVideoInputProcessing? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchDomainFilter? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchContextSizeEnum? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerToolType? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocation? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListAccountGuardrailPoliciesResponse? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AccountGuardrailPolicy>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBudgetGuardrailPoliciesResponse? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BudgetGuardrailPolicySummary>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysResponse? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BYOKKey>? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ModelArchitecture, global::OpenRouter.ListEndpointsResponseArchitecture>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelArchitecture? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponseArchitecture? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputModality>? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModality? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelGroup? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpoint? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListExternalUsersResponse? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ExternalUser>? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListGuardrailsResponse? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListKeyAssignmentsResponse? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListMemberAssignmentsResponse? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MemberAssignment? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelAvailabilityGuardrailPoliciesResponse? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ModelAvailabilityGuardrailPolicySummary>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicySummary? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModerationGuardrailPoliciesResponse? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ModerationGuardrailPolicySummary>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicySummary? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListObservabilityDestinationsResponse? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDestination>? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetsResponse? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Preset>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preset? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPresetVersionsResponse? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PresetDesignatedVersion?>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPrivateEndpointsResponse? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSummary>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSummary? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListScimGroupMappingsResponse? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ScimGroupMapping>? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListScimGroupsResponse? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ScimGroup>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroup? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsResponse? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerTool>? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerTool? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsResponseLinks? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceBudgetsResponse? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceBudget>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspaceMembersResponse? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListWorkspacesResponse? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Workspace>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemAction? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemActionType? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItemType? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItemType? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointVariant2? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointDeclaredRegion? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ManagedPrivateEndpointResponse? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItemType? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItemType? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDeltaEvent? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDeltaEventType? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDoneEvent? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallArgumentsDoneEventType? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallCompletedEvent? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallCompletedEventType? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallFailedEvent? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallFailedEventType? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallInProgressEvent? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallInProgressEventType? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolCallError? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItemStatus? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItemType? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpError? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpErrorType? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsCompletedEvent? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsCompletedEventType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsFailedEvent? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsFailedEventType? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsInProgressEvent? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsInProgressEventType? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.McpListToolsItemTool>? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemTool? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItemType? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolError? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolErrorType? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolAllowedTools>? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolAllowedTools? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Always? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant1Never? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant2? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolRequireApprovalVariant3? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolType? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParameters? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolOpenRouterType? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<string>, global::OpenRouter.McpServerToolParametersAllowedTools>? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParametersAllowedTools? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParametersRequireApprovalVariant1? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParametersRequireApprovalVariant1Always? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParametersRequireApprovalVariant1Never? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParametersRequireApprovalVariant2? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpServerToolParametersRequireApprovalVariant3? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionError? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionErrorType? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlock? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlockType? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlock? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesBashToolResultBlockFile>? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockFile? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockFileType? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesBashToolResultBlockType? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEvent? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1Type? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2Type? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3Type? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4Type? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Citation? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5Type? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6Type? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEventType? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEvent? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlock? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResult? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResult? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResult? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventContentBlock? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventContentBlockType? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEventType? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEvent? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEventType? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEvent? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventDelta? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguardResult>? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventType? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEventUsage? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUsage? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEvent? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEventError? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEventType? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesFallbackParam? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParam? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant4Type? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5ContentVariant2Item? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant5Type? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant6Type? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant7Type? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant8Type? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content>? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResultBlockParam>? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9ContentErrorCode? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9ContentType? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Type? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant11Type? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlock? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlock? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlock? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultParam? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesMessageParamRole? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfig? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigEffort? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormat? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigFormatType? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudget? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesOutputConfigTaskBudgetType? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEvent? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEventType? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequest? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagement? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.IList<string>>? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Trigger? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminator? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1TriggerDiscriminatorType? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant1Type? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnumType? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2KeepEnum2? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant2Type? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicInputTokensTrigger, object>? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestContextManagementEditVariant3Type? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestMetadata? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem2>? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem2? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginDiscriminator? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestPluginDiscriminatorId? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguard>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicSpeed?, object>? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant1? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant1Type? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant2? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant2Type? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant3? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant3Type? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant4? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestThinkingVariant4Type? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant1? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant1Type? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant2? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant2Type? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant3? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant3Type? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant4? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolChoiceVariant4Type? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1InputSchema? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant1Type? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2Name? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant2Type? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3Name? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant3Type? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4Name? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant4Type? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5Name? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant5Type? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6Name? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant6Type? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerTool? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesRequestToolVariant13? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResult? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2ContextManagement? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit>? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesResultVariant2Usage>? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2Usage? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesResultVariant2UsageDeferredToolsDetails? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesSearchModelsServerToolType? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesShellToolResultBlockFile>? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockFile? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockFileType? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesShellToolResultBlockType? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEvent? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessage? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageProvider? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageRole? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageType? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicUsage, global::OpenRouter.MessagesStartEventMessageUsage>? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventMessageUsage? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEventType? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEvent? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEventType? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEvents? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminator? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminatorType? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamingResponse? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant1? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant1Type? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant2? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant2Type? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant3? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant3Type? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4Type? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolAdditionBlockType? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant1? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant1Type? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant2? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant2Type? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant3? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockToolVariant3Type? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesToolRemovalBlockType? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MetadataLevel? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Model? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAliasTarget? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelBenchmarks? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelLinks? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerRequestLimits? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicPricing? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelReasoning? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Parameter>? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Parameter? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TopProviderInfo? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyPolicyType? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequestFloorReassignment? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequestPolicyType? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicy? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyPolicyType? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyDetail? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyDetailPolicyType? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyDetailReference? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyDetailResponse? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityGuardrailPolicySummaryPolicyType? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ReasoningEffort?, object>? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort?>? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelResponse? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponse? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsCountResponseData? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponse? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Model>? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelsListResponseLinks? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicyPolicyType? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequestFloorReassignment? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequestPolicyType? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicy? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicyPolicyType? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicyDetail? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicyDetailPolicyType? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicyDetailReference? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicyDetailResponse? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicyResponse? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationGuardrailPolicySummaryPolicyType? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPluginId? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionTool? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolAllowedCaller? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceFunctionToolType? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>>? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NamespaceToolType? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NativeTools? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponse? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.NotFoundResponseErrorData? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthErrorResponse? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthErrorResponseError? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwks? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OAuthJwksKey>? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKey? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyAlg? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyCrv? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyKty? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OAuthJwksKeyUse? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestination? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestinationConfig? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRulesConfig? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegion>? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDataRegion? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestinationType? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestination? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestinationConfig? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestinationType? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestination? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestinationConfig? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestinationType? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestination? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestinationConfig? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestinationType? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestination? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestination? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestination? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestination? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestination? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestination? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestination? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestination? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3Destination? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestination? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestination? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestination? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestination? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminator? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminatorType? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroup? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupLogic? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRule>? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRule? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRuleField? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityFilterRuleGroupRuleOperator? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup>? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestinationConfig? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestinationType? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestinationConfig? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestinationType? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestinationConfig? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestinationType? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationConfig? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationConfigRegion? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestinationType? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestinationConfig? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestinationType? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestinationConfig? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestinationType? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestinationConfig? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestinationType? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestinationConfig? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestinationType? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfig? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfigAuthMode? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationConfigProvider? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3DestinationType? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestinationConfig? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestinationType? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestinationConfig? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestinationType? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestinationConfig? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestinationType? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationConfig? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationConfigMethod? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestinationType? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileShape? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileObject? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFilePurpose? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileStatus? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeletedShape? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileDeletedObject? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileListShape? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIFile>? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIFileListObject? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallType? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item3>>? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item3>? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputVariant2Item3? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminator? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputOutputVariant2ItemDiscriminatorType? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseCustomToolCallOutputType? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem>? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallType? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item4>>? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputVariant2Item4>? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputVariant2Item4? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminator? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputOutputVariant2ItemDiscriminatorType? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutputType? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentItem4>? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentItem4? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminator? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant1? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant2? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemRoleVariant3? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseInputMessageItemType? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitation? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDeltaType? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDoneType? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompletedType? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgressType? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpretingType? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallCompletedType? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallGeneratingType? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallInProgressType? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImageType? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesRefusalContentType? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompleted? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesSearchCompletedType? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant1? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant2? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant3? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4Type? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1?, global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2?>? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant1? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5TypeVariant2? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowed? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7Type? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8Type? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceMcp? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesTruncation? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsageInputTokensDetails? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesUsageOutputTokensDetails? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgress? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallInProgressType? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearching? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesWebSearchCallSearchingType? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEvent? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEventVariant2? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorField? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorFieldCode? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorMetadata? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, global::OpenRouter.OpenResponsesErrorMetadataAlignment>? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesErrorMetadataAlignment? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEvent? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEventVariant2? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesTopLogprobs>? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesTopLogprobs? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2AccessPrograms? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2AccessProgramsCyber? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItems>? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItems? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfig? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.OpenAIResponsesUsage, global::OpenRouter.UsageVariant12>? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileShape? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileType? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeletedShape? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileDeletedType? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterFileListShape? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenRouterFile>? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterAttempt? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RouterParams? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStage? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RoutingStrategy? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenRouterWebSearchServerToolType? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Operator? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OperatorName? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OperatorValueType? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicBashToolResultFile>? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultFile? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultFileType? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResultType? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminator? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCaller? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminator? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlockType? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ORAnthropicShellToolResultFile>? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultFile? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultFileType? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResultType? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultType? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResultParamType? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OrganizationSettings? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItemType? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItem? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItemType? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItemType? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItemStatus? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputArmorBlockedItemType? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputBashServerToolItemFile>? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemFile? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemFileType? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItemType? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItemType? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItemType? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCompactionItem? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCompactionItemType? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputComputerCallItemPendingSafetyCheck>? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemPendingSafetyCheck? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemStatus? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItemType? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItem? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItemStatus? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItemType? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItemType? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItemType? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItemType? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItem? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemFailedModel>? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemFailedModel? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputFusionServerToolItemResponse>? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemResponse? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FusionSource>? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItemType? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItemVariant2? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItemType? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEvent? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Item? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventItemDiscriminator? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventItemDiscriminatorType? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEventType? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Operation? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallOperationDiscriminator? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallOperationDiscriminatorType? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallStatus? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemApplyPatchCallType? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputsItem>? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputsItem? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminator? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallStatus? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCodeInterpreterCallType? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCompactionType? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCallStatus? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemCustomToolCallType? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEvent? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Item2? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventItemDiscriminator? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventItemDiscriminatorType? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEventType? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchStatus? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFileSearchCallType? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant1? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant2? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallStatusVariant3? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemFunctionCallType? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemImageGenerationCallType? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpApprovalRequestType? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.OutputItemMcpCallErrorVariant2, global::OpenRouter.OutputItemMcpCallErrorVariant3, global::OpenRouter.OutputItemMcpCallErrorVariant4>? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallErrorVariant2? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallErrorVariant2Type? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallErrorVariant3? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallErrorVariant3Type? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallErrorVariant4? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallErrorVariant4Type? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallStatus? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpCallType? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputItemMcpListToolsTool>? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpListToolsTool? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemMcpListToolsType? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputItemReasoningStatusVariant1?, global::OpenRouter.OutputItemReasoningStatusVariant2?, global::OpenRouter.OutputItemReasoningStatusVariant3?>? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant1? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant2? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningStatusVariant3? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemReasoningType? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItem? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItem? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItem? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminator? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorType? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant1? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.WebSearchSource>? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSource? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant1Type? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant2? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant2Type? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant3? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallActionVariant3Type? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemWebSearchCallType? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemAction? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItemType? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputMessagePhaseVariant1?, global::OpenRouter.OutputMessagePhaseVariant2?>? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhaseVariant1? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessagePhaseVariant2? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageRole? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.OutputMessageStatusVariant1?, global::OpenRouter.OutputMessageStatusVariant2?, global::OpenRouter.OutputMessageStatusVariant3?>? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant1? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant2? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageStatusVariant3? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageType? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputModalityEnum? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItemVariant2? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningFormat? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItemType? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemAction? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallStatus? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItemType? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellCallOutputItemFile>? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemFile? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemFileType? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent>? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContent? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemType? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemAction? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellServerToolItemFile>? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemFile? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemFileType? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItemType? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItemType? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemCommand? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItemType? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItemExecution? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchCallItemType? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemFormat? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputToolSearchServerToolItemMatche>? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemMatche? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItemType? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItemType? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemAction? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputWebSearchServerToolItemActionSource>? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSource? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionSourceType? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemActionType? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItemType? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPluginId? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPluginPriceSource? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponse? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PayloadTooLargeResponseErrorData? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponse? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PaymentRequiredResponseErrorData? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngine? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant1? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PDFParserEngineVariant2? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileLatencyCutoffs? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileThroughputCutoffs? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PerfLast30mByWorkload? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Rerank? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Stt? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextGeneration? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Tts? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Unknown? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGeneration? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PipelineStageType? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>>? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentText? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionType? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PredictionContentTextType? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMaxLatency? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreferredMinThroughput? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetStatus? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PresetWithDesignatedVersionVariant2? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerToolType? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocation? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerToolType? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocationType? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Pricing? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverride>? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverride? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverrideUtcDay>? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingOverrideUtcDay? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpoint? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettings? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointStatus? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointCheck? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointCheckReason? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointParameterCheck? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointQuantization? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointReasoningReturnMechanism? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointResponse? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsCompletions? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointSettingsExcludedParameter>? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsExcludedParameter? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsInputs? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsReasoning? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointSettingsToolChoice? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidation? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointCheck>? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointParameterCheck>? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateEndpointValidationResponse? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PrivateProvider? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheBreakpointMode? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PromptCacheOptionsMode? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOverloadedResponse? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderOverloadedResponseErrorData? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesDataCollection? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderPreferencesMaxPrice? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Quantization>? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.Quantization? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseProviderName? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderResponseRoutedServiceTier? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigBy? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ProviderSortConfigPartition? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.NativeTools>? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicServiceTier? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceSupport? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpoint? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpointVariant2? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RangeCapabilityType? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyItem? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyMetaVersion? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RankingsDailyResponse? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.RankingsDailyItem>? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningConfigVariant12? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDeltaEvent? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailEncryptedType? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailServerToolCallType? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailSummaryType? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailTextType? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminator? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDetailUnionDiscriminatorType? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDoneEvent? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItemVariant2? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartAddedEvent? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartDoneEvent? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextType? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDeltaEvent? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDoneEvent? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningTextContentType? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDeltaEvent? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDoneEvent? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponse? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestTimeoutResponseErrorData? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPluginId? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseIncludesEnum? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OpenAIResponsesAnnotation>? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprob>? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprob? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseOutputTextLogprobTopLogprob>? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextLogprobTopLogprob? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseOutputTextType? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesErrorFieldCode? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequest? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestAccessPrograms? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestAccessProgramsCyber? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PluginsItem3? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginDiscriminator? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginDiscriminatorId? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestServiceTier? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolVariant1? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller>? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponsesStreamingResponse? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEvents? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilterOperator? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimGroupMappingRole? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScimSyncJobStatus? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouterType? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputName>? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolInputName? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngine>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngine? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolNativeSupport? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolStatus? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolSupportedApiFormat>? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolSupportedApiFormat? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ServerToolNativeSupport, global::OpenRouter.ServerToolDetailsVariant2NativeSupport>? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2NativeSupport? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolNativeModel>? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolNativeModel? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngineByok? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngineDataRegion>? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEngineDataRegion? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolExecutedBy? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolPrice>? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolPrice? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolEnginePricingSource? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputNameApiFormat>? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolInputNameApiFormat? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ServerToolOutputName>? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolOutputName? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolOutputNameApiFormat? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponse? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServiceUnavailableResponseErrorData? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostItem? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostItemTurnRange? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostMeta? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostMetaVersion? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SessionCostResponse? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SessionCostItem>? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilterOperator? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemAction? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItemType? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.ShellCallOutputContentOutcomeVariant1, global::OpenRouter.ShellCallOutputContentOutcomeVariant2>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant1? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant1Type? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant2? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputContentOutcomeVariant2Type? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputItemFile>? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemFile? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemFileType? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItemType? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolType? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolConfig? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouterType? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEngine? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironment? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminator? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInput? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechTurn? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReference? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudio? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceText? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImage? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminator? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceDiscriminatorType? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudioInput? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceAudioType? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImageInput? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceImageType? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputReferenceTextType? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequest? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputReference>? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProvider? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestProviderDataCollection? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechRequestResponseFormat? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenCondition? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIs? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCall? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsed? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCost? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIs? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminator? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIsType? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCallType? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCostType? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsedType? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIsType? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.InputText, global::OpenRouter.InputImage, global::OpenRouter.InputFile>? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompleted? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncomplete? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailed? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAdded? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDone? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEvent? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEvent? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallInProgressEvent? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallSearchingEvent? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallCompletedEvent? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminator? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminatorType? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompletedVariant2? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailedVariant2? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncompleteVariant2? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprob? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobVariant2? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StreamLogprobTopLogprob>? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamLogprobTopLogprob? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTEntity? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInlineInputAudio? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInputAudio? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUrlInputAudio? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequest? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestProvider? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestProviderDataCollection? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTRequestResponseFormat? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTTimestampGranularity? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTResponse? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTEntity>? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTSegment? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUsage? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWord? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTWordType? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentNestedTool? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoning? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentReasoningEffort? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolConfig? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouterType? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequest? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackRequestCategory? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponse? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SubmitGenerationFeedbackResponseData? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPluginAlgorithm? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPluginId? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationItem? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationModel>? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationModel? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationMacroCategory? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponse? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TaskClassificationResponseData? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationItem>? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationMacroCategory>? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextConfigVerbosity? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEventVariant2? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.StreamLogprob>? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEventVariant2? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextExtendedConfigVariant2Verbosity? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequest? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestGrantType? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestRequestedTokenType? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestScope? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeRequestSubjectTokenType? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponse? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponseIssuedTokenType? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TokenExchangeResponseTokenType? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.ToolChoiceAllowedModeVariant1?, global::OpenRouter.ToolChoiceAllowedModeVariant2?>? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedModeVariant1? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedModeVariant2? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowedType? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceMcpType? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemExecution? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemStatus? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchCallItemType? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemExecution? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemStatus? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ToolSearchOutputItemTool>? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemTool? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ToolSearchOutputItemToolAllowedCaller>? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemToolAllowedCaller? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemTool2? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchOutputItemType? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerToolConfig? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolSearchServerToolType? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponse? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TooManyRequestsResponseErrorData? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponse? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnauthorizedResponseErrorData? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarkPricing? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksAAItem? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksAAItemSource? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItem? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItemSource? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksDAItemTournamentStats? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMeta? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaSource? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksMetaVersion? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItem? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItemBenchmarkType? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksORItemSource? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksResponse? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>>? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItem? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemBenchmarkType? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemPrimaryMetric? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchRunConfig? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemSearchSurface? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnifiedBenchmarksSearchItemSource? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponse? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UnprocessableEntityResponseErrorData? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBudgetGuardrailPolicyRequest? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequest? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyRequestDeclaredRegion? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateBYOKKeyResponse? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateExternalUserRequest? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailRequest? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateGuardrailResponse? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateModelAvailabilityGuardrailPolicyRequest? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateModerationGuardrailPolicyRequest? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationRequest? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateObservabilityDestinationResponse? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateOrganizationSettingsRequest? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointRequest? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.PrivateEndpointPricing, object>? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestCompletions? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestInputs? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestReasoning? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequestToolChoice? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderRequest? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingRequest? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingRequestRole? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateScimGroupMappingResponse? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequest? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateWorkspaceResponse? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetRequest? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpsertWorkspaceBudgetResponse? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.URLCitationType? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageVariant12? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UsageVariant1CostDetails? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ValidatePrivateEndpointRequest? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecret? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecretScope? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultEffectiveSecretListResponse? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultEffectiveSecret>? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTable? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableCustomOrigin>? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOrigin? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOriginStatus? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableCustomOriginStatusState? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithub? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubApp>? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubApp? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppInstallation>? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallation? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationAccountType? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverage? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverageSelection? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationShadowedBy? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppMemberLink>? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppMemberLink? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppMemberLinkVia? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubAppScope? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubToken>? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubToken? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGithubTokenScope? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogle? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGoogleAccount>? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogleAccount? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableGoogleAccountScope? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableHostRule>? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableHostRule? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOrigin>? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOrigin? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOriginRoute>? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginRoute? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginStatus? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableMcpOriginStatusState? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSecret>? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSecret? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSecretScope? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSlack? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSlackMemberLink>? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultRoutingTableSlackMemberLink? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecret? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretCopyRequest? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretCopyResponse? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret>? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretListResponse? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretResponse? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VaultSecretWriteRequest? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequest? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestAspectRatio? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestProvider? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationRequestResolution? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponse? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationResponseStatus? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoGenerationUsage? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModel? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatio>? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedAspectRatio? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImage>? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedFrameImage? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolution>? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedResolution? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSize>? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelSupportedSize? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelUpscaleFactor? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.VideoModelsListResponse? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModel>? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchEngineEnum? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPluginId? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolConfig? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchServerToolType? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchEngine? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPluginId? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.WebSearchUserLocation, object>? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolType? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolConfig? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouterType? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchSourceType? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationType? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchUserLocationServerToolType? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetResetInterval? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceBudgetInterval? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WorkspaceMemberRole? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequest? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestClassifierDimensions? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestClassifierFilters? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ClassifierFiltersFilter>? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Filter>? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestOrderBy? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestOrderByDirection? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsRequestTimeRange? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequest? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequestResponseFormat? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequest? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequest? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequestCodeChallengeMethod? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeRequestUsageLimitType? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequest? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestEncodingFormat? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant1Type? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2ImageUrl? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant5ItemContentItemVariant2Type? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UploadFileRequest? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequest? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequestExternal? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysRequestLimitReset? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequest? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysRequestLimitReset? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequest? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>>? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankRequestDocument? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetUserActivityGroupBy? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchListStatus>? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AllOf<global::OpenRouter.BatchListTimestamp?, object>? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksSource? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksTaskType? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksBenchmarkType? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksSearchSurface? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetBenchmarksArena? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListBYOKKeysProvider? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetTaskClassificationsWindow? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsCategory? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsSubcategory? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAppRankingsSort? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyPeriod? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyModality? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyContextBucket? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyCategory? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetRankingsDailyLanguageType? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetSessionCostTurnRange? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListFilesOrder? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetMemberPolicyAssignmentPolicyType? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsCategory? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsSort? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsDistillable? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsZdr? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetModelsRegion? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelsUserSort? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListModelsUserClient? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateEndpointDraftOnly? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.DeleteScimGroupMappingKeepMembers2?, bool?>? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteScimGroupMappingKeepMembers2? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListToolsApiFormat? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponse? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseData? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataDimension>? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataDimension? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie>? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataGranularitieName? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataMetric>? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataMetric? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetAnalyticsMetaResponseDataMetricDisplayFormat? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.Operator>? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponse? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponseData? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.QueryAnalyticsResponseDataMetadata? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyResponse? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeResponse? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateAuthKeysCodeResponseData? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCreditsResponse? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCreditsResponseData? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponse? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsResponseDataItem>? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseDataItem? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseDataItemObject? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseObject? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseUsage? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateEmbeddingsResponseUsagePromptTokensDetails? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsZdrResponse? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PublicZdrEndpoint>? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponse? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseData? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion>? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.KeyBudget>? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetCurrentKeyResponseDataRateLimit? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListResponse? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListResponseDataItem>? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListResponseDataItem? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysResponse? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateKeysResponseData? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeleteKeysResponse? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetKeyResponse? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetKeyResponseData? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysResponse? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateKeysResponseData? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListEndpointsResponse2? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponse? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListOrganizationMembersResponseDataItem>? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponseDataItem? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListOrganizationMembersResponseDataItemRole? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetOrganizationSettingsResponse? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdateOrganizationSettingsResponse? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.NotFoundResponse>? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.ConflictResponse>? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.UnprocessableEntityResponse>? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.InternalServerResponse>? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::OpenRouter.CreatePrivateEndpointValidationFailedResponse, global::OpenRouter.BadGatewayResponse>? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListPrivateProvidersResponse? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateProvider>? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatePrivateProviderResponse? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateProviderResponse? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DeletePrivateProviderResponseData? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.GetPrivateProviderResponse? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.UpdatePrivateProviderResponse? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponse? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItem>? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItem? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItemDatacenter? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListProvidersResponseDataItemHeadquarters? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponse? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateRerankResponseResult>? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseResult? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseResultDocument? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreateRerankResponseUsage? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListInternConnectionsResponse? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ListInternConnectionsResponseDataItem>? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ListInternConnectionsResponseDataItem? Type2834 { get; set; }

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
        public global::System.Collections.Generic.List<global::System.Guid>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceMember>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatAssistantImage>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatContentItems>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningDetailUnion>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatToolCall>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatContentText>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AllOf<string, object>>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatMessages>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatRequestModalitie>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StopServerToolsWhenCondition>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatFunctionTool>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatChoice>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatStreamChoice>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatStreamToolCall>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprobTopLogprob>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ChatTokenLogprob>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?>>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContainerFile>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GuardrailDataRegion>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntryInput>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterEntry>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDataRegionInput>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointDeclaredParameter>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateWorkspaceRequestDisabledServerTool>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.List<object>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.DecisionsUrlCitationAnnotation>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, object, global::System.Collections.Generic.List<object>>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>, string>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile, global::OpenRouter.InputAudio, global::OpenRouter.InputVideo>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.EndpointInfo>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<double?, string>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ExtractionForecastStep>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<long>>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?>>>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FunctionCallItemSubagentItem>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradiction>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultContradictionStance>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultPartialCoverageItem>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionAnalysisResultUniqueInsight>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionPluginTool>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, bool?, global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?, bool?>?>, object>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, double?, bool?>?>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionServerToolConfigTool>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GenerationContentErrorAttempt>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntry>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltin>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GuardrailModerationPolicyConfigContentFilter>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GuardrailModerationPolicyConfigPiiFilter>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.List<object>>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImagePricingEntry>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentPartImage>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationResponseDataItem>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageInputModality>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageOutputModality>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageEndpoint>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ImageModelListItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>, string>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.ResponseOutputText, global::OpenRouter.OpenAIResponsesRefusalContent>>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningSummaryText>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AccountGuardrailPolicy>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BudgetGuardrailPolicySummary>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BYOKKey>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputModality>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModality>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicEndpoint>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ExternalUser>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Guardrail>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ModelAvailabilityGuardrailPolicySummary>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ModerationGuardrailPolicySummary>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDestination>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Preset>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PresetDesignatedVersion?>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointSummary>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ScimGroupMapping>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ScimGroup>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerTool>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WorkspaceBudget>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Workspace>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.McpListToolsItemTool>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<string>, global::OpenRouter.McpServerToolAllowedTools>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<string>, global::OpenRouter.McpServerToolParametersAllowedTools>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesBashToolResultBlockFile>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicSafeguardResult>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>, global::OpenRouter.MessagesMessageParamContentVariant2ItemVariant9Content>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicWebSearchResultBlockParam>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<bool?, global::System.Collections.Generic.List<string>>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesFallbackParam>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesMessageParam>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem2>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnthropicSafeguard>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.AnthropicTextBlockParam>>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesResultVariant2ContextManagementAppliedEdit>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.MessagesShellToolResultBlockFile>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Parameter>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.DABenchmarkEntry>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningEffort?>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Model>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<global::OpenRouter.NamespaceFunctionTool, global::OpenRouter.CustomTool>>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OAuthJwksKey>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityDataRegion>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroupRule>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ObservabilityFilterRuleGroup>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIFile>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item3>>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item3>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponseFunctionToolCallSubagentItem>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item4>>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputVariant2Item4>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ContentItem4>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenResponsesTopLogprobs>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItems>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenRouterFile>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RouterAttempt>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PipelineStage>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicBashToolResultFile>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ORAnthropicShellToolResultFile>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputBashServerToolItemFile>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputComputerCallItemPendingSafetyCheck>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFunctionCallItemVariant2SubagentItem>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFusionServerToolItemFailedModel>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputFusionServerToolItemResponse>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FusionSource>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputsItem>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputItemMcpListToolsTool>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ReasoningTextContent>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.WebSearchSource>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellCallOutputItemFile>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputContent>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputShellServerToolItemFile>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputToolSearchServerToolItemMatche>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputWebSearchServerToolItemActionSource>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PredictionContentText>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverride>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PricingOverrideUtcDay>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointSettingsExcludedParameter>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointCheck>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateEndpointParameterCheck>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Quantization>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.RankingsDailyItem>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OpenAIResponsesAnnotation>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprob>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseOutputTextLogprobTopLogprob>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponseIncludesEnum>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OutputModalityEnum>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PluginsItem3>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ResponsesRequestToolVariant1AllowedCaller>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolInputName>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolEngine>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolSupportedApiFormat>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolNativeModel>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolEngineDataRegion>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolPrice>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolInputNameApiFormat>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ServerToolOutputName>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SessionCostItem>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ShellCallOutputItemFile>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SpeechTurn>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SpeechInputReference>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StreamLogprobTopLogprob>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTTimestampGranularity>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTEntity>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTSegment>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.STTWord>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.SubagentNestedTool>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationModel>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationItem>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.TaskClassificationMacroCategory>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.StreamLogprob>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ToolSearchOutputItemToolAllowedCaller>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.OneOf<global::OpenRouter.UnifiedBenchmarksAAItem, global::OpenRouter.UnifiedBenchmarksDAItem, global::OpenRouter.UnifiedBenchmarksORItem, global::OpenRouter.UnifiedBenchmarksSearchItem>>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UpdatePrivateEndpointSettingsRequestExcludedParameter>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultEffectiveSecret>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableCustomOrigin>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubApp>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubAppInstallation>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubAppMemberLink>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGithubToken>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableGoogleAccount>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableHostRule>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableMcpOrigin>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableMcpOriginRoute>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableSecret>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultRoutingTableSlackMemberLink>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VaultSecret>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.FrameImage>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.InputReference>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedAspectRatio>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedFrameImage>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedResolution>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedSize>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.VideoModel>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ClassifierFiltersFilter>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Filter>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>, global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.BatchListStatus>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataDimension>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetAnalyticsMetaResponseDataMetric>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.Operator>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateEmbeddingsResponseDataItem>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PublicZdrEndpoint>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.GetCurrentKeyResponseDataAllowedDataRegion>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.KeyBudget>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListResponseDataItem>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListOrganizationMembersResponseDataItem>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.PrivateProvider>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListProvidersResponseDataItem>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListProvidersResponseDataItemDatacenter>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.CreateRerankResponseResult>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::OpenRouter.ListInternConnectionsResponseDataItem>? ListType280 { get; set; }
    }
}