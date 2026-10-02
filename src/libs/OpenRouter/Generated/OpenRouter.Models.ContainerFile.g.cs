
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContainerFile
    {
        /// <summary>
        /// File size in bytes.<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Bytes { get; set; }

        /// <summary>
        /// The container the file belongs to — echoes the `container_id` path parameter (OpenAI field name).<br/>
        /// Example: sess_abc123
        /// </summary>
        /// <example>sess_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) when the file was last synced.<br/>
        /// Example: 1755640000
        /// </summary>
        /// <example>1755640000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Container file id: `cfile_` + base64url of the file path.<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </summary>
        /// <example>cfile_b3V0L3JlcG9ydC5jc3Y</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: container.file
        /// </summary>
        /// <example>container.file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerFileObjectJsonConverter))]
        public global::OpenRouter.ContainerFileObject Object { get; set; }

        /// <summary>
        /// Container-relative file path.<br/>
        /// Example: out/report.csv
        /// </summary>
        /// <example>out/report.csv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Container files are always produced by the assistant sandbox.<br/>
        /// Example: assistant
        /// </summary>
        /// <example>assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerFileSourceJsonConverter))]
        public global::OpenRouter.ContainerFileSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFile" /> class.
        /// </summary>
        /// <param name="bytes">
        /// File size in bytes.<br/>
        /// Example: 123
        /// </param>
        /// <param name="containerId">
        /// The container the file belongs to — echoes the `container_id` path parameter (OpenAI field name).<br/>
        /// Example: sess_abc123
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (seconds) when the file was last synced.<br/>
        /// Example: 1755640000
        /// </param>
        /// <param name="id">
        /// Container file id: `cfile_` + base64url of the file path.<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="path">
        /// Container-relative file path.<br/>
        /// Example: out/report.csv
        /// </param>
        /// <param name="object">
        /// Example: container.file
        /// </param>
        /// <param name="source">
        /// Container files are always produced by the assistant sandbox.<br/>
        /// Example: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerFile(
            long bytes,
            string containerId,
            global::System.DateTimeOffset createdAt,
            string id,
            string path,
            global::OpenRouter.ContainerFileObject @object,
            global::OpenRouter.ContainerFileSource source)
        {
            this.Bytes = bytes;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFile" /> class.
        /// </summary>
        public ContainerFile()
        {
        }

    }
}