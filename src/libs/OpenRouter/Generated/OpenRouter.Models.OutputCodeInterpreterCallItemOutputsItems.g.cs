#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputCodeInterpreterCallItemOutputsItems : global::System.IEquatable<OutputCodeInterpreterCallItemOutputsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? OutputCodeInterpreterCallItemOutputsItems0 { get; init; }
#else
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? OutputCodeInterpreterCallItemOutputsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCodeInterpreterCallItemOutputsItems0))]
#endif
        public bool IsOutputCodeInterpreterCallItemOutputsItems0 => OutputCodeInterpreterCallItemOutputsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputCodeInterpreterCallItemOutputsItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? value)
        {
            value = OutputCodeInterpreterCallItemOutputsItems0;
            return IsOutputCodeInterpreterCallItemOutputsItems0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0 PickOutputCodeInterpreterCallItemOutputsItems0() => IsOutputCodeInterpreterCallItemOutputsItems0
            ? OutputCodeInterpreterCallItemOutputsItems0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCodeInterpreterCallItemOutputsItems0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? OutputCodeInterpreterCallItemOutputsItems1 { get; init; }
#else
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? OutputCodeInterpreterCallItemOutputsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCodeInterpreterCallItemOutputsItems1))]
#endif
        public bool IsOutputCodeInterpreterCallItemOutputsItems1 => OutputCodeInterpreterCallItemOutputsItems1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputCodeInterpreterCallItemOutputsItems1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? value)
        {
            value = OutputCodeInterpreterCallItemOutputsItems1;
            return IsOutputCodeInterpreterCallItemOutputsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1 PickOutputCodeInterpreterCallItemOutputsItems1() => IsOutputCodeInterpreterCallItemOutputsItems1
            ? OutputCodeInterpreterCallItemOutputsItems1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCodeInterpreterCallItemOutputsItems1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputCodeInterpreterCallItemOutputsItems(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0 value) => new OutputCodeInterpreterCallItemOutputsItems((global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0?(OutputCodeInterpreterCallItemOutputsItems @this) => @this.OutputCodeInterpreterCallItemOutputsItems0;

        /// <summary>
        /// 
        /// </summary>
        public OutputCodeInterpreterCallItemOutputsItems(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? value)
        {
            OutputCodeInterpreterCallItemOutputsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputCodeInterpreterCallItemOutputsItems FromOutputCodeInterpreterCallItemOutputsItems0(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? value) => new OutputCodeInterpreterCallItemOutputsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputCodeInterpreterCallItemOutputsItems(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1 value) => new OutputCodeInterpreterCallItemOutputsItems((global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1?(OutputCodeInterpreterCallItemOutputsItems @this) => @this.OutputCodeInterpreterCallItemOutputsItems1;

        /// <summary>
        /// 
        /// </summary>
        public OutputCodeInterpreterCallItemOutputsItems(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? value)
        {
            OutputCodeInterpreterCallItemOutputsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputCodeInterpreterCallItemOutputsItems FromOutputCodeInterpreterCallItemOutputsItems1(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? value) => new OutputCodeInterpreterCallItemOutputsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputCodeInterpreterCallItemOutputsItems(
            global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0? outputCodeInterpreterCallItemOutputsItems0,
            global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1? outputCodeInterpreterCallItemOutputsItems1
            )
        {
            OutputCodeInterpreterCallItemOutputsItems0 = outputCodeInterpreterCallItemOutputsItems0;
            OutputCodeInterpreterCallItemOutputsItems1 = outputCodeInterpreterCallItemOutputsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputCodeInterpreterCallItemOutputsItems1 as object ??
            OutputCodeInterpreterCallItemOutputsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputCodeInterpreterCallItemOutputsItems0?.ToString() ??
            OutputCodeInterpreterCallItemOutputsItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputCodeInterpreterCallItemOutputsItems0 && !IsOutputCodeInterpreterCallItemOutputsItems1 || !IsOutputCodeInterpreterCallItemOutputsItems0 && IsOutputCodeInterpreterCallItemOutputsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0, TResult>? outputCodeInterpreterCallItemOutputsItems0 = null,
            global::System.Func<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1, TResult>? outputCodeInterpreterCallItemOutputsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputCodeInterpreterCallItemOutputsItems0 && outputCodeInterpreterCallItemOutputsItems0 != null)
            {
                return outputCodeInterpreterCallItemOutputsItems0(OutputCodeInterpreterCallItemOutputsItems0!);
            }
            else if (IsOutputCodeInterpreterCallItemOutputsItems1 && outputCodeInterpreterCallItemOutputsItems1 != null)
            {
                return outputCodeInterpreterCallItemOutputsItems1(OutputCodeInterpreterCallItemOutputsItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0>? outputCodeInterpreterCallItemOutputsItems0 = null,

            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1>? outputCodeInterpreterCallItemOutputsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputCodeInterpreterCallItemOutputsItems0)
            {
                outputCodeInterpreterCallItemOutputsItems0?.Invoke(OutputCodeInterpreterCallItemOutputsItems0!);
            }
            else if (IsOutputCodeInterpreterCallItemOutputsItems1)
            {
                outputCodeInterpreterCallItemOutputsItems1?.Invoke(OutputCodeInterpreterCallItemOutputsItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0>? outputCodeInterpreterCallItemOutputsItems0 = null,
            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1>? outputCodeInterpreterCallItemOutputsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputCodeInterpreterCallItemOutputsItems0)
            {
                outputCodeInterpreterCallItemOutputsItems0?.Invoke(OutputCodeInterpreterCallItemOutputsItems0!);
            }
            else if (IsOutputCodeInterpreterCallItemOutputsItems1)
            {
                outputCodeInterpreterCallItemOutputsItems1?.Invoke(OutputCodeInterpreterCallItemOutputsItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputCodeInterpreterCallItemOutputsItems0,
                typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0),
                OutputCodeInterpreterCallItemOutputsItems1,
                typeof(global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1),
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
        public bool Equals(OutputCodeInterpreterCallItemOutputsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems0?>.Default.Equals(OutputCodeInterpreterCallItemOutputsItems0, other.OutputCodeInterpreterCallItemOutputsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCodeInterpreterCallItemOutputsItems1?>.Default.Equals(OutputCodeInterpreterCallItemOutputsItems1, other.OutputCodeInterpreterCallItemOutputsItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputCodeInterpreterCallItemOutputsItems obj1, OutputCodeInterpreterCallItemOutputsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputCodeInterpreterCallItemOutputsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputCodeInterpreterCallItemOutputsItems obj1, OutputCodeInterpreterCallItemOutputsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputCodeInterpreterCallItemOutputsItems o && Equals(o);
        }
    }
}
