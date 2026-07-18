#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
    /// </summary>
    public readonly partial struct OutputMessagePhase : global::System.IEquatable<OutputMessagePhase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessagePhase0? OutputMessagePhase0 { get; init; }
#else
        public global::OpenRouter.OutputMessagePhase0? OutputMessagePhase0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessagePhase0))]
#endif
        public bool IsOutputMessagePhase0 => OutputMessagePhase0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessagePhase0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessagePhase0? value)
        {
            value = OutputMessagePhase0;
            return IsOutputMessagePhase0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessagePhase0 PickOutputMessagePhase0() => IsOutputMessagePhase0
            ? OutputMessagePhase0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessagePhase0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessagePhase1? OutputMessagePhase1 { get; init; }
#else
        public global::OpenRouter.OutputMessagePhase1? OutputMessagePhase1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessagePhase1))]
#endif
        public bool IsOutputMessagePhase1 => OutputMessagePhase1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessagePhase1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessagePhase1? value)
        {
            value = OutputMessagePhase1;
            return IsOutputMessagePhase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessagePhase1 PickOutputMessagePhase1() => IsOutputMessagePhase1
            ? OutputMessagePhase1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessagePhase1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessagePhase(global::OpenRouter.OutputMessagePhase0 value) => new OutputMessagePhase((global::OpenRouter.OutputMessagePhase0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessagePhase0?(OutputMessagePhase @this) => @this.OutputMessagePhase0;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessagePhase(global::OpenRouter.OutputMessagePhase0? value)
        {
            OutputMessagePhase0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessagePhase FromOutputMessagePhase0(global::OpenRouter.OutputMessagePhase0? value) => new OutputMessagePhase(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessagePhase(global::OpenRouter.OutputMessagePhase1 value) => new OutputMessagePhase((global::OpenRouter.OutputMessagePhase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessagePhase1?(OutputMessagePhase @this) => @this.OutputMessagePhase1;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessagePhase(global::OpenRouter.OutputMessagePhase1? value)
        {
            OutputMessagePhase1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessagePhase FromOutputMessagePhase1(global::OpenRouter.OutputMessagePhase1? value) => new OutputMessagePhase(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputMessagePhase(
            global::OpenRouter.OutputMessagePhase0? outputMessagePhase0,
            global::OpenRouter.OutputMessagePhase1? outputMessagePhase1
            )
        {
            OutputMessagePhase0 = outputMessagePhase0;
            OutputMessagePhase1 = outputMessagePhase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessagePhase1 as object ??
            OutputMessagePhase0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessagePhase0?.ToValueString() ??
            OutputMessagePhase1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessagePhase0 && !IsOutputMessagePhase1 || !IsOutputMessagePhase0 && IsOutputMessagePhase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessagePhase0?, TResult>? outputMessagePhase0 = null,
            global::System.Func<global::OpenRouter.OutputMessagePhase1?, TResult>? outputMessagePhase1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessagePhase0 && outputMessagePhase0 != null)
            {
                return outputMessagePhase0(OutputMessagePhase0!);
            }
            else if (IsOutputMessagePhase1 && outputMessagePhase1 != null)
            {
                return outputMessagePhase1(OutputMessagePhase1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessagePhase0?>? outputMessagePhase0 = null,

            global::System.Action<global::OpenRouter.OutputMessagePhase1?>? outputMessagePhase1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessagePhase0)
            {
                outputMessagePhase0?.Invoke(OutputMessagePhase0!);
            }
            else if (IsOutputMessagePhase1)
            {
                outputMessagePhase1?.Invoke(OutputMessagePhase1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputMessagePhase0?>? outputMessagePhase0 = null,
            global::System.Action<global::OpenRouter.OutputMessagePhase1?>? outputMessagePhase1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessagePhase0)
            {
                outputMessagePhase0?.Invoke(OutputMessagePhase0!);
            }
            else if (IsOutputMessagePhase1)
            {
                outputMessagePhase1?.Invoke(OutputMessagePhase1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessagePhase0,
                typeof(global::OpenRouter.OutputMessagePhase0),
                OutputMessagePhase1,
                typeof(global::OpenRouter.OutputMessagePhase1),
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
        public bool Equals(OutputMessagePhase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessagePhase0?>.Default.Equals(OutputMessagePhase0, other.OutputMessagePhase0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessagePhase1?>.Default.Equals(OutputMessagePhase1, other.OutputMessagePhase1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessagePhase obj1, OutputMessagePhase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessagePhase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessagePhase obj1, OutputMessagePhase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessagePhase o && Equals(o);
        }
    }
}
