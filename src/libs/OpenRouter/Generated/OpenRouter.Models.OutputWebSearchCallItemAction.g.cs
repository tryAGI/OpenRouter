#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputWebSearchCallItemAction : global::System.IEquatable<OutputWebSearchCallItemAction>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchCallItemAction0? OutputWebSearchCallItemAction0 { get; init; }
#else
        public global::OpenRouter.OutputWebSearchCallItemAction0? OutputWebSearchCallItemAction0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchCallItemAction0))]
#endif
        public bool IsOutputWebSearchCallItemAction0 => OutputWebSearchCallItemAction0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputWebSearchCallItemAction0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchCallItemAction0? value)
        {
            value = OutputWebSearchCallItemAction0;
            return IsOutputWebSearchCallItemAction0;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchCallItemAction1? OutputWebSearchCallItemAction1 { get; init; }
#else
        public global::OpenRouter.OutputWebSearchCallItemAction1? OutputWebSearchCallItemAction1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchCallItemAction1))]
#endif
        public bool IsOutputWebSearchCallItemAction1 => OutputWebSearchCallItemAction1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputWebSearchCallItemAction1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchCallItemAction1? value)
        {
            value = OutputWebSearchCallItemAction1;
            return IsOutputWebSearchCallItemAction1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchCallItemAction2? OutputWebSearchCallItemAction2 { get; init; }
#else
        public global::OpenRouter.OutputWebSearchCallItemAction2? OutputWebSearchCallItemAction2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchCallItemAction2))]
