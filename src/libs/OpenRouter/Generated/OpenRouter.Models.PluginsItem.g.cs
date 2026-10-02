#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PluginsItem : global::System.IEquatable<PluginsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ChatRequestPluginDiscriminatorId? Id { get; }

        /// <summary>
        /// Example: {"allowed_models":["anthropic/*","openai/*"],"cost_tier":"low","enabled":true,"excluded_models":["openai/gpt-4o"],"id":"auto-router","pin_model":false}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AutoRouterPlugin? AutoRouter { get; init; }
#else
        public global::OpenRouter.AutoRouterPlugin? AutoRouter { get; }
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
            out global::OpenRouter.AutoRouterPlugin? value)
        {
            value = AutoRouter;
            return IsAutoRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoRouterPlugin PickAutoRouter() => AutoRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoRouter' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"allowed_models":["anthropic/*","openai/*"],"cost_tier":"low","enabled":true,"excluded_models":["openai/gpt-4o"],"id":"auto-beta-router"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AutoBetaRouterPlugin? AutoBetaRouter { get; init; }
#else
        public global::OpenRouter.AutoBetaRouterPlugin? AutoBetaRouter { get; }
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
            out global::OpenRouter.AutoBetaRouterPlugin? value)
        {
            value = AutoBetaRouter;
            return IsAutoBetaRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AutoBetaRouterPlugin PickAutoBetaRouter() => AutoBetaRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoBetaRouter' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"moderation"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModerationPlugin? Moderation { get; init; }
#else
        public global::OpenRouter.ModerationPlugin? Moderation { get; }
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
            out global::OpenRouter.ModerationPlugin? value)
        {
            value = Moderation;
            return IsModeration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationPlugin PickModeration() => Moderation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moderation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"enabled":true,"id":"web","max_results":5}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchPlugin? Web { get; init; }
#else
        public global::OpenRouter.WebSearchPlugin? Web { get; }
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
            out global::OpenRouter.WebSearchPlugin? value)
        {
            value = Web;
            return IsWeb;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebSearchPlugin PickWeb() => Web is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Web' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"web-fetch","max_uses":10}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebFetchPlugin? WebFetch { get; init; }
#else
        public global::OpenRouter.WebFetchPlugin? WebFetch { get; }
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
            out global::OpenRouter.WebFetchPlugin? value)
        {
            value = WebFetch;
            return IsWebFetch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.WebFetchPlugin PickWebFetch() => WebFetch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetch' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"enabled":true,"id":"file-parser","pdf":{"engine":"cloudflare-ai"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FileParserPlugin? FileParser { get; init; }
#else
        public global::OpenRouter.FileParserPlugin? FileParser { get; }
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
            out global::OpenRouter.FileParserPlugin? value)
        {
            value = FileParser;
            return IsFileParser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FileParserPlugin PickFileParser() => FileParser is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileParser' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"enabled":true,"id":"response-healing"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponseHealingPlugin? ResponseHealing { get; init; }
#else
        public global::OpenRouter.ResponseHealingPlugin? ResponseHealing { get; }
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
            out global::OpenRouter.ResponseHealingPlugin? value)
        {
            value = ResponseHealing;
            return IsResponseHealing;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ResponseHealingPlugin PickResponseHealing() => ResponseHealing is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseHealing' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"enabled":true,"engine":"middle-out","id":"context-compression"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContextCompressionPlugin? ContextCompression { get; init; }
#else
        public global::OpenRouter.ContextCompressionPlugin? ContextCompression { get; }
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
            out global::OpenRouter.ContextCompressionPlugin? value)
        {
            value = ContextCompression;
            return IsContextCompression;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompressionPlugin PickContextCompression() => ContextCompression is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextCompression' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"enabled":true,"id":"pareto-router","max_price":5,"price_source":"prompt"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ParetoRouterPlugin? ParetoRouter { get; init; }
#else
        public global::OpenRouter.ParetoRouterPlugin? ParetoRouter { get; }
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
            out global::OpenRouter.ParetoRouterPlugin? value)
        {
            value = ParetoRouter;
            return IsParetoRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ParetoRouterPlugin PickParetoRouter() => ParetoRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ParetoRouter' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"analysis_models":["~anthropic/claude-opus-latest","~openai/gpt-sol-latest","~google/gemini-pro-latest"],"enabled":true,"id":"fusion","model":"~anthropic/claude-opus-latest"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionPlugin? Fusion { get; init; }
#else
        public global::OpenRouter.FusionPlugin? Fusion { get; }
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
            out global::OpenRouter.FusionPlugin? value)
        {
            value = Fusion;
            return IsFusion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FusionPlugin PickFusion() => Fusion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Fusion' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"algorithm":"stage","id":"switchyard-router"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SwitchyardRouterPlugin? SwitchyardRouter { get; init; }
#else
        public global::OpenRouter.SwitchyardRouterPlugin? SwitchyardRouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwitchyardRouter))]
