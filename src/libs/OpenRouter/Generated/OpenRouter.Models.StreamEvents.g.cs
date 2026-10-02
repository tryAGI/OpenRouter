#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Union of all possible event types emitted during response streaming<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}
    /// </summary>
    public readonly partial struct StreamEvents : global::System.IEquatable<StreamEvents>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsDiscriminatorType? Type { get; }

        /// <summary>
        /// Event emitted when a response is created<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesCreatedEvent? ResponseCreated { get; init; }
#else
        public global::OpenRouter.OpenResponsesCreatedEvent? ResponseCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreated))]
#endif
        public bool IsResponseCreated => ResponseCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesCreatedEvent? value)
        {
            value = ResponseCreated;
            return IsResponseCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEvent PickResponseCreated() => ResponseCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreated' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a response is in progress<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":1,"type":"response.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesInProgressEvent? ResponseInProgress { get; init; }
#else
        public global::OpenRouter.OpenResponsesInProgressEvent? ResponseInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInProgress))]
#endif
        public bool IsResponseInProgress => ResponseInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesInProgressEvent? value)
        {
            value = ResponseInProgress;
            return IsResponseInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEvent PickResponseInProgress() => ResponseInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a response has completed successfully<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":10,"type":"response.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseCompleted? ResponseCompleted { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseCompleted? ResponseCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCompleted))]
#endif
        public bool IsResponseCompleted => ResponseCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseCompleted? value)
        {
            value = ResponseCompleted;
            return IsResponseCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompleted PickResponseCompleted() => ResponseCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a response is incomplete<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"incomplete","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":5,"type":"response.incomplete"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseIncomplete? ResponseIncomplete { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseIncomplete? ResponseIncomplete { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseIncomplete))]
#endif
        public bool IsResponseIncomplete => ResponseIncomplete != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseIncomplete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseIncomplete? value)
        {
            value = ResponseIncomplete;
            return IsResponseIncomplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncomplete PickResponseIncomplete() => ResponseIncomplete is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseIncomplete' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a response has failed<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"failed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":3,"type":"response.failed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseFailed? ResponseFailed { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseFailed? ResponseFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFailed))]
#endif
        public bool IsResponseFailed => ResponseFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseFailed? value)
        {
            value = ResponseFailed;
            return IsResponseFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailed PickResponseFailed() => ResponseFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFailed' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when an error occurs during streaming<br/>
        /// Example: {"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later.","param":null,"sequence_number":2,"type":"error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ErrorEvent? Error { get; init; }
#else
        public global::OpenRouter.ErrorEvent? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ErrorEvent PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a new output item is added to the response<br/>
        /// Example: {"item":{"content":[],"id":"item-1","role":"assistant","status":"in_progress","type":"message"},"output_index":0,"sequence_number":2,"type":"response.output_item.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseOutputItemAdded? ResponseOutputItemAdded { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseOutputItemAdded? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseOutputItemAdded? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAdded PickResponseOutputItemAdded() => ResponseOutputItemAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when an output item is complete<br/>
        /// Example: {"item":{"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"item-1","role":"assistant","status":"completed","type":"message"},"output_index":0,"sequence_number":8,"type":"response.output_item.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseOutputItemDone? ResponseOutputItemDone { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseOutputItemDone? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseOutputItemDone? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDone PickResponseOutputItemDone() => ResponseOutputItemDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a new content part is added to an output item<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"part":{"annotations":[],"text":"","type":"output_text"},"sequence_number":3,"type":"response.content_part.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartAddedEvent? ResponseContentPartAdded { get; init; }
#else
        public global::OpenRouter.ContentPartAddedEvent? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartAddedEvent? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEvent PickResponseContentPartAdded() => ResponseContentPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a content part is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"part":{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"},"sequence_number":7,"type":"response.content_part.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartDoneEvent? ResponseContentPartDone { get; init; }
#else
        public global::OpenRouter.ContentPartDoneEvent? ResponseContentPartDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartDoneEvent? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEvent PickResponseContentPartDone() => ResponseContentPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a text delta is streamed<br/>
        /// Example: {"content_index":0,"delta":"Hello","item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":4,"type":"response.output_text.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.TextDeltaEvent? ResponseOutputTextDelta { get; init; }
#else
        public global::OpenRouter.TextDeltaEvent? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.TextDeltaEvent? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEvent PickResponseOutputTextDelta() => ResponseOutputTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when text streaming is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":6,"text":"Hello! How can I help you?","type":"response.output_text.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.TextDoneEvent? ResponseOutputTextDone { get; init; }
#else
        public global::OpenRouter.TextDoneEvent? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.TextDoneEvent? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEvent PickResponseOutputTextDone() => ResponseOutputTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a refusal delta is streamed<br/>
        /// Example: {"content_index":0,"delta":"I\u0027m sorry","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.refusal.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RefusalDeltaEvent? ResponseRefusalDelta { get; init; }
#else
        public global::OpenRouter.RefusalDeltaEvent? ResponseRefusalDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDelta))]
#endif
        public bool IsResponseRefusalDelta => ResponseRefusalDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseRefusalDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RefusalDeltaEvent? value)
        {
            value = ResponseRefusalDelta;
            return IsResponseRefusalDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDeltaEvent PickResponseRefusalDelta() => ResponseRefusalDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when refusal streaming is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"refusal":"I\u0027m sorry, but I can\u0027t assist with that request.","sequence_number":6,"type":"response.refusal.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RefusalDoneEvent? ResponseRefusalDone { get; init; }
#else
        public global::OpenRouter.RefusalDoneEvent? ResponseRefusalDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseRefusalDone))]
#endif
        public bool IsResponseRefusalDone => ResponseRefusalDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseRefusalDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RefusalDoneEvent? value)
        {
            value = ResponseRefusalDone;
            return IsResponseRefusalDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RefusalDoneEvent PickResponseRefusalDone() => ResponseRefusalDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseRefusalDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a text annotation is added to output<br/>
        /// Example: {"annotation":{"end_index":7,"start_index":0,"title":"Example","type":"url_citation","url":"https://example.com"},"annotation_index":0,"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":5,"type":"response.output_text.annotation.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; init; }
#else
        public global::OpenRouter.AnnotationAddedEvent? ResponseOutputTextAnnotationAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextAnnotationAdded))]
#endif
        public bool IsResponseOutputTextAnnotationAdded => ResponseOutputTextAnnotationAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextAnnotationAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnnotationAddedEvent? value)
        {
            value = ResponseOutputTextAnnotationAdded;
            return IsResponseOutputTextAnnotationAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnnotationAddedEvent PickResponseOutputTextAnnotationAdded() => ResponseOutputTextAnnotationAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextAnnotationAdded' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when function call arguments are being streamed<br/>
        /// Example: {"delta":"{\u0022city\u0022: \u0022...\u0022}","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.function_call_arguments.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallArgsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; init; }
#else
        public global::OpenRouter.FunctionCallArgsDeltaEvent? ResponseFunctionCallArgumentsDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDelta))]
#endif
        public bool IsResponseFunctionCallArgumentsDelta => ResponseFunctionCallArgumentsDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FunctionCallArgsDeltaEvent? value)
        {
            value = ResponseFunctionCallArgumentsDelta;
            return IsResponseFunctionCallArgumentsDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDeltaEvent PickResponseFunctionCallArgumentsDelta() => ResponseFunctionCallArgumentsDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when function call arguments streaming is complete<br/>
        /// Example: {"arguments":"{\u0022city\u0022: \u0022San Francisco\u0022, \u0022units\u0022: \u0022celsius\u0022}","item_id":"item-1","name":"get_weather","output_index":0,"sequence_number":6,"type":"response.function_call_arguments.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallArgsDoneEvent? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::OpenRouter.FunctionCallArgsDoneEvent? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FunctionCallArgsDoneEvent? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallArgsDoneEvent PickResponseFunctionCallArgumentsDone() => ResponseFunctionCallArgumentsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when reasoning text delta is streamed<br/>
        /// Example: {"content_index":0,"delta":"First, we need","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.reasoning_text.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDeltaEvent? ResponseFusionCallPanelReasoningDelta1 { get; init; }
#else
        public global::OpenRouter.ReasoningDeltaEvent? ResponseFusionCallPanelReasoningDelta1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallPanelReasoningDelta1))]
#endif
        public bool IsResponseFusionCallPanelReasoningDelta1 => ResponseFusionCallPanelReasoningDelta1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallPanelReasoningDelta1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningDeltaEvent? value)
        {
            value = ResponseFusionCallPanelReasoningDelta1;
            return IsResponseFusionCallPanelReasoningDelta1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDeltaEvent PickResponseFusionCallPanelReasoningDelta1() => ResponseFusionCallPanelReasoningDelta1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallPanelReasoningDelta1' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when reasoning text streaming is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":6,"text":"First, we need to identify the key components and then combine them logically.","type":"response.reasoning_text.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningDoneEvent? ResponseReasoningTextDone { get; init; }
#else
        public global::OpenRouter.ReasoningDoneEvent? ResponseReasoningTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningTextDone))]
#endif
        public bool IsResponseReasoningTextDone => ResponseReasoningTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningDoneEvent? value)
        {
            value = ResponseReasoningTextDone;
            return IsResponseReasoningTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningDoneEvent PickResponseReasoningTextDone() => ResponseReasoningTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a reasoning summary part is added<br/>
        /// Example: {"item_id":"item-1","output_index":0,"part":{"text":"","type":"summary_text"},"sequence_number":3,"summary_index":0,"type":"response.reasoning_summary_part.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; init; }
#else
        public global::OpenRouter.ReasoningSummaryPartAddedEvent? ResponseReasoningSummaryPartAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartAdded))]
#endif
        public bool IsResponseReasoningSummaryPartAdded => ResponseReasoningSummaryPartAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningSummaryPartAddedEvent? value)
        {
            value = ResponseReasoningSummaryPartAdded;
            return IsResponseReasoningSummaryPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartAddedEvent PickResponseReasoningSummaryPartAdded() => ResponseReasoningSummaryPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a reasoning summary part is complete<br/>
        /// Example: {"item_id":"item-1","output_index":0,"part":{"text":"Analyzing the problem step by step to find the optimal solution.","type":"summary_text"},"sequence_number":7,"summary_index":0,"type":"response.reasoning_summary_part.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; init; }
#else
        public global::OpenRouter.ReasoningSummaryPartDoneEvent? ResponseReasoningSummaryPartDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryPartDone))]
#endif
        public bool IsResponseReasoningSummaryPartDone => ResponseReasoningSummaryPartDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningSummaryPartDoneEvent? value)
        {
            value = ResponseReasoningSummaryPartDone;
            return IsResponseReasoningSummaryPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryPartDoneEvent PickResponseReasoningSummaryPartDone() => ResponseReasoningSummaryPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryPartDone' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when reasoning summary text delta is streamed<br/>
        /// Example: {"delta":"Analyzing","item_id":"item-1","output_index":0,"sequence_number":4,"summary_index":0,"type":"response.reasoning_summary_text.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; init; }
#else
        public global::OpenRouter.ReasoningSummaryTextDeltaEvent? ResponseReasoningSummaryTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextDelta))]
#endif
        public bool IsResponseReasoningSummaryTextDelta => ResponseReasoningSummaryTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningSummaryTextDeltaEvent? value)
        {
            value = ResponseReasoningSummaryTextDelta;
            return IsResponseReasoningSummaryTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDeltaEvent PickResponseReasoningSummaryTextDelta() => ResponseReasoningSummaryTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when reasoning summary text streaming is complete<br/>
        /// Example: {"item_id":"item-1","output_index":0,"sequence_number":6,"summary_index":0,"text":"Analyzing the problem step by step to find the optimal solution.","type":"response.reasoning_summary_text.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; init; }
#else
        public global::OpenRouter.ReasoningSummaryTextDoneEvent? ResponseReasoningSummaryTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseReasoningSummaryTextDone))]
#endif
        public bool IsResponseReasoningSummaryTextDone => ResponseReasoningSummaryTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseReasoningSummaryTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningSummaryTextDoneEvent? value)
        {
            value = ResponseReasoningSummaryTextDone;
            return IsResponseReasoningSummaryTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningSummaryTextDoneEvent PickResponseReasoningSummaryTextDone() => ResponseReasoningSummaryTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseReasoningSummaryTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Image generation call in progress<br/>
        /// Example: {"item_id":"call-123","output_index":0,"sequence_number":1,"type":"response.image_generation_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; init; }
#else
        public global::OpenRouter.ImageGenCallInProgressEvent? ResponseImageGenerationCallInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallInProgress))]
#endif
        public bool IsResponseImageGenerationCallInProgress => ResponseImageGenerationCallInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenCallInProgressEvent? value)
        {
            value = ResponseImageGenerationCallInProgress;
            return IsResponseImageGenerationCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallInProgressEvent PickResponseImageGenerationCallInProgress() => ResponseImageGenerationCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Image generation call is generating<br/>
        /// Example: {"item_id":"call-123","output_index":0,"sequence_number":2,"type":"response.image_generation_call.generating"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; init; }
#else
        public global::OpenRouter.ImageGenCallGeneratingEvent? ResponseImageGenerationCallGenerating { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallGenerating))]
#endif
        public bool IsResponseImageGenerationCallGenerating => ResponseImageGenerationCallGenerating != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallGenerating(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenCallGeneratingEvent? value)
        {
            value = ResponseImageGenerationCallGenerating;
            return IsResponseImageGenerationCallGenerating;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallGeneratingEvent PickResponseImageGenerationCallGenerating() => ResponseImageGenerationCallGenerating is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallGenerating' but the value was {ToString()}.");

        /// <summary>
        /// Image generation call with partial image<br/>
        /// Example: {"item_id":"call-123","output_index":0,"partial_image_b64":"base64encodedimage...","partial_image_index":0,"sequence_number":3,"type":"response.image_generation_call.partial_image"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; init; }
#else
        public global::OpenRouter.ImageGenCallPartialImageEvent? ResponseImageGenerationCallPartialImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallPartialImage))]
