#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageConfig : global::System.IEquatable<ImageConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ImageConfigVariant1 { get; init; }
#else
        public string? ImageConfigVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageConfigVariant1))]
#endif
        public bool IsImageConfigVariant1 => ImageConfigVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ImageConfigVariant2 { get; init; }
#else
        public double? ImageConfigVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageConfigVariant2))]
#endif
        public bool IsImageConfigVariant2 => ImageConfigVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? ImageConfigVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? ImageConfigVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageConfigVariant3))]
#endif
        public bool IsImageConfigVariant3 => ImageConfigVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageConfig(string value) => new ImageConfig((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ImageConfig @this) => @this.ImageConfigVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ImageConfig(string? value)
        {
            ImageConfigVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageConfig(double value) => new ImageConfig((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ImageConfig @this) => @this.ImageConfigVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageConfig(double? value)
        {
            ImageConfigVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageConfig(
            string? imageConfigVariant1,
            double? imageConfigVariant2,
            global::System.Collections.Generic.IList<object>? imageConfigVariant3
            )
        {
            ImageConfigVariant1 = imageConfigVariant1;
            ImageConfigVariant2 = imageConfigVariant2;
            ImageConfigVariant3 = imageConfigVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageConfigVariant3 as object ??
            ImageConfigVariant2 as object ??
            ImageConfigVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageConfigVariant1?.ToString() ??
            ImageConfigVariant2?.ToString() ??
            ImageConfigVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageConfigVariant1 && !IsImageConfigVariant2 && !IsImageConfigVariant3 || !IsImageConfigVariant1 && IsImageConfigVariant2 && !IsImageConfigVariant3 || !IsImageConfigVariant1 && !IsImageConfigVariant2 && IsImageConfigVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? imageConfigVariant1 = null,
            global::System.Func<double?, TResult>? imageConfigVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? imageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageConfigVariant1 && imageConfigVariant1 != null)
            {
                return imageConfigVariant1(ImageConfigVariant1!);
            }
            else if (IsImageConfigVariant2 && imageConfigVariant2 != null)
            {
                return imageConfigVariant2(ImageConfigVariant2!);
            }
            else if (IsImageConfigVariant3 && imageConfigVariant3 != null)
            {
                return imageConfigVariant3(ImageConfigVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? imageConfigVariant1 = null,
            global::System.Action<double?>? imageConfigVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? imageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageConfigVariant1)
            {
                imageConfigVariant1?.Invoke(ImageConfigVariant1!);
            }
            else if (IsImageConfigVariant2)
            {
                imageConfigVariant2?.Invoke(ImageConfigVariant2!);
            }
            else if (IsImageConfigVariant3)
            {
                imageConfigVariant3?.Invoke(ImageConfigVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageConfigVariant1,
                typeof(string),
                ImageConfigVariant2,
                typeof(double),
                ImageConfigVariant3,
                typeof(global::System.Collections.Generic.IList<object>),
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
        public bool Equals(ImageConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ImageConfigVariant1, other.ImageConfigVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ImageConfigVariant2, other.ImageConfigVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(ImageConfigVariant3, other.ImageConfigVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageConfig obj1, ImageConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageConfig obj1, ImageConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageConfig o && Equals(o);
        }
    }
}
