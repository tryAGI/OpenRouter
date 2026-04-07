#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct McpServerToolAllowedTools : global::System.IEquatable<McpServerToolAllowedTools>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? McpServerToolAllowedToolsVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? McpServerToolAllowedToolsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedToolsVariant1))]
#endif
        public bool IsMcpServerToolAllowedToolsVariant1 => McpServerToolAllowedToolsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpServerToolAllowedTools1? McpServerToolAllowedTools1 { get; init; }
#else
        public global::OpenRouter.McpServerToolAllowedTools1? McpServerToolAllowedTools1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedTools1))]
#endif
        public bool IsMcpServerToolAllowedTools1 => McpServerToolAllowedTools1 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? McpServerToolAllowedToolsVariant3 { get; init; }
#else
        public object? McpServerToolAllowedToolsVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerToolAllowedToolsVariant3))]
#endif
        public bool IsMcpServerToolAllowedToolsVariant3 => McpServerToolAllowedToolsVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServerToolAllowedTools(global::OpenRouter.McpServerToolAllowedTools1 value) => new McpServerToolAllowedTools((global::OpenRouter.McpServerToolAllowedTools1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.McpServerToolAllowedTools1?(McpServerToolAllowedTools @this) => @this.McpServerToolAllowedTools1;

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolAllowedTools(global::OpenRouter.McpServerToolAllowedTools1? value)
        {
            McpServerToolAllowedTools1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public McpServerToolAllowedTools(
            global::System.Collections.Generic.IList<string>? mcpServerToolAllowedToolsVariant1,
            global::OpenRouter.McpServerToolAllowedTools1? mcpServerToolAllowedTools1,
            object? mcpServerToolAllowedToolsVariant3
            )
        {
            McpServerToolAllowedToolsVariant1 = mcpServerToolAllowedToolsVariant1;
            McpServerToolAllowedTools1 = mcpServerToolAllowedTools1;
            McpServerToolAllowedToolsVariant3 = mcpServerToolAllowedToolsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpServerToolAllowedToolsVariant3 as object ??
            McpServerToolAllowedTools1 as object ??
            McpServerToolAllowedToolsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            McpServerToolAllowedToolsVariant1?.ToString() ??
            McpServerToolAllowedTools1?.ToString() ??
            McpServerToolAllowedToolsVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcpServerToolAllowedToolsVariant1 && !IsMcpServerToolAllowedTools1 && !IsMcpServerToolAllowedToolsVariant3 || !IsMcpServerToolAllowedToolsVariant1 && IsMcpServerToolAllowedTools1 && !IsMcpServerToolAllowedToolsVariant3 || !IsMcpServerToolAllowedToolsVariant1 && !IsMcpServerToolAllowedTools1 && IsMcpServerToolAllowedToolsVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? mcpServerToolAllowedToolsVariant1 = null,
            global::System.Func<global::OpenRouter.McpServerToolAllowedTools1?, TResult>? mcpServerToolAllowedTools1 = null,
            global::System.Func<object?, TResult>? mcpServerToolAllowedToolsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpServerToolAllowedToolsVariant1 && mcpServerToolAllowedToolsVariant1 != null)
            {
                return mcpServerToolAllowedToolsVariant1(McpServerToolAllowedToolsVariant1!);
            }
            else if (IsMcpServerToolAllowedTools1 && mcpServerToolAllowedTools1 != null)
            {
                return mcpServerToolAllowedTools1(McpServerToolAllowedTools1!);
            }
            else if (IsMcpServerToolAllowedToolsVariant3 && mcpServerToolAllowedToolsVariant3 != null)
            {
                return mcpServerToolAllowedToolsVariant3(McpServerToolAllowedToolsVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<string>?>? mcpServerToolAllowedToolsVariant1 = null,
            global::System.Action<global::OpenRouter.McpServerToolAllowedTools1?>? mcpServerToolAllowedTools1 = null,
            global::System.Action<object?>? mcpServerToolAllowedToolsVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpServerToolAllowedToolsVariant1)
            {
                mcpServerToolAllowedToolsVariant1?.Invoke(McpServerToolAllowedToolsVariant1!);
            }
            else if (IsMcpServerToolAllowedTools1)
            {
                mcpServerToolAllowedTools1?.Invoke(McpServerToolAllowedTools1!);
            }
            else if (IsMcpServerToolAllowedToolsVariant3)
            {
                mcpServerToolAllowedToolsVariant3?.Invoke(McpServerToolAllowedToolsVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpServerToolAllowedToolsVariant1,
                typeof(global::System.Collections.Generic.IList<string>),
                McpServerToolAllowedTools1,
                typeof(global::OpenRouter.McpServerToolAllowedTools1),
                McpServerToolAllowedToolsVariant3,
                typeof(object),
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
        public bool Equals(McpServerToolAllowedTools other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(McpServerToolAllowedToolsVariant1, other.McpServerToolAllowedToolsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpServerToolAllowedTools1?>.Default.Equals(McpServerToolAllowedTools1, other.McpServerToolAllowedTools1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(McpServerToolAllowedToolsVariant3, other.McpServerToolAllowedToolsVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpServerToolAllowedTools obj1, McpServerToolAllowedTools obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpServerToolAllowedTools>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpServerToolAllowedTools obj1, McpServerToolAllowedTools obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpServerToolAllowedTools o && Equals(o);
        }
    }
}