#endif
        public bool IsResponseImageGenerationCallPartialImage => ResponseImageGenerationCallPartialImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallPartialImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenCallPartialImageEvent? value)
        {
            value = ResponseImageGenerationCallPartialImage;
            return IsResponseImageGenerationCallPartialImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallPartialImageEvent PickResponseImageGenerationCallPartialImage() => ResponseImageGenerationCallPartialImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallPartialImage' but the value was {ToString()}.");

        /// <summary>
        /// Image generation call completed<br/>
        /// Example: {"item_id":"call-123","output_index":0,"sequence_number":4,"type":"response.image_generation_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; init; }
#else
        public global::OpenRouter.ImageGenCallCompletedEvent? ResponseImageGenerationCallCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseImageGenerationCallCompleted))]
#endif
        public bool IsResponseImageGenerationCallCompleted => ResponseImageGenerationCallCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseImageGenerationCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenCallCompletedEvent? value)
        {
            value = ResponseImageGenerationCallCompleted;
            return IsResponseImageGenerationCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ImageGenCallCompletedEvent PickResponseImageGenerationCallCompleted() => ResponseImageGenerationCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseImageGenerationCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Code interpreter call in progress<br/>
        /// Example: {"item_id":"ci-abc123","output_index":0,"sequence_number":2,"type":"response.code_interpreter_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallInProgressEvent? ResponseCodeInterpreterCallInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInProgress))]
#endif
        public bool IsResponseCodeInterpreterCallInProgress => ResponseCodeInterpreterCallInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterCallInProgressEvent? value)
        {
            value = ResponseCodeInterpreterCallInProgress;
            return IsResponseCodeInterpreterCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInProgressEvent PickResponseCodeInterpreterCallInProgress() => ResponseCodeInterpreterCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Code interpreter is executing the code<br/>
        /// Example: {"item_id":"ci-abc123","output_index":0,"sequence_number":9,"type":"response.code_interpreter_call.interpreting"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallInterpretingEvent? ResponseCodeInterpreterCallInterpreting { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallInterpreting))]
#endif
        public bool IsResponseCodeInterpreterCallInterpreting => ResponseCodeInterpreterCallInterpreting != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallInterpreting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterCallInterpretingEvent? value)
        {
            value = ResponseCodeInterpreterCallInterpreting;
            return IsResponseCodeInterpreterCallInterpreting;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallInterpretingEvent PickResponseCodeInterpreterCallInterpreting() => ResponseCodeInterpreterCallInterpreting is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallInterpreting' but the value was {ToString()}.");

        /// <summary>
        /// Code interpreter call completed<br/>
        /// Example: {"item_id":"ci-abc123","output_index":0,"sequence_number":10,"type":"response.code_interpreter_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallCompletedEvent? ResponseCodeInterpreterCallCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCompleted))]
#endif
        public bool IsResponseCodeInterpreterCallCompleted => ResponseCodeInterpreterCallCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterCallCompletedEvent? value)
        {
            value = ResponseCodeInterpreterCallCompleted;
            return IsResponseCodeInterpreterCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCompletedEvent PickResponseCodeInterpreterCallCompleted() => ResponseCodeInterpreterCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Incremental chunk of code being streamed for a `code_interpreter_call`.<br/>
        /// Example: {"delta":"print(\u0022hello\u0022)","item_id":"ci-abc123","output_index":0,"sequence_number":3,"type":"response.code_interpreter_call_code.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? ResponseCodeInterpreterCallCodeDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDelta))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDelta => ResponseCodeInterpreterCallCodeDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDelta;
            return IsResponseCodeInterpreterCallCodeDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDeltaEvent PickResponseCodeInterpreterCallCodeDelta() => ResponseCodeInterpreterCallCodeDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when code streaming completes for a `code_interpreter_call`.<br/>
        /// Example: {"code":"print(\u0022hello\u0022)","item_id":"ci-abc123","output_index":0,"sequence_number":8,"type":"response.code_interpreter_call_code.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallCodeDoneEvent? ResponseCodeInterpreterCallCodeDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCodeInterpreterCallCodeDone))]
#endif
        public bool IsResponseCodeInterpreterCallCodeDone => ResponseCodeInterpreterCallCodeDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCodeInterpreterCallCodeDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterCallCodeDoneEvent? value)
        {
            value = ResponseCodeInterpreterCallCodeDone;
            return IsResponseCodeInterpreterCallCodeDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallCodeDoneEvent PickResponseCodeInterpreterCallCodeDone() => ResponseCodeInterpreterCallCodeDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCodeInterpreterCallCodeDone' but the value was {ToString()}.");

        /// <summary>
        /// Web search call in progress<br/>
        /// Example: {"item_id":"ws-123","output_index":0,"sequence_number":1,"type":"response.web_search_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; init; }
#else
        public global::OpenRouter.WebSearchCallInProgressEvent? ResponseWebSearchCallInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallInProgress))]
#endif
        public bool IsResponseWebSearchCallInProgress => ResponseWebSearchCallInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebSearchCallInProgressEvent? value)
        {
            value = ResponseWebSearchCallInProgress;
            return IsResponseWebSearchCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallInProgressEvent PickResponseWebSearchCallInProgress() => ResponseWebSearchCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Web search call is searching<br/>
        /// Example: {"item_id":"ws-123","output_index":0,"sequence_number":2,"type":"response.web_search_call.searching"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; init; }
#else
        public global::OpenRouter.WebSearchCallSearchingEvent? ResponseWebSearchCallSearching { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallSearching))]
#endif
        public bool IsResponseWebSearchCallSearching => ResponseWebSearchCallSearching != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallSearching(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebSearchCallSearchingEvent? value)
        {
            value = ResponseWebSearchCallSearching;
            return IsResponseWebSearchCallSearching;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallSearchingEvent PickResponseWebSearchCallSearching() => ResponseWebSearchCallSearching is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallSearching' but the value was {ToString()}.");

        /// <summary>
        /// Web search call completed<br/>
        /// Example: {"item_id":"ws-123","output_index":0,"sequence_number":3,"type":"response.web_search_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; init; }
#else
        public global::OpenRouter.WebSearchCallCompletedEvent? ResponseWebSearchCallCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseWebSearchCallCompleted))]
#endif
        public bool IsResponseWebSearchCallCompleted => ResponseWebSearchCallCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseWebSearchCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebSearchCallCompletedEvent? value)
        {
            value = ResponseWebSearchCallCompleted;
            return IsResponseWebSearchCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchCallCompletedEvent PickResponseWebSearchCallCompleted() => ResponseWebSearchCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseWebSearchCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a custom tool call's freeform input is being streamed. Mirrors `response.function_call_arguments.delta` but for `custom` tools whose input is opaque text rather than JSON arguments.<br/>
        /// Example: {"delta":"*** Begin Patch","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.custom_tool_call_input.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomToolCallInputDeltaEvent? ResponseCustomToolCallInputDelta { get; init; }
#else
        public global::OpenRouter.CustomToolCallInputDeltaEvent? ResponseCustomToolCallInputDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallInputDelta))]
#endif
        public bool IsResponseCustomToolCallInputDelta => ResponseCustomToolCallInputDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCustomToolCallInputDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomToolCallInputDeltaEvent? value)
        {
            value = ResponseCustomToolCallInputDelta;
            return IsResponseCustomToolCallInputDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDeltaEvent PickResponseCustomToolCallInputDelta() => ResponseCustomToolCallInputDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event emitted when a custom tool call's freeform input streaming is complete. Mirrors `response.function_call_arguments.done` but for `custom` tools.<br/>
        /// Example: {"input":"*** Begin Patch\n*** End Patch","item_id":"item-1","output_index":0,"sequence_number":6,"type":"response.custom_tool_call_input.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomToolCallInputDoneEvent? ResponseCustomToolCallInputDone { get; init; }
#else
        public global::OpenRouter.CustomToolCallInputDoneEvent? ResponseCustomToolCallInputDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCustomToolCallInputDone))]
#endif
        public bool IsResponseCustomToolCallInputDone => ResponseCustomToolCallInputDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCustomToolCallInputDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomToolCallInputDoneEvent? value)
        {
            value = ResponseCustomToolCallInputDone;
            return IsResponseCustomToolCallInputDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallInputDoneEvent PickResponseCustomToolCallInputDone() => ResponseCustomToolCallInputDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCustomToolCallInputDone' but the value was {ToString()}.");

        /// <summary>
        /// Incremental chunk of `operation.diff` for an `apply_patch_call`. Matches OpenAI's streaming shape.<br/>
        /// Example: {"delta":"\u002Bconsole.log(\u0022hi\u0022);\n","item_id":"apc_abc123","output_index":0,"sequence_number":5,"type":"response.apply_patch_call_operation_diff.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? ResponseApplyPatchCallOperationDiffDelta { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? ResponseApplyPatchCallOperationDiffDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseApplyPatchCallOperationDiffDelta))]
#endif
        public bool IsResponseApplyPatchCallOperationDiffDelta => ResponseApplyPatchCallOperationDiffDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseApplyPatchCallOperationDiffDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? value)
        {
            value = ResponseApplyPatchCallOperationDiffDelta;
            return IsResponseApplyPatchCallOperationDiffDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent PickResponseApplyPatchCallOperationDiffDelta() => ResponseApplyPatchCallOperationDiffDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseApplyPatchCallOperationDiffDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when `operation.diff` streaming completes for an `apply_patch_call`.<br/>
        /// Example: {"diff":"@@\n\u002Bconsole.log(\u0022hi\u0022);\n","item_id":"apc_abc123","output_index":0,"sequence_number":12,"type":"response.apply_patch_call_operation_diff.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? ResponseApplyPatchCallOperationDiffDone { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? ResponseApplyPatchCallOperationDiffDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseApplyPatchCallOperationDiffDone))]
#endif
        public bool IsResponseApplyPatchCallOperationDiffDone => ResponseApplyPatchCallOperationDiffDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseApplyPatchCallOperationDiffDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? value)
        {
            value = ResponseApplyPatchCallOperationDiffDone;
            return IsResponseApplyPatchCallOperationDiffDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent PickResponseApplyPatchCallOperationDiffDone() => ResponseApplyPatchCallOperationDiffDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseApplyPatchCallOperationDiffDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an openrouter:fusion tool call begins executing.<br/>
        /// Example: {"item_id":"st_fusion_abc","output_index":0,"sequence_number":3,"type":"response.fusion_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallInProgressEvent? ResponseFusionCallInProgress { get; init; }
#else
        public global::OpenRouter.FusionCallInProgressEvent? ResponseFusionCallInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallInProgress))]
#endif
        public bool IsResponseFusionCallInProgress => ResponseFusionCallInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallInProgressEvent? value)
        {
            value = ResponseFusionCallInProgress;
            return IsResponseFusionCallInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallInProgressEvent PickResponseFusionCallInProgress() => ResponseFusionCallInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a fusion analysis-panel model starts.<br/>
        /// Example: {"item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":4,"type":"response.fusion_call.panel.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallPanelAddedEvent? ResponseFusionCallPanelAdded { get; init; }
#else
        public global::OpenRouter.FusionCallPanelAddedEvent? ResponseFusionCallPanelAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallPanelAdded))]
#endif
        public bool IsResponseFusionCallPanelAdded => ResponseFusionCallPanelAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallPanelAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallPanelAddedEvent? value)
        {
            value = ResponseFusionCallPanelAdded;
            return IsResponseFusionCallPanelAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelAddedEvent PickResponseFusionCallPanelAdded() => ResponseFusionCallPanelAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallPanelAdded' but the value was {ToString()}.");

        /// <summary>
        /// Incremental content token from a fusion panel model.<br/>
        /// Example: {"delta":"Carbon taxes","item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":5,"type":"response.fusion_call.panel.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallPanelDeltaEvent? ResponseFusionCallPanelDelta { get; init; }
#else
        public global::OpenRouter.FusionCallPanelDeltaEvent? ResponseFusionCallPanelDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallPanelDelta))]
#endif
        public bool IsResponseFusionCallPanelDelta => ResponseFusionCallPanelDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallPanelDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallPanelDeltaEvent? value)
        {
            value = ResponseFusionCallPanelDelta;
            return IsResponseFusionCallPanelDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelDeltaEvent PickResponseFusionCallPanelDelta() => ResponseFusionCallPanelDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallPanelDelta' but the value was {ToString()}.");

        /// <summary>
        /// Incremental reasoning token from a fusion panel model.<br/>
        /// Example: {"delta":"Considering both sides","item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":6,"type":"response.fusion_call.panel.reasoning.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallPanelReasoningDeltaEvent? ResponseFusionCallPanelReasoningDelta2 { get; init; }
#else
        public global::OpenRouter.FusionCallPanelReasoningDeltaEvent? ResponseFusionCallPanelReasoningDelta2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallPanelReasoningDelta2))]
#endif
        public bool IsResponseFusionCallPanelReasoningDelta2 => ResponseFusionCallPanelReasoningDelta2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallPanelReasoningDelta2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallPanelReasoningDeltaEvent? value)
        {
            value = ResponseFusionCallPanelReasoningDelta2;
            return IsResponseFusionCallPanelReasoningDelta2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelReasoningDeltaEvent PickResponseFusionCallPanelReasoningDelta2() => ResponseFusionCallPanelReasoningDelta2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallPanelReasoningDelta2' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a fusion panel model finishes with its full content.<br/>
        /// Example: {"content":"Full panel response text...","item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":20,"type":"response.fusion_call.panel.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallPanelCompletedEvent? ResponseFusionCallPanelCompleted { get; init; }
#else
        public global::OpenRouter.FusionCallPanelCompletedEvent? ResponseFusionCallPanelCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallPanelCompleted))]
