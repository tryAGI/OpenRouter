#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The observability destination.
    /// </summary>
    public readonly partial struct GetObservabilityDestinationResponseData : global::System.IEquatable<GetObservabilityDestinationResponseData>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType? Type { get; }

        /// <summary>
        /// arize variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? Arize { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? Arize { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Arize))]
#endif
        public bool IsArize => Arize != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickArize(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? value)
        {
            value = Arize;
            return IsArize;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant1 PickArize() => IsArize
            ? Arize!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arize' but the value was {ToString()}.");

        /// <summary>
        /// braintrust variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? Braintrust { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? Braintrust { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Braintrust))]
#endif
        public bool IsBraintrust => Braintrust != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBraintrust(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? value)
        {
            value = Braintrust;
            return IsBraintrust;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant2 PickBraintrust() => IsBraintrust
            ? Braintrust!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Braintrust' but the value was {ToString()}.");

        /// <summary>
        /// clickhouse variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? Clickhouse { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? Clickhouse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Clickhouse))]
#endif
        public bool IsClickhouse => Clickhouse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClickhouse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? value)
        {
            value = Clickhouse;
            return IsClickhouse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant3 PickClickhouse() => IsClickhouse
            ? Clickhouse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Clickhouse' but the value was {ToString()}.");

        /// <summary>
        /// datadog variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? Datadog { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? Datadog { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Datadog))]
#endif
        public bool IsDatadog => Datadog != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDatadog(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? value)
        {
            value = Datadog;
            return IsDatadog;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant4 PickDatadog() => IsDatadog
            ? Datadog!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Datadog' but the value was {ToString()}.");

        /// <summary>
        /// grafana variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? Grafana { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? Grafana { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Grafana))]
#endif
        public bool IsGrafana => Grafana != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGrafana(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? value)
        {
            value = Grafana;
            return IsGrafana;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant5 PickGrafana() => IsGrafana
            ? Grafana!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grafana' but the value was {ToString()}.");

        /// <summary>
        /// langfuse variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? Langfuse { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? Langfuse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Langfuse))]
#endif
        public bool IsLangfuse => Langfuse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLangfuse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? value)
        {
            value = Langfuse;
            return IsLangfuse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant6 PickLangfuse() => IsLangfuse
            ? Langfuse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langfuse' but the value was {ToString()}.");

        /// <summary>
        /// langsmith variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? Langsmith { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? Langsmith { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Langsmith))]
#endif
        public bool IsLangsmith => Langsmith != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLangsmith(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? value)
        {
            value = Langsmith;
            return IsLangsmith;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant7 PickLangsmith() => IsLangsmith
            ? Langsmith!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langsmith' but the value was {ToString()}.");

        /// <summary>
        /// newrelic variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? Newrelic { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? Newrelic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Newrelic))]
#endif
        public bool IsNewrelic => Newrelic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNewrelic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? value)
        {
            value = Newrelic;
            return IsNewrelic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant8 PickNewrelic() => IsNewrelic
            ? Newrelic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Newrelic' but the value was {ToString()}.");

        /// <summary>
        /// opik variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? Opik { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? Opik { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Opik))]
#endif
        public bool IsOpik => Opik != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpik(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? value)
        {
            value = Opik;
            return IsOpik;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant9 PickOpik() => IsOpik
            ? Opik!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Opik' but the value was {ToString()}.");

        /// <summary>
        /// otel-collector variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? OtelCollector { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? OtelCollector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OtelCollector))]
#endif
        public bool IsOtelCollector => OtelCollector != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOtelCollector(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? value)
        {
            value = OtelCollector;
            return IsOtelCollector;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant10 PickOtelCollector() => IsOtelCollector
            ? OtelCollector!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OtelCollector' but the value was {ToString()}.");

        /// <summary>
        /// posthog variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? Posthog { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? Posthog { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Posthog))]
#endif
        public bool IsPosthog => Posthog != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPosthog(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? value)
        {
            value = Posthog;
            return IsPosthog;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant11 PickPosthog() => IsPosthog
            ? Posthog!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Posthog' but the value was {ToString()}.");

        /// <summary>
        /// ramp variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? Ramp { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? Ramp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ramp))]
#endif
        public bool IsRamp => Ramp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRamp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? value)
        {
            value = Ramp;
            return IsRamp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant12 PickRamp() => IsRamp
            ? Ramp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ramp' but the value was {ToString()}.");

        /// <summary>
        /// s3 variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? S3 { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? S3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickS3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant13 PickS3() => IsS3
            ? S3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// sentry variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? Sentry { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? Sentry { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sentry))]
#endif
        public bool IsSentry => Sentry != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSentry(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? value)
        {
            value = Sentry;
            return IsSentry;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant14 PickSentry() => IsSentry
            ? Sentry!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sentry' but the value was {ToString()}.");

        /// <summary>
        /// snowflake variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? Snowflake { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? Snowflake { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Snowflake))]
#endif
        public bool IsSnowflake => Snowflake != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSnowflake(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? value)
        {
            value = Snowflake;
            return IsSnowflake;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant15 PickSnowflake() => IsSnowflake
            ? Snowflake!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Snowflake' but the value was {ToString()}.");

        /// <summary>
        /// weave variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? Weave { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? Weave { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Weave))]
#endif
        public bool IsWeave => Weave != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWeave(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? value)
        {
            value = Weave;
            return IsWeave;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant16 PickWeave() => IsWeave
            ? Weave!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Weave' but the value was {ToString()}.");

        /// <summary>
        /// webhook variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? Webhook { get; init; }
#else
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.GetObservabilityDestinationResponseDataVariant17 PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant1?(GetObservabilityDestinationResponseData @this) => @this.Arize;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? value)
        {
            Arize = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromArize(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant2?(GetObservabilityDestinationResponseData @this) => @this.Braintrust;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? value)
        {
            Braintrust = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromBraintrust(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant3?(GetObservabilityDestinationResponseData @this) => @this.Clickhouse;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? value)
        {
            Clickhouse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromClickhouse(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant4?(GetObservabilityDestinationResponseData @this) => @this.Datadog;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? value)
        {
            Datadog = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromDatadog(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant5?(GetObservabilityDestinationResponseData @this) => @this.Grafana;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? value)
        {
            Grafana = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromGrafana(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant6?(GetObservabilityDestinationResponseData @this) => @this.Langfuse;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? value)
        {
            Langfuse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromLangfuse(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant7?(GetObservabilityDestinationResponseData @this) => @this.Langsmith;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? value)
        {
            Langsmith = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromLangsmith(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant8?(GetObservabilityDestinationResponseData @this) => @this.Newrelic;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? value)
        {
            Newrelic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromNewrelic(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant9?(GetObservabilityDestinationResponseData @this) => @this.Opik;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? value)
        {
            Opik = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromOpik(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant10?(GetObservabilityDestinationResponseData @this) => @this.OtelCollector;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? value)
        {
            OtelCollector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromOtelCollector(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant11?(GetObservabilityDestinationResponseData @this) => @this.Posthog;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? value)
        {
            Posthog = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromPosthog(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant12?(GetObservabilityDestinationResponseData @this) => @this.Ramp;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? value)
        {
            Ramp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromRamp(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant13?(GetObservabilityDestinationResponseData @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromS3(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant14?(GetObservabilityDestinationResponseData @this) => @this.Sentry;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? value)
        {
            Sentry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromSentry(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant15?(GetObservabilityDestinationResponseData @this) => @this.Snowflake;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? value)
        {
            Snowflake = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromSnowflake(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant16?(GetObservabilityDestinationResponseData @this) => @this.Weave;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? value)
        {
            Weave = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromWeave(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17 value) => new GetObservabilityDestinationResponseData((global::OpenRouter.GetObservabilityDestinationResponseDataVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GetObservabilityDestinationResponseDataVariant17?(GetObservabilityDestinationResponseData @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetObservabilityDestinationResponseData FromWebhook(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? value) => new GetObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public GetObservabilityDestinationResponseData(
            global::OpenRouter.GetObservabilityDestinationResponseDataDiscriminatorType? type,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant1? arize,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant2? braintrust,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant3? clickhouse,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant4? datadog,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant5? grafana,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant6? langfuse,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant7? langsmith,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant8? newrelic,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant9? opik,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant10? otelCollector,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant11? posthog,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant12? ramp,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant13? s3,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant14? sentry,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant15? snowflake,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant16? weave,
            global::OpenRouter.GetObservabilityDestinationResponseDataVariant17? webhook
            )
        {
            Type = type;

            Arize = arize;
            Braintrust = braintrust;
            Clickhouse = clickhouse;
            Datadog = datadog;
            Grafana = grafana;
            Langfuse = langfuse;
            Langsmith = langsmith;
            Newrelic = newrelic;
            Opik = opik;
            OtelCollector = otelCollector;
            Posthog = posthog;
            Ramp = ramp;
            S3 = s3;
            Sentry = sentry;
            Snowflake = snowflake;
            Weave = weave;
            Webhook = webhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Webhook as object ??
            Weave as object ??
            Snowflake as object ??
            Sentry as object ??
            S3 as object ??
            Ramp as object ??
            Posthog as object ??
            OtelCollector as object ??
            Opik as object ??
            Newrelic as object ??
            Langsmith as object ??
            Langfuse as object ??
            Grafana as object ??
            Datadog as object ??
            Clickhouse as object ??
            Braintrust as object ??
            Arize as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Arize?.ToString() ??
            Braintrust?.ToString() ??
            Clickhouse?.ToString() ??
            Datadog?.ToString() ??
            Grafana?.ToString() ??
            Langfuse?.ToString() ??
            Langsmith?.ToString() ??
            Newrelic?.ToString() ??
            Opik?.ToString() ??
            OtelCollector?.ToString() ??
            Posthog?.ToString() ??
            Ramp?.ToString() ??
            S3?.ToString() ??
            Sentry?.ToString() ??
            Snowflake?.ToString() ??
            Weave?.ToString() ??
            Webhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && IsS3 && !IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && IsSentry && !IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && IsSnowflake && !IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && IsWeave && !IsWebhook || !IsArize && !IsBraintrust && !IsClickhouse && !IsDatadog && !IsGrafana && !IsLangfuse && !IsLangsmith && !IsNewrelic && !IsOpik && !IsOtelCollector && !IsPosthog && !IsRamp && !IsS3 && !IsSentry && !IsSnowflake && !IsWeave && IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant1, TResult>? arize = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant2, TResult>? braintrust = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant3, TResult>? clickhouse = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant4, TResult>? datadog = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant5, TResult>? grafana = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant6, TResult>? langfuse = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant7, TResult>? langsmith = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant8, TResult>? newrelic = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant9, TResult>? opik = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant10, TResult>? otelCollector = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant11, TResult>? posthog = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant12, TResult>? ramp = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant13, TResult>? s3 = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant14, TResult>? sentry = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant15, TResult>? snowflake = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant16, TResult>? weave = null,
            global::System.Func<global::OpenRouter.GetObservabilityDestinationResponseDataVariant17, TResult>? webhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArize && arize != null)
            {
                return arize(Arize!);
            }
            else if (IsBraintrust && braintrust != null)
            {
                return braintrust(Braintrust!);
            }
            else if (IsClickhouse && clickhouse != null)
            {
                return clickhouse(Clickhouse!);
            }
            else if (IsDatadog && datadog != null)
            {
                return datadog(Datadog!);
            }
            else if (IsGrafana && grafana != null)
            {
                return grafana(Grafana!);
            }
            else if (IsLangfuse && langfuse != null)
            {
                return langfuse(Langfuse!);
            }
            else if (IsLangsmith && langsmith != null)
            {
                return langsmith(Langsmith!);
            }
            else if (IsNewrelic && newrelic != null)
            {
                return newrelic(Newrelic!);
            }
            else if (IsOpik && opik != null)
            {
                return opik(Opik!);
            }
            else if (IsOtelCollector && otelCollector != null)
            {
                return otelCollector(OtelCollector!);
            }
            else if (IsPosthog && posthog != null)
            {
                return posthog(Posthog!);
            }
            else if (IsRamp && ramp != null)
            {
                return ramp(Ramp!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsSentry && sentry != null)
            {
                return sentry(Sentry!);
            }
            else if (IsSnowflake && snowflake != null)
            {
                return snowflake(Snowflake!);
            }
            else if (IsWeave && weave != null)
            {
                return weave(Weave!);
            }
            else if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant1>? arize = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant2>? braintrust = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant3>? clickhouse = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant4>? datadog = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant5>? grafana = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant6>? langfuse = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant7>? langsmith = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant8>? newrelic = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant9>? opik = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant10>? otelCollector = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant11>? posthog = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant12>? ramp = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant13>? s3 = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant14>? sentry = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant15>? snowflake = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant16>? weave = null,

            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant17>? webhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArize)
            {
                arize?.Invoke(Arize!);
            }
            else if (IsBraintrust)
            {
                braintrust?.Invoke(Braintrust!);
            }
            else if (IsClickhouse)
            {
                clickhouse?.Invoke(Clickhouse!);
            }
            else if (IsDatadog)
            {
                datadog?.Invoke(Datadog!);
            }
            else if (IsGrafana)
            {
                grafana?.Invoke(Grafana!);
            }
            else if (IsLangfuse)
            {
                langfuse?.Invoke(Langfuse!);
            }
            else if (IsLangsmith)
            {
                langsmith?.Invoke(Langsmith!);
            }
            else if (IsNewrelic)
            {
                newrelic?.Invoke(Newrelic!);
            }
            else if (IsOpik)
            {
                opik?.Invoke(Opik!);
            }
            else if (IsOtelCollector)
            {
                otelCollector?.Invoke(OtelCollector!);
            }
            else if (IsPosthog)
            {
                posthog?.Invoke(Posthog!);
            }
            else if (IsRamp)
            {
                ramp?.Invoke(Ramp!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsSentry)
            {
                sentry?.Invoke(Sentry!);
            }
            else if (IsSnowflake)
            {
                snowflake?.Invoke(Snowflake!);
            }
            else if (IsWeave)
            {
                weave?.Invoke(Weave!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant1>? arize = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant2>? braintrust = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant3>? clickhouse = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant4>? datadog = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant5>? grafana = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant6>? langfuse = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant7>? langsmith = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant8>? newrelic = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant9>? opik = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant10>? otelCollector = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant11>? posthog = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant12>? ramp = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant13>? s3 = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant14>? sentry = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant15>? snowflake = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant16>? weave = null,
            global::System.Action<global::OpenRouter.GetObservabilityDestinationResponseDataVariant17>? webhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsArize)
            {
                arize?.Invoke(Arize!);
            }
            else if (IsBraintrust)
            {
                braintrust?.Invoke(Braintrust!);
            }
            else if (IsClickhouse)
            {
                clickhouse?.Invoke(Clickhouse!);
            }
            else if (IsDatadog)
            {
                datadog?.Invoke(Datadog!);
            }
            else if (IsGrafana)
            {
                grafana?.Invoke(Grafana!);
            }
            else if (IsLangfuse)
            {
                langfuse?.Invoke(Langfuse!);
            }
            else if (IsLangsmith)
            {
                langsmith?.Invoke(Langsmith!);
            }
            else if (IsNewrelic)
            {
                newrelic?.Invoke(Newrelic!);
            }
            else if (IsOpik)
            {
                opik?.Invoke(Opik!);
            }
            else if (IsOtelCollector)
            {
                otelCollector?.Invoke(OtelCollector!);
            }
            else if (IsPosthog)
            {
                posthog?.Invoke(Posthog!);
            }
            else if (IsRamp)
            {
                ramp?.Invoke(Ramp!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsSentry)
            {
                sentry?.Invoke(Sentry!);
            }
            else if (IsSnowflake)
            {
                snowflake?.Invoke(Snowflake!);
            }
            else if (IsWeave)
            {
                weave?.Invoke(Weave!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Arize,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant1),
                Braintrust,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant2),
                Clickhouse,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant3),
                Datadog,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant4),
                Grafana,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant5),
                Langfuse,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant6),
                Langsmith,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant7),
                Newrelic,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant8),
                Opik,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant9),
                OtelCollector,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant10),
                Posthog,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant11),
                Ramp,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant12),
                S3,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant13),
                Sentry,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant14),
                Snowflake,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant15),
                Weave,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant16),
                Webhook,
                typeof(global::OpenRouter.GetObservabilityDestinationResponseDataVariant17),
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
        public bool Equals(GetObservabilityDestinationResponseData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant1?>.Default.Equals(Arize, other.Arize) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant2?>.Default.Equals(Braintrust, other.Braintrust) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant3?>.Default.Equals(Clickhouse, other.Clickhouse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant4?>.Default.Equals(Datadog, other.Datadog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant5?>.Default.Equals(Grafana, other.Grafana) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant6?>.Default.Equals(Langfuse, other.Langfuse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant7?>.Default.Equals(Langsmith, other.Langsmith) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant8?>.Default.Equals(Newrelic, other.Newrelic) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant9?>.Default.Equals(Opik, other.Opik) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant10?>.Default.Equals(OtelCollector, other.OtelCollector) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant11?>.Default.Equals(Posthog, other.Posthog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant12?>.Default.Equals(Ramp, other.Ramp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant13?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant14?>.Default.Equals(Sentry, other.Sentry) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant15?>.Default.Equals(Snowflake, other.Snowflake) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant16?>.Default.Equals(Weave, other.Weave) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GetObservabilityDestinationResponseDataVariant17?>.Default.Equals(Webhook, other.Webhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetObservabilityDestinationResponseData obj1, GetObservabilityDestinationResponseData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetObservabilityDestinationResponseData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetObservabilityDestinationResponseData obj1, GetObservabilityDestinationResponseData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetObservabilityDestinationResponseData o && Equals(o);
        }
    }
}
