
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum StreamEventsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        ResponseApplyPatchCallOperationDiffDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseApplyPatchCallOperationDiffDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInterpreting,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCodeDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDone,
        /// <summary>
        ///
        /// </summary>
        ResponseDebug,
        /// <summary>
        ///
        /// </summary>
        ResponseFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallAnalysisCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallAnalysisInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseFusionCallPanelReasoningDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallGenerating,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallPartialImage,
        /// <summary>
        ///
        /// </summary>
        ResponseInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseIncomplete,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextAnnotationAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDone,
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamEventsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamEventsDiscriminatorType value)
        {
            return value switch
            {
                StreamEventsDiscriminatorType.Error => "error",
                StreamEventsDiscriminatorType.ResponseApplyPatchCallOperationDiffDelta => "response.apply_patch_call_operation_diff.delta",
                StreamEventsDiscriminatorType.ResponseApplyPatchCallOperationDiffDone => "response.apply_patch_call_operation_diff.done",
                StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                StreamEventsDiscriminatorType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                StreamEventsDiscriminatorType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCodeDelta => "response.code_interpreter_call_code.delta",
                StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call_code.done",
                StreamEventsDiscriminatorType.ResponseCompleted => "response.completed",
                StreamEventsDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                StreamEventsDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                StreamEventsDiscriminatorType.ResponseCreated => "response.created",
                StreamEventsDiscriminatorType.ResponseCustomToolCallInputDelta => "response.custom_tool_call_input.delta",
                StreamEventsDiscriminatorType.ResponseCustomToolCallInputDone => "response.custom_tool_call_input.done",
                StreamEventsDiscriminatorType.ResponseDebug => "response.debug",
                StreamEventsDiscriminatorType.ResponseFailed => "response.failed",
                StreamEventsDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                StreamEventsDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                StreamEventsDiscriminatorType.ResponseFusionCallAnalysisCompleted => "response.fusion_call.analysis.completed",
                StreamEventsDiscriminatorType.ResponseFusionCallAnalysisInProgress => "response.fusion_call.analysis.in_progress",
                StreamEventsDiscriminatorType.ResponseFusionCallCompleted => "response.fusion_call.completed",
                StreamEventsDiscriminatorType.ResponseFusionCallInProgress => "response.fusion_call.in_progress",
                StreamEventsDiscriminatorType.ResponseFusionCallPanelAdded => "response.fusion_call.panel.added",
                StreamEventsDiscriminatorType.ResponseFusionCallPanelCompleted => "response.fusion_call.panel.completed",
                StreamEventsDiscriminatorType.ResponseFusionCallPanelDelta => "response.fusion_call.panel.delta",
                StreamEventsDiscriminatorType.ResponseFusionCallPanelFailed => "response.fusion_call.panel.failed",
                StreamEventsDiscriminatorType.ResponseFusionCallPanelReasoningDelta => "response.fusion_call.panel.reasoning.delta",
                StreamEventsDiscriminatorType.ResponseImageGenerationCallCompleted => "response.image_generation_call.completed",
                StreamEventsDiscriminatorType.ResponseImageGenerationCallGenerating => "response.image_generation_call.generating",
                StreamEventsDiscriminatorType.ResponseImageGenerationCallInProgress => "response.image_generation_call.in_progress",
                StreamEventsDiscriminatorType.ResponseImageGenerationCallPartialImage => "response.image_generation_call.partial_image",
                StreamEventsDiscriminatorType.ResponseInProgress => "response.in_progress",
                StreamEventsDiscriminatorType.ResponseIncomplete => "response.incomplete",
                StreamEventsDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                StreamEventsDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                StreamEventsDiscriminatorType.ResponseOutputTextAnnotationAdded => "response.output_text.annotation.added",
                StreamEventsDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                StreamEventsDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                StreamEventsDiscriminatorType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                StreamEventsDiscriminatorType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                StreamEventsDiscriminatorType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                StreamEventsDiscriminatorType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
                StreamEventsDiscriminatorType.ResponseReasoningTextDelta => "response.reasoning_text.delta",
                StreamEventsDiscriminatorType.ResponseReasoningTextDone => "response.reasoning_text.done",
                StreamEventsDiscriminatorType.ResponseRefusalDelta => "response.refusal.delta",
                StreamEventsDiscriminatorType.ResponseRefusalDone => "response.refusal.done",
                StreamEventsDiscriminatorType.ResponseWebSearchCallCompleted => "response.web_search_call.completed",
                StreamEventsDiscriminatorType.ResponseWebSearchCallInProgress => "response.web_search_call.in_progress",
                StreamEventsDiscriminatorType.ResponseWebSearchCallSearching => "response.web_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamEventsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => StreamEventsDiscriminatorType.Error,
                "response.apply_patch_call_operation_diff.delta" => StreamEventsDiscriminatorType.ResponseApplyPatchCallOperationDiffDelta,
                "response.apply_patch_call_operation_diff.done" => StreamEventsDiscriminatorType.ResponseApplyPatchCallOperationDiffDone,
                "response.code_interpreter_call.completed" => StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCompleted,
                "response.code_interpreter_call.in_progress" => StreamEventsDiscriminatorType.ResponseCodeInterpreterCallInProgress,
                "response.code_interpreter_call.interpreting" => StreamEventsDiscriminatorType.ResponseCodeInterpreterCallInterpreting,
                "response.code_interpreter_call_code.delta" => StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCodeDelta,
                "response.code_interpreter_call_code.done" => StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCodeDone,
                "response.completed" => StreamEventsDiscriminatorType.ResponseCompleted,
                "response.content_part.added" => StreamEventsDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => StreamEventsDiscriminatorType.ResponseContentPartDone,
                "response.created" => StreamEventsDiscriminatorType.ResponseCreated,
                "response.custom_tool_call_input.delta" => StreamEventsDiscriminatorType.ResponseCustomToolCallInputDelta,
                "response.custom_tool_call_input.done" => StreamEventsDiscriminatorType.ResponseCustomToolCallInputDone,
                "response.debug" => StreamEventsDiscriminatorType.ResponseDebug,
                "response.failed" => StreamEventsDiscriminatorType.ResponseFailed,
                "response.function_call_arguments.delta" => StreamEventsDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => StreamEventsDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.fusion_call.analysis.completed" => StreamEventsDiscriminatorType.ResponseFusionCallAnalysisCompleted,
                "response.fusion_call.analysis.in_progress" => StreamEventsDiscriminatorType.ResponseFusionCallAnalysisInProgress,
                "response.fusion_call.completed" => StreamEventsDiscriminatorType.ResponseFusionCallCompleted,
                "response.fusion_call.in_progress" => StreamEventsDiscriminatorType.ResponseFusionCallInProgress,
                "response.fusion_call.panel.added" => StreamEventsDiscriminatorType.ResponseFusionCallPanelAdded,
                "response.fusion_call.panel.completed" => StreamEventsDiscriminatorType.ResponseFusionCallPanelCompleted,
                "response.fusion_call.panel.delta" => StreamEventsDiscriminatorType.ResponseFusionCallPanelDelta,
                "response.fusion_call.panel.failed" => StreamEventsDiscriminatorType.ResponseFusionCallPanelFailed,
                "response.fusion_call.panel.reasoning.delta" => StreamEventsDiscriminatorType.ResponseFusionCallPanelReasoningDelta,
                "response.image_generation_call.completed" => StreamEventsDiscriminatorType.ResponseImageGenerationCallCompleted,
                "response.image_generation_call.generating" => StreamEventsDiscriminatorType.ResponseImageGenerationCallGenerating,
                "response.image_generation_call.in_progress" => StreamEventsDiscriminatorType.ResponseImageGenerationCallInProgress,
                "response.image_generation_call.partial_image" => StreamEventsDiscriminatorType.ResponseImageGenerationCallPartialImage,
                "response.in_progress" => StreamEventsDiscriminatorType.ResponseInProgress,
                "response.incomplete" => StreamEventsDiscriminatorType.ResponseIncomplete,
                "response.output_item.added" => StreamEventsDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => StreamEventsDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.annotation.added" => StreamEventsDiscriminatorType.ResponseOutputTextAnnotationAdded,
                "response.output_text.delta" => StreamEventsDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => StreamEventsDiscriminatorType.ResponseOutputTextDone,
                "response.reasoning_summary_part.added" => StreamEventsDiscriminatorType.ResponseReasoningSummaryPartAdded,
                "response.reasoning_summary_part.done" => StreamEventsDiscriminatorType.ResponseReasoningSummaryPartDone,
                "response.reasoning_summary_text.delta" => StreamEventsDiscriminatorType.ResponseReasoningSummaryTextDelta,
                "response.reasoning_summary_text.done" => StreamEventsDiscriminatorType.ResponseReasoningSummaryTextDone,
                "response.reasoning_text.delta" => StreamEventsDiscriminatorType.ResponseReasoningTextDelta,
                "response.reasoning_text.done" => StreamEventsDiscriminatorType.ResponseReasoningTextDone,
                "response.refusal.delta" => StreamEventsDiscriminatorType.ResponseRefusalDelta,
                "response.refusal.done" => StreamEventsDiscriminatorType.ResponseRefusalDone,
                "response.web_search_call.completed" => StreamEventsDiscriminatorType.ResponseWebSearchCallCompleted,
                "response.web_search_call.in_progress" => StreamEventsDiscriminatorType.ResponseWebSearchCallInProgress,
                "response.web_search_call.searching" => StreamEventsDiscriminatorType.ResponseWebSearchCallSearching,
                _ => null,
            };
        }
    }
}