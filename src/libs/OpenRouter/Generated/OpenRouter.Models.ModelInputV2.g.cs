#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An input modality of the endpoint: its `params` (the provider document's `supported_inputs`, with the text window as `max_length`), pricing, capacity and passthrough parameters<br/>
    /// Example: {"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}
    /// </summary>
    public readonly partial struct ModelInputV2 : global::System.IEquatable<ModelInputV2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelInputV2Variant1? ModelInputV2Variant1 { get; init; }
#else
        public global::OpenRouter.ModelInputV2Variant1? ModelInputV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelInputV2Variant1))]
#endif
        public bool IsModelInputV2Variant1 => ModelInputV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelInputV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelInputV2Variant1? value)
        {
            value = ModelInputV2Variant1;
            return IsModelInputV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelInputV2Variant1 PickModelInputV2Variant1() => ModelInputV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelInputV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelInputV2Variant2? ModelInputV2Variant2 { get; init; }
#else
        public global::OpenRouter.ModelInputV2Variant2? ModelInputV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelInputV2Variant2))]
#endif
        public bool IsModelInputV2Variant2 => ModelInputV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelInputV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelInputV2Variant2? value)
        {
            value = ModelInputV2Variant2;
            return IsModelInputV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelInputV2Variant2 PickModelInputV2Variant2() => ModelInputV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelInputV2Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelInputV2Variant3? ModelInputV2Variant3 { get; init; }
#else
        public global::OpenRouter.ModelInputV2Variant3? ModelInputV2Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelInputV2Variant3))]
#endif
        public bool IsModelInputV2Variant3 => ModelInputV2Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelInputV2Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelInputV2Variant3? value)
        {
            value = ModelInputV2Variant3;
            return IsModelInputV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelInputV2Variant3 PickModelInputV2Variant3() => ModelInputV2Variant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelInputV2Variant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelInputV2Variant4? ModelInputV2Variant4 { get; init; }
#else
        public global::OpenRouter.ModelInputV2Variant4? ModelInputV2Variant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelInputV2Variant4))]
#endif
        public bool IsModelInputV2Variant4 => ModelInputV2Variant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelInputV2Variant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelInputV2Variant4? value)
        {
            value = ModelInputV2Variant4;
            return IsModelInputV2Variant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelInputV2Variant4 PickModelInputV2Variant4() => ModelInputV2Variant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelInputV2Variant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelInputV2Variant5? ModelInputV2Variant5 { get; init; }
#else
        public global::OpenRouter.ModelInputV2Variant5? ModelInputV2Variant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelInputV2Variant5))]
