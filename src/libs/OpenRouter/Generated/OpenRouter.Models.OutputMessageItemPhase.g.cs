#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The phase of an assistant message. Use `commentary` for an intermediate assistant message and `final_answer` for the final assistant message. For follow-up requests with models like `gpt-5.3-codex` and later, preserve and resend phase on all assistant messages. Omitting it can degrade performance. Not used for user messages.
    /// </summary>
    public readonly partial struct OutputMessageItemPhase : global::System.IEquatable<OutputMessageItemPhase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItemPhase0? OutputMessageItemPhase0 { get; init; }
#else
        public global::OpenRouter.OutputMessageItemPhase0? OutputMessageItemPhase0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItemPhase0))]
#endif
        public bool IsOutputMessageItemPhase0 => OutputMessageItemPhase0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessageItemPhase0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessageItemPhase0? value)
        {
            value = OutputMessageItemPhase0;
            return IsOutputMessageItemPhase0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessageItemPhase0 PickOutputMessageItemPhase0() => IsOutputMessageItemPhase0
            ? OutputMessageItemPhase0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessageItemPhase0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItemPhase1? OutputMessageItemPhase1 { get; init; }
#else
        public global::OpenRouter.OutputMessageItemPhase1? OutputMessageItemPhase1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItemPhase1))]
#endif
        public bool IsOutputMessageItemPhase1 => OutputMessageItemPhase1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessageItemPhase1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessageItemPhase1? value)
        {
            value = OutputMessageItemPhase1;
            return IsOutputMessageItemPhase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessageItemPhase1 PickOutputMessageItemPhase1() => IsOutputMessageItemPhase1
            ? OutputMessageItemPhase1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessageItemPhase1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemPhase(global::OpenRouter.OutputMessageItemPhase0 value) => new OutputMessageItemPhase((global::OpenRouter.OutputMessageItemPhase0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItemPhase0?(OutputMessageItemPhase @this) => @this.OutputMessageItemPhase0;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemPhase(global::OpenRouter.OutputMessageItemPhase0? value)
        {
            OutputMessageItemPhase0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemPhase FromOutputMessageItemPhase0(global::OpenRouter.OutputMessageItemPhase0? value) => new OutputMessageItemPhase(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemPhase(global::OpenRouter.OutputMessageItemPhase1 value) => new OutputMessageItemPhase((global::OpenRouter.OutputMessageItemPhase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItemPhase1?(OutputMessageItemPhase @this) => @this.OutputMessageItemPhase1;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemPhase(global::OpenRouter.OutputMessageItemPhase1? value)
        {
            OutputMessageItemPhase1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemPhase FromOutputMessageItemPhase1(global::OpenRouter.OutputMessageItemPhase1? value) => new OutputMessageItemPhase(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemPhase(
            global::OpenRouter.OutputMessageItemPhase0? outputMessageItemPhase0,
            global::OpenRouter.OutputMessageItemPhase1? outputMessageItemPhase1
            )
        {
            OutputMessageItemPhase0 = outputMessageItemPhase0;
            OutputMessageItemPhase1 = outputMessageItemPhase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessageItemPhase1 as object ??
            OutputMessageItemPhase0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessageItemPhase0?.ToValueString() ??
            OutputMessageItemPhase1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessageItemPhase0 && !IsOutputMessageItemPhase1 || !IsOutputMessageItemPhase0 && IsOutputMessageItemPhase1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessageItemPhase0?, TResult>? outputMessageItemPhase0 = null,
            global::System.Func<global::OpenRouter.OutputMessageItemPhase1?, TResult>? outputMessageItemPhase1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItemPhase0 && outputMessageItemPhase0 != null)
            {
                return outputMessageItemPhase0(OutputMessageItemPhase0!);
            }
            else if (IsOutputMessageItemPhase1 && outputMessageItemPhase1 != null)
            {
                return outputMessageItemPhase1(OutputMessageItemPhase1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessageItemPhase0?>? outputMessageItemPhase0 = null,

            global::System.Action<global::OpenRouter.OutputMessageItemPhase1?>? outputMessageItemPhase1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItemPhase0)
            {
                outputMessageItemPhase0?.Invoke(OutputMessageItemPhase0!);
            }
            else if (IsOutputMessageItemPhase1)
            {
                outputMessageItemPhase1?.Invoke(OutputMessageItemPhase1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputMessageItemPhase0?>? outputMessageItemPhase0 = null,
            global::System.Action<global::OpenRouter.OutputMessageItemPhase1?>? outputMessageItemPhase1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItemPhase0)
            {
                outputMessageItemPhase0?.Invoke(OutputMessageItemPhase0!);
            }
            else if (IsOutputMessageItemPhase1)
            {
                outputMessageItemPhase1?.Invoke(OutputMessageItemPhase1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessageItemPhase0,
                typeof(global::OpenRouter.OutputMessageItemPhase0),
                OutputMessageItemPhase1,
                typeof(global::OpenRouter.OutputMessageItemPhase1),
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
        public bool Equals(OutputMessageItemPhase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItemPhase0?>.Default.Equals(OutputMessageItemPhase0, other.OutputMessageItemPhase0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItemPhase1?>.Default.Equals(OutputMessageItemPhase1, other.OutputMessageItemPhase1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessageItemPhase obj1, OutputMessageItemPhase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessageItemPhase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessageItemPhase obj1, OutputMessageItemPhase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessageItemPhase o && Equals(o);
        }
    }
}
