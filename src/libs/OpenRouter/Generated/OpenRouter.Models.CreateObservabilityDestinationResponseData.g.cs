#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The newly created observability destination.
    /// </summary>
    public readonly partial struct CreateObservabilityDestinationResponseData : global::System.IEquatable<CreateObservabilityDestinationResponseData>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType? Type { get; }

        /// <summary>
        /// arize variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? Arize { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? Arize { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? value)
        {
            value = Arize;
            return IsArize;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1 PickArize() => IsArize
            ? Arize!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arize' but the value was {ToString()}.");

        /// <summary>
        /// braintrust variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? Braintrust { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? Braintrust { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? value)
        {
            value = Braintrust;
            return IsBraintrust;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2 PickBraintrust() => IsBraintrust
            ? Braintrust!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Braintrust' but the value was {ToString()}.");

        /// <summary>
        /// clickhouse variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? Clickhouse { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? Clickhouse { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? value)
        {
            value = Clickhouse;
            return IsClickhouse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3 PickClickhouse() => IsClickhouse
            ? Clickhouse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Clickhouse' but the value was {ToString()}.");

        /// <summary>
        /// datadog variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? Datadog { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? Datadog { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? value)
        {
            value = Datadog;
            return IsDatadog;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4 PickDatadog() => IsDatadog
            ? Datadog!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Datadog' but the value was {ToString()}.");

        /// <summary>
        /// grafana variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? Grafana { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? Grafana { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? value)
        {
            value = Grafana;
            return IsGrafana;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5 PickGrafana() => IsGrafana
            ? Grafana!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grafana' but the value was {ToString()}.");

        /// <summary>
        /// langfuse variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? Langfuse { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? Langfuse { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? value)
        {
            value = Langfuse;
            return IsLangfuse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6 PickLangfuse() => IsLangfuse
            ? Langfuse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langfuse' but the value was {ToString()}.");

        /// <summary>
        /// langsmith variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? Langsmith { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? Langsmith { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? value)
        {
            value = Langsmith;
            return IsLangsmith;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7 PickLangsmith() => IsLangsmith
            ? Langsmith!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langsmith' but the value was {ToString()}.");

        /// <summary>
        /// newrelic variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? Newrelic { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? Newrelic { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? value)
        {
            value = Newrelic;
            return IsNewrelic;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8 PickNewrelic() => IsNewrelic
            ? Newrelic!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Newrelic' but the value was {ToString()}.");

        /// <summary>
        /// opik variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? Opik { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? Opik { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? value)
        {
            value = Opik;
            return IsOpik;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9 PickOpik() => IsOpik
            ? Opik!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Opik' but the value was {ToString()}.");

        /// <summary>
        /// otel-collector variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? OtelCollector { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? OtelCollector { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? value)
        {
            value = OtelCollector;
            return IsOtelCollector;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10 PickOtelCollector() => IsOtelCollector
            ? OtelCollector!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OtelCollector' but the value was {ToString()}.");

        /// <summary>
        /// posthog variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? Posthog { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? Posthog { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? value)
        {
            value = Posthog;
            return IsPosthog;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11 PickPosthog() => IsPosthog
            ? Posthog!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Posthog' but the value was {ToString()}.");

        /// <summary>
        /// ramp variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? Ramp { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? Ramp { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? value)
        {
            value = Ramp;
            return IsRamp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12 PickRamp() => IsRamp
            ? Ramp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ramp' but the value was {ToString()}.");

        /// <summary>
        /// s3 variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? S3 { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? S3 { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13 PickS3() => IsS3
            ? S3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// sentry variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? Sentry { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? Sentry { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? value)
        {
            value = Sentry;
            return IsSentry;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14 PickSentry() => IsSentry
            ? Sentry!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sentry' but the value was {ToString()}.");

        /// <summary>
        /// snowflake variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? Snowflake { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? Snowflake { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? value)
        {
            value = Snowflake;
            return IsSnowflake;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15 PickSnowflake() => IsSnowflake
            ? Snowflake!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Snowflake' but the value was {ToString()}.");

        /// <summary>
        /// weave variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? Weave { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? Weave { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? value)
        {
            value = Weave;
            return IsWeave;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16 PickWeave() => IsWeave
            ? Weave!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Weave' but the value was {ToString()}.");

        /// <summary>
        /// webhook variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? Webhook { get; init; }
#else
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? Webhook { get; }
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
            out global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17 PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1?(CreateObservabilityDestinationResponseData @this) => @this.Arize;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? value)
        {
            Arize = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromArize(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2?(CreateObservabilityDestinationResponseData @this) => @this.Braintrust;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? value)
        {
            Braintrust = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromBraintrust(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3?(CreateObservabilityDestinationResponseData @this) => @this.Clickhouse;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? value)
        {
            Clickhouse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromClickhouse(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4?(CreateObservabilityDestinationResponseData @this) => @this.Datadog;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? value)
        {
            Datadog = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromDatadog(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5?(CreateObservabilityDestinationResponseData @this) => @this.Grafana;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? value)
        {
            Grafana = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromGrafana(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6?(CreateObservabilityDestinationResponseData @this) => @this.Langfuse;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? value)
        {
            Langfuse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromLangfuse(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7?(CreateObservabilityDestinationResponseData @this) => @this.Langsmith;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? value)
        {
            Langsmith = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromLangsmith(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8?(CreateObservabilityDestinationResponseData @this) => @this.Newrelic;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? value)
        {
            Newrelic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromNewrelic(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9?(CreateObservabilityDestinationResponseData @this) => @this.Opik;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? value)
        {
            Opik = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromOpik(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10?(CreateObservabilityDestinationResponseData @this) => @this.OtelCollector;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? value)
        {
            OtelCollector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromOtelCollector(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11?(CreateObservabilityDestinationResponseData @this) => @this.Posthog;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? value)
        {
            Posthog = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromPosthog(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12?(CreateObservabilityDestinationResponseData @this) => @this.Ramp;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? value)
        {
            Ramp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromRamp(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13?(CreateObservabilityDestinationResponseData @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromS3(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14?(CreateObservabilityDestinationResponseData @this) => @this.Sentry;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? value)
        {
            Sentry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromSentry(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15?(CreateObservabilityDestinationResponseData @this) => @this.Snowflake;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? value)
        {
            Snowflake = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromSnowflake(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16?(CreateObservabilityDestinationResponseData @this) => @this.Weave;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? value)
        {
            Weave = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromWeave(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17 value) => new CreateObservabilityDestinationResponseData((global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17?(CreateObservabilityDestinationResponseData @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateObservabilityDestinationResponseData FromWebhook(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? value) => new CreateObservabilityDestinationResponseData(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateObservabilityDestinationResponseData(
            global::OpenRouter.CreateObservabilityDestinationResponseDataDiscriminatorType? type,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1? arize,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2? braintrust,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3? clickhouse,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4? datadog,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5? grafana,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6? langfuse,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7? langsmith,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8? newrelic,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9? opik,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10? otelCollector,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11? posthog,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12? ramp,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13? s3,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14? sentry,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15? snowflake,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16? weave,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17? webhook
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
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1, TResult>? arize = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2, TResult>? braintrust = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3, TResult>? clickhouse = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4, TResult>? datadog = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5, TResult>? grafana = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6, TResult>? langfuse = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7, TResult>? langsmith = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8, TResult>? newrelic = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9, TResult>? opik = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10, TResult>? otelCollector = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11, TResult>? posthog = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12, TResult>? ramp = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13, TResult>? s3 = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14, TResult>? sentry = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15, TResult>? snowflake = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16, TResult>? weave = null,
            global::System.Func<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17, TResult>? webhook = null,
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
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1>? arize = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2>? braintrust = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3>? clickhouse = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4>? datadog = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5>? grafana = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6>? langfuse = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7>? langsmith = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8>? newrelic = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9>? opik = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10>? otelCollector = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11>? posthog = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12>? ramp = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13>? s3 = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14>? sentry = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15>? snowflake = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16>? weave = null,

            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17>? webhook = null,
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
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1>? arize = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2>? braintrust = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3>? clickhouse = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4>? datadog = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5>? grafana = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6>? langfuse = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7>? langsmith = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8>? newrelic = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9>? opik = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10>? otelCollector = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11>? posthog = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12>? ramp = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13>? s3 = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14>? sentry = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15>? snowflake = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16>? weave = null,
            global::System.Action<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17>? webhook = null,
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
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1),
                Braintrust,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2),
                Clickhouse,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3),
                Datadog,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4),
                Grafana,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5),
                Langfuse,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6),
                Langsmith,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7),
                Newrelic,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8),
                Opik,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9),
                OtelCollector,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10),
                Posthog,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11),
                Ramp,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12),
                S3,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13),
                Sentry,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14),
                Snowflake,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15),
                Weave,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16),
                Webhook,
                typeof(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17),
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
        public bool Equals(CreateObservabilityDestinationResponseData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant1?>.Default.Equals(Arize, other.Arize) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant2?>.Default.Equals(Braintrust, other.Braintrust) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant3?>.Default.Equals(Clickhouse, other.Clickhouse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant4?>.Default.Equals(Datadog, other.Datadog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant5?>.Default.Equals(Grafana, other.Grafana) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant6?>.Default.Equals(Langfuse, other.Langfuse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant7?>.Default.Equals(Langsmith, other.Langsmith) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant8?>.Default.Equals(Newrelic, other.Newrelic) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant9?>.Default.Equals(Opik, other.Opik) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant10?>.Default.Equals(OtelCollector, other.OtelCollector) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant11?>.Default.Equals(Posthog, other.Posthog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant12?>.Default.Equals(Ramp, other.Ramp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant13?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant14?>.Default.Equals(Sentry, other.Sentry) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant15?>.Default.Equals(Snowflake, other.Snowflake) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant16?>.Default.Equals(Weave, other.Weave) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17?>.Default.Equals(Webhook, other.Webhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateObservabilityDestinationResponseData obj1, CreateObservabilityDestinationResponseData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateObservabilityDestinationResponseData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateObservabilityDestinationResponseData obj1, CreateObservabilityDestinationResponseData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateObservabilityDestinationResponseData o && Equals(o);
        }
    }
}
