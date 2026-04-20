#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The input to the generation — either a prompt string or an array of messages
    /// </summary>
    public readonly partial struct GenerationContentDataInput : global::System.IEquatable<GenerationContentDataInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GenerationContentDataInput0? GenerationContentDataInput0 { get; init; }
#else
        public global::OpenRouter.GenerationContentDataInput0? GenerationContentDataInput0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationContentDataInput0))]
#endif
        public bool IsGenerationContentDataInput0 => GenerationContentDataInput0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.GenerationContentDataInput1? GenerationContentDataInput1 { get; init; }
#else
        public global::OpenRouter.GenerationContentDataInput1? GenerationContentDataInput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerationContentDataInput1))]
#endif
        public bool IsGenerationContentDataInput1 => GenerationContentDataInput1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerationContentDataInput(global::OpenRouter.GenerationContentDataInput0 value) => new GenerationContentDataInput((global::OpenRouter.GenerationContentDataInput0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GenerationContentDataInput0?(GenerationContentDataInput @this) => @this.GenerationContentDataInput0;

        /// <summary>
        /// 
        /// </summary>
        public GenerationContentDataInput(global::OpenRouter.GenerationContentDataInput0? value)
        {
            GenerationContentDataInput0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerationContentDataInput(global::OpenRouter.GenerationContentDataInput1 value) => new GenerationContentDataInput((global::OpenRouter.GenerationContentDataInput1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.GenerationContentDataInput1?(GenerationContentDataInput @this) => @this.GenerationContentDataInput1;

        /// <summary>
        /// 
        /// </summary>
        public GenerationContentDataInput(global::OpenRouter.GenerationContentDataInput1? value)
        {
            GenerationContentDataInput1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerationContentDataInput(
            global::OpenRouter.GenerationContentDataInput0? generationContentDataInput0,
            global::OpenRouter.GenerationContentDataInput1? generationContentDataInput1
            )
        {
            GenerationContentDataInput0 = generationContentDataInput0;
            GenerationContentDataInput1 = generationContentDataInput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerationContentDataInput1 as object ??
            GenerationContentDataInput0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerationContentDataInput0?.ToString() ??
            GenerationContentDataInput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerationContentDataInput0 && !IsGenerationContentDataInput1 || !IsGenerationContentDataInput0 && IsGenerationContentDataInput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.GenerationContentDataInput0?, TResult>? generationContentDataInput0 = null,
            global::System.Func<global::OpenRouter.GenerationContentDataInput1?, TResult>? generationContentDataInput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationContentDataInput0 && generationContentDataInput0 != null)
            {
                return generationContentDataInput0(GenerationContentDataInput0!);
            }
            else if (IsGenerationContentDataInput1 && generationContentDataInput1 != null)
            {
                return generationContentDataInput1(GenerationContentDataInput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.GenerationContentDataInput0?>? generationContentDataInput0 = null,
            global::System.Action<global::OpenRouter.GenerationContentDataInput1?>? generationContentDataInput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerationContentDataInput0)
            {
                generationContentDataInput0?.Invoke(GenerationContentDataInput0!);
            }
            else if (IsGenerationContentDataInput1)
            {
                generationContentDataInput1?.Invoke(GenerationContentDataInput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerationContentDataInput0,
                typeof(global::OpenRouter.GenerationContentDataInput0),
                GenerationContentDataInput1,
                typeof(global::OpenRouter.GenerationContentDataInput1),
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
        public bool Equals(GenerationContentDataInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GenerationContentDataInput0?>.Default.Equals(GenerationContentDataInput0, other.GenerationContentDataInput0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.GenerationContentDataInput1?>.Default.Equals(GenerationContentDataInput1, other.GenerationContentDataInput1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerationContentDataInput obj1, GenerationContentDataInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerationContentDataInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerationContentDataInput obj1, GenerationContentDataInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerationContentDataInput o && Equals(o);
        }
    }
}