#endif
        public bool IsResponseFusionCallPanelCompleted => ResponseFusionCallPanelCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallPanelCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallPanelCompletedEvent? value)
        {
            value = ResponseFusionCallPanelCompleted;
            return IsResponseFusionCallPanelCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelCompletedEvent PickResponseFusionCallPanelCompleted() => ResponseFusionCallPanelCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallPanelCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a fusion panel model fails.<br/>
        /// Example: {"error":"Upstream provider error","item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":18,"status_code":502,"type":"response.fusion_call.panel.failed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallPanelFailedEvent? ResponseFusionCallPanelFailed { get; init; }
#else
        public global::OpenRouter.FusionCallPanelFailedEvent? ResponseFusionCallPanelFailed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallPanelFailed))]
#endif
        public bool IsResponseFusionCallPanelFailed => ResponseFusionCallPanelFailed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallPanelFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallPanelFailedEvent? value)
        {
            value = ResponseFusionCallPanelFailed;
            return IsResponseFusionCallPanelFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallPanelFailedEvent PickResponseFusionCallPanelFailed() => ResponseFusionCallPanelFailed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallPanelFailed' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the fusion analyst starts producing the structured analysis.<br/>
        /// Example: {"analyst_model":"openai/gpt-5","item_id":"st_fusion_abc","judge_model":"openai/gpt-5","output_index":0,"sequence_number":25,"type":"response.fusion_call.analysis.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallAnalysisInProgressEvent? ResponseFusionCallAnalysisInProgress { get; init; }
#else
        public global::OpenRouter.FusionCallAnalysisInProgressEvent? ResponseFusionCallAnalysisInProgress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallAnalysisInProgress))]
#endif
        public bool IsResponseFusionCallAnalysisInProgress => ResponseFusionCallAnalysisInProgress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallAnalysisInProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallAnalysisInProgressEvent? value)
        {
            value = ResponseFusionCallAnalysisInProgress;
            return IsResponseFusionCallAnalysisInProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisInProgressEvent PickResponseFusionCallAnalysisInProgress() => ResponseFusionCallAnalysisInProgress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallAnalysisInProgress' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the fusion analyst completes with the structured analysis.<br/>
        /// Example: {"analysis":{"blind_spots":[],"consensus":[],"contradictions":[],"partial_coverage":[],"unique_insights":[]},"item_id":"st_fusion_abc","output_index":0,"sequence_number":40,"type":"response.fusion_call.analysis.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallAnalysisCompletedEvent? ResponseFusionCallAnalysisCompleted { get; init; }
#else
        public global::OpenRouter.FusionCallAnalysisCompletedEvent? ResponseFusionCallAnalysisCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallAnalysisCompleted))]
#endif
        public bool IsResponseFusionCallAnalysisCompleted => ResponseFusionCallAnalysisCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallAnalysisCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallAnalysisCompletedEvent? value)
        {
            value = ResponseFusionCallAnalysisCompleted;
            return IsResponseFusionCallAnalysisCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallAnalysisCompletedEvent PickResponseFusionCallAnalysisCompleted() => ResponseFusionCallAnalysisCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallAnalysisCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when the openrouter:fusion tool call finishes.<br/>
        /// Example: {"item_id":"st_fusion_abc","output_index":0,"sequence_number":41,"type":"response.fusion_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionCallCompletedEvent? ResponseFusionCallCompleted { get; init; }
#else
        public global::OpenRouter.FusionCallCompletedEvent? ResponseFusionCallCompleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFusionCallCompleted))]
#endif
        public bool IsResponseFusionCallCompleted => ResponseFusionCallCompleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFusionCallCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionCallCompletedEvent? value)
        {
            value = ResponseFusionCallCompleted;
            return IsResponseFusionCallCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionCallCompletedEvent PickResponseFusionCallCompleted() => ResponseFusionCallCompleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFusionCallCompleted' but the value was {ToString()}.");

        /// <summary>
        /// Debug event emitted when debug.echo_upstream_body is true. Contains the transformed upstream request body or timing milestones.<br/>
        /// Example: {"debug":{"echo_upstream_body":{"messages":[],"model":"anthropic/claude-sonnet-4"}},"sequence_number":1,"type":"response.debug"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DebugEvent? ResponseDebug { get; init; }
#else
        public global::OpenRouter.DebugEvent? ResponseDebug { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseDebug))]
