#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAiResponseInputMessageItemRole : global::System.IEquatable<OpenAiResponseInputMessageItemRole>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemRole0? OpenAiResponseInputMessageItemRole0 { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemRole0? OpenAiResponseInputMessageItemRole0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseInputMessageItemRole0))]
#endif
        public bool IsOpenAiResponseInputMessageItemRole0 => OpenAiResponseInputMessageItemRole0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemRole1? OpenAiResponseInputMessageItemRole1 { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemRole1? OpenAiResponseInputMessageItemRole1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseInputMessageItemRole1))]
#endif
        public bool IsOpenAiResponseInputMessageItemRole1 => OpenAiResponseInputMessageItemRole1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAiResponseInputMessageItemRole2? OpenAiResponseInputMessageItemRole2 { get; init; }
#else
        public global::OpenRouter.OpenAiResponseInputMessageItemRole2? OpenAiResponseInputMessageItemRole2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponseInputMessageItemRole2))]
#endif
        public bool IsOpenAiResponseInputMessageItemRole2 => OpenAiResponseInputMessageItemRole2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemRole(global::OpenRouter.OpenAiResponseInputMessageItemRole0 value) => new OpenAiResponseInputMessageItemRole((global::OpenRouter.OpenAiResponseInputMessageItemRole0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemRole0?(OpenAiResponseInputMessageItemRole @this) => @this.OpenAiResponseInputMessageItemRole0;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemRole(global::OpenRouter.OpenAiResponseInputMessageItemRole0? value)
        {
            OpenAiResponseInputMessageItemRole0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemRole(global::OpenRouter.OpenAiResponseInputMessageItemRole1 value) => new OpenAiResponseInputMessageItemRole((global::OpenRouter.OpenAiResponseInputMessageItemRole1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemRole1?(OpenAiResponseInputMessageItemRole @this) => @this.OpenAiResponseInputMessageItemRole1;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemRole(global::OpenRouter.OpenAiResponseInputMessageItemRole1? value)
        {
            OpenAiResponseInputMessageItemRole1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponseInputMessageItemRole(global::OpenRouter.OpenAiResponseInputMessageItemRole2 value) => new OpenAiResponseInputMessageItemRole((global::OpenRouter.OpenAiResponseInputMessageItemRole2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAiResponseInputMessageItemRole2?(OpenAiResponseInputMessageItemRole @this) => @this.OpenAiResponseInputMessageItemRole2;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemRole(global::OpenRouter.OpenAiResponseInputMessageItemRole2? value)
        {
            OpenAiResponseInputMessageItemRole2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponseInputMessageItemRole(
            global::OpenRouter.OpenAiResponseInputMessageItemRole0? openAiResponseInputMessageItemRole0,
            global::OpenRouter.OpenAiResponseInputMessageItemRole1? openAiResponseInputMessageItemRole1,
            global::OpenRouter.OpenAiResponseInputMessageItemRole2? openAiResponseInputMessageItemRole2
            )
        {
            OpenAiResponseInputMessageItemRole0 = openAiResponseInputMessageItemRole0;
            OpenAiResponseInputMessageItemRole1 = openAiResponseInputMessageItemRole1;
            OpenAiResponseInputMessageItemRole2 = openAiResponseInputMessageItemRole2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAiResponseInputMessageItemRole2 as object ??
            OpenAiResponseInputMessageItemRole1 as object ??
            OpenAiResponseInputMessageItemRole0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAiResponseInputMessageItemRole0?.ToValueString() ??
            OpenAiResponseInputMessageItemRole1?.ToValueString() ??
            OpenAiResponseInputMessageItemRole2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAiResponseInputMessageItemRole0 && !IsOpenAiResponseInputMessageItemRole1 && !IsOpenAiResponseInputMessageItemRole2 || !IsOpenAiResponseInputMessageItemRole0 && IsOpenAiResponseInputMessageItemRole1 && !IsOpenAiResponseInputMessageItemRole2 || !IsOpenAiResponseInputMessageItemRole0 && !IsOpenAiResponseInputMessageItemRole1 && IsOpenAiResponseInputMessageItemRole2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemRole0?, TResult>? openAiResponseInputMessageItemRole0 = null,
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemRole1?, TResult>? openAiResponseInputMessageItemRole1 = null,
            global::System.Func<global::OpenRouter.OpenAiResponseInputMessageItemRole2?, TResult>? openAiResponseInputMessageItemRole2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseInputMessageItemRole0 && openAiResponseInputMessageItemRole0 != null)
            {
                return openAiResponseInputMessageItemRole0(OpenAiResponseInputMessageItemRole0!);
            }
            else if (IsOpenAiResponseInputMessageItemRole1 && openAiResponseInputMessageItemRole1 != null)
            {
                return openAiResponseInputMessageItemRole1(OpenAiResponseInputMessageItemRole1!);
            }
            else if (IsOpenAiResponseInputMessageItemRole2 && openAiResponseInputMessageItemRole2 != null)
            {
                return openAiResponseInputMessageItemRole2(OpenAiResponseInputMessageItemRole2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemRole0?>? openAiResponseInputMessageItemRole0 = null,
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemRole1?>? openAiResponseInputMessageItemRole1 = null,
            global::System.Action<global::OpenRouter.OpenAiResponseInputMessageItemRole2?>? openAiResponseInputMessageItemRole2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponseInputMessageItemRole0)
            {
                openAiResponseInputMessageItemRole0?.Invoke(OpenAiResponseInputMessageItemRole0!);
            }
            else if (IsOpenAiResponseInputMessageItemRole1)
            {
                openAiResponseInputMessageItemRole1?.Invoke(OpenAiResponseInputMessageItemRole1!);
            }
            else if (IsOpenAiResponseInputMessageItemRole2)
            {
                openAiResponseInputMessageItemRole2?.Invoke(OpenAiResponseInputMessageItemRole2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAiResponseInputMessageItemRole0,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole0),
                OpenAiResponseInputMessageItemRole1,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole1),
                OpenAiResponseInputMessageItemRole2,
                typeof(global::OpenRouter.OpenAiResponseInputMessageItemRole2),
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
        public bool Equals(OpenAiResponseInputMessageItemRole other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemRole0?>.Default.Equals(OpenAiResponseInputMessageItemRole0, other.OpenAiResponseInputMessageItemRole0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemRole1?>.Default.Equals(OpenAiResponseInputMessageItemRole1, other.OpenAiResponseInputMessageItemRole1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAiResponseInputMessageItemRole2?>.Default.Equals(OpenAiResponseInputMessageItemRole2, other.OpenAiResponseInputMessageItemRole2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAiResponseInputMessageItemRole obj1, OpenAiResponseInputMessageItemRole obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAiResponseInputMessageItemRole>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAiResponseInputMessageItemRole obj1, OpenAiResponseInputMessageItemRole obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAiResponseInputMessageItemRole o && Equals(o);
        }
    }
}
