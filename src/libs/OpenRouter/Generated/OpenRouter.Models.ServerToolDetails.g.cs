#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerToolDetails : global::System.IEquatable<ServerToolDetails>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ServerTool? ServerTool { get; init; }
#else
        public global::OpenRouter.ServerTool? ServerTool { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerTool))]
#endif
        public bool IsServerTool => ServerTool != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ServerTool? value)
        {
            value = ServerTool;
            return IsServerTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerTool PickServerTool() => ServerTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerTool' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ServerToolDetailsVariant2? ServerToolDetailsVariant2 { get; init; }
#else
        public global::OpenRouter.ServerToolDetailsVariant2? ServerToolDetailsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerToolDetailsVariant2))]
#endif
        public bool IsServerToolDetailsVariant2 => ServerToolDetailsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServerToolDetailsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ServerToolDetailsVariant2? value)
        {
            value = ServerToolDetailsVariant2;
            return IsServerToolDetailsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ServerToolDetailsVariant2 PickServerToolDetailsVariant2() => ServerToolDetailsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerToolDetailsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolDetails(global::OpenRouter.ServerTool value) => new ServerToolDetails((global::OpenRouter.ServerTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ServerTool?(ServerToolDetails @this) => @this.ServerTool;

        /// <summary>
        ///
        /// </summary>
        public ServerToolDetails(global::OpenRouter.ServerTool? value)
        {
            ServerTool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolDetails FromServerTool(global::OpenRouter.ServerTool? value) => new ServerToolDetails(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolDetails(global::OpenRouter.ServerToolDetailsVariant2 value) => new ServerToolDetails((global::OpenRouter.ServerToolDetailsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ServerToolDetailsVariant2?(ServerToolDetails @this) => @this.ServerToolDetailsVariant2;

        /// <summary>
        ///
        /// </summary>
        public ServerToolDetails(global::OpenRouter.ServerToolDetailsVariant2? value)
        {
            ServerToolDetailsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolDetails FromServerToolDetailsVariant2(global::OpenRouter.ServerToolDetailsVariant2? value) => new ServerToolDetails(value);

        /// <summary>
        ///
        /// </summary>
        public ServerToolDetails(
            global::OpenRouter.ServerTool? serverTool,
            global::OpenRouter.ServerToolDetailsVariant2? serverToolDetailsVariant2
            )
        {
            ServerTool = serverTool;
            ServerToolDetailsVariant2 = serverToolDetailsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServerToolDetailsVariant2 as object ??
            ServerTool as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ServerTool?.ToString() ??
            ServerToolDetailsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsServerTool && IsServerToolDetailsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ServerTool, TResult>? serverTool = null,
            global::System.Func<global::OpenRouter.ServerToolDetailsVariant2, TResult>? serverToolDetailsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ServerTool is { } __value0 && serverTool != null)
            {
                return serverTool(__value0);
            }
            else if (ServerToolDetailsVariant2 is { } __value1 && serverToolDetailsVariant2 != null)
            {
                return serverToolDetailsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ServerTool>? serverTool = null,

            global::System.Action<global::OpenRouter.ServerToolDetailsVariant2>? serverToolDetailsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ServerTool is { } __value0)
            {
                serverTool?.Invoke(__value0);
            }
            else if (ServerToolDetailsVariant2 is { } __value1)
            {
                serverToolDetailsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ServerTool>? serverTool = null,
            global::System.Action<global::OpenRouter.ServerToolDetailsVariant2>? serverToolDetailsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ServerTool is { } __value0)
            {
                serverTool?.Invoke(__value0);
            }
            else if (ServerToolDetailsVariant2 is { } __value1)
            {
                serverToolDetailsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ServerTool,
                typeof(global::OpenRouter.ServerTool),
                ServerToolDetailsVariant2,
                typeof(global::OpenRouter.ServerToolDetailsVariant2),
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
        public bool Equals(ServerToolDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ServerTool?>.Default.Equals(ServerTool, other.ServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ServerToolDetailsVariant2?>.Default.Equals(ServerToolDetailsVariant2, other.ServerToolDetailsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ServerToolDetails obj1, ServerToolDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerToolDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolDetails obj1, ServerToolDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolDetails o && Equals(o);
        }
    }
}
