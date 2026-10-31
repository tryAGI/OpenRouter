#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An endpoint whose data policy does not retain prompts by default<br/>
    /// Example: {"context_length":1048576,"latency_last_30m":null,"max_completion_tokens":65535,"max_prompt_tokens":null,"model_id":"google/gemini-2.5-flash","model_name":"Gemini 2.5 Flash","name":"Google: Gemini 2.5 Flash","native_tools":{},"pricing":{"completion":"0.0000025","image":"0","prompt":"0.0000003","request":"0"},"provider_name":"Google","quantization":null,"safety_retention":true,"service_tier":null,"status":0,"supported_parameters":["temperature","top_p","max_tokens"],"supports_diarization":false,"supports_image_reference":false,"supports_implicit_caching":true,"supports_multiple_audio_references":false,"supports_tool_choice":{"auto":true,"function":true,"none":true,"required":true},"supports_voice_cloning":false,"tag":"google-vertex","throughput_last_30m":null,"uptime_last_1d":99.8,"uptime_last_30m":99.5,"uptime_last_5m":100}
    /// </summary>
    public readonly partial struct PublicZdrEndpoint : global::System.IEquatable<PublicZdrEndpoint>
    {
        /// <summary>
        /// Information about a specific model endpoint<br/>
        /// Example: {"context_length":8192,"latency_last_30m":{"p50":0.25,"p75":0.35,"p90":0.48,"p99":0.85},"max_completion_tokens":4096,"max_prompt_tokens":8192,"model_id":"openai/gpt-4","model_name":"GPT-4","name":"OpenAI: GPT-4","native_tools":{"openrouter:web_search":{"type":"web_search_20260209"}},"perf_last_30m_by_workload":{"text_generation":{"latency":{"p50":250,"p75":350,"p90":480,"p99":850},"request_count":1000,"throughput":{"p50":45.2,"p75":38.5,"p90":28.3,"p99":15.1}}},"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"provider_name":"OpenAI","quantization":"fp16","service_tier":null,"status":0,"supported_parameters":["temperature","top_p","max_tokens"],"supports_diarization":false,"supports_image_reference":false,"supports_implicit_caching":true,"supports_multiple_audio_references":false,"supports_tool_choice":{"auto":true,"function":true,"none":true,"required":true},"supports_voice_cloning":false,"tag":"openai","throughput_last_30m":{"p50":45.2,"p75":38.5,"p90":28.3,"p99":15.1},"uptime_last_1d":99.8,"uptime_last_30m":99.5,"uptime_last_5m":100}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PublicEndpoint? PublicEndpoint { get; init; }
#else
        public global::OpenRouter.PublicEndpoint? PublicEndpoint { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicEndpoint))]
#endif
        public bool IsPublicEndpoint => PublicEndpoint != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicEndpoint(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PublicEndpoint? value)
        {
            value = PublicEndpoint;
            return IsPublicEndpoint;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicEndpoint PickPublicEndpoint() => PublicEndpoint is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicEndpoint' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PublicZdrEndpointVariant2? PublicZdrEndpointVariant2 { get; init; }
#else
        public global::OpenRouter.PublicZdrEndpointVariant2? PublicZdrEndpointVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PublicZdrEndpointVariant2))]
#endif
        public bool IsPublicZdrEndpointVariant2 => PublicZdrEndpointVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPublicZdrEndpointVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PublicZdrEndpointVariant2? value)
        {
            value = PublicZdrEndpointVariant2;
            return IsPublicZdrEndpointVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PublicZdrEndpointVariant2 PickPublicZdrEndpointVariant2() => PublicZdrEndpointVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PublicZdrEndpointVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PublicZdrEndpoint(global::OpenRouter.PublicEndpoint value) => new PublicZdrEndpoint((global::OpenRouter.PublicEndpoint?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PublicEndpoint?(PublicZdrEndpoint @this) => @this.PublicEndpoint;

        /// <summary>
        ///
        /// </summary>
        public PublicZdrEndpoint(global::OpenRouter.PublicEndpoint? value)
        {
            PublicEndpoint = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PublicZdrEndpoint FromPublicEndpoint(global::OpenRouter.PublicEndpoint? value) => new PublicZdrEndpoint(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PublicZdrEndpoint(global::OpenRouter.PublicZdrEndpointVariant2 value) => new PublicZdrEndpoint((global::OpenRouter.PublicZdrEndpointVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PublicZdrEndpointVariant2?(PublicZdrEndpoint @this) => @this.PublicZdrEndpointVariant2;

        /// <summary>
        ///
        /// </summary>
        public PublicZdrEndpoint(global::OpenRouter.PublicZdrEndpointVariant2? value)
        {
            PublicZdrEndpointVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PublicZdrEndpoint FromPublicZdrEndpointVariant2(global::OpenRouter.PublicZdrEndpointVariant2? value) => new PublicZdrEndpoint(value);

        /// <summary>
        ///
        /// </summary>
        public PublicZdrEndpoint(
            global::OpenRouter.PublicEndpoint? publicEndpoint,
            global::OpenRouter.PublicZdrEndpointVariant2? publicZdrEndpointVariant2
            )
        {
            PublicEndpoint = publicEndpoint;
            PublicZdrEndpointVariant2 = publicZdrEndpointVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PublicZdrEndpointVariant2 as object ??
            PublicEndpoint as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PublicEndpoint?.ToString() ??
            PublicZdrEndpointVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPublicEndpoint && IsPublicZdrEndpointVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.PublicEndpoint, TResult>? publicEndpoint = null,
            global::System.Func<global::OpenRouter.PublicZdrEndpointVariant2, TResult>? publicZdrEndpointVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PublicEndpoint is { } __value0 && publicEndpoint != null)
            {
                return publicEndpoint(__value0);
            }
            else if (PublicZdrEndpointVariant2 is { } __value1 && publicZdrEndpointVariant2 != null)
            {
                return publicZdrEndpointVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.PublicEndpoint>? publicEndpoint = null,

            global::System.Action<global::OpenRouter.PublicZdrEndpointVariant2>? publicZdrEndpointVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PublicEndpoint is { } __value0)
            {
                publicEndpoint?.Invoke(__value0);
            }
            else if (PublicZdrEndpointVariant2 is { } __value1)
            {
                publicZdrEndpointVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.PublicEndpoint>? publicEndpoint = null,
            global::System.Action<global::OpenRouter.PublicZdrEndpointVariant2>? publicZdrEndpointVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PublicEndpoint is { } __value0)
            {
                publicEndpoint?.Invoke(__value0);
            }
            else if (PublicZdrEndpointVariant2 is { } __value1)
            {
                publicZdrEndpointVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PublicEndpoint,
                typeof(global::OpenRouter.PublicEndpoint),
                PublicZdrEndpointVariant2,
                typeof(global::OpenRouter.PublicZdrEndpointVariant2),
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
        public bool Equals(PublicZdrEndpoint other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PublicEndpoint?>.Default.Equals(PublicEndpoint, other.PublicEndpoint) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PublicZdrEndpointVariant2?>.Default.Equals(PublicZdrEndpointVariant2, other.PublicZdrEndpointVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PublicZdrEndpoint obj1, PublicZdrEndpoint obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PublicZdrEndpoint>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PublicZdrEndpoint obj1, PublicZdrEndpoint obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PublicZdrEndpoint o && Equals(o);
        }
    }
}
