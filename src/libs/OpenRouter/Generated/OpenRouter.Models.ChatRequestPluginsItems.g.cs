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
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId? Id { get; }

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
        /// 
        /// </summary>
        public bool TryPickAutoRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant1? value)
        {
            value = AutoRouter;
            return IsAutoRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant1 PickAutoRouter() => IsAutoRouter
            ? AutoRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoRouter' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickContextCompression(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant2? value)
        {
            value = ContextCompression;
            return IsContextCompression;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant2 PickContextCompression() => IsContextCompression
            ? ContextCompression!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextCompression' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickFileParser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant3? value)
        {
            value = FileParser;
            return IsFileParser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant3 PickFileParser() => IsFileParser
            ? FileParser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileParser' but the value was {ToString()}.");

        /// <summary>
        /// fusion variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? Fusion { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? Fusion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fusion))]
#endif
        public bool IsFusion => Fusion != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFusion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant4? value)
        {
            value = Fusion;
            return IsFusion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant4 PickFusion() => IsFusion
            ? Fusion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fusion' but the value was {ToString()}.");

        /// <summary>
        /// moderation variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? Moderation { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? Moderation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Moderation))]
#endif
        public bool IsModeration => Moderation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickModeration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant5? value)
        {
            value = Moderation;
            return IsModeration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant5 PickModeration() => IsModeration
            ? Moderation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moderation' but the value was {ToString()}.");

        /// <summary>
        /// pareto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? ParetoRouter { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? ParetoRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParetoRouter))]
#endif
        public bool IsParetoRouter => ParetoRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickParetoRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant6? value)
        {
            value = ParetoRouter;
            return IsParetoRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant6 PickParetoRouter() => IsParetoRouter
            ? ParetoRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ParetoRouter' but the value was {ToString()}.");

        /// <summary>
        /// response-healing variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? ResponseHealing { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? ResponseHealing { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseHealing))]
#endif
        public bool IsResponseHealing => ResponseHealing != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseHealing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant7? value)
        {
            value = ResponseHealing;
            return IsResponseHealing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant7 PickResponseHealing() => IsResponseHealing
            ? ResponseHealing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseHealing' but the value was {ToString()}.");

        /// <summary>
        /// web variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant8? Web { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant8? Web { get; }
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
        public bool TryPickWeb(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant8? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant8 PickWeb() => IsWeb
            ? Web!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");
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
        public static ChatRequestPluginsItems FromAutoRouter(global::OpenRouter.ChatRequestPluginsItemsVariant1? value) => new ChatRequestPluginsItems(value);

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
        public static ChatRequestPluginsItems FromContextCompression(global::OpenRouter.ChatRequestPluginsItemsVariant2? value) => new ChatRequestPluginsItems(value);

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
        public static ChatRequestPluginsItems FromFileParser(global::OpenRouter.ChatRequestPluginsItemsVariant3? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant4 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant4?(ChatRequestPluginsItems @this) => @this.Fusion;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant4? value)
        {
            Fusion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromFusion(global::OpenRouter.ChatRequestPluginsItemsVariant4? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant5 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant5?(ChatRequestPluginsItems @this) => @this.Moderation;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant5? value)
        {
            Moderation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromModeration(global::OpenRouter.ChatRequestPluginsItemsVariant5? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant6 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant6?(ChatRequestPluginsItems @this) => @this.ParetoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant6? value)
        {
            ParetoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromParetoRouter(global::OpenRouter.ChatRequestPluginsItemsVariant6? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant7 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant7?(ChatRequestPluginsItems @this) => @this.ResponseHealing;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant7? value)
        {
            ResponseHealing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromResponseHealing(global::OpenRouter.ChatRequestPluginsItemsVariant7? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant8 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant8?(ChatRequestPluginsItems @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant8? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromWeb(global::OpenRouter.ChatRequestPluginsItemsVariant8? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(
            global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId? id,
            global::OpenRouter.ChatRequestPluginsItemsVariant1? autoRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant2? contextCompression,
            global::OpenRouter.ChatRequestPluginsItemsVariant3? fileParser,
            global::OpenRouter.ChatRequestPluginsItemsVariant4? fusion,
            global::OpenRouter.ChatRequestPluginsItemsVariant5? moderation,
            global::OpenRouter.ChatRequestPluginsItemsVariant6? paretoRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant7? responseHealing,
            global::OpenRouter.ChatRequestPluginsItemsVariant8? web
            )
        {
            Id = id;

            AutoRouter = autoRouter;
            ContextCompression = contextCompression;
            FileParser = fileParser;
            Fusion = fusion;
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
            Fusion as object ??
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
            Fusion?.ToString() ??
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
            return IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && IsParetoRouter && !IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && IsResponseHealing && !IsWeb || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant1, TResult>? autoRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant2, TResult>? contextCompression = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant3, TResult>? fileParser = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant4, TResult>? fusion = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant5, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant6, TResult>? paretoRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant7, TResult>? responseHealing = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant8, TResult>? web = null,
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
            else if (IsFusion && fusion != null)
            {
                return fusion(Fusion!);
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
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant1>? autoRouter = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant2>? contextCompression = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant3>? fileParser = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant4>? fusion = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant5>? moderation = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant6>? paretoRouter = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant7>? responseHealing = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant8>? web = null,
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
            else if (IsFusion)
            {
                fusion?.Invoke(Fusion!);
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
        public void Switch(
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant1>? autoRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant2>? contextCompression = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant3>? fileParser = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant4>? fusion = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant5>? moderation = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant6>? paretoRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant7>? responseHealing = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant8>? web = null,
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
            else if (IsFusion)
            {
                fusion?.Invoke(Fusion!);
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
                Fusion,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4),
                Moderation,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5),
                ParetoRouter,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6),
                ResponseHealing,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7),
                Web,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant4?>.Default.Equals(Fusion, other.Fusion) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant5?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant6?>.Default.Equals(ParetoRouter, other.ParetoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant7?>.Default.Equals(ResponseHealing, other.ResponseHealing) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant8?>.Default.Equals(Web, other.Web) 
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
