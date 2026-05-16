#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ObservabilityDestination : global::System.IEquatable<ObservabilityDestination>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminatorType? Type { get; }

        /// <summary>
        /// arize variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant1? Arize { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant1? Arize { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant1? value)
        {
            value = Arize;
            return IsArize;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant1 PickArize() => IsArize
            ? Arize!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arize' but the value was {ToString()}.");

        /// <summary>
        /// braintrust variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant2? Braintrust { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant2? Braintrust { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant2? value)
        {
            value = Braintrust;
            return IsBraintrust;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant2 PickBraintrust() => IsBraintrust
            ? Braintrust!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Braintrust' but the value was {ToString()}.");

        /// <summary>
        /// clickhouse variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant3? Clickhouse { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant3? Clickhouse { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant3? value)
        {
            value = Clickhouse;
            return IsClickhouse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant3 PickClickhouse() => IsClickhouse
            ? Clickhouse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Clickhouse' but the value was {ToString()}.");

        /// <summary>
        /// datadog variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant4? Datadog { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant4? Datadog { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant4? value)
        {
            value = Datadog;
            return IsDatadog;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant4 PickDatadog() => IsDatadog
            ? Datadog!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Datadog' but the value was {ToString()}.");

        /// <summary>
        /// grafana variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant5? Grafana { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant5? Grafana { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant5? value)
        {
            value = Grafana;
            return IsGrafana;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant5 PickGrafana() => IsGrafana
            ? Grafana!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grafana' but the value was {ToString()}.");

        /// <summary>
        /// langfuse variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant6? Langfuse { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant6? Langfuse { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant6? value)
        {
            value = Langfuse;
            return IsLangfuse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant6 PickLangfuse() => IsLangfuse
            ? Langfuse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langfuse' but the value was {ToString()}.");

        /// <summary>
        /// langsmith variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant7? Langsmith { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant7? Langsmith { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant7? value)
        {
            value = Langsmith;
            return IsLangsmith;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant7 PickLangsmith() => IsLangsmith
            ? Langsmith!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langsmith' but the value was {ToString()}.");

        /// <summary>
        /// newrelic variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant8? Newrelic { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant8? Newrelic { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant8? value)
        {
            value = Newrelic;
            return IsNewrelic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant8 PickNewrelic() => IsNewrelic
            ? Newrelic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Newrelic' but the value was {ToString()}.");

        /// <summary>
        /// opik variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant9? Opik { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant9? Opik { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant9? value)
        {
            value = Opik;
            return IsOpik;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant9 PickOpik() => IsOpik
            ? Opik!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Opik' but the value was {ToString()}.");

        /// <summary>
        /// otel-collector variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant10? OtelCollector { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant10? OtelCollector { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant10? value)
        {
            value = OtelCollector;
            return IsOtelCollector;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant10 PickOtelCollector() => IsOtelCollector
            ? OtelCollector!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OtelCollector' but the value was {ToString()}.");

        /// <summary>
        /// posthog variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant11? Posthog { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant11? Posthog { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant11? value)
        {
            value = Posthog;
            return IsPosthog;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant11 PickPosthog() => IsPosthog
            ? Posthog!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Posthog' but the value was {ToString()}.");

        /// <summary>
        /// ramp variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant12? Ramp { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant12? Ramp { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant12? value)
        {
            value = Ramp;
            return IsRamp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant12 PickRamp() => IsRamp
            ? Ramp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ramp' but the value was {ToString()}.");

        /// <summary>
        /// s3 variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant13? S3 { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant13? S3 { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant13? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant13 PickS3() => IsS3
            ? S3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// sentry variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant14? Sentry { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant14? Sentry { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant14? value)
        {
            value = Sentry;
            return IsSentry;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant14 PickSentry() => IsSentry
            ? Sentry!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sentry' but the value was {ToString()}.");

        /// <summary>
        /// snowflake variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant15? Snowflake { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant15? Snowflake { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant15? value)
        {
            value = Snowflake;
            return IsSnowflake;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant15 PickSnowflake() => IsSnowflake
            ? Snowflake!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Snowflake' but the value was {ToString()}.");

        /// <summary>
        /// weave variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant16? Weave { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant16? Weave { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant16? value)
        {
            value = Weave;
            return IsWeave;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant16 PickWeave() => IsWeave
            ? Weave!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Weave' but the value was {ToString()}.");

        /// <summary>
        /// webhook variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDestinationVariant17? Webhook { get; init; }
#else
        public global::OpenRouter.ObservabilityDestinationVariant17? Webhook { get; }
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
            out global::OpenRouter.ObservabilityDestinationVariant17? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationVariant17 PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant1 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant1?(ObservabilityDestination @this) => @this.Arize;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant1? value)
        {
            Arize = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromArize(global::OpenRouter.ObservabilityDestinationVariant1? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant2 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant2?(ObservabilityDestination @this) => @this.Braintrust;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant2? value)
        {
            Braintrust = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromBraintrust(global::OpenRouter.ObservabilityDestinationVariant2? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant3 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant3?(ObservabilityDestination @this) => @this.Clickhouse;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant3? value)
        {
            Clickhouse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromClickhouse(global::OpenRouter.ObservabilityDestinationVariant3? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant4 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant4?(ObservabilityDestination @this) => @this.Datadog;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant4? value)
        {
            Datadog = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromDatadog(global::OpenRouter.ObservabilityDestinationVariant4? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant5 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant5?(ObservabilityDestination @this) => @this.Grafana;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant5? value)
        {
            Grafana = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromGrafana(global::OpenRouter.ObservabilityDestinationVariant5? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant6 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant6?(ObservabilityDestination @this) => @this.Langfuse;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant6? value)
        {
            Langfuse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromLangfuse(global::OpenRouter.ObservabilityDestinationVariant6? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant7 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant7?(ObservabilityDestination @this) => @this.Langsmith;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant7? value)
        {
            Langsmith = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromLangsmith(global::OpenRouter.ObservabilityDestinationVariant7? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant8 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant8?(ObservabilityDestination @this) => @this.Newrelic;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant8? value)
        {
            Newrelic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromNewrelic(global::OpenRouter.ObservabilityDestinationVariant8? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant9 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant9?(ObservabilityDestination @this) => @this.Opik;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant9? value)
        {
            Opik = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromOpik(global::OpenRouter.ObservabilityDestinationVariant9? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant10 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant10?(ObservabilityDestination @this) => @this.OtelCollector;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant10? value)
        {
            OtelCollector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromOtelCollector(global::OpenRouter.ObservabilityDestinationVariant10? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant11 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant11?(ObservabilityDestination @this) => @this.Posthog;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant11? value)
        {
            Posthog = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromPosthog(global::OpenRouter.ObservabilityDestinationVariant11? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant12 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant12?(ObservabilityDestination @this) => @this.Ramp;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant12? value)
        {
            Ramp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromRamp(global::OpenRouter.ObservabilityDestinationVariant12? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant13 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant13?(ObservabilityDestination @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant13? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromS3(global::OpenRouter.ObservabilityDestinationVariant13? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant14 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant14?(ObservabilityDestination @this) => @this.Sentry;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant14? value)
        {
            Sentry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromSentry(global::OpenRouter.ObservabilityDestinationVariant14? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant15 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant15?(ObservabilityDestination @this) => @this.Snowflake;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant15? value)
        {
            Snowflake = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromSnowflake(global::OpenRouter.ObservabilityDestinationVariant15? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant16 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant16?(ObservabilityDestination @this) => @this.Weave;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant16? value)
        {
            Weave = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromWeave(global::OpenRouter.ObservabilityDestinationVariant16? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant17 value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDestinationVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDestinationVariant17?(ObservabilityDestination @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDestinationVariant17? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityDestination FromWebhook(global::OpenRouter.ObservabilityDestinationVariant17? value) => new ObservabilityDestination(value);

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityDestination(
            global::OpenRouter.ObservabilityDestinationDiscriminatorType? type,
            global::OpenRouter.ObservabilityDestinationVariant1? arize,
            global::OpenRouter.ObservabilityDestinationVariant2? braintrust,
            global::OpenRouter.ObservabilityDestinationVariant3? clickhouse,
            global::OpenRouter.ObservabilityDestinationVariant4? datadog,
            global::OpenRouter.ObservabilityDestinationVariant5? grafana,
            global::OpenRouter.ObservabilityDestinationVariant6? langfuse,
            global::OpenRouter.ObservabilityDestinationVariant7? langsmith,
            global::OpenRouter.ObservabilityDestinationVariant8? newrelic,
            global::OpenRouter.ObservabilityDestinationVariant9? opik,
            global::OpenRouter.ObservabilityDestinationVariant10? otelCollector,
            global::OpenRouter.ObservabilityDestinationVariant11? posthog,
            global::OpenRouter.ObservabilityDestinationVariant12? ramp,
            global::OpenRouter.ObservabilityDestinationVariant13? s3,
            global::OpenRouter.ObservabilityDestinationVariant14? sentry,
            global::OpenRouter.ObservabilityDestinationVariant15? snowflake,
            global::OpenRouter.ObservabilityDestinationVariant16? weave,
            global::OpenRouter.ObservabilityDestinationVariant17? webhook
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
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant1, TResult>? arize = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant2, TResult>? braintrust = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant3, TResult>? clickhouse = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant4, TResult>? datadog = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant5, TResult>? grafana = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant6, TResult>? langfuse = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant7, TResult>? langsmith = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant8, TResult>? newrelic = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant9, TResult>? opik = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant10, TResult>? otelCollector = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant11, TResult>? posthog = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant12, TResult>? ramp = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant13, TResult>? s3 = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant14, TResult>? sentry = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant15, TResult>? snowflake = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant16, TResult>? weave = null,
            global::System.Func<global::OpenRouter.ObservabilityDestinationVariant17, TResult>? webhook = null,
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
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant1>? arize = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant2>? braintrust = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant3>? clickhouse = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant4>? datadog = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant5>? grafana = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant6>? langfuse = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant7>? langsmith = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant8>? newrelic = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant9>? opik = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant10>? otelCollector = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant11>? posthog = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant12>? ramp = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant13>? s3 = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant14>? sentry = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant15>? snowflake = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant16>? weave = null,

            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant17>? webhook = null,
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
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant1>? arize = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant2>? braintrust = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant3>? clickhouse = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant4>? datadog = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant5>? grafana = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant6>? langfuse = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant7>? langsmith = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant8>? newrelic = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant9>? opik = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant10>? otelCollector = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant11>? posthog = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant12>? ramp = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant13>? s3 = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant14>? sentry = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant15>? snowflake = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant16>? weave = null,
            global::System.Action<global::OpenRouter.ObservabilityDestinationVariant17>? webhook = null,
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
                typeof(global::OpenRouter.ObservabilityDestinationVariant1),
                Braintrust,
                typeof(global::OpenRouter.ObservabilityDestinationVariant2),
                Clickhouse,
                typeof(global::OpenRouter.ObservabilityDestinationVariant3),
                Datadog,
                typeof(global::OpenRouter.ObservabilityDestinationVariant4),
                Grafana,
                typeof(global::OpenRouter.ObservabilityDestinationVariant5),
                Langfuse,
                typeof(global::OpenRouter.ObservabilityDestinationVariant6),
                Langsmith,
                typeof(global::OpenRouter.ObservabilityDestinationVariant7),
                Newrelic,
                typeof(global::OpenRouter.ObservabilityDestinationVariant8),
                Opik,
                typeof(global::OpenRouter.ObservabilityDestinationVariant9),
                OtelCollector,
                typeof(global::OpenRouter.ObservabilityDestinationVariant10),
                Posthog,
                typeof(global::OpenRouter.ObservabilityDestinationVariant11),
                Ramp,
                typeof(global::OpenRouter.ObservabilityDestinationVariant12),
                S3,
                typeof(global::OpenRouter.ObservabilityDestinationVariant13),
                Sentry,
                typeof(global::OpenRouter.ObservabilityDestinationVariant14),
                Snowflake,
                typeof(global::OpenRouter.ObservabilityDestinationVariant15),
                Weave,
                typeof(global::OpenRouter.ObservabilityDestinationVariant16),
                Webhook,
                typeof(global::OpenRouter.ObservabilityDestinationVariant17),
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
        public bool Equals(ObservabilityDestination other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant1?>.Default.Equals(Arize, other.Arize) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant2?>.Default.Equals(Braintrust, other.Braintrust) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant3?>.Default.Equals(Clickhouse, other.Clickhouse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant4?>.Default.Equals(Datadog, other.Datadog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant5?>.Default.Equals(Grafana, other.Grafana) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant6?>.Default.Equals(Langfuse, other.Langfuse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant7?>.Default.Equals(Langsmith, other.Langsmith) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant8?>.Default.Equals(Newrelic, other.Newrelic) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant9?>.Default.Equals(Opik, other.Opik) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant10?>.Default.Equals(OtelCollector, other.OtelCollector) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant11?>.Default.Equals(Posthog, other.Posthog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant12?>.Default.Equals(Ramp, other.Ramp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant13?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant14?>.Default.Equals(Sentry, other.Sentry) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant15?>.Default.Equals(Snowflake, other.Snowflake) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant16?>.Default.Equals(Weave, other.Weave) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDestinationVariant17?>.Default.Equals(Webhook, other.Webhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ObservabilityDestination obj1, ObservabilityDestination obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ObservabilityDestination>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ObservabilityDestination obj1, ObservabilityDestination obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityDestination o && Equals(o);
        }
    }
}
