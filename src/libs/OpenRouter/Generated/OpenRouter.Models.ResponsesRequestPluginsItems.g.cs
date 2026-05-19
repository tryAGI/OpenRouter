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
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId? Id { get; }

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
        /// 
        /// </summary>
        public bool TryPickAutoRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant1? value)
        {
            value = AutoRouter;
            return IsAutoRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant1 PickAutoRouter() => IsAutoRouter
            ? AutoRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoRouter' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickContextCompression(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant2? value)
        {
            value = ContextCompression;
            return IsContextCompression;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant2 PickContextCompression() => IsContextCompression
            ? ContextCompression!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextCompression' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickFileParser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant3? value)
        {
            value = FileParser;
            return IsFileParser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant3 PickFileParser() => IsFileParser
            ? FileParser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileParser' but the value was {ToString()}.");

        /// <summary>
        /// fusion variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4? Fusion { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4? Fusion { get; }
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
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant4? value)
        {
            value = Fusion;
            return IsFusion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant4 PickFusion() => IsFusion
            ? Fusion!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fusion' but the value was {ToString()}.");

        /// <summary>
        /// moderation variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5? Moderation { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5? Moderation { get; }
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
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant5? value)
        {
            value = Moderation;
            return IsModeration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant5 PickModeration() => IsModeration
            ? Moderation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moderation' but the value was {ToString()}.");

        /// <summary>
        /// pareto-router variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6? ParetoRouter { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6? ParetoRouter { get; }
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
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant6? value)
        {
            value = ParetoRouter;
            return IsParetoRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant6 PickParetoRouter() => IsParetoRouter
            ? ParetoRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ParetoRouter' but the value was {ToString()}.");

        /// <summary>
        /// response-healing variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7? ResponseHealing { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7? ResponseHealing { get; }
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
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant7? value)
        {
            value = ResponseHealing;
            return IsResponseHealing;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant7 PickResponseHealing() => IsResponseHealing
            ? ResponseHealing!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseHealing' but the value was {ToString()}.");

        /// <summary>
        /// web variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant8? Web { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant8? Web { get; }
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
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant8? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant8 PickWeb() => IsWeb
            ? Web!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");

        /// <summary>
        /// web-fetch variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant9? WebFetch { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant9? WebFetch { get; }
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
            out global::OpenRouter.ResponsesRequestPluginsItemsVariant9? value)
        {
            value = WebFetch;
            return IsWebFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsVariant9 PickWebFetch() => IsWebFetch
            ? WebFetch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetch' but the value was {ToString()}.");
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
        public static ResponsesRequestPluginsItems FromAutoRouter(global::OpenRouter.ResponsesRequestPluginsItemsVariant1? value) => new ResponsesRequestPluginsItems(value);

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
        public static ResponsesRequestPluginsItems FromContextCompression(global::OpenRouter.ResponsesRequestPluginsItemsVariant2? value) => new ResponsesRequestPluginsItems(value);

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
        public static ResponsesRequestPluginsItems FromFileParser(global::OpenRouter.ResponsesRequestPluginsItemsVariant3? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant4 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant4?(ResponsesRequestPluginsItems @this) => @this.Fusion;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant4? value)
        {
            Fusion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItems FromFusion(global::OpenRouter.ResponsesRequestPluginsItemsVariant4? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant5 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant5?(ResponsesRequestPluginsItems @this) => @this.Moderation;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant5? value)
        {
            Moderation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItems FromModeration(global::OpenRouter.ResponsesRequestPluginsItemsVariant5? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant6 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant6?(ResponsesRequestPluginsItems @this) => @this.ParetoRouter;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant6? value)
        {
            ParetoRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItems FromParetoRouter(global::OpenRouter.ResponsesRequestPluginsItemsVariant6? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant7 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant7?(ResponsesRequestPluginsItems @this) => @this.ResponseHealing;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant7? value)
        {
            ResponseHealing = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItems FromResponseHealing(global::OpenRouter.ResponsesRequestPluginsItemsVariant7? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant8 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant8?(ResponsesRequestPluginsItems @this) => @this.Web;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant8? value)
        {
            Web = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItems FromWeb(global::OpenRouter.ResponsesRequestPluginsItemsVariant8? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant9 value) => new ResponsesRequestPluginsItems((global::OpenRouter.ResponsesRequestPluginsItemsVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsVariant9?(ResponsesRequestPluginsItems @this) => @this.WebFetch;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(global::OpenRouter.ResponsesRequestPluginsItemsVariant9? value)
        {
            WebFetch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItems FromWebFetch(global::OpenRouter.ResponsesRequestPluginsItemsVariant9? value) => new ResponsesRequestPluginsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItems(
            global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId? id,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant1? autoRouter,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant2? contextCompression,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant3? fileParser,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant4? fusion,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant5? moderation,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant6? paretoRouter,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant7? responseHealing,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant8? web,
            global::OpenRouter.ResponsesRequestPluginsItemsVariant9? webFetch
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
            Web?.ToString() ??
            WebFetch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && !IsFileParser && IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && IsParetoRouter && !IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && IsResponseHealing && !IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && IsWeb && !IsWebFetch || !IsAutoRouter && !IsContextCompression && !IsFileParser && !IsFusion && !IsModeration && !IsParetoRouter && !IsResponseHealing && !IsWeb && IsWebFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant1, TResult>? autoRouter = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant2, TResult>? contextCompression = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant3, TResult>? fileParser = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant4, TResult>? fusion = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant5, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant6, TResult>? paretoRouter = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant7, TResult>? responseHealing = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant8, TResult>? web = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsVariant9, TResult>? webFetch = null,
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
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant1>? autoRouter = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant2>? contextCompression = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant3>? fileParser = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant4>? fusion = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant5>? moderation = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant6>? paretoRouter = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant7>? responseHealing = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant8>? web = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant9>? webFetch = null,
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
            else if (IsWebFetch)
            {
                webFetch?.Invoke(WebFetch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant1>? autoRouter = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant2>? contextCompression = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant3>? fileParser = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant4>? fusion = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant5>? moderation = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant6>? paretoRouter = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant7>? responseHealing = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant8>? web = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsVariant9>? webFetch = null,
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
                AutoRouter,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1),
                ContextCompression,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2),
                FileParser,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3),
                Fusion,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4),
                Moderation,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5),
                ParetoRouter,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6),
                ResponseHealing,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7),
                Web,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant8),
                WebFetch,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant9),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant4?>.Default.Equals(Fusion, other.Fusion) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant5?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant6?>.Default.Equals(ParetoRouter, other.ParetoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant7?>.Default.Equals(ResponseHealing, other.ResponseHealing) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant8?>.Default.Equals(Web, other.Web) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsVariant9?>.Default.Equals(WebFetch, other.WebFetch) 
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
