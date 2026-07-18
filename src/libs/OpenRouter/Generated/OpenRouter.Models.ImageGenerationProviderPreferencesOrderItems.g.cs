#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ImageGenerationProviderPreferencesOrderItems : global::System.IEquatable<ImageGenerationProviderPreferencesOrderItems>
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
        public string? ImageGenerationProviderPreferencesOrderItemsVariant2 { get; init; }
#else
        public string? ImageGenerationProviderPreferencesOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationProviderPreferencesOrderItemsVariant2))]
#endif
        public bool IsImageGenerationProviderPreferencesOrderItemsVariant2 => ImageGenerationProviderPreferencesOrderItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageGenerationProviderPreferencesOrderItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ImageGenerationProviderPreferencesOrderItemsVariant2;
            return IsImageGenerationProviderPreferencesOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickImageGenerationProviderPreferencesOrderItemsVariant2() => IsImageGenerationProviderPreferencesOrderItemsVariant2
            ? ImageGenerationProviderPreferencesOrderItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationProviderPreferencesOrderItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenerationProviderPreferencesOrderItems(global::OpenRouter.ProviderName value) => new ImageGenerationProviderPreferencesOrderItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(ImageGenerationProviderPreferencesOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesOrderItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageGenerationProviderPreferencesOrderItems FromProviderName(global::OpenRouter.ProviderName? value) => new ImageGenerationProviderPreferencesOrderItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageGenerationProviderPreferencesOrderItems(string value) => new ImageGenerationProviderPreferencesOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ImageGenerationProviderPreferencesOrderItems @this) => @this.ImageGenerationProviderPreferencesOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesOrderItems(string? value)
        {
            ImageGenerationProviderPreferencesOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ImageGenerationProviderPreferencesOrderItems FromImageGenerationProviderPreferencesOrderItemsVariant2(string? value) => new ImageGenerationProviderPreferencesOrderItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ImageGenerationProviderPreferencesOrderItems(
            global::OpenRouter.ProviderName? providerName,
            string? imageGenerationProviderPreferencesOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            ImageGenerationProviderPreferencesOrderItemsVariant2 = imageGenerationProviderPreferencesOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageGenerationProviderPreferencesOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ImageGenerationProviderPreferencesOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsImageGenerationProviderPreferencesOrderItemsVariant2 || !IsProviderName && IsImageGenerationProviderPreferencesOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? imageGenerationProviderPreferencesOrderItemsVariant2 = null,
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
            else if (IsImageGenerationProviderPreferencesOrderItemsVariant2 && imageGenerationProviderPreferencesOrderItemsVariant2 != null)
            {
                return imageGenerationProviderPreferencesOrderItemsVariant2(ImageGenerationProviderPreferencesOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? imageGenerationProviderPreferencesOrderItemsVariant2 = null,
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
            else if (IsImageGenerationProviderPreferencesOrderItemsVariant2)
            {
                imageGenerationProviderPreferencesOrderItemsVariant2?.Invoke(ImageGenerationProviderPreferencesOrderItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? imageGenerationProviderPreferencesOrderItemsVariant2 = null,
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
            else if (IsImageGenerationProviderPreferencesOrderItemsVariant2)
            {
                imageGenerationProviderPreferencesOrderItemsVariant2?.Invoke(ImageGenerationProviderPreferencesOrderItemsVariant2!);
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
                ImageGenerationProviderPreferencesOrderItemsVariant2,
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
        public bool Equals(ImageGenerationProviderPreferencesOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ImageGenerationProviderPreferencesOrderItemsVariant2, other.ImageGenerationProviderPreferencesOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageGenerationProviderPreferencesOrderItems obj1, ImageGenerationProviderPreferencesOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageGenerationProviderPreferencesOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageGenerationProviderPreferencesOrderItems obj1, ImageGenerationProviderPreferencesOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationProviderPreferencesOrderItems o && Equals(o);
        }
    }
}
