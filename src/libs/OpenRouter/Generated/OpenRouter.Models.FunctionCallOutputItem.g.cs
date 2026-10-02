#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The output from a function call execution<br/>
    /// Example: {"call_id":"call-abc123","id":"output-abc123","output":"{\u0022temperature\u0022:72,\u0022conditions\u0022:\u0022sunny\u0022}","status":"completed","type":"function_call_output"}
    /// </summary>
    public readonly partial struct FunctionCallOutputItem : global::System.IEquatable<FunctionCallOutputItem>
    {
        /// <summary>
        /// Example: {"call_id":"call-abc123","output":"{\u0022temperature\u0022:72,\u0022conditions\u0022:\u0022sunny\u0022}","type":"function_call_output"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? OpenAIResponseTool { get; init; }
#else
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? OpenAIResponseTool { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponseTool))]
#endif
        public bool IsOpenAIResponseTool => OpenAIResponseTool != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponseTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponseFunctionToolCallOutput? value)
        {
            value = OpenAIResponseTool;
            return IsOpenAIResponseTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput PickOpenAIResponseTool() => OpenAIResponseTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponseTool' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallOutputItemVariant2? FunctionCallOutputItemVariant2 { get; init; }
#else
        public global::OpenRouter.FunctionCallOutputItemVariant2? FunctionCallOutputItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItemVariant2))]
#endif
        public bool IsFunctionCallOutputItemVariant2 => FunctionCallOutputItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutputItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FunctionCallOutputItemVariant2? value)
        {
            value = FunctionCallOutputItemVariant2;
            return IsFunctionCallOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItemVariant2 PickFunctionCallOutputItemVariant2() => FunctionCallOutputItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionCallOutputItem(global::OpenRouter.OpenAIResponseFunctionToolCallOutput value) => new FunctionCallOutputItem((global::OpenRouter.OpenAIResponseFunctionToolCallOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponseFunctionToolCallOutput?(FunctionCallOutputItem @this) => @this.OpenAIResponseTool;

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputItem(global::OpenRouter.OpenAIResponseFunctionToolCallOutput? value)
        {
            OpenAIResponseTool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionCallOutputItem FromOpenAIResponseTool(global::OpenRouter.OpenAIResponseFunctionToolCallOutput? value) => new FunctionCallOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionCallOutputItem(global::OpenRouter.FunctionCallOutputItemVariant2 value) => new FunctionCallOutputItem((global::OpenRouter.FunctionCallOutputItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallOutputItemVariant2?(FunctionCallOutputItem @this) => @this.FunctionCallOutputItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputItem(global::OpenRouter.FunctionCallOutputItemVariant2? value)
        {
            FunctionCallOutputItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionCallOutputItem FromFunctionCallOutputItemVariant2(global::OpenRouter.FunctionCallOutputItemVariant2? value) => new FunctionCallOutputItem(value);

        /// <summary>
        ///
        /// </summary>
        public FunctionCallOutputItem(
            global::OpenRouter.OpenAIResponseFunctionToolCallOutput? openAIResponseTool,
            global::OpenRouter.FunctionCallOutputItemVariant2? functionCallOutputItemVariant2
            )
        {
            OpenAIResponseTool = openAIResponseTool;
            FunctionCallOutputItemVariant2 = functionCallOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallOutputItemVariant2 as object ??
            OpenAIResponseTool as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponseTool?.ToString() ??
            FunctionCallOutputItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponseTool && IsFunctionCallOutputItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponseFunctionToolCallOutput, TResult>? openAIResponseTool = null,
            global::System.Func<global::OpenRouter.FunctionCallOutputItemVariant2, TResult>? functionCallOutputItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponseTool is { } __value0 && openAIResponseTool != null)
            {
                return openAIResponseTool(__value0);
            }
            else if (FunctionCallOutputItemVariant2 is { } __value1 && functionCallOutputItemVariant2 != null)
            {
                return functionCallOutputItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponseFunctionToolCallOutput>? openAIResponseTool = null,

            global::System.Action<global::OpenRouter.FunctionCallOutputItemVariant2>? functionCallOutputItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponseTool is { } __value0)
            {
                openAIResponseTool?.Invoke(__value0);
            }
            else if (FunctionCallOutputItemVariant2 is { } __value1)
            {
                functionCallOutputItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponseFunctionToolCallOutput>? openAIResponseTool = null,
            global::System.Action<global::OpenRouter.FunctionCallOutputItemVariant2>? functionCallOutputItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponseTool is { } __value0)
            {
                openAIResponseTool?.Invoke(__value0);
            }
            else if (FunctionCallOutputItemVariant2 is { } __value1)
            {
                functionCallOutputItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIResponseTool,
                typeof(global::OpenRouter.OpenAIResponseFunctionToolCallOutput),
                FunctionCallOutputItemVariant2,
                typeof(global::OpenRouter.FunctionCallOutputItemVariant2),
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
        public bool Equals(FunctionCallOutputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponseFunctionToolCallOutput?>.Default.Equals(OpenAIResponseTool, other.OpenAIResponseTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallOutputItemVariant2?>.Default.Equals(FunctionCallOutputItemVariant2, other.FunctionCallOutputItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FunctionCallOutputItem obj1, FunctionCallOutputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallOutputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FunctionCallOutputItem obj1, FunctionCallOutputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallOutputItem o && Equals(o);
        }
    }
}
