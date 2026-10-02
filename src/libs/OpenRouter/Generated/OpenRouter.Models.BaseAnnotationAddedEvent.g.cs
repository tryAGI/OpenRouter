
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a text annotation is added to output<br/>
    /// Example: {"annotation":{"end_index":7,"start_index":0,"title":"Example","type":"url_citation","url":"https://example.com"},"annotation_index":0,"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":5,"type":"response.output_text.annotation.added"}
    /// </summary>
    public sealed partial class BaseAnnotationAddedEvent
    {
        /// <summary>
        /// Example: {"file_id":"file-abc123","filename":"research_paper.pdf","index":0,"type":"file_citation"}
        /// </summary>
        /// <example>{"file_id":"file-abc123","filename":"research_paper.pdf","index":0,"type":"file_citation"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesAnnotationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAIResponsesAnnotation Annotation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseAnnotationAddedEventTypeJsonConverter))]
        public global::OpenRouter.BaseAnnotationAddedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAnnotationAddedEvent" /> class.
        /// </summary>
        /// <param name="annotation">
        /// Example: {"file_id":"file-abc123","filename":"research_paper.pdf","index":0,"type":"file_citation"}
        /// </param>
        /// <param name="annotationIndex"></param>
        /// <param name="contentIndex"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseAnnotationAddedEvent(
            global::OpenRouter.OpenAIResponsesAnnotation annotation,
            int annotationIndex,
            int contentIndex,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.BaseAnnotationAddedEventType type)
        {
            this.Annotation = annotation;
            this.AnnotationIndex = annotationIndex;
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseAnnotationAddedEvent" /> class.
        /// </summary>
        public BaseAnnotationAddedEvent()
        {
        }

    }
}