#endif
        public bool IsSwitchyardRouter => SwitchyardRouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwitchyardRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SwitchyardRouterPlugin? value)
        {
            value = SwitchyardRouter;
            return IsSwitchyardRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SwitchyardRouterPlugin PickSwitchyardRouter() => SwitchyardRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwitchyardRouter' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"excluded_models":["openai/gpt-6-astra"],"id":"jev-router","models":["anthropic/*","openai/gpt-5.6-sol"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.JevRouterPlugin? JevRouter { get; init; }
#else
        public global::OpenRouter.JevRouterPlugin? JevRouter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JevRouter))]
#endif
        public bool IsJevRouter => JevRouter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJevRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.JevRouterPlugin? value)
        {
            value = JevRouter;
            return IsJevRouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.JevRouterPlugin PickJevRouter() => JevRouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JevRouter' but the value was {ToString()}.");

        /// <summary>
        /// Beta. States the listed rules to the model and evaluates every turn against them. Requests are evaluated only for entities admitted to the beta; the configuration, metadata, and error shapes may change.<br/>
        /// Example: {"id":"alignment","mode":"audit","rules":["Never offer a discount."]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AlignmentPlugin? Alignment { get; init; }
#else
        public global::OpenRouter.AlignmentPlugin? Alignment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Alignment))]
