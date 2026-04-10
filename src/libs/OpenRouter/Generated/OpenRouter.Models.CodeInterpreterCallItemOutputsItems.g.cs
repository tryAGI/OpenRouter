#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeInterpreterCallItemOutputsItems : global::System.IEquatable<CodeInterpreterCallItemOutputsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallItemOutputsItems0? CodeInterpreterCallItemOutputsItems0 { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallItemOutputsItems0? CodeInterpreterCallItemOutputsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallItemOutputsItems0))]
#endif
        public bool IsCodeInterpreterCallItemOutputsItems0 => CodeInterpreterCallItemOutputsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallItemOutputsItems1? CodeInterpreterCallItemOutputsItems1 { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallItemOutputsItems1? CodeInterpreterCallItemOutputsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallItemOutputsItems1))]
#endif
        public bool IsCodeInterpreterCallItemOutputsItems1 => CodeInterpreterCallItemOutputsItems1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterCallItemOutputsItems(global::OpenRouter.CodeInterpreterCallItemOutputsItems0 value) => new CodeInterpreterCallItemOutputsItems((global::OpenRouter.CodeInterpreterCallItemOutputsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallItemOutputsItems0?(CodeInterpreterCallItemOutputsItems @this) => @this.CodeInterpreterCallItemOutputsItems0;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterCallItemOutputsItems(global::OpenRouter.CodeInterpreterCallItemOutputsItems0? value)
        {
            CodeInterpreterCallItemOutputsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterCallItemOutputsItems(global::OpenRouter.CodeInterpreterCallItemOutputsItems1 value) => new CodeInterpreterCallItemOutputsItems((global::OpenRouter.CodeInterpreterCallItemOutputsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallItemOutputsItems1?(CodeInterpreterCallItemOutputsItems @this) => @this.CodeInterpreterCallItemOutputsItems1;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterCallItemOutputsItems(global::OpenRouter.CodeInterpreterCallItemOutputsItems1? value)
        {
            CodeInterpreterCallItemOutputsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterCallItemOutputsItems(
            global::OpenRouter.CodeInterpreterCallItemOutputsItems0? codeInterpreterCallItemOutputsItems0,
            global::OpenRouter.CodeInterpreterCallItemOutputsItems1? codeInterpreterCallItemOutputsItems1
            )
        {
            CodeInterpreterCallItemOutputsItems0 = codeInterpreterCallItemOutputsItems0;
            CodeInterpreterCallItemOutputsItems1 = codeInterpreterCallItemOutputsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeInterpreterCallItemOutputsItems1 as object ??
            CodeInterpreterCallItemOutputsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterCallItemOutputsItems0?.ToString() ??
            CodeInterpreterCallItemOutputsItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreterCallItemOutputsItems0 && !IsCodeInterpreterCallItemOutputsItems1 || !IsCodeInterpreterCallItemOutputsItems0 && IsCodeInterpreterCallItemOutputsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.CodeInterpreterCallItemOutputsItems0?, TResult>? codeInterpreterCallItemOutputsItems0 = null,
            global::System.Func<global::OpenRouter.CodeInterpreterCallItemOutputsItems1?, TResult>? codeInterpreterCallItemOutputsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterCallItemOutputsItems0 && codeInterpreterCallItemOutputsItems0 != null)
            {
                return codeInterpreterCallItemOutputsItems0(CodeInterpreterCallItemOutputsItems0!);
            }
            else if (IsCodeInterpreterCallItemOutputsItems1 && codeInterpreterCallItemOutputsItems1 != null)
            {
                return codeInterpreterCallItemOutputsItems1(CodeInterpreterCallItemOutputsItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.CodeInterpreterCallItemOutputsItems0?>? codeInterpreterCallItemOutputsItems0 = null,
            global::System.Action<global::OpenRouter.CodeInterpreterCallItemOutputsItems1?>? codeInterpreterCallItemOutputsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeInterpreterCallItemOutputsItems0)
            {
                codeInterpreterCallItemOutputsItems0?.Invoke(CodeInterpreterCallItemOutputsItems0!);
            }
            else if (IsCodeInterpreterCallItemOutputsItems1)
            {
                codeInterpreterCallItemOutputsItems1?.Invoke(CodeInterpreterCallItemOutputsItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreterCallItemOutputsItems0,
                typeof(global::OpenRouter.CodeInterpreterCallItemOutputsItems0),
                CodeInterpreterCallItemOutputsItems1,
                typeof(global::OpenRouter.CodeInterpreterCallItemOutputsItems1),
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
        public bool Equals(CodeInterpreterCallItemOutputsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallItemOutputsItems0?>.Default.Equals(CodeInterpreterCallItemOutputsItems0, other.CodeInterpreterCallItemOutputsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallItemOutputsItems1?>.Default.Equals(CodeInterpreterCallItemOutputsItems1, other.CodeInterpreterCallItemOutputsItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeInterpreterCallItemOutputsItems obj1, CodeInterpreterCallItemOutputsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallItemOutputsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeInterpreterCallItemOutputsItems obj1, CodeInterpreterCallItemOutputsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallItemOutputsItems o && Equals(o);
        }
    }
}
