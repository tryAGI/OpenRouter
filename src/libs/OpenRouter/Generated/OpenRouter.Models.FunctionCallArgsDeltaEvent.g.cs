#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when function call arguments are being streamed<br/>
    /// Example: {"delta":"{\u0022city\u0022: \u0022...\u0022}","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.function_call_arguments.delta"}
    /// </summary>
    public readonly partial struct FunctionCallArgsDeltaEvent : global::System.IEquatable<FunctionCallArgsDeltaEvent>
    {
        /// <summary>
        /// Event emitted when function call arguments are being streamed<br/>
        /// Example: {"delta":"{\u0022city\u0022: \u0022...\u0022}","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.function_call_arguments.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseFunctionCallArgsDeltaEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseFunctionCallArgsDeltaEvent? Base { get; }
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
            out global::OpenRouter.BaseFunctionCallArgsDeltaEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDeltaEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FunctionCallArgsDeltaEventVariant2 { get; init; }
#else
        public object? FunctionCallArgsDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallArgsDeltaEventVariant2))]
#endif
        public bool IsFunctionCallArgsDeltaEventVariant2 => FunctionCallArgsDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallArgsDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FunctionCallArgsDeltaEventVariant2;
            return IsFunctionCallArgsDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickFunctionCallArgsDeltaEventVariant2() => FunctionCallArgsDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallArgsDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionCallArgsDeltaEvent(global::OpenRouter.BaseFunctionCallArgsDeltaEvent value) => new FunctionCallArgsDeltaEvent((global::OpenRouter.BaseFunctionCallArgsDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseFunctionCallArgsDeltaEvent?(FunctionCallArgsDeltaEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public FunctionCallArgsDeltaEvent(global::OpenRouter.BaseFunctionCallArgsDeltaEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionCallArgsDeltaEvent FromBase(global::OpenRouter.BaseFunctionCallArgsDeltaEvent? value) => new FunctionCallArgsDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public FunctionCallArgsDeltaEvent(
            global::OpenRouter.BaseFunctionCallArgsDeltaEvent? @base,
            object? functionCallArgsDeltaEventVariant2
            )
        {
            Base = @base;
            FunctionCallArgsDeltaEventVariant2 = functionCallArgsDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallArgsDeltaEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FunctionCallArgsDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsFunctionCallArgsDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseFunctionCallArgsDeltaEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? functionCallArgsDeltaEventVariant2 = null,
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
            else if (FunctionCallArgsDeltaEventVariant2 is { } __value1 && functionCallArgsDeltaEventVariant2 != null)
            {
                return functionCallArgsDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseFunctionCallArgsDeltaEvent>? @base = null,

            global::System.Action<object>? functionCallArgsDeltaEventVariant2 = null,
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
            else if (FunctionCallArgsDeltaEventVariant2 is { } __value1)
            {
                functionCallArgsDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseFunctionCallArgsDeltaEvent>? @base = null,
            global::System.Action<object>? functionCallArgsDeltaEventVariant2 = null,
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
            else if (FunctionCallArgsDeltaEventVariant2 is { } __value1)
            {
                functionCallArgsDeltaEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseFunctionCallArgsDeltaEvent),
                FunctionCallArgsDeltaEventVariant2,
                typeof(object),
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
        public bool Equals(FunctionCallArgsDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseFunctionCallArgsDeltaEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FunctionCallArgsDeltaEventVariant2, other.FunctionCallArgsDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FunctionCallArgsDeltaEvent obj1, FunctionCallArgsDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallArgsDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FunctionCallArgsDeltaEvent obj1, FunctionCallArgsDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallArgsDeltaEvent o && Equals(o);
        }
    }
}