#endif
        public bool IsOutputWebSearchCallItemAction2 => OutputWebSearchCallItemAction2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputWebSearchCallItemAction2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchCallItemAction2? value)
        {
            value = OutputWebSearchCallItemAction2;
            return IsOutputWebSearchCallItemAction2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputWebSearchCallItemAction(global::OpenRouter.OutputWebSearchCallItemAction0 value) => new OutputWebSearchCallItemAction((global::OpenRouter.OutputWebSearchCallItemAction0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchCallItemAction0?(OutputWebSearchCallItemAction @this) => @this.OutputWebSearchCallItemAction0;

        /// <summary>
        /// 
        /// </summary>
        public OutputWebSearchCallItemAction(global::OpenRouter.OutputWebSearchCallItemAction0? value)
        {
            OutputWebSearchCallItemAction0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputWebSearchCallItemAction(global::OpenRouter.OutputWebSearchCallItemAction1 value) => new OutputWebSearchCallItemAction((global::OpenRouter.OutputWebSearchCallItemAction1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchCallItemAction1?(OutputWebSearchCallItemAction @this) => @this.OutputWebSearchCallItemAction1;

        /// <summary>
        /// 
        /// </summary>
        public OutputWebSearchCallItemAction(global::OpenRouter.OutputWebSearchCallItemAction1? value)
        {
            OutputWebSearchCallItemAction1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputWebSearchCallItemAction(global::OpenRouter.OutputWebSearchCallItemAction2 value) => new OutputWebSearchCallItemAction((global::OpenRouter.OutputWebSearchCallItemAction2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchCallItemAction2?(OutputWebSearchCallItemAction @this) => @this.OutputWebSearchCallItemAction2;

        /// <summary>
        /// 
        /// </summary>
        public OutputWebSearchCallItemAction(global::OpenRouter.OutputWebSearchCallItemAction2? value)
        {
            OutputWebSearchCallItemAction2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputWebSearchCallItemAction(
            global::OpenRouter.OutputWebSearchCallItemAction0? outputWebSearchCallItemAction0,
            global::OpenRouter.OutputWebSearchCallItemAction1? outputWebSearchCallItemAction1,
            global::OpenRouter.OutputWebSearchCallItemAction2? outputWebSearchCallItemAction2
            )
        {
            OutputWebSearchCallItemAction0 = outputWebSearchCallItemAction0;
            OutputWebSearchCallItemAction1 = outputWebSearchCallItemAction1;
            OutputWebSearchCallItemAction2 = outputWebSearchCallItemAction2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputWebSearchCallItemAction2 as object ??
            OutputWebSearchCallItemAction1 as object ??
            OutputWebSearchCallItemAction0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputWebSearchCallItemAction0?.ToString() ??
            OutputWebSearchCallItemAction1?.ToString() ??
            OutputWebSearchCallItemAction2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputWebSearchCallItemAction0 && !IsOutputWebSearchCallItemAction1 && !IsOutputWebSearchCallItemAction2 || !IsOutputWebSearchCallItemAction0 && IsOutputWebSearchCallItemAction1 && !IsOutputWebSearchCallItemAction2 || !IsOutputWebSearchCallItemAction0 && !IsOutputWebSearchCallItemAction1 && IsOutputWebSearchCallItemAction2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputWebSearchCallItemAction0, TResult>? outputWebSearchCallItemAction0 = null,
            global::System.Func<global::OpenRouter.OutputWebSearchCallItemAction1, TResult>? outputWebSearchCallItemAction1 = null,
            global::System.Func<global::OpenRouter.OutputWebSearchCallItemAction2, TResult>? outputWebSearchCallItemAction2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputWebSearchCallItemAction0 && outputWebSearchCallItemAction0 != null)
            {
                return outputWebSearchCallItemAction0(OutputWebSearchCallItemAction0!);
            }
            else if (IsOutputWebSearchCallItemAction1 && outputWebSearchCallItemAction1 != null)
            {
                return outputWebSearchCallItemAction1(OutputWebSearchCallItemAction1!);
            }
            else if (IsOutputWebSearchCallItemAction2 && outputWebSearchCallItemAction2 != null)
            {
                return outputWebSearchCallItemAction2(OutputWebSearchCallItemAction2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputWebSearchCallItemAction0>? outputWebSearchCallItemAction0 = null,

            global::System.Action<global::OpenRouter.OutputWebSearchCallItemAction1>? outputWebSearchCallItemAction1 = null,

            global::System.Action<global::OpenRouter.OutputWebSearchCallItemAction2>? outputWebSearchCallItemAction2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputWebSearchCallItemAction0)
            {
                outputWebSearchCallItemAction0?.Invoke(OutputWebSearchCallItemAction0!);
            }
            else if (IsOutputWebSearchCallItemAction1)
            {
                outputWebSearchCallItemAction1?.Invoke(OutputWebSearchCallItemAction1!);
            }
            else if (IsOutputWebSearchCallItemAction2)
            {
                outputWebSearchCallItemAction2?.Invoke(OutputWebSearchCallItemAction2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputWebSearchCallItemAction0>? outputWebSearchCallItemAction0 = null,
            global::System.Action<global::OpenRouter.OutputWebSearchCallItemAction1>? outputWebSearchCallItemAction1 = null,
            global::System.Action<global::OpenRouter.OutputWebSearchCallItemAction2>? outputWebSearchCallItemAction2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputWebSearchCallItemAction0)
            {
                outputWebSearchCallItemAction0?.Invoke(OutputWebSearchCallItemAction0!);
            }
            else if (IsOutputWebSearchCallItemAction1)
            {
                outputWebSearchCallItemAction1?.Invoke(OutputWebSearchCallItemAction1!);
            }
            else if (IsOutputWebSearchCallItemAction2)
            {
                outputWebSearchCallItemAction2?.Invoke(OutputWebSearchCallItemAction2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputWebSearchCallItemAction0,
                typeof(global::OpenRouter.OutputWebSearchCallItemAction0),
                OutputWebSearchCallItemAction1,
                typeof(global::OpenRouter.OutputWebSearchCallItemAction1),
                OutputWebSearchCallItemAction2,
                typeof(global::OpenRouter.OutputWebSearchCallItemAction2),
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
        public bool Equals(OutputWebSearchCallItemAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItemAction0?>.Default.Equals(OutputWebSearchCallItemAction0, other.OutputWebSearchCallItemAction0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItemAction1?>.Default.Equals(OutputWebSearchCallItemAction1, other.OutputWebSearchCallItemAction1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItemAction2?>.Default.Equals(OutputWebSearchCallItemAction2, other.OutputWebSearchCallItemAction2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputWebSearchCallItemAction obj1, OutputWebSearchCallItemAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputWebSearchCallItemAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputWebSearchCallItemAction obj1, OutputWebSearchCallItemAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputWebSearchCallItemAction o && Equals(o);
        }
    }
}
