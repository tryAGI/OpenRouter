#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestPluginsItems : global::System.IEquatable<ResponsesRequestPluginsItems>
    {
        /// <summary>
        /// auto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant1? AutoRouter { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant1? AutoRouter { get; }
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
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant2? ContextCompression { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant2? ContextCompression { get; }
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
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant3? FileParser { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant3? FileParser { get; }
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
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4? Moderation { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4? Moderation { get; }
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
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5? ParetoRouter { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5? ParetoRouter { get; }
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
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6? ResponseHealing { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6? ResponseHealing { get; }
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
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7? Web { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7? Web { get; }
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
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant1 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant1?(ResponsesRequestPluginsItems @this) => @this.AutoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant1? value)
        {
            AutoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant2 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant2?(ResponsesRequestPluginsItems @this) => @this.ContextCompression;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant2? value)
        {
            ContextCompression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant3 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant3?(ResponsesRequestPluginsItems @this) => @this.FileParser;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant3? value)
        {
            FileParser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant4 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant4?(ResponsesRequestPluginsItems @this) => @this.Moderation;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant4? value)
        {
            Moderation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant5 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant5?(ResponsesRequestPluginsItems @this) => @this.ParetoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant5? value)
        {
            ParetoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant6 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant6?(ResponsesRequestPluginsItems @this) => @this.ResponseHealing;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant6? value)
        {
            ResponseHealing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant7 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant7?(ResponsesRequestPluginsItems @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant7? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(
            global::OpenRouter.ResponsesRequestPluginsItemsVariant1? autoRouter,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant2? contextCompression,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant3? fileParser,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant4? moderation,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant5? paretoRouter,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant6? responseHealing,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant7? web
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
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant1?, TResult>? autoRouter = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant2?, TResult>? contextCompression = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant3?, TResult>? fileParser = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant4?, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant5?, TResult>? paretoRouter = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant6?, TResult>? responseHealing = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant7?, TResult>? web = null,
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
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant1?>? autoRouter = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant2?>? contextCompression = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant3?>? fileParser = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant4?>? moderation = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant5?>? paretoRouter = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant6?>? responseHealing = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant7?>? web = null,
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
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1),
                ContextCompression,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2),
                FileParser,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3),
                Moderation,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4),
                ParetoRouter,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5),
                ResponseHealing,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6),
                Web,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7),
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
        public bool Equals(ResponsesRequestPluginsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant1?>.Default.Equals(AutoRouter, other.AutoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant2?>.Default.Equals(ContextCompression, other.ContextCompression) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant3?>.Default.Equals(FileParser, other.FileParser) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant4?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant5?>.Default.Equals(ParetoRouter, other.ParetoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant6?>.Default.Equals(ResponseHealing, other.ResponseHealing) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant7?>.Default.Equals(Web, other.Web) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestPluginsItems obj1, ResponsesRequestPluginsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestPluginsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestPluginsItems obj1, ResponsesRequestPluginsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestPluginsItems o && Equals(o);
        }
    }
}
