#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestPluginsItems : global::System.IEquatable<ChatRequestPluginsItems>
    {
        /// <summary>
        /// auto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant1? AutoRouter { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant1? AutoRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoRouter))]
#endif
        public bool IsAutoRouter => AutoRouter != null;

        /// <summary>
        /// context-compression variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant2? ContextCompression { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant2? ContextCompression { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextCompression))]
#endif
        public bool IsContextCompression => ContextCompression != null;

        /// <summary>
        /// file-parser variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant3? FileParser { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant3? FileParser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileParser))]
#endif
        public bool IsFileParser => FileParser != null;

        /// <summary>
        /// moderation variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? Moderation { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? Moderation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Moderation))]
#endif
        public bool IsModeration => Moderation != null;

        /// <summary>
        /// pareto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? ParetoRouter { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? ParetoRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParetoRouter))]
#endif
        public bool IsParetoRouter => ParetoRouter != null;

        /// <summary>
        /// response-healing variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? ResponseHealing { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? ResponseHealing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseHealing))]
#endif
        public bool IsResponseHealing => ResponseHealing != null;

        /// <summary>
        /// web variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? Web { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? Web { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Web))]
#endif
        public bool IsWeb => Web != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant1 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant1?(ChatRequestPluginsItems @this) => @this.AutoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant1? value)
        {
            AutoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant2 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant2?(ChatRequestPluginsItems @this) => @this.ContextCompression;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant2? value)
        {
            ContextCompression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant3 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant3?(ChatRequestPluginsItems @this) => @this.FileParser;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant3? value)
        {
            FileParser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant4 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant4?(ChatRequestPluginsItems @this) => @this.Moderation;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant4? value)
        {
            Moderation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant5 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant5?(ChatRequestPluginsItems @this) => @this.ParetoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant5? value)
        {
            ParetoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant6 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant6?(ChatRequestPluginsItems @this) => @this.ResponseHealing;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant6? value)
        {
            ResponseHealing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant7 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant7?(ChatRequestPluginsItems @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant7? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(
            global::OpenRouter.ChatRequestPluginsItemsVariant1? autoRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant2? contextCompression,
            global::OpenRouter.ChatRequestPluginsItemsVariant3? fileParser,
            global::OpenRouter.ChatRequestPluginsItemsVariant4? moderation,
            global::OpenRouter.ChatRequestPluginsItemsVariant5? paretoRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant6? responseHealing,
            global::OpenRouter.ChatRequestPluginsItemsVariant7? web
            )
        {
            AutoRouter = autoRouter;
            ContextCompression = contextCompression;
            FileParser = fileParser;
            Moderation = moderation;
            ParetoRouter = paretoRouter;
            ResponseHealing = responseHealing;
            Web = web;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Web as object ??
            ResponseHealing as object ??
            ParetoRouter as object ??
            Moderation as object ??
            FileParser as object ??
            ContextCompression as object ??
            AutoRouter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutoRouter?.ToString() ??
            ContextCompression?.ToString() ??
            FileParser?.ToString() ??
            Moderation?.ToString() ??
            ParetoRouter?.ToString() ??
            ResponseHealing?.ToString() ??
            Web?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoRouter && !IsContextCompression && !IsFileParser && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && IsContextCompression && !IsFileParser && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && IsFileParser && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsModeration && IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsModeration && !IsParetoRouter && IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsModeration && !IsParetoRouter && !IsResponseHealing && IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant1?, TResult>? autoRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant2?, TResult>? contextCompression = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant3?, TResult>? fileParser = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant4?, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant5?, TResult>? paretoRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant6?, TResult>? responseHealing = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant7?, TResult>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoRouter && autoRouter != null)
            {
                return autoRouter(AutoRouter!);
            }
            else if (IsContextCompression && contextCompression != null)
            {
                return contextCompression(ContextCompression!);
            }
            else if (IsFileParser && fileParser != null)
            {
                return fileParser(FileParser!);
            }
            else if (IsModeration && moderation != null)
            {
                return moderation(Moderation!);
            }
            else if (IsParetoRouter && paretoRouter != null)
            {
                return paretoRouter(ParetoRouter!);
            }
            else if (IsResponseHealing && responseHealing != null)
            {
                return responseHealing(ResponseHealing!);
            }
            else if (IsWeb && web != null)
            {
                return web(Web!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant1?>? autoRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant2?>? contextCompression = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant3?>? fileParser = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant4?>? moderation = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant5?>? paretoRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant6?>? responseHealing = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant7?>? web = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoRouter)
            {
                autoRouter?.Invoke(AutoRouter!);
            }
            else if (IsContextCompression)
            {
                contextCompression?.Invoke(ContextCompression!);
            }
            else if (IsFileParser)
            {
                fileParser?.Invoke(FileParser!);
            }
            else if (IsModeration)
            {
                moderation?.Invoke(Moderation!);
            }
            else if (IsParetoRouter)
            {
                paretoRouter?.Invoke(ParetoRouter!);
            }
            else if (IsResponseHealing)
            {
                responseHealing?.Invoke(ResponseHealing!);
            }
            else if (IsWeb)
            {
                web?.Invoke(Web!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoRouter,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1),
                ContextCompression,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2),
                FileParser,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3),
                Moderation,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4),
                ParetoRouter,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5),
                ResponseHealing,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6),
                Web,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7),
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
        public bool Equals(ChatRequestPluginsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant1?>.Default.Equals(AutoRouter, other.AutoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant2?>.Default.Equals(ContextCompression, other.ContextCompression) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant3?>.Default.Equals(FileParser, other.FileParser) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant4?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant5?>.Default.Equals(ParetoRouter, other.ParetoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant6?>.Default.Equals(ResponseHealing, other.ResponseHealing) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant7?>.Default.Equals(Web, other.Web) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestPluginsItems obj1, ChatRequestPluginsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestPluginsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestPluginsItems obj1, ChatRequestPluginsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestPluginsItems o && Equals(o);
        }
    }
}
