#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputFunctionCallItemStatus : global::System.IEquatable<OutputFunctionCallItemStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFunctionCallItemStatus0? OutputFunctionCallItemStatus0 { get; init; }
#else
        public global::OpenRouter.OutputFunctionCallItemStatus0? OutputFunctionCallItemStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFunctionCallItemStatus0))]
#endif
        public bool IsOutputFunctionCallItemStatus0 => OutputFunctionCallItemStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputFunctionCallItemStatus0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFunctionCallItemStatus0? value)
        {
            value = OutputFunctionCallItemStatus0;
            return IsOutputFunctionCallItemStatus0;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFunctionCallItemStatus1? OutputFunctionCallItemStatus1 { get; init; }
#else
        public global::OpenRouter.OutputFunctionCallItemStatus1? OutputFunctionCallItemStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFunctionCallItemStatus1))]
#endif
        public bool IsOutputFunctionCallItemStatus1 => OutputFunctionCallItemStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputFunctionCallItemStatus1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFunctionCallItemStatus1? value)
        {
            value = OutputFunctionCallItemStatus1;
            return IsOutputFunctionCallItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFunctionCallItemStatus2? OutputFunctionCallItemStatus2 { get; init; }
#else
        public global::OpenRouter.OutputFunctionCallItemStatus2? OutputFunctionCallItemStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFunctionCallItemStatus2))]
