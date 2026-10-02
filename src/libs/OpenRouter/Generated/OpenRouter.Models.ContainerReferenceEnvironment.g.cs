
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference to a container by its canonical id — a previously returned container_id or a fresh name to create a persistent container.<br/>
    /// Example: {"container_id":"sess_abc123","type":"container_reference"}
    /// </summary>
    public sealed partial class ContainerReferenceEnvironment
    {
        /// <summary>
        /// Canonical container id to reuse (max 40 characters, letters/digits/underscores/hyphens). Any container_id previously returned by a bash or shell tool result works here and reattaches to the same container and files — including session-derived ids (sess_...) and generation-derived ids (gen_...). Note that a session-derived id is always sess_ + the sanitized session key, which is not necessarily the raw session id you sent. Using the same container_id from both the bash and shell tools shares the same files, with last-write-wins when both flush concurrently. A fresh name creates a new persistent container. Containers are always scoped to your account and workspace.<br/>
        /// Example: sess_abc123
        /// </summary>
        /// <example>sess_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Workspace file ids (or_file_…) to attach into the container before the first command runs. Each file is copied to the container home as a writable copy named {last 8 characters of the file id}-{base filename} (a file stored as data/report.csv with id or_file_…NR6q4V8w attaches to ~/NR6q4V8w-report.csv), so same-named files never collide; the source document is never modified. Unknown, foreign, or malformed ids fail the request with a 400 before any command executes. Max 20 ids.<br/>
        /// Example: [or_file_011CNha8iCJcU1wXNR6q4V8w]
        /// </summary>
        /// <example>[or_file_011CNha8iCJcU1wXNR6q4V8w]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Network egress policy for the container. "disabled" blocks all outbound internet; "allowlist" permits only hosts matching the listed hostnames or * glob patterns (ports 80/443, DNS via Cloudflare resolvers). The policy is fixed when a container starts: sending a different policy to a warm container fails the request with a 409. Omitted: defaults to "disabled" (no outbound internet). For unrestricted egress, use an allowlist of ["*"].<br/>
        /// Example: {"allowed_domains":["pypi.org","files.pythonhosted.org"],"type":"allowlist"}
        /// </summary>
        /// <example>{"allowed_domains":["pypi.org","files.pythonhosted.org"],"type":"allowlist"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerNetworkPolicyJsonConverter))]
        public global::OpenRouter.ContainerNetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContainerReferenceEnvironmentTypeJsonConverter))]
        public global::OpenRouter.ContainerReferenceEnvironmentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerReferenceEnvironment" /> class.
        /// </summary>
        /// <param name="containerId">
        /// Canonical container id to reuse (max 40 characters, letters/digits/underscores/hyphens). Any container_id previously returned by a bash or shell tool result works here and reattaches to the same container and files — including session-derived ids (sess_...) and generation-derived ids (gen_...). Note that a session-derived id is always sess_ + the sanitized session key, which is not necessarily the raw session id you sent. Using the same container_id from both the bash and shell tools shares the same files, with last-write-wins when both flush concurrently. A fresh name creates a new persistent container. Containers are always scoped to your account and workspace.<br/>
        /// Example: sess_abc123
        /// </param>
        /// <param name="fileIds">
        /// Workspace file ids (or_file_…) to attach into the container before the first command runs. Each file is copied to the container home as a writable copy named {last 8 characters of the file id}-{base filename} (a file stored as data/report.csv with id or_file_…NR6q4V8w attaches to ~/NR6q4V8w-report.csv), so same-named files never collide; the source document is never modified. Unknown, foreign, or malformed ids fail the request with a 400 before any command executes. Max 20 ids.<br/>
        /// Example: [or_file_011CNha8iCJcU1wXNR6q4V8w]
        /// </param>
        /// <param name="networkPolicy">
        /// Network egress policy for the container. "disabled" blocks all outbound internet; "allowlist" permits only hosts matching the listed hostnames or * glob patterns (ports 80/443, DNS via Cloudflare resolvers). The policy is fixed when a container starts: sending a different policy to a warm container fails the request with a 409. Omitted: defaults to "disabled" (no outbound internet). For unrestricted egress, use an allowlist of ["*"].<br/>
        /// Example: {"allowed_domains":["pypi.org","files.pythonhosted.org"],"type":"allowlist"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerReferenceEnvironment(
            string containerId,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::OpenRouter.ContainerNetworkPolicy? networkPolicy,
            global::OpenRouter.ContainerReferenceEnvironmentType type)
        {
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.FileIds = fileIds;
            this.NetworkPolicy = networkPolicy;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerReferenceEnvironment" /> class.
        /// </summary>
        public ContainerReferenceEnvironment()
        {
        }

    }
}