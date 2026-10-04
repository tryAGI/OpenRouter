#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Error from an MCP tool call, either a plain message or a structured error<br/>
    /// Example: {"code":503,"message":"Service Unavailable","type":"http_error"}
    /// </summary>
    public readonly partial struct McpToolCallError : global::System.IEquatable<McpToolCallError>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? McpToolCallErrorVariant1 { get; init; }
#else
        public string? McpToolCallErrorVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolCallErrorVariant1))]
#endif
        public bool IsMcpToolCallErrorVariant1 => McpToolCallErrorVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpToolCallErrorVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = McpToolCallErrorVariant1;
            return IsMcpToolCallErrorVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickMcpToolCallErrorVariant1() => McpToolCallErrorVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolCallErrorVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The MCP server returned a protocol-level error<br/>
        /// Example: {"code":-32601,"message":"Method not found","type":"mcp_protocol_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpProtocolError? Protocol { get; init; }
#else
        public global::OpenRouter.McpProtocolError? Protocol { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Protocol))]
#endif
        public bool IsProtocol => Protocol != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProtocol(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpProtocolError? value)
        {
            value = Protocol;
            return IsProtocol;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpProtocolError PickProtocol() => Protocol is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Protocol' but the value was {ToString()}.");

        /// <summary>
        /// The MCP tool ran but reported a failure<br/>
        /// Example: {"content":"Connection refused","type":"mcp_tool_execution_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpToolExecutionError? Execution { get; init; }
#else
        public global::OpenRouter.McpToolExecutionError? Execution { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Execution))]
#endif
        public bool IsExecution => Execution != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExecution(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpToolExecutionError? value)
        {
            value = Execution;
            return IsExecution;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpToolExecutionError PickExecution() => Execution is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Execution' but the value was {ToString()}.");

        /// <summary>
        /// The MCP server request failed at the HTTP layer<br/>
        /// Example: {"code":503,"message":"Service Unavailable","type":"http_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpHttpError? Http { get; init; }
#else
        public global::OpenRouter.McpHttpError? Http { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Http))]
#endif
        public bool IsHttp => Http != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHttp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpHttpError? value)
        {
            value = Http;
            return IsHttp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpHttpError PickHttp() => Http is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Http' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpToolCallError(string value) => new McpToolCallError((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(McpToolCallError @this) => @this.McpToolCallErrorVariant1;

        /// <summary>
        ///
        /// </summary>
        public McpToolCallError(string? value)
        {
            McpToolCallErrorVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpToolCallError FromMcpToolCallErrorVariant1(string? value) => new McpToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpToolCallError(global::OpenRouter.McpProtocolError value) => new McpToolCallError((global::OpenRouter.McpProtocolError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpProtocolError?(McpToolCallError @this) => @this.Protocol;

        /// <summary>
        ///
        /// </summary>
        public McpToolCallError(global::OpenRouter.McpProtocolError? value)
        {
            Protocol = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpToolCallError FromProtocol(global::OpenRouter.McpProtocolError? value) => new McpToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpToolCallError(global::OpenRouter.McpToolExecutionError value) => new McpToolCallError((global::OpenRouter.McpToolExecutionError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpToolExecutionError?(McpToolCallError @this) => @this.Execution;

        /// <summary>
        ///
        /// </summary>
        public McpToolCallError(global::OpenRouter.McpToolExecutionError? value)
        {
            Execution = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpToolCallError FromExecution(global::OpenRouter.McpToolExecutionError? value) => new McpToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator McpToolCallError(global::OpenRouter.McpHttpError value) => new McpToolCallError((global::OpenRouter.McpHttpError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpHttpError?(McpToolCallError @this) => @this.Http;

        /// <summary>
        ///
        /// </summary>
        public McpToolCallError(global::OpenRouter.McpHttpError? value)
        {
            Http = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static McpToolCallError FromHttp(global::OpenRouter.McpHttpError? value) => new McpToolCallError(value);

        /// <summary>
        ///
        /// </summary>
        public McpToolCallError(
            string? mcpToolCallErrorVariant1,
            global::OpenRouter.McpProtocolError? protocol,
            global::OpenRouter.McpToolExecutionError? execution,
            global::OpenRouter.McpHttpError? http
            )
        {
            McpToolCallErrorVariant1 = mcpToolCallErrorVariant1;
            Protocol = protocol;
            Execution = execution;
            Http = http;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Http as object ??
            Execution as object ??
            Protocol as object ??
            McpToolCallErrorVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            McpToolCallErrorVariant1?.ToString() ??
            Protocol?.ToString() ??
            Execution?.ToString() ??
            Http?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMcpToolCallErrorVariant1 || IsProtocol || IsExecution || IsHttp;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? mcpToolCallErrorVariant1 = null,
            global::System.Func<global::OpenRouter.McpProtocolError, TResult>? protocol = null,
            global::System.Func<global::OpenRouter.McpToolExecutionError, TResult>? execution = null,
            global::System.Func<global::OpenRouter.McpHttpError, TResult>? http = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpToolCallErrorVariant1 is { } __value0 && mcpToolCallErrorVariant1 != null)
            {
                return mcpToolCallErrorVariant1(__value0);
            }
            else if (Protocol is { } __value1 && protocol != null)
            {
                return protocol(__value1);
            }
            else if (Execution is { } __value2 && execution != null)
            {
                return execution(__value2);
            }
            else if (Http is { } __value3 && http != null)
            {
                return http(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? mcpToolCallErrorVariant1 = null,

            global::System.Action<global::OpenRouter.McpProtocolError>? protocol = null,

            global::System.Action<global::OpenRouter.McpToolExecutionError>? execution = null,

            global::System.Action<global::OpenRouter.McpHttpError>? http = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpToolCallErrorVariant1 is { } __value0)
            {
                mcpToolCallErrorVariant1?.Invoke(__value0);
            }
            else if (Protocol is { } __value1)
            {
                protocol?.Invoke(__value1);
            }
            else if (Execution is { } __value2)
            {
                execution?.Invoke(__value2);
            }
            else if (Http is { } __value3)
            {
                http?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? mcpToolCallErrorVariant1 = null,
            global::System.Action<global::OpenRouter.McpProtocolError>? protocol = null,
            global::System.Action<global::OpenRouter.McpToolExecutionError>? execution = null,
            global::System.Action<global::OpenRouter.McpHttpError>? http = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (McpToolCallErrorVariant1 is { } __value0)
            {
                mcpToolCallErrorVariant1?.Invoke(__value0);
            }
            else if (Protocol is { } __value1)
            {
                protocol?.Invoke(__value1);
            }
            else if (Execution is { } __value2)
            {
                execution?.Invoke(__value2);
            }
            else if (Http is { } __value3)
            {
                http?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpToolCallErrorVariant1,
                typeof(string),
                Protocol,
                typeof(global::OpenRouter.McpProtocolError),
                Execution,
                typeof(global::OpenRouter.McpToolExecutionError),
                Http,
                typeof(global::OpenRouter.McpHttpError),
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
        public bool Equals(McpToolCallError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(McpToolCallErrorVariant1, other.McpToolCallErrorVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpProtocolError?>.Default.Equals(Protocol, other.Protocol) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpToolExecutionError?>.Default.Equals(Execution, other.Execution) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpHttpError?>.Default.Equals(Http, other.Http)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(McpToolCallError obj1, McpToolCallError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpToolCallError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpToolCallError obj1, McpToolCallError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpToolCallError o && Equals(o);
        }
    }
}