#endif
        public bool IsOutputFunctionCallItemStatus2 => OutputFunctionCallItemStatus2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputFunctionCallItemStatus2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFunctionCallItemStatus2? value)
        {
            value = OutputFunctionCallItemStatus2;
            return IsOutputFunctionCallItemStatus2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFunctionCallItemStatus(global::OpenRouter.OutputFunctionCallItemStatus0 value) => new OutputFunctionCallItemStatus((global::OpenRouter.OutputFunctionCallItemStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItemStatus0?(OutputFunctionCallItemStatus @this) => @this.OutputFunctionCallItemStatus0;

        /// <summary>
        /// 
        /// </summary>
        public OutputFunctionCallItemStatus(global::OpenRouter.OutputFunctionCallItemStatus0? value)
        {
            OutputFunctionCallItemStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFunctionCallItemStatus(global::OpenRouter.OutputFunctionCallItemStatus1 value) => new OutputFunctionCallItemStatus((global::OpenRouter.OutputFunctionCallItemStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItemStatus1?(OutputFunctionCallItemStatus @this) => @this.OutputFunctionCallItemStatus1;

        /// <summary>
        /// 
        /// </summary>
        public OutputFunctionCallItemStatus(global::OpenRouter.OutputFunctionCallItemStatus1? value)
        {
            OutputFunctionCallItemStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputFunctionCallItemStatus(global::OpenRouter.OutputFunctionCallItemStatus2 value) => new OutputFunctionCallItemStatus((global::OpenRouter.OutputFunctionCallItemStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItemStatus2?(OutputFunctionCallItemStatus @this) => @this.OutputFunctionCallItemStatus2;

        /// <summary>
        /// 
        /// </summary>
        public OutputFunctionCallItemStatus(global::OpenRouter.OutputFunctionCallItemStatus2? value)
        {
            OutputFunctionCallItemStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputFunctionCallItemStatus(
            global::OpenRouter.OutputFunctionCallItemStatus0? outputFunctionCallItemStatus0,
            global::OpenRouter.OutputFunctionCallItemStatus1? outputFunctionCallItemStatus1,
            global::OpenRouter.OutputFunctionCallItemStatus2? outputFunctionCallItemStatus2
            )
        {
            OutputFunctionCallItemStatus0 = outputFunctionCallItemStatus0;
            OutputFunctionCallItemStatus1 = outputFunctionCallItemStatus1;
            OutputFunctionCallItemStatus2 = outputFunctionCallItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputFunctionCallItemStatus2 as object ??
            OutputFunctionCallItemStatus1 as object ??
            OutputFunctionCallItemStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputFunctionCallItemStatus0?.ToValueString() ??
            OutputFunctionCallItemStatus1?.ToValueString() ??
            OutputFunctionCallItemStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputFunctionCallItemStatus0 && !IsOutputFunctionCallItemStatus1 && !IsOutputFunctionCallItemStatus2 || !IsOutputFunctionCallItemStatus0 && IsOutputFunctionCallItemStatus1 && !IsOutputFunctionCallItemStatus2 || !IsOutputFunctionCallItemStatus0 && !IsOutputFunctionCallItemStatus1 && IsOutputFunctionCallItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputFunctionCallItemStatus0?, TResult>? outputFunctionCallItemStatus0 = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItemStatus1?, TResult>? outputFunctionCallItemStatus1 = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItemStatus2?, TResult>? outputFunctionCallItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputFunctionCallItemStatus0 && outputFunctionCallItemStatus0 != null)
            {
                return outputFunctionCallItemStatus0(OutputFunctionCallItemStatus0!);
            }
            else if (IsOutputFunctionCallItemStatus1 && outputFunctionCallItemStatus1 != null)
            {
                return outputFunctionCallItemStatus1(OutputFunctionCallItemStatus1!);
            }
            else if (IsOutputFunctionCallItemStatus2 && outputFunctionCallItemStatus2 != null)
            {
                return outputFunctionCallItemStatus2(OutputFunctionCallItemStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputFunctionCallItemStatus0?>? outputFunctionCallItemStatus0 = null,

            global::System.Action<global::OpenRouter.OutputFunctionCallItemStatus1?>? outputFunctionCallItemStatus1 = null,

            global::System.Action<global::OpenRouter.OutputFunctionCallItemStatus2?>? outputFunctionCallItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputFunctionCallItemStatus0)
            {
                outputFunctionCallItemStatus0?.Invoke(OutputFunctionCallItemStatus0!);
            }
            else if (IsOutputFunctionCallItemStatus1)
            {
                outputFunctionCallItemStatus1?.Invoke(OutputFunctionCallItemStatus1!);
            }
            else if (IsOutputFunctionCallItemStatus2)
            {
                outputFunctionCallItemStatus2?.Invoke(OutputFunctionCallItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputFunctionCallItemStatus0?>? outputFunctionCallItemStatus0 = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItemStatus1?>? outputFunctionCallItemStatus1 = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItemStatus2?>? outputFunctionCallItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputFunctionCallItemStatus0)
            {
                outputFunctionCallItemStatus0?.Invoke(OutputFunctionCallItemStatus0!);
            }
            else if (IsOutputFunctionCallItemStatus1)
            {
                outputFunctionCallItemStatus1?.Invoke(OutputFunctionCallItemStatus1!);
            }
            else if (IsOutputFunctionCallItemStatus2)
            {
                outputFunctionCallItemStatus2?.Invoke(OutputFunctionCallItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputFunctionCallItemStatus0,
                typeof(global::OpenRouter.OutputFunctionCallItemStatus0),
                OutputFunctionCallItemStatus1,
                typeof(global::OpenRouter.OutputFunctionCallItemStatus1),
                OutputFunctionCallItemStatus2,
                typeof(global::OpenRouter.OutputFunctionCallItemStatus2),
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
        public bool Equals(OutputFunctionCallItemStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItemStatus0?>.Default.Equals(OutputFunctionCallItemStatus0, other.OutputFunctionCallItemStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItemStatus1?>.Default.Equals(OutputFunctionCallItemStatus1, other.OutputFunctionCallItemStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItemStatus2?>.Default.Equals(OutputFunctionCallItemStatus2, other.OutputFunctionCallItemStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputFunctionCallItemStatus obj1, OutputFunctionCallItemStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputFunctionCallItemStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputFunctionCallItemStatus obj1, OutputFunctionCallItemStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputFunctionCallItemStatus o && Equals(o);
        }
    }
}