#endif
        public bool IsAlignment => Alignment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAlignment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AlignmentPlugin? value)
        {
            value = Alignment;
            return IsAlignment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AlignmentPlugin PickAlignment() => Alignment is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Alignment' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.AutoRouterPlugin value) => new PluginsItem((global::OpenRouter.AutoRouterPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AutoRouterPlugin?(PluginsItem @this) => @this.AutoRouter;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.AutoRouterPlugin? value)
        {
            AutoRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromAutoRouter(global::OpenRouter.AutoRouterPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.AutoBetaRouterPlugin value) => new PluginsItem((global::OpenRouter.AutoBetaRouterPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AutoBetaRouterPlugin?(PluginsItem @this) => @this.AutoBetaRouter;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.AutoBetaRouterPlugin? value)
        {
            AutoBetaRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromAutoBetaRouter(global::OpenRouter.AutoBetaRouterPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.ModerationPlugin value) => new PluginsItem((global::OpenRouter.ModerationPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModerationPlugin?(PluginsItem @this) => @this.Moderation;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.ModerationPlugin? value)
        {
            Moderation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromModeration(global::OpenRouter.ModerationPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.WebSearchPlugin value) => new PluginsItem((global::OpenRouter.WebSearchPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchPlugin?(PluginsItem @this) => @this.Web;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.WebSearchPlugin? value)
        {
            Web = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromWeb(global::OpenRouter.WebSearchPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.WebFetchPlugin value) => new PluginsItem((global::OpenRouter.WebFetchPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.WebFetchPlugin?(PluginsItem @this) => @this.WebFetch;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.WebFetchPlugin? value)
        {
            WebFetch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromWebFetch(global::OpenRouter.WebFetchPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.FileParserPlugin value) => new PluginsItem((global::OpenRouter.FileParserPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FileParserPlugin?(PluginsItem @this) => @this.FileParser;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.FileParserPlugin? value)
        {
            FileParser = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromFileParser(global::OpenRouter.FileParserPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.ResponseHealingPlugin value) => new PluginsItem((global::OpenRouter.ResponseHealingPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ResponseHealingPlugin?(PluginsItem @this) => @this.ResponseHealing;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.ResponseHealingPlugin? value)
        {
            ResponseHealing = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromResponseHealing(global::OpenRouter.ResponseHealingPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.ContextCompressionPlugin value) => new PluginsItem((global::OpenRouter.ContextCompressionPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContextCompressionPlugin?(PluginsItem @this) => @this.ContextCompression;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.ContextCompressionPlugin? value)
        {
            ContextCompression = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromContextCompression(global::OpenRouter.ContextCompressionPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.ParetoRouterPlugin value) => new PluginsItem((global::OpenRouter.ParetoRouterPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ParetoRouterPlugin?(PluginsItem @this) => @this.ParetoRouter;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.ParetoRouterPlugin? value)
        {
            ParetoRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromParetoRouter(global::OpenRouter.ParetoRouterPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.FusionPlugin value) => new PluginsItem((global::OpenRouter.FusionPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FusionPlugin?(PluginsItem @this) => @this.Fusion;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.FusionPlugin? value)
        {
            Fusion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromFusion(global::OpenRouter.FusionPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.SwitchyardRouterPlugin value) => new PluginsItem((global::OpenRouter.SwitchyardRouterPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SwitchyardRouterPlugin?(PluginsItem @this) => @this.SwitchyardRouter;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.SwitchyardRouterPlugin? value)
        {
            SwitchyardRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromSwitchyardRouter(global::OpenRouter.SwitchyardRouterPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.JevRouterPlugin value) => new PluginsItem((global::OpenRouter.JevRouterPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.JevRouterPlugin?(PluginsItem @this) => @this.JevRouter;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.JevRouterPlugin? value)
        {
            JevRouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromJevRouter(global::OpenRouter.JevRouterPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PluginsItem(global::OpenRouter.AlignmentPlugin value) => new PluginsItem((global::OpenRouter.AlignmentPlugin?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AlignmentPlugin?(PluginsItem @this) => @this.Alignment;

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(global::OpenRouter.AlignmentPlugin? value)
        {
            Alignment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PluginsItem FromAlignment(global::OpenRouter.AlignmentPlugin? value) => new PluginsItem(value);

        /// <summary>
        ///
        /// </summary>
        public PluginsItem(
            global::OpenRouter.ChatRequestPluginDiscriminatorId? id,
            global::OpenRouter.AutoRouterPlugin? autoRouter,
            global::OpenRouter.AutoBetaRouterPlugin? autoBetaRouter,
            global::OpenRouter.ModerationPlugin? moderation,
            global::OpenRouter.WebSearchPlugin? web,
            global::OpenRouter.WebFetchPlugin? webFetch,
            global::OpenRouter.FileParserPlugin? fileParser,
            global::OpenRouter.ResponseHealingPlugin? responseHealing,
            global::OpenRouter.ContextCompressionPlugin? contextCompression,
            global::OpenRouter.ParetoRouterPlugin? paretoRouter,
            global::OpenRouter.FusionPlugin? fusion,
            global::OpenRouter.SwitchyardRouterPlugin? switchyardRouter,
            global::OpenRouter.JevRouterPlugin? jevRouter,
            global::OpenRouter.AlignmentPlugin? alignment
            )
        {
            Id = id;

            AutoRouter = autoRouter;
            AutoBetaRouter = autoBetaRouter;
            Moderation = moderation;
            Web = web;
            WebFetch = webFetch;
            FileParser = fileParser;
            ResponseHealing = responseHealing;
            ContextCompression = contextCompression;
            ParetoRouter = paretoRouter;
            Fusion = fusion;
            SwitchyardRouter = switchyardRouter;
            JevRouter = jevRouter;
            Alignment = alignment;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Alignment as object ??
            JevRouter as object ??
            SwitchyardRouter as object ??
            Fusion as object ??
            ParetoRouter as object ??
            ContextCompression as object ??
            ResponseHealing as object ??
            FileParser as object ??
            WebFetch as object ??
            Web as object ??
            Moderation as object ??
            AutoBetaRouter as object ??
            AutoRouter as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoRouter?.ToString() ??
            AutoBetaRouter?.ToString() ??
            Moderation?.ToString() ??
            Web?.ToString() ??
            WebFetch?.ToString() ??
            FileParser?.ToString() ??
            ResponseHealing?.ToString() ??
            ContextCompression?.ToString() ??
            ParetoRouter?.ToString() ??
            Fusion?.ToString() ??
            SwitchyardRouter?.ToString() ??
            JevRouter?.ToString() ??
            Alignment?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && IsFusion && !IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && IsSwitchyardRouter && !IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && IsJevRouter && !IsAlignment || !IsAutoRouter && !IsAutoBetaRouter && !IsModeration && !IsWeb && !IsWebFetch && !IsFileParser && !IsResponseHealing && !IsContextCompression && !IsParetoRouter && !IsFusion && !IsSwitchyardRouter && !IsJevRouter && IsAlignment;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AutoRouterPlugin, TResult>? autoRouter = null,
            global::System.Func<global::OpenRouter.AutoBetaRouterPlugin, TResult>? autoBetaRouter = null,
            global::System.Func<global::OpenRouter.ModerationPlugin, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.WebSearchPlugin, TResult>? web = null,
            global::System.Func<global::OpenRouter.WebFetchPlugin, TResult>? webFetch = null,
            global::System.Func<global::OpenRouter.FileParserPlugin, TResult>? fileParser = null,
            global::System.Func<global::OpenRouter.ResponseHealingPlugin, TResult>? responseHealing = null,
            global::System.Func<global::OpenRouter.ContextCompressionPlugin, TResult>? contextCompression = null,
            global::System.Func<global::OpenRouter.ParetoRouterPlugin, TResult>? paretoRouter = null,
            global::System.Func<global::OpenRouter.FusionPlugin, TResult>? fusion = null,
            global::System.Func<global::OpenRouter.SwitchyardRouterPlugin, TResult>? switchyardRouter = null,
            global::System.Func<global::OpenRouter.JevRouterPlugin, TResult>? jevRouter = null,
            global::System.Func<global::OpenRouter.AlignmentPlugin, TResult>? alignment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoRouter is { } __value0 && autoRouter != null)
            {
                return autoRouter(__value0);
            }
            else if (AutoBetaRouter is { } __value1 && autoBetaRouter != null)
            {
                return autoBetaRouter(__value1);
            }
            else if (Moderation is { } __value2 && moderation != null)
            {
                return moderation(__value2);
            }
            else if (Web is { } __value3 && web != null)
            {
                return web(__value3);
            }
            else if (WebFetch is { } __value4 && webFetch != null)
            {
                return webFetch(__value4);
            }
            else if (FileParser is { } __value5 && fileParser != null)
            {
                return fileParser(__value5);
            }
            else if (ResponseHealing is { } __value6 && responseHealing != null)
            {
                return responseHealing(__value6);
            }
            else if (ContextCompression is { } __value7 && contextCompression != null)
            {
                return contextCompression(__value7);
            }
            else if (ParetoRouter is { } __value8 && paretoRouter != null)
            {
                return paretoRouter(__value8);
            }
            else if (Fusion is { } __value9 && fusion != null)
            {
                return fusion(__value9);
            }
            else if (SwitchyardRouter is { } __value10 && switchyardRouter != null)
            {
                return switchyardRouter(__value10);
            }
            else if (JevRouter is { } __value11 && jevRouter != null)
            {
                return jevRouter(__value11);
            }
            else if (Alignment is { } __value12 && alignment != null)
            {
                return alignment(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AutoRouterPlugin>? autoRouter = null,

            global::System.Action<global::OpenRouter.AutoBetaRouterPlugin>? autoBetaRouter = null,

            global::System.Action<global::OpenRouter.ModerationPlugin>? moderation = null,

            global::System.Action<global::OpenRouter.WebSearchPlugin>? web = null,

            global::System.Action<global::OpenRouter.WebFetchPlugin>? webFetch = null,

            global::System.Action<global::OpenRouter.FileParserPlugin>? fileParser = null,

            global::System.Action<global::OpenRouter.ResponseHealingPlugin>? responseHealing = null,

            global::System.Action<global::OpenRouter.ContextCompressionPlugin>? contextCompression = null,

            global::System.Action<global::OpenRouter.ParetoRouterPlugin>? paretoRouter = null,

            global::System.Action<global::OpenRouter.FusionPlugin>? fusion = null,

            global::System.Action<global::OpenRouter.SwitchyardRouterPlugin>? switchyardRouter = null,

            global::System.Action<global::OpenRouter.JevRouterPlugin>? jevRouter = null,

            global::System.Action<global::OpenRouter.AlignmentPlugin>? alignment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoRouter is { } __value0)
            {
                autoRouter?.Invoke(__value0);
            }
            else if (AutoBetaRouter is { } __value1)
            {
                autoBetaRouter?.Invoke(__value1);
            }
            else if (Moderation is { } __value2)
            {
                moderation?.Invoke(__value2);
            }
            else if (Web is { } __value3)
            {
                web?.Invoke(__value3);
            }
            else if (WebFetch is { } __value4)
            {
                webFetch?.Invoke(__value4);
            }
            else if (FileParser is { } __value5)
            {
                fileParser?.Invoke(__value5);
            }
            else if (ResponseHealing is { } __value6)
            {
                responseHealing?.Invoke(__value6);
            }
            else if (ContextCompression is { } __value7)
            {
                contextCompression?.Invoke(__value7);
            }
            else if (ParetoRouter is { } __value8)
            {
                paretoRouter?.Invoke(__value8);
            }
            else if (Fusion is { } __value9)
            {
                fusion?.Invoke(__value9);
            }
            else if (SwitchyardRouter is { } __value10)
            {
                switchyardRouter?.Invoke(__value10);
            }
            else if (JevRouter is { } __value11)
            {
                jevRouter?.Invoke(__value11);
            }
            else if (Alignment is { } __value12)
            {
                alignment?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AutoRouterPlugin>? autoRouter = null,
            global::System.Action<global::OpenRouter.AutoBetaRouterPlugin>? autoBetaRouter = null,
            global::System.Action<global::OpenRouter.ModerationPlugin>? moderation = null,
            global::System.Action<global::OpenRouter.WebSearchPlugin>? web = null,
            global::System.Action<global::OpenRouter.WebFetchPlugin>? webFetch = null,
            global::System.Action<global::OpenRouter.FileParserPlugin>? fileParser = null,
            global::System.Action<global::OpenRouter.ResponseHealingPlugin>? responseHealing = null,
            global::System.Action<global::OpenRouter.ContextCompressionPlugin>? contextCompression = null,
            global::System.Action<global::OpenRouter.ParetoRouterPlugin>? paretoRouter = null,
            global::System.Action<global::OpenRouter.FusionPlugin>? fusion = null,
            global::System.Action<global::OpenRouter.SwitchyardRouterPlugin>? switchyardRouter = null,
            global::System.Action<global::OpenRouter.JevRouterPlugin>? jevRouter = null,
            global::System.Action<global::OpenRouter.AlignmentPlugin>? alignment = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoRouter is { } __value0)
            {
                autoRouter?.Invoke(__value0);
            }
            else if (AutoBetaRouter is { } __value1)
            {
                autoBetaRouter?.Invoke(__value1);
            }
            else if (Moderation is { } __value2)
            {
                moderation?.Invoke(__value2);
            }
            else if (Web is { } __value3)
            {
                web?.Invoke(__value3);
            }
            else if (WebFetch is { } __value4)
            {
                webFetch?.Invoke(__value4);
            }
            else if (FileParser is { } __value5)
            {
                fileParser?.Invoke(__value5);
            }
            else if (ResponseHealing is { } __value6)
            {
                responseHealing?.Invoke(__value6);
            }
            else if (ContextCompression is { } __value7)
            {
                contextCompression?.Invoke(__value7);
            }
            else if (ParetoRouter is { } __value8)
            {
                paretoRouter?.Invoke(__value8);
            }
            else if (Fusion is { } __value9)
            {
                fusion?.Invoke(__value9);
            }
            else if (SwitchyardRouter is { } __value10)
            {
                switchyardRouter?.Invoke(__value10);
            }
            else if (JevRouter is { } __value11)
            {
                jevRouter?.Invoke(__value11);
            }
            else if (Alignment is { } __value12)
            {
                alignment?.Invoke(__value12);
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
                typeof(global::OpenRouter.AutoRouterPlugin),
                AutoBetaRouter,
                typeof(global::OpenRouter.AutoBetaRouterPlugin),
                Moderation,
                typeof(global::OpenRouter.ModerationPlugin),
                Web,
                typeof(global::OpenRouter.WebSearchPlugin),
                WebFetch,
                typeof(global::OpenRouter.WebFetchPlugin),
                FileParser,
                typeof(global::OpenRouter.FileParserPlugin),
                ResponseHealing,
                typeof(global::OpenRouter.ResponseHealingPlugin),
                ContextCompression,
                typeof(global::OpenRouter.ContextCompressionPlugin),
                ParetoRouter,
                typeof(global::OpenRouter.ParetoRouterPlugin),
                Fusion,
                typeof(global::OpenRouter.FusionPlugin),
                SwitchyardRouter,
                typeof(global::OpenRouter.SwitchyardRouterPlugin),
                JevRouter,
                typeof(global::OpenRouter.JevRouterPlugin),
                Alignment,
                typeof(global::OpenRouter.AlignmentPlugin),
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
        public bool Equals(PluginsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AutoRouterPlugin?>.Default.Equals(AutoRouter, other.AutoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AutoBetaRouterPlugin?>.Default.Equals(AutoBetaRouter, other.AutoBetaRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModerationPlugin?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchPlugin?>.Default.Equals(Web, other.Web) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebFetchPlugin?>.Default.Equals(WebFetch, other.WebFetch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FileParserPlugin?>.Default.Equals(FileParser, other.FileParser) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponseHealingPlugin?>.Default.Equals(ResponseHealing, other.ResponseHealing) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContextCompressionPlugin?>.Default.Equals(ContextCompression, other.ContextCompression) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ParetoRouterPlugin?>.Default.Equals(ParetoRouter, other.ParetoRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionPlugin?>.Default.Equals(Fusion, other.Fusion) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SwitchyardRouterPlugin?>.Default.Equals(SwitchyardRouter, other.SwitchyardRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.JevRouterPlugin?>.Default.Equals(JevRouter, other.JevRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AlignmentPlugin?>.Default.Equals(Alignment, other.Alignment)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PluginsItem obj1, PluginsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PluginsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PluginsItem obj1, PluginsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PluginsItem o && Equals(o);
        }
    }
}