#endif
        public bool IsResponseDebug => ResponseDebug != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseDebug(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DebugEvent? value)
        {
            value = ResponseDebug;
            return IsResponseDebug;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DebugEvent PickResponseDebug() => ResponseDebug is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseDebug' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.OpenResponsesCreatedEvent value) => new StreamEvents((global::OpenRouter.OpenResponsesCreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesCreatedEvent?(StreamEvents @this) => @this.ResponseCreated;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.OpenResponsesCreatedEvent? value)
        {
            ResponseCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCreated(global::OpenRouter.OpenResponsesCreatedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.OpenResponsesInProgressEvent value) => new StreamEvents((global::OpenRouter.OpenResponsesInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesInProgressEvent?(StreamEvents @this) => @this.ResponseInProgress;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.OpenResponsesInProgressEvent? value)
        {
            ResponseInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseInProgress(global::OpenRouter.OpenResponsesInProgressEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.StreamEventsResponseCompleted value) => new StreamEvents((global::OpenRouter.StreamEventsResponseCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseCompleted?(StreamEvents @this) => @this.ResponseCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.StreamEventsResponseCompleted? value)
        {
            ResponseCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCompleted(global::OpenRouter.StreamEventsResponseCompleted? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.StreamEventsResponseIncomplete value) => new StreamEvents((global::OpenRouter.StreamEventsResponseIncomplete?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseIncomplete?(StreamEvents @this) => @this.ResponseIncomplete;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.StreamEventsResponseIncomplete? value)
        {
            ResponseIncomplete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseIncomplete(global::OpenRouter.StreamEventsResponseIncomplete? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.StreamEventsResponseFailed value) => new StreamEvents((global::OpenRouter.StreamEventsResponseFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseFailed?(StreamEvents @this) => @this.ResponseFailed;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.StreamEventsResponseFailed? value)
        {
            ResponseFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFailed(global::OpenRouter.StreamEventsResponseFailed? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ErrorEvent value) => new StreamEvents((global::OpenRouter.ErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ErrorEvent?(StreamEvents @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromError(global::OpenRouter.ErrorEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.StreamEventsResponseOutputItemAdded value) => new StreamEvents((global::OpenRouter.StreamEventsResponseOutputItemAdded?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseOutputItemAdded?(StreamEvents @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.StreamEventsResponseOutputItemAdded? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseOutputItemAdded(global::OpenRouter.StreamEventsResponseOutputItemAdded? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.StreamEventsResponseOutputItemDone value) => new StreamEvents((global::OpenRouter.StreamEventsResponseOutputItemDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseOutputItemDone?(StreamEvents @this) => @this.ResponseOutputItemDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.StreamEventsResponseOutputItemDone? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseOutputItemDone(global::OpenRouter.StreamEventsResponseOutputItemDone? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ContentPartAddedEvent value) => new StreamEvents((global::OpenRouter.ContentPartAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartAddedEvent?(StreamEvents @this) => @this.ResponseContentPartAdded;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ContentPartAddedEvent? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseContentPartAdded(global::OpenRouter.ContentPartAddedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ContentPartDoneEvent value) => new StreamEvents((global::OpenRouter.ContentPartDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartDoneEvent?(StreamEvents @this) => @this.ResponseContentPartDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ContentPartDoneEvent? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseContentPartDone(global::OpenRouter.ContentPartDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.TextDeltaEvent value) => new StreamEvents((global::OpenRouter.TextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.TextDeltaEvent?(StreamEvents @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.TextDeltaEvent? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseOutputTextDelta(global::OpenRouter.TextDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.TextDoneEvent value) => new StreamEvents((global::OpenRouter.TextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.TextDoneEvent?(StreamEvents @this) => @this.ResponseOutputTextDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.TextDoneEvent? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseOutputTextDone(global::OpenRouter.TextDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.RefusalDeltaEvent value) => new StreamEvents((global::OpenRouter.RefusalDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RefusalDeltaEvent?(StreamEvents @this) => @this.ResponseRefusalDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.RefusalDeltaEvent? value)
        {
            ResponseRefusalDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseRefusalDelta(global::OpenRouter.RefusalDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.RefusalDoneEvent value) => new StreamEvents((global::OpenRouter.RefusalDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RefusalDoneEvent?(StreamEvents @this) => @this.ResponseRefusalDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.RefusalDoneEvent? value)
        {
            ResponseRefusalDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseRefusalDone(global::OpenRouter.RefusalDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.AnnotationAddedEvent value) => new StreamEvents((global::OpenRouter.AnnotationAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnnotationAddedEvent?(StreamEvents @this) => @this.ResponseOutputTextAnnotationAdded;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.AnnotationAddedEvent? value)
        {
            ResponseOutputTextAnnotationAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseOutputTextAnnotationAdded(global::OpenRouter.AnnotationAddedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FunctionCallArgsDeltaEvent value) => new StreamEvents((global::OpenRouter.FunctionCallArgsDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallArgsDeltaEvent?(StreamEvents @this) => @this.ResponseFunctionCallArgumentsDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FunctionCallArgsDeltaEvent? value)
        {
            ResponseFunctionCallArgumentsDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFunctionCallArgumentsDelta(global::OpenRouter.FunctionCallArgsDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FunctionCallArgsDoneEvent value) => new StreamEvents((global::OpenRouter.FunctionCallArgsDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallArgsDoneEvent?(StreamEvents @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FunctionCallArgsDoneEvent? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFunctionCallArgumentsDone(global::OpenRouter.FunctionCallArgsDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ReasoningDeltaEvent value) => new StreamEvents((global::OpenRouter.ReasoningDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDeltaEvent?(StreamEvents @this) => @this.ResponseFusionCallPanelReasoningDelta1;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ReasoningDeltaEvent? value)
        {
            ResponseFusionCallPanelReasoningDelta1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallPanelReasoningDelta1(global::OpenRouter.ReasoningDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ReasoningDoneEvent value) => new StreamEvents((global::OpenRouter.ReasoningDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningDoneEvent?(StreamEvents @this) => @this.ResponseReasoningTextDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ReasoningDoneEvent? value)
        {
            ResponseReasoningTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseReasoningTextDone(global::OpenRouter.ReasoningDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ReasoningSummaryPartAddedEvent value) => new StreamEvents((global::OpenRouter.ReasoningSummaryPartAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningSummaryPartAddedEvent?(StreamEvents @this) => @this.ResponseReasoningSummaryPartAdded;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ReasoningSummaryPartAddedEvent? value)
        {
            ResponseReasoningSummaryPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseReasoningSummaryPartAdded(global::OpenRouter.ReasoningSummaryPartAddedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ReasoningSummaryPartDoneEvent value) => new StreamEvents((global::OpenRouter.ReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningSummaryPartDoneEvent?(StreamEvents @this) => @this.ResponseReasoningSummaryPartDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ReasoningSummaryPartDoneEvent? value)
        {
            ResponseReasoningSummaryPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseReasoningSummaryPartDone(global::OpenRouter.ReasoningSummaryPartDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ReasoningSummaryTextDeltaEvent value) => new StreamEvents((global::OpenRouter.ReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningSummaryTextDeltaEvent?(StreamEvents @this) => @this.ResponseReasoningSummaryTextDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ReasoningSummaryTextDeltaEvent? value)
        {
            ResponseReasoningSummaryTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseReasoningSummaryTextDelta(global::OpenRouter.ReasoningSummaryTextDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ReasoningSummaryTextDoneEvent value) => new StreamEvents((global::OpenRouter.ReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningSummaryTextDoneEvent?(StreamEvents @this) => @this.ResponseReasoningSummaryTextDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ReasoningSummaryTextDoneEvent? value)
        {
            ResponseReasoningSummaryTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseReasoningSummaryTextDone(global::OpenRouter.ReasoningSummaryTextDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ImageGenCallInProgressEvent value) => new StreamEvents((global::OpenRouter.ImageGenCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenCallInProgressEvent?(StreamEvents @this) => @this.ResponseImageGenerationCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ImageGenCallInProgressEvent? value)
        {
            ResponseImageGenerationCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseImageGenerationCallInProgress(global::OpenRouter.ImageGenCallInProgressEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ImageGenCallGeneratingEvent value) => new StreamEvents((global::OpenRouter.ImageGenCallGeneratingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenCallGeneratingEvent?(StreamEvents @this) => @this.ResponseImageGenerationCallGenerating;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ImageGenCallGeneratingEvent? value)
        {
            ResponseImageGenerationCallGenerating = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseImageGenerationCallGenerating(global::OpenRouter.ImageGenCallGeneratingEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ImageGenCallPartialImageEvent value) => new StreamEvents((global::OpenRouter.ImageGenCallPartialImageEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenCallPartialImageEvent?(StreamEvents @this) => @this.ResponseImageGenerationCallPartialImage;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ImageGenCallPartialImageEvent? value)
        {
            ResponseImageGenerationCallPartialImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseImageGenerationCallPartialImage(global::OpenRouter.ImageGenCallPartialImageEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ImageGenCallCompletedEvent value) => new StreamEvents((global::OpenRouter.ImageGenCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenCallCompletedEvent?(StreamEvents @this) => @this.ResponseImageGenerationCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ImageGenCallCompletedEvent? value)
        {
            ResponseImageGenerationCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseImageGenerationCallCompleted(global::OpenRouter.ImageGenCallCompletedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CodeInterpreterCallInProgressEvent value) => new StreamEvents((global::OpenRouter.CodeInterpreterCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallInProgressEvent?(StreamEvents @this) => @this.ResponseCodeInterpreterCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CodeInterpreterCallInProgressEvent? value)
        {
            ResponseCodeInterpreterCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCodeInterpreterCallInProgress(global::OpenRouter.CodeInterpreterCallInProgressEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CodeInterpreterCallInterpretingEvent value) => new StreamEvents((global::OpenRouter.CodeInterpreterCallInterpretingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallInterpretingEvent?(StreamEvents @this) => @this.ResponseCodeInterpreterCallInterpreting;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CodeInterpreterCallInterpretingEvent? value)
        {
            ResponseCodeInterpreterCallInterpreting = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCodeInterpreterCallInterpreting(global::OpenRouter.CodeInterpreterCallInterpretingEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CodeInterpreterCallCompletedEvent value) => new StreamEvents((global::OpenRouter.CodeInterpreterCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallCompletedEvent?(StreamEvents @this) => @this.ResponseCodeInterpreterCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CodeInterpreterCallCompletedEvent? value)
        {
            ResponseCodeInterpreterCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCodeInterpreterCallCompleted(global::OpenRouter.CodeInterpreterCallCompletedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent value) => new StreamEvents((global::OpenRouter.CodeInterpreterCallCodeDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallCodeDeltaEvent?(StreamEvents @this) => @this.ResponseCodeInterpreterCallCodeDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? value)
        {
            ResponseCodeInterpreterCallCodeDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCodeInterpreterCallCodeDelta(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CodeInterpreterCallCodeDoneEvent value) => new StreamEvents((global::OpenRouter.CodeInterpreterCallCodeDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallCodeDoneEvent?(StreamEvents @this) => @this.ResponseCodeInterpreterCallCodeDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CodeInterpreterCallCodeDoneEvent? value)
        {
            ResponseCodeInterpreterCallCodeDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCodeInterpreterCallCodeDone(global::OpenRouter.CodeInterpreterCallCodeDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.WebSearchCallInProgressEvent value) => new StreamEvents((global::OpenRouter.WebSearchCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchCallInProgressEvent?(StreamEvents @this) => @this.ResponseWebSearchCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.WebSearchCallInProgressEvent? value)
        {
            ResponseWebSearchCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseWebSearchCallInProgress(global::OpenRouter.WebSearchCallInProgressEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.WebSearchCallSearchingEvent value) => new StreamEvents((global::OpenRouter.WebSearchCallSearchingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchCallSearchingEvent?(StreamEvents @this) => @this.ResponseWebSearchCallSearching;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.WebSearchCallSearchingEvent? value)
        {
            ResponseWebSearchCallSearching = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseWebSearchCallSearching(global::OpenRouter.WebSearchCallSearchingEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.WebSearchCallCompletedEvent value) => new StreamEvents((global::OpenRouter.WebSearchCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchCallCompletedEvent?(StreamEvents @this) => @this.ResponseWebSearchCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.WebSearchCallCompletedEvent? value)
        {
            ResponseWebSearchCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseWebSearchCallCompleted(global::OpenRouter.WebSearchCallCompletedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CustomToolCallInputDeltaEvent value) => new StreamEvents((global::OpenRouter.CustomToolCallInputDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CustomToolCallInputDeltaEvent?(StreamEvents @this) => @this.ResponseCustomToolCallInputDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CustomToolCallInputDeltaEvent? value)
        {
            ResponseCustomToolCallInputDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCustomToolCallInputDelta(global::OpenRouter.CustomToolCallInputDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.CustomToolCallInputDoneEvent value) => new StreamEvents((global::OpenRouter.CustomToolCallInputDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CustomToolCallInputDoneEvent?(StreamEvents @this) => @this.ResponseCustomToolCallInputDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.CustomToolCallInputDoneEvent? value)
        {
            ResponseCustomToolCallInputDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseCustomToolCallInputDone(global::OpenRouter.CustomToolCallInputDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent value) => new StreamEvents((global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent?(StreamEvents @this) => @this.ResponseApplyPatchCallOperationDiffDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? value)
        {
            ResponseApplyPatchCallOperationDiffDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseApplyPatchCallOperationDiffDelta(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent value) => new StreamEvents((global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent?(StreamEvents @this) => @this.ResponseApplyPatchCallOperationDiffDone;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? value)
        {
            ResponseApplyPatchCallOperationDiffDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseApplyPatchCallOperationDiffDone(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallInProgressEvent value) => new StreamEvents((global::OpenRouter.FusionCallInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallInProgressEvent?(StreamEvents @this) => @this.ResponseFusionCallInProgress;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallInProgressEvent? value)
        {
            ResponseFusionCallInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallInProgress(global::OpenRouter.FusionCallInProgressEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallPanelAddedEvent value) => new StreamEvents((global::OpenRouter.FusionCallPanelAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallPanelAddedEvent?(StreamEvents @this) => @this.ResponseFusionCallPanelAdded;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallPanelAddedEvent? value)
        {
            ResponseFusionCallPanelAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallPanelAdded(global::OpenRouter.FusionCallPanelAddedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallPanelDeltaEvent value) => new StreamEvents((global::OpenRouter.FusionCallPanelDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallPanelDeltaEvent?(StreamEvents @this) => @this.ResponseFusionCallPanelDelta;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallPanelDeltaEvent? value)
        {
            ResponseFusionCallPanelDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallPanelDelta(global::OpenRouter.FusionCallPanelDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallPanelReasoningDeltaEvent value) => new StreamEvents((global::OpenRouter.FusionCallPanelReasoningDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallPanelReasoningDeltaEvent?(StreamEvents @this) => @this.ResponseFusionCallPanelReasoningDelta2;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallPanelReasoningDeltaEvent? value)
        {
            ResponseFusionCallPanelReasoningDelta2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallPanelReasoningDelta2(global::OpenRouter.FusionCallPanelReasoningDeltaEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallPanelCompletedEvent value) => new StreamEvents((global::OpenRouter.FusionCallPanelCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallPanelCompletedEvent?(StreamEvents @this) => @this.ResponseFusionCallPanelCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallPanelCompletedEvent? value)
        {
            ResponseFusionCallPanelCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallPanelCompleted(global::OpenRouter.FusionCallPanelCompletedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallPanelFailedEvent value) => new StreamEvents((global::OpenRouter.FusionCallPanelFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallPanelFailedEvent?(StreamEvents @this) => @this.ResponseFusionCallPanelFailed;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallPanelFailedEvent? value)
        {
            ResponseFusionCallPanelFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallPanelFailed(global::OpenRouter.FusionCallPanelFailedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallAnalysisInProgressEvent value) => new StreamEvents((global::OpenRouter.FusionCallAnalysisInProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallAnalysisInProgressEvent?(StreamEvents @this) => @this.ResponseFusionCallAnalysisInProgress;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallAnalysisInProgressEvent? value)
        {
            ResponseFusionCallAnalysisInProgress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallAnalysisInProgress(global::OpenRouter.FusionCallAnalysisInProgressEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallAnalysisCompletedEvent value) => new StreamEvents((global::OpenRouter.FusionCallAnalysisCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallAnalysisCompletedEvent?(StreamEvents @this) => @this.ResponseFusionCallAnalysisCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallAnalysisCompletedEvent? value)
        {
            ResponseFusionCallAnalysisCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallAnalysisCompleted(global::OpenRouter.FusionCallAnalysisCompletedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.FusionCallCompletedEvent value) => new StreamEvents((global::OpenRouter.FusionCallCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionCallCompletedEvent?(StreamEvents @this) => @this.ResponseFusionCallCompleted;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.FusionCallCompletedEvent? value)
        {
            ResponseFusionCallCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseFusionCallCompleted(global::OpenRouter.FusionCallCompletedEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEvents(global::OpenRouter.DebugEvent value) => new StreamEvents((global::OpenRouter.DebugEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DebugEvent?(StreamEvents @this) => @this.ResponseDebug;

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(global::OpenRouter.DebugEvent? value)
        {
            ResponseDebug = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEvents FromResponseDebug(global::OpenRouter.DebugEvent? value) => new StreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public StreamEvents(
            global::OpenRouter.StreamEventsDiscriminatorType? type,
            global::OpenRouter.OpenResponsesCreatedEvent? responseCreated,
            global::OpenRouter.OpenResponsesInProgressEvent? responseInProgress,
            global::OpenRouter.StreamEventsResponseCompleted? responseCompleted,
            global::OpenRouter.StreamEventsResponseIncomplete? responseIncomplete,
            global::OpenRouter.StreamEventsResponseFailed? responseFailed,
            global::OpenRouter.ErrorEvent? error,
            global::OpenRouter.StreamEventsResponseOutputItemAdded? responseOutputItemAdded,
            global::OpenRouter.StreamEventsResponseOutputItemDone? responseOutputItemDone,
            global::OpenRouter.ContentPartAddedEvent? responseContentPartAdded,
            global::OpenRouter.ContentPartDoneEvent? responseContentPartDone,
            global::OpenRouter.TextDeltaEvent? responseOutputTextDelta,
            global::OpenRouter.TextDoneEvent? responseOutputTextDone,
            global::OpenRouter.RefusalDeltaEvent? responseRefusalDelta,
            global::OpenRouter.RefusalDoneEvent? responseRefusalDone,
            global::OpenRouter.AnnotationAddedEvent? responseOutputTextAnnotationAdded,
            global::OpenRouter.FunctionCallArgsDeltaEvent? responseFunctionCallArgumentsDelta,
            global::OpenRouter.FunctionCallArgsDoneEvent? responseFunctionCallArgumentsDone,
            global::OpenRouter.ReasoningDeltaEvent? responseFusionCallPanelReasoningDelta1,
            global::OpenRouter.ReasoningDoneEvent? responseReasoningTextDone,
            global::OpenRouter.ReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded,
            global::OpenRouter.ReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone,
            global::OpenRouter.ReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta,
            global::OpenRouter.ReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone,
            global::OpenRouter.ImageGenCallInProgressEvent? responseImageGenerationCallInProgress,
            global::OpenRouter.ImageGenCallGeneratingEvent? responseImageGenerationCallGenerating,
            global::OpenRouter.ImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage,
            global::OpenRouter.ImageGenCallCompletedEvent? responseImageGenerationCallCompleted,
            global::OpenRouter.CodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress,
            global::OpenRouter.CodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting,
            global::OpenRouter.CodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted,
            global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta,
            global::OpenRouter.CodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone,
            global::OpenRouter.WebSearchCallInProgressEvent? responseWebSearchCallInProgress,
            global::OpenRouter.WebSearchCallSearchingEvent? responseWebSearchCallSearching,
            global::OpenRouter.WebSearchCallCompletedEvent? responseWebSearchCallCompleted,
            global::OpenRouter.CustomToolCallInputDeltaEvent? responseCustomToolCallInputDelta,
            global::OpenRouter.CustomToolCallInputDoneEvent? responseCustomToolCallInputDone,
            global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? responseApplyPatchCallOperationDiffDelta,
            global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? responseApplyPatchCallOperationDiffDone,
            global::OpenRouter.FusionCallInProgressEvent? responseFusionCallInProgress,
            global::OpenRouter.FusionCallPanelAddedEvent? responseFusionCallPanelAdded,
            global::OpenRouter.FusionCallPanelDeltaEvent? responseFusionCallPanelDelta,
            global::OpenRouter.FusionCallPanelReasoningDeltaEvent? responseFusionCallPanelReasoningDelta2,
            global::OpenRouter.FusionCallPanelCompletedEvent? responseFusionCallPanelCompleted,
            global::OpenRouter.FusionCallPanelFailedEvent? responseFusionCallPanelFailed,
            global::OpenRouter.FusionCallAnalysisInProgressEvent? responseFusionCallAnalysisInProgress,
            global::OpenRouter.FusionCallAnalysisCompletedEvent? responseFusionCallAnalysisCompleted,
            global::OpenRouter.FusionCallCompletedEvent? responseFusionCallCompleted,
            global::OpenRouter.DebugEvent? responseDebug
            )
        {
            Type = type;

            ResponseCreated = responseCreated;
            ResponseInProgress = responseInProgress;
            ResponseCompleted = responseCompleted;
            ResponseIncomplete = responseIncomplete;
            ResponseFailed = responseFailed;
            Error = error;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseContentPartDone = responseContentPartDone;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            ResponseRefusalDelta = responseRefusalDelta;
            ResponseRefusalDone = responseRefusalDone;
            ResponseOutputTextAnnotationAdded = responseOutputTextAnnotationAdded;
            ResponseFunctionCallArgumentsDelta = responseFunctionCallArgumentsDelta;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            ResponseFusionCallPanelReasoningDelta1 = responseFusionCallPanelReasoningDelta1;
            ResponseReasoningTextDone = responseReasoningTextDone;
            ResponseReasoningSummaryPartAdded = responseReasoningSummaryPartAdded;
            ResponseReasoningSummaryPartDone = responseReasoningSummaryPartDone;
            ResponseReasoningSummaryTextDelta = responseReasoningSummaryTextDelta;
            ResponseReasoningSummaryTextDone = responseReasoningSummaryTextDone;
            ResponseImageGenerationCallInProgress = responseImageGenerationCallInProgress;
            ResponseImageGenerationCallGenerating = responseImageGenerationCallGenerating;
            ResponseImageGenerationCallPartialImage = responseImageGenerationCallPartialImage;
            ResponseImageGenerationCallCompleted = responseImageGenerationCallCompleted;
            ResponseCodeInterpreterCallInProgress = responseCodeInterpreterCallInProgress;
            ResponseCodeInterpreterCallInterpreting = responseCodeInterpreterCallInterpreting;
            ResponseCodeInterpreterCallCompleted = responseCodeInterpreterCallCompleted;
            ResponseCodeInterpreterCallCodeDelta = responseCodeInterpreterCallCodeDelta;
            ResponseCodeInterpreterCallCodeDone = responseCodeInterpreterCallCodeDone;
            ResponseWebSearchCallInProgress = responseWebSearchCallInProgress;
            ResponseWebSearchCallSearching = responseWebSearchCallSearching;
            ResponseWebSearchCallCompleted = responseWebSearchCallCompleted;
            ResponseCustomToolCallInputDelta = responseCustomToolCallInputDelta;
            ResponseCustomToolCallInputDone = responseCustomToolCallInputDone;
            ResponseApplyPatchCallOperationDiffDelta = responseApplyPatchCallOperationDiffDelta;
            ResponseApplyPatchCallOperationDiffDone = responseApplyPatchCallOperationDiffDone;
            ResponseFusionCallInProgress = responseFusionCallInProgress;
            ResponseFusionCallPanelAdded = responseFusionCallPanelAdded;
            ResponseFusionCallPanelDelta = responseFusionCallPanelDelta;
            ResponseFusionCallPanelReasoningDelta2 = responseFusionCallPanelReasoningDelta2;
            ResponseFusionCallPanelCompleted = responseFusionCallPanelCompleted;
            ResponseFusionCallPanelFailed = responseFusionCallPanelFailed;
            ResponseFusionCallAnalysisInProgress = responseFusionCallAnalysisInProgress;
            ResponseFusionCallAnalysisCompleted = responseFusionCallAnalysisCompleted;
            ResponseFusionCallCompleted = responseFusionCallCompleted;
            ResponseDebug = responseDebug;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseDebug as object ??
            ResponseFusionCallCompleted as object ??
            ResponseFusionCallAnalysisCompleted as object ??
            ResponseFusionCallAnalysisInProgress as object ??
            ResponseFusionCallPanelFailed as object ??
            ResponseFusionCallPanelCompleted as object ??
            ResponseFusionCallPanelReasoningDelta2 as object ??
            ResponseFusionCallPanelDelta as object ??
            ResponseFusionCallPanelAdded as object ??
            ResponseFusionCallInProgress as object ??
            ResponseApplyPatchCallOperationDiffDone as object ??
            ResponseApplyPatchCallOperationDiffDelta as object ??
            ResponseCustomToolCallInputDone as object ??
            ResponseCustomToolCallInputDelta as object ??
            ResponseWebSearchCallCompleted as object ??
            ResponseWebSearchCallSearching as object ??
            ResponseWebSearchCallInProgress as object ??
            ResponseCodeInterpreterCallCodeDone as object ??
            ResponseCodeInterpreterCallCodeDelta as object ??
            ResponseCodeInterpreterCallCompleted as object ??
            ResponseCodeInterpreterCallInterpreting as object ??
            ResponseCodeInterpreterCallInProgress as object ??
            ResponseImageGenerationCallCompleted as object ??
            ResponseImageGenerationCallPartialImage as object ??
            ResponseImageGenerationCallGenerating as object ??
            ResponseImageGenerationCallInProgress as object ??
            ResponseReasoningSummaryTextDone as object ??
            ResponseReasoningSummaryTextDelta as object ??
            ResponseReasoningSummaryPartDone as object ??
            ResponseReasoningSummaryPartAdded as object ??
            ResponseReasoningTextDone as object ??
            ResponseFusionCallPanelReasoningDelta1 as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseFunctionCallArgumentsDelta as object ??
            ResponseOutputTextAnnotationAdded as object ??
            ResponseRefusalDone as object ??
            ResponseRefusalDelta as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseContentPartDone as object ??
            ResponseContentPartAdded as object ??
            ResponseOutputItemDone as object ??
            ResponseOutputItemAdded as object ??
            Error as object ??
            ResponseFailed as object ??
            ResponseIncomplete as object ??
            ResponseCompleted as object ??
            ResponseInProgress as object ??
            ResponseCreated as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseCreated?.ToString() ??
            ResponseInProgress?.ToString() ??
            ResponseCompleted?.ToString() ??
            ResponseIncomplete?.ToString() ??
            ResponseFailed?.ToString() ??
            Error?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            ResponseRefusalDelta?.ToString() ??
            ResponseRefusalDone?.ToString() ??
            ResponseOutputTextAnnotationAdded?.ToString() ??
            ResponseFunctionCallArgumentsDelta?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            ResponseFusionCallPanelReasoningDelta1?.ToString() ??
            ResponseReasoningTextDone?.ToString() ??
            ResponseReasoningSummaryPartAdded?.ToString() ??
            ResponseReasoningSummaryPartDone?.ToString() ??
            ResponseReasoningSummaryTextDelta?.ToString() ??
            ResponseReasoningSummaryTextDone?.ToString() ??
            ResponseImageGenerationCallInProgress?.ToString() ??
            ResponseImageGenerationCallGenerating?.ToString() ??
            ResponseImageGenerationCallPartialImage?.ToString() ??
            ResponseImageGenerationCallCompleted?.ToString() ??
            ResponseCodeInterpreterCallInProgress?.ToString() ??
            ResponseCodeInterpreterCallInterpreting?.ToString() ??
            ResponseCodeInterpreterCallCompleted?.ToString() ??
            ResponseCodeInterpreterCallCodeDelta?.ToString() ??
            ResponseCodeInterpreterCallCodeDone?.ToString() ??
            ResponseWebSearchCallInProgress?.ToString() ??
            ResponseWebSearchCallSearching?.ToString() ??
            ResponseWebSearchCallCompleted?.ToString() ??
            ResponseCustomToolCallInputDelta?.ToString() ??
            ResponseCustomToolCallInputDone?.ToString() ??
            ResponseApplyPatchCallOperationDiffDelta?.ToString() ??
            ResponseApplyPatchCallOperationDiffDone?.ToString() ??
            ResponseFusionCallInProgress?.ToString() ??
            ResponseFusionCallPanelAdded?.ToString() ??
            ResponseFusionCallPanelDelta?.ToString() ??
            ResponseFusionCallPanelReasoningDelta2?.ToString() ??
            ResponseFusionCallPanelCompleted?.ToString() ??
            ResponseFusionCallPanelFailed?.ToString() ??
            ResponseFusionCallAnalysisInProgress?.ToString() ??
            ResponseFusionCallAnalysisCompleted?.ToString() ??
            ResponseFusionCallCompleted?.ToString() ??
            ResponseDebug?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && IsResponseFusionCallCompleted && !IsResponseDebug || !IsResponseCreated && !IsResponseInProgress && !IsResponseCompleted && !IsResponseIncomplete && !IsResponseFailed && !IsError && !IsResponseOutputItemAdded && !IsResponseOutputItemDone && !IsResponseContentPartAdded && !IsResponseContentPartDone && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseRefusalDelta && !IsResponseRefusalDone && !IsResponseOutputTextAnnotationAdded && !IsResponseFunctionCallArgumentsDelta && !IsResponseFunctionCallArgumentsDone && !IsResponseFusionCallPanelReasoningDelta1 && !IsResponseReasoningTextDone && !IsResponseReasoningSummaryPartAdded && !IsResponseReasoningSummaryPartDone && !IsResponseReasoningSummaryTextDelta && !IsResponseReasoningSummaryTextDone && !IsResponseImageGenerationCallInProgress && !IsResponseImageGenerationCallGenerating && !IsResponseImageGenerationCallPartialImage && !IsResponseImageGenerationCallCompleted && !IsResponseCodeInterpreterCallInProgress && !IsResponseCodeInterpreterCallInterpreting && !IsResponseCodeInterpreterCallCompleted && !IsResponseCodeInterpreterCallCodeDelta && !IsResponseCodeInterpreterCallCodeDone && !IsResponseWebSearchCallInProgress && !IsResponseWebSearchCallSearching && !IsResponseWebSearchCallCompleted && !IsResponseCustomToolCallInputDelta && !IsResponseCustomToolCallInputDone && !IsResponseApplyPatchCallOperationDiffDelta && !IsResponseApplyPatchCallOperationDiffDone && !IsResponseFusionCallInProgress && !IsResponseFusionCallPanelAdded && !IsResponseFusionCallPanelDelta && !IsResponseFusionCallPanelReasoningDelta2 && !IsResponseFusionCallPanelCompleted && !IsResponseFusionCallPanelFailed && !IsResponseFusionCallAnalysisInProgress && !IsResponseFusionCallAnalysisCompleted && !IsResponseFusionCallCompleted && IsResponseDebug;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenResponsesCreatedEvent?, TResult>? responseCreated = null,
            global::System.Func<global::OpenRouter.OpenResponsesInProgressEvent?, TResult>? responseInProgress = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseCompleted?, TResult>? responseCompleted = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseIncomplete?, TResult>? responseIncomplete = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseFailed?, TResult>? responseFailed = null,
            global::System.Func<global::OpenRouter.ErrorEvent?, TResult>? error = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseOutputItemAdded?, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseOutputItemDone?, TResult>? responseOutputItemDone = null,
            global::System.Func<global::OpenRouter.ContentPartAddedEvent?, TResult>? responseContentPartAdded = null,
            global::System.Func<global::OpenRouter.ContentPartDoneEvent?, TResult>? responseContentPartDone = null,
            global::System.Func<global::OpenRouter.TextDeltaEvent?, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::OpenRouter.TextDoneEvent?, TResult>? responseOutputTextDone = null,
            global::System.Func<global::OpenRouter.RefusalDeltaEvent?, TResult>? responseRefusalDelta = null,
            global::System.Func<global::OpenRouter.RefusalDoneEvent?, TResult>? responseRefusalDone = null,
            global::System.Func<global::OpenRouter.AnnotationAddedEvent?, TResult>? responseOutputTextAnnotationAdded = null,
            global::System.Func<global::OpenRouter.FunctionCallArgsDeltaEvent?, TResult>? responseFunctionCallArgumentsDelta = null,
            global::System.Func<global::OpenRouter.FunctionCallArgsDoneEvent?, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::OpenRouter.ReasoningDeltaEvent?, TResult>? responseFusionCallPanelReasoningDelta1 = null,
            global::System.Func<global::OpenRouter.ReasoningDoneEvent?, TResult>? responseReasoningTextDone = null,
            global::System.Func<global::OpenRouter.ReasoningSummaryPartAddedEvent?, TResult>? responseReasoningSummaryPartAdded = null,
            global::System.Func<global::OpenRouter.ReasoningSummaryPartDoneEvent?, TResult>? responseReasoningSummaryPartDone = null,
            global::System.Func<global::OpenRouter.ReasoningSummaryTextDeltaEvent?, TResult>? responseReasoningSummaryTextDelta = null,
            global::System.Func<global::OpenRouter.ReasoningSummaryTextDoneEvent?, TResult>? responseReasoningSummaryTextDone = null,
            global::System.Func<global::OpenRouter.ImageGenCallInProgressEvent?, TResult>? responseImageGenerationCallInProgress = null,
            global::System.Func<global::OpenRouter.ImageGenCallGeneratingEvent?, TResult>? responseImageGenerationCallGenerating = null,
            global::System.Func<global::OpenRouter.ImageGenCallPartialImageEvent?, TResult>? responseImageGenerationCallPartialImage = null,
            global::System.Func<global::OpenRouter.ImageGenCallCompletedEvent?, TResult>? responseImageGenerationCallCompleted = null,
            global::System.Func<global::OpenRouter.CodeInterpreterCallInProgressEvent?, TResult>? responseCodeInterpreterCallInProgress = null,
            global::System.Func<global::OpenRouter.CodeInterpreterCallInterpretingEvent?, TResult>? responseCodeInterpreterCallInterpreting = null,
            global::System.Func<global::OpenRouter.CodeInterpreterCallCompletedEvent?, TResult>? responseCodeInterpreterCallCompleted = null,
            global::System.Func<global::OpenRouter.CodeInterpreterCallCodeDeltaEvent?, TResult>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Func<global::OpenRouter.CodeInterpreterCallCodeDoneEvent?, TResult>? responseCodeInterpreterCallCodeDone = null,
            global::System.Func<global::OpenRouter.WebSearchCallInProgressEvent?, TResult>? responseWebSearchCallInProgress = null,
            global::System.Func<global::OpenRouter.WebSearchCallSearchingEvent?, TResult>? responseWebSearchCallSearching = null,
            global::System.Func<global::OpenRouter.WebSearchCallCompletedEvent?, TResult>? responseWebSearchCallCompleted = null,
            global::System.Func<global::OpenRouter.CustomToolCallInputDeltaEvent?, TResult>? responseCustomToolCallInputDelta = null,
            global::System.Func<global::OpenRouter.CustomToolCallInputDoneEvent?, TResult>? responseCustomToolCallInputDone = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent, TResult>? responseApplyPatchCallOperationDiffDelta = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent, TResult>? responseApplyPatchCallOperationDiffDone = null,
            global::System.Func<global::OpenRouter.FusionCallInProgressEvent, TResult>? responseFusionCallInProgress = null,
            global::System.Func<global::OpenRouter.FusionCallPanelAddedEvent, TResult>? responseFusionCallPanelAdded = null,
            global::System.Func<global::OpenRouter.FusionCallPanelDeltaEvent, TResult>? responseFusionCallPanelDelta = null,
            global::System.Func<global::OpenRouter.FusionCallPanelReasoningDeltaEvent, TResult>? responseFusionCallPanelReasoningDelta2 = null,
            global::System.Func<global::OpenRouter.FusionCallPanelCompletedEvent, TResult>? responseFusionCallPanelCompleted = null,
            global::System.Func<global::OpenRouter.FusionCallPanelFailedEvent, TResult>? responseFusionCallPanelFailed = null,
            global::System.Func<global::OpenRouter.FusionCallAnalysisInProgressEvent, TResult>? responseFusionCallAnalysisInProgress = null,
            global::System.Func<global::OpenRouter.FusionCallAnalysisCompletedEvent, TResult>? responseFusionCallAnalysisCompleted = null,
            global::System.Func<global::OpenRouter.FusionCallCompletedEvent, TResult>? responseFusionCallCompleted = null,
            global::System.Func<global::OpenRouter.DebugEvent, TResult>? responseDebug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseCreated is { } __value0 && responseCreated != null)
            {
                return responseCreated(__value0);
            }
            else if (ResponseInProgress is { } __value1 && responseInProgress != null)
            {
                return responseInProgress(__value1);
            }
            else if (ResponseCompleted is { } __value2 && responseCompleted != null)
            {
                return responseCompleted(__value2);
            }
            else if (ResponseIncomplete is { } __value3 && responseIncomplete != null)
            {
                return responseIncomplete(__value3);
            }
            else if (ResponseFailed is { } __value4 && responseFailed != null)
            {
                return responseFailed(__value4);
            }
            else if (Error is { } __value5 && error != null)
            {
                return error(__value5);
            }
            else if (ResponseOutputItemAdded is { } __value6 && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(__value6);
            }
            else if (ResponseOutputItemDone is { } __value7 && responseOutputItemDone != null)
            {
                return responseOutputItemDone(__value7);
            }
            else if (ResponseContentPartAdded is { } __value8 && responseContentPartAdded != null)
            {
                return responseContentPartAdded(__value8);
            }
            else if (ResponseContentPartDone is { } __value9 && responseContentPartDone != null)
            {
                return responseContentPartDone(__value9);
            }
            else if (ResponseOutputTextDelta is { } __value10 && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(__value10);
            }
            else if (ResponseOutputTextDone is { } __value11 && responseOutputTextDone != null)
            {
                return responseOutputTextDone(__value11);
            }
            else if (ResponseRefusalDelta is { } __value12 && responseRefusalDelta != null)
            {
                return responseRefusalDelta(__value12);
            }
            else if (ResponseRefusalDone is { } __value13 && responseRefusalDone != null)
            {
                return responseRefusalDone(__value13);
            }
            else if (ResponseOutputTextAnnotationAdded is { } __value14 && responseOutputTextAnnotationAdded != null)
            {
                return responseOutputTextAnnotationAdded(__value14);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value15 && responseFunctionCallArgumentsDelta != null)
            {
                return responseFunctionCallArgumentsDelta(__value15);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value16 && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(__value16);
            }
            else if (ResponseFusionCallPanelReasoningDelta1 is { } __value17 && responseFusionCallPanelReasoningDelta1 != null)
            {
                return responseFusionCallPanelReasoningDelta1(__value17);
            }
            else if (ResponseReasoningTextDone is { } __value18 && responseReasoningTextDone != null)
            {
                return responseReasoningTextDone(__value18);
            }
            else if (ResponseReasoningSummaryPartAdded is { } __value19 && responseReasoningSummaryPartAdded != null)
            {
                return responseReasoningSummaryPartAdded(__value19);
            }
            else if (ResponseReasoningSummaryPartDone is { } __value20 && responseReasoningSummaryPartDone != null)
            {
                return responseReasoningSummaryPartDone(__value20);
            }
            else if (ResponseReasoningSummaryTextDelta is { } __value21 && responseReasoningSummaryTextDelta != null)
            {
                return responseReasoningSummaryTextDelta(__value21);
            }
            else if (ResponseReasoningSummaryTextDone is { } __value22 && responseReasoningSummaryTextDone != null)
            {
                return responseReasoningSummaryTextDone(__value22);
            }
            else if (ResponseImageGenerationCallInProgress is { } __value23 && responseImageGenerationCallInProgress != null)
            {
                return responseImageGenerationCallInProgress(__value23);
            }
            else if (ResponseImageGenerationCallGenerating is { } __value24 && responseImageGenerationCallGenerating != null)
            {
                return responseImageGenerationCallGenerating(__value24);
            }
            else if (ResponseImageGenerationCallPartialImage is { } __value25 && responseImageGenerationCallPartialImage != null)
            {
                return responseImageGenerationCallPartialImage(__value25);
            }
            else if (ResponseImageGenerationCallCompleted is { } __value26 && responseImageGenerationCallCompleted != null)
            {
                return responseImageGenerationCallCompleted(__value26);
            }
            else if (ResponseCodeInterpreterCallInProgress is { } __value27 && responseCodeInterpreterCallInProgress != null)
            {
                return responseCodeInterpreterCallInProgress(__value27);
            }
            else if (ResponseCodeInterpreterCallInterpreting is { } __value28 && responseCodeInterpreterCallInterpreting != null)
            {
                return responseCodeInterpreterCallInterpreting(__value28);
            }
            else if (ResponseCodeInterpreterCallCompleted is { } __value29 && responseCodeInterpreterCallCompleted != null)
            {
                return responseCodeInterpreterCallCompleted(__value29);
            }
            else if (ResponseCodeInterpreterCallCodeDelta is { } __value30 && responseCodeInterpreterCallCodeDelta != null)
            {
                return responseCodeInterpreterCallCodeDelta(__value30);
            }
            else if (ResponseCodeInterpreterCallCodeDone is { } __value31 && responseCodeInterpreterCallCodeDone != null)
            {
                return responseCodeInterpreterCallCodeDone(__value31);
            }
            else if (ResponseWebSearchCallInProgress is { } __value32 && responseWebSearchCallInProgress != null)
            {
                return responseWebSearchCallInProgress(__value32);
            }
            else if (ResponseWebSearchCallSearching is { } __value33 && responseWebSearchCallSearching != null)
            {
                return responseWebSearchCallSearching(__value33);
            }
            else if (ResponseWebSearchCallCompleted is { } __value34 && responseWebSearchCallCompleted != null)
            {
                return responseWebSearchCallCompleted(__value34);
            }
            else if (ResponseCustomToolCallInputDelta is { } __value35 && responseCustomToolCallInputDelta != null)
            {
                return responseCustomToolCallInputDelta(__value35);
            }
            else if (ResponseCustomToolCallInputDone is { } __value36 && responseCustomToolCallInputDone != null)
            {
                return responseCustomToolCallInputDone(__value36);
            }
            else if (ResponseApplyPatchCallOperationDiffDelta is { } __value37 && responseApplyPatchCallOperationDiffDelta != null)
            {
                return responseApplyPatchCallOperationDiffDelta(__value37);
            }
            else if (ResponseApplyPatchCallOperationDiffDone is { } __value38 && responseApplyPatchCallOperationDiffDone != null)
            {
                return responseApplyPatchCallOperationDiffDone(__value38);
            }
            else if (ResponseFusionCallInProgress is { } __value39 && responseFusionCallInProgress != null)
            {
                return responseFusionCallInProgress(__value39);
            }
            else if (ResponseFusionCallPanelAdded is { } __value40 && responseFusionCallPanelAdded != null)
            {
                return responseFusionCallPanelAdded(__value40);
            }
            else if (ResponseFusionCallPanelDelta is { } __value41 && responseFusionCallPanelDelta != null)
            {
                return responseFusionCallPanelDelta(__value41);
            }
            else if (ResponseFusionCallPanelReasoningDelta2 is { } __value42 && responseFusionCallPanelReasoningDelta2 != null)
            {
                return responseFusionCallPanelReasoningDelta2(__value42);
            }
            else if (ResponseFusionCallPanelCompleted is { } __value43 && responseFusionCallPanelCompleted != null)
            {
                return responseFusionCallPanelCompleted(__value43);
            }
            else if (ResponseFusionCallPanelFailed is { } __value44 && responseFusionCallPanelFailed != null)
            {
                return responseFusionCallPanelFailed(__value44);
            }
            else if (ResponseFusionCallAnalysisInProgress is { } __value45 && responseFusionCallAnalysisInProgress != null)
            {
                return responseFusionCallAnalysisInProgress(__value45);
            }
            else if (ResponseFusionCallAnalysisCompleted is { } __value46 && responseFusionCallAnalysisCompleted != null)
            {
                return responseFusionCallAnalysisCompleted(__value46);
            }
            else if (ResponseFusionCallCompleted is { } __value47 && responseFusionCallCompleted != null)
            {
                return responseFusionCallCompleted(__value47);
            }
            else if (ResponseDebug is { } __value48 && responseDebug != null)
            {
                return responseDebug(__value48);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenResponsesCreatedEvent?>? responseCreated = null,

            global::System.Action<global::OpenRouter.OpenResponsesInProgressEvent?>? responseInProgress = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseCompleted?>? responseCompleted = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseIncomplete?>? responseIncomplete = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseFailed?>? responseFailed = null,

            global::System.Action<global::OpenRouter.ErrorEvent?>? error = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemAdded?>? responseOutputItemAdded = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemDone?>? responseOutputItemDone = null,

            global::System.Action<global::OpenRouter.ContentPartAddedEvent?>? responseContentPartAdded = null,

            global::System.Action<global::OpenRouter.ContentPartDoneEvent?>? responseContentPartDone = null,

            global::System.Action<global::OpenRouter.TextDeltaEvent?>? responseOutputTextDelta = null,

            global::System.Action<global::OpenRouter.TextDoneEvent?>? responseOutputTextDone = null,

            global::System.Action<global::OpenRouter.RefusalDeltaEvent?>? responseRefusalDelta = null,

            global::System.Action<global::OpenRouter.RefusalDoneEvent?>? responseRefusalDone = null,

            global::System.Action<global::OpenRouter.AnnotationAddedEvent?>? responseOutputTextAnnotationAdded = null,

            global::System.Action<global::OpenRouter.FunctionCallArgsDeltaEvent?>? responseFunctionCallArgumentsDelta = null,

            global::System.Action<global::OpenRouter.FunctionCallArgsDoneEvent?>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::OpenRouter.ReasoningDeltaEvent?>? responseFusionCallPanelReasoningDelta1 = null,

            global::System.Action<global::OpenRouter.ReasoningDoneEvent?>? responseReasoningTextDone = null,

            global::System.Action<global::OpenRouter.ReasoningSummaryPartAddedEvent?>? responseReasoningSummaryPartAdded = null,

            global::System.Action<global::OpenRouter.ReasoningSummaryPartDoneEvent?>? responseReasoningSummaryPartDone = null,

            global::System.Action<global::OpenRouter.ReasoningSummaryTextDeltaEvent?>? responseReasoningSummaryTextDelta = null,

            global::System.Action<global::OpenRouter.ReasoningSummaryTextDoneEvent?>? responseReasoningSummaryTextDone = null,

            global::System.Action<global::OpenRouter.ImageGenCallInProgressEvent?>? responseImageGenerationCallInProgress = null,

            global::System.Action<global::OpenRouter.ImageGenCallGeneratingEvent?>? responseImageGenerationCallGenerating = null,

            global::System.Action<global::OpenRouter.ImageGenCallPartialImageEvent?>? responseImageGenerationCallPartialImage = null,

            global::System.Action<global::OpenRouter.ImageGenCallCompletedEvent?>? responseImageGenerationCallCompleted = null,

            global::System.Action<global::OpenRouter.CodeInterpreterCallInProgressEvent?>? responseCodeInterpreterCallInProgress = null,

            global::System.Action<global::OpenRouter.CodeInterpreterCallInterpretingEvent?>? responseCodeInterpreterCallInterpreting = null,

            global::System.Action<global::OpenRouter.CodeInterpreterCallCompletedEvent?>? responseCodeInterpreterCallCompleted = null,

            global::System.Action<global::OpenRouter.CodeInterpreterCallCodeDeltaEvent?>? responseCodeInterpreterCallCodeDelta = null,

            global::System.Action<global::OpenRouter.CodeInterpreterCallCodeDoneEvent?>? responseCodeInterpreterCallCodeDone = null,

            global::System.Action<global::OpenRouter.WebSearchCallInProgressEvent?>? responseWebSearchCallInProgress = null,

            global::System.Action<global::OpenRouter.WebSearchCallSearchingEvent?>? responseWebSearchCallSearching = null,

            global::System.Action<global::OpenRouter.WebSearchCallCompletedEvent?>? responseWebSearchCallCompleted = null,

            global::System.Action<global::OpenRouter.CustomToolCallInputDeltaEvent?>? responseCustomToolCallInputDelta = null,

            global::System.Action<global::OpenRouter.CustomToolCallInputDoneEvent?>? responseCustomToolCallInputDone = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent>? responseApplyPatchCallOperationDiffDelta = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent>? responseApplyPatchCallOperationDiffDone = null,

            global::System.Action<global::OpenRouter.FusionCallInProgressEvent>? responseFusionCallInProgress = null,

            global::System.Action<global::OpenRouter.FusionCallPanelAddedEvent>? responseFusionCallPanelAdded = null,

            global::System.Action<global::OpenRouter.FusionCallPanelDeltaEvent>? responseFusionCallPanelDelta = null,

            global::System.Action<global::OpenRouter.FusionCallPanelReasoningDeltaEvent>? responseFusionCallPanelReasoningDelta2 = null,

            global::System.Action<global::OpenRouter.FusionCallPanelCompletedEvent>? responseFusionCallPanelCompleted = null,

            global::System.Action<global::OpenRouter.FusionCallPanelFailedEvent>? responseFusionCallPanelFailed = null,

            global::System.Action<global::OpenRouter.FusionCallAnalysisInProgressEvent>? responseFusionCallAnalysisInProgress = null,

            global::System.Action<global::OpenRouter.FusionCallAnalysisCompletedEvent>? responseFusionCallAnalysisCompleted = null,

            global::System.Action<global::OpenRouter.FusionCallCompletedEvent>? responseFusionCallCompleted = null,

            global::System.Action<global::OpenRouter.DebugEvent>? responseDebug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseCreated is { } __value0)
            {
                responseCreated?.Invoke(__value0);
            }
            else if (ResponseInProgress is { } __value1)
            {
                responseInProgress?.Invoke(__value1);
            }
            else if (ResponseCompleted is { } __value2)
            {
                responseCompleted?.Invoke(__value2);
            }
            else if (ResponseIncomplete is { } __value3)
            {
                responseIncomplete?.Invoke(__value3);
            }
            else if (ResponseFailed is { } __value4)
            {
                responseFailed?.Invoke(__value4);
            }
            else if (Error is { } __value5)
            {
                error?.Invoke(__value5);
            }
            else if (ResponseOutputItemAdded is { } __value6)
            {
                responseOutputItemAdded?.Invoke(__value6);
            }
            else if (ResponseOutputItemDone is { } __value7)
            {
                responseOutputItemDone?.Invoke(__value7);
            }
            else if (ResponseContentPartAdded is { } __value8)
            {
                responseContentPartAdded?.Invoke(__value8);
            }
            else if (ResponseContentPartDone is { } __value9)
            {
                responseContentPartDone?.Invoke(__value9);
            }
            else if (ResponseOutputTextDelta is { } __value10)
            {
                responseOutputTextDelta?.Invoke(__value10);
            }
            else if (ResponseOutputTextDone is { } __value11)
            {
                responseOutputTextDone?.Invoke(__value11);
            }
            else if (ResponseRefusalDelta is { } __value12)
            {
                responseRefusalDelta?.Invoke(__value12);
            }
            else if (ResponseRefusalDone is { } __value13)
            {
                responseRefusalDone?.Invoke(__value13);
            }
            else if (ResponseOutputTextAnnotationAdded is { } __value14)
            {
                responseOutputTextAnnotationAdded?.Invoke(__value14);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value15)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value15);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value16)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value16);
            }
            else if (ResponseFusionCallPanelReasoningDelta1 is { } __value17)
            {
                responseFusionCallPanelReasoningDelta1?.Invoke(__value17);
            }
            else if (ResponseReasoningTextDone is { } __value18)
            {
                responseReasoningTextDone?.Invoke(__value18);
            }
            else if (ResponseReasoningSummaryPartAdded is { } __value19)
            {
                responseReasoningSummaryPartAdded?.Invoke(__value19);
            }
            else if (ResponseReasoningSummaryPartDone is { } __value20)
            {
                responseReasoningSummaryPartDone?.Invoke(__value20);
            }
            else if (ResponseReasoningSummaryTextDelta is { } __value21)
            {
                responseReasoningSummaryTextDelta?.Invoke(__value21);
            }
            else if (ResponseReasoningSummaryTextDone is { } __value22)
            {
                responseReasoningSummaryTextDone?.Invoke(__value22);
            }
            else if (ResponseImageGenerationCallInProgress is { } __value23)
            {
                responseImageGenerationCallInProgress?.Invoke(__value23);
            }
            else if (ResponseImageGenerationCallGenerating is { } __value24)
            {
                responseImageGenerationCallGenerating?.Invoke(__value24);
            }
            else if (ResponseImageGenerationCallPartialImage is { } __value25)
            {
                responseImageGenerationCallPartialImage?.Invoke(__value25);
            }
            else if (ResponseImageGenerationCallCompleted is { } __value26)
            {
                responseImageGenerationCallCompleted?.Invoke(__value26);
            }
            else if (ResponseCodeInterpreterCallInProgress is { } __value27)
            {
                responseCodeInterpreterCallInProgress?.Invoke(__value27);
            }
            else if (ResponseCodeInterpreterCallInterpreting is { } __value28)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(__value28);
            }
            else if (ResponseCodeInterpreterCallCompleted is { } __value29)
            {
                responseCodeInterpreterCallCompleted?.Invoke(__value29);
            }
            else if (ResponseCodeInterpreterCallCodeDelta is { } __value30)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(__value30);
            }
            else if (ResponseCodeInterpreterCallCodeDone is { } __value31)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(__value31);
            }
            else if (ResponseWebSearchCallInProgress is { } __value32)
            {
                responseWebSearchCallInProgress?.Invoke(__value32);
            }
            else if (ResponseWebSearchCallSearching is { } __value33)
            {
                responseWebSearchCallSearching?.Invoke(__value33);
            }
            else if (ResponseWebSearchCallCompleted is { } __value34)
            {
                responseWebSearchCallCompleted?.Invoke(__value34);
            }
            else if (ResponseCustomToolCallInputDelta is { } __value35)
            {
                responseCustomToolCallInputDelta?.Invoke(__value35);
            }
            else if (ResponseCustomToolCallInputDone is { } __value36)
            {
                responseCustomToolCallInputDone?.Invoke(__value36);
            }
            else if (ResponseApplyPatchCallOperationDiffDelta is { } __value37)
            {
                responseApplyPatchCallOperationDiffDelta?.Invoke(__value37);
            }
            else if (ResponseApplyPatchCallOperationDiffDone is { } __value38)
            {
                responseApplyPatchCallOperationDiffDone?.Invoke(__value38);
            }
            else if (ResponseFusionCallInProgress is { } __value39)
            {
                responseFusionCallInProgress?.Invoke(__value39);
            }
            else if (ResponseFusionCallPanelAdded is { } __value40)
            {
                responseFusionCallPanelAdded?.Invoke(__value40);
            }
            else if (ResponseFusionCallPanelDelta is { } __value41)
            {
                responseFusionCallPanelDelta?.Invoke(__value41);
            }
            else if (ResponseFusionCallPanelReasoningDelta2 is { } __value42)
            {
                responseFusionCallPanelReasoningDelta2?.Invoke(__value42);
            }
            else if (ResponseFusionCallPanelCompleted is { } __value43)
            {
                responseFusionCallPanelCompleted?.Invoke(__value43);
            }
            else if (ResponseFusionCallPanelFailed is { } __value44)
            {
                responseFusionCallPanelFailed?.Invoke(__value44);
            }
            else if (ResponseFusionCallAnalysisInProgress is { } __value45)
            {
                responseFusionCallAnalysisInProgress?.Invoke(__value45);
            }
            else if (ResponseFusionCallAnalysisCompleted is { } __value46)
            {
                responseFusionCallAnalysisCompleted?.Invoke(__value46);
            }
            else if (ResponseFusionCallCompleted is { } __value47)
            {
                responseFusionCallCompleted?.Invoke(__value47);
            }
            else if (ResponseDebug is { } __value48)
            {
                responseDebug?.Invoke(__value48);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenResponsesCreatedEvent?>? responseCreated = null,
            global::System.Action<global::OpenRouter.OpenResponsesInProgressEvent?>? responseInProgress = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseCompleted?>? responseCompleted = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseIncomplete?>? responseIncomplete = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseFailed?>? responseFailed = null,
            global::System.Action<global::OpenRouter.ErrorEvent?>? error = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemAdded?>? responseOutputItemAdded = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemDone?>? responseOutputItemDone = null,
            global::System.Action<global::OpenRouter.ContentPartAddedEvent?>? responseContentPartAdded = null,
            global::System.Action<global::OpenRouter.ContentPartDoneEvent?>? responseContentPartDone = null,
            global::System.Action<global::OpenRouter.TextDeltaEvent?>? responseOutputTextDelta = null,
            global::System.Action<global::OpenRouter.TextDoneEvent?>? responseOutputTextDone = null,
            global::System.Action<global::OpenRouter.RefusalDeltaEvent?>? responseRefusalDelta = null,
            global::System.Action<global::OpenRouter.RefusalDoneEvent?>? responseRefusalDone = null,
            global::System.Action<global::OpenRouter.AnnotationAddedEvent?>? responseOutputTextAnnotationAdded = null,
            global::System.Action<global::OpenRouter.FunctionCallArgsDeltaEvent?>? responseFunctionCallArgumentsDelta = null,
            global::System.Action<global::OpenRouter.FunctionCallArgsDoneEvent?>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::OpenRouter.ReasoningDeltaEvent?>? responseFusionCallPanelReasoningDelta1 = null,
            global::System.Action<global::OpenRouter.ReasoningDoneEvent?>? responseReasoningTextDone = null,
            global::System.Action<global::OpenRouter.ReasoningSummaryPartAddedEvent?>? responseReasoningSummaryPartAdded = null,
            global::System.Action<global::OpenRouter.ReasoningSummaryPartDoneEvent?>? responseReasoningSummaryPartDone = null,
            global::System.Action<global::OpenRouter.ReasoningSummaryTextDeltaEvent?>? responseReasoningSummaryTextDelta = null,
            global::System.Action<global::OpenRouter.ReasoningSummaryTextDoneEvent?>? responseReasoningSummaryTextDone = null,
            global::System.Action<global::OpenRouter.ImageGenCallInProgressEvent?>? responseImageGenerationCallInProgress = null,
            global::System.Action<global::OpenRouter.ImageGenCallGeneratingEvent?>? responseImageGenerationCallGenerating = null,
            global::System.Action<global::OpenRouter.ImageGenCallPartialImageEvent?>? responseImageGenerationCallPartialImage = null,
            global::System.Action<global::OpenRouter.ImageGenCallCompletedEvent?>? responseImageGenerationCallCompleted = null,
            global::System.Action<global::OpenRouter.CodeInterpreterCallInProgressEvent?>? responseCodeInterpreterCallInProgress = null,
            global::System.Action<global::OpenRouter.CodeInterpreterCallInterpretingEvent?>? responseCodeInterpreterCallInterpreting = null,
            global::System.Action<global::OpenRouter.CodeInterpreterCallCompletedEvent?>? responseCodeInterpreterCallCompleted = null,
            global::System.Action<global::OpenRouter.CodeInterpreterCallCodeDeltaEvent?>? responseCodeInterpreterCallCodeDelta = null,
            global::System.Action<global::OpenRouter.CodeInterpreterCallCodeDoneEvent?>? responseCodeInterpreterCallCodeDone = null,
            global::System.Action<global::OpenRouter.WebSearchCallInProgressEvent?>? responseWebSearchCallInProgress = null,
            global::System.Action<global::OpenRouter.WebSearchCallSearchingEvent?>? responseWebSearchCallSearching = null,
            global::System.Action<global::OpenRouter.WebSearchCallCompletedEvent?>? responseWebSearchCallCompleted = null,
            global::System.Action<global::OpenRouter.CustomToolCallInputDeltaEvent?>? responseCustomToolCallInputDelta = null,
            global::System.Action<global::OpenRouter.CustomToolCallInputDoneEvent?>? responseCustomToolCallInputDone = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent>? responseApplyPatchCallOperationDiffDelta = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent>? responseApplyPatchCallOperationDiffDone = null,
            global::System.Action<global::OpenRouter.FusionCallInProgressEvent>? responseFusionCallInProgress = null,
            global::System.Action<global::OpenRouter.FusionCallPanelAddedEvent>? responseFusionCallPanelAdded = null,
            global::System.Action<global::OpenRouter.FusionCallPanelDeltaEvent>? responseFusionCallPanelDelta = null,
            global::System.Action<global::OpenRouter.FusionCallPanelReasoningDeltaEvent>? responseFusionCallPanelReasoningDelta2 = null,
            global::System.Action<global::OpenRouter.FusionCallPanelCompletedEvent>? responseFusionCallPanelCompleted = null,
            global::System.Action<global::OpenRouter.FusionCallPanelFailedEvent>? responseFusionCallPanelFailed = null,
            global::System.Action<global::OpenRouter.FusionCallAnalysisInProgressEvent>? responseFusionCallAnalysisInProgress = null,
            global::System.Action<global::OpenRouter.FusionCallAnalysisCompletedEvent>? responseFusionCallAnalysisCompleted = null,
            global::System.Action<global::OpenRouter.FusionCallCompletedEvent>? responseFusionCallCompleted = null,
            global::System.Action<global::OpenRouter.DebugEvent>? responseDebug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseCreated is { } __value0)
            {
                responseCreated?.Invoke(__value0);
            }
            else if (ResponseInProgress is { } __value1)
            {
                responseInProgress?.Invoke(__value1);
            }
            else if (ResponseCompleted is { } __value2)
            {
                responseCompleted?.Invoke(__value2);
            }
            else if (ResponseIncomplete is { } __value3)
            {
                responseIncomplete?.Invoke(__value3);
            }
            else if (ResponseFailed is { } __value4)
            {
                responseFailed?.Invoke(__value4);
            }
            else if (Error is { } __value5)
            {
                error?.Invoke(__value5);
            }
            else if (ResponseOutputItemAdded is { } __value6)
            {
                responseOutputItemAdded?.Invoke(__value6);
            }
            else if (ResponseOutputItemDone is { } __value7)
            {
                responseOutputItemDone?.Invoke(__value7);
            }
            else if (ResponseContentPartAdded is { } __value8)
            {
                responseContentPartAdded?.Invoke(__value8);
            }
            else if (ResponseContentPartDone is { } __value9)
            {
                responseContentPartDone?.Invoke(__value9);
            }
            else if (ResponseOutputTextDelta is { } __value10)
            {
                responseOutputTextDelta?.Invoke(__value10);
            }
            else if (ResponseOutputTextDone is { } __value11)
            {
                responseOutputTextDone?.Invoke(__value11);
            }
            else if (ResponseRefusalDelta is { } __value12)
            {
                responseRefusalDelta?.Invoke(__value12);
            }
            else if (ResponseRefusalDone is { } __value13)
            {
                responseRefusalDone?.Invoke(__value13);
            }
            else if (ResponseOutputTextAnnotationAdded is { } __value14)
            {
                responseOutputTextAnnotationAdded?.Invoke(__value14);
            }
            else if (ResponseFunctionCallArgumentsDelta is { } __value15)
            {
                responseFunctionCallArgumentsDelta?.Invoke(__value15);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value16)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value16);
            }
            else if (ResponseFusionCallPanelReasoningDelta1 is { } __value17)
            {
                responseFusionCallPanelReasoningDelta1?.Invoke(__value17);
            }
            else if (ResponseReasoningTextDone is { } __value18)
            {
                responseReasoningTextDone?.Invoke(__value18);
            }
            else if (ResponseReasoningSummaryPartAdded is { } __value19)
            {
                responseReasoningSummaryPartAdded?.Invoke(__value19);
            }
            else if (ResponseReasoningSummaryPartDone is { } __value20)
            {
                responseReasoningSummaryPartDone?.Invoke(__value20);
            }
            else if (ResponseReasoningSummaryTextDelta is { } __value21)
            {
                responseReasoningSummaryTextDelta?.Invoke(__value21);
            }
            else if (ResponseReasoningSummaryTextDone is { } __value22)
            {
                responseReasoningSummaryTextDone?.Invoke(__value22);
            }
            else if (ResponseImageGenerationCallInProgress is { } __value23)
            {
                responseImageGenerationCallInProgress?.Invoke(__value23);
            }
            else if (ResponseImageGenerationCallGenerating is { } __value24)
            {
                responseImageGenerationCallGenerating?.Invoke(__value24);
            }
            else if (ResponseImageGenerationCallPartialImage is { } __value25)
            {
                responseImageGenerationCallPartialImage?.Invoke(__value25);
            }
            else if (ResponseImageGenerationCallCompleted is { } __value26)
            {
                responseImageGenerationCallCompleted?.Invoke(__value26);
            }
            else if (ResponseCodeInterpreterCallInProgress is { } __value27)
            {
                responseCodeInterpreterCallInProgress?.Invoke(__value27);
            }
            else if (ResponseCodeInterpreterCallInterpreting is { } __value28)
            {
                responseCodeInterpreterCallInterpreting?.Invoke(__value28);
            }
            else if (ResponseCodeInterpreterCallCompleted is { } __value29)
            {
                responseCodeInterpreterCallCompleted?.Invoke(__value29);
            }
            else if (ResponseCodeInterpreterCallCodeDelta is { } __value30)
            {
                responseCodeInterpreterCallCodeDelta?.Invoke(__value30);
            }
            else if (ResponseCodeInterpreterCallCodeDone is { } __value31)
            {
                responseCodeInterpreterCallCodeDone?.Invoke(__value31);
            }
            else if (ResponseWebSearchCallInProgress is { } __value32)
            {
                responseWebSearchCallInProgress?.Invoke(__value32);
            }
            else if (ResponseWebSearchCallSearching is { } __value33)
            {
                responseWebSearchCallSearching?.Invoke(__value33);
            }
            else if (ResponseWebSearchCallCompleted is { } __value34)
            {
                responseWebSearchCallCompleted?.Invoke(__value34);
            }
            else if (ResponseCustomToolCallInputDelta is { } __value35)
            {
                responseCustomToolCallInputDelta?.Invoke(__value35);
            }
            else if (ResponseCustomToolCallInputDone is { } __value36)
            {
                responseCustomToolCallInputDone?.Invoke(__value36);
            }
            else if (ResponseApplyPatchCallOperationDiffDelta is { } __value37)
            {
                responseApplyPatchCallOperationDiffDelta?.Invoke(__value37);
            }
            else if (ResponseApplyPatchCallOperationDiffDone is { } __value38)
            {
                responseApplyPatchCallOperationDiffDone?.Invoke(__value38);
            }
            else if (ResponseFusionCallInProgress is { } __value39)
            {
                responseFusionCallInProgress?.Invoke(__value39);
            }
            else if (ResponseFusionCallPanelAdded is { } __value40)
            {
                responseFusionCallPanelAdded?.Invoke(__value40);
            }
            else if (ResponseFusionCallPanelDelta is { } __value41)
            {
                responseFusionCallPanelDelta?.Invoke(__value41);
            }
            else if (ResponseFusionCallPanelReasoningDelta2 is { } __value42)
            {
                responseFusionCallPanelReasoningDelta2?.Invoke(__value42);
            }
            else if (ResponseFusionCallPanelCompleted is { } __value43)
            {
                responseFusionCallPanelCompleted?.Invoke(__value43);
            }
            else if (ResponseFusionCallPanelFailed is { } __value44)
            {
                responseFusionCallPanelFailed?.Invoke(__value44);
            }
            else if (ResponseFusionCallAnalysisInProgress is { } __value45)
            {
                responseFusionCallAnalysisInProgress?.Invoke(__value45);
            }
            else if (ResponseFusionCallAnalysisCompleted is { } __value46)
            {
                responseFusionCallAnalysisCompleted?.Invoke(__value46);
            }
            else if (ResponseFusionCallCompleted is { } __value47)
            {
                responseFusionCallCompleted?.Invoke(__value47);
            }
            else if (ResponseDebug is { } __value48)
            {
                responseDebug?.Invoke(__value48);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseCreated,
                typeof(global::OpenRouter.OpenResponsesCreatedEvent),
                ResponseInProgress,
                typeof(global::OpenRouter.OpenResponsesInProgressEvent),
                ResponseCompleted,
                typeof(global::OpenRouter.StreamEventsResponseCompleted),
                ResponseIncomplete,
                typeof(global::OpenRouter.StreamEventsResponseIncomplete),
                ResponseFailed,
                typeof(global::OpenRouter.StreamEventsResponseFailed),
                Error,
                typeof(global::OpenRouter.ErrorEvent),
                ResponseOutputItemAdded,
                typeof(global::OpenRouter.StreamEventsResponseOutputItemAdded),
                ResponseOutputItemDone,
                typeof(global::OpenRouter.StreamEventsResponseOutputItemDone),
                ResponseContentPartAdded,
                typeof(global::OpenRouter.ContentPartAddedEvent),
                ResponseContentPartDone,
                typeof(global::OpenRouter.ContentPartDoneEvent),
                ResponseOutputTextDelta,
                typeof(global::OpenRouter.TextDeltaEvent),
                ResponseOutputTextDone,
                typeof(global::OpenRouter.TextDoneEvent),
                ResponseRefusalDelta,
                typeof(global::OpenRouter.RefusalDeltaEvent),
                ResponseRefusalDone,
                typeof(global::OpenRouter.RefusalDoneEvent),
                ResponseOutputTextAnnotationAdded,
                typeof(global::OpenRouter.AnnotationAddedEvent),
                ResponseFunctionCallArgumentsDelta,
                typeof(global::OpenRouter.FunctionCallArgsDeltaEvent),
                ResponseFunctionCallArgumentsDone,
                typeof(global::OpenRouter.FunctionCallArgsDoneEvent),
                ResponseFusionCallPanelReasoningDelta1,
                typeof(global::OpenRouter.ReasoningDeltaEvent),
                ResponseReasoningTextDone,
                typeof(global::OpenRouter.ReasoningDoneEvent),
                ResponseReasoningSummaryPartAdded,
                typeof(global::OpenRouter.ReasoningSummaryPartAddedEvent),
                ResponseReasoningSummaryPartDone,
                typeof(global::OpenRouter.ReasoningSummaryPartDoneEvent),
                ResponseReasoningSummaryTextDelta,
                typeof(global::OpenRouter.ReasoningSummaryTextDeltaEvent),
                ResponseReasoningSummaryTextDone,
                typeof(global::OpenRouter.ReasoningSummaryTextDoneEvent),
                ResponseImageGenerationCallInProgress,
                typeof(global::OpenRouter.ImageGenCallInProgressEvent),
                ResponseImageGenerationCallGenerating,
                typeof(global::OpenRouter.ImageGenCallGeneratingEvent),
                ResponseImageGenerationCallPartialImage,
                typeof(global::OpenRouter.ImageGenCallPartialImageEvent),
                ResponseImageGenerationCallCompleted,
                typeof(global::OpenRouter.ImageGenCallCompletedEvent),
                ResponseCodeInterpreterCallInProgress,
                typeof(global::OpenRouter.CodeInterpreterCallInProgressEvent),
                ResponseCodeInterpreterCallInterpreting,
                typeof(global::OpenRouter.CodeInterpreterCallInterpretingEvent),
                ResponseCodeInterpreterCallCompleted,
                typeof(global::OpenRouter.CodeInterpreterCallCompletedEvent),
                ResponseCodeInterpreterCallCodeDelta,
                typeof(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent),
                ResponseCodeInterpreterCallCodeDone,
                typeof(global::OpenRouter.CodeInterpreterCallCodeDoneEvent),
                ResponseWebSearchCallInProgress,
                typeof(global::OpenRouter.WebSearchCallInProgressEvent),
                ResponseWebSearchCallSearching,
                typeof(global::OpenRouter.WebSearchCallSearchingEvent),
                ResponseWebSearchCallCompleted,
                typeof(global::OpenRouter.WebSearchCallCompletedEvent),
                ResponseCustomToolCallInputDelta,
                typeof(global::OpenRouter.CustomToolCallInputDeltaEvent),
                ResponseCustomToolCallInputDone,
                typeof(global::OpenRouter.CustomToolCallInputDoneEvent),
                ResponseApplyPatchCallOperationDiffDelta,
                typeof(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent),
                ResponseApplyPatchCallOperationDiffDone,
                typeof(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent),
                ResponseFusionCallInProgress,
                typeof(global::OpenRouter.FusionCallInProgressEvent),
                ResponseFusionCallPanelAdded,
                typeof(global::OpenRouter.FusionCallPanelAddedEvent),
                ResponseFusionCallPanelDelta,
                typeof(global::OpenRouter.FusionCallPanelDeltaEvent),
                ResponseFusionCallPanelReasoningDelta2,
                typeof(global::OpenRouter.FusionCallPanelReasoningDeltaEvent),
                ResponseFusionCallPanelCompleted,
                typeof(global::OpenRouter.FusionCallPanelCompletedEvent),
                ResponseFusionCallPanelFailed,
                typeof(global::OpenRouter.FusionCallPanelFailedEvent),
                ResponseFusionCallAnalysisInProgress,
                typeof(global::OpenRouter.FusionCallAnalysisInProgressEvent),
                ResponseFusionCallAnalysisCompleted,
                typeof(global::OpenRouter.FusionCallAnalysisCompletedEvent),
                ResponseFusionCallCompleted,
                typeof(global::OpenRouter.FusionCallCompletedEvent),
                ResponseDebug,
                typeof(global::OpenRouter.DebugEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(StreamEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesCreatedEvent?>.Default.Equals(ResponseCreated, other.ResponseCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesInProgressEvent?>.Default.Equals(ResponseInProgress, other.ResponseInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseCompleted?>.Default.Equals(ResponseCompleted, other.ResponseCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseIncomplete?>.Default.Equals(ResponseIncomplete, other.ResponseIncomplete) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseFailed?>.Default.Equals(ResponseFailed, other.ResponseFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseOutputItemAdded?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseOutputItemDone?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartAddedEvent?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartDoneEvent?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.TextDeltaEvent?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.TextDoneEvent?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RefusalDeltaEvent?>.Default.Equals(ResponseRefusalDelta, other.ResponseRefusalDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RefusalDoneEvent?>.Default.Equals(ResponseRefusalDone, other.ResponseRefusalDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnnotationAddedEvent?>.Default.Equals(ResponseOutputTextAnnotationAdded, other.ResponseOutputTextAnnotationAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallArgsDeltaEvent?>.Default.Equals(ResponseFunctionCallArgumentsDelta, other.ResponseFunctionCallArgumentsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallArgsDoneEvent?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDeltaEvent?>.Default.Equals(ResponseFusionCallPanelReasoningDelta1, other.ResponseFusionCallPanelReasoningDelta1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningDoneEvent?>.Default.Equals(ResponseReasoningTextDone, other.ResponseReasoningTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningSummaryPartAddedEvent?>.Default.Equals(ResponseReasoningSummaryPartAdded, other.ResponseReasoningSummaryPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningSummaryPartDoneEvent?>.Default.Equals(ResponseReasoningSummaryPartDone, other.ResponseReasoningSummaryPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningSummaryTextDeltaEvent?>.Default.Equals(ResponseReasoningSummaryTextDelta, other.ResponseReasoningSummaryTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningSummaryTextDoneEvent?>.Default.Equals(ResponseReasoningSummaryTextDone, other.ResponseReasoningSummaryTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenCallInProgressEvent?>.Default.Equals(ResponseImageGenerationCallInProgress, other.ResponseImageGenerationCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenCallGeneratingEvent?>.Default.Equals(ResponseImageGenerationCallGenerating, other.ResponseImageGenerationCallGenerating) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenCallPartialImageEvent?>.Default.Equals(ResponseImageGenerationCallPartialImage, other.ResponseImageGenerationCallPartialImage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenCallCompletedEvent?>.Default.Equals(ResponseImageGenerationCallCompleted, other.ResponseImageGenerationCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallInProgressEvent?>.Default.Equals(ResponseCodeInterpreterCallInProgress, other.ResponseCodeInterpreterCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallInterpretingEvent?>.Default.Equals(ResponseCodeInterpreterCallInterpreting, other.ResponseCodeInterpreterCallInterpreting) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallCompletedEvent?>.Default.Equals(ResponseCodeInterpreterCallCompleted, other.ResponseCodeInterpreterCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallCodeDeltaEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDelta, other.ResponseCodeInterpreterCallCodeDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallCodeDoneEvent?>.Default.Equals(ResponseCodeInterpreterCallCodeDone, other.ResponseCodeInterpreterCallCodeDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchCallInProgressEvent?>.Default.Equals(ResponseWebSearchCallInProgress, other.ResponseWebSearchCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchCallSearchingEvent?>.Default.Equals(ResponseWebSearchCallSearching, other.ResponseWebSearchCallSearching) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchCallCompletedEvent?>.Default.Equals(ResponseWebSearchCallCompleted, other.ResponseWebSearchCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallInputDeltaEvent?>.Default.Equals(ResponseCustomToolCallInputDelta, other.ResponseCustomToolCallInputDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallInputDoneEvent?>.Default.Equals(ResponseCustomToolCallInputDone, other.ResponseCustomToolCallInputDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent?>.Default.Equals(ResponseApplyPatchCallOperationDiffDelta, other.ResponseApplyPatchCallOperationDiffDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent?>.Default.Equals(ResponseApplyPatchCallOperationDiffDone, other.ResponseApplyPatchCallOperationDiffDone) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallInProgressEvent?>.Default.Equals(ResponseFusionCallInProgress, other.ResponseFusionCallInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallPanelAddedEvent?>.Default.Equals(ResponseFusionCallPanelAdded, other.ResponseFusionCallPanelAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallPanelDeltaEvent?>.Default.Equals(ResponseFusionCallPanelDelta, other.ResponseFusionCallPanelDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallPanelReasoningDeltaEvent?>.Default.Equals(ResponseFusionCallPanelReasoningDelta2, other.ResponseFusionCallPanelReasoningDelta2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallPanelCompletedEvent?>.Default.Equals(ResponseFusionCallPanelCompleted, other.ResponseFusionCallPanelCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallPanelFailedEvent?>.Default.Equals(ResponseFusionCallPanelFailed, other.ResponseFusionCallPanelFailed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallAnalysisInProgressEvent?>.Default.Equals(ResponseFusionCallAnalysisInProgress, other.ResponseFusionCallAnalysisInProgress) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallAnalysisCompletedEvent?>.Default.Equals(ResponseFusionCallAnalysisCompleted, other.ResponseFusionCallAnalysisCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionCallCompletedEvent?>.Default.Equals(ResponseFusionCallCompleted, other.ResponseFusionCallCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DebugEvent?>.Default.Equals(ResponseDebug, other.ResponseDebug)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamEvents obj1, StreamEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamEvents obj1, StreamEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamEvents o && Equals(o);
        }
    }
}
