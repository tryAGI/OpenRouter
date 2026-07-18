#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PredictionContent : global::System.IEquatable<PredictionContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? PredictionContentVariant1 { get; init; }
#else
        public string? PredictionContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictionContentVariant1))]
#endif
        public bool IsPredictionContentVariant1 => PredictionContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPredictionContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = PredictionContentVariant1;
            return IsPredictionContentVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickPredictionContentVariant1() => IsPredictionContentVariant1
            ? PredictionContentVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PredictionContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? PredictionContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? PredictionContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PredictionContent1))]
#endif
        public bool IsPredictionContent1 => PredictionContent1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPredictionContent1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? value)
        {
            value = PredictionContent1;
            return IsPredictionContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText> PickPredictionContent1() => IsPredictionContent1
            ? PredictionContent1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PredictionContent1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PredictionContent(string value) => new PredictionContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(PredictionContent @this) => @this.PredictionContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PredictionContent(string? value)
        {
            PredictionContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PredictionContent FromPredictionContentVariant1(string? value) => new PredictionContent(value);

        /// <summary>
        /// 
        /// </summary>
        public PredictionContent(
            string? predictionContentVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>? predictionContent1
            )
        {
            PredictionContentVariant1 = predictionContentVariant1;
            PredictionContent1 = predictionContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PredictionContent1 as object ??
            PredictionContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PredictionContentVariant1?.ToString() ??
            PredictionContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPredictionContentVariant1 && !IsPredictionContent1 || !IsPredictionContentVariant1 && IsPredictionContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? predictionContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>, TResult>? predictionContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictionContentVariant1 && predictionContentVariant1 != null)
            {
                return predictionContentVariant1(PredictionContentVariant1!);
            }
            else if (IsPredictionContent1 && predictionContent1 != null)
            {
                return predictionContent1(PredictionContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? predictionContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>>? predictionContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictionContentVariant1)
            {
                predictionContentVariant1?.Invoke(PredictionContentVariant1!);
            }
            else if (IsPredictionContent1)
            {
                predictionContent1?.Invoke(PredictionContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? predictionContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>>? predictionContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPredictionContentVariant1)
            {
                predictionContentVariant1?.Invoke(PredictionContentVariant1!);
            }
            else if (IsPredictionContent1)
            {
                predictionContent1?.Invoke(PredictionContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PredictionContentVariant1,
                typeof(string),
                PredictionContent1,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>),
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
        public bool Equals(PredictionContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(PredictionContentVariant1, other.PredictionContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.PredictionContentText>?>.Default.Equals(PredictionContent1, other.PredictionContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PredictionContent obj1, PredictionContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PredictionContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PredictionContent obj1, PredictionContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PredictionContent o && Equals(o);
        }
    }
}
