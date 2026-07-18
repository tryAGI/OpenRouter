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
        /// auto-beta-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant1? AutoBetaRouter { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant1? AutoBetaRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoBetaRouter))]
#endif
        public bool IsAutoBetaRouter => AutoBetaRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAutoBetaRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant1? value)
        {
            value = AutoBetaRouter;
            return IsAutoBetaRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant1 PickAutoBetaRouter() => IsAutoBetaRouter
            ? AutoBetaRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoBetaRouter' but the value was {ToString()}.");

        /// <summary>
        /// auto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant2? AutoRouter { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant2? AutoRouter { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant2? value)
        {
            value = AutoRouter;
            return IsAutoRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant2 PickAutoRouter() => IsAutoRouter
            ? AutoRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoRouter' but the value was {ToString()}.");

        /// <summary>
        /// context-compression variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant3? ContextCompression { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant3? ContextCompression { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant3? value)
        {
            value = ContextCompression;
            return IsContextCompression;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant3 PickContextCompression() => IsContextCompression
            ? ContextCompression!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextCompression' but the value was {ToString()}.");

        /// <summary>
        /// file-parser variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? FileParser { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant4? FileParser { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant4? value)
        {
            value = FileParser;
            return IsFileParser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant4 PickFileParser() => IsFileParser
            ? FileParser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileParser' but the value was {ToString()}.");

        /// <summary>
        /// fusion variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? Fusion { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant5? Fusion { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant5? value)
        {
            value = Fusion;
            return IsFusion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant5 PickFusion() => IsFusion
            ? Fusion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fusion' but the value was {ToString()}.");

        /// <summary>
        /// moderation variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? Moderation { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant6? Moderation { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant6? value)
        {
            value = Moderation;
            return IsModeration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant6 PickModeration() => IsModeration
            ? Moderation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moderation' but the value was {ToString()}.");

        /// <summary>
        /// pareto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? ParetoRouter { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant7? ParetoRouter { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant7? value)
        {
            value = ParetoRouter;
            return IsParetoRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant7 PickParetoRouter() => IsParetoRouter
            ? ParetoRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ParetoRouter' but the value was {ToString()}.");

        /// <summary>
        /// response-healing variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant8? ResponseHealing { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant8? ResponseHealing { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant8? value)
        {
            value = ResponseHealing;
            return IsResponseHealing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant8 PickResponseHealing() => IsResponseHealing
            ? ResponseHealing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseHealing' but the value was {ToString()}.");

        /// <summary>
        /// web variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant9? Web { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant9? Web { get; }
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
            out global::OpenRouter.ChatRequestPluginsItemsVariant9? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant9 PickWeb() => IsWeb
            ? Web!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");

        /// <summary>
        /// web-fetch variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatRequestPluginsItemsVariant10? WebFetch { get; init; }
#else
        public global::OpenRouter.ChatRequestPluginsItemsVariant10? WebFetch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetch))]
#endif
        public bool IsWebFetch => WebFetch != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebFetch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ChatRequestPluginsItemsVariant10? value)
        {
            value = WebFetch;
            return IsWebFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ChatRequestPluginsItemsVariant10 PickWebFetch() => IsWebFetch
            ? WebFetch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetch' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant1 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant1?(ChatRequestPluginsItems @this) => @this.AutoBetaRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant1? value)
        {
            AutoBetaRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromAutoBetaRouter(global::OpenRouter.ChatRequestPluginsItemsVariant1? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant2 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant2?(ChatRequestPluginsItems @this) => @this.AutoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant2? value)
        {
            AutoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromAutoRouter(global::OpenRouter.ChatRequestPluginsItemsVariant2? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant3 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant3?(ChatRequestPluginsItems @this) => @this.ContextCompression;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant3? value)
        {
            ContextCompression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromContextCompression(global::OpenRouter.ChatRequestPluginsItemsVariant3? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant4 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant4?(ChatRequestPluginsItems @this) => @this.FileParser;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant4? value)
        {
            FileParser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromFileParser(global::OpenRouter.ChatRequestPluginsItemsVariant4? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant5 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant5?(ChatRequestPluginsItems @this) => @this.Fusion;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant5? value)
        {
            Fusion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromFusion(global::OpenRouter.ChatRequestPluginsItemsVariant5? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant6 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant6?(ChatRequestPluginsItems @this) => @this.Moderation;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant6? value)
        {
            Moderation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromModeration(global::OpenRouter.ChatRequestPluginsItemsVariant6? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant7 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant7?(ChatRequestPluginsItems @this) => @this.ParetoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant7? value)
        {
            ParetoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromParetoRouter(global::OpenRouter.ChatRequestPluginsItemsVariant7? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant8 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant8?(ChatRequestPluginsItems @this) => @this.ResponseHealing;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant8? value)
        {
            ResponseHealing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromResponseHealing(global::OpenRouter.ChatRequestPluginsItemsVariant8? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant9 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant9?(ChatRequestPluginsItems @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant9? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromWeb(global::OpenRouter.ChatRequestPluginsItemsVariant9? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant10 value) => new ChatRequestPluginsItems((global::OpenRouter.ChatRequestPluginsItemsVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatRequestPluginsItemsVariant10?(ChatRequestPluginsItems @this) => @this.WebFetch;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(global::OpenRouter.ChatRequestPluginsItemsVariant10? value)
        {
            WebFetch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequestPluginsItems FromWebFetch(global::OpenRouter.ChatRequestPluginsItemsVariant10? value) => new ChatRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestPluginsItems(
            global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId? id,
            global::OpenRouter.ChatRequestPluginsItemsVariant1? autoBetaRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant2? autoRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant3? contextCompression,
            global::OpenRouter.ChatRequestPluginsItemsVariant4? fileParser,
            global::OpenRouter.ChatRequestPluginsItemsVariant5? fusion,
            global::OpenRouter.ChatRequestPluginsItemsVariant6? moderation,
            global::OpenRouter.ChatRequestPluginsItemsVariant7? paretoRouter,
            global::OpenRouter.ChatRequestPluginsItemsVariant8? responseHealing,
            global::OpenRouter.ChatRequestPluginsItemsVariant9? web,
            global::OpenRouter.ChatRequestPluginsItemsVariant10? webFetch
            )
        {
            Id = id;

            AutoBetaRouter = autoBetaRouter;
            AutoRouter = autoRouter;
            ContextCompression = contextCompression;
            FileParser = fileParser;
            Fusion = fusion;
            Moderation = moderation;
            ParetoRouter = paretoRouter;
            ResponseHealing = responseHealing;
            Web = web;
            WebFetch = webFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebFetch as object ??
            Web as object ??
            ResponseHealing as object ??
            ParetoRouter as object ??
            Moderation as object ??
            Fusion as object ??
            FileParser as object ??
            ContextCompression as object ??
            AutoRouter as object ??
            AutoBetaRouter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AutoBetaRouter?.ToString() ??
            AutoRouter?.ToString() ??
            ContextCompression?.ToString() ??
            FileParser?.ToString() ??
            Fusion?.ToString() ??
            Moderation?.ToString() ??
            ParetoRouter?.ToString() ??
            ResponseHealing?.ToString() ??
            Web?.ToString() ??
            WebFetch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && IsWeb && !IsWebFetch || !IsAutoBetaRouter && !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && IsWebFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant1, TResult>? autoBetaRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant2, TResult>? autoRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant3, TResult>? contextCompression = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant4, TResult>? fileParser = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant5, TResult>? fusion = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant6, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant7, TResult>? paretoRouter = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant8, TResult>? responseHealing = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant9, TResult>? web = null,
            global::System.Func<global::OpenRouter.ChatRequestPluginsItemsVariant10, TResult>? webFetch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoBetaRouter && autoBetaRouter != null)
            {
                return autoBetaRouter(AutoBetaRouter!);
            }
            else if (IsAutoRouter && autoRouter != null)
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
            else if (IsWebFetch && webFetch != null)
            {
                return webFetch(WebFetch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant1>? autoBetaRouter = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant2>? autoRouter = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant3>? contextCompression = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant4>? fileParser = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant5>? fusion = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant6>? moderation = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant7>? paretoRouter = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant8>? responseHealing = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant9>? web = null,

            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant10>? webFetch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoBetaRouter)
            {
                autoBetaRouter?.Invoke(AutoBetaRouter!);
            }
            else if (IsAutoRouter)
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
            else if (IsWebFetch)
            {
                webFetch?.Invoke(WebFetch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant1>? autoBetaRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant2>? autoRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant3>? contextCompression = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant4>? fileParser = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant5>? fusion = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant6>? moderation = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant7>? paretoRouter = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant8>? responseHealing = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant9>? web = null,
            global::System.Action<global::OpenRouter.ChatRequestPluginsItemsVariant10>? webFetch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAutoBetaRouter)
            {
                autoBetaRouter?.Invoke(AutoBetaRouter!);
            }
            else if (IsAutoRouter)
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
            else if (IsWebFetch)
            {
                webFetch?.Invoke(WebFetch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoBetaRouter,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1),
                AutoRouter,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2),
                ContextCompression,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3),
                FileParser,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4),
                Fusion,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5),
                Moderation,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6),
                ParetoRouter,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7),
                ResponseHealing,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8),
                Web,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant9),
                WebFetch,
                typeof(global::OpenRouter.ChatRequestPluginsItemsVariant10),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant1?>.Default.Equals(AutoBetaRouter, other.AutoBetaRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant2?>.Default.Equals(AutoRouter, other.AutoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant3?>.Default.Equals(ContextCompression, other.ContextCompression) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant4?>.Default.Equals(FileParser, other.FileParser) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant5?>.Default.Equals(Fusion, other.Fusion) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant6?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant7?>.Default.Equals(ParetoRouter, other.ParetoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant8?>.Default.Equals(ResponseHealing, other.ResponseHealing) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant9?>.Default.Equals(Web, other.Web) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatRequestPluginsItemsVariant10?>.Default.Equals(WebFetch, other.WebFetch) 
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
