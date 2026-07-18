#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PreviewWebSearchUserLocation2 : global::System.IEquatable<PreviewWebSearchUserLocation2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PreviewWebSearchUserLocation? PreviewWebSearchUserLocation { get; init; }
#else
        public global::OpenRouter.PreviewWebSearchUserLocation? PreviewWebSearchUserLocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreviewWebSearchUserLocation))]
#endif
        public bool IsPreviewWebSearchUserLocation => PreviewWebSearchUserLocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPreviewWebSearchUserLocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PreviewWebSearchUserLocation? value)
        {
            value = PreviewWebSearchUserLocation;
            return IsPreviewWebSearchUserLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.PreviewWebSearchUserLocation PickPreviewWebSearchUserLocation() => IsPreviewWebSearchUserLocation
            ? PreviewWebSearchUserLocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreviewWebSearchUserLocation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? LocationVariant2 { get; init; }
#else
        public object? LocationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocationVariant2))]
#endif
        public bool IsLocationVariant2 => LocationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLocationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = LocationVariant2;
            return IsLocationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickLocationVariant2() => IsLocationVariant2
            ? LocationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LocationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreviewWebSearchUserLocation2(global::OpenRouter.PreviewWebSearchUserLocation value) => new PreviewWebSearchUserLocation2((global::OpenRouter.PreviewWebSearchUserLocation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.PreviewWebSearchUserLocation?(PreviewWebSearchUserLocation2 @this) => @this.PreviewWebSearchUserLocation;

        /// <summary>
        /// 
        /// </summary>
        public PreviewWebSearchUserLocation2(global::OpenRouter.PreviewWebSearchUserLocation? value)
        {
            PreviewWebSearchUserLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PreviewWebSearchUserLocation2 FromPreviewWebSearchUserLocation(global::OpenRouter.PreviewWebSearchUserLocation? value) => new PreviewWebSearchUserLocation2(value);

        /// <summary>
        /// 
        /// </summary>
        public PreviewWebSearchUserLocation2(
            global::OpenRouter.PreviewWebSearchUserLocation? previewWebSearchUserLocation,
            object? locationVariant2
            )
        {
            PreviewWebSearchUserLocation = previewWebSearchUserLocation;
            LocationVariant2 = locationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LocationVariant2 as object ??
            PreviewWebSearchUserLocation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PreviewWebSearchUserLocation?.ToString() ??
            LocationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreviewWebSearchUserLocation && !IsLocationVariant2 || !IsPreviewWebSearchUserLocation && IsLocationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.PreviewWebSearchUserLocation, TResult>? previewWebSearchUserLocation = null,
            global::System.Func<object, TResult>? locationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreviewWebSearchUserLocation && previewWebSearchUserLocation != null)
            {
                return previewWebSearchUserLocation(PreviewWebSearchUserLocation!);
            }
            else if (IsLocationVariant2 && locationVariant2 != null)
            {
                return locationVariant2(LocationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.PreviewWebSearchUserLocation>? previewWebSearchUserLocation = null,

            global::System.Action<object>? locationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreviewWebSearchUserLocation)
            {
                previewWebSearchUserLocation?.Invoke(PreviewWebSearchUserLocation!);
            }
            else if (IsLocationVariant2)
            {
                locationVariant2?.Invoke(LocationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.PreviewWebSearchUserLocation>? previewWebSearchUserLocation = null,
            global::System.Action<object>? locationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreviewWebSearchUserLocation)
            {
                previewWebSearchUserLocation?.Invoke(PreviewWebSearchUserLocation!);
            }
            else if (IsLocationVariant2)
            {
                locationVariant2?.Invoke(LocationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PreviewWebSearchUserLocation,
                typeof(global::OpenRouter.PreviewWebSearchUserLocation),
                LocationVariant2,
                typeof(object),
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
        public bool Equals(PreviewWebSearchUserLocation2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PreviewWebSearchUserLocation?>.Default.Equals(PreviewWebSearchUserLocation, other.PreviewWebSearchUserLocation) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(LocationVariant2, other.LocationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PreviewWebSearchUserLocation2 obj1, PreviewWebSearchUserLocation2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreviewWebSearchUserLocation2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PreviewWebSearchUserLocation2 obj1, PreviewWebSearchUserLocation2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreviewWebSearchUserLocation2 o && Equals(o);
        }
    }
}
