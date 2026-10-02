#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Langfuse","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"langfuse","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    public readonly partial struct ObservabilityDestination : global::System.IEquatable<ObservabilityDestination>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDestinationDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"arize_...AbCd","baseUrl":"https://otlp.arize.com","modelId":"openrouter-prod","spaceKey":"space_...EfGh"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Arize","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"arize","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityArizeDestination? Arize { get; init; }
#else
        public global::OpenRouter.ObservabilityArizeDestination? Arize { get; }
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
            out global::OpenRouter.ObservabilityArizeDestination? value)
        {
            value = Arize;
            return IsArize;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityArizeDestination PickArize() => Arize is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Arize' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"sk-...AbCd","baseUrl":"https://api.braintrust.dev","projectId":"proj_..."},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Braintrust","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"braintrust","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityBraintrustDestination? Braintrust { get; init; }
#else
        public global::OpenRouter.ObservabilityBraintrustDestination? Braintrust { get; }
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
            out global::OpenRouter.ObservabilityBraintrustDestination? value)
        {
            value = Braintrust;
            return IsBraintrust;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityBraintrustDestination PickBraintrust() => Braintrust is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Braintrust' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"database":"analytics","host":"https://clickhouse.example.com:8123","password":"********","table":"OPENROUTER_TRACES","username":"default"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production ClickHouse","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"clickhouse","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityClickhouseDestination? Clickhouse { get; init; }
#else
        public global::OpenRouter.ObservabilityClickhouseDestination? Clickhouse { get; }
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
            out global::OpenRouter.ObservabilityClickhouseDestination? value)
        {
            value = Clickhouse;
            return IsClickhouse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityClickhouseDestination PickClickhouse() => Clickhouse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Clickhouse' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"************...AbCd","mlApp":"my-llm-app","url":"https://api.datadoghq.com"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Datadog","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"datadog","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityDatadogDestination? Datadog { get; init; }
#else
        public global::OpenRouter.ObservabilityDatadogDestination? Datadog { get; }
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
            out global::OpenRouter.ObservabilityDatadogDestination? value)
        {
            value = Datadog;
            return IsDatadog;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityDatadogDestination PickDatadog() => Datadog is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Datadog' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"glc_...AbCd","baseUrl":"https://otlp-gateway-prod-us-west-0.grafana.net","instanceId":"123456"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Grafana","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"grafana","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityGrafanaDestination? Grafana { get; init; }
#else
        public global::OpenRouter.ObservabilityGrafanaDestination? Grafana { get; }
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
            out global::OpenRouter.ObservabilityGrafanaDestination? value)
        {
            value = Grafana;
            return IsGrafana;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityGrafanaDestination PickGrafana() => Grafana is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grafana' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Langfuse","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"langfuse","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityLangfuseDestination? Langfuse { get; init; }
#else
        public global::OpenRouter.ObservabilityLangfuseDestination? Langfuse { get; }
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
            out global::OpenRouter.ObservabilityLangfuseDestination? value)
        {
            value = Langfuse;
            return IsLangfuse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangfuseDestination PickLangfuse() => Langfuse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langfuse' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"lsv2_...AbCd","endpoint":"https://api.smith.langchain.com","project":"main"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production LangSmith","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"langsmith","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityLangsmithDestination? Langsmith { get; init; }
#else
        public global::OpenRouter.ObservabilityLangsmithDestination? Langsmith { get; }
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
            out global::OpenRouter.ObservabilityLangsmithDestination? value)
        {
            value = Langsmith;
            return IsLangsmith;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityLangsmithDestination PickLangsmith() => Langsmith is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langsmith' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"licenseKey":"****...AbCd","region":"us"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production New Relic","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"newrelic","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityNewrelicDestination? Newrelic { get; init; }
#else
        public global::OpenRouter.ObservabilityNewrelicDestination? Newrelic { get; }
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
            out global::OpenRouter.ObservabilityNewrelicDestination? value)
        {
            value = Newrelic;
            return IsNewrelic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityNewrelicDestination PickNewrelic() => Newrelic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Newrelic' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"****...AbCd","projectName":"openrouter-prod","workspace":"my-workspace"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Opik","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"opik","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityOpikDestination? Opik { get; init; }
#else
        public global::OpenRouter.ObservabilityOpikDestination? Opik { get; }
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
            out global::OpenRouter.ObservabilityOpikDestination? value)
        {
            value = Opik;
            return IsOpik;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOpikDestination PickOpik() => Opik is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Opik' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"endpoint":"https://otel.example.com:4318"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production OTel Collector","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"otel-collector","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityOtelCollectorDestination? OtelCollector { get; init; }
#else
        public global::OpenRouter.ObservabilityOtelCollectorDestination? OtelCollector { get; }
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
            out global::OpenRouter.ObservabilityOtelCollectorDestination? value)
        {
            value = OtelCollector;
            return IsOtelCollector;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityOtelCollectorDestination PickOtelCollector() => OtelCollector is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OtelCollector' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"phc_...AbCd","endpoint":"https://us.i.posthog.com"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production PostHog","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"posthog","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityPosthogDestination? Posthog { get; init; }
#else
        public global::OpenRouter.ObservabilityPosthogDestination? Posthog { get; }
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
            out global::OpenRouter.ObservabilityPosthogDestination? value)
        {
            value = Posthog;
            return IsPosthog;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityPosthogDestination PickPosthog() => Posthog is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Posthog' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"rmp_...AbCd","baseUrl":"https://api.ramp.com/developer/v1/ai-usage/openrouter"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Ramp","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"ramp","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityRampDestination? Ramp { get; init; }
#else
        public global::OpenRouter.ObservabilityRampDestination? Ramp { get; }
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
            out global::OpenRouter.ObservabilityRampDestination? value)
        {
            value = Ramp;
            return IsRamp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityRampDestination PickRamp() => Ramp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ramp' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"accessKeyId":"AKIA...AbCd","bucketName":"openrouter-traces","secretAccessKey":"****...EfGh"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production S3","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"s3","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityS3Destination? S3 { get; init; }
#else
        public global::OpenRouter.ObservabilityS3Destination? S3 { get; }
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
            out global::OpenRouter.ObservabilityS3Destination? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityS3Destination PickS3() => S3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"dsn":"https://abc123@o0.ingest.sentry.io/0","otlpEndpoint":"https://o0.ingest.sentry.io/api/0/otlp"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Sentry","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"sentry","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilitySentryDestination? Sentry { get; init; }
#else
        public global::OpenRouter.ObservabilitySentryDestination? Sentry { get; }
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
            out global::OpenRouter.ObservabilitySentryDestination? value)
        {
            value = Sentry;
            return IsSentry;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySentryDestination PickSentry() => Sentry is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sentry' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"account":"xy12345.us-east-1","token":"****...AbCd"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Snowflake","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"snowflake","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilitySnowflakeDestination? Snowflake { get; init; }
#else
        public global::OpenRouter.ObservabilitySnowflakeDestination? Snowflake { get; }
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
            out global::OpenRouter.ObservabilitySnowflakeDestination? value)
        {
            value = Snowflake;
            return IsSnowflake;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilitySnowflakeDestination PickSnowflake() => Snowflake is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Snowflake' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"apiKey":"****...AbCd","baseUrl":"https://trace.wandb.ai","entity":"my-team","project":"openrouter-prod"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Weave","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"weave","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityWeaveDestination? Weave { get; init; }
#else
        public global::OpenRouter.ObservabilityWeaveDestination? Weave { get; }
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
            out global::OpenRouter.ObservabilityWeaveDestination? value)
        {
            value = Weave;
            return IsWeave;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWeaveDestination PickWeave() => Weave is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Weave' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"api_key_hashes":null,"broadcast_generation_cost":false,"broadcast_generation_identity":false,"broadcast_generation_request_context":false,"config":{"url":"https://example.com/openrouter-events"},"created_at":"2025-08-24T10:30:00Z","enabled":true,"filter_rules":null,"id":"99999999-aaaa-bbbb-cccc-dddddddddddd","name":"Production Webhook","privacy_mode":false,"regions":["global"],"sampling_rate":1,"type":"webhook","updated_at":"2025-08-24T15:45:00Z","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ObservabilityWebhookDestination? Webhook { get; init; }
#else
        public global::OpenRouter.ObservabilityWebhookDestination? Webhook { get; }
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
            out global::OpenRouter.ObservabilityWebhookDestination? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ObservabilityWebhookDestination PickWebhook() => Webhook is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityArizeDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityArizeDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityArizeDestination?(ObservabilityDestination @this) => @this.Arize;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityArizeDestination? value)
        {
            Arize = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromArize(global::OpenRouter.ObservabilityArizeDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityBraintrustDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityBraintrustDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityBraintrustDestination?(ObservabilityDestination @this) => @this.Braintrust;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityBraintrustDestination? value)
        {
            Braintrust = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromBraintrust(global::OpenRouter.ObservabilityBraintrustDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityClickhouseDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityClickhouseDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityClickhouseDestination?(ObservabilityDestination @this) => @this.Clickhouse;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityClickhouseDestination? value)
        {
            Clickhouse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromClickhouse(global::OpenRouter.ObservabilityClickhouseDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityDatadogDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityDatadogDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityDatadogDestination?(ObservabilityDestination @this) => @this.Datadog;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityDatadogDestination? value)
        {
            Datadog = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromDatadog(global::OpenRouter.ObservabilityDatadogDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityGrafanaDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityGrafanaDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityGrafanaDestination?(ObservabilityDestination @this) => @this.Grafana;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityGrafanaDestination? value)
        {
            Grafana = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromGrafana(global::OpenRouter.ObservabilityGrafanaDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityLangfuseDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityLangfuseDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityLangfuseDestination?(ObservabilityDestination @this) => @this.Langfuse;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityLangfuseDestination? value)
        {
            Langfuse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromLangfuse(global::OpenRouter.ObservabilityLangfuseDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityLangsmithDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityLangsmithDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityLangsmithDestination?(ObservabilityDestination @this) => @this.Langsmith;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityLangsmithDestination? value)
        {
            Langsmith = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromLangsmith(global::OpenRouter.ObservabilityLangsmithDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityNewrelicDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityNewrelicDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityNewrelicDestination?(ObservabilityDestination @this) => @this.Newrelic;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityNewrelicDestination? value)
        {
            Newrelic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromNewrelic(global::OpenRouter.ObservabilityNewrelicDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityOpikDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityOpikDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityOpikDestination?(ObservabilityDestination @this) => @this.Opik;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityOpikDestination? value)
        {
            Opik = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromOpik(global::OpenRouter.ObservabilityOpikDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityOtelCollectorDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityOtelCollectorDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityOtelCollectorDestination?(ObservabilityDestination @this) => @this.OtelCollector;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityOtelCollectorDestination? value)
        {
            OtelCollector = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromOtelCollector(global::OpenRouter.ObservabilityOtelCollectorDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityPosthogDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityPosthogDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityPosthogDestination?(ObservabilityDestination @this) => @this.Posthog;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityPosthogDestination? value)
        {
            Posthog = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromPosthog(global::OpenRouter.ObservabilityPosthogDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityRampDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityRampDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityRampDestination?(ObservabilityDestination @this) => @this.Ramp;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityRampDestination? value)
        {
            Ramp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromRamp(global::OpenRouter.ObservabilityRampDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityS3Destination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityS3Destination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityS3Destination?(ObservabilityDestination @this) => @this.S3;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityS3Destination? value)
        {
            S3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromS3(global::OpenRouter.ObservabilityS3Destination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilitySentryDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilitySentryDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilitySentryDestination?(ObservabilityDestination @this) => @this.Sentry;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilitySentryDestination? value)
        {
            Sentry = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromSentry(global::OpenRouter.ObservabilitySentryDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilitySnowflakeDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilitySnowflakeDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilitySnowflakeDestination?(ObservabilityDestination @this) => @this.Snowflake;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilitySnowflakeDestination? value)
        {
            Snowflake = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromSnowflake(global::OpenRouter.ObservabilitySnowflakeDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityWeaveDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityWeaveDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityWeaveDestination?(ObservabilityDestination @this) => @this.Weave;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityWeaveDestination? value)
        {
            Weave = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromWeave(global::OpenRouter.ObservabilityWeaveDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ObservabilityDestination(global::OpenRouter.ObservabilityWebhookDestination value) => new ObservabilityDestination((global::OpenRouter.ObservabilityWebhookDestination?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ObservabilityWebhookDestination?(ObservabilityDestination @this) => @this.Webhook;

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(global::OpenRouter.ObservabilityWebhookDestination? value)
        {
            Webhook = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityDestination FromWebhook(global::OpenRouter.ObservabilityWebhookDestination? value) => new ObservabilityDestination(value);

        /// <summary>
        ///
        /// </summary>
        public ObservabilityDestination(
            global::OpenRouter.ObservabilityDestinationDiscriminatorType? type,
            global::OpenRouter.ObservabilityArizeDestination? arize,
            global::OpenRouter.ObservabilityBraintrustDestination? braintrust,
            global::OpenRouter.ObservabilityClickhouseDestination? clickhouse,
            global::OpenRouter.ObservabilityDatadogDestination? datadog,
            global::OpenRouter.ObservabilityGrafanaDestination? grafana,
            global::OpenRouter.ObservabilityLangfuseDestination? langfuse,
            global::OpenRouter.ObservabilityLangsmithDestination? langsmith,
            global::OpenRouter.ObservabilityNewrelicDestination? newrelic,
            global::OpenRouter.ObservabilityOpikDestination? opik,
            global::OpenRouter.ObservabilityOtelCollectorDestination? otelCollector,
            global::OpenRouter.ObservabilityPosthogDestination? posthog,
            global::OpenRouter.ObservabilityRampDestination? ramp,
            global::OpenRouter.ObservabilityS3Destination? s3,
            global::OpenRouter.ObservabilitySentryDestination? sentry,
            global::OpenRouter.ObservabilitySnowflakeDestination? snowflake,
            global::OpenRouter.ObservabilityWeaveDestination? weave,
            global::OpenRouter.ObservabilityWebhookDestination? webhook
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
            global::System.Func<global::OpenRouter.ObservabilityArizeDestination, TResult>? arize = null,
            global::System.Func<global::OpenRouter.ObservabilityBraintrustDestination, TResult>? braintrust = null,
            global::System.Func<global::OpenRouter.ObservabilityClickhouseDestination, TResult>? clickhouse = null,
            global::System.Func<global::OpenRouter.ObservabilityDatadogDestination, TResult>? datadog = null,
            global::System.Func<global::OpenRouter.ObservabilityGrafanaDestination, TResult>? grafana = null,
            global::System.Func<global::OpenRouter.ObservabilityLangfuseDestination, TResult>? langfuse = null,
            global::System.Func<global::OpenRouter.ObservabilityLangsmithDestination, TResult>? langsmith = null,
            global::System.Func<global::OpenRouter.ObservabilityNewrelicDestination, TResult>? newrelic = null,
            global::System.Func<global::OpenRouter.ObservabilityOpikDestination, TResult>? opik = null,
            global::System.Func<global::OpenRouter.ObservabilityOtelCollectorDestination, TResult>? otelCollector = null,
            global::System.Func<global::OpenRouter.ObservabilityPosthogDestination, TResult>? posthog = null,
            global::System.Func<global::OpenRouter.ObservabilityRampDestination, TResult>? ramp = null,
            global::System.Func<global::OpenRouter.ObservabilityS3Destination, TResult>? s3 = null,
            global::System.Func<global::OpenRouter.ObservabilitySentryDestination, TResult>? sentry = null,
            global::System.Func<global::OpenRouter.ObservabilitySnowflakeDestination, TResult>? snowflake = null,
            global::System.Func<global::OpenRouter.ObservabilityWeaveDestination, TResult>? weave = null,
            global::System.Func<global::OpenRouter.ObservabilityWebhookDestination, TResult>? webhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Arize is { } __value0 && arize != null)
            {
                return arize(__value0);
            }
            else if (Braintrust is { } __value1 && braintrust != null)
            {
                return braintrust(__value1);
            }
            else if (Clickhouse is { } __value2 && clickhouse != null)
            {
                return clickhouse(__value2);
            }
            else if (Datadog is { } __value3 && datadog != null)
            {
                return datadog(__value3);
            }
            else if (Grafana is { } __value4 && grafana != null)
            {
                return grafana(__value4);
            }
            else if (Langfuse is { } __value5 && langfuse != null)
            {
                return langfuse(__value5);
            }
            else if (Langsmith is { } __value6 && langsmith != null)
            {
                return langsmith(__value6);
            }
            else if (Newrelic is { } __value7 && newrelic != null)
            {
                return newrelic(__value7);
            }
            else if (Opik is { } __value8 && opik != null)
            {
                return opik(__value8);
            }
            else if (OtelCollector is { } __value9 && otelCollector != null)
            {
                return otelCollector(__value9);
            }
            else if (Posthog is { } __value10 && posthog != null)
            {
                return posthog(__value10);
            }
            else if (Ramp is { } __value11 && ramp != null)
            {
                return ramp(__value11);
            }
            else if (S3 is { } __value12 && s3 != null)
            {
                return s3(__value12);
            }
            else if (Sentry is { } __value13 && sentry != null)
            {
                return sentry(__value13);
            }
            else if (Snowflake is { } __value14 && snowflake != null)
            {
                return snowflake(__value14);
            }
            else if (Weave is { } __value15 && weave != null)
            {
                return weave(__value15);
            }
            else if (Webhook is { } __value16 && webhook != null)
            {
                return webhook(__value16);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ObservabilityArizeDestination>? arize = null,

            global::System.Action<global::OpenRouter.ObservabilityBraintrustDestination>? braintrust = null,

            global::System.Action<global::OpenRouter.ObservabilityClickhouseDestination>? clickhouse = null,

            global::System.Action<global::OpenRouter.ObservabilityDatadogDestination>? datadog = null,

            global::System.Action<global::OpenRouter.ObservabilityGrafanaDestination>? grafana = null,

            global::System.Action<global::OpenRouter.ObservabilityLangfuseDestination>? langfuse = null,

            global::System.Action<global::OpenRouter.ObservabilityLangsmithDestination>? langsmith = null,

            global::System.Action<global::OpenRouter.ObservabilityNewrelicDestination>? newrelic = null,

            global::System.Action<global::OpenRouter.ObservabilityOpikDestination>? opik = null,

            global::System.Action<global::OpenRouter.ObservabilityOtelCollectorDestination>? otelCollector = null,

            global::System.Action<global::OpenRouter.ObservabilityPosthogDestination>? posthog = null,

            global::System.Action<global::OpenRouter.ObservabilityRampDestination>? ramp = null,

            global::System.Action<global::OpenRouter.ObservabilityS3Destination>? s3 = null,

            global::System.Action<global::OpenRouter.ObservabilitySentryDestination>? sentry = null,

            global::System.Action<global::OpenRouter.ObservabilitySnowflakeDestination>? snowflake = null,

            global::System.Action<global::OpenRouter.ObservabilityWeaveDestination>? weave = null,

            global::System.Action<global::OpenRouter.ObservabilityWebhookDestination>? webhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Arize is { } __value0)
            {
                arize?.Invoke(__value0);
            }
            else if (Braintrust is { } __value1)
            {
                braintrust?.Invoke(__value1);
            }
            else if (Clickhouse is { } __value2)
            {
                clickhouse?.Invoke(__value2);
            }
            else if (Datadog is { } __value3)
            {
                datadog?.Invoke(__value3);
            }
            else if (Grafana is { } __value4)
            {
                grafana?.Invoke(__value4);
            }
            else if (Langfuse is { } __value5)
            {
                langfuse?.Invoke(__value5);
            }
            else if (Langsmith is { } __value6)
            {
                langsmith?.Invoke(__value6);
            }
            else if (Newrelic is { } __value7)
            {
                newrelic?.Invoke(__value7);
            }
            else if (Opik is { } __value8)
            {
                opik?.Invoke(__value8);
            }
            else if (OtelCollector is { } __value9)
            {
                otelCollector?.Invoke(__value9);
            }
            else if (Posthog is { } __value10)
            {
                posthog?.Invoke(__value10);
            }
            else if (Ramp is { } __value11)
            {
                ramp?.Invoke(__value11);
            }
            else if (S3 is { } __value12)
            {
                s3?.Invoke(__value12);
            }
            else if (Sentry is { } __value13)
            {
                sentry?.Invoke(__value13);
            }
            else if (Snowflake is { } __value14)
            {
                snowflake?.Invoke(__value14);
            }
            else if (Weave is { } __value15)
            {
                weave?.Invoke(__value15);
            }
            else if (Webhook is { } __value16)
            {
                webhook?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ObservabilityArizeDestination>? arize = null,
            global::System.Action<global::OpenRouter.ObservabilityBraintrustDestination>? braintrust = null,
            global::System.Action<global::OpenRouter.ObservabilityClickhouseDestination>? clickhouse = null,
            global::System.Action<global::OpenRouter.ObservabilityDatadogDestination>? datadog = null,
            global::System.Action<global::OpenRouter.ObservabilityGrafanaDestination>? grafana = null,
            global::System.Action<global::OpenRouter.ObservabilityLangfuseDestination>? langfuse = null,
            global::System.Action<global::OpenRouter.ObservabilityLangsmithDestination>? langsmith = null,
            global::System.Action<global::OpenRouter.ObservabilityNewrelicDestination>? newrelic = null,
            global::System.Action<global::OpenRouter.ObservabilityOpikDestination>? opik = null,
            global::System.Action<global::OpenRouter.ObservabilityOtelCollectorDestination>? otelCollector = null,
            global::System.Action<global::OpenRouter.ObservabilityPosthogDestination>? posthog = null,
            global::System.Action<global::OpenRouter.ObservabilityRampDestination>? ramp = null,
            global::System.Action<global::OpenRouter.ObservabilityS3Destination>? s3 = null,
            global::System.Action<global::OpenRouter.ObservabilitySentryDestination>? sentry = null,
            global::System.Action<global::OpenRouter.ObservabilitySnowflakeDestination>? snowflake = null,
            global::System.Action<global::OpenRouter.ObservabilityWeaveDestination>? weave = null,
            global::System.Action<global::OpenRouter.ObservabilityWebhookDestination>? webhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Arize is { } __value0)
            {
                arize?.Invoke(__value0);
            }
            else if (Braintrust is { } __value1)
            {
                braintrust?.Invoke(__value1);
            }
            else if (Clickhouse is { } __value2)
            {
                clickhouse?.Invoke(__value2);
            }
            else if (Datadog is { } __value3)
            {
                datadog?.Invoke(__value3);
            }
            else if (Grafana is { } __value4)
            {
                grafana?.Invoke(__value4);
            }
            else if (Langfuse is { } __value5)
            {
                langfuse?.Invoke(__value5);
            }
            else if (Langsmith is { } __value6)
            {
                langsmith?.Invoke(__value6);
            }
            else if (Newrelic is { } __value7)
            {
                newrelic?.Invoke(__value7);
            }
            else if (Opik is { } __value8)
            {
                opik?.Invoke(__value8);
            }
            else if (OtelCollector is { } __value9)
            {
                otelCollector?.Invoke(__value9);
            }
            else if (Posthog is { } __value10)
            {
                posthog?.Invoke(__value10);
            }
            else if (Ramp is { } __value11)
            {
                ramp?.Invoke(__value11);
            }
            else if (S3 is { } __value12)
            {
                s3?.Invoke(__value12);
            }
            else if (Sentry is { } __value13)
            {
                sentry?.Invoke(__value13);
            }
            else if (Snowflake is { } __value14)
            {
                snowflake?.Invoke(__value14);
            }
            else if (Weave is { } __value15)
            {
                weave?.Invoke(__value15);
            }
            else if (Webhook is { } __value16)
            {
                webhook?.Invoke(__value16);
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
                typeof(global::OpenRouter.ObservabilityArizeDestination),
                Braintrust,
                typeof(global::OpenRouter.ObservabilityBraintrustDestination),
                Clickhouse,
                typeof(global::OpenRouter.ObservabilityClickhouseDestination),
                Datadog,
                typeof(global::OpenRouter.ObservabilityDatadogDestination),
                Grafana,
                typeof(global::OpenRouter.ObservabilityGrafanaDestination),
                Langfuse,
                typeof(global::OpenRouter.ObservabilityLangfuseDestination),
                Langsmith,
                typeof(global::OpenRouter.ObservabilityLangsmithDestination),
                Newrelic,
                typeof(global::OpenRouter.ObservabilityNewrelicDestination),
                Opik,
                typeof(global::OpenRouter.ObservabilityOpikDestination),
                OtelCollector,
                typeof(global::OpenRouter.ObservabilityOtelCollectorDestination),
                Posthog,
                typeof(global::OpenRouter.ObservabilityPosthogDestination),
                Ramp,
                typeof(global::OpenRouter.ObservabilityRampDestination),
                S3,
                typeof(global::OpenRouter.ObservabilityS3Destination),
                Sentry,
                typeof(global::OpenRouter.ObservabilitySentryDestination),
                Snowflake,
                typeof(global::OpenRouter.ObservabilitySnowflakeDestination),
                Weave,
                typeof(global::OpenRouter.ObservabilityWeaveDestination),
                Webhook,
                typeof(global::OpenRouter.ObservabilityWebhookDestination),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityArizeDestination?>.Default.Equals(Arize, other.Arize) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityBraintrustDestination?>.Default.Equals(Braintrust, other.Braintrust) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityClickhouseDestination?>.Default.Equals(Clickhouse, other.Clickhouse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityDatadogDestination?>.Default.Equals(Datadog, other.Datadog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityGrafanaDestination?>.Default.Equals(Grafana, other.Grafana) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityLangfuseDestination?>.Default.Equals(Langfuse, other.Langfuse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityLangsmithDestination?>.Default.Equals(Langsmith, other.Langsmith) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityNewrelicDestination?>.Default.Equals(Newrelic, other.Newrelic) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityOpikDestination?>.Default.Equals(Opik, other.Opik) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityOtelCollectorDestination?>.Default.Equals(OtelCollector, other.OtelCollector) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityPosthogDestination?>.Default.Equals(Posthog, other.Posthog) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityRampDestination?>.Default.Equals(Ramp, other.Ramp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityS3Destination?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilitySentryDestination?>.Default.Equals(Sentry, other.Sentry) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilitySnowflakeDestination?>.Default.Equals(Snowflake, other.Snowflake) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityWeaveDestination?>.Default.Equals(Weave, other.Weave) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ObservabilityWebhookDestination?>.Default.Equals(Webhook, other.Webhook)
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
