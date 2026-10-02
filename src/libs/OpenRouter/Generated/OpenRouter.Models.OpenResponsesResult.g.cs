#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Complete non-streaming response from the Responses API<br/>
    /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[{"content":[{"annotations":[],"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null,"usage":{"input_tokens":10,"input_tokens_details":{"cached_tokens":0},"output_tokens":25,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":35}}
    /// </summary>
    public readonly partial struct OpenResponsesResult : global::System.IEquatable<OpenResponsesResult>
    {
        /// <summary>
        /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseResponsesResult? Base { get; init; }
#else
        public global::OpenRouter.BaseResponsesResult? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BaseResponsesResult? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseResponsesResult PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesResultVariant2? OpenResponsesResultVariant2 { get; init; }
#else
        public global::OpenRouter.OpenResponsesResultVariant2? OpenResponsesResultVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenResponsesResultVariant2))]
#endif
        public bool IsOpenResponsesResultVariant2 => OpenResponsesResultVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenResponsesResultVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesResultVariant2? value)
        {
            value = OpenResponsesResultVariant2;
            return IsOpenResponsesResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesResultVariant2 PickOpenResponsesResultVariant2() => OpenResponsesResultVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenResponsesResultVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenResponsesResult(global::OpenRouter.BaseResponsesResult value) => new OpenResponsesResult((global::OpenRouter.BaseResponsesResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseResponsesResult?(OpenResponsesResult @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesResult(global::OpenRouter.BaseResponsesResult? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesResult FromBase(global::OpenRouter.BaseResponsesResult? value) => new OpenResponsesResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenResponsesResult(global::OpenRouter.OpenResponsesResultVariant2 value) => new OpenResponsesResult((global::OpenRouter.OpenResponsesResultVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesResultVariant2?(OpenResponsesResult @this) => @this.OpenResponsesResultVariant2;

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesResult(global::OpenRouter.OpenResponsesResultVariant2? value)
        {
            OpenResponsesResultVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesResult FromOpenResponsesResultVariant2(global::OpenRouter.OpenResponsesResultVariant2? value) => new OpenResponsesResult(value);

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesResult(
            global::OpenRouter.BaseResponsesResult? @base,
            global::OpenRouter.OpenResponsesResultVariant2? openResponsesResultVariant2
            )
        {
            Base = @base;
            OpenResponsesResultVariant2 = openResponsesResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenResponsesResultVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            OpenResponsesResultVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsOpenResponsesResultVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseResponsesResult, TResult>? @base = null,
            global::System.Func<global::OpenRouter.OpenResponsesResultVariant2, TResult>? openResponsesResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (OpenResponsesResultVariant2 is { } __value1 && openResponsesResultVariant2 != null)
            {
                return openResponsesResultVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseResponsesResult>? @base = null,

            global::System.Action<global::OpenRouter.OpenResponsesResultVariant2>? openResponsesResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (OpenResponsesResultVariant2 is { } __value1)
            {
                openResponsesResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseResponsesResult>? @base = null,
            global::System.Action<global::OpenRouter.OpenResponsesResultVariant2>? openResponsesResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (OpenResponsesResultVariant2 is { } __value1)
            {
                openResponsesResultVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::OpenRouter.BaseResponsesResult),
                OpenResponsesResultVariant2,
                typeof(global::OpenRouter.OpenResponsesResultVariant2),
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
        public bool Equals(OpenResponsesResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseResponsesResult?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesResultVariant2?>.Default.Equals(OpenResponsesResultVariant2, other.OpenResponsesResultVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OpenResponsesResult obj1, OpenResponsesResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenResponsesResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenResponsesResult obj1, OpenResponsesResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenResponsesResult o && Equals(o);
        }
    }
}