#endif
        public bool IsModelInputV2Variant5 => ModelInputV2Variant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelInputV2Variant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelInputV2Variant5? value)
        {
            value = ModelInputV2Variant5;
            return IsModelInputV2Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelInputV2Variant5 PickModelInputV2Variant5() => ModelInputV2Variant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelInputV2Variant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelInputV2(global::OpenRouter.ModelInputV2Variant1 value) => new ModelInputV2((global::OpenRouter.ModelInputV2Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelInputV2Variant1?(ModelInputV2 @this) => @this.ModelInputV2Variant1;

        /// <summary>
        ///
        /// </summary>
        public ModelInputV2(global::OpenRouter.ModelInputV2Variant1? value)
        {
            ModelInputV2Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2 FromModelInputV2Variant1(global::OpenRouter.ModelInputV2Variant1? value) => new ModelInputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelInputV2(global::OpenRouter.ModelInputV2Variant2 value) => new ModelInputV2((global::OpenRouter.ModelInputV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelInputV2Variant2?(ModelInputV2 @this) => @this.ModelInputV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public ModelInputV2(global::OpenRouter.ModelInputV2Variant2? value)
        {
            ModelInputV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2 FromModelInputV2Variant2(global::OpenRouter.ModelInputV2Variant2? value) => new ModelInputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelInputV2(global::OpenRouter.ModelInputV2Variant3 value) => new ModelInputV2((global::OpenRouter.ModelInputV2Variant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelInputV2Variant3?(ModelInputV2 @this) => @this.ModelInputV2Variant3;

        /// <summary>
        ///
        /// </summary>
        public ModelInputV2(global::OpenRouter.ModelInputV2Variant3? value)
        {
            ModelInputV2Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2 FromModelInputV2Variant3(global::OpenRouter.ModelInputV2Variant3? value) => new ModelInputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelInputV2(global::OpenRouter.ModelInputV2Variant4 value) => new ModelInputV2((global::OpenRouter.ModelInputV2Variant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelInputV2Variant4?(ModelInputV2 @this) => @this.ModelInputV2Variant4;

        /// <summary>
        ///
        /// </summary>
        public ModelInputV2(global::OpenRouter.ModelInputV2Variant4? value)
        {
            ModelInputV2Variant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2 FromModelInputV2Variant4(global::OpenRouter.ModelInputV2Variant4? value) => new ModelInputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelInputV2(global::OpenRouter.ModelInputV2Variant5 value) => new ModelInputV2((global::OpenRouter.ModelInputV2Variant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelInputV2Variant5?(ModelInputV2 @this) => @this.ModelInputV2Variant5;

        /// <summary>
        ///
        /// </summary>
        public ModelInputV2(global::OpenRouter.ModelInputV2Variant5? value)
        {
            ModelInputV2Variant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2 FromModelInputV2Variant5(global::OpenRouter.ModelInputV2Variant5? value) => new ModelInputV2(value);

        /// <summary>
        ///
        /// </summary>
        public ModelInputV2(
            global::OpenRouter.ModelInputV2Variant1? modelInputV2Variant1,
            global::OpenRouter.ModelInputV2Variant2? modelInputV2Variant2,
            global::OpenRouter.ModelInputV2Variant3? modelInputV2Variant3,
            global::OpenRouter.ModelInputV2Variant4? modelInputV2Variant4,
            global::OpenRouter.ModelInputV2Variant5? modelInputV2Variant5
            )
        {
            ModelInputV2Variant1 = modelInputV2Variant1;
            ModelInputV2Variant2 = modelInputV2Variant2;
            ModelInputV2Variant3 = modelInputV2Variant3;
            ModelInputV2Variant4 = modelInputV2Variant4;
            ModelInputV2Variant5 = modelInputV2Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ModelInputV2Variant5 as object ??
            ModelInputV2Variant4 as object ??
            ModelInputV2Variant3 as object ??
            ModelInputV2Variant2 as object ??
            ModelInputV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ModelInputV2Variant1?.ToString() ??
            ModelInputV2Variant2?.ToString() ??
            ModelInputV2Variant3?.ToString() ??
            ModelInputV2Variant4?.ToString() ??
            ModelInputV2Variant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsModelInputV2Variant1 && !IsModelInputV2Variant2 && !IsModelInputV2Variant3 && !IsModelInputV2Variant4 && !IsModelInputV2Variant5 || !IsModelInputV2Variant1 && IsModelInputV2Variant2 && !IsModelInputV2Variant3 && !IsModelInputV2Variant4 && !IsModelInputV2Variant5 || !IsModelInputV2Variant1 && !IsModelInputV2Variant2 && IsModelInputV2Variant3 && !IsModelInputV2Variant4 && !IsModelInputV2Variant5 || !IsModelInputV2Variant1 && !IsModelInputV2Variant2 && !IsModelInputV2Variant3 && IsModelInputV2Variant4 && !IsModelInputV2Variant5 || !IsModelInputV2Variant1 && !IsModelInputV2Variant2 && !IsModelInputV2Variant3 && !IsModelInputV2Variant4 && IsModelInputV2Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ModelInputV2Variant1, TResult>? modelInputV2Variant1 = null,
            global::System.Func<global::OpenRouter.ModelInputV2Variant2, TResult>? modelInputV2Variant2 = null,
            global::System.Func<global::OpenRouter.ModelInputV2Variant3, TResult>? modelInputV2Variant3 = null,
            global::System.Func<global::OpenRouter.ModelInputV2Variant4, TResult>? modelInputV2Variant4 = null,
            global::System.Func<global::OpenRouter.ModelInputV2Variant5, TResult>? modelInputV2Variant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelInputV2Variant1 is { } __value0 && modelInputV2Variant1 != null)
            {
                return modelInputV2Variant1(__value0);
            }
            else if (ModelInputV2Variant2 is { } __value1 && modelInputV2Variant2 != null)
            {
                return modelInputV2Variant2(__value1);
            }
            else if (ModelInputV2Variant3 is { } __value2 && modelInputV2Variant3 != null)
            {
                return modelInputV2Variant3(__value2);
            }
            else if (ModelInputV2Variant4 is { } __value3 && modelInputV2Variant4 != null)
            {
                return modelInputV2Variant4(__value3);
            }
            else if (ModelInputV2Variant5 is { } __value4 && modelInputV2Variant5 != null)
            {
                return modelInputV2Variant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ModelInputV2Variant1>? modelInputV2Variant1 = null,

            global::System.Action<global::OpenRouter.ModelInputV2Variant2>? modelInputV2Variant2 = null,

            global::System.Action<global::OpenRouter.ModelInputV2Variant3>? modelInputV2Variant3 = null,

            global::System.Action<global::OpenRouter.ModelInputV2Variant4>? modelInputV2Variant4 = null,

            global::System.Action<global::OpenRouter.ModelInputV2Variant5>? modelInputV2Variant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelInputV2Variant1 is { } __value0)
            {
                modelInputV2Variant1?.Invoke(__value0);
            }
            else if (ModelInputV2Variant2 is { } __value1)
            {
                modelInputV2Variant2?.Invoke(__value1);
            }
            else if (ModelInputV2Variant3 is { } __value2)
            {
                modelInputV2Variant3?.Invoke(__value2);
            }
            else if (ModelInputV2Variant4 is { } __value3)
            {
                modelInputV2Variant4?.Invoke(__value3);
            }
            else if (ModelInputV2Variant5 is { } __value4)
            {
                modelInputV2Variant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ModelInputV2Variant1>? modelInputV2Variant1 = null,
            global::System.Action<global::OpenRouter.ModelInputV2Variant2>? modelInputV2Variant2 = null,
            global::System.Action<global::OpenRouter.ModelInputV2Variant3>? modelInputV2Variant3 = null,
            global::System.Action<global::OpenRouter.ModelInputV2Variant4>? modelInputV2Variant4 = null,
            global::System.Action<global::OpenRouter.ModelInputV2Variant5>? modelInputV2Variant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelInputV2Variant1 is { } __value0)
            {
                modelInputV2Variant1?.Invoke(__value0);
            }
            else if (ModelInputV2Variant2 is { } __value1)
            {
                modelInputV2Variant2?.Invoke(__value1);
            }
            else if (ModelInputV2Variant3 is { } __value2)
            {
                modelInputV2Variant3?.Invoke(__value2);
            }
            else if (ModelInputV2Variant4 is { } __value3)
            {
                modelInputV2Variant4?.Invoke(__value3);
            }
            else if (ModelInputV2Variant5 is { } __value4)
            {
                modelInputV2Variant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelInputV2Variant1,
                typeof(global::OpenRouter.ModelInputV2Variant1),
                ModelInputV2Variant2,
                typeof(global::OpenRouter.ModelInputV2Variant2),
                ModelInputV2Variant3,
                typeof(global::OpenRouter.ModelInputV2Variant3),
                ModelInputV2Variant4,
                typeof(global::OpenRouter.ModelInputV2Variant4),
                ModelInputV2Variant5,
                typeof(global::OpenRouter.ModelInputV2Variant5),
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
        public bool Equals(ModelInputV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelInputV2Variant1?>.Default.Equals(ModelInputV2Variant1, other.ModelInputV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelInputV2Variant2?>.Default.Equals(ModelInputV2Variant2, other.ModelInputV2Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelInputV2Variant3?>.Default.Equals(ModelInputV2Variant3, other.ModelInputV2Variant3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelInputV2Variant4?>.Default.Equals(ModelInputV2Variant4, other.ModelInputV2Variant4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelInputV2Variant5?>.Default.Equals(ModelInputV2Variant5, other.ModelInputV2Variant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelInputV2 obj1, ModelInputV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelInputV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelInputV2 obj1, ModelInputV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelInputV2 o && Equals(o);
        }
    }
}
