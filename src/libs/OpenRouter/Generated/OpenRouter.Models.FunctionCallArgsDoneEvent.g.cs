#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when function call arguments streaming is complete<br/>
    /// Example: {"arguments":"{\u0022city\u0022: \u0022San Francisco\u0022, \u0022units\u0022: \u0022celsius\u0022}","item_id":"item-1","name":"get_weather","output_index":0,"sequence_number":6,"type":"response.function_call_arguments.done"}
    /// </summary>
    public readonly partial struct FunctionCallArgsDoneEvent : global::System.IEquatable<FunctionCallArgsDoneEvent>
    {
        /// <summary>
        /// Event emitted when function call arguments streaming is complete<br/>
        /// Example: {"arguments":"{\u0022city\u0022: \u0022San Francisco\u0022, \u0022units\u0022: \u0022celsius\u0022}","item_id":"item-1","name":"get_weather","output_index":0,"sequence_number":6,"type":"response.function_call_arguments.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseFunctionCallArgsDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseFunctionCallArgsDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseFunctionCallArgsDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseFunctionCallArgsDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FunctionCallArgsDoneEventVariant2 { get; init; }
#else
        public object? FunctionCallArgsDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallArgsDoneEventVariant2))]
#endif
        public bool IsFunctionCallArgsDoneEventVariant2 => FunctionCallArgsDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallArgsDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FunctionCallArgsDoneEventVariant2;
            return IsFunctionCallArgsDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickFunctionCallArgsDoneEventVariant2() => FunctionCallArgsDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallArgsDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionCallArgsDoneEvent(global::OpenRouter.BaseFunctionCallArgsDoneEvent value) => new FunctionCallArgsDoneEvent((global::OpenRouter.BaseFunctionCallArgsDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseFunctionCallArgsDoneEvent?(FunctionCallArgsDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public FunctionCallArgsDoneEvent(global::OpenRouter.BaseFunctionCallArgsDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionCallArgsDoneEvent FromBase(global::OpenRouter.BaseFunctionCallArgsDoneEvent? value) => new FunctionCallArgsDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public FunctionCallArgsDoneEvent(
            global::OpenRouter.BaseFunctionCallArgsDoneEvent? @base,
            object? functionCallArgsDoneEventVariant2
            )
        {
            Base = @base;
            FunctionCallArgsDoneEventVariant2 = functionCallArgsDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FunctionCallArgsDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FunctionCallArgsDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsFunctionCallArgsDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseFunctionCallArgsDoneEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? functionCallArgsDoneEventVariant2 = null,
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
            else if (FunctionCallArgsDoneEventVariant2 is { } __value1 && functionCallArgsDoneEventVariant2 != null)
            {
                return functionCallArgsDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseFunctionCallArgsDoneEvent>? @base = null,

            global::System.Action<object>? functionCallArgsDoneEventVariant2 = null,
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
            else if (FunctionCallArgsDoneEventVariant2 is { } __value1)
            {
                functionCallArgsDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseFunctionCallArgsDoneEvent>? @base = null,
            global::System.Action<object>? functionCallArgsDoneEventVariant2 = null,
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
            else if (FunctionCallArgsDoneEventVariant2 is { } __value1)
            {
                functionCallArgsDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseFunctionCallArgsDoneEvent),
                FunctionCallArgsDoneEventVariant2,
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
        public bool Equals(FunctionCallArgsDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseFunctionCallArgsDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FunctionCallArgsDoneEventVariant2, other.FunctionCallArgsDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FunctionCallArgsDoneEvent obj1, FunctionCallArgsDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallArgsDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FunctionCallArgsDoneEvent obj1, FunctionCallArgsDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallArgsDoneEvent o && Equals(o);
        }
    }
}
