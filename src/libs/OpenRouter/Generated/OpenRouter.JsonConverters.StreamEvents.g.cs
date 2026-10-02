#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class StreamEventsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.StreamEvents>
    {
        /// <inheritdoc />
        public override global::OpenRouter.StreamEvents Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StreamEventsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.OpenResponsesCreatedEvent? responseCreated = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenResponsesCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenResponsesCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OpenResponsesCreatedEvent)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OpenResponsesInProgressEvent? responseInProgress = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenResponsesInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenResponsesInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OpenResponsesInProgressEvent)}");
                responseInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StreamEventsResponseCompleted? responseCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StreamEventsResponseCompleted)}");
                responseCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StreamEventsResponseIncomplete? responseIncomplete = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseIncomplete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseIncomplete> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StreamEventsResponseIncomplete)}");
                responseIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StreamEventsResponseFailed? responseFailed = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StreamEventsResponseFailed)}");
                responseFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ErrorEvent? error = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StreamEventsResponseOutputItemAdded? responseOutputItemAdded = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StreamEventsResponseOutputItemAdded)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StreamEventsResponseOutputItemDone? responseOutputItemDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StreamEventsResponseOutputItemDone)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ContentPartAddedEvent? responseContentPartAdded = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContentPartAddedEvent)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ContentPartDoneEvent? responseContentPartDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContentPartDoneEvent)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.TextDeltaEvent? responseOutputTextDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.TextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.TextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.TextDeltaEvent)}");
                responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.TextDoneEvent? responseOutputTextDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.TextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.TextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.TextDoneEvent)}");
                responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.RefusalDeltaEvent? responseRefusalDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.RefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.RefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.RefusalDeltaEvent)}");
                responseRefusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.RefusalDoneEvent? responseRefusalDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.RefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.RefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.RefusalDoneEvent)}");
                responseRefusalDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnnotationAddedEvent? responseOutputTextAnnotationAdded = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnnotationAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnnotationAddedEvent)}");
                responseOutputTextAnnotationAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FunctionCallArgsDeltaEvent? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallArgsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallArgsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FunctionCallArgsDeltaEvent)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FunctionCallArgsDoneEvent? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallArgsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallArgsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FunctionCallArgsDoneEvent)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningDeltaEvent? responseFusionCallPanelReasoningDelta1 = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallPanelReasoningDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDeltaEvent)}");
                responseFusionCallPanelReasoningDelta1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningDoneEvent? responseReasoningTextDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseReasoningTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDoneEvent)}");
                responseReasoningTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningSummaryPartAddedEvent? responseReasoningSummaryPartAdded = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningSummaryPartAddedEvent)}");
                responseReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningSummaryPartDoneEvent? responseReasoningSummaryPartDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningSummaryPartDoneEvent)}");
                responseReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningSummaryTextDeltaEvent? responseReasoningSummaryTextDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningSummaryTextDeltaEvent)}");
                responseReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningSummaryTextDoneEvent? responseReasoningSummaryTextDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningSummaryTextDoneEvent)}");
                responseReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ImageGenCallInProgressEvent? responseImageGenerationCallInProgress = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseImageGenerationCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ImageGenCallInProgressEvent)}");
                responseImageGenerationCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ImageGenCallGeneratingEvent? responseImageGenerationCallGenerating = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseImageGenerationCallGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallGeneratingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ImageGenCallGeneratingEvent)}");
                responseImageGenerationCallGenerating = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ImageGenCallPartialImageEvent? responseImageGenerationCallPartialImage = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseImageGenerationCallPartialImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallPartialImageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ImageGenCallPartialImageEvent)}");
                responseImageGenerationCallPartialImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ImageGenCallCompletedEvent? responseImageGenerationCallCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseImageGenerationCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ImageGenCallCompletedEvent)}");
                responseImageGenerationCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterCallInProgressEvent? responseCodeInterpreterCallInProgress = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterCallInProgressEvent)}");
                responseCodeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterCallInterpretingEvent? responseCodeInterpreterCallInterpreting = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterCallInterpretingEvent)}");
                responseCodeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterCallCompletedEvent? responseCodeInterpreterCallCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterCallCompletedEvent)}");
                responseCodeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterCallCodeDeltaEvent? responseCodeInterpreterCallCodeDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent)}");
                responseCodeInterpreterCallCodeDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterCallCodeDoneEvent? responseCodeInterpreterCallCodeDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterCallCodeDoneEvent)}");
                responseCodeInterpreterCallCodeDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.WebSearchCallInProgressEvent? responseWebSearchCallInProgress = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.WebSearchCallInProgressEvent)}");
                responseWebSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.WebSearchCallSearchingEvent? responseWebSearchCallSearching = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.WebSearchCallSearchingEvent)}");
                responseWebSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.WebSearchCallCompletedEvent? responseWebSearchCallCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.WebSearchCallCompletedEvent)}");
                responseWebSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CustomToolCallInputDeltaEvent? responseCustomToolCallInputDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCustomToolCallInputDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallInputDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallInputDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CustomToolCallInputDeltaEvent)}");
                responseCustomToolCallInputDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CustomToolCallInputDoneEvent? responseCustomToolCallInputDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseCustomToolCallInputDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallInputDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallInputDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CustomToolCallInputDoneEvent)}");
                responseCustomToolCallInputDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent? responseApplyPatchCallOperationDiffDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseApplyPatchCallOperationDiffDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent)}");
                responseApplyPatchCallOperationDiffDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent? responseApplyPatchCallOperationDiffDone = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseApplyPatchCallOperationDiffDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent)}");
                responseApplyPatchCallOperationDiffDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallInProgressEvent? responseFusionCallInProgress = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallInProgressEvent)}");
                responseFusionCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallPanelAddedEvent? responseFusionCallPanelAdded = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallPanelAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallPanelAddedEvent)}");
                responseFusionCallPanelAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallPanelDeltaEvent? responseFusionCallPanelDelta = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallPanelDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallPanelDeltaEvent)}");
                responseFusionCallPanelDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallPanelReasoningDeltaEvent? responseFusionCallPanelReasoningDelta2 = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallPanelReasoningDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelReasoningDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallPanelReasoningDeltaEvent)}");
                responseFusionCallPanelReasoningDelta2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallPanelCompletedEvent? responseFusionCallPanelCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallPanelCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallPanelCompletedEvent)}");
                responseFusionCallPanelCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallPanelFailedEvent? responseFusionCallPanelFailed = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallPanelFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallPanelFailedEvent)}");
                responseFusionCallPanelFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallAnalysisInProgressEvent? responseFusionCallAnalysisInProgress = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallAnalysisInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallAnalysisInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallAnalysisInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallAnalysisInProgressEvent)}");
                responseFusionCallAnalysisInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallAnalysisCompletedEvent? responseFusionCallAnalysisCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallAnalysisCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallAnalysisCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallAnalysisCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallAnalysisCompletedEvent)}");
                responseFusionCallAnalysisCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionCallCompletedEvent? responseFusionCallCompleted = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseFusionCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionCallCompletedEvent)}");
                responseFusionCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DebugEvent? responseDebug = default;
            if (discriminator?.Type == global::OpenRouter.StreamEventsDiscriminatorType.ResponseDebug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DebugEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DebugEvent)}");
                responseDebug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.StreamEvents(
                discriminator?.Type,
                responseCreated,

                responseInProgress,

                responseCompleted,

                responseIncomplete,

                responseFailed,

                error,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                responseRefusalDelta,

                responseRefusalDone,

                responseOutputTextAnnotationAdded,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseFusionCallPanelReasoningDelta1,

                responseReasoningTextDone,

                responseReasoningSummaryPartAdded,

                responseReasoningSummaryPartDone,

                responseReasoningSummaryTextDelta,

                responseReasoningSummaryTextDone,

                responseImageGenerationCallInProgress,

                responseImageGenerationCallGenerating,

                responseImageGenerationCallPartialImage,

                responseImageGenerationCallCompleted,

                responseCodeInterpreterCallInProgress,

                responseCodeInterpreterCallInterpreting,

                responseCodeInterpreterCallCompleted,

                responseCodeInterpreterCallCodeDelta,

                responseCodeInterpreterCallCodeDone,

                responseWebSearchCallInProgress,

                responseWebSearchCallSearching,

                responseWebSearchCallCompleted,

                responseCustomToolCallInputDelta,

                responseCustomToolCallInputDone,

                responseApplyPatchCallOperationDiffDelta,

                responseApplyPatchCallOperationDiffDone,

                responseFusionCallInProgress,

                responseFusionCallPanelAdded,

                responseFusionCallPanelDelta,

                responseFusionCallPanelReasoningDelta2,

                responseFusionCallPanelCompleted,

                responseFusionCallPanelFailed,

                responseFusionCallAnalysisInProgress,

                responseFusionCallAnalysisCompleted,

                responseFusionCallCompleted,

                responseDebug
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.StreamEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenResponsesCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenResponsesCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenResponsesCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCreated(), typeInfo);
            }
            else if (value.IsResponseInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenResponsesInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenResponsesInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenResponsesInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseInProgress(), typeInfo);
            }
            else if (value.IsResponseCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StreamEventsResponseCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCompleted(), typeInfo);
            }
            else if (value.IsResponseIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseIncomplete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseIncomplete> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StreamEventsResponseIncomplete).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseIncomplete(), typeInfo);
            }
            else if (value.IsResponseFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StreamEventsResponseFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFailed(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StreamEventsResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemAdded(), typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StreamEventsResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StreamEventsResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StreamEventsResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputItemDone(), typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseContentPartAdded(), typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseContentPartDone(), typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.TextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.TextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.TextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputTextDelta(), typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.TextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.TextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.TextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputTextDone(), typeInfo);
            }
            else if (value.IsResponseRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.RefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.RefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.RefusalDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseRefusalDelta(), typeInfo);
            }
            else if (value.IsResponseRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.RefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.RefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.RefusalDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseRefusalDone(), typeInfo);
            }
            else if (value.IsResponseOutputTextAnnotationAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnnotationAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnnotationAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnnotationAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseOutputTextAnnotationAdded(), typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallArgsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallArgsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallArgsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFunctionCallArgumentsDelta(), typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallArgsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallArgsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallArgsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFunctionCallArgumentsDone(), typeInfo);
            }
            else if (value.IsResponseFusionCallPanelReasoningDelta1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallPanelReasoningDelta1(), typeInfo);
            }
            else if (value.IsResponseReasoningTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseReasoningTextDone(), typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningSummaryPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseReasoningSummaryPartAdded(), typeInfo);
            }
            else if (value.IsResponseReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningSummaryPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseReasoningSummaryPartDone(), typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningSummaryTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseReasoningSummaryTextDelta(), typeInfo);
            }
            else if (value.IsResponseReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningSummaryTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseReasoningSummaryTextDone(), typeInfo);
            }
            else if (value.IsResponseImageGenerationCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseImageGenerationCallInProgress(), typeInfo);
            }
            else if (value.IsResponseImageGenerationCallGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallGeneratingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallGeneratingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenCallGeneratingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseImageGenerationCallGenerating(), typeInfo);
            }
            else if (value.IsResponseImageGenerationCallPartialImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallPartialImageEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallPartialImageEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenCallPartialImageEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseImageGenerationCallPartialImage(), typeInfo);
            }
            else if (value.IsResponseImageGenerationCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseImageGenerationCallCompleted(), typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCodeInterpreterCallInProgress(), typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterCallInterpretingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCodeInterpreterCallInterpreting(), typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCodeInterpreterCallCompleted(), typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterCallCodeDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCodeInterpreterCallCodeDelta(), typeInfo);
            }
            else if (value.IsResponseCodeInterpreterCallCodeDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterCallCodeDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCodeInterpreterCallCodeDone(), typeInfo);
            }
            else if (value.IsResponseWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseWebSearchCallInProgress(), typeInfo);
            }
            else if (value.IsResponseWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseWebSearchCallSearching(), typeInfo);
            }
            else if (value.IsResponseWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseWebSearchCallCompleted(), typeInfo);
            }
            else if (value.IsResponseCustomToolCallInputDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallInputDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallInputDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallInputDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCustomToolCallInputDelta(), typeInfo);
            }
            else if (value.IsResponseCustomToolCallInputDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallInputDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallInputDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallInputDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseCustomToolCallInputDone(), typeInfo);
            }
            else if (value.IsResponseApplyPatchCallOperationDiffDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOperationDiffDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseApplyPatchCallOperationDiffDelta(), typeInfo);
            }
            else if (value.IsResponseApplyPatchCallOperationDiffDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOperationDiffDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseApplyPatchCallOperationDiffDone(), typeInfo);
            }
            else if (value.IsResponseFusionCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallInProgress(), typeInfo);
            }
            else if (value.IsResponseFusionCallPanelAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallPanelAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallPanelAdded(), typeInfo);
            }
            else if (value.IsResponseFusionCallPanelDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallPanelDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallPanelDelta(), typeInfo);
            }
            else if (value.IsResponseFusionCallPanelReasoningDelta2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelReasoningDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelReasoningDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallPanelReasoningDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallPanelReasoningDelta2(), typeInfo);
            }
            else if (value.IsResponseFusionCallPanelCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallPanelCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallPanelCompleted(), typeInfo);
            }
            else if (value.IsResponseFusionCallPanelFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallPanelFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallPanelFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallPanelFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallPanelFailed(), typeInfo);
            }
            else if (value.IsResponseFusionCallAnalysisInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallAnalysisInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallAnalysisInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallAnalysisInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallAnalysisInProgress(), typeInfo);
            }
            else if (value.IsResponseFusionCallAnalysisCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallAnalysisCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallAnalysisCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallAnalysisCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallAnalysisCompleted(), typeInfo);
            }
            else if (value.IsResponseFusionCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseFusionCallCompleted(), typeInfo);
            }
            else if (value.IsResponseDebug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DebugEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DebugEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DebugEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseDebug(), typeInfo);
            }
        }
    }
}