#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageGenerationProviderPreferencesIgnoreItems : global::System.IEquatable<ImageGenerationProviderPreferencesIgnoreItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ProviderName? ProviderName { get; init; }
#else
        public global::OpenRouter.ProviderName? ProviderName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderName))]
#endif
        public bool IsProviderName => ProviderName != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProviderName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ProviderName? value)
        {
            value = ProviderName;
            return IsProviderName;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ProviderName PickProviderName() => IsProviderName
            ? ProviderName!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProviderName' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ImageGenerationProviderPreferencesIgnoreItemsVariant2 { get; init; }
#else
        public string? ImageGenerationProviderPreferencesIgnoreItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationProviderPreferencesIgnoreItemsVariant2))]
#endif
        public bool IsImageGenerationProviderPreferencesIgnoreItemsVariant2 => ImageGenerationProviderPreferencesIgnoreItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGenerationProviderPreferencesIgnoreItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ImageGenerationProviderPreferencesIgnoreItemsVariant2;
            return IsImageGenerationProviderPreferencesIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickImageGenerationProviderPreferencesIgnoreItemsVariant2() => IsImageGenerationProviderPreferencesIgnoreItemsVariant2
            ? ImageGenerationProviderPreferencesIgnoreItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationProviderPreferencesIgnoreItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenerationProviderPreferencesIgnoreItems(global::OpenRouter.ProviderName value) => new ImageGenerationProviderPreferencesIgnoreItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(ImageGenerationProviderPreferencesIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesIgnoreItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageGenerationProviderPreferencesIgnoreItems FromProviderName(global::OpenRouter.ProviderName? value) => new ImageGenerationProviderPreferencesIgnoreItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenerationProviderPreferencesIgnoreItems(string value) => new ImageGenerationProviderPreferencesIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ImageGenerationProviderPreferencesIgnoreItems @this) => @this.ImageGenerationProviderPreferencesIgnoreItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesIgnoreItems(string? value)
        {
            ImageGenerationProviderPreferencesIgnoreItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageGenerationProviderPreferencesIgnoreItems FromImageGenerationProviderPreferencesIgnoreItemsVariant2(string? value) => new ImageGenerationProviderPreferencesIgnoreItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesIgnoreItems(
            global::OpenRouter.ProviderName? providerName,
            string? imageGenerationProviderPreferencesIgnoreItemsVariant2
            )
        {
            ProviderName = providerName;
            ImageGenerationProviderPreferencesIgnoreItemsVariant2 = imageGenerationProviderPreferencesIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageGenerationProviderPreferencesIgnoreItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ImageGenerationProviderPreferencesIgnoreItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsImageGenerationProviderPreferencesIgnoreItemsVariant2 || !IsProviderName && IsImageGenerationProviderPreferencesIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? imageGenerationProviderPreferencesIgnoreItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName && providerName != null)
            {
                return providerName(ProviderName!);
            }
            else if (IsImageGenerationProviderPreferencesIgnoreItemsVariant2 && imageGenerationProviderPreferencesIgnoreItemsVariant2 != null)
            {
                return imageGenerationProviderPreferencesIgnoreItemsVariant2(ImageGenerationProviderPreferencesIgnoreItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? imageGenerationProviderPreferencesIgnoreItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsImageGenerationProviderPreferencesIgnoreItemsVariant2)
            {
                imageGenerationProviderPreferencesIgnoreItemsVariant2?.Invoke(ImageGenerationProviderPreferencesIgnoreItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? imageGenerationProviderPreferencesIgnoreItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsImageGenerationProviderPreferencesIgnoreItemsVariant2)
            {
                imageGenerationProviderPreferencesIgnoreItemsVariant2?.Invoke(ImageGenerationProviderPreferencesIgnoreItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProviderName,
                typeof(global::OpenRouter.ProviderName),
                ImageGenerationProviderPreferencesIgnoreItemsVariant2,
                typeof(string),
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
        public bool Equals(ImageGenerationProviderPreferencesIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ImageGenerationProviderPreferencesIgnoreItemsVariant2, other.ImageGenerationProviderPreferencesIgnoreItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageGenerationProviderPreferencesIgnoreItems obj1, ImageGenerationProviderPreferencesIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenerationProviderPreferencesIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageGenerationProviderPreferencesIgnoreItems obj1, ImageGenerationProviderPreferencesIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationProviderPreferencesIgnoreItems o && Equals(o);
        }
    }
}
