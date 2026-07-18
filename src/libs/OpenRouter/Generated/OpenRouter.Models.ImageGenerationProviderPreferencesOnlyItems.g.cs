#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageGenerationProviderPreferencesOnlyItems : global::System.IEquatable<ImageGenerationProviderPreferencesOnlyItems>
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
        public string? ImageGenerationProviderPreferencesOnlyItemsVariant2 { get; init; }
#else
        public string? ImageGenerationProviderPreferencesOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationProviderPreferencesOnlyItemsVariant2))]
#endif
        public bool IsImageGenerationProviderPreferencesOnlyItemsVariant2 => ImageGenerationProviderPreferencesOnlyItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGenerationProviderPreferencesOnlyItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ImageGenerationProviderPreferencesOnlyItemsVariant2;
            return IsImageGenerationProviderPreferencesOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickImageGenerationProviderPreferencesOnlyItemsVariant2() => IsImageGenerationProviderPreferencesOnlyItemsVariant2
            ? ImageGenerationProviderPreferencesOnlyItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationProviderPreferencesOnlyItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenerationProviderPreferencesOnlyItems(global::OpenRouter.ProviderName value) => new ImageGenerationProviderPreferencesOnlyItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(ImageGenerationProviderPreferencesOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesOnlyItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageGenerationProviderPreferencesOnlyItems FromProviderName(global::OpenRouter.ProviderName? value) => new ImageGenerationProviderPreferencesOnlyItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenerationProviderPreferencesOnlyItems(string value) => new ImageGenerationProviderPreferencesOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ImageGenerationProviderPreferencesOnlyItems @this) => @this.ImageGenerationProviderPreferencesOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesOnlyItems(string? value)
        {
            ImageGenerationProviderPreferencesOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageGenerationProviderPreferencesOnlyItems FromImageGenerationProviderPreferencesOnlyItemsVariant2(string? value) => new ImageGenerationProviderPreferencesOnlyItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesOnlyItems(
            global::OpenRouter.ProviderName? providerName,
            string? imageGenerationProviderPreferencesOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            ImageGenerationProviderPreferencesOnlyItemsVariant2 = imageGenerationProviderPreferencesOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageGenerationProviderPreferencesOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ImageGenerationProviderPreferencesOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsImageGenerationProviderPreferencesOnlyItemsVariant2 || !IsProviderName && IsImageGenerationProviderPreferencesOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? imageGenerationProviderPreferencesOnlyItemsVariant2 = null,
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
            else if (IsImageGenerationProviderPreferencesOnlyItemsVariant2 && imageGenerationProviderPreferencesOnlyItemsVariant2 != null)
            {
                return imageGenerationProviderPreferencesOnlyItemsVariant2(ImageGenerationProviderPreferencesOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? imageGenerationProviderPreferencesOnlyItemsVariant2 = null,
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
            else if (IsImageGenerationProviderPreferencesOnlyItemsVariant2)
            {
                imageGenerationProviderPreferencesOnlyItemsVariant2?.Invoke(ImageGenerationProviderPreferencesOnlyItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? imageGenerationProviderPreferencesOnlyItemsVariant2 = null,
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
            else if (IsImageGenerationProviderPreferencesOnlyItemsVariant2)
            {
                imageGenerationProviderPreferencesOnlyItemsVariant2?.Invoke(ImageGenerationProviderPreferencesOnlyItemsVariant2!);
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
                ImageGenerationProviderPreferencesOnlyItemsVariant2,
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
        public bool Equals(ImageGenerationProviderPreferencesOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ImageGenerationProviderPreferencesOnlyItemsVariant2, other.ImageGenerationProviderPreferencesOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageGenerationProviderPreferencesOnlyItems obj1, ImageGenerationProviderPreferencesOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenerationProviderPreferencesOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageGenerationProviderPreferencesOnlyItems obj1, ImageGenerationProviderPreferencesOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationProviderPreferencesOnlyItems o && Equals(o);
        }
    }
}
